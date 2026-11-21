using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Reward;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x020054CC RID: 21708
	[NullableContext(1)]
	[Nullable(0)]
	public class LinkageRewardActivityController : ActivityControllerBase
	{
		// Token: 0x06035CA5 RID: 220325 RVA: 0x00F06B60 File Offset: 0x00F04D60
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06035CA6 RID: 220326 RVA: 0x00F06B62 File Offset: 0x00F04D62
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCyberWelfare";
		}

		// Token: 0x06035CA7 RID: 220327 RVA: 0x00F06B69 File Offset: 0x00F04D69
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new LinkageRewardActivitySubView();
		}

		// Token: 0x06035CA8 RID: 220328 RVA: 0x00F06B70 File Offset: 0x00F04D70
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new LinkageRewardActivityData();
		}

		// Token: 0x06035CA9 RID: 220329 RVA: 0x00F06B77 File Offset: 0x00F04D77
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06035CAA RID: 220330 RVA: 0x00F06B7C File Offset: 0x00F04D7C
		[NullableContext(2)]
		public static void ClaimAllRewardsByController(int activityId, int fallbackId, LinkageCheckInType fallbackType, Action onFinished = null)
		{
			LinkageRewardActivityData activityData = LinkageRewardActivityController.GetActivityData(activityId);
			if (activityData == null)
			{
				LinkageRewardActivityController.GetRewardById(activityId, fallbackId, fallbackType, new int[]
				{
					fallbackId
				}, delegate(bool _)
				{
					Action onFinished2 = onFinished;
					if (onFinished2 == null)
					{
						return;
					}
					onFinished2();
				});
				return;
			}
			LinkageCheckInType linkageCheckInType = LinkageCheckInType.KeepCheckIn;
			LinkageCheckInType normalType = LinkageCheckInType.NormalCheckIn;
			int[] unlockUnclaimedRewardIds = activityData.GetUnlockUnclaimedRewardIds(linkageCheckInType);
			int[] normalIds = activityData.GetUnlockUnclaimedRewardIds(normalType);
			List<RewardItemData> keepPreviewRewards = LinkageRewardActivityController.BuildPreviewRewardItems(unlockUnclaimedRewardIds, linkageCheckInType);
			List<RewardItemData> normalPreviewRewards = LinkageRewardActivityController.BuildPreviewRewardItems(normalIds, normalType);
			if (unlockUnclaimedRewardIds.Length != 0 && normalIds.Length != 0)
			{
				List<RewardItemData> mergedRewards = new List<RewardItemData>();
				Action<bool> <>9__5;
				LinkageRewardActivityController.GetRewardById(activityId, unlockUnclaimedRewardIds[0], linkageCheckInType, unlockUnclaimedRewardIds, delegate(bool isKeepSuccess)
				{
					if (isKeepSuccess)
					{
						mergedRewards.AddRange(keepPreviewRewards);
						int activityId2 = activityId;
						int[] normalIds;
						int id = normalIds[0];
						LinkageCheckInType normalType = normalType;
						normalIds = normalIds;
						Action<bool> onResponse;
						if ((onResponse = <>9__5) == null)
						{
							onResponse = (<>9__5 = delegate(bool isNormalSuccess)
							{
								if (isNormalSuccess)
								{
									mergedRewards.AddRange(normalPreviewRewards);
								}
								LinkageRewardActivityController.OpenMergedRewardView(LinkageRewardActivityController.MergeRewardItems(mergedRewards));
								Action onFinished3 = onFinished;
								if (onFinished3 == null)
								{
									return;
								}
								onFinished3();
							});
						}
						LinkageRewardActivityController.GetRewardById(activityId2, id, normalType, normalIds, onResponse);
						return;
					}
					Action onFinished2 = onFinished;
					if (onFinished2 == null)
					{
						return;
					}
					onFinished2();
				});
				return;
			}
			if (unlockUnclaimedRewardIds.Length != 0)
			{
				LinkageRewardActivityController.GetRewardById(activityId, unlockUnclaimedRewardIds[0], linkageCheckInType, unlockUnclaimedRewardIds, delegate(bool isSuccess)
				{
					if (isSuccess)
					{
						LinkageRewardActivityController.OpenMergedRewardView(keepPreviewRewards);
					}
					Action onFinished2 = onFinished;
					if (onFinished2 == null)
					{
						return;
					}
					onFinished2();
				});
				return;
			}
			if (normalIds.Length != 0)
			{
				LinkageRewardActivityController.GetRewardById(activityId, normalIds[0], normalType, normalIds, delegate(bool isSuccess)
				{
					if (isSuccess)
					{
						LinkageRewardActivityController.OpenMergedRewardView(normalPreviewRewards);
					}
					Action onFinished2 = onFinished;
					if (onFinished2 == null)
					{
						return;
					}
					onFinished2();
				});
				return;
			}
			LinkageRewardActivityController.GetRewardById(activityId, fallbackId, fallbackType, new int[]
			{
				fallbackId
			}, delegate(bool _)
			{
				Action onFinished2 = onFinished;
				if (onFinished2 == null)
				{
					return;
				}
				onFinished2();
			});
		}

		// Token: 0x06035CAB RID: 220331 RVA: 0x00F06CDC File Offset: 0x00F04EDC
		[NullableContext(2)]
		public static void GetRewardById(int activityId, int id, LinkageCheckInType linkageCheckInType, int[] rewardIds = null, Action<bool> onResponse = null)
		{
			LinkageRewardActivityController.<>c__DisplayClass6_0 CS$<>8__locals1 = new LinkageRewardActivityController.<>c__DisplayClass6_0();
			CS$<>8__locals1.linkageCheckInType = linkageCheckInType;
			CS$<>8__locals1.onResponse = onResponse;
			LinkageCheckInRewardRequest linkageCheckInRewardRequest = LinkageCheckInRewardRequest.Create();
			LinkageRewardActivityController.<>c__DisplayClass6_0 CS$<>8__locals2 = CS$<>8__locals1;
			int[] taskIds;
			if (rewardIds == null || rewardIds.Length == 0)
			{
				(taskIds = new int[1])[0] = id;
			}
			else
			{
				taskIds = rewardIds;
			}
			CS$<>8__locals2.taskIds = taskIds;
			linkageCheckInRewardRequest.TaskIds.AddRange(CS$<>8__locals1.taskIds);
			linkageCheckInRewardRequest.Type = CS$<>8__locals1.linkageCheckInType;
			CS$<>8__locals1.activityData = (ActivityModel.Instance.GetActivityById(activityId) as LinkageRewardActivityData);
			LinkageRewardActivityData activityData = CS$<>8__locals1.activityData;
			if (activityData != null)
			{
				activityData.SetRewardsToGotState(CS$<>8__locals1.taskIds, CS$<>8__locals1.linkageCheckInType);
			}
			Net.Instance.Call(ERequestMessageId.LinkageCheckInRewardRequest, linkageCheckInRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				LinkageCheckInRewardResponse linkageCheckInRewardResponse = (LinkageCheckInRewardResponse)msg;
				bool flag = linkageCheckInRewardResponse != null && linkageCheckInRewardResponse.ErrorCode == Aki.Protocol.ErrorCode.Success;
				if (!flag)
				{
					LinkageRewardActivityData activityData2 = CS$<>8__locals1.activityData;
					if (activityData2 != null)
					{
						activityData2.RevertOptimisticClaimReward(CS$<>8__locals1.taskIds, CS$<>8__locals1.linkageCheckInType);
					}
					if (linkageCheckInRewardResponse != null)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(linkageCheckInRewardResponse.ErrorCode, 19375, null, true, true);
					}
				}
				Action<bool> onResponse2 = CS$<>8__locals1.onResponse;
				if (onResponse2 == null)
				{
					return;
				}
				onResponse2(flag);
			}, 0);
		}

		// Token: 0x06035CAC RID: 220332 RVA: 0x00F06D8B File Offset: 0x00F04F8B
		[NullableContext(2)]
		private static LinkageRewardActivityData GetActivityData(int activityId)
		{
			return ActivityModel.Instance.GetActivityById(activityId) as LinkageRewardActivityData;
		}

		// Token: 0x06035CAD RID: 220333 RVA: 0x00F06DA0 File Offset: 0x00F04FA0
		private static List<RewardItemData> BuildPreviewRewardItems(IReadOnlyList<int> rewardIds, LinkageCheckInType linkageType)
		{
			Dictionary<string, RewardItemData> dictionary = new Dictionary<string, RewardItemData>();
			foreach (int id in rewardIds)
			{
				LinkageReward? byId = LinkageRewardActivityConfig.Instance.GetById(id);
				if (byId != null)
				{
					int num = (linkageType == LinkageCheckInType.KeepCheckIn) ? ((byId.Value.KeepDropId > 0) ? byId.Value.KeepDropId : byId.Value.DropId) : byId.Value.DropId;
					if (num > 0)
					{
						foreach (TItem titem in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(num))
						{
							int itemId = titem.ItemData.ItemId;
							int incId = titem.ItemData.IncId;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
							defaultInterpolatedStringHandler.AppendFormatted<int>(itemId);
							string key = defaultInterpolatedStringHandler.ToStringAndClear();
							RewardItemData rewardItemData;
							if (dictionary.TryGetValue(key, out rewardItemData))
							{
								rewardItemData.Count += titem.Count;
							}
							else
							{
								dictionary[key] = new RewardItemData(itemId, titem.Count, new int?(incId), EDropItemType.Normal);
							}
						}
					}
				}
			}
			return new List<RewardItemData>(dictionary.Values);
		}

		// Token: 0x06035CAE RID: 220334 RVA: 0x00F06F40 File Offset: 0x00F05140
		private static void OpenMergedRewardView(List<RewardItemData> rewardItems)
		{
			if (rewardItems.Count <= 0)
			{
				return;
			}
			ItemRewardController.Instance.OpenCommonRewardView(1009, rewardItems, null);
		}

		// Token: 0x06035CAF RID: 220335 RVA: 0x00F06F60 File Offset: 0x00F05160
		private static List<RewardItemData> MergeRewardItems(IReadOnlyList<RewardItemData> rewardItems)
		{
			Dictionary<int, RewardItemData> dictionary = new Dictionary<int, RewardItemData>();
			foreach (RewardItemData rewardItemData in rewardItems)
			{
				int configId = rewardItemData.ConfigId;
				RewardItemData rewardItemData2;
				if (dictionary.TryGetValue(configId, out rewardItemData2))
				{
					rewardItemData2.Count += rewardItemData.Count;
				}
				else
				{
					dictionary[configId] = new RewardItemData(configId, rewardItemData.Count, new int?(rewardItemData.UniqueId), EDropItemType.Normal);
				}
			}
			return new List<RewardItemData>(dictionary.Values);
		}

		// Token: 0x170068A2 RID: 26786
		// (get) Token: 0x06035CB0 RID: 220336 RVA: 0x00F06FFC File Offset: 0x00F051FC
		public static LinkageRewardActivityController Instance
		{
			get
			{
				return LinkageRewardActivityController._Instance;
			}
		}

		// Token: 0x06035CB1 RID: 220337 RVA: 0x00F07003 File Offset: 0x00F05203
		public static LinkageRewardActivityController GetOrCreateInstance()
		{
			if (LinkageRewardActivityController._Instance == null)
			{
				LinkageRewardActivityController.CreateInstance();
			}
			return LinkageRewardActivityController._Instance;
		}

		// Token: 0x06035CB2 RID: 220338 RVA: 0x00F07017 File Offset: 0x00F05217
		public static bool CreateInstance()
		{
			if (LinkageRewardActivityController._Instance != null)
			{
				return true;
			}
			LinkageRewardActivityController._Instance = new LinkageRewardActivityController();
			return true;
		}

		// Token: 0x06035CB3 RID: 220339 RVA: 0x00F0702D File Offset: 0x00F0522D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035CB4 RID: 220340 RVA: 0x00F0702F File Offset: 0x00F0522F
		public static void ResetStaticDefaultValue()
		{
			LinkageRewardActivityController._Instance = null;
		}

		// Token: 0x06035CB5 RID: 220341 RVA: 0x00F07037 File Offset: 0x00F05237
		static LinkageRewardActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LinkageRewardActivityController.CreateStaticDefaultValue), new Action(LinkageRewardActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C76A RID: 116586
		[Nullable(2)]
		private static LinkageRewardActivityController _Instance;
	}
}
