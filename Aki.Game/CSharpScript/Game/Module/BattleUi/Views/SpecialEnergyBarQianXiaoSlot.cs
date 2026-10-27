using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF9 RID: 24057
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarQianXiaoSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D27C RID: 250492 RVA: 0x00EBA554 File Offset: 0x00EB8754
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool flag = this.State == SpecialEnergyBarQianXiaoSlot.ESlotState.Normal && this.FullEffectEnable && this.GetKeyEnable();
			SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[0];
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshKeyEnable(flag, isStart);
			}
			float x = curPercent * 187f + (1f - curPercent) * -181f;
			this.PointItemLocation.X = x;
			UUIItem pointItem = this.PointItem;
			if (pointItem != null)
			{
				pointItem.SetUIRelativeLocation(this.PointItemLocation);
			}
			bool flag2 = this.MarkEmpty || this.MarkFull;
			if (this.MarkEmpty)
			{
				this.MarkEmpty = false;
				specialEnergyBarSlotItem.UpdatePercent(0f, false, true);
			}
			else if (this.MarkFull)
			{
				this.MarkFull = false;
				specialEnergyBarSlotItem.UpdatePercent(1f, false, true);
				specialEnergyBarSlotItem.SetFullEffectVisible(false);
			}
			if (this.State != SpecialEnergyBarQianXiaoSlot.ESlotState.Special && flag && this.CanPlayChangeEffect)
			{
				this.CanPlayChangeEffect = false;
				specialEnergyBarSlotItem.PlayChangeEffectWithPercent(1f);
			}
			if (this.State == SpecialEnergyBarQianXiaoSlot.ESlotState.Special)
			{
				specialEnergyBarSlotItem.UpdatePercentWithFullEffect(curPercent, curPercent > 0f, isStart);
				this.GearItemLocation.X = x;
				UUIItem gearItem = this.GearItem;
				if (gearItem != null)
				{
					gearItem.SetUIRelativeLocation(this.GearItemLocation);
				}
			}
			else if (flag)
			{
				specialEnergyBarSlotItem.UpdatePercentWithFullEffect(curPercent, curPercent > 0f, isStart);
			}
			else if (!flag2)
			{
				specialEnergyBarSlotItem.UpdatePercent(curPercent, false, isStart);
			}
			if (this.State == SpecialEnergyBarQianXiaoSlot.ESlotState.Normal && this.BarPercent == 1f && curPercent == 0f)
			{
				specialEnergyBarSlotItem.PlayUseEffectWithPercent(this.BarPercent);
			}
			this.BarPercent = curPercent;
		}

		// Token: 0x0603D27D RID: 250493 RVA: 0x00EBA6F0 File Offset: 0x00EB88F0
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.State == SpecialEnergyBarQianXiaoSlot.ESlotState.CoolDown)
			{
				this.GearRollbackTime += (int)delta;
				if (this.GearRollbackTime >= 300)
				{
					this.GearItemLocation.X = 187f;
					UUIItem gearItem = this.GearItem;
					if (gearItem != null)
					{
						gearItem.SetUIRelativeLocation(this.GearItemLocation);
					}
					this.SetState(SpecialEnergyBarQianXiaoSlot.ESlotState.Normal);
				}
				else if (this.GearRollbackCurve != null)
				{
					float floatValue = this.GearRollbackCurve.GetFloatValue((float)this.GearRollbackTime * (float)TimeUtil.Instance.Millisecond);
					this.GearItemLocation.X = floatValue * 187f + (1f - floatValue) * this.GearItemStartX;
					UUIItem gearItem2 = this.GearItem;
					if (gearItem2 != null)
					{
						gearItem2.SetUIRelativeLocation(this.GearItemLocation);
					}
				}
			}
			if (this.GlowEffectFinishTime > 0.0 && this.GlowEffectFinishTime <= Time.Instance.Now)
			{
				UUIItem glowItem = this.GlowItem;
				if (glowItem != null)
				{
					glowItem.SetUIActive(false);
				}
				this.GlowEffectFinishTime = 0.0;
			}
		}

		// Token: 0x0603D27E RID: 250494 RVA: 0x00EBA800 File Offset: 0x00EB8A00
		public void SetState(SpecialEnergyBarQianXiaoSlot.ESlotState state)
		{
			if (this.State == state)
			{
				return;
			}
			this.State = state;
			if (state == SpecialEnergyBarQianXiaoSlot.ESlotState.Normal)
			{
				this.CanPlayChangeEffect = true;
				return;
			}
			if (state == SpecialEnergyBarQianXiaoSlot.ESlotState.Special)
			{
				this.GearItemLocation.X = 187f;
				UUIItem gearItem = this.GearItem;
				if (gearItem != null)
				{
					gearItem.SetUIRelativeLocation(this.GearItemLocation);
				}
				UUIItem glowItem = this.GlowItem;
				if (glowItem != null)
				{
					glowItem.SetUIActive(false);
				}
				this.MarkEmpty = true;
				this.RefreshBarPercent(false);
				return;
			}
			float curPercent = this.PercentMachine.GetCurPercent();
			if (curPercent > 0f)
			{
				UUISliderComponent glowSlider = this.GlowSlider;
				if (glowSlider != null)
				{
					glowSlider.SetValue(curPercent, true);
				}
				UUIItem glowItem2 = this.GlowItem;
				if (glowItem2 != null)
				{
					glowItem2.SetUIActive(true);
				}
			}
			this.GearRollbackTime = 0;
			this.GearItemStartX = this.GearItem.RelativeLocation.X;
			this.GlowEffectFinishTime = 1000.0 + Time.Instance.Now;
			this.CanPlayChangeEffect = true;
		}

		// Token: 0x0603D27F RID: 250495 RVA: 0x00EBA8EC File Offset: 0x00EB8AEC
		public void SetFullEffectEnable(bool enable)
		{
			if (this.FullEffectEnable == enable)
			{
				return;
			}
			this.FullEffectEnable = enable;
			if (!enable && this.State != SpecialEnergyBarQianXiaoSlot.ESlotState.CoolDown && this.GetKeyEnable())
			{
				this.MarkFull = true;
			}
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D280 RID: 250496 RVA: 0x00EBA921 File Offset: 0x00EB8B21
		[NullableContext(1)]
		public void SetPointItem(UUIItem pointItem)
		{
			this.PointItem = pointItem;
			this.PointItemLocation = pointItem.RelativeLocation;
		}

		// Token: 0x0603D281 RID: 250497 RVA: 0x00EBA936 File Offset: 0x00EB8B36
		[NullableContext(1)]
		public void SetGearItem(UUIItem gearItem)
		{
			this.GearItem = gearItem;
			this.GearItemLocation = gearItem.RelativeLocation;
		}

		// Token: 0x0603D282 RID: 250498 RVA: 0x00EBA94B File Offset: 0x00EB8B4B
		[NullableContext(1)]
		public void SetGearRollbackCurve(UCurveFloat curve)
		{
			this.GearRollbackCurve = curve;
		}

		// Token: 0x0603D283 RID: 250499 RVA: 0x00EBA954 File Offset: 0x00EB8B54
		public void StopCoolDownState()
		{
			if (this.State == SpecialEnergyBarQianXiaoSlot.ESlotState.CoolDown)
			{
				this.GearItemLocation.X = 187f;
				UUIItem gearItem = this.GearItem;
				if (gearItem != null)
				{
					gearItem.SetUIRelativeLocation(this.GearItemLocation);
				}
				this.SetState(SpecialEnergyBarQianXiaoSlot.ESlotState.Normal);
			}
			if (this.GlowEffectFinishTime > 0.0)
			{
				this.GlowEffectFinishTime = 0.0;
				UUIItem glowItem = this.GlowItem;
				if (glowItem == null)
				{
					return;
				}
				glowItem.SetUIActive(false);
			}
		}

		// Token: 0x0603D284 RID: 250500 RVA: 0x00EBA9C9 File Offset: 0x00EB8BC9
		public bool IsInSlotState(SpecialEnergyBarQianXiaoSlot.ESlotState state)
		{
			return this.State == state;
		}

		// Token: 0x0401FE16 RID: 130582
		private const int START_LOCATION_X = -181;

		// Token: 0x0401FE17 RID: 130583
		private const int END_LOCATION_X = 187;

		// Token: 0x0401FE18 RID: 130584
		private const int GEAR_ROLLBACK_DURATION = 300;

		// Token: 0x0401FE19 RID: 130585
		private const double GLOW_EFFECT_DURATION = 1000.0;

		// Token: 0x0401FE1A RID: 130586
		public UUIItem PointItem;

		// Token: 0x0401FE1B RID: 130587
		public UUIItem GearItem;

		// Token: 0x0401FE1C RID: 130588
		public UUIItem GlowItem;

		// Token: 0x0401FE1D RID: 130589
		public UUISliderComponent GlowSlider;

		// Token: 0x0401FE1E RID: 130590
		public UCurveFloat GearRollbackCurve;

		// Token: 0x0401FE1F RID: 130591
		public bool FullEffectEnable;

		// Token: 0x0401FE20 RID: 130592
		private SpecialEnergyBarQianXiaoSlot.ESlotState State;

		// Token: 0x0401FE21 RID: 130593
		private int GearRollbackTime;

		// Token: 0x0401FE22 RID: 130594
		private double GlowEffectFinishTime;

		// Token: 0x0401FE23 RID: 130595
		private bool CanPlayChangeEffect = true;

		// Token: 0x0401FE24 RID: 130596
		private bool MarkEmpty;

		// Token: 0x0401FE25 RID: 130597
		private bool MarkFull;

		// Token: 0x0401FE26 RID: 130598
		private FVector PointItemLocation;

		// Token: 0x0401FE27 RID: 130599
		private FVector GearItemLocation;

		// Token: 0x0401FE28 RID: 130600
		private float GearItemStartX;

		// Token: 0x0401FE29 RID: 130601
		private float BarPercent;

		// Token: 0x0200C140 RID: 49472
		[NullableContext(0)]
		public enum ESlotState
		{
			// Token: 0x0403A5E9 RID: 239081
			Normal,
			// Token: 0x0403A5EA RID: 239082
			Special,
			// Token: 0x0403A5EB RID: 239083
			CoolDown
		}
	}
}
