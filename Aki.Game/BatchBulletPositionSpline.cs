using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.PathLine.PathLine_Bullet;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002DE8 RID: 11752
[NullableContext(2)]
[Nullable(0)]
public class BatchBulletPositionSpline : IBatchBulletPositionShape
{
	// Token: 0x06018AB6 RID: 101046 RVA: 0x006538E9 File Offset: 0x00651AE9
	[NullableContext(1)]
	public static BatchBulletPositionSpline Create(CharacterCustomValueComponent customValueComp, SBatchBulletPositionSpline config, SkillBehaviorBatchBulletTask taskContext)
	{
		BatchBulletPositionSpline batchBulletPositionSpline = new BatchBulletPositionSpline();
		batchBulletPositionSpline.FromUeConfig(customValueComp, config);
		batchBulletPositionSpline.Intervals = taskContext.GetInterval();
		batchBulletPositionSpline.Context = taskContext;
		return batchBulletPositionSpline;
	}

	// Token: 0x06018AB7 RID: 101047 RVA: 0x0065390B File Offset: 0x00651B0B
	private BatchBulletPositionSpline()
	{
	}

	// Token: 0x06018AB8 RID: 101048 RVA: 0x00653914 File Offset: 0x00651B14
	[NullableContext(1)]
	private void FromUeConfig(CharacterCustomValueComponent customValueComp, SBatchBulletPositionSpline spline)
	{
		this.SplineClassPath = spline.SplineClass.ToAssetPathName();
		Vector vector;
		this.Start = (customValueComp.GetBlackboard(spline.StartKey, default(TFormulaValue)).TryGetVector(out vector) ? vector : null);
		if (StringUtils.IsBlank(spline.EndKey.ToString()))
		{
			Rotator rotator;
			this.Rotator = (customValueComp.GetBlackboard(spline.RotatorKey, default(TFormulaValue)).TryGetRotator(out rotator) ? rotator : null);
		}
		else
		{
			Vector vector2;
			this.End = (customValueComp.GetBlackboard(spline.EndKey, default(TFormulaValue)).TryGetVector(out vector2) ? vector2 : null);
		}
		this.Duration = (float)customValueComp.GetBlackboard(spline.DurationKey, TFormulaValue.FromFloat(0f));
		this.Delay = spline.Delay;
		this.PathEffectOnEnd = spline.EffectOfEnd.ToAssetPathName();
		this.BulletIdOnEnd = spline.BulletIdOfEnd;
		this.DestroyOnEnd = spline.DestroyAllOnEnd;
		this.BulletIdOnBreak = spline.BulletIdOnBreak;
		this.PathEffectOnBreak = spline.EffectOnBreak.ToAssetPathName();
		this.SummonChildBullet = spline.DestroySummonBullet;
	}

	// Token: 0x06018AB9 RID: 101049 RVA: 0x00653A4C File Offset: 0x00651C4C
	public UniTask Load()
	{
		BatchBulletPositionSpline.<Load>d__19 <Load>d__;
		<Load>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Load>d__.<>4__this = this;
		<Load>d__.<>1__state = -1;
		<Load>d__.<>t__builder.Start<BatchBulletPositionSpline.<Load>d__19>(ref <Load>d__);
		return <Load>d__.<>t__builder.Task;
	}

	// Token: 0x06018ABA RID: 101050 RVA: 0x00653A8F File Offset: 0x00651C8F
	public void OnBreak()
	{
		this.OnSplineFinish(this.PathEffectOnBreak, this.BulletIdOnBreak);
	}

	// Token: 0x06018ABB RID: 101051 RVA: 0x00653AA3 File Offset: 0x00651CA3
	public void OnEnd()
	{
		this.OnSplineFinish(this.PathEffectOnEnd, this.BulletIdOnEnd);
	}

	// Token: 0x06018ABC RID: 101052 RVA: 0x00653AB8 File Offset: 0x00651CB8
	private void OnSplineFinish(string pathEffect, string bulletId)
	{
		bool flag = StringUtils.IsBlank(pathEffect);
		bool flag2 = StringUtils.IsBlank(bulletId);
		if (flag && flag2)
		{
			ActorSystem.Instance.Put("样条曲线批量子弹", this.Spline, null);
			this.Spline = null;
			this.SplineComp = null;
			return;
		}
		USplineComponent splineComp = this.SplineComp;
		FTransformDouble? initialTransform = (splineComp != null) ? new FTransformDouble?(splineComp.D_GetTransformAtTime(this.Duration, ESplineCoordinateSpace.World, true, true)) : null;
		if (!flag)
		{
			int id = EffectSystem.Instance.SpawnEffect(GlobalData.World, initialTransform, pathEffect, "样条批量子弹末尾特效", null, EEffectType.Scene, null, null, null, false, false);
			EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.SelfCentered, id, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		}
		if (!flag2)
		{
			TsBaseCharacter owner = this.Context.GetOwner();
			int skillId = this.Context.GetSkillId();
			BaseSkillComponent skillComponent = this.Context.GetSkillComponent();
			Skill skill = (skillComponent != null) ? skillComponent.GetSkill(skillId) : null;
			long? preContextId = (skill != null && skill.SkillBehaviorAnimNotifyMessageId != null) ? ((skill != null) ? skill.SkillBehaviorAnimNotifyMessageId : null) : ((skill != null) ? skill.CombatMessageId : null);
			BulletUtil.CreateBulletFromAN(owner, bulletId, initialTransform, skillId, false, preContextId, null, null, null);
		}
		ActorSystem.Instance.Put("样条曲线批量子弹", this.Spline, null);
		this.Spline = null;
		this.SplineComp = null;
	}

	// Token: 0x06018ABD RID: 101053 RVA: 0x00653C30 File Offset: 0x00651E30
	public Transform ToTransform(int index)
	{
		float time = this.Delay + this.Intervals * (float)index;
		return Transform.Create(this.SplineComp.D_GetTransformAtTime(time, ESplineCoordinateSpace.World, true, true));
	}

	// Token: 0x06018ABE RID: 101054 RVA: 0x00653C67 File Offset: 0x00651E67
	public Vector ToTargetLocation(Transform transform)
	{
		return null;
	}

	// Token: 0x06018ABF RID: 101055 RVA: 0x00653C6A File Offset: 0x00651E6A
	public float GetDelay()
	{
		return this.Delay;
	}

	// Token: 0x06018AC0 RID: 101056 RVA: 0x00653C72 File Offset: 0x00651E72
	public bool IsDestroyOnEnd()
	{
		return this.DestroyOnEnd;
	}

	// Token: 0x06018AC1 RID: 101057 RVA: 0x00653C7A File Offset: 0x00651E7A
	public bool IsSummonChildBullet()
	{
		return this.SummonChildBullet;
	}

	// Token: 0x0400B7CE RID: 47054
	private string SplineClassPath;

	// Token: 0x0400B7CF RID: 47055
	private BP_BasePathLineBullet_C Spline;

	// Token: 0x0400B7D0 RID: 47056
	private USplineComponent SplineComp;

	// Token: 0x0400B7D1 RID: 47057
	private Vector Start;

	// Token: 0x0400B7D2 RID: 47058
	private Vector End;

	// Token: 0x0400B7D3 RID: 47059
	private Rotator Rotator;

	// Token: 0x0400B7D4 RID: 47060
	private float Duration;

	// Token: 0x0400B7D5 RID: 47061
	private float Delay;

	// Token: 0x0400B7D6 RID: 47062
	private float Intervals;

	// Token: 0x0400B7D7 RID: 47063
	private string PathEffectOnEnd;

	// Token: 0x0400B7D8 RID: 47064
	private string BulletIdOnEnd;

	// Token: 0x0400B7D9 RID: 47065
	private string PathEffectOnBreak;

	// Token: 0x0400B7DA RID: 47066
	private string BulletIdOnBreak;

	// Token: 0x0400B7DB RID: 47067
	private SkillBehaviorBatchBulletTask Context;

	// Token: 0x0400B7DC RID: 47068
	private bool DestroyOnEnd;

	// Token: 0x0400B7DD RID: 47069
	private bool SummonChildBullet;
}
