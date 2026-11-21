using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A29 RID: 23081
	public class SolarSchoolLimitTimeRewardBottomItem : UiPanelBase
	{
		// Token: 0x06038D79 RID: 232825 RVA: 0x00FE9AC0 File Offset: 0x00FE7CC0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D7A RID: 232826 RVA: 0x00FE9BEF File Offset: 0x00FE7DEF
		private void GetBtnClick()
		{
			SolarSchoolController.Instance.GetRewardTaskProgressReward(this.ActivityData.Id);
		}

		// Token: 0x06038D7B RID: 232827 RVA: 0x00FE9C08 File Offset: 0x00FE7E08
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolLimitTimeRewardBottomItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolLimitTimeRewardBottomItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D7C RID: 232828 RVA: 0x00FE9C4B File Offset: 0x00FE7E4B
		protected override void OnStart()
		{
			this.RefreshView();
		}

		// Token: 0x06038D7D RID: 232829 RVA: 0x00FE9C54 File Offset: 0x00FE7E54
		public void RefreshView()
		{
			SolarSchoolActivity? config = ConfigSolarSchoolActivityById.GetConfig(this.ActivityData.Id, true);
			if (config == null)
			{
				return;
			}
			int limitAccDropId = config.Value.LimitAccDropId;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(limitAccDropId);
			ItemGridData data = new ItemGridData
			{
				Item = dropPackagePreviewItemList[0],
				HasClaimed = this.ActivityData.IsGetLimitTaskProgressReward
			};
			this.RewardItem.Refresh(data);
			int limitAccNeedNum = config.Value.LimitAccNeedNum;
			string name = InventoryConfig.Instance.GetItemConfigData(dropPackagePreviewItemList[0].ItemData.ItemId).Name;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SolarSchoolLimitedTimeRewardCounting", new <>z__ReadOnlySingleElementList<object>(limitAccNeedNum));
			int taskFinishNum = this.ActivityData.GetTaskFinishNum(SolarSchoolTaskType.SolarSchoolLimited);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "SolarSchoolRewardCounting", new <>z__ReadOnlyArray<object>(new object[]
			{
				taskFinishNum,
				limitAccNeedNum
			}));
			bool isGetLimitTaskProgressReward = this.ActivityData.IsGetLimitTaskProgressReward;
			bool flag = taskFinishNum >= limitAccNeedNum;
			bool flag2 = flag && !isGetLimitTaskProgressReward;
			base.GetItem(5).SetUIActive(!flag);
			SolarSchoolBtnItem getButtonItem = this.GetButtonItem;
			if (getButtonItem != null)
			{
				getButtonItem.SetUiActive(flag2);
			}
			SolarSchoolBtnItem getButtonItem2 = this.GetButtonItem;
			if (getButtonItem2 != null)
			{
				getButtonItem2.SetRedDotVisible(flag2);
			}
			base.GetItem(7).SetUIActive(isGetLimitTaskProgressReward);
			base.GetSlider(3).SetValue((float)taskFinishNum / (float)limitAccNeedNum, true);
		}

		// Token: 0x0401DEA1 RID: 122529
		[Nullable(2)]
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DEA2 RID: 122530
		[Nullable(1)]
		private ActivitySmallItemGrid RewardItem;

		// Token: 0x0401DEA3 RID: 122531
		[Nullable(2)]
		private SolarSchoolBtnItem GetButtonItem;

		// Token: 0x0200B5F8 RID: 46584
		private class EComponents
		{
			// Token: 0x04038451 RID: 230481
			public const int RewardItem = 0;

			// Token: 0x04038452 RID: 230482
			public const int NameText = 1;

			// Token: 0x04038453 RID: 230483
			public const int SubText = 2;

			// Token: 0x04038454 RID: 230484
			public const int SliderItem = 3;

			// Token: 0x04038455 RID: 230485
			public const int NumText = 4;

			// Token: 0x04038456 RID: 230486
			public const int DoingItem = 5;

			// Token: 0x04038457 RID: 230487
			public const int GetBtn = 6;

			// Token: 0x04038458 RID: 230488
			public const int FinishMaskItem = 7;
		}
	}
}
