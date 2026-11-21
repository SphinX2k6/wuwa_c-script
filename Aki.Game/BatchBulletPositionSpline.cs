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

// Token: 0x02002343 RID: 9027
[NullableContext(2)]
[Nullable(0)]
public class BatchBulletPositionSpline : IBatchBulletPositionShape
{
	// Token: 0x06016363 RID: 90979 RVA: 0x006799C9 File Offset: 0x00677BC9
	[NullableContext(1)]
	public static BatchBulletPositionSpline Create(CharacterCustomValueComponent customValueComp, SBatchBulletPositionSpline config, SkillBehaviorBatchBulletTask taskContext)
	{
		BatchBulletPositionSpline batchBulletPositionSpline = new BatchBulletPositionSpline();
		batchBulletPositionSpline.FromUeConfig(customValueComp, config);
		batchBulletPositionSpline.Intervals = taskContext.GetInterval();
		batchBulletPositionSpline.Context = taskContext;
		return batchBulletPositionSpline;
	}

	// Token: 0x06016364 RID: 90980 RVA: 0x006799EB File Offset: 0x00677BEB
	private BatchBulletPositionSpline()
	{
	}

	// Token: 0x06016365 RID: 90981 RVA: 0x006799F4 File Offset: 0x00677BF4
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

	// Token: 0x06016366 RID: 90982 RVA: 0x00679B2C File Offset: 0x00677D2C
	public UniTask Load()
	{
		BatchBulletPositionSpline.<Load>d__19 <Load>d__;
		<Load>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Load>d__.<>4__this = this;
		<Load>d__.<>1__state = -1;
		<Load>d__.<>t__builder.Start<BatchBulletPositionSpline.<Load>d__19>(ref <Load>d__);
		return <Load>d__.<>t__builder.Task;
	}

	// Token: 0x06016367 RID: 90983 RVA: 0x00679B6F File Offset: 0x00677D6F
	public void OnBreak()
	{
		this.OnSplineFinish(this.PathEffectOnBreak, this.BulletIdOnBreak);
	}

	// Token: 0x06016368 RID: 90984 RVA: 0x00679B83 File Offset: 0x00677D83
	public void OnEnd()
	{
		this.OnSplineFinish(this.PathEffectOnEnd, this.BulletIdOnEnd);
	}

	// Token: 0x06016369 RID: 90985 RVA: 0x00679B98 File Offset: 0x00677D98
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

	// Token: 0x0601636A RID: 90986 RVA: 0x00679D10 File Offset: 0x00677F10
	public Transform ToTransform(int index)
	{
		float time = this.Delay + this.Intervals * (float)index;
		return Transform.Create(this.SplineComp.D_GetTransformAtTime(time, ESplineCoordinateSpace.World, true, true));
	}

	// Token: 0x0601636B RID: 90987 RVA: 0x00679D47 File Offset: 0x00677F47
	public Vector ToTargetLocation(Transform transform)
	{
		return null;
	}

	// Token: 0x0601636C RID: 90988 RVA: 0x00679D4A File Offset: 0x00677F4A
	public float GetDelay()
	{
		return this.Delay;
	}

	// Token: 0x0601636D RID: 90989 RVA: 0x00679D52 File Offset: 0x00677F52
	public bool IsDestroyOnEnd()
	{
		return this.DestroyOnEnd;
	}

	// Token: 0x0601636E RID: 90990 RVA: 0x00679D5A File Offset: 0x00677F5A
	public bool IsSummonChildBullet()
	{
		return this.SummonChildBullet;
	}

	// Token: 0x0400BB54 RID: 47956
	private string SplineClassPath;

	// Token: 0x0400BB55 RID: 47957
	private BP_BasePathLineBullet_C Spline;

	// Token: 0x0400BB56 RID: 47958
	private USplineComponent SplineComp;

	// Token: 0x0400BB57 RID: 47959
	private Vector Start;

	// Token: 0x0400BB58 RID: 47960
	private Vector End;

	// Token: 0x0400BB59 RID: 47961
	private Rotator Rotator;

	// Token: 0x0400BB5A RID: 47962
	private float Duration;

	// Token: 0x0400BB5B RID: 47963
	private float Delay;

	// Token: 0x0400BB5C RID: 47964
	private float Intervals;

	// Token: 0x0400BB5D RID: 47965
	private string PathEffectOnEnd;

	// Token: 0x0400BB5E RID: 47966
	private string BulletIdOnEnd;

	// Token: 0x0400BB5F RID: 47967
	private string PathEffectOnBreak;

	// Token: 0x0400BB60 RID: 47968
	private string BulletIdOnBreak;

	// Token: 0x0400BB61 RID: 47969
	private SkillBehaviorBatchBulletTask Context;

	// Token: 0x0400BB62 RID: 47970
	private bool DestroyOnEnd;

	// Token: 0x0400BB63 RID: 47971
	private bool SummonChildBullet;
}
