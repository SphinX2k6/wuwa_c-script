using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Utils;
using Cysharp.Threading.Tasks;

// Token: 0x02002341 RID: 9025
[NullableContext(2)]
[Nullable(0)]
public class BatchBulletPositionCircle : IBatchBulletPositionShape
{
	// Token: 0x0601634D RID: 90957 RVA: 0x006794FA File Offset: 0x006776FA
	private BatchBulletPositionCircle()
	{
	}

	// Token: 0x0601634E RID: 90958 RVA: 0x0067951B File Offset: 0x0067771B
	public bool IsDestroyOnEnd()
	{
		return false;
	}

	// Token: 0x0601634F RID: 90959 RVA: 0x0067951E File Offset: 0x0067771E
	public bool IsSummonChildBullet()
	{
		return false;
	}

	// Token: 0x06016350 RID: 90960 RVA: 0x00679521 File Offset: 0x00677721
	public float GetDelay()
	{
		return 0f;
	}

	// Token: 0x06016351 RID: 90961 RVA: 0x00679528 File Offset: 0x00677728
	public void OnBreak()
	{
	}

	// Token: 0x06016352 RID: 90962 RVA: 0x0067952A File Offset: 0x0067772A
	public void OnEnd()
	{
	}

	// Token: 0x06016353 RID: 90963 RVA: 0x0067952C File Offset: 0x0067772C
	public UniTask Load()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06016354 RID: 90964 RVA: 0x00679533 File Offset: 0x00677733
	[NullableContext(1)]
	public static BatchBulletPositionCircle Create(CharacterCustomValueComponent customValueComp, SBatchBulletPositionCircle config)
	{
		BatchBulletPositionCircle batchBulletPositionCircle = new BatchBulletPositionCircle();
		batchBulletPositionCircle.FromUeConfig(customValueComp, config);
		return batchBulletPositionCircle;
	}

	// Token: 0x06016355 RID: 90965 RVA: 0x00679544 File Offset: 0x00677744
	[NullableContext(1)]
	public void FromUeConfig(CharacterCustomValueComponent customValueComp, SBatchBulletPositionCircle config)
	{
		this.AngleInterval = (double)customValueComp.GetBlackboard(config.AngleIntervalKey, TFormulaValue.FromDouble(0.0));
		Vector vector;
		this.Center = (customValueComp.GetBlackboard(config.CenterKey, default(TFormulaValue)).TryGetVector(out vector) ? vector : null);
		this.Clockwise = config.Clockwise;
		Rotator rotator2;
		Rotator rotator = customValueComp.GetBlackboard(config.ForwardKey, default(TFormulaValue)).TryGetRotator(out rotator2) ? rotator2 : null;
		if (rotator != null)
		{
			rotator.Vector(this.Forward);
		}
		this.Radius = (double)customValueComp.GetBlackboard(config.RadiusKey, TFormulaValue.FromDouble(0.0));
		this.BeginAngle = (double)config.BeginAngle;
		this.BeginRotator = config.BeginRotator;
		this.DistToTarget = (double)customValueComp.GetBlackboard(config.DistToTarget, TFormulaValue.FromDouble(0.0));
		Vector vector2;
		this.StartPos = (customValueComp.GetBlackboard(config.StartPosKey, default(TFormulaValue)).TryGetVector(out vector2) ? vector2 : null);
	}

	// Token: 0x06016356 RID: 90966 RVA: 0x00679680 File Offset: 0x00677880
	public Transform ToTransform(int index)
	{
		Transform transform = Transform.Create();
		transform.SetLocation(this.Center);
		Vector vector = Vector.Create();
		double num = this.BeginAngle + (double)index * this.AngleInterval * (double)(this.Clockwise ? 1 : -1);
		this.Forward.RotateAngleAxis(num, Vector.UpVectorProxy, vector);
		vector.MultiplyEqual(this.Radius);
		transform.GetLocation().AdditionEqual(vector);
		if (this.BeginRotator == EBatchBulletBeginRotator.切线方向)
		{
			this.Forward.RotateAngleAxis(num + 90.0, Vector.UpVectorProxy, vector);
			Rotator rotator = Rotator.Create();
			vector.Rotation(rotator);
			rotator.Quaternion(transform.GetRotation());
		}
		else if (this.BeginRotator == EBatchBulletBeginRotator.法线方向)
		{
			Rotator rotator2 = Rotator.Create();
			vector.Normalize(9.99999993922529E-09);
			vector.Rotation(rotator2);
			rotator2.Quaternion(transform.GetRotation());
		}
		return transform;
	}

	// Token: 0x06016357 RID: 90967 RVA: 0x00679768 File Offset: 0x00677968
	public Vector ToTargetLocation(Transform transform)
	{
		if (transform == null || Math.Abs(this.DistToTarget) < 1E-08)
		{
			return null;
		}
		Vector vector = Vector.Create();
		transform.GetRotation().GetForwardVector(vector);
		vector.MultiplyEqual(this.DistToTarget);
		if (this.StartPos != null)
		{
			vector.AdditionEqual(this.StartPos);
		}
		else
		{
			vector.AdditionEqual(transform.GetLocation());
		}
		return vector;
	}

	// Token: 0x0400BB45 RID: 47941
	public double AngleInterval;

	// Token: 0x0400BB46 RID: 47942
	public Vector Center;

	// Token: 0x0400BB47 RID: 47943
	public bool Clockwise = true;

	// Token: 0x0400BB48 RID: 47944
	[Nullable(1)]
	public Vector Forward = Vector.Create();

	// Token: 0x0400BB49 RID: 47945
	public double Radius;

	// Token: 0x0400BB4A RID: 47946
	public double BeginAngle;

	// Token: 0x0400BB4B RID: 47947
	public EBatchBulletBeginRotator BeginRotator = EBatchBulletBeginRotator.切线方向;

	// Token: 0x0400BB4C RID: 47948
	public double DistToTarget;

	// Token: 0x0400BB4D RID: 47949
	public Vector StartPos;
}
