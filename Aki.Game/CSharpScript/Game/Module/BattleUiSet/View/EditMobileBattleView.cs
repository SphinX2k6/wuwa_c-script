using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUiSet.View
{
	// Token: 0x02005E65 RID: 24165
	[NullableContext(1)]
	[Nullable(0)]
	public class EditMobileBattleView : UiPanelBase
	{
		// Token: 0x0603D6FD RID: 251645 RVA: 0x00ED2213 File Offset: 0x00ED0413
		public EditMobileBattleView(UUIItem parentItem)
		{
			base.CreateThenShowByResourceIdAsync("UiView_FightEdit", parentItem, false).Forget();
		}

		// Token: 0x0603D6FE RID: 251646 RVA: 0x00ED2238 File Offset: 0x00ED0438
		protected override UniTask OnBeforeStartAsync()
		{
			EditMobileBattleView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EditMobileBattleView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D6FF RID: 251647 RVA: 0x00ED227C File Offset: 0x00ED047C
		protected override void OnAfterShow()
		{
			BattleUiSetModel instance = BattleUiSetModel.Instance;
			foreach (BattleUiSetPanelItemData battleUiSetPanelItemData in instance.GetPanelItemDataMap().Values)
			{
				if (battleUiSetPanelItemData.IsDefaultSelected)
				{
					instance.SetPanelItemSelected(battleUiSetPanelItemData);
					break;
				}
			}
		}

		// Token: 0x0603D700 RID: 251648 RVA: 0x00ED22E0 File Offset: 0x00ED04E0
		private UniTask InitializePanel()
		{
			EditMobileBattleView.<InitializePanel>d__4 <InitializePanel>d__;
			<InitializePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializePanel>d__.<>4__this = this;
			<InitializePanel>d__.<>1__state = -1;
			<InitializePanel>d__.<>t__builder.Start<EditMobileBattleView.<InitializePanel>d__4>(ref <InitializePanel>d__);
			return <InitializePanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603D701 RID: 251649 RVA: 0x00ED2324 File Offset: 0x00ED0524
		public void ResetAllPanelItem()
		{
			foreach (EditMobileBattleViewPanel editMobileBattleViewPanel in this.PanelMap.Values)
			{
				editMobileBattleViewPanel.ResetAllPanelItem();
			}
		}

		// Token: 0x0603D702 RID: 251650 RVA: 0x00ED237C File Offset: 0x00ED057C
		public void SavePanelItem()
		{
			foreach (EditMobileBattleViewPanel editMobileBattleViewPanel in this.PanelMap.Values)
			{
				editMobileBattleViewPanel.SavePanelItem();
			}
		}

		// Token: 0x0603D703 RID: 251651 RVA: 0x00ED23D4 File Offset: 0x00ED05D4
		[NullableContext(2)]
		public EditMobileBattleViewPanel GetPanel(int panelIndex)
		{
			return this.PanelMap.GetValueOrDefault(panelIndex);
		}

		// Token: 0x0603D704 RID: 251652 RVA: 0x00ED23E4 File Offset: 0x00ED05E4
		[return: Nullable(2)]
		public EditMobileBattleViewPanelItem GetPanelItem(BattleUiSetPanelItemData panelItemData)
		{
			EditMobileBattleViewPanel editMobileBattleViewPanel;
			if (!this.PanelMap.TryGetValue(panelItemData.PanelIndex, out editMobileBattleViewPanel))
			{
				return null;
			}
			return editMobileBattleViewPanel.GetPanelItem(panelItemData.PanelItemIndex);
		}

		// Token: 0x0603D705 RID: 251653 RVA: 0x00ED2414 File Offset: 0x00ED0614
		public void RefreshHierarchyIndex()
		{
			foreach (EditMobileBattleViewPanel editMobileBattleViewPanel in this.PanelMap.Values)
			{
				if (editMobileBattleViewPanel.PanelData != null)
				{
					int hierarchyIndex = editMobileBattleViewPanel.GetRootItem().GetHierarchyIndex();
					editMobileBattleViewPanel.RefreshHierarchyIndex(hierarchyIndex);
				}
			}
		}

		// Token: 0x0603D706 RID: 251654 RVA: 0x00ED2480 File Offset: 0x00ED0680
		public bool IsAnyItemOverlap(UUIItem item)
		{
			using (Dictionary<int, EditMobileBattleViewPanel>.ValueCollection.Enumerator enumerator = this.PanelMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsAnyItemOverlap(item))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x040200F9 RID: 131321
		private readonly Dictionary<int, EditMobileBattleViewPanel> PanelMap = new Dictionary<int, EditMobileBattleViewPanel>();
	}
}
