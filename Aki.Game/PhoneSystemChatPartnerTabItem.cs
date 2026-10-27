using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002543 RID: 9539
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneSystemChatPartnerTabItem : GridProxyAbstract<ChatPartnerTabItemData>
{
	// Token: 0x170018D3 RID: 6355
	// (get) Token: 0x06013336 RID: 78646 RVA: 0x004C5A01 File Offset: 0x004C3C01
	// (set) Token: 0x06013337 RID: 78647 RVA: 0x004C5A09 File Offset: 0x004C3C09
	public Action OnSetSelectCallBack { get; set; }

	// Token: 0x06013338 RID: 78648 RVA: 0x004C5A14 File Offset: 0x004C3C14
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06013339 RID: 78649 RVA: 0x004C5A70 File Offset: 0x004C3C70
	protected override UniTask OnBeforeStartAsync()
	{
		PhoneSystemChatPartnerTabItem.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhoneSystemChatPartnerTabItem.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601333A RID: 78650 RVA: 0x004C5AB3 File Offset: 0x004C3CB3
	protected override void OnBeforeShow()
	{
		this.CollapseChatTabItem();
	}

	// Token: 0x0601333B RID: 78651 RVA: 0x004C5ABB File Offset: 0x004C3CBB
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
	}

	// Token: 0x0601333C RID: 78652 RVA: 0x004C5AD8 File Offset: 0x004C3CD8
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.TogChatPartner.GetTogglePartner().SetToggleState(state2, false, false, false);
		this.TogChatPartner.SetSelected(state);
	}

	// Token: 0x0601333D RID: 78653 RVA: 0x004C5B0E File Offset: 0x004C3D0E
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
		this.ExpandChatTabItem();
		Action onSetSelectCallBack = this.OnSetSelectCallBack;
		if (onSetSelectCallBack == null)
		{
			return;
		}
		onSetSelectCallBack();
	}

	// Token: 0x0601333E RID: 78654 RVA: 0x004C5B2D File Offset: 0x004C3D2D
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
		this.CollapseChatTabItem();
	}

	// Token: 0x0601333F RID: 78655 RVA: 0x004C5B3C File Offset: 0x004C3D3C
	public void DeselectAllChatTabItem()
	{
		this.TogChatItemList.DeselectCurrentGridProxy();
	}

	// Token: 0x06013340 RID: 78656 RVA: 0x004C5B49 File Offset: 0x004C3D49
	[NullableContext(1)]
	public void SetRefreshMainPanelFunc(Action<int, TogChatTalkItem> func)
	{
		this.RefreshMainPanelFunc = func;
	}

	// Token: 0x06013341 RID: 78657 RVA: 0x004C5B52 File Offset: 0x004C3D52
	[NullableContext(1)]
	private void OnChatTogClickCallBack(int index, int shortMsgId, TogChatTalkItem togChatItem)
	{
		if (this.RefreshMainPanelFunc != null)
		{
			this.RefreshMainPanelFunc(shortMsgId, togChatItem);
		}
	}

	// Token: 0x06013342 RID: 78658 RVA: 0x004C5B69 File Offset: 0x004C3D69
	private bool CanToggleChange(int index)
	{
		return this.TogChatItemList.GetSelectedGridIndex() != index;
	}

	// Token: 0x06013343 RID: 78659 RVA: 0x004C5B7C File Offset: 0x004C3D7C
	[NullableContext(1)]
	private TogChatTalkItem CreateChatTalkItem()
	{
		TogChatTalkItem togChatTalkItem = new TogChatTalkItem();
		togChatTalkItem.SetOnTogClickCallBack(new Action<int, int, TogChatTalkItem>(this.OnChatTogClickCallBack));
		togChatTalkItem.SetCanExecuteChange(new Func<int, bool>(this.CanToggleChange));
		return togChatTalkItem;
	}

	// Token: 0x06013344 RID: 78660 RVA: 0x004C5BA8 File Offset: 0x004C3DA8
	[NullableContext(1)]
	public override UniTask RefreshAsync(ChatPartnerTabItemData data, bool isSelected, int gridIndex)
	{
		PhoneSystemChatPartnerTabItem.<RefreshAsync>d__26 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.isSelected = isSelected;
		<RefreshAsync>d__.gridIndex = gridIndex;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<PhoneSystemChatPartnerTabItem.<RefreshAsync>d__26>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013345 RID: 78661 RVA: 0x004C5C04 File Offset: 0x004C3E04
	public UniTask EnsureChildBuiltAsync()
	{
		PhoneSystemChatPartnerTabItem.<EnsureChildBuiltAsync>d__27 <EnsureChildBuiltAsync>d__;
		<EnsureChildBuiltAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnsureChildBuiltAsync>d__.<>4__this = this;
		<EnsureChildBuiltAsync>d__.<>1__state = -1;
		<EnsureChildBuiltAsync>d__.<>t__builder.Start<PhoneSystemChatPartnerTabItem.<EnsureChildBuiltAsync>d__27>(ref <EnsureChildBuiltAsync>d__);
		return <EnsureChildBuiltAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013346 RID: 78662 RVA: 0x004C5C47 File Offset: 0x004C3E47
	[NullableContext(1)]
	public void SetClickCallBack(Action<int> func)
	{
		this.OnClickCallBack = func;
	}

	// Token: 0x06013347 RID: 78663 RVA: 0x004C5C50 File Offset: 0x004C3E50
	public void OnClickThisItem()
	{
		if (this.OnClickCallBack != null)
		{
			this.OnClickCallBack(base.GridIndex);
		}
	}

	// Token: 0x06013348 RID: 78664 RVA: 0x004C5C6B File Offset: 0x004C3E6B
	public void ExpandChatTabItem()
	{
		this.IsExecute = true;
		this.ExpandChatTabItemAsync().Forget();
	}

	// Token: 0x06013349 RID: 78665 RVA: 0x004C5C80 File Offset: 0x004C3E80
	private UniTask ExpandChatTabItemAsync()
	{
		PhoneSystemChatPartnerTabItem.<ExpandChatTabItemAsync>d__31 <ExpandChatTabItemAsync>d__;
		<ExpandChatTabItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExpandChatTabItemAsync>d__.<>4__this = this;
		<ExpandChatTabItemAsync>d__.<>1__state = -1;
		<ExpandChatTabItemAsync>d__.<>t__builder.Start<PhoneSystemChatPartnerTabItem.<ExpandChatTabItemAsync>d__31>(ref <ExpandChatTabItemAsync>d__);
		return <ExpandChatTabItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601334A RID: 78666 RVA: 0x004C5CC3 File Offset: 0x004C3EC3
	private void CollapseChatTabItem()
	{
		if (this.IsExecute)
		{
			GenericLayout<TogChatTalkItem, ChatTalkTabItemData> togChatItemList = this.TogChatItemList;
			if (togChatItemList != null)
			{
				togChatItemList.SetActive(false);
			}
			this.IsExecute = false;
		}
	}

	// Token: 0x0601334B RID: 78667 RVA: 0x004C5CE8 File Offset: 0x004C3EE8
	public void RefreshShowChatText(int shortMsgId, EGetLastChatTextType type = EGetLastChatTextType.FromReadIndex)
	{
		GenericLayout<TogChatTalkItem, ChatTalkTabItemData> togChatItemList = this.TogChatItemList;
		TogChatTalkItem togChatTalkItem = (togChatItemList != null) ? togChatItemList.GetLayoutItemByKey(shortMsgId) : null;
		if (togChatTalkItem == null)
		{
			return;
		}
		togChatTalkItem.ShortMsgId = shortMsgId;
		togChatTalkItem.RefreshShowChatText(type);
	}

	// Token: 0x0601334C RID: 78668 RVA: 0x004C5D21 File Offset: 0x004C3F21
	[NullableContext(1)]
	public override object GetKey(ChatPartnerTabItemData data, int displayIndex)
	{
		return data.ChatPartnerId;
	}

	// Token: 0x0601334D RID: 78669 RVA: 0x004C5D30 File Offset: 0x004C3F30
	public void SetChangeAlpha(bool isEnable)
	{
		this.TogChatPartner.SetChangeAlpha(isEnable);
		foreach (TogChatTalkItem togChatTalkItem in this.TogChatItemList.GetLayoutItemList())
		{
			togChatTalkItem.SetChangeAlpha(isEnable);
		}
	}

	// Token: 0x04009108 RID: 37128
	private TogChatPartner TogChatPartner;

	// Token: 0x04009109 RID: 37129
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TogChatTalkItem, ChatTalkTabItemData> TogChatItemList;

	// Token: 0x0400910A RID: 37130
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ChatTalkTabItemData> ChatTalkTabItemDataList;

	// Token: 0x0400910B RID: 37131
	private Action<int> OnClickCallBack;

	// Token: 0x0400910C RID: 37132
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, TogChatTalkItem> RefreshMainPanelFunc;

	// Token: 0x0400910D RID: 37133
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400910F RID: 37135
	private bool IsExecute = true;

	// Token: 0x04009110 RID: 37136
	private bool IsChildBuilt;

	// Token: 0x04009111 RID: 37137
	private UniTaskCompletionSource BuildTcs;

	// Token: 0x02008AF6 RID: 35574
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402D1D8 RID: 184792
		TogChatPartner,
		// Token: 0x0402D1D9 RID: 184793
		PanelList,
		// Token: 0x0402D1DA RID: 184794
		TogChatTalk
	}
}
