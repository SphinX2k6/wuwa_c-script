using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.RoleDevelop;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02004EC6 RID: 20166
	[NullableContext(2)]
	[Nullable(0)]
	public class PeriodicityChallengeTitleItem : UiPanelBase
	{
		// Token: 0x06032B4E RID: 207694 RVA: 0x00E3C094 File Offset: 0x00E3A294
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032B4F RID: 207695 RVA: 0x00E3C208 File Offset: 0x00E3A408
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<NewSoundDetectRewardItem, INewSoundDetectRewardItemData>(base.GetScrollViewWithScrollbar(6), new Func<NewSoundDetectRewardItem>(this.OnRewardLayoutUpdater), null, false, null);
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				this.RoleBadge = new RoleDevelopItemRoleBadge();
				this.RoleBadge.CreateByActor(item.GetOwner(), null);
			}
		}

		// Token: 0x06032B50 RID: 207696 RVA: 0x00E3C25F File Offset: 0x00E3A45F
		[NullableContext(1)]
		public void RefreshItem(SoundAreaDetectionRecord data)
		{
			this.Data = data;
			this.Type = (EPeriodicityChallengeType)this.Data.PeriodicityChallengeType;
			this.RefreshTitleItem();
			this.RefreshTimeItem();
			this.RefreshReward();
			this.RefreshRoleBadge();
		}

		// Token: 0x06032B51 RID: 207697 RVA: 0x00E3C294 File Offset: 0x00E3A494
		private void RefreshRoleBadge()
		{
			if (this.RoleBadge == null)
			{
				return;
			}
			RoleDevelopModel instance = RoleDevelopModel.Instance;
			SoundAreaDetectionRecord data = this.Data;
			OneOf<DungeonDetection, SilentAreaDetection>? oneOf = (data != null) ? data.Conf : null;
			if (instance == null || oneOf == null)
			{
				this.RoleBadge.SetUiActive(false);
				return;
			}
			int item = oneOf.Value.IsT1 ? oneOf.Value.AsT1.Id : oneOf.Value.AsT2.Id;
			bool flag = instance.DevTargetRoleId != 0 && instance.GetDevelopRoleDeficitDetectionIdSet().Contains(item);
			this.RoleBadge.SetUiActive(flag);
			if (flag)
			{
				this.RoleBadge.SetRoleHeadIconPath(instance.GetDevelopRoleIconPath());
			}
		}

		// Token: 0x06032B52 RID: 207698 RVA: 0x00E3C364 File Offset: 0x00E3A564
		private void RefreshTitleItem()
		{
			DetectionTitlePanel? detectionTitlePanelConfig = AdventureGuideConfig.Instance.GetDetectionTitlePanelConfig(this.Data.DetectionTitlePanel);
			if (detectionTitlePanelConfig == null)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			base.SetTextureByPath(detectionTitlePanelConfig.Value.BgTexture, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), detectionTitlePanelConfig.Value.TitleText, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), detectionTitlePanelConfig.Value.SubTitleText, Array.Empty<object>());
		}

		// Token: 0x06032B53 RID: 207699 RVA: 0x00E3C410 File Offset: 0x00E3A610
		private void RefreshTimeItem()
		{
			SecondaryGuideData? secondaryGuideDataConf = AdventureGuideConfig.Instance.GetSecondaryGuideDataConf(this.Data.Secondary);
			if (secondaryGuideDataConf.Value.TimeOutDay <= 0 || !this.IsTimeOutType())
			{
				base.GetItem(2).SetUIActive(false);
				return;
			}
			CommonDefine.ICountDown countDown = null;
			double num = 0.0;
			if (this.Type == EPeriodicityChallengeType.TowerVariation)
			{
				countDown = TowerModel.Instance.GetSeasonCountDownData();
				num = (double)MathUtils.Instance.LongToNumber(TowerModel.Instance.TowerEndTime.Value) - TimeUtil.Instance.GetServerTime();
			}
			if (this.Type == EPeriodicityChallengeType.ShipTowerPeriodicity)
			{
				countDown = ShipTowerModel.Instance.GetSeasonCountDownData();
				num = ShipTowerModel.Instance.GetRemainTime();
			}
			if (this.Type == EPeriodicityChallengeType.WeeklyRogue)
			{
				countDown = WeeklyRogueModel.Instance.ActivityDataNew.GetCycleCountDownData();
				num = (double)WeeklyRogueModel.Instance.ActivityDataNew.EndShowTime - TimeUtil.Instance.GetServerTime();
			}
			if (AdventureGuideModel.Instance.IsWheelTowerType(this.Type))
			{
				countDown = WheelTowerModel.Instance.ActivityData.GetCycleCountDownData();
				num = (double)WheelTowerModel.Instance.ActivityData.EndShowTime - TimeUtil.Instance.GetServerTime();
			}
			if (countDown == null)
			{
				base.GetItem(2).SetUIActive(false);
				return;
			}
			bool uiactive = num <= (double)(secondaryGuideDataConf.Value.TimeOutDay * TimeUtil.Instance.OneDaySeconds);
			base.GetItem(2).SetUIActive(true);
			base.GetItem(3).SetUIActive(uiactive);
			base.GetText(4).SetText(countDown.CountDownText, true);
		}

		// Token: 0x06032B54 RID: 207700 RVA: 0x00E3C59C File Offset: 0x00E3A79C
		private void RefreshReward()
		{
			List<INewSoundDetectRewardItemData> list = new List<INewSoundDetectRewardItemData>();
			Dictionary<int, int> showReward = AdventureGuideConfig.Instance.GetShowReward(this.Data.ShowRewardMap, null);
			if (showReward == null || this.IsRewardMapEqual(this.LastRefreshReward, showReward))
			{
				return;
			}
			this.LastRefreshReward = showReward;
			foreach (int num in showReward.Keys)
			{
				TItem itemData = new TItem(new InventoryDefine.GetItemData(num, 0), showReward[num]);
				NewSoundDetectRewardItemData item = new NewSoundDetectRewardItemData
				{
					ItemData = itemData,
					HaveFinish = false
				};
				list.Add(item);
			}
			this.RewardScroll.RefreshByData(list, delegate
			{
				GenericScrollViewNew<NewSoundDetectRewardItem, INewSoundDetectRewardItemData> rewardScroll = this.RewardScroll;
				TWeakObjectPtr<UUIItem>? tweakObjectPtr;
				if (((rewardScroll != null) ? ((rewardScroll.ContentItem != null) ? tweakObjectPtr.GetValueOrDefault().Get() : null) : null) != null)
				{
					GenericScrollViewNew<NewSoundDetectRewardItem, INewSoundDetectRewardItemData> rewardScroll2 = this.RewardScroll;
					if (rewardScroll2 == null)
					{
						return;
					}
					rewardScroll2.ScrollToLeft(0);
				}
			}, false);
		}

		// Token: 0x06032B55 RID: 207701 RVA: 0x00E3C678 File Offset: 0x00E3A878
		private bool IsRewardMapEqual(Dictionary<int, int> map1, Dictionary<int, int> map2)
		{
			if (map1 == null || map2 == null)
			{
				return map1 == map2;
			}
			if (map1.Count != map2.Count)
			{
				return false;
			}
			foreach (KeyValuePair<int, int> keyValuePair in map1)
			{
				if (!map2.ContainsKey(keyValuePair.Key) || map2[keyValuePair.Key] != keyValuePair.Value)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06032B56 RID: 207702 RVA: 0x00E3C708 File Offset: 0x00E3A908
		[NullableContext(1)]
		private NewSoundDetectRewardItem OnRewardLayoutUpdater()
		{
			return new NewSoundDetectRewardItem();
		}

		// Token: 0x06032B57 RID: 207703 RVA: 0x00E3C70F File Offset: 0x00E3A90F
		private bool IsTimeOutType()
		{
			return this.Type == EPeriodicityChallengeType.TowerVariation || this.Type == EPeriodicityChallengeType.ShipTowerPeriodicity || this.Type == EPeriodicityChallengeType.WeeklyRogue || this.Type == EPeriodicityChallengeType.WheelTowerNormal || this.Type == EPeriodicityChallengeType.WheelTowerEndless;
		}

		// Token: 0x0401AEBF RID: 110271
		private SoundAreaDetectionRecord Data;

		// Token: 0x0401AEC0 RID: 110272
		private EPeriodicityChallengeType Type;

		// Token: 0x0401AEC1 RID: 110273
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<NewSoundDetectRewardItem, INewSoundDetectRewardItemData> RewardScroll;

		// Token: 0x0401AEC2 RID: 110274
		private RoleDevelopItemRoleBadge RoleBadge;

		// Token: 0x0401AEC3 RID: 110275
		private Dictionary<int, int> LastRefreshReward;
	}
}
