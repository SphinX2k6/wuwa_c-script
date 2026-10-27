using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005CA3 RID: 23715
	public class BattleUiSpecialEnergyBarData
	{
		// Token: 0x0603BEB0 RID: 245424 RVA: 0x00E5152D File Offset: 0x00E4F72D
		public void Init()
		{
		}

		// Token: 0x0603BEB1 RID: 245425 RVA: 0x00E51530 File Offset: 0x00E4F730
		public UniTask<bool> Preload()
		{
			BattleUiSpecialEnergyBarData.<Preload>d__8 <Preload>d__;
			<Preload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Preload>d__.<>4__this = this;
			<Preload>d__.<>1__state = -1;
			<Preload>d__.<>t__builder.Start<BattleUiSpecialEnergyBarData.<Preload>d__8>(ref <Preload>d__);
			return <Preload>d__.<>t__builder.Task;
		}

		// Token: 0x0603BEB2 RID: 245426 RVA: 0x00E51573 File Offset: 0x00E4F773
		public void OnLeaveLevel()
		{
			this.IsInit = false;
			this.IsLoading = false;
			this.DataTable = null;
			this.EnvironmentPropertyList.Clear();
			this.SpecialEnergyBarInfoMap.Clear();
		}

		// Token: 0x0603BEB3 RID: 245427 RVA: 0x00E515A0 File Offset: 0x00E4F7A0
		public void Clear()
		{
		}

		// Token: 0x0603BEB4 RID: 245428 RVA: 0x00E515A4 File Offset: 0x00E4F7A4
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

		// Token: 0x0401F43E RID: 128062
		public bool IsOpenLog;

		// Token: 0x0401F43F RID: 128063
		public bool IsSpecialEnergyBarEditorModeOpen;

		// Token: 0x0401F440 RID: 128064
		[Nullable(2)]
		private UDataTable DataTable;

		// Token: 0x0401F441 RID: 128065
		[Nullable(1)]
		public List<int> EnvironmentPropertyList = new List<int>();

		// Token: 0x0401F442 RID: 128066
		[Nullable(1)]
		public Dictionary<int, SpecialEnergyBarInfo> SpecialEnergyBarInfoMap = new Dictionary<int, SpecialEnergyBarInfo>();

		// Token: 0x0401F443 RID: 128067
		private bool IsInit;

		// Token: 0x0401F444 RID: 128068
		private bool IsLoading;
	}
}
