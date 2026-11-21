using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DE9 RID: 19945
	public class SpecialEnergyBarSuoMingSlot : SpecialEnergyBarSlot
	{
		// Token: 0x060322B9 RID: 205497 RVA: 0x00E0F4EC File Offset: 0x00E0D6EC
		[NullableContext(1)]
		protected override UniTask InitSlotItem(UUIItem slotItem)
		{
			SpecialEnergyBarSuoMingSlot.<InitSlotItem>d__4 <InitSlotItem>d__;
			<InitSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSlotItem>d__.<>4__this = this;
			<InitSlotItem>d__.slotItem = slotItem;
			<InitSlotItem>d__.<>1__state = -1;
			<InitSlotItem>d__.<>t__builder.Start<SpecialEnergyBarSuoMingSlot.<InitSlotItem>d__4>(ref <InitSlotItem>d__);
			return <InitSlotItem>d__.<>t__builder.Task;
		}

		// Token: 0x060322BA RID: 205498 RVA: 0x00E0F538 File Offset: 0x00E0D738
		protected override void OnStart()
		{
			this.OverrideColor = true;
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SetItemStyle(i, this.Config.EffectColor, this.Config.PointColor);
			}
			base.OnStart();
		}

		// Token: 0x060322BB RID: 205499 RVA: 0x00E0F588 File Offset: 0x00E0D788
		[NullableContext(2)]
		private void SetItemStyle(int index, string barColor, string pointColor)
		{
			if (!string.IsNullOrEmpty(barColor))
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[index];
				FColor fcolor = FColor.FromHex(barColor);
				specialEnergyBarSlotItem.SetBarColor(fcolor);
			}
			if (!string.IsNullOrEmpty(pointColor))
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem2 = this.SlotItemList[index];
				FColor fcolor = FColor.FromHex(pointColor);
				specialEnergyBarSlotItem2.SetPointColor(fcolor);
			}
		}

		// Token: 0x060322BC RID: 205500 RVA: 0x00E0F5DC File Offset: 0x00E0D7DC
		protected override void OnInitData()
		{
			base.OnInitData();
			this.FinalKeyInfos.Add(new SpecialEnergyBarKeyInfo
			{
				Action = 1,
				ActionType = 4
			});
			this.FinalKeyInfos.Add(new SpecialEnergyBarKeyInfo
			{
				Action = 1,
				ActionType = 6
			});
		}

		// Token: 0x060322BD RID: 205501 RVA: 0x00E0F62C File Offset: 0x00E0D82C
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[i];
				specialEnergyBarSlotItem.SetFullEffectPercent(curPercent * (float)this.SlotNum - (float)i);
				specialEnergyBarSlotItem.UpdatePercent(curPercent * (float)this.SlotNum - (float)i, curPercent >= 1f, false);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x060322BE RID: 205502 RVA: 0x00E0F6AF File Offset: 0x00E0D8AF
		protected override bool GetKeyEnable()
		{
			return this.IsInPrepareState.GetValueOrDefault() || (!this.IsInFinalState.GetValueOrDefault() && this.PercentMachine.GetCurPercent() >= 1f);
		}

		// Token: 0x060322BF RID: 205503 RVA: 0x00E0F6E4 File Offset: 0x00E0D8E4
		public void SetIsInFinalState(bool isInFinalState)
		{
			bool? isInFinalState2 = this.IsInFinalState;
			if (isInFinalState2.GetValueOrDefault() == isInFinalState & isInFinalState2 != null)
			{
				return;
			}
			this.IsInFinalState = new bool?(isInFinalState);
			this.SwitchFullEffect();
			this.SwitchKeyConfig();
			this.RefreshBarPercent(false);
		}

		// Token: 0x060322C0 RID: 205504 RVA: 0x00E0F730 File Offset: 0x00E0D930
		public void SetIsInPrepareState(bool isInPrepareState)
		{
			bool? isInPrepareState2 = this.IsInPrepareState;
			if (isInPrepareState2.GetValueOrDefault() == isInPrepareState & isInPrepareState2 != null)
			{
				return;
			}
			this.IsInPrepareState = new bool?(isInPrepareState);
			this.SwitchFullEffect();
			this.SwitchKeyConfig();
			this.RefreshBarPercent(false);
		}

		// Token: 0x060322C1 RID: 205505 RVA: 0x00E0F77C File Offset: 0x00E0D97C
		public void SwitchFullEffect()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				SpecialEnergyBarSuoMingSlot.SpecialEnergyBarSuoMingSlotItem specialEnergyBarSuoMingSlotItem = specialEnergyBarSlotItem as SpecialEnergyBarSuoMingSlot.SpecialEnergyBarSuoMingSlotItem;
				if (specialEnergyBarSuoMingSlotItem != null)
				{
					specialEnergyBarSuoMingSlotItem.SwitchFullEffect(this.IsInPrepareState.GetValueOrDefault() || this.IsInFinalState.GetValueOrDefault(), curPercent >= 1f);
				}
			}
		}

		// Token: 0x060322C2 RID: 205506 RVA: 0x00E0F80C File Offset: 0x00E0DA0C
		public void SwitchKeyConfig()
		{
			if (this.IsInPrepareState.GetValueOrDefault() || this.IsInFinalState.GetValueOrDefault())
			{
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.SetKeyType(2);
				}
				SpecialEnergyBarKeyItem keyItem2 = this.KeyItem;
				if (keyItem2 == null)
				{
					return;
				}
				keyItem2.SwitchToKeyInfoList(this.FinalKeyInfos);
				return;
			}
			else
			{
				SpecialEnergyBarKeyItem keyItem3 = this.KeyItem;
				if (keyItem3 == null)
				{
					return;
				}
				keyItem3.SwitchToDefault();
				return;
			}
		}

		// Token: 0x060322C3 RID: 205507 RVA: 0x00E0F86C File Offset: 0x00E0DA6C
		public void UpdateFinalStateRemainingPercent(float percent)
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				SpecialEnergyBarSuoMingSlot.SpecialEnergyBarSuoMingSlotItem specialEnergyBarSuoMingSlotItem = specialEnergyBarSlotItem as SpecialEnergyBarSuoMingSlot.SpecialEnergyBarSuoMingSlotItem;
				if (specialEnergyBarSuoMingSlotItem != null)
				{
					specialEnergyBarSuoMingSlotItem.UpdateFinalEffectPercent(percent);
				}
			}
		}

		// Token: 0x0401A959 RID: 108889
		private bool? IsInFinalState;

		// Token: 0x0401A95A RID: 108890
		private bool? IsInPrepareState;

		// Token: 0x0401A95B RID: 108891
		[Nullable(1)]
		private List<SpecialEnergyBarKeyInfo> FinalKeyInfos = new List<SpecialEnergyBarKeyInfo>();

		// Token: 0x0200AB6F RID: 43887
		private class SpecialEnergyBarSuoMingSlotItem : SpecialEnergyBarSlotItem
		{
			// Token: 0x060469B5 RID: 289205 RVA: 0x0154CA16 File Offset: 0x0154AC16
			protected override void OnRegisterComponent()
			{
				base.OnRegisterComponent();
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUINiagara)));
			}

			// Token: 0x060469B6 RID: 289206 RVA: 0x0154CA3C File Offset: 0x0154AC3C
			public void SwitchFullEffect(bool useFinalEffect, bool normalEffectVisible)
			{
				bool? isUsingFinalEffect = this.IsUsingFinalEffect;
				if (isUsingFinalEffect.GetValueOrDefault() == useFinalEffect & isUsingFinalEffect != null)
				{
					return;
				}
				this.IsUsingFinalEffect = new bool?(useFinalEffect);
				UUINiagara uiNiagara = base.GetUiNiagara(3);
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(!useFinalEffect && normalEffectVisible);
				}
				UUINiagara uiNiagara2 = base.GetUiNiagara(9);
				if (uiNiagara2 == null)
				{
					return;
				}
				uiNiagara2.SetUIActive(useFinalEffect);
			}

			// Token: 0x060469B7 RID: 289207 RVA: 0x0154CA9E File Offset: 0x0154AC9E
			public void UpdateFinalEffectPercent(float percent)
			{
				UUINiagara uiNiagara = base.GetUiNiagara(9);
				if (uiNiagara == null)
				{
					return;
				}
				uiNiagara.SetNiagaraVarFloat("Dissolve", percent);
			}

			// Token: 0x040350A5 RID: 217253
			private bool? IsUsingFinalEffect;

			// Token: 0x0200BD70 RID: 48496
			private enum ESlotItemChildType
			{
				// Token: 0x0403A281 RID: 238209
				FullEffect = 3,
				// Token: 0x0403A282 RID: 238210
				FinalFullEffect = 9
			}
		}
	}
}
