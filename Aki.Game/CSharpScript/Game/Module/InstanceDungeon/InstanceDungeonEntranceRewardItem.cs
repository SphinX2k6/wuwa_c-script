using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004847 RID: 18503
	public class InstanceDungeonEntranceRewardItem : UiPanelBase
	{
		// Token: 0x0602E86B RID: 190571 RVA: 0x00CFCAE8 File Offset: 0x00CFACE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnReward));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602E86C RID: 190572 RVA: 0x00CFCC54 File Offset: 0x00CFAE54
		protected override void OnStart()
		{
			this.RewardLoopScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(0), new Func<CommonItemSmallItemGrid>(this.CreateRewardGrid), null, false, null);
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.InstanceId);
			}
		}

		// Token: 0x0602E86D RID: 190573 RVA: 0x00CFCC90 File Offset: 0x00CFAE90
		protected override void OnBeforeDestroy()
		{
			this.RewardLoopScroll = null;
		}

		// Token: 0x0602E86E RID: 190574 RVA: 0x00CFCC9C File Offset: 0x00CFAE9C
		public void RefreshItem(int instanceId)
		{
			if (base.InAsyncLoading())
			{
				this.ItemDataHandle = new IInstanceDungeonEntranceRewardItem
				{
					InstanceId = instanceId
				};
				return;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			ValueTuple<List<TItem>, bool> instanceDungeonReward = InstanceDungeonEntranceModel.Instance.GetInstanceDungeonReward(instanceId);
			ExchangeReward? exchangeReward;
			Dictionary<int, int> dictionary = (ExchangeRewardConfig.Instance.GetExchangeRewardConfig((config != null) ? new int?(config.GetValueOrDefault().RewardId) : null) != null) ? exchangeReward.GetValueOrDefault().RewardId() : null;
			this.SetRewardBtnActive(((dictionary != null) ? dictionary.Count : 0) > 1);
			ExchangeRewardModel instance = ExchangeRewardModel.Instance;
			bool? flag = (instance != null) ? new bool?(instance.IsFinishInstance(instanceId)) : null;
			int num;
			if (!flag.GetValueOrDefault())
			{
				List<TItem> exchangeRewardPreviewRewardList = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList((config != null) ? config.GetValueOrDefault().FirstRewardId : 0, null);
				num = ((exchangeRewardPreviewRewardList != null) ? exchangeRewardPreviewRewardList.Count : 0);
			}
			else
			{
				num = 0;
			}
			int firstRewardLength = num;
			List<TItem> exchangeRewardPreviewRewardList2 = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList((config != null) ? config.GetValueOrDefault().ExchangeRewardId : 0, null);
			int exchangeRewardLength = (exchangeRewardPreviewRewardList2 != null) ? exchangeRewardPreviewRewardList2.Count : 0;
			this.SetFirstRewardLength(firstRewardLength);
			this.SetExchangeRewardLength(exchangeRewardLength);
			int? instanceFirstRewardId = InstanceDungeonConfig.Instance.GetInstanceFirstRewardId(instanceId);
			bool value;
			if (!flag.GetValueOrDefault())
			{
				int? num2 = instanceFirstRewardId;
				int num3 = 0;
				value = !(num2.GetValueOrDefault() == num3 & num2 != null);
			}
			else
			{
				value = false;
			}
			this.RefreshRewardText(new bool?(value));
			this.RefreshReward(instanceDungeonReward.Item1, instanceDungeonReward.Item2 || ExchangeRewardModel.Instance.IsFinishInstanceCompatible(instanceId));
			this.SetDoubleReward(instanceId);
		}

		// Token: 0x0602E86F RID: 190575 RVA: 0x00CFCE67 File Offset: 0x00CFB067
		[NullableContext(1)]
		public void RefreshReward(List<TItem> dataList, bool isFinishInstance)
		{
			this.CanExchangeReward = !isFinishInstance;
			this.RewardLoopScroll.RefreshByData(dataList, delegate
			{
				GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardLoopScroll = this.RewardLoopScroll;
				List<CommonItemSmallItemGrid> list = (rewardLoopScroll != null) ? rewardLoopScroll.GetScrollItemList() : null;
				int num = (list != null) ? list.Count : 0;
				for (int i = 0; i < num; i++)
				{
					CommonItemSmallItemGrid commonItemSmallItemGrid = list[i];
					commonItemSmallItemGrid.SetReceivedVisible(!this.CanExchangeReward);
					commonItemSmallItemGrid.SetFirstRewardVisible(i < this.FirstRewardLength);
					commonItemSmallItemGrid.SetExchangeRewardVisible(i >= this.FirstRewardLength && i < this.FirstRewardLength + this.ExchangeRewardLength);
				}
			}, false);
		}

		// Token: 0x0602E870 RID: 190576 RVA: 0x00CFCE8C File Offset: 0x00CFB08C
		public void RefreshRewardText(bool? isFirstGet)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Text_RewardPreview_Text", Array.Empty<object>());
		}

		// Token: 0x0602E871 RID: 190577 RVA: 0x00CFCEA9 File Offset: 0x00CFB0A9
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateRewardGrid()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0602E872 RID: 190578 RVA: 0x00CFCEB0 File Offset: 0x00CFB0B0
		private void OnClickBtnReward()
		{
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonReward, null, null);
		}

		// Token: 0x0602E873 RID: 190579 RVA: 0x00CFCEC3 File Offset: 0x00CFB0C3
		public void SetRewardBtnActive(bool isActive)
		{
			(base.GetButton(1).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(isActive);
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isActive);
		}

		// Token: 0x0602E874 RID: 190580 RVA: 0x00CFCEF4 File Offset: 0x00CFB0F4
		public void SetDoubleReward(int instanceId)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			ActivityDoubleRewardData dungeonUpActivity = ActivityDoubleRewardController.Instance.GetDungeonUpActivity(((config != null) ? config.GetValueOrDefault().GetCustomTypesArray() : null) ?? Array.Empty<int>(), true);
			bool flag = dungeonUpActivity != null && dungeonUpActivity.LeftUpCount > 0;
			ValueTuple<bool, int, int, string, string> dungeonDoubleDropTuple = ActivityRegressModel.Instance.GetDungeonDoubleDropTuple(instanceId);
			bool item = dungeonDoubleDropTuple.Item1;
			int item2 = dungeonDoubleDropTuple.Item2;
			int item3 = dungeonDoubleDropTuple.Item3;
			string item4 = dungeonDoubleDropTuple.Item4;
			string item5 = dungeonDoubleDropTuple.Item5;
			bool uiactive = item || flag;
			base.GetItem(3).SetUIActive(uiactive);
			base.GetItem(5).SetUIActive(uiactive);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Double_reward_tips_02", Array.Empty<object>());
				ValueTuple<string, int, int> numTxtAndParam = dungeonUpActivity.GetNumTxtAndParam();
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), numTxtAndParam.Item1, new <>z__ReadOnlyArray<object>(new object[]
				{
					numTxtAndParam.Item2,
					numTxtAndParam.Item3
				}));
			}
			if (item)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), item5, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), item4, new <>z__ReadOnlyArray<object>(new object[]
				{
					item2,
					item3
				}));
			}
		}

		// Token: 0x0602E875 RID: 190581 RVA: 0x00CFD054 File Offset: 0x00CFB254
		public void SetFirstRewardLength(int length)
		{
			this.FirstRewardLength = length;
		}

		// Token: 0x0602E876 RID: 190582 RVA: 0x00CFD05D File Offset: 0x00CFB25D
		public void SetExchangeRewardLength(int length)
		{
			this.ExchangeRewardLength = length;
		}

		// Token: 0x04018C4B RID: 101451
		[Nullable(2)]
		private IInstanceDungeonEntranceRewardItem ItemDataHandle;

		// Token: 0x04018C4C RID: 101452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLoopScroll;

		// Token: 0x04018C4D RID: 101453
		private bool CanExchangeReward = true;

		// Token: 0x04018C4E RID: 101454
		private int FirstRewardLength;

		// Token: 0x04018C4F RID: 101455
		private int ExchangeRewardLength;

		// Token: 0x0200A4C8 RID: 42184
		private enum EChildType
		{
			// Token: 0x040330A7 RID: 209063
			LoopScrollReward,
			// Token: 0x040330A8 RID: 209064
			BtnReward,
			// Token: 0x040330A9 RID: 209065
			RewardText,
			// Token: 0x040330AA RID: 209066
			DoubleTip,
			// Token: 0x040330AB RID: 209067
			DoubleTipTxt,
			// Token: 0x040330AC RID: 209068
			DoubleIcon,
			// Token: 0x040330AD RID: 209069
			RewardDesText,
			// Token: 0x040330AE RID: 209070
			DoubleTitleText
		}
	}
}
