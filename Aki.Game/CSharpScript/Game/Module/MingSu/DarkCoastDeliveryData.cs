using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053CA RID: 21450
	[NullableContext(1)]
	[Nullable(0)]
	public class DarkCoastDeliveryData : MingSuInstance
	{
		// Token: 0x06036D1D RID: 224541 RVA: 0x00CFBE00 File Offset: 0x00CFA000
		public DarkCoastDeliveryData(int id) : base(id)
		{
			if (this.DragonPoolConfig == null)
			{
				return;
			}
			DragonPool value = this.DragonPoolConfig.Value;
			for (int i = 0; i < value.DarkCoastDeliveryListLength; i++)
			{
				int id2 = value.DarkCoastDeliveryList(i);
				DarkCoastDelivery? darkCoastDeliveryById = CollectItemConfig.Instance.GetDarkCoastDeliveryById(id2);
				if (darkCoastDeliveryById != null)
				{
					DarkCoastDelivery value2 = darkCoastDeliveryById.Value;
					int goal = (i < value.GoalLength) ? value.Goal(i) : 0;
					int dropId = (i < value.DropIdsLength) ? value.DropIds(i) : 0;
					this.LevelDataList.Add(new DarkCoastDeliveryLevelData(value2, goal, dropId));
				}
			}
		}

		// Token: 0x06036D1E RID: 224542 RVA: 0x00CFBEB8 File Offset: 0x00CFA0B8
		public override void SetDragonPoolLevel(int level)
		{
			base.SetDragonPoolLevel(level);
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				this.LevelDataList[i].SetIsUnLockState(level);
			}
		}

		// Token: 0x06036D1F RID: 224543 RVA: 0x00CFBEF4 File Offset: 0x00CFA0F4
		public override void SetLevelGainList(int levelGain)
		{
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				DarkCoastDeliveryLevelData darkCoastDeliveryLevelData = this.LevelDataList[i];
				darkCoastDeliveryLevelData.SetReceiveRewardState(levelGain >= darkCoastDeliveryLevelData.Id);
			}
		}

		// Token: 0x06036D20 RID: 224544 RVA: 0x00CFBF38 File Offset: 0x00CFA138
		public void RefreshLevelDataState(int[] defeatGuardIds, int[] receivedGuardList)
		{
			for (int i = 0; i < defeatGuardIds.Length; i++)
			{
				DarkCoastDeliveryLevelData levelData = this.GetLevelData(defeatGuardIds[i]);
				if (levelData != null)
				{
					levelData.SetDefeatedGuardState(true);
				}
			}
			for (int j = 0; j < receivedGuardList.Length; j++)
			{
				DarkCoastDeliveryLevelData levelData2 = this.GetLevelData(receivedGuardList[j]);
				if (levelData2 != null)
				{
					levelData2.SetReceivedGuardRewardState(true);
				}
			}
		}

		// Token: 0x06036D21 RID: 224545 RVA: 0x00CFBF8C File Offset: 0x00CFA18C
		[NullableContext(2)]
		public DarkCoastDeliveryLevelData GetLevelData(int level)
		{
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				DarkCoastDeliveryLevelData darkCoastDeliveryLevelData = this.LevelDataList[i];
				if (darkCoastDeliveryLevelData.Id == level)
				{
					return darkCoastDeliveryLevelData;
				}
			}
			return null;
		}

		// Token: 0x06036D22 RID: 224546 RVA: 0x00CFBFC8 File Offset: 0x00CFA1C8
		public List<DarkCoastDeliveryLevelData> GetLevelDataList()
		{
			return this.LevelDataList;
		}

		// Token: 0x06036D23 RID: 224547 RVA: 0x00CFBFD0 File Offset: 0x00CFA1D0
		public string GetCurLevelTexturePath()
		{
			return this.GetLevelTexturePath(base.GetDragonPoolLevel());
		}

		// Token: 0x06036D24 RID: 224548 RVA: 0x00CFBFE0 File Offset: 0x00CFA1E0
		public string GetLevelTexturePath(int level)
		{
			DarkCoastDeliveryLevelData levelData = this.GetLevelData(level);
			if (levelData != null)
			{
				return levelData.Config.LevelTexture ?? "";
			}
			return ConfigCommonParamById.GetStringConfig("DarkShoreDefaultLevel") ?? "";
		}

		// Token: 0x06036D25 RID: 224549 RVA: 0x00CFC024 File Offset: 0x00CFA224
		public IActivityRewardViewData GetActivityRewardViewData()
		{
			List<IActivityRewardData> activityRewardDataList = this.GetActivityRewardDataList();
			ActivityRewardDataPage item = new ActivityRewardDataPage
			{
				DataList = activityRewardDataList
			};
			return new ActivityRewardViewData
			{
				DataPageList = new List<IActivityRewardDataPage>
				{
					item
				},
				Source = EActivityRewardSource.DarkCoastDelivery
			};
		}

		// Token: 0x06036D26 RID: 224550 RVA: 0x00CFC068 File Offset: 0x00CFA268
		private List<IActivityRewardData> GetActivityRewardDataList()
		{
			List<IActivityRewardData> list = new List<IActivityRewardData>();
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("DarkShoreRewardGet", null);
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew("DarkShoreRewardNotAchieved", null);
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				DarkCoastDeliveryLevelData darkCoastDeliveryLevelData = this.LevelDataList[i];
				List<TItem> rewardItems = darkCoastDeliveryLevelData.GetRewardItems();
				EActivityRewardState darkCoastDeliveryRewardState = darkCoastDeliveryLevelData.GetDarkCoastDeliveryRewardState();
				string text = (darkCoastDeliveryRewardState == EActivityRewardState.Enable) ? localTextNew : localTextNew2;
				TItem[] array = new TItem[rewardItems.Count];
				for (int j = 0; j < rewardItems.Count; j++)
				{
					array[j] = rewardItems[j];
				}
				ActivityRewardData item = new ActivityRewardData
				{
					RewardList = array,
					NameText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("DarkCoastDelivery_Reward", null) ?? "", new string[]
					{
						darkCoastDeliveryLevelData.Id.ToString()
					}),
					RewardState = darkCoastDeliveryRewardState,
					RewardButtonRedDot = new bool?(darkCoastDeliveryRewardState == EActivityRewardState.Enable),
					RewardButtonText = (text ?? ""),
					ClickFunction = delegate
					{
						MingSuController.SendMingSuHandRewardRequest(this.DragonPoolId);
					}
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06036D27 RID: 224551 RVA: 0x00CFC1A4 File Offset: 0x00CFA3A4
		public bool GetRewardRedDotState()
		{
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				if (this.LevelDataList[i].GetDarkCoastDeliveryRewardState() == EActivityRewardState.Enable)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0401CF01 RID: 118529
		private readonly List<DarkCoastDeliveryLevelData> LevelDataList = new List<DarkCoastDeliveryLevelData>();
	}
}
