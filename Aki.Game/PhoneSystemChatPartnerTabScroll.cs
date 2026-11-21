using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A30 RID: 6704
[NullableContext(1)]
[Nullable(0)]
public class PhoneSystemChatPartnerTabScroll
{
	// Token: 0x06010839 RID: 67641 RVA: 0x004D51F2 File Offset: 0x004D33F2
	public PhoneSystemChatPartnerTabScroll(UUIMultiTemplateScrollViewComponent scrollViewComponent)
	{
		this.ScrollView = new MultiTemplateScrollView(scrollViewComponent);
	}

	// Token: 0x0601083A RID: 67642 RVA: 0x004D5232 File Offset: 0x004D3432
	public void SetOnPartnerClick(Action<int> callback)
	{
		this.OnPartnerClick = callback;
	}

	// Token: 0x0601083B RID: 67643 RVA: 0x004D523B File Offset: 0x004D343B
	public void SetOnChatItemClick(Action<int, TogChatTalkItem> callback)
	{
		this.OnChatItemClick = callback;
	}

	// Token: 0x0601083C RID: 67644 RVA: 0x004D5244 File Offset: 0x004D3444
	public void RefreshByData(List<ChatPartnerTabItemData> dataList, int scrollToPartnerId = 0)
	{
		this.PartnerDataList = dataList;
		if (this.ExpandedPartnerId != 0 && !this.ContainsPartner(this.ExpandedPartnerId))
		{
			this.ExpandedPartnerId = 0;
		}
		this.RebuildAndRefresh(scrollToPartnerId);
	}

	// Token: 0x0601083D RID: 67645 RVA: 0x004D5274 File Offset: 0x004D3474
	private bool ContainsPartner(int partnerId)
	{
		for (int i = 0; i < this.PartnerDataList.Count; i++)
		{
			if (this.PartnerDataList[i].ChatPartnerId == partnerId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601083E RID: 67646 RVA: 0x004D52B0 File Offset: 0x004D34B0
	private void RebuildAndRefresh(int scrollToPartnerId = 0)
	{
		this.DataList = new List<IMultiTemplateGridData>();
		this.PartnerIndexMap.Clear();
		this.ShortMsgIndexMap.Clear();
		for (int i = 0; i < this.PartnerDataList.Count; i++)
		{
			ChatPartnerTabItemData chatPartnerTabItemData = this.PartnerDataList[i];
			int chatPartnerId = chatPartnerTabItemData.ChatPartnerId;
			chatPartnerTabItemData.OnClickPartner = this.OnPartnerClick;
			chatPartnerTabItemData.IsExpandedProvider = new Func<int, bool>(this.IsPartnerExpanded);
			chatPartnerTabItemData.IsSelectedPartnerProvider = new Func<int, bool>(this.IsPartnerSelected);
			chatPartnerTabItemData.SelectedShortMsgIdProvider = new Func<int>(this.GetSelectedShortMsgId);
			this.PartnerIndexMap[chatPartnerId] = this.DataList.Count;
			this.DataList.Add(new ChatPartnerMultiTemplateData
			{
				Data = chatPartnerTabItemData
			});
			if (chatPartnerId == this.ExpandedPartnerId)
			{
				this.AppendMessageGrids(chatPartnerId);
			}
		}
		MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.DataList);
		int scrollToGridIndex;
		if (scrollToPartnerId != 0 && this.PartnerIndexMap.TryGetValue(scrollToPartnerId, out scrollToGridIndex))
		{
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = scrollToGridIndex;
		}
		this.ScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
	}

	// Token: 0x0601083F RID: 67647 RVA: 0x004D53C4 File Offset: 0x004D35C4
	private void AppendMessageGrids(int partnerId)
	{
		List<PhoneMsgShortMsgData> allPhoneMsgShortMsgDataByChatPartnerId = PhoneMsgModel.Instance.GetAllPhoneMsgShortMsgDataByChatPartnerId(partnerId);
		if (allPhoneMsgShortMsgDataByChatPartnerId == null)
		{
			return;
		}
		int count = allPhoneMsgShortMsgDataByChatPartnerId.Count;
		for (int i = 0; i < count; i++)
		{
			PhoneMsgShortMsgData phoneMsgShortMsgData = allPhoneMsgShortMsgDataByChatPartnerId[i];
			if (PhoneMsgModel.Instance.IsThisMessageCanShow(phoneMsgShortMsgData.ShortMsgId))
			{
				ChatTalkTabItemData chatTalkTabItemData = new ChatTalkTabItemData(phoneMsgShortMsgData);
				chatTalkTabItemData.OnClickChatItem = this.OnChatItemClick;
				chatTalkTabItemData.IsSelectedProvider = new Func<int, bool>(this.IsShortMsgSelected);
				this.ShortMsgIndexMap[phoneMsgShortMsgData.ShortMsgId] = this.DataList.Count;
				this.DataList.Add(new ChatTalkMultiTemplateData
				{
					Data = chatTalkTabItemData
				});
			}
		}
	}

	// Token: 0x06010840 RID: 67648 RVA: 0x004D546A File Offset: 0x004D366A
	private bool IsPartnerExpanded(int partnerId)
	{
		return this.ExpandedPartnerId == partnerId;
	}

	// Token: 0x06010841 RID: 67649 RVA: 0x004D5475 File Offset: 0x004D3675
	private bool IsPartnerSelected(int partnerId)
	{
		return this.SelectedPartnerId == partnerId;
	}

	// Token: 0x06010842 RID: 67650 RVA: 0x004D5480 File Offset: 0x004D3680
	private bool IsShortMsgSelected(int shortMsgId)
	{
		return this.SelectedShortMsgId == shortMsgId;
	}

	// Token: 0x06010843 RID: 67651 RVA: 0x004D548B File Offset: 0x004D368B
	private int GetSelectedShortMsgId()
	{
		return this.SelectedShortMsgId;
	}

	// Token: 0x06010844 RID: 67652 RVA: 0x004D5493 File Offset: 0x004D3693
	public int GetDataCount()
	{
		return this.DataList.Count;
	}

	// Token: 0x06010845 RID: 67653 RVA: 0x004D54A0 File Offset: 0x004D36A0
	public int GetGridIndexByPartnerId(int partnerId)
	{
		int result;
		if (!this.PartnerIndexMap.TryGetValue(partnerId, out result))
		{
			return -1;
		}
		return result;
	}

	// Token: 0x06010846 RID: 67654 RVA: 0x004D54C0 File Offset: 0x004D36C0
	public int GetGridIndexByShortMsgId(int shortMsgId)
	{
		int result;
		if (!this.ShortMsgIndexMap.TryGetValue(shortMsgId, out result))
		{
			return -1;
		}
		return result;
	}

	// Token: 0x06010847 RID: 67655 RVA: 0x004D54E0 File Offset: 0x004D36E0
	public int GetPartnerIdByComponent(UUISelectableComponent component)
	{
		if (component == null)
		{
			return 0;
		}
		int gridIndexByChildComponent = this.ScrollView.ScrollView.GetGridIndexByChildComponent(component);
		if (gridIndexByChildComponent < 0)
		{
			return 0;
		}
		foreach (KeyValuePair<int, int> keyValuePair in this.PartnerIndexMap)
		{
			if (keyValuePair.Value == gridIndexByChildComponent)
			{
				return keyValuePair.Key;
			}
		}
		return 0;
	}

	// Token: 0x06010848 RID: 67656 RVA: 0x004D5560 File Offset: 0x004D3760
	[NullableContext(2)]
	public TogChatPartner GetProxyByPartnerId(int partnerId)
	{
		int gridIndexByPartnerId = this.GetGridIndexByPartnerId(partnerId);
		if (gridIndexByPartnerId < 0)
		{
			return null;
		}
		return this.ScrollView.GetProxyByGridIndex(gridIndexByPartnerId) as TogChatPartner;
	}

	// Token: 0x06010849 RID: 67657 RVA: 0x004D558C File Offset: 0x004D378C
	[NullableContext(2)]
	public TogChatTalkItem GetChatItemProxyByShortMsgId(int shortMsgId)
	{
		int gridIndexByShortMsgId = this.GetGridIndexByShortMsgId(shortMsgId);
		if (gridIndexByShortMsgId < 0)
		{
			return null;
		}
		return this.ScrollView.GetProxyByGridIndex(gridIndexByShortMsgId) as TogChatTalkItem;
	}

	// Token: 0x0601084A RID: 67658 RVA: 0x004D55B8 File Offset: 0x004D37B8
	public void SetSelectedShortMsgId(int shortMsgId)
	{
		this.SelectedShortMsgId = shortMsgId;
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(shortMsgId);
		if (phoneMsgConfig != null)
		{
			this.SelectedPartnerId = phoneMsgConfig.Value.WhichChat;
		}
	}

	// Token: 0x0601084B RID: 67659 RVA: 0x004D55F6 File Offset: 0x004D37F6
	public void SelectPartner(int partnerId)
	{
		this.ExpandedPartnerId = partnerId;
		this.SelectedPartnerId = partnerId;
		this.RebuildAndRefresh(0);
		this.RelocateNavigationFocusToPartner(partnerId);
	}

	// Token: 0x0601084C RID: 67660 RVA: 0x004D5614 File Offset: 0x004D3814
	public void DeselectPartner()
	{
		int expandedPartnerId = this.ExpandedPartnerId;
		this.ExpandedPartnerId = 0;
		this.SelectedPartnerId = 0;
		this.RebuildAndRefresh(0);
		if (expandedPartnerId != 0)
		{
			this.RelocateNavigationFocusToPartner(expandedPartnerId);
		}
	}

	// Token: 0x0601084D RID: 67661 RVA: 0x004D5648 File Offset: 0x004D3848
	private void RelocateNavigationFocusToPartner(int partnerId)
	{
		int gridIndexByPartnerId = this.GetGridIndexByPartnerId(partnerId);
		if (gridIndexByPartnerId < 0)
		{
			return;
		}
		UUISelectableComponent navigationComponentByGridIndex = this.ScrollView.ScrollView.GetNavigationComponentByGridIndex(gridIndexByPartnerId);
		if (navigationComponentByGridIndex == null || !navigationComponentByGridIndex.IsValid())
		{
			return;
		}
		UUIItem rootComponent = navigationComponentByGridIndex.GetRootComponent();
		if (rootComponent == null || !rootComponent.IsValid())
		{
			return;
		}
		UiNavigationNewController.Instance.SetNavigationFocusForView(rootComponent, true, false, false);
	}

	// Token: 0x0601084E RID: 67662 RVA: 0x004D56A4 File Offset: 0x004D38A4
	public UniTask EnsureChildBuiltForPartnerAsync(int partnerId)
	{
		PhoneSystemChatPartnerTabScroll.<EnsureChildBuiltForPartnerAsync>d__31 <EnsureChildBuiltForPartnerAsync>d__;
		<EnsureChildBuiltForPartnerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnsureChildBuiltForPartnerAsync>d__.<>1__state = -1;
		<EnsureChildBuiltForPartnerAsync>d__.<>t__builder.Start<PhoneSystemChatPartnerTabScroll.<EnsureChildBuiltForPartnerAsync>d__31>(ref <EnsureChildBuiltForPartnerAsync>d__);
		return <EnsureChildBuiltForPartnerAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601084F RID: 67663 RVA: 0x004D56E0 File Offset: 0x004D38E0
	public void ScrollToPartner(int partnerId)
	{
		int gridIndexByPartnerId = this.GetGridIndexByPartnerId(partnerId);
		if (gridIndexByPartnerId < 0)
		{
			return;
		}
		this.ScrollView.ScrollView.ScrollToGridIndexLater(gridIndexByPartnerId, true);
	}

	// Token: 0x06010850 RID: 67664 RVA: 0x004D570C File Offset: 0x004D390C
	public void TryScrollToPartner(int partnerId)
	{
		int gridIndexByPartnerId = this.GetGridIndexByPartnerId(partnerId);
		if (gridIndexByPartnerId < 0)
		{
			return;
		}
		this.ScrollView.ScrollView.TryScrollToGridIndex(gridIndexByPartnerId, true);
	}

	// Token: 0x06010851 RID: 67665 RVA: 0x004D5738 File Offset: 0x004D3938
	public bool IsPartnerDisplaying(int partnerId)
	{
		int gridIndexByPartnerId = this.GetGridIndexByPartnerId(partnerId);
		return gridIndexByPartnerId >= 0 && this.ScrollView.IsGridDisplaying(gridIndexByPartnerId);
	}

	// Token: 0x06010852 RID: 67666 RVA: 0x004D5760 File Offset: 0x004D3960
	public void RefreshPartnerChatText(int partnerId, int shortMsgId, EGetLastChatTextType type)
	{
		TogChatTalkItem chatItemProxyByShortMsgId = this.GetChatItemProxyByShortMsgId(shortMsgId);
		if (chatItemProxyByShortMsgId == null)
		{
			return;
		}
		chatItemProxyByShortMsgId.ShortMsgId = shortMsgId;
		chatItemProxyByShortMsgId.RefreshShowChatText(type).Forget();
	}

	// Token: 0x06010853 RID: 67667 RVA: 0x004D578C File Offset: 0x004D398C
	public void SetAllDisplayingBlackMark(bool isEnable)
	{
		int startDisplayGridIndex = this.ScrollView.ScrollView.GetStartDisplayGridIndex();
		int endDisplayGridIndex = this.ScrollView.ScrollView.GetEndDisplayGridIndex();
		if (startDisplayGridIndex < 0 || endDisplayGridIndex < 0)
		{
			return;
		}
		for (int i = startDisplayGridIndex; i <= endDisplayGridIndex; i++)
		{
			if (i >= 0 && i < this.DataList.Count)
			{
				ISyncGridProxy proxyByGridIndex = this.ScrollView.GetProxyByGridIndex(i);
				TogChatPartner togChatPartner = proxyByGridIndex as TogChatPartner;
				if (togChatPartner != null)
				{
					togChatPartner.SetChangeAlpha(isEnable);
				}
				else
				{
					TogChatTalkItem togChatTalkItem = proxyByGridIndex as TogChatTalkItem;
					if (togChatTalkItem != null)
					{
						togChatTalkItem.SetChangeAlpha(isEnable);
					}
				}
			}
		}
	}

	// Token: 0x0400926A RID: 37482
	private readonly MultiTemplateScrollView ScrollView;

	// Token: 0x0400926B RID: 37483
	private List<ChatPartnerTabItemData> PartnerDataList = new List<ChatPartnerTabItemData>();

	// Token: 0x0400926C RID: 37484
	private List<IMultiTemplateGridData> DataList = new List<IMultiTemplateGridData>();

	// Token: 0x0400926D RID: 37485
	private readonly Dictionary<int, int> PartnerIndexMap = new Dictionary<int, int>();

	// Token: 0x0400926E RID: 37486
	private readonly Dictionary<int, int> ShortMsgIndexMap = new Dictionary<int, int>();

	// Token: 0x0400926F RID: 37487
	private int ExpandedPartnerId;

	// Token: 0x04009270 RID: 37488
	private int SelectedPartnerId;

	// Token: 0x04009271 RID: 37489
	private int SelectedShortMsgId;

	// Token: 0x04009272 RID: 37490
	[Nullable(2)]
	private Action<int> OnPartnerClick;

	// Token: 0x04009273 RID: 37491
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, TogChatTalkItem> OnChatItemClick;
}
