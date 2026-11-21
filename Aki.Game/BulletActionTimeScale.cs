using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils;

// Token: 0x020022F3 RID: 8947
public class BulletActionTimeScale : BulletActionBase
{
	// Token: 0x060160F6 RID: 90358 RVA: 0x00668CBF File Offset: 0x00666EBF
	public BulletActionTimeScale(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060160F7 RID: 90359 RVA: 0x00668CC8 File Offset: 0x00666EC8
	protected override void OnExecute()
	{
		if (this.BulletInfo.BulletDataMain.TimeScale.TimeScaleWithAttacker)
		{
			this.BulletAttackerTimeScaleComponent = this.BulletInfo.Attacker.GetComponent<PawnTimeScaleComponent>();
			return;
		}
		BulletInfo bulletInfo = this.BulletInfo;
		Comparison<TimeScale> compare;
		if ((compare = BulletActionTimeScale.<>O.<0>__CompareScalePriority) == null)
		{
			compare = (BulletActionTimeScale.<>O.<0>__CompareScalePriority = new Comparison<TimeScale>(PawnTimeScaleComponent.CompareScalePriority));
		}
		bulletInfo.TimeScaleList = new PriorityQueue<TimeScale>(compare);
		this.BulletInfo.TimeScaleMap = new Dictionary<int, TimeScale>();
		this.BulletInfo.TimeScaleId = 1;
		double worldTimeSeconds = Time.Instance.WorldTimeSeconds;
		Dictionary<int, BulletPersistentTimeScale> persistentTimeScaleMap = BulletModel.Instance.PersistentTimeScaleMap;
		foreach (BulletPersistentTimeScale bulletPersistentTimeScale in persistentTimeScaleMap.Values)
		{
			double num = worldTimeSeconds - (double)bulletPersistentTimeScale.StartTime;
			if (num >= (double)bulletPersistentTimeScale.Duration)
			{
				persistentTimeScaleMap.Remove(bulletPersistentTimeScale.TimeScaleId);
			}
			else
			{
				if (bulletPersistentTimeScale.CenterLocation != null)
				{
					Vector lastFramePosition = this.BulletInfo.CollisionInfo.LastFramePosition;
					if (lastFramePosition == null || Math.Abs(lastFramePosition.X - bulletPersistentTimeScale.CenterLocation.X) > (double)bulletPersistentTimeScale.Radius || Math.Abs(lastFramePosition.Y - bulletPersistentTimeScale.CenterLocation.Y) > (double)bulletPersistentTimeScale.Radius || Math.Abs(lastFramePosition.Z - bulletPersistentTimeScale.CenterLocation.Z) > (double)bulletPersistentTimeScale.Radius)
					{
						continue;
					}
				}
				BulletUtil.SetTimeScale(this.BulletInfo, bulletPersistentTimeScale.Priority, bulletPersistentTimeScale.TimeDilation, bulletPersistentTimeScale.Curve, bulletPersistentTimeScale.Duration, bulletPersistentTimeScale.SourceType, num, bulletPersistentTimeScale.TimeScaleId);
			}
		}
	}

	// Token: 0x060160F8 RID: 90360 RVA: 0x00668E84 File Offset: 0x00667084
	protected override void OnTick(float delta)
	{
		float num = this.BulletInfo.Entity.TimeDilation;
		if (this.BulletInfo.BulletDataMain.TimeScale.TimeScaleWithAttacker)
		{
			PawnTimeScaleComponent bulletAttackerTimeScaleComponent = this.BulletAttackerTimeScaleComponent;
			this.CurrentTimeScaleValue = (bulletAttackerTimeScaleComponent.Active ? bulletAttackerTimeScaleComponent.CurrentTimeScale : 1f);
			if (this.LastSetTimeScale == this.CurrentTimeScaleValue)
			{
				return;
			}
			this.LastSetTimeScale = this.CurrentTimeScaleValue;
			this.BulletInfo.Actor.CustomTimeDilation = this.CurrentTimeScaleValue;
			EffectUtil.SetEffectTimeScale(this.BulletInfo.EffectInfo.Effect, bulletAttackerTimeScaleComponent, num, ETimeScaleType.FollowEntity);
			return;
		}
		else
		{
			double worldTimeSeconds = Time.Instance.WorldTimeSeconds;
			while (!this.BulletInfo.TimeScaleList.Empty && (this.BulletInfo.TimeScaleList.Top.EndTime <= worldTimeSeconds || this.BulletInfo.TimeScaleList.Top.MarkDelete))
			{
				TimeScale timeScale = this.BulletInfo.TimeScaleList.Pop();
				this.BulletInfo.TimeScaleMap.Remove(timeScale.Id);
			}
			if (!this.BulletInfo.TimeScaleList.Empty)
			{
				this.CurrentTimeScaleValue = this.BulletInfo.TimeScaleList.Top.CalculateTimeScale();
			}
			else
			{
				this.CurrentTimeScaleValue = 1f;
			}
			num *= this.CurrentTimeScaleValue;
			Entity attacker = this.BulletInfo.Attacker;
			float? num2;
			if (attacker == null)
			{
				num2 = null;
			}
			else
			{
				PawnTimeScaleComponent component = attacker.GetComponent<PawnTimeScaleComponent>();
				num2 = ((component != null) ? new float?(component.GetTopForeverTimeScale(new ESourceEffectGroup?(ESourceEffectGroup.LogicAndView))) : null);
			}
			float num3 = num2 ?? CharacterModel.Instance.InverseSelfCenteredTimeDilation;
			this.CurrentTimeScaleValue *= num3;
			if (this.LastSetTimeScale == num && this.LastTopForeverTimeScale == num3)
			{
				return;
			}
			this.LastSetTimeScale = num;
			this.LastTopForeverTimeScale = num3;
			this.BulletInfo.Actor.CustomTimeDilation = this.CurrentTimeScaleValue;
			BulletStaticFunction.SetBulletEffectTimeScale(this.BulletInfo.EffectInfo, (double)num, true);
			EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.SelfCentered, this.BulletInfo.EffectInfo.Effect, num3);
			return;
		}
	}

	// Token: 0x060160F9 RID: 90361 RVA: 0x006690B4 File Offset: 0x006672B4
	public override void Clear()
	{
		base.Clear();
		this.CurrentTimeScaleValue = 0f;
		this.BulletAttackerTimeScaleComponent = null;
		this.LastSetTimeScale = 0f;
		this.LastTopForeverTimeScale = 0f;
	}

	// Token: 0x0400B958 RID: 47448
	private float CurrentTimeScaleValue;

	// Token: 0x0400B959 RID: 47449
	[Nullable(2)]
	private PawnTimeScaleComponent BulletAttackerTimeScaleComponent;

	// Token: 0x0400B95A RID: 47450
	private float LastSetTimeScale;

	// Token: 0x0400B95B RID: 47451
	private float LastTopForeverTimeScale;

	// Token: 0x0200853B RID: 34107
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402AEF1 RID: 175857
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<TimeScale> <0>__CompareScalePriority;
	}
}
