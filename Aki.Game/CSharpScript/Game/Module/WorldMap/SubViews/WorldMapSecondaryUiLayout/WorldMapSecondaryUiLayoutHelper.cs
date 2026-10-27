using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout
{
	// Token: 0x020047C9 RID: 18377
	[NullableContext(1)]
	[Nullable(0)]
	public static class WorldMapSecondaryUiLayoutHelper
	{
		// Token: 0x0603028C RID: 197260 RVA: 0x00B291A8 File Offset: 0x00B273A8
		public static void UpdateAreaTxtByConfigMarkItem(WorldMapSecondaryUiContext context)
		{
			ConfigMarkItem configMarkItem = (ConfigMarkItem)context.MarkItem;
			string text = (configMarkItem != null) ? configMarkItem.GetAreaText() : null;
			if (!string.IsNullOrEmpty(text))
			{
				UUIText areaText = context.AreaText;
				if (areaText == null)
				{
					return;
				}
				areaText.SetText(text, true);
			}
		}

		// Token: 0x0603028D RID: 197261 RVA: 0x00B291E8 File Offset: 0x00B273E8
		public static void UpdateAreaAndIconByConfigOrDynamicConfigMarkItem(WorldMapSecondaryUiContext context)
		{
			string text = null;
			ConfigMarkItem configMarkItem = context.MarkItem as ConfigMarkItem;
			if (configMarkItem != null)
			{
				text = configMarkItem.GetAreaText();
			}
			else
			{
				DynamicConfigMarkItem dynamicConfigMarkItem = context.MarkItem as DynamicConfigMarkItem;
				if (dynamicConfigMarkItem != null)
				{
					text = dynamicConfigMarkItem.GetAreaText();
				}
			}
			bool flag = text != null;
			UUIText areaText = context.AreaText;
			if (areaText != null)
			{
				areaText.SetUIActive(flag);
			}
			UUIItem areaIconItem = context.AreaIconItem;
			if (areaIconItem != null)
			{
				areaIconItem.SetUIActive(flag);
			}
			if (flag)
			{
				UUIText areaText2 = context.AreaText;
				if (areaText2 == null)
				{
					return;
				}
				areaText2.SetText(text, true);
			}
		}

		// Token: 0x0603028E RID: 197262 RVA: 0x00B29264 File Offset: 0x00B27464
		public static void UpdateAreaTxtByServerMarkItem(WorldMapSecondaryUiContext context)
		{
			ServerMarkItem serverMarkItem = context.MarkItem as ServerMarkItem;
			string text = (serverMarkItem != null) ? serverMarkItem.GetAreaText() : null;
			if (!string.IsNullOrEmpty(text))
			{
				UUIText areaText = context.AreaText;
				if (areaText == null)
				{
					return;
				}
				areaText.SetText(text, true);
			}
		}

		// Token: 0x0603028F RID: 197263 RVA: 0x00B292A4 File Offset: 0x00B274A4
		public static void UpdateIconAndTitleByServerMarkItem(WorldMapSecondaryUiContext context)
		{
			ServerMarkItem serverMarkItem = (ServerMarkItem)context.MarkItem;
			WorldMapSecondaryUiLayoutHelper.UpdateIconByServerMarkItem(context);
			MapMark? configMark = MapConfig.Instance.GetConfigMark((serverMarkItem != null) ? serverMarkItem.ConfigId : 0);
			UUIText title = context.Title;
			if (title == null)
			{
				return;
			}
			title.ShowTextNew(((configMark != null) ? configMark.GetValueOrDefault().MarkTitle : null) ?? "");
		}

		// Token: 0x06030290 RID: 197264 RVA: 0x00B29310 File Offset: 0x00B27510
		public static void UpdateIconAndTitle(WorldMapSecondaryUiContext context)
		{
			WorldMapSecondaryUiLayoutHelper.UpdateIcon(context);
			string key = "";
			ConfigMarkItem configMarkItem = context.MarkItem as ConfigMarkItem;
			if (configMarkItem != null)
			{
				key = configMarkItem.MarkConfig.Value.MarkTitle;
			}
			else
			{
				DynamicConfigMarkItem dynamicConfigMarkItem = context.MarkItem as DynamicConfigMarkItem;
				if (dynamicConfigMarkItem != null)
				{
					key = dynamicConfigMarkItem.MarkConfig.Value.MarkTitle;
				}
				else
				{
					TraceExploreEntityMarkItem traceExploreEntityMarkItem = context.MarkItem as TraceExploreEntityMarkItem;
					if (traceExploreEntityMarkItem != null)
					{
						key = traceExploreEntityMarkItem.MarkConfig.MarkTitle;
					}
					else
					{
						FishingShipMarkItem fishingShipMarkItem = context.MarkItem as FishingShipMarkItem;
						if (fishingShipMarkItem != null)
						{
							key = fishingShipMarkItem.MarkConfig.MarkTitle;
						}
					}
				}
			}
			UUIText title = context.Title;
			if (title == null)
			{
				return;
			}
			title.ShowTextNew(key);
		}

		// Token: 0x06030291 RID: 197265 RVA: 0x00B293CC File Offset: 0x00B275CC
		public static void SetTitleUseChangeColor(WorldMapSecondaryUiContext context, bool useChangeColor)
		{
			UUIText title = context.Title;
			if (title == null)
			{
				return;
			}
			UUIText title2 = context.Title;
			FColor? fcolor;
			FColor? fcolor2;
			if (title2 == null)
			{
				fcolor = null;
				fcolor2 = fcolor;
			}
			else
			{
				fcolor2 = new FColor?(title2.changeColor);
			}
			fcolor = fcolor2;
			title.SetChangeColor(useChangeColor, fcolor);
		}

		// Token: 0x06030292 RID: 197266 RVA: 0x00B2940C File Offset: 0x00B2760C
		public static void UpdateIcon(WorldMapSecondaryUiContext context)
		{
			if (context.MarkItem != null && context.SetSpriteByPathAction != null)
			{
				context.SetSpriteByPathAction(context.MarkItem.IconPath, context.Icon, false, null, null);
			}
		}

		// Token: 0x06030293 RID: 197267 RVA: 0x00B29450 File Offset: 0x00B27650
		public static void UpdateIconByServerMarkItem(WorldMapSecondaryUiContext context)
		{
			ServerMarkItem serverMarkItem = context.MarkItem as ServerMarkItem;
			if (serverMarkItem != null && context.SetSpriteByPathAction != null)
			{
				context.SetSpriteByPathAction(serverMarkItem.IconPath, context.Icon, false, null, null);
			}
		}

		// Token: 0x06030294 RID: 197268 RVA: 0x00B29498 File Offset: 0x00B27698
		public static void UpdateDesc(WorldMapSecondaryUiContext context)
		{
			string key = "";
			ConfigMarkItem configMarkItem = context.MarkItem as ConfigMarkItem;
			if (configMarkItem != null)
			{
				ConfigMarkItem configMarkItem2 = configMarkItem;
				key = (((configMarkItem2.MarkConfig != null) ? configMarkItem2.MarkConfig.GetValueOrDefault().MarkDesc : null) ?? "");
			}
			else
			{
				DynamicConfigMarkItem dynamicConfigMarkItem = context.MarkItem as DynamicConfigMarkItem;
				if (dynamicConfigMarkItem != null)
				{
					DynamicConfigMarkItem dynamicConfigMarkItem2 = dynamicConfigMarkItem;
					key = (((dynamicConfigMarkItem2.MarkConfig != null) ? dynamicConfigMarkItem2.MarkConfig.GetValueOrDefault().MarkDesc : null) ?? "");
				}
				else
				{
					TraceExploreEntityMarkItem traceExploreEntityMarkItem = context.MarkItem as TraceExploreEntityMarkItem;
					if (traceExploreEntityMarkItem != null)
					{
						key = traceExploreEntityMarkItem.MarkConfig.MarkDesc;
					}
					else
					{
						FishingShipMarkItem fishingShipMarkItem = context.MarkItem as FishingShipMarkItem;
						if (fishingShipMarkItem != null)
						{
							key = fishingShipMarkItem.MarkConfig.MarkDesc;
						}
					}
				}
			}
			UUIText descriptionText = context.DescriptionText;
			if (descriptionText == null)
			{
				return;
			}
			descriptionText.ShowTextNew(key);
		}

		// Token: 0x06030295 RID: 197269 RVA: 0x00B29578 File Offset: 0x00B27778
		public static void UpdateBoxDesc(WorldMapSecondaryUiContext context)
		{
			IBoxMark boxMark = context.MarkItem as IBoxMark;
			UUIText descriptionText = context.DescriptionText;
			if (descriptionText == null)
			{
				return;
			}
			descriptionText.ShowTextNew(((boxMark != null) ? boxMark.GetDescText() : null) ?? "");
		}

		// Token: 0x06030296 RID: 197270 RVA: 0x00B295B8 File Offset: 0x00B277B8
		public static void UpdateServerMarkDesc(WorldMapSecondaryUiContext context)
		{
			ServerMarkItem serverMarkItem = (ServerMarkItem)context.MarkItem;
			int markId = (serverMarkItem != null) ? serverMarkItem.ConfigId : 0;
			OneOf<MapMark, DynamicMapMark>? oneOf = MapConfig.Instance.SearchMarkConfig(markId);
			string key = "";
			if (oneOf.Value.IsT1)
			{
				key = oneOf.Value.AsT1.MarkDesc;
			}
			else if (oneOf.Value.IsT2)
			{
				key = oneOf.Value.AsT2.MarkDesc;
			}
			UUIText descriptionText = context.DescriptionText;
			if (descriptionText == null)
			{
				return;
			}
			descriptionText.ShowTextNew(key);
		}

		// Token: 0x06030297 RID: 197271 RVA: 0x00B29658 File Offset: 0x00B27858
		public static void UpdateConfirmButtonTextWithFastMoveStyle(WorldMapSecondaryUiContext context)
		{
			string textContentIdById = TextConfig.Instance.GetTextContentIdById("TeleportFastMove");
			context.SetConfirmBtnText(textContentIdById, Array.Empty<object>());
		}

		// Token: 0x06030298 RID: 197272 RVA: 0x00B29681 File Offset: 0x00B27881
		public static void UpdateConfirmButtonTextWithStopDetectionStyle(WorldMapSecondaryUiContext context)
		{
			context.SetConfirmBtnText("Text_TeleportStop_Text", Array.Empty<object>());
		}

		// Token: 0x06030299 RID: 197273 RVA: 0x00B29694 File Offset: 0x00B27894
		public static void UpdateConfirmButtonTextWithTrackStyle(WorldMapSecondaryUiContext context)
		{
			MarkItem markItem = context.MarkItem;
			string id;
			if (markItem != null && markItem.IsTracked)
			{
				id = "InstanceDungeonEntranceCancelTrack";
			}
			else
			{
				id = "InstanceDungeonEntranceTrack";
			}
			string textContentIdById = TextConfig.Instance.GetTextContentIdById(id);
			context.SetConfirmBtnText(textContentIdById, Array.Empty<object>());
		}

		// Token: 0x0603029A RID: 197274 RVA: 0x00B296E4 File Offset: 0x00B278E4
		public static void UpdateConfirmButtonEnableClickByTeleportState(WorldMapSecondaryUiContext context)
		{
			MarkItem markItem = context.MarkItem;
			IMarkShowState markExtraShowState = MapModel.Instance.GetMarkExtraShowState((markItem != null) ? markItem.MarkId : 0);
			bool flag = markExtraShowState != null && markExtraShowState.ShowFlag == MapMarkShowFlag.ShowDisable;
			context.SetConfirmBtnEnableClick(!flag);
		}

		// Token: 0x0603029B RID: 197275 RVA: 0x00B29728 File Offset: 0x00B27928
		public static void UpdateTrackButtonTextWithTrackStyle(WorldMapSecondaryUiContext context)
		{
			MarkItem markItem = context.MarkItem;
			string textId;
			if (markItem != null && markItem.IsTracked)
			{
				textId = "InstanceDungeonEntranceCancelTrack";
			}
			else
			{
				textId = "InstanceDungeonEntranceTrack";
			}
			ButtonItem trackButtonItem = context.TrackButtonItem;
			if (trackButtonItem == null)
			{
				return;
			}
			trackButtonItem.SetLocalText(textId, Array.Empty<object>());
		}

		// Token: 0x0603029C RID: 197276 RVA: 0x00B29774 File Offset: 0x00B27974
		public static void UpdateDownStateIcon(WorldMapSecondaryUiContext context)
		{
			MarkItem markItem = context.MarkItem;
			if (markItem == null)
			{
				return;
			}
			bool flag = markItem.MarkItemEntity.ViewLifeCircle.IsChildViewVisible(EMarkViewComponentType.ChildIcon, false);
			string childIconPath = markItem.MarkItemEntity.Resource.ChildIconPath;
			UUISprite downStateIcon = context.DownStateIcon;
			if (downStateIcon != null)
			{
				downStateIcon.SetUIActive(flag);
			}
			if (flag && context.SetSpriteByPathAction != null)
			{
				context.SetSpriteByPathAction(childIconPath, context.DownStateIcon, false, null, null);
			}
		}

		// Token: 0x0603029D RID: 197277 RVA: 0x00B297EC File Offset: 0x00B279EC
		public static void UpdateAutoPilotState(WorldMapSecondaryUiAutoPilotContext context)
		{
			MarkItem markItem = context.LayoutContext.MarkItem;
			if (markItem == null)
			{
				return;
			}
			int autoPilotAreaId = AutoPilotController.Instance.GetAutoPilotAreaId(markItem.WorldPosition, markItem.MapId);
			if (!WorldMapSecondaryUiLayoutHelper.UpdateAutoPilotTrackToggleActive(context, autoPilotAreaId))
			{
				return;
			}
			int autoPilotAreaId2 = AutoPilotModel.Instance.AutoPilotAreaId;
			bool item = autoPilotAreaId2 != 0 && autoPilotAreaId2 == autoPilotAreaId;
			bool exploreSkillFlagEnable = ExploreSkillFlagModel.Instance.GetExploreSkillFlagEnable(EExploreSkillType.MotorcycleCruise);
			bool item2 = AutoPilotModel.Instance.CheckPlayerToTargetDistanceValid(markItem.WorldPosition);
			ValueTuple<bool, string>[] array = new ValueTuple<bool, string>[]
			{
				new ValueTuple<bool, string>(item, (autoPilotAreaId2 == 0) ? AutoPilotDefine.EAutoPilotTextId.TextAutoPilotActivated : AutoPilotDefine.EAutoPilotTextId.TextAutoPilotAreaIsolatedTips),
				new ValueTuple<bool, string>(exploreSkillFlagEnable, AutoPilotDefine.EAutoPilotTextId.TextAutoPilotForbidden),
				new ValueTuple<bool, string>(item2, AutoPilotDefine.EAutoPilotTextId.TextAutoPilotUnValidTooNearTips)
			};
			ValueTuple<bool, string>? valueTuple = null;
			foreach (ValueTuple<bool, string> valueTuple2 in array)
			{
				if (!valueTuple2.Item1)
				{
					valueTuple = new ValueTuple<bool, string>?(valueTuple2);
					break;
				}
			}
			bool isInteractive = valueTuple == null;
			if (valueTuple != null)
			{
				MapTipsActivateTipPanel mapTipsActivateTipPanel = context.LayoutContext.MapTipsActivateTipPanel;
				if (mapTipsActivateTipPanel != null)
				{
					mapTipsActivateTipPanel.SetUiActive(true);
				}
				MapTipsActivateTipPanel mapTipsActivateTipPanel2 = context.LayoutContext.MapTipsActivateTipPanel;
				if (mapTipsActivateTipPanel2 != null)
				{
					mapTipsActivateTipPanel2.SetActivatedTip(valueTuple.Value.Item2, new bool?(false));
				}
			}
			context.UpdateAutoPilotNavBtn(markItem.IsAutoPilotTracked, isInteractive);
			context.SetDownStateBtnRootActive(!markItem.IsAutoPilotTracked);
			context.RefreshAutoPilotTrackBtnGroup(markItem.IsAutoPilotTracked);
		}

		// Token: 0x0603029E RID: 197278 RVA: 0x00B29964 File Offset: 0x00B27B64
		private static bool UpdateAutoPilotTrackToggleActive(WorldMapSecondaryUiAutoPilotContext context, int autoPilotAreaId)
		{
			bool flag = WorldMapSecondaryUiLayoutHelper.CheckAutoPilotTrackToggleCanShow(context, autoPilotAreaId);
			context.SetAutoPilotNavBtnActive(flag);
			return flag;
		}

		// Token: 0x0603029F RID: 197279 RVA: 0x00B29984 File Offset: 0x00B27B84
		private static bool CheckAutoPilotTrackToggleCanShow(WorldMapSecondaryUiAutoPilotContext context, int autoPilotAreaId)
		{
			if (!WorldMapModel.Instance.IsCanAutoPilotTrack)
			{
				return false;
			}
			if (context.LayoutContext.GetIsConfirmBtnActive() || !context.LayoutContext.TrackButtonItem.IsUiActiveInHierarchy())
			{
				return false;
			}
			if (autoPilotAreaId == 0)
			{
				return false;
			}
			MarkItem markItem = context.LayoutContext.MarkItem;
			int instanceId = markItem.InstanceDungeonId.GetValueOrDefault();
			return instanceId == 0 || (MapConfig.Instance.GetMapRoadWaysByMapId(markItem.MapId) ?? Array.Empty<MapRoadWays>()).Any((MapRoadWays item) => (item.GetShowDungeonListArray() ?? Array.Empty<int>()).Contains(instanceId));
		}
	}
}
