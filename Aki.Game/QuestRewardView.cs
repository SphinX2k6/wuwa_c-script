using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001267 RID: 4711
public class QuestRewardView : UiViewBase
{
	// Token: 0x0600BA6F RID: 47727 RVA: 0x003706D5 File Offset: 0x0036E8D5
	[NullableContext(1)]
	public QuestRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BA70 RID: 47728 RVA: 0x003706E0 File Offset: 0x0036E8E0
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

	// Token: 0x0600BA71 RID: 47729 RVA: 0x003707E9 File Offset: 0x0036E9E9
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<RewardItemData>>(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
		EventSystem.Instance.Add<EUiTabViewName, int?>(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.OnChangeChildView));
	}

	// Token: 0x0600BA72 RID: 47730 RVA: 0x00370820 File Offset: 0x0036EA20
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
		EventSystem.Instance.Remove(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.OnChangeChildView));
	}

	// Token: 0x0600BA73 RID: 47731 RVA: 0x00370858 File Offset: 0x0036EA58
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

	// Token: 0x0600BA74 RID: 47732 RVA: 0x003708D5 File Offset: 0x0036EAD5
	protected override void OnAfterDestroy()
	{
		this.RewardData = null;
	}

	// Token: 0x0600BA75 RID: 47733 RVA: 0x003708DE File Offset: 0x0036EADE
	protected override void OnAfterShow()
	{
		EventSystem.Instance.Emit(EEventName.OnShowRewardView);
	}

	// Token: 0x0600BA76 RID: 47734 RVA: 0x003708F0 File Offset: 0x0036EAF0
	protected override void OnBeforeDestroyImplement()
	{
		Action onCloseCallback = this.RewardData.GetRewardInfo().OnCloseCallback;
		if (onCloseCallback != null)
		{
			onCloseCallback();
		}
		ItemRewardModel.Instance.ClearCurrentRewardData();
	}

	// Token: 0x0600BA77 RID: 47735 RVA: 0x00370917 File Offset: 0x0036EB17
	private void OnChangeChildView(EUiTabViewName eUiTabViewName, int? o)
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600BA78 RID: 47736 RVA: 0x0037092F File Offset: 0x0036EB2F
	private void OnClickedMaskButton()
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600BA79 RID: 47737 RVA: 0x00370947 File Offset: 0x0036EB47
	[NullableContext(1)]
	private void OnRefreshRewardItemList(IReadOnlyList<RewardItemData> itemList)
	{
		if (this.RefreshItemListVisible())
		{
			this.RefreshItemList();
		}
	}

	// Token: 0x0600BA7A RID: 47738 RVA: 0x00370958 File Offset: 0x0036EB58
	private bool RefreshTitleVisible()
	{
		bool flag = !string.IsNullOrEmpty(this.RewardData.GetRewardInfo().Title);
		base.GetItem(2).SetUIActive(flag);
		return flag;
	}

	// Token: 0x0600BA7B RID: 47739 RVA: 0x0037098C File Offset: 0x0036EB8C
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

	// Token: 0x0600BA7C RID: 47740 RVA: 0x003709CC File Offset: 0x0036EBCC
	private bool RefreshContinueTextVisible()
	{
		bool flag = !string.IsNullOrEmpty(this.RewardData.GetRewardInfo().ContinueText);
		base.GetText(4).SetUIActive(flag);
		return flag;
	}

	// Token: 0x0600BA7D RID: 47741 RVA: 0x00370A00 File Offset: 0x0036EC00
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

	// Token: 0x0600BA7E RID: 47742 RVA: 0x00370A40 File Offset: 0x0036EC40
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

	// Token: 0x0600BA7F RID: 47743 RVA: 0x00370A96 File Offset: 0x0036EC96
	private void RefreshItemList()
	{
		this.RewardItemList.Refresh(this.RewardData.GetItemList());
	}

	// Token: 0x04006B75 RID: 27509
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RewardData<ICommonRewardInfo> RewardData;

	// Token: 0x04006B76 RID: 27510
	[Nullable(2)]
	private QuestRewardItemList RewardItemList;

	// Token: 0x0200750C RID: 29964
	private static class EChildType
	{
		// Token: 0x040260D0 RID: 155856
		public const int MaskButton = 0;

		// Token: 0x040260D1 RID: 155857
		public const int TitleText = 1;

		// Token: 0x040260D2 RID: 155858
		public const int TitlePanelItem = 2;

		// Token: 0x040260D3 RID: 155859
		public const int RewardItemListItem = 3;

		// Token: 0x040260D4 RID: 155860
		public const int ContinueText = 4;
	}
}
