using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C85 RID: 19589
	public class BattleUiSpecialEnergyBarData
	{
		// Token: 0x06030E03 RID: 200195 RVA: 0x00DA1BD5 File Offset: 0x00D9FDD5
		public void Init()
		{
		}

		// Token: 0x06030E04 RID: 200196 RVA: 0x00DA1BD8 File Offset: 0x00D9FDD8
		public UniTask<bool> Preload()
		{
			BattleUiSpecialEnergyBarData.<Preload>d__8 <Preload>d__;
			<Preload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Preload>d__.<>4__this = this;
			<Preload>d__.<>1__state = -1;
			<Preload>d__.<>t__builder.Start<BattleUiSpecialEnergyBarData.<Preload>d__8>(ref <Preload>d__);
			return <Preload>d__.<>t__builder.Task;
		}

		// Token: 0x06030E05 RID: 200197 RVA: 0x00DA1C1B File Offset: 0x00D9FE1B
		public void OnLeaveLevel()
		{
			this.IsInit = false;
			this.IsLoading = false;
			this.DataTable = null;
			this.EnvironmentPropertyList.Clear();
			this.SpecialEnergyBarInfoMap.Clear();
		}

		// Token: 0x06030E06 RID: 200198 RVA: 0x00DA1C48 File Offset: 0x00D9FE48
		public void Clear()
		{
		}

		// Token: 0x06030E07 RID: 200199 RVA: 0x00DA1C4C File Offset: 0x00D9FE4C
		[NullableContext(2)]
		public SpecialEnergyBarInfo GetSpecialEnergyBarInfo(int id)
		{
			if (!this.IsInit)
			{
				return null;
			}
			SpecialEnergyBarInfo specialEnergyBarInfo;
			if (!this.SpecialEnergyBarInfoMap.TryGetValue(id, out specialEnergyBarInfo))
			{
				SSpecialEnergyBar dataTableRow = DataTableUtil.GetDataTableRow<SSpecialEnergyBar>(this.DataTable, id.ToString());
				specialEnergyBarInfo = new SpecialEnergyBarInfo();
				specialEnergyBarInfo.Init(id, dataTableRow);
				if (!GlobalData.IsPlayInEditor)
				{
					this.SpecialEnergyBarInfoMap[id] = specialEnergyBarInfo;
				}
			}
			return specialEnergyBarInfo;
		}

		// Token: 0x04019EF7 RID: 106231
		public bool IsOpenLog;

		// Token: 0x04019EF8 RID: 106232
		public bool IsSpecialEnergyBarEditorModeOpen;

		// Token: 0x04019EF9 RID: 106233
		[Nullable(2)]
		private UDataTable DataTable;

		// Token: 0x04019EFA RID: 106234
		[Nullable(1)]
		public List<int> EnvironmentPropertyList = new List<int>();

		// Token: 0x04019EFB RID: 106235
		[Nullable(1)]
		public Dictionary<int, SpecialEnergyBarInfo> SpecialEnergyBarInfoMap = new Dictionary<int, SpecialEnergyBarInfo>();

		// Token: 0x04019EFC RID: 106236
		private bool IsInit;

		// Token: 0x04019EFD RID: 106237
		private bool IsLoading;
	}
}
