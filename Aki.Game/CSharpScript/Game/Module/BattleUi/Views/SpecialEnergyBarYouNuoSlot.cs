using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DF9 RID: 19961
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarYouNuoSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06032382 RID: 205698 RVA: 0x00E1395D File Offset: 0x00E11B5D
		protected override void OnInitData()
		{
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(141001));
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(141002));
		}

		// Token: 0x06032383 RID: 205699 RVA: 0x00E139A0 File Offset: 0x00E11BA0
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

		// Token: 0x06032384 RID: 205700 RVA: 0x00E139EC File Offset: 0x00E11BEC
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

		// Token: 0x06032385 RID: 205701 RVA: 0x00E13AA0 File Offset: 0x00E11CA0
		private void AddColor(SpecialEnergyBarInfo config)
		{
			FColor item = FColor.FromHex(config.EffectColor);
			FColor item2 = FColor.FromHex(config.PointColor);
			this.ColorList.Add(item);
			this.PointColorList.Add(item2);
		}

		// Token: 0x06032386 RID: 205702 RVA: 0x00E13ADD File Offset: 0x00E11CDD
		public void SetFullEffectPercent(float percent)
		{
			if (this.FullEffectPercent == percent)
			{
				return;
			}
			this.FullEffectPercent = percent;
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032387 RID: 205703 RVA: 0x00E13AF8 File Offset: 0x00E11CF8
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

		// Token: 0x06032388 RID: 205704 RVA: 0x00E13B55 File Offset: 0x00E11D55
		public void SetKeyItemEnable(int type, bool enable, bool isStart = false)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			this.KeyItemList[type].RefreshKeyEnable(enable, isStart);
		}

		// Token: 0x06032389 RID: 205705 RVA: 0x00E13B78 File Offset: 0x00E11D78
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

		// Token: 0x0603238A RID: 205706 RVA: 0x00E13BC0 File Offset: 0x00E11DC0
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

		// Token: 0x0401A9CD RID: 109005
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401A9CE RID: 109006
		private readonly List<SpecialEnergyBarKeyItem> KeyItemList = new List<SpecialEnergyBarKeyItem>();

		// Token: 0x0401A9CF RID: 109007
		private readonly List<FColor> ColorList = new List<FColor>();

		// Token: 0x0401A9D0 RID: 109008
		private readonly List<FColor> PointColorList = new List<FColor>();

		// Token: 0x0401A9D1 RID: 109009
		private float FullEffectPercent = 1f;
	}
}
