using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001955 RID: 6485
[NullableContext(1)]
[Nullable(0)]
public class PlayerTitleInfoTip : UiViewBase
{
	// Token: 0x0600BD57 RID: 48471 RVA: 0x002AD5DB File Offset: 0x002AB7DB
	public PlayerTitleInfoTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BD58 RID: 48472 RVA: 0x002AD5F0 File Offset: 0x002AB7F0
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

	// Token: 0x0600BD59 RID: 48473 RVA: 0x002AD6FC File Offset: 0x002AB8FC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateNavigationListener, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Add(EEventName.OnResetToBattleView, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Add<ChatRoom, ChatContentData>(EEventName.OnAddChatContent, new Action<ChatRoom, ChatContentData>(this.OnAddChatContent));
	}

	// Token: 0x0600BD5A RID: 48474 RVA: 0x002AD77C File Offset: 0x002AB97C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateNavigationListener, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Remove(EEventName.OnResetToBattleView, new Action(this.CloseTitleInfo));
		EventSystem.Instance.Remove(EEventName.OnAddChatContent, new Action<ChatRoom, ChatContentData>(this.OnAddChatContent));
	}

	// Token: 0x0600BD5B RID: 48475 RVA: 0x002AD7F9 File Offset: 0x002AB9F9
	private void OnAddChatContent(ChatRoom chatRoom, ChatContentData chatContent)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.ChatView))
		{
			this.CloseTitleInfo();
		}
	}

	// Token: 0x0600BD5C RID: 48476 RVA: 0x002AD812 File Offset: 0x002ABA12
	private void CloseTitleInfo()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600BD5D RID: 48477 RVA: 0x002AD81C File Offset: 0x002ABA1C
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

	// Token: 0x0600BD5E RID: 48478 RVA: 0x002AD8AF File Offset: 0x002ABAAF
	protected override void OnBeforeDestroy()
	{
		if (this.CloseCallback != null)
		{
			this.CloseCallback();
		}
	}

	// Token: 0x0600BD5F RID: 48479 RVA: 0x002AD8C4 File Offset: 0x002ABAC4
	private void OnBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600BD60 RID: 48480 RVA: 0x002AD8CD File Offset: 0x002ABACD
	public void UpdateText()
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(this.PlayerTitleInfoString, true);
	}

	// Token: 0x0600BD61 RID: 48481 RVA: 0x002AD8E7 File Offset: 0x002ABAE7
	public void BindCloseCallback(Action closeCallback)
	{
		this.CloseCallback = closeCallback;
	}

	// Token: 0x0400556D RID: 21869
	[Nullable(2)]
	private UUIItem ItemForLocation;

	// Token: 0x0400556E RID: 21870
	private string PlayerTitleInfoString = "";

	// Token: 0x0400556F RID: 21871
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x02007EB2 RID: 32434
	[NullableContext(0)]
	private class EPlayerTitleInfoTipDefine
	{
		// Token: 0x040296BC RID: 169660
		public const int ItemRoot = 0;

		// Token: 0x040296BD RID: 169661
		public const int PanelInfoTip = 1;

		// Token: 0x040296BE RID: 169662
		public const int TxtInfoTip = 2;

		// Token: 0x040296BF RID: 169663
		public const int BtnMask = 3;

		// Token: 0x040296C0 RID: 169664
		public const int TextureIcon = 4;
	}
}
