using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Reward;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x0200654E RID: 25934
	[NullableContext(1)]
	[Nullable(0)]
	public class LinkageRewardActivityController : ActivityControllerBase
	{
		// Token: 0x06040FE0 RID: 266208 RVA: 0x00FBFB70 File Offset: 0x00FBDD70
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06040FE1 RID: 266209 RVA: 0x00FBFB72 File Offset: 0x00FBDD72
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCyberWelfare";
		}

		// Token: 0x06040FE2 RID: 266210 RVA: 0x00FBFB79 File Offset: 0x00FBDD79
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new LinkageRewardActivitySubView();
		}

		// Token: 0x06040FE3 RID: 266211 RVA: 0x00FBFB80 File Offset: 0x00FBDD80
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new LinkageRewardActivityData();
		}

		// Token: 0x06040FE4 RID: 266212 RVA: 0x00FBFB87 File Offset: 0x00FBDD87
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06040FE5 RID: 266213 RVA: 0x00FBFB8C File Offset: 0x00FBDD8C
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

		// Token: 0x06040FE6 RID: 266214 RVA: 0x00FBFCEC File Offset: 0x00FBDEEC
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
						ErrorCodeController.Instance.OpenErrorCodeTipView(linkageCheckInRewardResponse.ErrorCode, 16096, null, true, true);
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

		// Token: 0x06040FE7 RID: 266215 RVA: 0x00FBFD9B File Offset: 0x00FBDF9B
		[NullableContext(2)]
		private static LinkageRewardActivityData GetActivityData(int activityId)
		{
			return ActivityModel.Instance.GetActivityById(activityId) as LinkageRewardActivityData;
		}

		// Token: 0x06040FE8 RID: 266216 RVA: 0x00FBFDB0 File Offset: 0x00FBDFB0
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
			return dictionary.Values.ToList<RewardItemData>();
		}

		// Token: 0x06040FE9 RID: 266217 RVA: 0x00FBFF50 File Offset: 0x00FBE150
		private static void OpenMergedRewardView(List<RewardItemData> rewardItems)
		{
			if (rewardItems.Count <= 0)
			{
				return;
			}
			ItemRewardController.Instance.OpenCommonRewardView(1009, rewardItems, null);
		}

		// Token: 0x06040FEA RID: 266218 RVA: 0x00FBFF70 File Offset: 0x00FBE170
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
			return dictionary.Values.ToList<RewardItemData>();
		}

		// Token: 0x17009540 RID: 38208
		// (get) Token: 0x06040FEB RID: 266219 RVA: 0x00FC000C File Offset: 0x00FBE20C
		public static LinkageRewardActivityController Instance
		{
			get
			{
				return LinkageRewardActivityController._Instance;
			}
		}

		// Token: 0x06040FEC RID: 266220 RVA: 0x00FC0013 File Offset: 0x00FBE213
		public static LinkageRewardActivityController GetOrCreateInstance()
		{
			if (LinkageRewardActivityController._Instance == null)
			{
				LinkageRewardActivityController.CreateInstance();
			}
			return LinkageRewardActivityController._Instance;
		}

		// Token: 0x06040FED RID: 266221 RVA: 0x00FC0027 File Offset: 0x00FBE227
		public static bool CreateInstance()
		{
			if (LinkageRewardActivityController._Instance != null)
			{
				return true;
			}
			LinkageRewardActivityController._Instance = new LinkageRewardActivityController();
			return true;
		}

		// Token: 0x06040FEE RID: 266222 RVA: 0x00FC003D File Offset: 0x00FBE23D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040FEF RID: 266223 RVA: 0x00FC003F File Offset: 0x00FBE23F
		public static void ResetStaticDefaultValue()
		{
			LinkageRewardActivityController._Instance = null;
		}

		// Token: 0x06040FF0 RID: 266224 RVA: 0x00FC0047 File Offset: 0x00FBE247
		static LinkageRewardActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LinkageRewardActivityController.CreateStaticDefaultValue), new Action(LinkageRewardActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x04021E39 RID: 138809
		[Nullable(2)]
		private static LinkageRewardActivityController _Instance;
	}
}
