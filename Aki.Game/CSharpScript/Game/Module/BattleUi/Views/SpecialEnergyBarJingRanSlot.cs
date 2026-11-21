using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DC3 RID: 19907
	public class SpecialEnergyBarJingRanSlot : SpecialEnergyBarSlot
	{
		// Token: 0x060320D8 RID: 205016 RVA: 0x00E03E4F File Offset: 0x00E0204F
		public void MarkStateChange()
		{
			this.IsWaitingStateChange = false;
		}

		// Token: 0x060320D9 RID: 205017 RVA: 0x00E03E58 File Offset: 0x00E02058
		public void SetStrengthState(bool isStrength)
		{
			if (this.IsInStrengthState == isStrength)
			{
				return;
			}
			this.IsInStrengthState = isStrength;
			this.IsWaitingStateChange = false;
			base.SetUseEffectMode(this.IsInStrengthState ? EUseEffectMode.EnergyDecreaseSegment : EUseEffectMode.Default);
		}

		// Token: 0x060320DA RID: 205018 RVA: 0x00E03E84 File Offset: 0x00E02084
		[NullableContext(1)]
		protected override UniTask InitSlotItem(UUIItem slotItem)
		{
			SpecialEnergyBarJingRanSlot.<InitSlotItem>d__17 <InitSlotItem>d__;
			<InitSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSlotItem>d__.<>4__this = this;
			<InitSlotItem>d__.slotItem = slotItem;
			<InitSlotItem>d__.<>1__state = -1;
			<InitSlotItem>d__.<>t__builder.Start<SpecialEnergyBarJingRanSlot.<InitSlotItem>d__17>(ref <InitSlotItem>d__);
			return <InitSlotItem>d__.<>t__builder.Task;
		}

		// Token: 0x060320DB RID: 205019 RVA: 0x00E03ED0 File Offset: 0x00E020D0
		protected override void OnStart()
		{
			this.OverrideColor = true;
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SetItemStyle(i, this.Config.EffectColor, this.Config.PointColor);
			}
			base.OnStart();
		}

		// Token: 0x060320DC RID: 205020 RVA: 0x00E03F20 File Offset: 0x00E02120
		[NullableContext(1)]
		private void SetItemStyle(int index, string barColor, string pointColor)
		{
			SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[index];
			FColor fcolor = FColor.FromHex(barColor);
			specialEnergyBarSlotItem.SetBarColor(fcolor);
			SpecialEnergyBarSlotItem specialEnergyBarSlotItem2 = this.SlotItemList[index];
			fcolor = FColor.FromHex(pointColor);
			specialEnergyBarSlotItem2.SetPointColor(fcolor);
		}

		// Token: 0x060320DD RID: 205021 RVA: 0x00E03F64 File Offset: 0x00E02164
		protected override void OnInitData()
		{
			base.OnInitData();
			this.CurrentPercent = base.GetTargetAttributePercent();
			this.CurrentPercent = base.GetTargetAttributePercent();
			SpecialEnergyBarInfo config = this.Config;
			this.FadeOutTime = ((config != null) ? config.ExtraFloatParams[0] : SpecialEnergyBarJingRanSlot.DEFAULT_FADE_OUT_TIME);
			SpecialEnergyBarInfo config2 = this.Config;
			this.ConsumeTime = ((config2 != null) ? config2.ExtraFloatParams[1] : SpecialEnergyBarJingRanSlot.DEFAULT_CONSUME_TIME);
		}

		// Token: 0x060320DE RID: 205022 RVA: 0x00E03FD3 File Offset: 0x00E021D3
		protected override void OnAttributeChanged()
		{
			this.CurrentPercent = base.GetTargetAttributePercent();
			this.OnBarPercentChanged();
		}

		// Token: 0x060320DF RID: 205023 RVA: 0x00E03FE7 File Offset: 0x00E021E7
		protected override void OnMaxAttributeChanged()
		{
			this.CurrentPercent = base.GetTargetAttributePercent();
			this.OnBarPercentChanged();
		}

		// Token: 0x060320E0 RID: 205024 RVA: 0x00E03FFC File Offset: 0x00E021FC
		private float CalcConsumeEnergyLength(int slotIndex)
		{
			float currentPercent = this.CurrentPercent;
			float num = (float)slotIndex / (float)this.SlotNum;
			float num2 = (float)(slotIndex + 1) / (float)this.SlotNum;
			if (this.BarPercent < num2)
			{
				num2 = this.BarPercent;
			}
			if (currentPercent > num)
			{
				num = currentPercent;
			}
			return (num2 - num) * (float)this.SlotNum;
		}

		// Token: 0x060320E1 RID: 205025 RVA: 0x00E0404C File Offset: 0x00E0224C
		private void SetAllItemAlpha(float alpha)
		{
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarJingRanSlot.SpecialEnergyBarJingRanSlotItem specialEnergyBarJingRanSlotItem = this.SlotItemList[i] as SpecialEnergyBarJingRanSlot.SpecialEnergyBarJingRanSlotItem;
				if (specialEnergyBarJingRanSlotItem != null)
				{
					specialEnergyBarJingRanSlotItem.SetFullEffectAlpha(alpha);
				}
				if (specialEnergyBarJingRanSlotItem != null)
				{
					specialEnergyBarJingRanSlotItem.SetConsumeEffectAlpha(alpha);
				}
			}
		}

		// Token: 0x060320E2 RID: 205026 RVA: 0x00E0409C File Offset: 0x00E0229C
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (!this.IsPlayingConsumeAnim())
			{
				return;
			}
			float delta2 = delta / (float)TimeUtil.Instance.InverseMillisecond;
			this.UpdateConsume(delta2);
			this.UpdateFadeOut(delta2);
			this.UpdateWaitingTime(delta2);
			if (!this.IsPlayingConsumeAnim())
			{
				this.RefreshBarPercent(false);
			}
		}

		// Token: 0x060320E3 RID: 205027 RVA: 0x00E040EC File Offset: 0x00E022EC
		protected override void RefreshBarPercent(bool isStart = false)
		{
			if (this.IsPlayingConsumeAnim() && this.IsInStrengthState)
			{
				return;
			}
			float currentPercent = this.CurrentPercent;
			float barPercent = this.BarPercent;
			bool isInStrengthState = this.IsInStrengthState;
			if (barPercent <= currentPercent)
			{
				this.SetConsumeEffectActive(false);
				this.SetAllItemAlpha(1f);
			}
			else if (isInStrengthState)
			{
				this.SetConsumeEffectActive(true);
				this.RemainingFadeOutTime = this.FadeOutTime;
				this.RemainingConsumeTime = this.ConsumeTime;
				this.WaitingTime = 0f;
				this.IsWaitingStateChange = true;
			}
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarJingRanSlot.SpecialEnergyBarJingRanSlotItem specialEnergyBarJingRanSlotItem = this.SlotItemList[i] as SpecialEnergyBarJingRanSlot.SpecialEnergyBarJingRanSlotItem;
				float num = currentPercent * (float)this.SlotNum - (float)i;
				specialEnergyBarJingRanSlotItem.EnableFullEffect(keyEnable || this.IsPlayingConsumeAnim());
				if (keyEnable || this.IsPlayingConsumeAnim())
				{
					specialEnergyBarJingRanSlotItem.UpdatePercentWithFullEffect(num, num * SpecialEnergyBarJingRanSlot.BaseBgEffectLength, isStart);
					specialEnergyBarJingRanSlotItem.UpdateTextEffectPercent(num);
				}
				else
				{
					specialEnergyBarJingRanSlotItem.UpdatePercentWithFullEffectEnable(num, false, false);
				}
				specialEnergyBarJingRanSlotItem.SetConsumeEffectOffsetX(num);
				float percent = this.CalcConsumeEnergyLength(i);
				specialEnergyBarJingRanSlotItem.UpdateConsumePercent(percent);
				if (isInStrengthState)
				{
					specialEnergyBarJingRanSlotItem.UpdateUseEffectByMode(num, isStart);
				}
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshKeyEnable(keyEnable, isStart);
			}
			this.BarPercent = currentPercent;
		}

		// Token: 0x060320E4 RID: 205028 RVA: 0x00E04238 File Offset: 0x00E02438
		private void UpdateConsume(float delta)
		{
			if (this.RemainingConsumeTime <= 0f)
			{
				return;
			}
			this.RemainingConsumeTime -= delta;
			float consumeEffectAlpha = MathUtils.Instance.Clamp(this.RemainingConsumeTime / this.ConsumeTime, 0f, 1f);
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				(this.SlotItemList[i] as SpecialEnergyBarJingRanSlot.SpecialEnergyBarJingRanSlotItem).SetConsumeEffectAlpha(consumeEffectAlpha);
			}
		}

		// Token: 0x060320E5 RID: 205029 RVA: 0x00E042B0 File Offset: 0x00E024B0
		private void UpdateFadeOut(float delta)
		{
			if (this.RemainingFadeOutTime <= 0f)
			{
				return;
			}
			this.RemainingFadeOutTime -= delta;
			float fullEffectAlpha = MathUtils.Instance.Clamp(this.RemainingFadeOutTime / this.FadeOutTime, 0f, 1f);
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				(this.SlotItemList[i] as SpecialEnergyBarJingRanSlot.SpecialEnergyBarJingRanSlotItem).SetFullEffectAlpha(fullEffectAlpha);
			}
		}

		// Token: 0x060320E6 RID: 205030 RVA: 0x00E04328 File Offset: 0x00E02528
		private void UpdateWaitingTime(float delta)
		{
			if (!this.IsWaitingStateChange)
			{
				return;
			}
			this.WaitingTime += delta;
			if ((double)this.WaitingTime >= (double)this.FadeOutTime + 0.15)
			{
				this.IsWaitingStateChange = false;
			}
		}

		// Token: 0x060320E7 RID: 205031 RVA: 0x00E04362 File Offset: 0x00E02562
		protected override bool GetKeyEnable()
		{
			return this.IsKeyEnable;
		}

		// Token: 0x060320E8 RID: 205032 RVA: 0x00E0436C File Offset: 0x00E0256C
		private void SetConsumeEffectActive(bool active)
		{
			if (this.IsConsumeEffectActive == active)
			{
				return;
			}
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarJingRanSlot.SpecialEnergyBarJingRanSlotItem specialEnergyBarJingRanSlotItem = this.SlotItemList[i] as SpecialEnergyBarJingRanSlot.SpecialEnergyBarJingRanSlotItem;
				if (specialEnergyBarJingRanSlotItem != null)
				{
					specialEnergyBarJingRanSlotItem.SetConsumeEffectActive(active);
				}
			}
			this.IsConsumeEffectActive = active;
		}

		// Token: 0x060320E9 RID: 205033 RVA: 0x00E043BD File Offset: 0x00E025BD
		public void SetKeyEnable(bool enable)
		{
			this.IsKeyEnable = enable;
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshKeyEnable(enable, true);
			}
			this.RefreshBarPercent(false);
		}

		// Token: 0x060320EA RID: 205034 RVA: 0x00E043E0 File Offset: 0x00E025E0
		public bool IsPlayingConsumeAnim()
		{
			return this.RemainingFadeOutTime > 0f || this.RemainingConsumeTime > 0f || this.IsWaitingStateChange;
		}

		// Token: 0x0401A80C RID: 108556
		private bool IsKeyEnable;

		// Token: 0x0401A80D RID: 108557
		private float CurrentPercent;

		// Token: 0x0401A80E RID: 108558
		private float BarPercent;

		// Token: 0x0401A80F RID: 108559
		private float FadeOutTime;

		// Token: 0x0401A810 RID: 108560
		private float ConsumeTime;

		// Token: 0x0401A811 RID: 108561
		private float RemainingFadeOutTime;

		// Token: 0x0401A812 RID: 108562
		private float RemainingConsumeTime;

		// Token: 0x0401A813 RID: 108563
		private static readonly float BaseBgEffectLength = 0.4f;

		// Token: 0x0401A814 RID: 108564
		private bool IsConsumeEffectActive;

		// Token: 0x0401A815 RID: 108565
		private float WaitingTime;

		// Token: 0x0401A816 RID: 108566
		private bool IsInStrengthState;

		// Token: 0x0401A817 RID: 108567
		private bool IsWaitingStateChange;

		// Token: 0x0401A818 RID: 108568
		private static readonly float DEFAULT_FADE_OUT_TIME = 1.2f;

		// Token: 0x0401A819 RID: 108569
		private static readonly float DEFAULT_CONSUME_TIME = 0.5f;

		// Token: 0x0200AB0E RID: 43790
		private class SpecialEnergyBarJingRanSlotItem : SpecialEnergyBarSlotItem
		{
			// Token: 0x06046936 RID: 289078 RVA: 0x015490E0 File Offset: 0x015472E0
			protected override void OnStart()
			{
				base.OnStart();
				base.GetUiNiagara(9).SetUIActive(false);
				base.GetUiNiagara(3).SetUIActive(true);
				base.GetUiNiagara(4).SetUIActive(true);
				base.GetUiNiagara(10).SetUIActive(true);
				this.InitConsumeEffectOffsetX = base.GetUiNiagara(9).GetAnchorOffsetX();
			}

			// Token: 0x06046937 RID: 289079 RVA: 0x0154913C File Offset: 0x0154733C
			protected override void OnRegisterComponent()
			{
				base.OnRegisterComponent();
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUINiagara)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUINiagara)));
			}

			// Token: 0x06046938 RID: 289080 RVA: 0x0154917C File Offset: 0x0154737C
			public void UpdateConsumePercent(float percent)
			{
				base.GetUiNiagara(9).SetNiagaraVarFloat("Dissolve", percent);
			}

			// Token: 0x06046939 RID: 289081 RVA: 0x01549191 File Offset: 0x01547391
			public void UpdateTextEffectPercent(float percent)
			{
				base.GetUiNiagara(10).SetNiagaraVarFloat("Dissolve", percent);
			}

			// Token: 0x0604693A RID: 289082 RVA: 0x015491A6 File Offset: 0x015473A6
			public void SetConsumeEffectActive(bool active)
			{
				if (this.IsConsumeEffectActive == active)
				{
					return;
				}
				base.GetUiNiagara(9).SetUIActive(active);
				this.SetConsumeEffectAlpha(active > false);
				this.IsConsumeEffectActive = active;
			}

			// Token: 0x0604693B RID: 289083 RVA: 0x015491D4 File Offset: 0x015473D4
			public void SetConsumeEffectOffsetX(float percent)
			{
				float num = percent;
				if (num < 0f)
				{
					num = 0f;
				}
				if (num > 1f)
				{
					num = 1f;
				}
				UUINiagara uiNiagara = base.GetUiNiagara(9);
				float width = base.GetRootItem().Width;
				if (uiNiagara == null)
				{
					return;
				}
				uiNiagara.SetAnchorOffsetX(this.InitConsumeEffectOffsetX + width * num);
			}

			// Token: 0x0604693C RID: 289084 RVA: 0x01549228 File Offset: 0x01547428
			public void EnableFullEffect(bool enable)
			{
				bool? isFullEffectEnable = this.IsFullEffectEnable;
				if (isFullEffectEnable.GetValueOrDefault() == enable & isFullEffectEnable != null)
				{
					return;
				}
				this.IsFullEffectEnable = new bool?(enable);
				base.GetUiNiagara(3).SetUIActive(enable);
				base.GetUiNiagara(4).SetUIActive(enable);
				base.GetUiNiagara(10).SetUIActive(enable);
				this.SetFullEffectAlpha(enable > false);
				base.GetSprite(0).SetUIActive(!enable);
				base.GetSprite(7).SetUIActive(true);
				base.GetSprite(8).SetUIActive(!enable);
				base.GetSprite(1).SetUIActive(!enable);
				this.State = 3;
			}

			// Token: 0x0604693D RID: 289085 RVA: 0x015492D6 File Offset: 0x015474D6
			public void SetFullEffectAlpha(float alpha)
			{
				base.GetUiNiagara(3).SetAlpha(alpha);
				base.GetUiNiagara(4).SetAlpha(alpha);
				base.GetUiNiagara(10).SetAlpha(alpha);
			}

			// Token: 0x0604693E RID: 289086 RVA: 0x01549300 File Offset: 0x01547500
			public void SetConsumeEffectAlpha(float alpha)
			{
				base.GetUiNiagara(9).SetAlpha(alpha);
			}

			// Token: 0x04034E13 RID: 216595
			private float InitConsumeEffectOffsetX;

			// Token: 0x04034E14 RID: 216596
			private bool IsConsumeEffectActive;

			// Token: 0x04034E15 RID: 216597
			private bool? IsFullEffectEnable;

			// Token: 0x0200BD6F RID: 48495
			private enum ESlotItemChildType
			{
				// Token: 0x0403A278 RID: 238200
				BgSprite,
				// Token: 0x0403A279 RID: 238201
				BarSprite,
				// Token: 0x0403A27A RID: 238202
				PointBgSprite = 7,
				// Token: 0x0403A27B RID: 238203
				PointFgSprite,
				// Token: 0x0403A27C RID: 238204
				FullEffect = 3,
				// Token: 0x0403A27D RID: 238205
				FullBgEffect,
				// Token: 0x0403A27E RID: 238206
				ConsumeEffect = 9,
				// Token: 0x0403A27F RID: 238207
				TextEffect
			}
		}
	}
}
