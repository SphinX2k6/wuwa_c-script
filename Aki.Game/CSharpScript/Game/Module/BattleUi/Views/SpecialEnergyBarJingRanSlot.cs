using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DDF RID: 24031
	public class SpecialEnergyBarJingRanSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D161 RID: 250209 RVA: 0x00EB2F5B File Offset: 0x00EB115B
		public void MarkStateChange()
		{
			this.IsWaitingStateChange = false;
		}

		// Token: 0x0603D162 RID: 250210 RVA: 0x00EB2F64 File Offset: 0x00EB1164
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

		// Token: 0x0603D163 RID: 250211 RVA: 0x00EB2F90 File Offset: 0x00EB1190
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

		// Token: 0x0603D164 RID: 250212 RVA: 0x00EB2FDC File Offset: 0x00EB11DC
		protected override void OnStart()
		{
			this.OverrideColor = true;
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SetItemStyle(i, this.Config.EffectColor, this.Config.PointColor);
			}
			base.OnStart();
		}

		// Token: 0x0603D165 RID: 250213 RVA: 0x00EB302C File Offset: 0x00EB122C
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

		// Token: 0x0603D166 RID: 250214 RVA: 0x00EB3070 File Offset: 0x00EB1270
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

		// Token: 0x0603D167 RID: 250215 RVA: 0x00EB30DF File Offset: 0x00EB12DF
		protected override void OnAttributeChanged()
		{
			this.CurrentPercent = base.GetTargetAttributePercent();
			this.OnBarPercentChanged();
		}

		// Token: 0x0603D168 RID: 250216 RVA: 0x00EB30F3 File Offset: 0x00EB12F3
		protected override void OnMaxAttributeChanged()
		{
			this.CurrentPercent = base.GetTargetAttributePercent();
			this.OnBarPercentChanged();
		}

		// Token: 0x0603D169 RID: 250217 RVA: 0x00EB3108 File Offset: 0x00EB1308
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

		// Token: 0x0603D16A RID: 250218 RVA: 0x00EB3158 File Offset: 0x00EB1358
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

		// Token: 0x0603D16B RID: 250219 RVA: 0x00EB31A8 File Offset: 0x00EB13A8
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

		// Token: 0x0603D16C RID: 250220 RVA: 0x00EB31F8 File Offset: 0x00EB13F8
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

		// Token: 0x0603D16D RID: 250221 RVA: 0x00EB3344 File Offset: 0x00EB1544
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

		// Token: 0x0603D16E RID: 250222 RVA: 0x00EB33BC File Offset: 0x00EB15BC
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

		// Token: 0x0603D16F RID: 250223 RVA: 0x00EB3434 File Offset: 0x00EB1634
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

		// Token: 0x0603D170 RID: 250224 RVA: 0x00EB346E File Offset: 0x00EB166E
		protected override bool GetKeyEnable()
		{
			return this.IsKeyEnable;
		}

		// Token: 0x0603D171 RID: 250225 RVA: 0x00EB3478 File Offset: 0x00EB1678
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

		// Token: 0x0603D172 RID: 250226 RVA: 0x00EB34C9 File Offset: 0x00EB16C9
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

		// Token: 0x0603D173 RID: 250227 RVA: 0x00EB34EC File Offset: 0x00EB16EC
		public bool IsPlayingConsumeAnim()
		{
			return this.RemainingFadeOutTime > 0f || this.RemainingConsumeTime > 0f || this.IsWaitingStateChange;
		}

		// Token: 0x0401FD4F RID: 130383
		private bool IsKeyEnable;

		// Token: 0x0401FD50 RID: 130384
		private float CurrentPercent;

		// Token: 0x0401FD51 RID: 130385
		private float BarPercent;

		// Token: 0x0401FD52 RID: 130386
		private float FadeOutTime;

		// Token: 0x0401FD53 RID: 130387
		private float ConsumeTime;

		// Token: 0x0401FD54 RID: 130388
		private float RemainingFadeOutTime;

		// Token: 0x0401FD55 RID: 130389
		private float RemainingConsumeTime;

		// Token: 0x0401FD56 RID: 130390
		private static readonly float BaseBgEffectLength = 0.4f;

		// Token: 0x0401FD57 RID: 130391
		private bool IsConsumeEffectActive;

		// Token: 0x0401FD58 RID: 130392
		private float WaitingTime;

		// Token: 0x0401FD59 RID: 130393
		private bool IsInStrengthState;

		// Token: 0x0401FD5A RID: 130394
		private bool IsWaitingStateChange;

		// Token: 0x0401FD5B RID: 130395
		private static readonly float DEFAULT_FADE_OUT_TIME = 1.2f;

		// Token: 0x0401FD5C RID: 130396
		private static readonly float DEFAULT_CONSUME_TIME = 0.5f;

		// Token: 0x0200C105 RID: 49413
		private class SpecialEnergyBarJingRanSlotItem : SpecialEnergyBarSlotItem
		{
			// Token: 0x060503EF RID: 328687 RVA: 0x0158FACC File Offset: 0x0158DCCC
			protected override void OnStart()
			{
				base.OnStart();
				base.GetUiNiagara(9).SetUIActive(false);
				base.GetUiNiagara(3).SetUIActive(true);
				base.GetUiNiagara(4).SetUIActive(true);
				base.GetUiNiagara(10).SetUIActive(true);
				this.InitConsumeEffectOffsetX = base.GetUiNiagara(9).GetAnchorOffsetX();
			}

			// Token: 0x060503F0 RID: 328688 RVA: 0x0158FB28 File Offset: 0x0158DD28
			protected override void OnRegisterComponent()
			{
				base.OnRegisterComponent();
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUINiagara)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUINiagara)));
			}

			// Token: 0x060503F1 RID: 328689 RVA: 0x0158FB68 File Offset: 0x0158DD68
			public void UpdateConsumePercent(float percent)
			{
				base.GetUiNiagara(9).SetNiagaraVarFloat("Dissolve", percent);
			}

			// Token: 0x060503F2 RID: 328690 RVA: 0x0158FB7D File Offset: 0x0158DD7D
			public void UpdateTextEffectPercent(float percent)
			{
				base.GetUiNiagara(10).SetNiagaraVarFloat("Dissolve", percent);
			}

			// Token: 0x060503F3 RID: 328691 RVA: 0x0158FB92 File Offset: 0x0158DD92
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

			// Token: 0x060503F4 RID: 328692 RVA: 0x0158FBC0 File Offset: 0x0158DDC0
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

			// Token: 0x060503F5 RID: 328693 RVA: 0x0158FC14 File Offset: 0x0158DE14
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

			// Token: 0x060503F6 RID: 328694 RVA: 0x0158FCC2 File Offset: 0x0158DEC2
			public void SetFullEffectAlpha(float alpha)
			{
				base.GetUiNiagara(3).SetAlpha(alpha);
				base.GetUiNiagara(4).SetAlpha(alpha);
				base.GetUiNiagara(10).SetAlpha(alpha);
			}

			// Token: 0x060503F7 RID: 328695 RVA: 0x0158FCEC File Offset: 0x0158DEEC
			public void SetConsumeEffectAlpha(float alpha)
			{
				base.GetUiNiagara(9).SetAlpha(alpha);
			}

			// Token: 0x0403A441 RID: 238657
			private float InitConsumeEffectOffsetX;

			// Token: 0x0403A442 RID: 238658
			private bool IsConsumeEffectActive;

			// Token: 0x0403A443 RID: 238659
			private bool? IsFullEffectEnable;

			// Token: 0x0200D191 RID: 53649
			private enum ESlotItemChildType
			{
				// Token: 0x0403EE30 RID: 257584
				BgSprite,
				// Token: 0x0403EE31 RID: 257585
				BarSprite,
				// Token: 0x0403EE32 RID: 257586
				PointBgSprite = 7,
				// Token: 0x0403EE33 RID: 257587
				PointFgSprite,
				// Token: 0x0403EE34 RID: 257588
				FullEffect = 3,
				// Token: 0x0403EE35 RID: 257589
				FullBgEffect,
				// Token: 0x0403EE36 RID: 257590
				ConsumeEffect = 9,
				// Token: 0x0403EE37 RID: 257591
				TextEffect
			}
		}
	}
}
