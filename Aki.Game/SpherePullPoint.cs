using System;
using System.Runtime.CompilerServices;

// Token: 0x02002662 RID: 9826
[NullableContext(1)]
[Nullable(0)]
public class SpherePullPoint : IClear
{
	// Token: 0x060189AF RID: 100783 RVA: 0x00775AA2 File Offset: 0x00773CA2
	public bool GetEnable()
	{
		return this.Enable;
	}

	// Token: 0x060189B0 RID: 100784 RVA: 0x00775AAA File Offset: 0x00773CAA
	public void Begin(float moveTime, CharacterActorComponent actorComp)
	{
		this.MoveTime = moveTime;
		this.ActorComp = actorComp;
		this.Enable = true;
		this.ElapsedTime = 0f;
	}

	// Token: 0x060189B1 RID: 100785 RVA: 0x00775ACC File Offset: 0x00773CCC
	public void Advance(float deltaSeconds, ISpherePullTarget target)
	{
		if (this.ActorComp == null || this.ElapsedTime >= this.MoveTime)
		{
			return;
		}
		this.ComputeTargetLocation(target, this.ToLocation);
		float key = (this.MoveTime > 0f) ? (this.ElapsedTime / this.MoveTime) : 1f;
		float delta = (this.MoveTime > 0f) ? (deltaSeconds / this.MoveTime) : 0f;
		float num = MathUtils.Instance.Clamp(target.Curve.GetOffsetRate(key, delta), 0f, 1f);
		bool openMoveLog = BulletConstant.Instance.OpenMoveLog;
		Vector.Lerp(this.ActorComp.ActorLocationProxy, this.ToLocation, (double)num, this.OutLocation);
		this.ActorComp.SetActorLocation(this.OutLocation.ToUeVector(false), "移动.球体牵引", true);
		this.ElapsedTime += deltaSeconds;
	}

	// Token: 0x060189B2 RID: 100786 RVA: 0x00775BB4 File Offset: 0x00773DB4
	private void ComputeTargetLocation(ISpherePullTarget target, Vector @out)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		Vector actorLocationProxy = actorComp.ActorLocationProxy;
		Vector tmpCenter = SpherePullPoint.TmpCenter;
		tmpCenter.DeepCopy(target.Center);
		Vector tmpGravityDown = SpherePullPoint.TmpGravityDown;
		tmpGravityDown.DeepCopy(target.GravityDirection);
		float defaultRadius = actorComp.DefaultRadius;
		float defaultHalfHeight = actorComp.DefaultHalfHeight;
		float num = Math.Max(0f, defaultHalfHeight - defaultRadius);
		tmpGravityDown.Multiply((double)num, SpherePullPoint.TmpOffset);
		actorLocationProxy.Subtraction(SpherePullPoint.TmpOffset, SpherePullPoint.TmpEnd);
		double val = SpherePullPoint.TmpEnd.Subtraction(tmpCenter, SpherePullPoint.TmpDiff).Size();
		actorLocationProxy.Addition(SpherePullPoint.TmpOffset, SpherePullPoint.TmpEnd);
		double val2 = SpherePullPoint.TmpEnd.Subtraction(tmpCenter, SpherePullPoint.TmpDiff).Size();
		@out.DeepCopy(actorLocationProxy);
		double num2 = Math.Max(val, val2) + (double)defaultRadius - (double)target.Radius;
		if (num2 > 0.0)
		{
			Vector vector = tmpCenter.Subtraction(actorLocationProxy, SpherePullPoint.TmpDir);
			double num3 = vector.Size();
			if (num3 > 0.001)
			{
				double num4 = Math.Min(num2, num3);
				vector.Multiply(num4 / num3, vector);
				@out.Addition(vector, @out);
			}
		}
		bool openMoveLog = BulletConstant.Instance.OpenMoveLog;
		double num5 = GravityUtils.Instance.GetZnInGravity(tmpGravityDown, @out) - (double)defaultHalfHeight;
		if (num5 < (double)target.GroundHeight)
		{
			GravityUtils.Instance.AddZnInGravity(tmpGravityDown, @out, (double)target.GroundHeight - num5);
			bool openMoveLog2 = BulletConstant.Instance.OpenMoveLog;
		}
	}

	// Token: 0x060189B3 RID: 100787 RVA: 0x00775D26 File Offset: 0x00773F26
	public void OnEnd()
	{
		this.Enable = false;
		this.ActorComp = null;
	}

	// Token: 0x060189B4 RID: 100788 RVA: 0x00775D36 File Offset: 0x00773F36
	public bool ClearObject()
	{
		this.MoveTime = 0f;
		this.Enable = false;
		this.ElapsedTime = 0f;
		this.ActorComp = null;
		return true;
	}

	// Token: 0x0400D54F RID: 54607
	private const double MIN_PULL_DISTANCE = 0.001;

	// Token: 0x0400D550 RID: 54608
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpCenter = Vector.Create();

	// Token: 0x0400D551 RID: 54609
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpGravityDown = Vector.Create();

	// Token: 0x0400D552 RID: 54610
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpOffset = Vector.Create();

	// Token: 0x0400D553 RID: 54611
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpEnd = Vector.Create();

	// Token: 0x0400D554 RID: 54612
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpDiff = Vector.Create();

	// Token: 0x0400D555 RID: 54613
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpDir = Vector.Create();

	// Token: 0x0400D556 RID: 54614
	public readonly Vector OutLocation = Vector.Create();

	// Token: 0x0400D557 RID: 54615
	private readonly Vector ToLocation = Vector.Create();

	// Token: 0x0400D558 RID: 54616
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D559 RID: 54617
	private bool Enable;

	// Token: 0x0400D55A RID: 54618
	private float MoveTime;

	// Token: 0x0400D55B RID: 54619
	private float ElapsedTime;
}
