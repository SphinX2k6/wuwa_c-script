using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Utils;
using Cysharp.Threading.Tasks;

// Token: 0x02002DE6 RID: 11750
[NullableContext(2)]
[Nullable(0)]
public class BatchBulletPositionCircle : IBatchBulletPositionShape
{
	// Token: 0x06018AA0 RID: 101024 RVA: 0x0065341A File Offset: 0x0065161A
	private BatchBulletPositionCircle()
	{
	}

	// Token: 0x06018AA1 RID: 101025 RVA: 0x0065343B File Offset: 0x0065163B
	public bool IsDestroyOnEnd()
	{
		return false;
	}

	// Token: 0x06018AA2 RID: 101026 RVA: 0x0065343E File Offset: 0x0065163E
	public bool IsSummonChildBullet()
	{
		return false;
	}

	// Token: 0x06018AA3 RID: 101027 RVA: 0x00653441 File Offset: 0x00651641
	public float GetDelay()
	{
		return 0f;
	}

	// Token: 0x06018AA4 RID: 101028 RVA: 0x00653448 File Offset: 0x00651648
	public void OnBreak()
	{
	}

	// Token: 0x06018AA5 RID: 101029 RVA: 0x0065344A File Offset: 0x0065164A
	public void OnEnd()
	{
	}

	// Token: 0x06018AA6 RID: 101030 RVA: 0x0065344C File Offset: 0x0065164C
	public UniTask Load()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06018AA7 RID: 101031 RVA: 0x00653453 File Offset: 0x00651653
	[NullableContext(1)]
	public static BatchBulletPositionCircle Create(CharacterCustomValueComponent customValueComp, SBatchBulletPositionCircle config)
	{
		BatchBulletPositionCircle batchBulletPositionCircle = new BatchBulletPositionCircle();
		batchBulletPositionCircle.FromUeConfig(customValueComp, config);
		return batchBulletPositionCircle;
	}

	// Token: 0x06018AA8 RID: 101032 RVA: 0x00653464 File Offset: 0x00651664
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

	// Token: 0x06018AA9 RID: 101033 RVA: 0x006535A0 File Offset: 0x006517A0
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

	// Token: 0x06018AAA RID: 101034 RVA: 0x00653688 File Offset: 0x00651888
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

	// Token: 0x0400B7BF RID: 47039
	public double AngleInterval;

	// Token: 0x0400B7C0 RID: 47040
	public Vector Center;

	// Token: 0x0400B7C1 RID: 47041
	public bool Clockwise = true;

	// Token: 0x0400B7C2 RID: 47042
	[Nullable(1)]
	public Vector Forward = Vector.Create();

	// Token: 0x0400B7C3 RID: 47043
	public double Radius;

	// Token: 0x0400B7C4 RID: 47044
	public double BeginAngle;

	// Token: 0x0400B7C5 RID: 47045
	public EBatchBulletBeginRotator BeginRotator = EBatchBulletBeginRotator.切线方向;

	// Token: 0x0400B7C6 RID: 47046
	public double DistToTarget;

	// Token: 0x0400B7C7 RID: 47047
	public Vector StartPos;
}
