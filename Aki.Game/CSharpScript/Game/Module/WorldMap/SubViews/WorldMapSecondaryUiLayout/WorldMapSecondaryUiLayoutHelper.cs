using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout
{
	// Token: 0x020036FA RID: 14074
	[NullableContext(1)]
	[Nullable(0)]
	public static class WorldMapSecondaryUiLayoutHelper
	{
		// Token: 0x06024A5C RID: 150108 RVA: 0x00A59014 File Offset: 0x00A57214
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

		// Token: 0x06024A5D RID: 150109 RVA: 0x00A59054 File Offset: 0x00A57254
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

		// Token: 0x06024A5E RID: 150110 RVA: 0x00A590D0 File Offset: 0x00A572D0
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

		// Token: 0x06024A5F RID: 150111 RVA: 0x00A59110 File Offset: 0x00A57310
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

		// Token: 0x06024A60 RID: 150112 RVA: 0x00A5917C File Offset: 0x00A5737C
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

		// Token: 0x06024A61 RID: 150113 RVA: 0x00A5923C File Offset: 0x00A5743C
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

		// Token: 0x06024A62 RID: 150114 RVA: 0x00A5927C File Offset: 0x00A5747C
		public static void UpdateIcon(WorldMapSecondaryUiContext context)
		{
			if (context.MarkItem != null && context.SetSpriteByPathAction != null)
			{
				context.SetSpriteByPathAction(context.MarkItem.IconPath, context.Icon, false, null, null);
			}
		}

		// Token: 0x06024A63 RID: 150115 RVA: 0x00A592C0 File Offset: 0x00A574C0
		public static void UpdateIconByServerMarkItem(WorldMapSecondaryUiContext context)
		{
			ServerMarkItem serverMarkItem = context.MarkItem as ServerMarkItem;
			if (serverMarkItem != null && context.SetSpriteByPathAction != null)
			{
				context.SetSpriteByPathAction(serverMarkItem.IconPath, context.Icon, false, null, null);
			}
		}

		// Token: 0x06024A64 RID: 150116 RVA: 0x00A59308 File Offset: 0x00A57508
		public static void UpdateDesc(WorldMapSecondaryUiContext context)
		{
			string key = "";
			ConfigMarkItem configMarkItem = context.MarkItem as ConfigMarkItem;
			if (configMarkItem != null)
			{
				MapMark? mapMark;
				key = (((configMarkItem.MarkConfig != null) ? mapMark.GetValueOrDefault().MarkDesc : null) ?? "");
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

		// Token: 0x06024A65 RID: 150117 RVA: 0x00A593F0 File Offset: 0x00A575F0
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

		// Token: 0x06024A66 RID: 150118 RVA: 0x00A59430 File Offset: 0x00A57630
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

		// Token: 0x06024A67 RID: 150119 RVA: 0x00A594D0 File Offset: 0x00A576D0
		public static void UpdateConfirmButtonTextWithFastMoveStyle(WorldMapSecondaryUiContext context)
		{
			string textContentIdById = TextConfig.Instance.GetTextContentIdById("TeleportFastMove");
			context.SetConfirmBtnText(textContentIdById, Array.Empty<object>());
		}

		// Token: 0x06024A68 RID: 150120 RVA: 0x00A594F9 File Offset: 0x00A576F9
		public static void UpdateConfirmButtonTextWithStopDetectionStyle(WorldMapSecondaryUiContext context)
		{
			context.SetConfirmBtnText("Text_TeleportStop_Text", Array.Empty<object>());
		}

		// Token: 0x06024A69 RID: 150121 RVA: 0x00A5950C File Offset: 0x00A5770C
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

		// Token: 0x06024A6A RID: 150122 RVA: 0x00A5955C File Offset: 0x00A5775C
		public static void UpdateConfirmButtonEnableClickByTeleportState(WorldMapSecondaryUiContext context)
		{
			MarkItem markItem = context.MarkItem;
			IMarkShowState markExtraShowState = MapModel.Instance.GetMarkExtraShowState((markItem != null) ? markItem.MarkId : 0);
			bool flag = markExtraShowState != null && markExtraShowState.ShowFlag == MapMarkShowFlag.ShowDisable;
			context.SetConfirmBtnEnableClick(!flag);
		}

		// Token: 0x06024A6B RID: 150123 RVA: 0x00A595A0 File Offset: 0x00A577A0
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

		// Token: 0x06024A6C RID: 150124 RVA: 0x00A595EC File Offset: 0x00A577EC
		public static void UpdateDownStateIcon(WorldMapSecondaryUiContext context)
		{
			MarkItem markItem = context.MarkItem;
			if (markItem == null)
			{
				return;
			}
			bool showChildIcon = markItem.ShowChildIcon;
			string childIconPath = markItem.ChildIconPath;
			UUISprite downStateIcon = context.DownStateIcon;
			if (downStateIcon != null)
			{
				downStateIcon.SetUIActive(showChildIcon);
			}
			if (showChildIcon && context.SetSpriteByPathAction != null)
			{
				context.SetSpriteByPathAction(childIconPath, context.DownStateIcon, false, null, null);
			}
		}

		// Token: 0x06024A6D RID: 150125 RVA: 0x00A5964C File Offset: 0x00A5784C
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

		// Token: 0x06024A6E RID: 150126 RVA: 0x00A597C4 File Offset: 0x00A579C4
		private static bool UpdateAutoPilotTrackToggleActive(WorldMapSecondaryUiAutoPilotContext context, int autoPilotAreaId)
		{
			bool flag = WorldMapSecondaryUiLayoutHelper.CheckAutoPilotTrackToggleCanShow(context, autoPilotAreaId);
			context.SetAutoPilotNavBtnActive(flag);
			return flag;
		}

		// Token: 0x06024A6F RID: 150127 RVA: 0x00A597E4 File Offset: 0x00A579E4
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
			int valueOrDefault = markItem.InstanceDungeonId.GetValueOrDefault();
			if (valueOrDefault != 0)
			{
				IEnumerable<MapRoadWays> enumerable = MapConfig.Instance.GetMapRoadWaysByMapId(markItem.MapId) ?? Array.Empty<MapRoadWays>();
				bool flag = false;
				foreach (MapRoadWays mapRoadWays in enumerable)
				{
					int[] showDungeonListArray = mapRoadWays.GetShowDungeonListArray();
					if (showDungeonListArray != null && Array.IndexOf<int>(showDungeonListArray, valueOrDefault) >= 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}
	}
}
