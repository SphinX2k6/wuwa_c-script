using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DCC RID: 24012
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarAoGuSiTaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D06A RID: 249962 RVA: 0x00EACF4E File Offset: 0x00EAB14E
		protected override void OnInitData()
		{
			this.ExtraConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130601));
			this.ExtraConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130602));
		}

		// Token: 0x0603D06B RID: 249963 RVA: 0x00EACF90 File Offset: 0x00EAB190
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

		// Token: 0x0603D06C RID: 249964 RVA: 0x00EACFDB File Offset: 0x00EAB1DB
		public void SetKeyItemEnable(int type, bool enable, bool isStart = false)
		{
			this.KeyItemList[type].RefreshKeyEnable(enable, isStart);
		}

		// Token: 0x0603D06D RID: 249965 RVA: 0x00EACFF0 File Offset: 0x00EAB1F0
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

		// Token: 0x0401FCB4 RID: 130228
		private readonly List<SpecialEnergyBarInfo> ExtraConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401FCB5 RID: 130229
		private readonly List<SpecialEnergyBarKeyItem> KeyItemList = new List<SpecialEnergyBarKeyItem>();

		// Token: 0x0401FCB6 RID: 130230
		private int KeyItemType = -1;
	}
}
