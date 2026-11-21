using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DDE RID: 19934
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarQianXiaoSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603220B RID: 205323 RVA: 0x00E0BAA0 File Offset: 0x00E09CA0
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

		// Token: 0x0603220C RID: 205324 RVA: 0x00E0BC3C File Offset: 0x00E09E3C
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

		// Token: 0x0603220D RID: 205325 RVA: 0x00E0BD4C File Offset: 0x00E09F4C
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

		// Token: 0x0603220E RID: 205326 RVA: 0x00E0BE38 File Offset: 0x00E0A038
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

		// Token: 0x0603220F RID: 205327 RVA: 0x00E0BE6D File Offset: 0x00E0A06D
		[NullableContext(1)]
		public void SetPointItem(UUIItem pointItem)
		{
			this.PointItem = pointItem;
			this.PointItemLocation = pointItem.RelativeLocation;
		}

		// Token: 0x06032210 RID: 205328 RVA: 0x00E0BE82 File Offset: 0x00E0A082
		[NullableContext(1)]
		public void SetGearItem(UUIItem gearItem)
		{
			this.GearItem = gearItem;
			this.GearItemLocation = gearItem.RelativeLocation;
		}

		// Token: 0x06032211 RID: 205329 RVA: 0x00E0BE97 File Offset: 0x00E0A097
		[NullableContext(1)]
		public void SetGearRollbackCurve(UCurveFloat curve)
		{
			this.GearRollbackCurve = curve;
		}

		// Token: 0x06032212 RID: 205330 RVA: 0x00E0BEA0 File Offset: 0x00E0A0A0
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

		// Token: 0x06032213 RID: 205331 RVA: 0x00E0BF15 File Offset: 0x00E0A115
		public bool IsInSlotState(SpecialEnergyBarQianXiaoSlot.ESlotState state)
		{
			return this.State == state;
		}

		// Token: 0x0401A8DD RID: 108765
		private const int START_LOCATION_X = -181;

		// Token: 0x0401A8DE RID: 108766
		private const int END_LOCATION_X = 187;

		// Token: 0x0401A8DF RID: 108767
		private const int GEAR_ROLLBACK_DURATION = 300;

		// Token: 0x0401A8E0 RID: 108768
		private const double GLOW_EFFECT_DURATION = 1000.0;

		// Token: 0x0401A8E1 RID: 108769
		public UUIItem PointItem;

		// Token: 0x0401A8E2 RID: 108770
		public UUIItem GearItem;

		// Token: 0x0401A8E3 RID: 108771
		public UUIItem GlowItem;

		// Token: 0x0401A8E4 RID: 108772
		public UUISliderComponent GlowSlider;

		// Token: 0x0401A8E5 RID: 108773
		public UCurveFloat GearRollbackCurve;

		// Token: 0x0401A8E6 RID: 108774
		public bool FullEffectEnable;

		// Token: 0x0401A8E7 RID: 108775
		private SpecialEnergyBarQianXiaoSlot.ESlotState State;

		// Token: 0x0401A8E8 RID: 108776
		private int GearRollbackTime;

		// Token: 0x0401A8E9 RID: 108777
		private double GlowEffectFinishTime;

		// Token: 0x0401A8EA RID: 108778
		private bool CanPlayChangeEffect = true;

		// Token: 0x0401A8EB RID: 108779
		private bool MarkEmpty;

		// Token: 0x0401A8EC RID: 108780
		private bool MarkFull;

		// Token: 0x0401A8ED RID: 108781
		private FVector PointItemLocation;

		// Token: 0x0401A8EE RID: 108782
		private FVector GearItemLocation;

		// Token: 0x0401A8EF RID: 108783
		private float GearItemStartX;

		// Token: 0x0401A8F0 RID: 108784
		private float BarPercent;

		// Token: 0x0200AB4F RID: 43855
		[NullableContext(0)]
		public enum ESlotState
		{
			// Token: 0x04034FDB RID: 217051
			Normal,
			// Token: 0x04034FDC RID: 217052
			Special,
			// Token: 0x04034FDD RID: 217053
			CoolDown
		}
	}
}
