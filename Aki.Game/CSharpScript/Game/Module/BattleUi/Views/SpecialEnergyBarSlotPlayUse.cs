using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E2B RID: 24107
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarSlotPlayUse : SpecialEnergyBarSlot
	{
		// Token: 0x0603D4F9 RID: 251129 RVA: 0x00EC7428 File Offset: 0x00EC5628
		protected override UniTask InitSlotItem(UUIItem slotItem)
		{
			SpecialEnergyBarSlotPlayUse.<InitSlotItem>d__1 <InitSlotItem>d__;
			<InitSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSlotItem>d__.<>4__this = this;
			<InitSlotItem>d__.slotItem = slotItem;
			<InitSlotItem>d__.<>1__state = -1;
			<InitSlotItem>d__.<>t__builder.Start<SpecialEnergyBarSlotPlayUse.<InitSlotItem>d__1>(ref <InitSlotItem>d__);
			return <InitSlotItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D4FA RID: 251130 RVA: 0x00EC7474 File Offset: 0x00EC5674
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[i];
				float num = curPercent * (float)this.SlotNum - (float)i;
				specialEnergyBarSlotItem.UpdatePercent(num, keyEnable, false);
				if (this.SlotItemLastPercent[i] > 0f && num <= 0f)
				{
					specialEnergyBarSlotItem.PlayUseEffectWithPercent(this.SlotItemLastPercent[i]);
				}
				this.SlotItemLastPercent[i] = num;
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0401FF9E RID: 130974
		private readonly List<float> SlotItemLastPercent = new List<float>();
	}
}
