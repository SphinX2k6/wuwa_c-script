using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02003752 RID: 14162
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingCageSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024D41 RID: 150849 RVA: 0x00A6895A File Offset: 0x00A66B5A
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024D42 RID: 150850 RVA: 0x00A68964 File Offset: 0x00A66B64
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapFishingCageSecondaryPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapFishingCageSecondaryPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024D43 RID: 150851 RVA: 0x00A689A8 File Offset: 0x00A66BA8
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

		// Token: 0x06024D44 RID: 150852 RVA: 0x00A689E4 File Offset: 0x00A66BE4
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

		// Token: 0x06024D45 RID: 150853 RVA: 0x00A68A48 File Offset: 0x00A66C48
		private void RefreshTipList()
		{
			List<IWorldMapSecondaryTipItemParam> data = new List<IWorldMapSecondaryTipItemParam>
			{
				this.GetNextHarvestTimeTipItemData(),
				this.GetCapacityTipItemData()
			};
			this.WorldMapSecondaryTipList.RefreshByData(data);
		}

		// Token: 0x06024D46 RID: 150854 RVA: 0x00A68A80 File Offset: 0x00A66C80
		private IWorldMapFishingCageSecondaryTipItemParam GetNextHarvestTimeTipItemData()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			int? num;
			if (markItem == null)
			{
				num = null;
			}
			else
			{
				IMarkConfig config = markItem.Config;
				num = ((config != null) ? config.RelativeId : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			return new WorldMapFishingCageSecondaryTipItemParam
			{
				Name = "",
				Desc = "",
				RelativeId = valueOrDefault,
				TipItemType = EFishingCageSecondaryTipItemType.NextHarvestTimeStamp
			};
		}

		// Token: 0x06024D47 RID: 150855 RVA: 0x00A68AF4 File Offset: 0x00A66CF4
		private IWorldMapFishingCageSecondaryTipItemParam GetCapacityTipItemData()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			int? num;
			if (markItem == null)
			{
				num = null;
			}
			else
			{
				IMarkConfig config = markItem.Config;
				num = ((config != null) ? config.RelativeId : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			return new WorldMapFishingCageSecondaryTipItemParam
			{
				Name = "",
				Desc = "",
				RelativeId = valueOrDefault,
				TipItemType = EFishingCageSecondaryTipItemType.Capacity
			};
		}

		// Token: 0x040146CB RID: 83659
		private WorldMapFishingCageTipListPanel WorldMapSecondaryTipList;

		// Token: 0x020094A5 RID: 38053
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E711 RID: 190225
			public const int FishingCage = 0;
		}
	}
}
