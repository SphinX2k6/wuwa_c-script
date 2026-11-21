using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020043AD RID: 17325
	[NullableContext(1)]
	[Nullable(0)]
	public class DarkCoastDeliveryData : MingSuInstance
	{
		// Token: 0x0602BC63 RID: 179299 RVA: 0x00C4AEA8 File Offset: 0x00C490A8
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

		// Token: 0x0602BC64 RID: 179300 RVA: 0x00C4AF60 File Offset: 0x00C49160
		public override void SetDragonPoolLevel(int level)
		{
			base.SetDragonPoolLevel(level);
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				this.LevelDataList[i].SetIsUnLockState(level);
			}
		}

		// Token: 0x0602BC65 RID: 179301 RVA: 0x00C4AF9C File Offset: 0x00C4919C
		public override void SetLevelGainList(int levelGain)
		{
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				DarkCoastDeliveryLevelData darkCoastDeliveryLevelData = this.LevelDataList[i];
				darkCoastDeliveryLevelData.SetReceiveRewardState(levelGain >= darkCoastDeliveryLevelData.Id);
			}
		}

		// Token: 0x0602BC66 RID: 179302 RVA: 0x00C4AFE0 File Offset: 0x00C491E0
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

		// Token: 0x0602BC67 RID: 179303 RVA: 0x00C4B034 File Offset: 0x00C49234
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

		// Token: 0x0602BC68 RID: 179304 RVA: 0x00C4B070 File Offset: 0x00C49270
		public List<DarkCoastDeliveryLevelData> GetLevelDataList()
		{
			return this.LevelDataList;
		}

		// Token: 0x0602BC69 RID: 179305 RVA: 0x00C4B078 File Offset: 0x00C49278
		public string GetCurLevelTexturePath()
		{
			return this.GetLevelTexturePath(base.GetDragonPoolLevel());
		}

		// Token: 0x0602BC6A RID: 179306 RVA: 0x00C4B088 File Offset: 0x00C49288
		public string GetLevelTexturePath(int level)
		{
			DarkCoastDeliveryLevelData levelData = this.GetLevelData(level);
			if (levelData != null)
			{
				return levelData.Config.LevelTexture ?? "";
			}
			return ConfigCommonParamById.GetStringConfig("DarkShoreDefaultLevel") ?? "";
		}

		// Token: 0x0602BC6B RID: 179307 RVA: 0x00C4B0CC File Offset: 0x00C492CC
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

		// Token: 0x0602BC6C RID: 179308 RVA: 0x00C4B110 File Offset: 0x00C49310
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

		// Token: 0x0602BC6D RID: 179309 RVA: 0x00C4B24C File Offset: 0x00C4944C
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

		// Token: 0x04017999 RID: 96665
		private readonly List<DarkCoastDeliveryLevelData> LevelDataList = new List<DarkCoastDeliveryLevelData>();
	}
}
