using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUiSet.View
{
	// Token: 0x02005E66 RID: 24166
	[NullableContext(2)]
	[Nullable(0)]
	public class EditMobileBattleViewPanel : UiPanelBase
	{
		// Token: 0x0603D707 RID: 251655 RVA: 0x00ED24E0 File Offset: 0x00ED06E0
		protected override UniTask OnBeforeStartAsync()
		{
			EditMobileBattleViewPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EditMobileBattleViewPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D708 RID: 251656 RVA: 0x00ED2523 File Offset: 0x00ED0723
		protected override void OnBeforeDestroy()
		{
			this.LguiComponentsRegistry = null;
			this.PanelData = null;
			this.BattleViewBaseActor = null;
			this.PanelItemMap.Clear();
		}

		// Token: 0x0603D709 RID: 251657 RVA: 0x00ED2548 File Offset: 0x00ED0748
		[NullableContext(1)]
		private UniTask InitializePanelItem([Nullable(2)] BattleUiSetPanelData panelData, AUIBaseActor battleViewBaseActor)
		{
			EditMobileBattleViewPanel.<InitializePanelItem>d__6 <InitializePanelItem>d__;
			<InitializePanelItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializePanelItem>d__.<>4__this = this;
			<InitializePanelItem>d__.panelData = panelData;
			<InitializePanelItem>d__.battleViewBaseActor = battleViewBaseActor;
			<InitializePanelItem>d__.<>1__state = -1;
			<InitializePanelItem>d__.<>t__builder.Start<EditMobileBattleViewPanel.<InitializePanelItem>d__6>(ref <InitializePanelItem>d__);
			return <InitializePanelItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D70A RID: 251658 RVA: 0x00ED259C File Offset: 0x00ED079C
		public void ResetAllPanelItem()
		{
			foreach (EditMobileBattleViewPanelItem editMobileBattleViewPanelItem in this.PanelItemMap.Values)
			{
				if (editMobileBattleViewPanelItem.PanelItemData != null)
				{
					editMobileBattleViewPanelItem.Reset();
				}
			}
		}

		// Token: 0x0603D70B RID: 251659 RVA: 0x00ED25FC File Offset: 0x00ED07FC
		public void SavePanelItem()
		{
			foreach (EditMobileBattleViewPanelItem editMobileBattleViewPanelItem in this.PanelItemMap.Values)
			{
				editMobileBattleViewPanelItem.OnSave();
			}
		}

		// Token: 0x0603D70C RID: 251660 RVA: 0x00ED2654 File Offset: 0x00ED0854
		public EditMobileBattleViewPanelItem GetPanelItem(int panelItemIndex)
		{
			return this.PanelItemMap.GetValueOrDefault(panelItemIndex);
		}

		// Token: 0x0603D70D RID: 251661 RVA: 0x00ED2664 File Offset: 0x00ED0864
		public void RefreshHierarchyIndex(int panelHierarchyIndex)
		{
			foreach (EditMobileBattleViewPanelItem editMobileBattleViewPanelItem in this.PanelItemMap.Values)
			{
				BattleUiSetPanelItemData panelItemData = editMobileBattleViewPanelItem.PanelItemData;
				if (panelItemData != null)
				{
					UUIItem rootItem = editMobileBattleViewPanelItem.GetRootItem();
					panelItemData.EditorHierarchyIndex = rootItem.GetHierarchyIndex();
				}
			}
		}

		// Token: 0x0603D70E RID: 251662 RVA: 0x00ED26D4 File Offset: 0x00ED08D4
		[NullableContext(1)]
		public bool IsAnyItemOverlap(UUIItem item)
		{
			TArray<AActor> components = this.LguiComponentsRegistry.Components;
			for (int i = 0; i < components.Num(); i++)
			{
				EditMobileBattleViewPanelItem panelItem = this.GetPanelItem(i);
				if (panelItem != null)
				{
					BattleUiSetPanelItemData panelItemData = panelItem.PanelItemData;
					if (panelItemData == null || panelItemData.IsCheckOverlap)
					{
						AUIBaseActor auibaseActor = components.Get(i) as AUIBaseActor;
						if (auibaseActor != null)
						{
							UUIItem uiitem = auibaseActor.GetUIItem();
							if (uiitem.IsUIActiveInHierarchy() && uiitem.IsRaycastTarget() && uiitem != item && uiitem.GetOverlapWith(item))
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x040200FA RID: 131322
		private AUIBaseActor BattleViewBaseActor;

		// Token: 0x040200FB RID: 131323
		public BattleUiSetPanelData PanelData;

		// Token: 0x040200FC RID: 131324
		[Nullable(1)]
		private readonly Dictionary<int, EditMobileBattleViewPanelItem> PanelItemMap = new Dictionary<int, EditMobileBattleViewPanelItem>();

		// Token: 0x040200FD RID: 131325
		private ULGUIComponentsRegistry LguiComponentsRegistry;
	}
}
