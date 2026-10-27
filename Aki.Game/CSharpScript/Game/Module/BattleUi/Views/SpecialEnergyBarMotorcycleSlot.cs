using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DC7 RID: 24007
	public class SpecialEnergyBarMotorcycleSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D017 RID: 249879 RVA: 0x00EAAD49 File Offset: 0x00EA8F49
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

		// Token: 0x0603D018 RID: 249880 RVA: 0x00EAAD7C File Offset: 0x00EA8F7C
		protected override void OnStart()
		{
			base.OnStart();
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetFullEffectPercent(1f);
			}
		}

		// Token: 0x0603D019 RID: 249881 RVA: 0x00EAADD8 File Offset: 0x00EA8FD8
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
