using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DB0 RID: 19888
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarAoGuSiTaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06031FE1 RID: 204769 RVA: 0x00DFDE42 File Offset: 0x00DFC042
		protected override void OnInitData()
		{
			this.ExtraConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130601));
			this.ExtraConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130602));
		}

		// Token: 0x06031FE2 RID: 204770 RVA: 0x00DFDE84 File Offset: 0x00DFC084
		protected override UniTask InitKeyItem(UUIItem keyItemContainer)
		{
			SpecialEnergyBarAoGuSiTaSlot.<InitKeyItem>d__4 <InitKeyItem>d__;
			<InitKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitKeyItem>d__.<>4__this = this;
			<InitKeyItem>d__.keyItemContainer = keyItemContainer;
			<InitKeyItem>d__.<>1__state = -1;
			<InitKeyItem>d__.<>t__builder.Start<SpecialEnergyBarAoGuSiTaSlot.<InitKeyItem>d__4>(ref <InitKeyItem>d__);
			return <InitKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031FE3 RID: 204771 RVA: 0x00DFDECF File Offset: 0x00DFC0CF
		public void SetKeyItemEnable(int type, bool enable, bool isStart = false)
		{
			this.KeyItemList[type].RefreshKeyEnable(enable, isStart);
		}

		// Token: 0x06031FE4 RID: 204772 RVA: 0x00DFDEE4 File Offset: 0x00DFC0E4
		public void SetKeyItemType(int type)
		{
			if (this.KeyItemType == type)
			{
				return;
			}
			this.KeyItemType = type;
			for (int i = 0; i < this.KeyItemList.Count; i++)
			{
				this.KeyItemList[i].SetUiActive(type == i);
			}
		}

		// Token: 0x0401A771 RID: 108401
		private readonly List<SpecialEnergyBarInfo> ExtraConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401A772 RID: 108402
		private readonly List<SpecialEnergyBarKeyItem> KeyItemList = new List<SpecialEnergyBarKeyItem>();

		// Token: 0x0401A773 RID: 108403
		private int KeyItemType = -1;
	}
}
