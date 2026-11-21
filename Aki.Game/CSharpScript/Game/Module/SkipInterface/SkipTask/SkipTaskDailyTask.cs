using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B53 RID: 15187
	public class SkipTaskDailyTask : SkipTask
	{
		// Token: 0x06027062 RID: 159842 RVA: 0x00AECB0C File Offset: 0x00AEAD0C
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string text = (string)data[0];
			if (!FunctionModel.Instance.IsOpen(10023005))
			{
				GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
				return;
			}
			long? num = null;
			DailyQuest dailyQuest = null;
			double? num2 = new double?(double.MaxValue);
			Dictionary<int, DailyQuest> allDailyQuest = DailyTaskModel.Instance.GetAllDailyQuest();
			if (allDailyQuest == null)
			{
				return;
			}
			if (text != "0")
			{
				int key = int.Parse(text);
				DailyQuest dailyQuest2;
				if (allDailyQuest.TryGetValue(key, out dailyQuest2))
				{
					num = dailyQuest2.TreeId;
				}
			}
			else
			{
				foreach (DailyQuest dailyQuest3 in allDailyQuest.Values)
				{
					long? treeId = dailyQuest3.TreeId;
					BehaviorNodeBase currentActiveChildQuestNode = dailyQuest3.GetCurrentActiveChildQuestNode();
					if (currentActiveChildQuestNode != null)
					{
						double? trackDistance = dailyQuest3.GetTrackDistance(currentActiveChildQuestNode.NodeId);
						double? num3 = trackDistance;
						double? num4 = num2;
						if (num3.GetValueOrDefault() < num4.GetValueOrDefault() & (num3 != null & num4 != null))
						{
							num2 = trackDistance;
							num = treeId;
							dailyQuest = dailyQuest3;
						}
					}
				}
			}
			ITrackCustomBoard currentTrackCustomBoard = dailyQuest.GetCurrentTrackCustomBoard();
			if (QuestUtil.Instance.HandleTrackCustomBoard(currentTrackCustomBoard, false))
			{
				return;
			}
			Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> allDynamicMarks = MapModel.Instance.GetAllDynamicMarks();
			if (allDynamicMarks == null)
			{
				return;
			}
			Dictionary<int, DynamicMarkCreateInfo> dictionary;
			if (!allDynamicMarks.TryGetValue(EMarkType.Quest, out dictionary))
			{
				return;
			}
			QuestMarkCreateInfo questMarkCreateInfo = null;
			foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo in dictionary.Values)
			{
				QuestMarkCreateInfo questMarkCreateInfo2 = dynamicMarkCreateInfo as QuestMarkCreateInfo;
				if (questMarkCreateInfo2 != null)
				{
					long treeId2 = questMarkCreateInfo2.TreeId;
					long? num5 = num;
					if (treeId2 == num5.GetValueOrDefault() & num5 != null)
					{
						questMarkCreateInfo = questMarkCreateInfo2;
						break;
					}
				}
			}
			if (questMarkCreateInfo == null)
			{
				return;
			}
			WorldMapViewOpenParams data2 = new WorldMapViewOpenParams
			{
				MarkId = questMarkCreateInfo.MarkId,
				MarkType = EMarkType.Quest,
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data2, null);
			base.Finish();
		}

		// Token: 0x040154D9 RID: 87257
		[Nullable(1)]
		private const string DEFAULT_TASK_ID = "0";
	}
}
