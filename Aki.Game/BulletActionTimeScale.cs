using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils;

// Token: 0x02002D99 RID: 11673
public class BulletActionTimeScale : BulletActionBase
{
	// Token: 0x06018852 RID: 100434 RVA: 0x00642F03 File Offset: 0x00641103
	public BulletActionTimeScale(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06018853 RID: 100435 RVA: 0x00642F0C File Offset: 0x0064110C
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

	// Token: 0x06018854 RID: 100436 RVA: 0x006430C8 File Offset: 0x006412C8
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

	// Token: 0x06018855 RID: 100437 RVA: 0x006432F8 File Offset: 0x006414F8
	public override void Clear()
	{
		base.Clear();
		this.CurrentTimeScaleValue = 0f;
		this.BulletAttackerTimeScaleComponent = null;
		this.LastSetTimeScale = 0f;
		this.LastTopForeverTimeScale = 0f;
	}

	// Token: 0x0400B5E2 RID: 46562
	private float CurrentTimeScaleValue;

	// Token: 0x0400B5E3 RID: 46563
	[Nullable(2)]
	private PawnTimeScaleComponent BulletAttackerTimeScaleComponent;

	// Token: 0x0400B5E4 RID: 46564
	private float LastSetTimeScale;

	// Token: 0x0400B5E5 RID: 46565
	private float LastTopForeverTimeScale;

	// Token: 0x02009314 RID: 37652
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402F869 RID: 194665
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<TimeScale> <0>__CompareScalePriority;
	}
}
