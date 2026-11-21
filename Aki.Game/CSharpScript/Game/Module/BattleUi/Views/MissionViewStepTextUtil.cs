using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D61 RID: 19809
	[NullableContext(1)]
	[Nullable(0)]
	public static class MissionViewStepTextUtil
	{
		// Token: 0x06031B82 RID: 203650 RVA: 0x00DE6F38 File Offset: 0x00DE5138
		public static string GetStepTextByConfig(long incId, MissionViewStepTextInfoBase config)
		{
			switch (config.ShowSource)
			{
			case EMissionItemViewDataSource.BehaviorTree:
			{
				BehaviorTreeStepTextInfo behaviorTreeStepTextInfo = (BehaviorTreeStepTextInfo)config;
				return GeneralLogicTreeController.Instance.GetTitleText(incId, behaviorTreeStepTextInfo.TidTitle, behaviorTreeStepTextInfo.QuestScheduleType, behaviorTreeStepTextInfo.UsePreStateText, behaviorTreeStepTextInfo.CustomPlaceholderBindingProgressList);
			}
			case EMissionItemViewDataSource.FishingEntrust:
				return MissionViewStepTextUtil.GetFishingEntrustStepText(config as FishingEntrustStepTextInfo);
			case EMissionItemViewDataSource.LackResourceQuest:
				return MissionViewStepTextUtil.GetLackResourceQuestStepText(config as LackResourceQuestTextInfo);
			default:
				return string.Empty;
			}
		}

		// Token: 0x06031B83 RID: 203651 RVA: 0x00DE6FA8 File Offset: 0x00DE51A8
		private static string GetFishingEntrustStepText(FishingEntrustStepTextInfo config)
		{
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(config.TidTitle);
			int itemCountByItemId = DockyardModel.Instance.GetItemCountByItemId(config.ProgressTargetId);
			int entrustProgressTotalCount = MissionViewStepTextUtil.GetEntrustProgressTotalCount(config.ProgressTargetId);
			int value = Math.Min(itemCountByItemId, entrustProgressTotalCount);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
			defaultInterpolatedStringHandler.AppendFormatted(configTextByKey.Replace("{0}", entrustProgressTotalCount.ToString()));
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entrustProgressTotalCount);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06031B84 RID: 203652 RVA: 0x00DE7046 File Offset: 0x00DE5246
		private static string GetLackResourceQuestStepText(LackResourceQuestTextInfo config)
		{
			return TextConfig.Instance.GetTextById(config.TidTitle);
		}

		// Token: 0x06031B85 RID: 203653 RVA: 0x00DE7058 File Offset: 0x00DE5258
		public static int GetEntrustProgressTotalCount(int targetItemId)
		{
			int currentTraceEntrust = FishingQuestModel.Instance.CurrentTraceEntrust;
			if (currentTraceEntrust == 0)
			{
				return 0;
			}
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(currentTraceEntrust);
			if (fishingEntrust == null)
			{
				return 0;
			}
			if (fishingEntrust.Value.EntrustType == 2)
			{
				return 0;
			}
			return fishingEntrust.Value.GetEntrustTarget(targetItemId).GetValueOrDefault();
		}

		// Token: 0x06031B86 RID: 203654 RVA: 0x00DE70B8 File Offset: 0x00DE52B8
		[NullableContext(2)]
		public static bool CheckStepTextSame(MissionViewStepTextInfoBase a, MissionViewStepTextInfoBase b)
		{
			return ((a != null) ? a.TidTitle : null) == ((b != null) ? b.TidTitle : null);
		}

		// Token: 0x06031B87 RID: 203655 RVA: 0x00DE70D8 File Offset: 0x00DE52D8
		[NullableContext(2)]
		public static bool CheckTextEqual(IMissionItemViewShowData data1, IMissionItemViewShowData data2)
		{
			if (data1 == data2)
			{
				return true;
			}
			if (data1 == null || data2 == null)
			{
				return false;
			}
			if (!MissionViewStepTextUtil.CheckStepTextSame(data1.MainStepInfo, data2.MainStepInfo))
			{
				return false;
			}
			if (data1.SubStepInfos == data2.SubStepInfos)
			{
				return true;
			}
			if (data1.SubStepInfos == null || data2.SubStepInfos == null)
			{
				return false;
			}
			if (data1.SubStepInfos.Count != data2.SubStepInfos.Count)
			{
				return false;
			}
			for (int i = 0; i < data1.SubStepInfos.Count; i++)
			{
				if (!MissionViewStepTextUtil.CheckStepTextSame(data1.SubStepInfos[i], data2.SubStepInfos[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06031B88 RID: 203656 RVA: 0x00DE717C File Offset: 0x00DE537C
		public static bool CheckShowConfigEmpty(IMissionItemViewShowData data)
		{
			if (!string.IsNullOrEmpty(data.TitleTextKey) && !string.IsNullOrEmpty(PublicUtil.Instance.GetConfigTextByKey(data.TitleTextKey)))
			{
				return false;
			}
			if (data.MainStepInfo != null && !string.IsNullOrEmpty(PublicUtil.Instance.GetConfigTextByKey(data.MainStepInfo.TidTitle)))
			{
				return false;
			}
			if (data.SubStepInfos != null)
			{
				foreach (MissionViewStepTextInfoBase missionViewStepTextInfoBase in data.SubStepInfos)
				{
					if (!string.IsNullOrEmpty(PublicUtil.Instance.GetConfigTextByKey(missionViewStepTextInfoBase.TidTitle)))
					{
						return false;
					}
				}
				return true;
			}
			return true;
		}
	}
}
