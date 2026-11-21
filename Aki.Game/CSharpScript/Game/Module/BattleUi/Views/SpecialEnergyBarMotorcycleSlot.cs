using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DAB RID: 19883
	public class SpecialEnergyBarMotorcycleSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06031F8E RID: 204686 RVA: 0x00DFBC25 File Offset: 0x00DF9E25
		[NullableContext(1)]
		public void InitMotorcycleData([Nullable(2)] EntityHandle entityHandle, SpecialEnergyBarInfo config, bool needInitKeyItem = true)
		{
			this.NeedInitKeyItem = needInitKeyItem;
			if (this.Destroyed || entityHandle == null)
			{
				return;
			}
			this.Config = config;
			this.OnInitData();
			this.PercentMachine.Init(0f);
		}

		// Token: 0x06031F8F RID: 204687 RVA: 0x00DFBC58 File Offset: 0x00DF9E58
		protected override void OnStart()
		{
			base.OnStart();
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetFullEffectPercent(1f);
			}
		}

		// Token: 0x06031F90 RID: 204688 RVA: 0x00DFBCB4 File Offset: 0x00DF9EB4
		public void UpdatePercent(float percent, bool keyEnable, bool isStart)
		{
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SlotItemList[i].UpdatePercent(percent * (float)this.SlotNum - (float)i, keyEnable, false);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}
	}
}
