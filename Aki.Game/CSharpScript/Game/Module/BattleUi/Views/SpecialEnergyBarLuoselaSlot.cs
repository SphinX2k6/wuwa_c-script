using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF0 RID: 24048
	public class SpecialEnergyBarLuoselaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D21D RID: 250397 RVA: 0x00EB8054 File Offset: 0x00EB6254
		protected override void OnStart()
		{
			base.OnStart();
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				SpecialEnergyBarLuoselaSlotItem specialEnergyBarLuoselaSlotItem = specialEnergyBarSlotItem as SpecialEnergyBarLuoselaSlotItem;
				if (specialEnergyBarLuoselaSlotItem != null)
				{
					specialEnergyBarLuoselaSlotItem.SetFullEffectPercent(1f);
				}
			}
		}

		// Token: 0x0603D21E RID: 250398 RVA: 0x00EB80BC File Offset: 0x00EB62BC
		[NullableContext(1)]
		protected override UniTask InitSlotItem(UUIItem slotItem)
		{
			SpecialEnergyBarLuoselaSlot.<InitSlotItem>d__3 <InitSlotItem>d__;
			<InitSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSlotItem>d__.<>4__this = this;
			<InitSlotItem>d__.slotItem = slotItem;
			<InitSlotItem>d__.<>1__state = -1;
			<InitSlotItem>d__.<>t__builder.Start<SpecialEnergyBarLuoselaSlot.<InitSlotItem>d__3>(ref <InitSlotItem>d__);
			return <InitSlotItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D21F RID: 250399 RVA: 0x00EB8108 File Offset: 0x00EB6308
		public void SwitchPointColor(bool enhanced)
		{
			SpecialEnergyBarInfo config = this.Config;
			string text;
			if (config == null)
			{
				text = null;
			}
			else
			{
				string[] pointColorList = config.PointColorList;
				text = ((pointColorList != null) ? pointColorList.ElementAtOrDefault((enhanced > false) ? 1 : 0) : null);
			}
			FColor fcolor = FColor.FromHex(text ?? "ffffff");
			FLinearColor flinearColor = FLinearColor.FromSRGBColor(fcolor);
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetPointColor(fcolor);
				specialEnergyBarSlotItem.SetBarColor(fcolor);
				specialEnergyBarSlotItem.SetFullEffectColor(flinearColor, false);
			}
		}

		// Token: 0x0603D220 RID: 250400 RVA: 0x00EB81A4 File Offset: 0x00EB63A4
		[NullableContext(2)]
		public void SwitchKeyItem(SpecialEnergyBarInfo cfg)
		{
			if (cfg != null)
			{
				this.Config = cfg;
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.SetConfig(cfg);
				}
				SpecialEnergyBarKeyItem keyItem2 = this.KeyItem;
				if (keyItem2 == null)
				{
					return;
				}
				keyItem2.SwitchToKeyInfoList(this.Config.KeyInfoList);
			}
		}

		// Token: 0x0603D221 RID: 250401 RVA: 0x00EB81E0 File Offset: 0x00EB63E0
		public void SetSlotUlt(bool b)
		{
			if (this.IsUlt == b)
			{
				return;
			}
			this.IsUlt = b;
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarLuoselaSlotItem specialEnergyBarLuoselaSlotItem = this.SlotItemList[i] as SpecialEnergyBarLuoselaSlotItem;
				if (specialEnergyBarLuoselaSlotItem != null)
				{
					specialEnergyBarLuoselaSlotItem.SetSlotItemUlt(b, i <= this.PointIndex);
				}
			}
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D222 RID: 250402 RVA: 0x00EB8244 File Offset: 0x00EB6444
		public void SetSlotPoint(int pointIndex)
		{
			this.PointIndex = pointIndex;
		}

		// Token: 0x0401FDDE RID: 130526
		private bool IsUlt;

		// Token: 0x0401FDDF RID: 130527
		private int PointIndex;
	}
}
