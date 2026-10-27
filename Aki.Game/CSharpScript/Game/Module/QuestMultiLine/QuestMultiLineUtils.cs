using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02004FA9 RID: 20393
	[NullableContext(1)]
	[Nullable(0)]
	public static class QuestMultiLineUtils
	{
		// Token: 0x06034343 RID: 213827 RVA: 0x00C411AA File Offset: 0x00C3F3AA
		public static float ClampValue(float value, float min, float max)
		{
			return Math.Max(min, Math.Min(max, value));
		}

		// Token: 0x06034344 RID: 213828 RVA: 0x00C411B9 File Offset: 0x00C3F3B9
		public static string GetComponentIconTexture(QuestMultiLineComponentData component)
		{
			return QuestMultiLineUtils.GetIconForGender(component.ComponentIcon);
		}

		// Token: 0x06034345 RID: 213829 RVA: 0x00C411C6 File Offset: 0x00C3F3C6
		public static bool IsMultiPersonAvatar(QuestMultiLineComponentData component)
		{
			return component.ComponentIcon.Length == 0;
		}

		// Token: 0x06034346 RID: 213830 RVA: 0x00C411D2 File Offset: 0x00C3F3D2
		public static bool IsComponentClickable(QuestMultiLineComponentData component)
		{
			return component.Type == 1 || component.Type == 3;
		}

		// Token: 0x06034347 RID: 213831 RVA: 0x00C411E8 File Offset: 0x00C3F3E8
		public static string GetMultiPersonAvatarTexture(QuestMultiLineComponentData component)
		{
			return QuestMultiLineUtils.GetIconForGender(component.MultiPersonAvatar);
		}

		// Token: 0x06034348 RID: 213832 RVA: 0x00C411F8 File Offset: 0x00C3F3F8
		public static string GetIconForGender(string[] icons)
		{
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if (icons.Length < 2 || playerGender == EPlayerGender.None)
			{
				return icons[0];
			}
			return icons[(int)playerGender];
		}

		// Token: 0x06034349 RID: 213833 RVA: 0x00C41224 File Offset: 0x00C3F424
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

		// Token: 0x0603434A RID: 213834 RVA: 0x00C412D0 File Offset: 0x00C3F4D0
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

		// Token: 0x0603434B RID: 213835 RVA: 0x00C41358 File Offset: 0x00C3F558
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

		// Token: 0x0603434C RID: 213836 RVA: 0x00C413F4 File Offset: 0x00C3F5F4
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

		// Token: 0x0603434D RID: 213837 RVA: 0x00C4144C File Offset: 0x00C3F64C
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

		// Token: 0x0603434E RID: 213838 RVA: 0x00C414B0 File Offset: 0x00C3F6B0
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

		// Token: 0x0603434F RID: 213839 RVA: 0x00C414EC File Offset: 0x00C3F6EC
		public static TArray<FVector2D> PointArrayToVectorArray(IReadOnlyList<global::Vector> points)
		{
			TArray<FVector2D> tarray = new TArray<FVector2D>();
			foreach (global::Vector vector in points)
			{
				tarray.Add(new FVector2D((float)vector.X, (float)vector.Y));
			}
			return tarray;
		}

		// Token: 0x06034350 RID: 213840 RVA: 0x00C41550 File Offset: 0x00C3F750
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

		// Token: 0x06034351 RID: 213841 RVA: 0x00C41574 File Offset: 0x00C3F774
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
