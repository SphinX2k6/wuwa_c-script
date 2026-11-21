using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013B8 RID: 5048
public class HonamiWeaponRewardView : UiViewBase
{
	// Token: 0x0600C819 RID: 51225 RVA: 0x003B93C0 File Offset: 0x003B75C0
	[NullableContext(1)]
	public HonamiWeaponRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C81A RID: 51226 RVA: 0x003B93CC File Offset: 0x003B75CC
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

	// Token: 0x0600C81B RID: 51227 RVA: 0x003B94D8 File Offset: 0x003B76D8
	protected override void OnStart()
	{
		RewardData<ICommonRewardInfo> rewardData = (RewardData<ICommonRewardInfo>)this.OpenParam;
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

	// Token: 0x0600C81C RID: 51228 RVA: 0x003B9555 File Offset: 0x003B7755
	protected override void OnAfterDestroy()
	{
		this.RewardData = null;
	}

	// Token: 0x0600C81D RID: 51229 RVA: 0x003B955E File Offset: 0x003B775E
	protected override void OnBeforeDestroyImplement()
	{
		Action onCloseCallback = this.RewardData.GetRewardInfo().OnCloseCallback;
		if (onCloseCallback != null)
		{
			onCloseCallback();
		}
		ItemRewardModel.Instance.ClearCurrentRewardData();
	}

	// Token: 0x0600C81E RID: 51230 RVA: 0x003B9585 File Offset: 0x003B7785
	private void OnClickedMaskButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C81F RID: 51231 RVA: 0x003B9590 File Offset: 0x003B7790
	private bool RefreshTitleVisible()
	{
		bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().Title);
		base.GetItem(2).SetUIActive(flag);
		return flag;
	}

	// Token: 0x0600C820 RID: 51232 RVA: 0x003B95C4 File Offset: 0x003B77C4
	private void RefreshTitle()
	{
		string title = this.RewardData.GetRewardInfo().Title;
		if (StringUtils.IsEmpty(title))
		{
			return;
		}
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, title, Array.Empty<object>());
	}

	// Token: 0x0600C821 RID: 51233 RVA: 0x003B9604 File Offset: 0x003B7804
	private bool RefreshContinueTextVisible()
	{
		bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().ContinueText);
		base.GetText(4).SetUIActive(flag);
		return flag;
	}

	// Token: 0x0600C822 RID: 51234 RVA: 0x003B9638 File Offset: 0x003B7838
	private void RefreshContinueText()
	{
		string continueText = this.RewardData.GetRewardInfo().ContinueText;
		if (StringUtils.IsEmpty(continueText))
		{
			return;
		}
		UUIText text = base.GetText(4);
		LguiUtil.Instance.SetLocalTextNew(text, continueText, Array.Empty<object>());
	}

	// Token: 0x0600C823 RID: 51235 RVA: 0x003B9678 File Offset: 0x003B7878
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

	// Token: 0x0600C824 RID: 51236 RVA: 0x003B96D0 File Offset: 0x003B78D0
	private void RefreshItemList()
	{
		List<RewardItemData> itemList = this.RewardData.GetItemList();
		this.RewardItemList.Refresh(itemList);
	}

	// Token: 0x040071D6 RID: 29142
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RewardData<ICommonRewardInfo> RewardData;

	// Token: 0x040071D7 RID: 29143
	[Nullable(2)]
	private QuestRewardItemList RewardItemList;

	// Token: 0x02007678 RID: 30328
	private enum EChildType
	{
		// Token: 0x04026765 RID: 157541
		MaskButton,
		// Token: 0x04026766 RID: 157542
		TitleText,
		// Token: 0x04026767 RID: 157543
		TitlePanelItem,
		// Token: 0x04026768 RID: 157544
		RewardItemListItem,
		// Token: 0x04026769 RID: 157545
		ContinueText
	}
}
