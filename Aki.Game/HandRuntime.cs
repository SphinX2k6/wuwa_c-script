using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001E66 RID: 7782
[NullableContext(1)]
[Nullable(0)]
public class HandRuntime
{
	// Token: 0x0600EC96 RID: 60566 RVA: 0x00383D95 File Offset: 0x00381F95
	public void LerpAlphas(double damping, double deltaTime)
	{
		if (this.IkTarget == null)
		{
			return;
		}
		this.IkTarget.Alpha = MathUtils.Instance.InterpTo(this.IkTarget.Alpha, (double)this.TargetAlpha, deltaTime, 1.0 / damping);
	}

	// Token: 0x04006DC3 RID: 28099
	public bool InBind;

	// Token: 0x04006DC4 RID: 28100
	public EHandType HandType;

	// Token: 0x04006DC5 RID: 28101
	public double MaxBendLength;

	// Token: 0x04006DC6 RID: 28102
	public FTransform? CachedClavicle;

	// Token: 0x04006DC7 RID: 28103
	public FTransform? CachedShoulder;

	// Token: 0x04006DC8 RID: 28104
	public FTransform? CachedHand;

	// Token: 0x04006DC9 RID: 28105
	public FTransform? CachedRingFinger;

	// Token: 0x04006DCA RID: 28106
	public Transform RootAfterIk = Transform.Create();

	// Token: 0x04006DCB RID: 28107
	public Transform Clavicle = Transform.Create();

	// Token: 0x04006DCC RID: 28108
	public Transform Shoulder = Transform.Create();

	// Token: 0x04006DCD RID: 28109
	public Transform Hand = Transform.Create();

	// Token: 0x04006DCE RID: 28110
	public Transform RingFinger = Transform.Create();

	// Token: 0x04006DCF RID: 28111
	public Vector FingerLocalPos = Vector.Create();

	// Token: 0x04006DD0 RID: 28112
	public Quat FingerLocalRot = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006DD1 RID: 28113
	public double FingerOffsetSize;

	// Token: 0x04006DD2 RID: 28114
	public Vector AnimBindPos = Vector.Create();

	// Token: 0x04006DD3 RID: 28115
	public Vector AnimBindVec = Vector.Create();

	// Token: 0x04006DD4 RID: 28116
	public double AnimBendLength;

	// Token: 0x04006DD5 RID: 28117
	public Vector AnimHandNormal = Vector.Create();

	// Token: 0x04006DD6 RID: 28118
	public Vector AnimFingerNormal = Vector.Create();

	// Token: 0x04006DD7 RID: 28119
	public Vector ClavicleDir = Vector.Create();

	// Token: 0x04006DD8 RID: 28120
	public Vector BindPos = Vector.Create();

	// Token: 0x04006DD9 RID: 28121
	public Vector BindDir = Vector.Create();

	// Token: 0x04006DDA RID: 28122
	public Vector BindDirSmooth = Vector.Create();

	// Token: 0x04006DDB RID: 28123
	public Vector BindVec = Vector.Create();

	// Token: 0x04006DDC RID: 28124
	public double BendLength;

	// Token: 0x04006DDD RID: 28125
	public Vector FingerNormal = Vector.Create();

	// Token: 0x04006DDE RID: 28126
	public Vector HandNormal = Vector.Create();

	// Token: 0x04006DDF RID: 28127
	public Vector HandPosTarget = Vector.Create();

	// Token: 0x04006DE0 RID: 28128
	public Quat HandRotTarget = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006DE1 RID: 28129
	public float TargetAlpha;

	// Token: 0x04006DE2 RID: 28130
	[Nullable(2)]
	public IkTarget IkTarget = new IkTarget(null, null, null);

	// Token: 0x04006DE3 RID: 28131
	[Nullable(2)]
	public FIKTarget IkTargetUe;

	// Token: 0x04006DE4 RID: 28132
	public Quat BindDirDeltaRot = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006DE5 RID: 28133
	public Quat ArmDeltaRot = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006DE6 RID: 28134
	public Vector ShoulderDir = Vector.Create();

	// Token: 0x04006DE7 RID: 28135
	public Vector ShoulderDirLocal = Vector.Create();

	// Token: 0x04006DE8 RID: 28136
	public Rotator ShoulderLocalEuler = Rotator.Create();

	// Token: 0x04006DE9 RID: 28137
	public Vector BindVecOnNormal = Vector.Create();

	// Token: 0x04006DEA RID: 28138
	public Vector BindDirRootSpace = Vector.Create();

	// Token: 0x04006DEB RID: 28139
	public Rotator BindDirRsEuler = Rotator.Create();
}
