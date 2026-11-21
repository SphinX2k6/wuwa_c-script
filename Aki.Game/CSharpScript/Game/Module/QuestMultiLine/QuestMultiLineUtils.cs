using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02003F72 RID: 16242
	[NullableContext(1)]
	[Nullable(0)]
	public static class QuestMultiLineUtils
	{
		// Token: 0x060291B1 RID: 168369 RVA: 0x00B8A956 File Offset: 0x00B88B56
		public static float ClampValue(float value, float min, float max)
		{
			return Math.Max(min, Math.Min(max, value));
		}

		// Token: 0x060291B2 RID: 168370 RVA: 0x00B8A965 File Offset: 0x00B88B65
		public static string GetComponentIconTexture(QuestMultiLineComponentData component)
		{
			return QuestMultiLineUtils.GetIconForGender(component.ComponentIcon);
		}

		// Token: 0x060291B3 RID: 168371 RVA: 0x00B8A972 File Offset: 0x00B88B72
		public static bool IsMultiPersonAvatar(QuestMultiLineComponentData component)
		{
			return component.ComponentIcon.Length == 0;
		}

		// Token: 0x060291B4 RID: 168372 RVA: 0x00B8A97E File Offset: 0x00B88B7E
		public static bool IsComponentClickable(QuestMultiLineComponentData component)
		{
			return component.Type == 1 || component.Type == 3;
		}

		// Token: 0x060291B5 RID: 168373 RVA: 0x00B8A994 File Offset: 0x00B88B94
		public static string GetMultiPersonAvatarTexture(QuestMultiLineComponentData component)
		{
			return QuestMultiLineUtils.GetIconForGender(component.MultiPersonAvatar);
		}

		// Token: 0x060291B6 RID: 168374 RVA: 0x00B8A9A4 File Offset: 0x00B88BA4
		public static string GetIconForGender(string[] icons)
		{
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if (icons.Length < 2 || playerGender == EPlayerGender.None)
			{
				return icons[0];
			}
			return icons[(int)playerGender];
		}

		// Token: 0x060291B7 RID: 168375 RVA: 0x00B8A9D0 File Offset: 0x00B88BD0
		public static List<QuestMultiLineComponentData> GetBranchPageComponents([Nullable(2)] QuestMultiLineBranchPageData branchPageData)
		{
			if (branchPageData == null)
			{
				return new List<QuestMultiLineComponentData>();
			}
			List<QuestMultiLineBranchData> branchData = branchPageData.BranchData;
			if (branchData == null)
			{
				return new List<QuestMultiLineComponentData>();
			}
			List<QuestMultiLineComponentData> list = new List<QuestMultiLineComponentData>();
			foreach (QuestMultiLineBranchData questMultiLineBranchData in branchData)
			{
				foreach (QuestMultiLineComponentData item in questMultiLineBranchData.Components)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060291B8 RID: 168376 RVA: 0x00B8AA7C File Offset: 0x00B88C7C
		public static Dictionary<int, bool> GetBranchPageFightAreas([Nullable(2)] QuestMultiLineBranchPageData branchPageData)
		{
			Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
			if (branchPageData == null)
			{
				return dictionary;
			}
			List<QuestMultiLineBranchData> branchData = branchPageData.BranchData;
			if (branchData == null)
			{
				return dictionary;
			}
			foreach (QuestMultiLineBranchData questMultiLineBranchData in branchData)
			{
				foreach (int key in questMultiLineBranchData.FightingAreas)
				{
					dictionary[key] = true;
				}
			}
			return dictionary;
		}

		// Token: 0x060291B9 RID: 168377 RVA: 0x00B8AB04 File Offset: 0x00B88D04
		public static bool IsBranchSelectTimePoint(QuestMultiLineTimePointData timePoint)
		{
			if (!timePoint.IsBranchTimePoint)
			{
				return false;
			}
			QuestBranchPageConfig? branchPageConfigById = QuestMultiLineConfig.GetBranchPageConfigById(timePoint.BranchPage);
			if (branchPageConfigById == null)
			{
				return false;
			}
			QuestNewModel instance = QuestNewModel.Instance;
			foreach (IntVector2D intVector2D in branchPageConfigById.Value.QuestNodes())
			{
				global::Quest quest = instance.GetQuest(intVector2D.X);
				if (quest != null)
				{
					BaseBehaviorTree tree = quest.Tree;
					BehaviorNodeBase behaviorNodeBase = (tree != null) ? tree.GetNode(intVector2D.Y) : null;
					if (behaviorNodeBase != null && behaviorNodeBase.IsProcessing)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060291BA RID: 168378 RVA: 0x00B8ABA0 File Offset: 0x00B88DA0
		public static bool IsComponentFinish(QuestMultiLineComponentData componentData)
		{
			int[] branchFinishQuestNode = componentData.BranchFinishQuestNode;
			if (branchFinishQuestNode.Length == 0)
			{
				return true;
			}
			int questId = branchFinishQuestNode[0];
			int nodeId = branchFinishQuestNode[1];
			global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
			if (quest == null)
			{
				return false;
			}
			BaseBehaviorTree tree = quest.Tree;
			BehaviorNodeBase behaviorNodeBase = (tree != null) ? tree.GetNode(nodeId) : null;
			return behaviorNodeBase != null && behaviorNodeBase.IsSuccess;
		}

		// Token: 0x060291BB RID: 168379 RVA: 0x00B8ABF8 File Offset: 0x00B88DF8
		public static List<QuestMultiLineTimePointData> GetUnlockTimePointData(List<QuestMultiLineTimePointData> timePoints)
		{
			List<QuestMultiLineTimePointData> list = new List<QuestMultiLineTimePointData>();
			foreach (QuestMultiLineTimePointData questMultiLineTimePointData in timePoints)
			{
				list.Add(questMultiLineTimePointData);
				if (!questMultiLineTimePointData.IsUnLock)
				{
					return list;
				}
			}
			return list;
		}

		// Token: 0x060291BC RID: 168380 RVA: 0x00B8AC5C File Offset: 0x00B88E5C
		[return: Nullable(2)]
		public static QuestMultiLineTimePointData GetNextTimePoint(QuestMultiLineTimePointData timePoint)
		{
			List<QuestMultiLineTimePointData> questTimePoints = QuestMultiLineModel.Instance.GetQuestTimePoints();
			int num = questTimePoints.IndexOf(timePoint);
			if (num >= 0 && num < questTimePoints.Count - 1)
			{
				return questTimePoints[num + 1];
			}
			return null;
		}

		// Token: 0x060291BD RID: 168381 RVA: 0x00B8AC98 File Offset: 0x00B88E98
		public static TArray<FVector2D> PointArrayToVectorArray(IReadOnlyList<global::Vector> points)
		{
			TArray<FVector2D> tarray = new TArray<FVector2D>();
			foreach (global::Vector vector in points)
			{
				tarray.Add(new FVector2D((float)vector.X, (float)vector.Y));
			}
			return tarray;
		}

		// Token: 0x060291BE RID: 168382 RVA: 0x00B8ACFC File Offset: 0x00B88EFC
		public static string GetPointSpritePath(QuestMultiLineTimePointData data)
		{
			if (!data.IsUnLock)
			{
				return "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TImeBtnPointLock.SP_TImeBtnPointLock";
			}
			if (QuestMultiLineUtils.IsBranchSelectTimePoint(data))
			{
				return "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TimeBtnPointSubNor.SP_TimeBtnPointSubNor";
			}
			return "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TImeBtnPointNor.SP_TImeBtnPointNor";
		}

		// Token: 0x060291BF RID: 168383 RVA: 0x00B8AD20 File Offset: 0x00B88F20
		public static ITimePointSpritePaths GetPointSpritePaths(QuestMultiLineTimePointData data)
		{
			if (!data.IsUnLock)
			{
				return new TimePointSpritePaths
				{
					Idle = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TImeBtnPointLock.SP_TImeBtnPointLock",
					Hover = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TImeBtnPointLock.SP_TImeBtnPointLock",
					Pressed = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TImeBtnPointLock.SP_TImeBtnPointLock",
					Selected = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TImeBtnPointLock.SP_TImeBtnPointLock"
				};
			}
			if (data.IsBranchNode)
			{
				return new TimePointSpritePaths
				{
					Idle = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TimeBtnPointSubNor.SP_TimeBtnPointSubNor",
					Hover = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TimeBtnPointSubHold.SP_TimeBtnPointSubHold",
					Pressed = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TimeBtnPointSubPress.SP_TimeBtnPointSubPress",
					Selected = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TimeBtnPointSubSele.SP_TimeBtnPointSubSele"
				};
			}
			return new TimePointSpritePaths
			{
				Idle = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TImeBtnPointNor.SP_TImeBtnPointNor",
				Hover = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TimeBtnPointHold.SP_TimeBtnPointHold",
				Pressed = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TimeBtnPointPress.SP_TimeBtnPointPress",
				Selected = "/Game/Aki/UI/UIResources/UiMissionMap/Atlas/SP_TimeBtnPointSele.SP_TimeBtnPointSele"
			};
		}
	}
}
