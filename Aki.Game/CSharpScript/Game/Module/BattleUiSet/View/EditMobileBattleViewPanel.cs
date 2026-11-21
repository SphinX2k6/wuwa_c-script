using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUiSet.View
{
	// Token: 0x02004E4B RID: 20043
	[NullableContext(2)]
	[Nullable(0)]
	public class EditMobileBattleViewPanel : UiPanelBase
	{
		// Token: 0x06032697 RID: 206487 RVA: 0x00E23A50 File Offset: 0x00E21C50
		protected override UniTask OnBeforeStartAsync()
		{
			EditMobileBattleViewPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EditMobileBattleViewPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032698 RID: 206488 RVA: 0x00E23A93 File Offset: 0x00E21C93
		protected override void OnBeforeDestroy()
		{
			this.LguiComponentsRegistry = null;
			this.PanelData = null;
			this.BattleViewBaseActor = null;
			this.PanelItemMap.Clear();
		}

		// Token: 0x06032699 RID: 206489 RVA: 0x00E23AB8 File Offset: 0x00E21CB8
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

		// Token: 0x0603269A RID: 206490 RVA: 0x00E23B0C File Offset: 0x00E21D0C
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

		// Token: 0x0603269B RID: 206491 RVA: 0x00E23B6C File Offset: 0x00E21D6C
		public void SavePanelItem()
		{
			foreach (EditMobileBattleViewPanelItem editMobileBattleViewPanelItem in this.PanelItemMap.Values)
			{
				editMobileBattleViewPanelItem.OnSave();
			}
		}

		// Token: 0x0603269C RID: 206492 RVA: 0x00E23BC4 File Offset: 0x00E21DC4
		public EditMobileBattleViewPanelItem GetPanelItem(int panelItemIndex)
		{
			return this.PanelItemMap.GetValueOrDefault(panelItemIndex);
		}

		// Token: 0x0603269D RID: 206493 RVA: 0x00E23BD4 File Offset: 0x00E21DD4
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

		// Token: 0x0603269E RID: 206494 RVA: 0x00E23C44 File Offset: 0x00E21E44
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

		// Token: 0x0401ABC1 RID: 109505
		private AUIBaseActor BattleViewBaseActor;

		// Token: 0x0401ABC2 RID: 109506
		public BattleUiSetPanelData PanelData;

		// Token: 0x0401ABC3 RID: 109507
		[Nullable(1)]
		private readonly Dictionary<int, EditMobileBattleViewPanelItem> PanelItemMap = new Dictionary<int, EditMobileBattleViewPanelItem>();

		// Token: 0x0401ABC4 RID: 109508
		private ULGUIComponentsRegistry LguiComponentsRegistry;
	}
}
