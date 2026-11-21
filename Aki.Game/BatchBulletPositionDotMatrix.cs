using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Utils;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002342 RID: 9026
[NullableContext(2)]
[Nullable(0)]
public class BatchBulletPositionDotMatrix : IBatchBulletPositionShape
{
	// Token: 0x06016358 RID: 90968 RVA: 0x006797D5 File Offset: 0x006779D5
	private BatchBulletPositionDotMatrix()
	{
	}

	// Token: 0x06016359 RID: 90969 RVA: 0x006797E4 File Offset: 0x006779E4
	public void OnBreak()
	{
	}

	// Token: 0x0601635A RID: 90970 RVA: 0x006797E6 File Offset: 0x006779E6
	public void OnEnd()
	{
	}

	// Token: 0x0601635B RID: 90971 RVA: 0x006797E8 File Offset: 0x006779E8
	public UniTask Load()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0601635C RID: 90972 RVA: 0x006797EF File Offset: 0x006779EF
	public float GetDelay()
	{
		return 0f;
	}

	// Token: 0x0601635D RID: 90973 RVA: 0x006797F6 File Offset: 0x006779F6
	public bool IsDestroyOnEnd()
	{
		return false;
	}

	// Token: 0x0601635E RID: 90974 RVA: 0x006797F9 File Offset: 0x006779F9
	public bool IsSummonChildBullet()
	{
		return false;
	}

	// Token: 0x0601635F RID: 90975 RVA: 0x006797FC File Offset: 0x006779FC
	[NullableContext(1)]
	public static BatchBulletPositionDotMatrix Create(CharacterCustomValueComponent customValueComp, SBatchBulletPositionPointMatrix config)
	{
		BatchBulletPositionDotMatrix batchBulletPositionDotMatrix = new BatchBulletPositionDotMatrix();
		batchBulletPositionDotMatrix.FromUeConfig(customValueComp, config);
		return batchBulletPositionDotMatrix;
	}

	// Token: 0x06016360 RID: 90976 RVA: 0x0067980C File Offset: 0x00677A0C
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

	// Token: 0x06016361 RID: 90977 RVA: 0x006798F0 File Offset: 0x00677AF0
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

	// Token: 0x06016362 RID: 90978 RVA: 0x006799C6 File Offset: 0x00677BC6
	public Vector ToTargetLocation(Transform transform)
	{
		return null;
	}

	// Token: 0x0400BB4E RID: 47950
	public Vector Center;

	// Token: 0x0400BB4F RID: 47951
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Vector> PositionOffset;

	// Token: 0x0400BB50 RID: 47952
	public double PositionOffsetScale;

	// Token: 0x0400BB51 RID: 47953
	public Rotator Rotator;

	// Token: 0x0400BB52 RID: 47954
	public Rotator RotatorOffset;

	// Token: 0x0400BB53 RID: 47955
	public EBatchBulletBeginRotator BeginRotator = EBatchBulletBeginRotator.切线方向;
}
