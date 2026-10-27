using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E04 RID: 24068
	public class SpecialEnergyBarSuoMingSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D32A RID: 250666 RVA: 0x00EBDF8C File Offset: 0x00EBC18C
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

		// Token: 0x0603D32B RID: 250667 RVA: 0x00EBDFD8 File Offset: 0x00EBC1D8
		protected override void OnStart()
		{
			this.OverrideColor = true;
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SetItemStyle(i, this.Config.EffectColor, this.Config.PointColor);
			}
			base.OnStart();
		}

		// Token: 0x0603D32C RID: 250668 RVA: 0x00EBE028 File Offset: 0x00EBC228
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

		// Token: 0x0603D32D RID: 250669 RVA: 0x00EBE07C File Offset: 0x00EBC27C
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

		// Token: 0x0603D32E RID: 250670 RVA: 0x00EBE0CC File Offset: 0x00EBC2CC
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

		// Token: 0x0603D32F RID: 250671 RVA: 0x00EBE14F File Offset: 0x00EBC34F
		protected override bool GetKeyEnable()
		{
			return this.IsInPrepareState.GetValueOrDefault() || (!this.IsInFinalState.GetValueOrDefault() && this.PercentMachine.GetCurPercent() >= 1f);
		}

		// Token: 0x0603D330 RID: 250672 RVA: 0x00EBE184 File Offset: 0x00EBC384
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

		// Token: 0x0603D331 RID: 250673 RVA: 0x00EBE1D0 File Offset: 0x00EBC3D0
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

		// Token: 0x0603D332 RID: 250674 RVA: 0x00EBE21C File Offset: 0x00EBC41C
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

		// Token: 0x0603D333 RID: 250675 RVA: 0x00EBE2AC File Offset: 0x00EBC4AC
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

		// Token: 0x0603D334 RID: 250676 RVA: 0x00EBE30C File Offset: 0x00EBC50C
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

		// Token: 0x0401FE92 RID: 130706
		private bool? IsInFinalState;

		// Token: 0x0401FE93 RID: 130707
		private bool? IsInPrepareState;

		// Token: 0x0401FE94 RID: 130708
		[Nullable(1)]
		private List<SpecialEnergyBarKeyInfo> FinalKeyInfos = new List<SpecialEnergyBarKeyInfo>();

		// Token: 0x0200C160 RID: 49504
		private class SpecialEnergyBarSuoMingSlotItem : SpecialEnergyBarSlotItem
		{
			// Token: 0x06050468 RID: 328808 RVA: 0x0159311A File Offset: 0x0159131A
			protected override void OnRegisterComponent()
			{
				base.OnRegisterComponent();
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUINiagara)));
			}

			// Token: 0x06050469 RID: 328809 RVA: 0x01593140 File Offset: 0x01591340
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

			// Token: 0x0605046A RID: 328810 RVA: 0x015931A2 File Offset: 0x015913A2
			public void UpdateFinalEffectPercent(float percent)
			{
				UUINiagara uiNiagara = base.GetUiNiagara(9);
				if (uiNiagara == null)
				{
					return;
				}
				uiNiagara.SetNiagaraVarFloat("Dissolve", percent);
			}

			// Token: 0x0403A6B3 RID: 239283
			private bool? IsUsingFinalEffect;

			// Token: 0x0200D192 RID: 53650
			private enum ESlotItemChildType
			{
				// Token: 0x0403EE39 RID: 257593
				FullEffect = 3,
				// Token: 0x0403EE3A RID: 257594
				FinalFullEffect = 9
			}
		}
	}
}
