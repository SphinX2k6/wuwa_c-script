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
	// Token: 0x02003756 RID: 14166
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingPointSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024D5B RID: 150875 RVA: 0x00A68F31 File Offset: 0x00A67131
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024D5C RID: 150876 RVA: 0x00A68F38 File Offset: 0x00A67138
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapFishingPointSecondaryPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapFishingPointSecondaryPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024D5D RID: 150877 RVA: 0x00A68F7C File Offset: 0x00A6717C
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

		// Token: 0x06024D5E RID: 150878 RVA: 0x00A68FB8 File Offset: 0x00A671B8
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

		// Token: 0x06024D5F RID: 150879 RVA: 0x00A690CC File Offset: 0x00A672CC
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

		// Token: 0x06024D60 RID: 150880 RVA: 0x00A69110 File Offset: 0x00A67310
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

		// Token: 0x06024D61 RID: 150881 RVA: 0x00A69190 File Offset: 0x00A67390
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

		// Token: 0x06024D62 RID: 150882 RVA: 0x00A69210 File Offset: 0x00A67410
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

		// Token: 0x06024D63 RID: 150883 RVA: 0x00A6928D File Offset: 0x00A6748D
		protected override void OnConfirmBtnClick(int index)
		{
			FishingController.Instance.RequestFishingEntrustTrace(0);
			FishingQuestModel.Instance.TraceItem(0);
			base.Close();
		}

		// Token: 0x040146CE RID: 83662
		private WorldMapSecondaryTipListPanel WorldMapSecondaryTipList;

		// Token: 0x020094A9 RID: 38057
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E719 RID: 190233
			public const int FishingPoint = 0;
		}
	}
}
