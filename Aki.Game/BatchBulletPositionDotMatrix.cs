using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Utils;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002DE7 RID: 11751
[NullableContext(2)]
[Nullable(0)]
public class BatchBulletPositionDotMatrix : IBatchBulletPositionShape
{
	// Token: 0x06018AAB RID: 101035 RVA: 0x006536F5 File Offset: 0x006518F5
	private BatchBulletPositionDotMatrix()
	{
	}

	// Token: 0x06018AAC RID: 101036 RVA: 0x00653704 File Offset: 0x00651904
	public void OnBreak()
	{
	}

	// Token: 0x06018AAD RID: 101037 RVA: 0x00653706 File Offset: 0x00651906
	public void OnEnd()
	{
	}

	// Token: 0x06018AAE RID: 101038 RVA: 0x00653708 File Offset: 0x00651908
	public UniTask Load()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06018AAF RID: 101039 RVA: 0x0065370F File Offset: 0x0065190F
	public float GetDelay()
	{
		return 0f;
	}

	// Token: 0x06018AB0 RID: 101040 RVA: 0x00653716 File Offset: 0x00651916
	public bool IsDestroyOnEnd()
	{
		return false;
	}

	// Token: 0x06018AB1 RID: 101041 RVA: 0x00653719 File Offset: 0x00651919
	public bool IsSummonChildBullet()
	{
		return false;
	}

	// Token: 0x06018AB2 RID: 101042 RVA: 0x0065371C File Offset: 0x0065191C
	[NullableContext(1)]
	public static BatchBulletPositionDotMatrix Create(CharacterCustomValueComponent customValueComp, SBatchBulletPositionPointMatrix config)
	{
		BatchBulletPositionDotMatrix batchBulletPositionDotMatrix = new BatchBulletPositionDotMatrix();
		batchBulletPositionDotMatrix.FromUeConfig(customValueComp, config);
		return batchBulletPositionDotMatrix;
	}

	// Token: 0x06018AB3 RID: 101043 RVA: 0x0065372C File Offset: 0x0065192C
	[NullableContext(1)]
	public void FromUeConfig(CharacterCustomValueComponent customValueComp, SBatchBulletPositionPointMatrix config)
	{
		Vector vector;
		this.Center = (customValueComp.GetBlackboard(config.CenterKey, default(TFormulaValue)).TryGetVector(out vector) ? vector : null);
		this.PositionOffset = new List<Vector>();
		TArray<FVector> positionOffset = config.PositionOffset;
		int num = positionOffset.Num();
		for (int i = 0; i < num; i++)
		{
			this.PositionOffset.Add(Vector.Create(positionOffset.Get(i)));
		}
		this.PositionOffsetScale = (double)config.PositionOffsetScale;
		Rotator rotator;
		this.Rotator = (customValueComp.GetBlackboard(config.RotatorKey, default(TFormulaValue)).TryGetRotator(out rotator) ? rotator : null);
		this.RotatorOffset = Rotator.Create(config.RotatorOffset);
		this.BeginRotator = config.BeginRotator;
	}

	// Token: 0x06018AB4 RID: 101044 RVA: 0x00653810 File Offset: 0x00651A10
	public Transform ToTransform(int index)
	{
		if (this.PositionOffset.Count <= index)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.HCW, "批量生成子弹失败，生成子弹数量超出 位置偏移 数量", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		Transform transform = Transform.Create();
		transform.SetLocation(this.Center);
		transform.SetRotation(this.Rotator.Quaternion(null));
		Vector vector = this.PositionOffset[index];
		Vector vector2 = Vector.Create();
		vector.Multiply(this.PositionOffsetScale, vector2);
		transform.TransformPosition(vector2, vector2);
		transform.SetLocation(vector2);
		if (this.BeginRotator == EBatchBulletBeginRotator.切线方向)
		{
			vector2.SubtractionEqual(this.Center);
			vector2.Normalize(9.99999993922529E-09);
			Rotator rotator = Rotator.Create();
			vector2.Rotation(rotator);
			MathUtils.Instance.ComposeRotator(rotator, this.RotatorOffset, transform.GetRotation());
		}
		return transform;
	}

	// Token: 0x06018AB5 RID: 101045 RVA: 0x006538E6 File Offset: 0x00651AE6
	public Vector ToTargetLocation(Transform transform)
	{
		return null;
	}

	// Token: 0x0400B7C8 RID: 47048
	public Vector Center;

	// Token: 0x0400B7C9 RID: 47049
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Vector> PositionOffset;

	// Token: 0x0400B7CA RID: 47050
	public double PositionOffsetScale;

	// Token: 0x0400B7CB RID: 47051
	public Rotator Rotator;

	// Token: 0x0400B7CC RID: 47052
	public Rotator RotatorOffset;

	// Token: 0x0400B7CD RID: 47053
	public EBatchBulletBeginRotator BeginRotator = EBatchBulletBeginRotator.切线方向;
}
