using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUiSet.View
{
	// Token: 0x02004E4A RID: 20042
	[NullableContext(1)]
	[Nullable(0)]
	public class EditMobileBattleView : UiPanelBase
	{
		// Token: 0x0603268D RID: 206477 RVA: 0x00E23783 File Offset: 0x00E21983
		public EditMobileBattleView(UUIItem parentItem)
		{
			base.CreateThenShowByResourceIdAsync("UiView_FightEdit", parentItem, false).Forget();
		}

		// Token: 0x0603268E RID: 206478 RVA: 0x00E237A8 File Offset: 0x00E219A8
		protected override UniTask OnBeforeStartAsync()
		{
			EditMobileBattleView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EditMobileBattleView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603268F RID: 206479 RVA: 0x00E237EC File Offset: 0x00E219EC
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

		// Token: 0x06032690 RID: 206480 RVA: 0x00E23850 File Offset: 0x00E21A50
		private UniTask InitializePanel()
		{
			EditMobileBattleView.<InitializePanel>d__4 <InitializePanel>d__;
			<InitializePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializePanel>d__.<>4__this = this;
			<InitializePanel>d__.<>1__state = -1;
			<InitializePanel>d__.<>t__builder.Start<EditMobileBattleView.<InitializePanel>d__4>(ref <InitializePanel>d__);
			return <InitializePanel>d__.<>t__builder.Task;
		}

		// Token: 0x06032691 RID: 206481 RVA: 0x00E23894 File Offset: 0x00E21A94
		public void ResetAllPanelItem()
		{
			foreach (EditMobileBattleViewPanel editMobileBattleViewPanel in this.PanelMap.Values)
			{
				editMobileBattleViewPanel.ResetAllPanelItem();
			}
		}

		// Token: 0x06032692 RID: 206482 RVA: 0x00E238EC File Offset: 0x00E21AEC
		public void SavePanelItem()
		{
			foreach (EditMobileBattleViewPanel editMobileBattleViewPanel in this.PanelMap.Values)
			{
				editMobileBattleViewPanel.SavePanelItem();
			}
		}

		// Token: 0x06032693 RID: 206483 RVA: 0x00E23944 File Offset: 0x00E21B44
		[NullableContext(2)]
		public EditMobileBattleViewPanel GetPanel(int panelIndex)
		{
			return this.PanelMap.GetValueOrDefault(panelIndex);
		}

		// Token: 0x06032694 RID: 206484 RVA: 0x00E23954 File Offset: 0x00E21B54
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

		// Token: 0x06032695 RID: 206485 RVA: 0x00E23984 File Offset: 0x00E21B84
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

		// Token: 0x06032696 RID: 206486 RVA: 0x00E239F0 File Offset: 0x00E21BF0
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

		// Token: 0x0401ABC0 RID: 109504
		private readonly Dictionary<int, EditMobileBattleViewPanel> PanelMap = new Dictionary<int, EditMobileBattleViewPanel>();
	}
}
