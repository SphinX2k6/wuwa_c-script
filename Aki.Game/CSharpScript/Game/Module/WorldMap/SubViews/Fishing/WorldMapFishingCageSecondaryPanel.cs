using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02004821 RID: 18465
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingCageSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030571 RID: 198001 RVA: 0x00B3888E File Offset: 0x00B36A8E
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030572 RID: 198002 RVA: 0x00B38898 File Offset: 0x00B36A98
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapFishingCageSecondaryPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapFishingCageSecondaryPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030573 RID: 198003 RVA: 0x00B388DC File Offset: 0x00B36ADC
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			UUIVerticalLayout panelListLayout = layoutContext.PanelListLayout;
			if (panelListLayout == null)
			{
				return;
			}
			panelListLayout.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06030574 RID: 198004 RVA: 0x00B38918 File Offset: 0x00B36B18
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				ConfigMarkItem configMarkItem = param[0] as ConfigMarkItem;
				if (configMarkItem != null)
				{
					this.LayoutContext.MarkItem = configMarkItem;
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithTrackStyle(this.LayoutContext);
					this.RefreshTipList();
					base.UpdateQuickGotoActive(false);
				}
			}
		}

		// Token: 0x06030575 RID: 198005 RVA: 0x00B3897C File Offset: 0x00B36B7C
		private void RefreshTipList()
		{
			List<IWorldMapSecondaryTipItemParam> data = new List<IWorldMapSecondaryTipItemParam>
			{
				this.GetNextHarvestTimeTipItemData(),
				this.GetCapacityTipItemData()
			};
			this.WorldMapSecondaryTipList.RefreshByData(data);
		}

		// Token: 0x06030576 RID: 198006 RVA: 0x00B389B4 File Offset: 0x00B36BB4
		private IWorldMapFishingCageSecondaryTipItemParam GetNextHarvestTimeTipItemData()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			MarkConfigComponent markConfigComponent = (markItem != null) ? markItem.MarkItemEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig) : null;
			int valueOrDefault = ((markConfigComponent != null) ? markConfigComponent.RelativeId : null).GetValueOrDefault();
			return new WorldMapFishingCageSecondaryTipItemParam
			{
				Name = "",
				Desc = "",
				RelativeId = valueOrDefault,
				TipItemType = EFishingCageSecondaryTipItemType.NextHarvestTimeStamp
			};
		}

		// Token: 0x06030577 RID: 198007 RVA: 0x00B38A28 File Offset: 0x00B36C28
		private IWorldMapFishingCageSecondaryTipItemParam GetCapacityTipItemData()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			MarkConfigComponent markConfigComponent = (markItem != null) ? markItem.MarkItemEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig) : null;
			int valueOrDefault = ((markConfigComponent != null) ? markConfigComponent.RelativeId : null).GetValueOrDefault();
			return new WorldMapFishingCageSecondaryTipItemParam
			{
				Name = "",
				Desc = "",
				RelativeId = valueOrDefault,
				TipItemType = EFishingCageSecondaryTipItemType.Capacity
			};
		}

		// Token: 0x0401A017 RID: 106519
		private WorldMapFishingCageTipListPanel WorldMapSecondaryTipList;

		// Token: 0x0200AAF6 RID: 43766
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033F91 RID: 212881
			public const int FishingCage = 0;
		}
	}
}
