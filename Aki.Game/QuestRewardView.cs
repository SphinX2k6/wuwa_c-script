using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DA5 RID: 7589
public class QuestRewardView : UiViewBase
{
	// Token: 0x0600E651 RID: 58961 RVA: 0x00364A74 File Offset: 0x00362C74
	[NullableContext(1)]
	public QuestRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E652 RID: 58962 RVA: 0x00364A80 File Offset: 0x00362C80
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedMaskButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600E653 RID: 58963 RVA: 0x00364B89 File Offset: 0x00362D89
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<RewardItemData>>(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
		EventSystem.Instance.Add<EUiTabViewName, int?>(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.OnChangeChildView));
	}

	// Token: 0x0600E654 RID: 58964 RVA: 0x00364BC0 File Offset: 0x00362DC0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
		EventSystem.Instance.Remove(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.OnChangeChildView));
	}

	// Token: 0x0600E655 RID: 58965 RVA: 0x00364BF8 File Offset: 0x00362DF8
	protected override void OnStart()
	{
		RewardData<ICommonRewardInfo> rewardData = this.OpenParam as RewardData<ICommonRewardInfo>;
		if (rewardData == null)
		{
			return;
		}
		this.RewardData = rewardData;
		this.RewardItemList = new QuestRewardItemList(base.GetItem(3).GetOwner());
		if (this.RefreshTitleVisible())
		{
			this.RefreshTitle();
		}
		if (this.RefreshContinueTextVisible())
		{
			this.RefreshContinueText();
		}
		if (this.RefreshItemListVisible())
		{
			this.RefreshItemList();
		}
		string audioId = rewardData.GetRewardInfo().AudioId;
		ItemRewardController.Instance.PlayAudio(audioId, null);
	}

	// Token: 0x0600E656 RID: 58966 RVA: 0x00364C75 File Offset: 0x00362E75
	protected override void OnAfterDestroy()
	{
		this.RewardData = null;
	}

	// Token: 0x0600E657 RID: 58967 RVA: 0x00364C7E File Offset: 0x00362E7E
	protected override void OnAfterShow()
	{
		EventSystem.Instance.Emit(EEventName.OnShowRewardView);
	}

	// Token: 0x0600E658 RID: 58968 RVA: 0x00364C90 File Offset: 0x00362E90
	protected override void OnBeforeDestroyImplement()
	{
		Action onCloseCallback = this.RewardData.GetRewardInfo().OnCloseCallback;
		if (onCloseCallback != null)
		{
			onCloseCallback();
		}
		ItemRewardModel.Instance.ClearCurrentRewardData();
	}

	// Token: 0x0600E659 RID: 58969 RVA: 0x00364CB7 File Offset: 0x00362EB7
	private void OnChangeChildView(EUiTabViewName eUiTabViewName, int? o)
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600E65A RID: 58970 RVA: 0x00364CCF File Offset: 0x00362ECF
	private void OnClickedMaskButton()
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600E65B RID: 58971 RVA: 0x00364CE7 File Offset: 0x00362EE7
	[NullableContext(1)]
	private void OnRefreshRewardItemList(IReadOnlyList<RewardItemData> itemList)
	{
		if (this.RefreshItemListVisible())
		{
			this.RefreshItemList();
		}
	}

	// Token: 0x0600E65C RID: 58972 RVA: 0x00364CF8 File Offset: 0x00362EF8
	private bool RefreshTitleVisible()
	{
		bool flag = !string.IsNullOrEmpty(this.RewardData.GetRewardInfo().Title);
		base.GetItem(2).SetUIActive(flag);
		return flag;
	}

	// Token: 0x0600E65D RID: 58973 RVA: 0x00364D2C File Offset: 0x00362F2C
	private void RefreshTitle()
	{
		string title = this.RewardData.GetRewardInfo().Title;
		if (string.IsNullOrEmpty(title))
		{
			return;
		}
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, title, Array.Empty<object>());
	}

	// Token: 0x0600E65E RID: 58974 RVA: 0x00364D6C File Offset: 0x00362F6C
	private bool RefreshContinueTextVisible()
	{
		bool flag = !string.IsNullOrEmpty(this.RewardData.GetRewardInfo().ContinueText);
		base.GetText(4).SetUIActive(flag);
		return flag;
	}

	// Token: 0x0600E65F RID: 58975 RVA: 0x00364DA0 File Offset: 0x00362FA0
	private void RefreshContinueText()
	{
		string continueText = this.RewardData.GetRewardInfo().ContinueText;
		if (string.IsNullOrEmpty(continueText))
		{
			return;
		}
		UUIText text = base.GetText(4);
		LguiUtil.Instance.SetLocalTextNew(text, continueText, Array.Empty<object>());
	}

	// Token: 0x0600E660 RID: 58976 RVA: 0x00364DE0 File Offset: 0x00362FE0
	private bool RefreshItemListVisible()
	{
		bool isItemVisible = this.RewardData.GetRewardInfo().IsItemVisible;
		List<RewardItemData> itemList = this.RewardData.GetItemList();
		bool flag = isItemVisible && itemList != null && itemList.Count > 0;
		if (this.RewardItemList.GetActive() != flag)
		{
			this.RewardItemList.SetActive(flag);
		}
		return flag;
	}

	// Token: 0x0600E661 RID: 58977 RVA: 0x00364E36 File Offset: 0x00363036
	private void RefreshItemList()
	{
		this.RewardItemList.Refresh(this.RewardData.GetItemList());
	}

	// Token: 0x04006A94 RID: 27284
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RewardData<ICommonRewardInfo> RewardData;

	// Token: 0x04006A95 RID: 27285
	[Nullable(2)]
	private QuestRewardItemList RewardItemList;

	// Token: 0x02008384 RID: 33668
	private static class EChildType
	{
		// Token: 0x0402ADAA RID: 175530
		public const int MaskButton = 0;

		// Token: 0x0402ADAB RID: 175531
		public const int TitleText = 1;

		// Token: 0x0402ADAC RID: 175532
		public const int TitlePanelItem = 2;

		// Token: 0x0402ADAD RID: 175533
		public const int RewardItemListItem = 3;

		// Token: 0x0402ADAE RID: 175534
		public const int ContinueText = 4;
	}
}
