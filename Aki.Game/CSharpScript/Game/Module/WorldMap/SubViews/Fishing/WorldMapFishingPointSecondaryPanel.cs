using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02004825 RID: 18469
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingPointSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x0603058B RID: 198027 RVA: 0x00B38E65 File Offset: 0x00B37065
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x0603058C RID: 198028 RVA: 0x00B38E6C File Offset: 0x00B3706C
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapFishingPointSecondaryPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapFishingPointSecondaryPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603058D RID: 198029 RVA: 0x00B38EB0 File Offset: 0x00B370B0
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

		// Token: 0x0603058E RID: 198030 RVA: 0x00B38EEC File Offset: 0x00B370EC
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				FishingPointMarkItem fishingPointMarkItem = param[0] as FishingPointMarkItem;
				if (fishingPointMarkItem != null)
				{
					this.LayoutContext.MarkItem = fishingPointMarkItem;
					int entityId = 0;
					TTrackTarget_Int ttrackTarget_Int = fishingPointMarkItem.TrackTarget as TTrackTarget_Int;
					if (ttrackTarget_Int != null)
					{
						entityId = ttrackTarget_Int.Value;
					}
					string fishingPointNameLocalKey = FishingModel.Instance.GetFishingPointNameLocalKey(entityId);
					string multiText = TextConfig.Instance.GetMultiText(fishingPointNameLocalKey, Array.Empty<string>());
					string multiText2 = TextConfig.Instance.GetMultiText(fishingPointMarkItem.MarkConfig.MarkTitle, new string[]
					{
						multiText
					});
					UUIText title = this.LayoutContext.Title;
					if (title != null)
					{
						title.SetText(multiText2, true);
					}
					WorldMapSecondaryUiLayoutHelper.UpdateIcon(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByServerMarkItem(this.LayoutContext);
					string multiText3 = TextConfig.Instance.GetMultiText(fishingPointMarkItem.MarkConfig.MarkDesc, new string[]
					{
						multiText
					});
					UUIText descriptionText = this.LayoutContext.DescriptionText;
					if (descriptionText != null)
					{
						descriptionText.SetText(multiText3, true);
					}
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithStopDetectionStyle(this.LayoutContext);
					this.RefreshTipList();
					base.UpdateQuickGotoActive(false);
				}
			}
		}

		// Token: 0x0603058F RID: 198031 RVA: 0x00B39000 File Offset: 0x00B37200
		private void RefreshTipList()
		{
			List<IWorldMapSecondaryTipItemParam> data = new List<IWorldMapSecondaryTipItemParam>
			{
				this.GetCapacityTipItemData(),
				this.GetNeedTechTipItemData(),
				this.GetAppearTimeTipItemData()
			};
			this.WorldMapSecondaryTipList.RefreshByData(data);
		}

		// Token: 0x06030590 RID: 198032 RVA: 0x00B39044 File Offset: 0x00B37244
		private IWorldMapSecondaryTipItemParam GetCapacityTipItemData()
		{
			FishingPointMarkItem fishingPointMarkItem = this.LayoutContext.MarkItem as FishingPointMarkItem;
			int entityId = 0;
			TTrackTarget_Int ttrackTarget_Int = ((fishingPointMarkItem != null) ? fishingPointMarkItem.TrackTarget : null) as TTrackTarget_Int;
			if (ttrackTarget_Int != null)
			{
				entityId = ttrackTarget_Int.Value;
			}
			int item = FishingModel.Instance.GetFishingPointCapacityInfoTuple(entityId).Item1;
			string multiText = TextConfig.Instance.GetMultiText("Fishing_MarkText4", Array.Empty<string>());
			string desc = item.ToString();
			return new WorldMapSecondaryTipItemParam
			{
				Name = multiText,
				Desc = desc
			};
		}

		// Token: 0x06030591 RID: 198033 RVA: 0x00B390C4 File Offset: 0x00B372C4
		private IWorldMapSecondaryTipItemParam GetNeedTechTipItemData()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			int entityId = 0;
			TTrackTarget_Int ttrackTarget_Int = ((markItem != null) ? markItem.TrackTarget : null) as TTrackTarget_Int;
			if (ttrackTarget_Int != null)
			{
				entityId = ttrackTarget_Int.Value;
			}
			string fishingPointTechNameLocalKey = FishingModel.Instance.GetFishingPointTechNameLocalKey(entityId);
			string multiText = TextConfig.Instance.GetMultiText("Fishing_MarkText2", Array.Empty<string>());
			string multiText2 = TextConfig.Instance.GetMultiText(fishingPointTechNameLocalKey, Array.Empty<string>());
			return new WorldMapSecondaryTipItemParam
			{
				Name = multiText,
				Desc = multiText2
			};
		}

		// Token: 0x06030592 RID: 198034 RVA: 0x00B39144 File Offset: 0x00B37344
		private IWorldMapSecondaryTipItemParam GetAppearTimeTipItemData()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			int entityId = 0;
			TTrackTarget_Int ttrackTarget_Int = ((markItem != null) ? markItem.TrackTarget : null) as TTrackTarget_Int;
			if (ttrackTarget_Int != null)
			{
				entityId = ttrackTarget_Int.Value;
			}
			string fishingPointAppearTimeLocalKey = FishingModel.Instance.GetFishingPointAppearTimeLocalKey(entityId);
			string multiText = TextConfig.Instance.GetMultiText("Fishing_MarkText3", Array.Empty<string>());
			string multiText2 = TextConfig.Instance.GetMultiText(fishingPointAppearTimeLocalKey, Array.Empty<string>());
			return new WorldMapSecondaryTipItemParam
			{
				Name = multiText,
				Desc = multiText2
			};
		}

		// Token: 0x06030593 RID: 198035 RVA: 0x00B391C1 File Offset: 0x00B373C1
		protected override void OnConfirmBtnClick(int index)
		{
			FishingController.Instance.RequestFishingEntrustTrace(0);
			FishingQuestModel.Instance.TraceItem(0);
			base.Close();
		}

		// Token: 0x0401A01A RID: 106522
		private WorldMapSecondaryTipListPanel WorldMapSecondaryTipList;

		// Token: 0x0200AAFA RID: 43770
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033F99 RID: 212889
			public const int FishingPoint = 0;
		}
	}
}
