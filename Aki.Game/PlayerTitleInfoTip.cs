using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E12 RID: 3602
[NullableContext(1)]
[Nullable(0)]
public class PlayerTitleInfoTip : UiViewBase
{
	// Token: 0x0600915A RID: 37210 RVA: 0x002B841F File Offset: 0x002B661F
	public PlayerTitleInfoTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600915B RID: 37211 RVA: 0x002B8434 File Offset: 0x002B6634
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600915C RID: 37212 RVA: 0x002B8540 File Offset: 0x002B6740
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateNavigationListener, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Add(EEventName.OnResetToBattleView, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Add<ChatRoom, ChatContentData>(EEventName.OnAddChatContent, new Action<ChatRoom, ChatContentData>(this.OnAddChatContent));
	}

	// Token: 0x0600915D RID: 37213 RVA: 0x002B85C0 File Offset: 0x002B67C0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateNavigationListener, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Remove(EEventName.OnResetToBattleView, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Remove(EEventName.OnAddChatContent, new Action<ChatRoom, ChatContentData>(this.OnAddChatContent));
	}

	// Token: 0x0600915E RID: 37214 RVA: 0x002B863D File Offset: 0x002B683D
	private void OnAddChatContent(ChatRoom chatRoom, ChatContentData chatContent)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.ChatView))
		{
			this.CloseTitleInfo();
		}
	}

	// Token: 0x0600915F RID: 37215 RVA: 0x002B8656 File Offset: 0x002B6856
	private void CloseTitleInfo()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009160 RID: 37216 RVA: 0x002B8660 File Offset: 0x002B6860
	protected override void OnBeforeShow()
	{
		PlayerTitleInfoTipParams playerTitleInfoTipParams = this.OpenParam as PlayerTitleInfoTipParams;
		this.ItemForLocation = playerTitleInfoTipParams.ItemForLocation;
		this.PlayerTitleInfoString = playerTitleInfoTipParams.PlayerTitleInfoString;
		USceneComponent item = base.GetItem(1);
		FHitResult fhitResult = new FHitResult();
		item.D_K2_SetWorldLocation(this.ItemForLocation.D_K2_GetComponentLocation(), false, ref fhitResult, true);
		this.UpdateText();
		UUITexture texture = base.GetTexture(4);
		if (!string.IsNullOrEmpty(playerTitleInfoTipParams.PlayerTitleInfoIcon))
		{
			texture.SetUIActive(true);
			base.SetTextureByPath(playerTitleInfoTipParams.PlayerTitleInfoIcon, texture, null, null);
			return;
		}
		texture.SetUIActive(false);
	}

	// Token: 0x06009161 RID: 37217 RVA: 0x002B86F3 File Offset: 0x002B68F3
	protected override void OnBeforeDestroy()
	{
		if (this.CloseCallback != null)
		{
			this.CloseCallback();
		}
	}

	// Token: 0x06009162 RID: 37218 RVA: 0x002B8708 File Offset: 0x002B6908
	private void OnBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009163 RID: 37219 RVA: 0x002B8711 File Offset: 0x002B6911
	public void UpdateText()
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(this.PlayerTitleInfoString, true);
	}

	// Token: 0x06009164 RID: 37220 RVA: 0x002B872B File Offset: 0x002B692B
	public void BindCloseCallback(Action closeCallback)
	{
		this.CloseCallback = closeCallback;
	}

	// Token: 0x0400561A RID: 22042
	[Nullable(2)]
	private UUIItem ItemForLocation;

	// Token: 0x0400561B RID: 22043
	private string PlayerTitleInfoString = "";

	// Token: 0x0400561C RID: 22044
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x02007041 RID: 28737
	[NullableContext(0)]
	private class EPlayerTitleInfoTipDefine
	{
		// Token: 0x040249F9 RID: 150009
		public const int ItemRoot = 0;

		// Token: 0x040249FA RID: 150010
		public const int PanelInfoTip = 1;

		// Token: 0x040249FB RID: 150011
		public const int TxtInfoTip = 2;

		// Token: 0x040249FC RID: 150012
		public const int BtnMask = 3;

		// Token: 0x040249FD RID: 150013
		public const int TextureIcon = 4;
	}
}
