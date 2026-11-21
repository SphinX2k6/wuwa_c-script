using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001328 RID: 4904
[NullableContext(1)]
[Nullable(0)]
public class HandRuntime
{
	// Token: 0x0600C0B5 RID: 49333 RVA: 0x0038FA51 File Offset: 0x0038DC51
	public void LerpAlphas(double damping, double deltaTime)
	{
		if (this.IkTarget == null)
		{
			return;
		}
		this.IkTarget.Alpha = MathUtils.Instance.InterpTo(this.IkTarget.Alpha, (double)this.TargetAlpha, deltaTime, 1.0 / damping);
	}

	// Token: 0x04006EA4 RID: 28324
	public bool InBind;

	// Token: 0x04006EA5 RID: 28325
	public EHandType HandType;

	// Token: 0x04006EA6 RID: 28326
	public double MaxBendLength;

	// Token: 0x04006EA7 RID: 28327
	public FTransform? CachedClavicle;

	// Token: 0x04006EA8 RID: 28328
	public FTransform? CachedShoulder;

	// Token: 0x04006EA9 RID: 28329
	public FTransform? CachedHand;

	// Token: 0x04006EAA RID: 28330
	public FTransform? CachedRingFinger;

	// Token: 0x04006EAB RID: 28331
	public Transform RootAfterIk = Transform.Create();

	// Token: 0x04006EAC RID: 28332
	public Transform Clavicle = Transform.Create();

	// Token: 0x04006EAD RID: 28333
	public Transform Shoulder = Transform.Create();

	// Token: 0x04006EAE RID: 28334
	public Transform Hand = Transform.Create();

	// Token: 0x04006EAF RID: 28335
	public Transform RingFinger = Transform.Create();

	// Token: 0x04006EB0 RID: 28336
	public Vector FingerLocalPos = Vector.Create();

	// Token: 0x04006EB1 RID: 28337
	public Quat FingerLocalRot = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006EB2 RID: 28338
	public double FingerOffsetSize;

	// Token: 0x04006EB3 RID: 28339
	public Vector AnimBindPos = Vector.Create();

	// Token: 0x04006EB4 RID: 28340
	public Vector AnimBindVec = Vector.Create();

	// Token: 0x04006EB5 RID: 28341
	public double AnimBendLength;

	// Token: 0x04006EB6 RID: 28342
	public Vector AnimHandNormal = Vector.Create();

	// Token: 0x04006EB7 RID: 28343
	public Vector AnimFingerNormal = Vector.Create();

	// Token: 0x04006EB8 RID: 28344
	public Vector ClavicleDir = Vector.Create();

	// Token: 0x04006EB9 RID: 28345
	public Vector BindPos = Vector.Create();

	// Token: 0x04006EBA RID: 28346
	public Vector BindDir = Vector.Create();

	// Token: 0x04006EBB RID: 28347
	public Vector BindDirSmooth = Vector.Create();

	// Token: 0x04006EBC RID: 28348
	public Vector BindVec = Vector.Create();

	// Token: 0x04006EBD RID: 28349
	public double BendLength;

	// Token: 0x04006EBE RID: 28350
	public Vector FingerNormal = Vector.Create();

	// Token: 0x04006EBF RID: 28351
	public Vector HandNormal = Vector.Create();

	// Token: 0x04006EC0 RID: 28352
	public Vector HandPosTarget = Vector.Create();

	// Token: 0x04006EC1 RID: 28353
	public Quat HandRotTarget = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006EC2 RID: 28354
	public float TargetAlpha;

	// Token: 0x04006EC3 RID: 28355
	[Nullable(2)]
	public IkTarget IkTarget = new IkTarget(null, null, null);

	// Token: 0x04006EC4 RID: 28356
	[Nullable(2)]
	public FIKTarget IkTargetUe;

	// Token: 0x04006EC5 RID: 28357
	public Quat BindDirDeltaRot = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006EC6 RID: 28358
	public Quat ArmDeltaRot = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006EC7 RID: 28359
	public Vector ShoulderDir = Vector.Create();

	// Token: 0x04006EC8 RID: 28360
	public Vector ShoulderDirLocal = Vector.Create();

	// Token: 0x04006EC9 RID: 28361
	public Rotator ShoulderLocalEuler = Rotator.Create();

	// Token: 0x04006ECA RID: 28362
	public Vector BindVecOnNormal = Vector.Create();

	// Token: 0x04006ECB RID: 28363
	public Vector BindDirRootSpace = Vector.Create();

	// Token: 0x04006ECC RID: 28364
	public Rotator BindDirRsEuler = Rotator.Create();
}
