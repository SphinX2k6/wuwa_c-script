using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EF6 RID: 7926
public class HonamiWeaponRewardView : UiViewBase
{
	// Token: 0x0600F3FA RID: 62458 RVA: 0x003AD8CC File Offset: 0x003ABACC
	[NullableContext(1)]
	public HonamiWeaponRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F3FB RID: 62459 RVA: 0x003AD8D8 File Offset: 0x003ABAD8
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

	// Token: 0x0600F3FC RID: 62460 RVA: 0x003AD9E4 File Offset: 0x003ABBE4
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

	// Token: 0x0600F3FD RID: 62461 RVA: 0x003ADA61 File Offset: 0x003ABC61
	protected override void OnAfterDestroy()
	{
		this.RewardData = null;
	}

	// Token: 0x0600F3FE RID: 62462 RVA: 0x003ADA6A File Offset: 0x003ABC6A
	protected override void OnBeforeDestroyImplement()
	{
		Action onCloseCallback = this.RewardData.GetRewardInfo().OnCloseCallback;
		if (onCloseCallback != null)
		{
			onCloseCallback();
		}
		ItemRewardModel.Instance.ClearCurrentRewardData();
	}

	// Token: 0x0600F3FF RID: 62463 RVA: 0x003ADA91 File Offset: 0x003ABC91
	private void OnClickedMaskButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F400 RID: 62464 RVA: 0x003ADA9C File Offset: 0x003ABC9C
	private bool RefreshTitleVisible()
	{
		bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().Title);
		base.GetItem(2).SetUIActive(flag);
		return flag;
	}

	// Token: 0x0600F401 RID: 62465 RVA: 0x003ADAD0 File Offset: 0x003ABCD0
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

	// Token: 0x0600F402 RID: 62466 RVA: 0x003ADB10 File Offset: 0x003ABD10
	private bool RefreshContinueTextVisible()
	{
		bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().ContinueText);
		base.GetText(4).SetUIActive(flag);
		return flag;
	}

	// Token: 0x0600F403 RID: 62467 RVA: 0x003ADB44 File Offset: 0x003ABD44
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

	// Token: 0x0600F404 RID: 62468 RVA: 0x003ADB84 File Offset: 0x003ABD84
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

	// Token: 0x0600F405 RID: 62469 RVA: 0x003ADBDC File Offset: 0x003ABDDC
	private void RefreshItemList()
	{
		List<RewardItemData> itemList = this.RewardData.GetItemList();
		this.RewardItemList.Refresh(itemList);
	}

	// Token: 0x040070F5 RID: 28917
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RewardData<ICommonRewardInfo> RewardData;

	// Token: 0x040070F6 RID: 28918
	[Nullable(2)]
	private QuestRewardItemList RewardItemList;

	// Token: 0x020084F3 RID: 34035
	private enum EChildType
	{
		// Token: 0x0402B441 RID: 177217
		MaskButton,
		// Token: 0x0402B442 RID: 177218
		TitleText,
		// Token: 0x0402B443 RID: 177219
		TitlePanelItem,
		// Token: 0x0402B444 RID: 177220
		RewardItemListItem,
		// Token: 0x0402B445 RID: 177221
		ContinueText
	}
}
