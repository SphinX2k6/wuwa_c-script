using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E14 RID: 24084
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarYouNuoSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D3F3 RID: 250867 RVA: 0x00EC23FD File Offset: 0x00EC05FD
		protected override void OnInitData()
		{
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(141001));
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(141002));
		}

		// Token: 0x0603D3F4 RID: 250868 RVA: 0x00EC2440 File Offset: 0x00EC0640
		protected override UniTask InitKeyItem(UUIItem keyItemContainer)
		{
			SpecialEnergyBarYouNuoSlot.<InitKeyItem>d__6 <InitKeyItem>d__;
			<InitKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitKeyItem>d__.<>4__this = this;
			<InitKeyItem>d__.keyItemContainer = keyItemContainer;
			<InitKeyItem>d__.<>1__state = -1;
			<InitKeyItem>d__.<>t__builder.Start<SpecialEnergyBarYouNuoSlot.<InitKeyItem>d__6>(ref <InitKeyItem>d__);
			return <InitKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D3F5 RID: 250869 RVA: 0x00EC248C File Offset: 0x00EC068C
		protected override void OnStart()
		{
			this.OverrideColor = true;
			base.OnStart();
			SpecialEnergyBarInfo specialEnergyBarInfo = this.ConfigList[1];
			if (!string.IsNullOrEmpty(specialEnergyBarInfo.EffectColor))
			{
				FColor fcolor = FColor.FromHex(specialEnergyBarInfo.EffectColor);
				FLinearColor flinearColor = new FLinearColor(ref fcolor);
				foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
				{
					specialEnergyBarSlotItem.SetFullEffectColor(flinearColor, this.IsMorph);
				}
			}
			this.AddColor(this.Config);
			this.AddColor(this.ConfigList[0]);
		}

		// Token: 0x0603D3F6 RID: 250870 RVA: 0x00EC2540 File Offset: 0x00EC0740
		private void AddColor(SpecialEnergyBarInfo config)
		{
			FColor item = FColor.FromHex(config.EffectColor);
			FColor item2 = FColor.FromHex(config.PointColor);
			this.ColorList.Add(item);
			this.PointColorList.Add(item2);
		}

		// Token: 0x0603D3F7 RID: 250871 RVA: 0x00EC257D File Offset: 0x00EC077D
		public void SetFullEffectPercent(float percent)
		{
			if (this.FullEffectPercent == percent)
			{
				return;
			}
			this.FullEffectPercent = percent;
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D3F8 RID: 250872 RVA: 0x00EC2598 File Offset: 0x00EC0798
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool fullEffectEnable = curPercent >= this.FullEffectPercent;
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[i];
				float percent = curPercent * (float)this.SlotNum - (float)i;
				specialEnergyBarSlotItem.UpdatePercentWithFullEffectEnable(percent, fullEffectEnable, isStart);
			}
		}

		// Token: 0x0603D3F9 RID: 250873 RVA: 0x00EC25F5 File Offset: 0x00EC07F5
		public void SetKeyItemEnable(int type, bool enable, bool isStart = false)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			this.KeyItemList[type].RefreshKeyEnable(enable, isStart);
		}

		// Token: 0x0603D3FA RID: 250874 RVA: 0x00EC2618 File Offset: 0x00EC0818
		public void SetKeyItemType(int type)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			for (int i = 0; i < this.KeyItemList.Count; i++)
			{
				this.KeyItemList[i].SetUiActive(type == i);
			}
		}

		// Token: 0x0603D3FB RID: 250875 RVA: 0x00EC2660 File Offset: 0x00EC0860
		public void SetBarColor(int type)
		{
			if (type < this.ColorList.Count)
			{
				foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
				{
					FColor fcolor = this.ColorList[type];
					specialEnergyBarSlotItem.SetBarColor(fcolor);
					fcolor = this.PointColorList[type];
					specialEnergyBarSlotItem.SetPointColor(fcolor);
				}
			}
		}

		// Token: 0x0401FF06 RID: 130822
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401FF07 RID: 130823
		private readonly List<SpecialEnergyBarKeyItem> KeyItemList = new List<SpecialEnergyBarKeyItem>();

		// Token: 0x0401FF08 RID: 130824
		private readonly List<FColor> ColorList = new List<FColor>();

		// Token: 0x0401FF09 RID: 130825
		private readonly List<FColor> PointColorList = new List<FColor>();

		// Token: 0x0401FF0A RID: 130826
		private float FullEffectPercent = 1f;
	}
}
