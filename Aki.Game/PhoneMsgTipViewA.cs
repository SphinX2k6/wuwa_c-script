using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200252C RID: 9516
public class PhoneMsgTipViewA : UiPanelBase
{
	// Token: 0x06013222 RID: 78370 RVA: 0x004BFC64 File Offset: 0x004BDE64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
	}

	// Token: 0x06013223 RID: 78371 RVA: 0x004BFD18 File Offset: 0x004BDF18
	protected override void OnStart()
	{
		ShortMessage? shortMessage = this.OpenParam as ShortMessage?;
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		if (shortMessage == null)
		{
			return;
		}
		this.OnRefreshByData(shortMessage.Value);
	}

	// Token: 0x06013224 RID: 78372 RVA: 0x004BFD60 File Offset: 0x004BDF60
	public void OnRefreshByData(ShortMessage msgData)
	{
		this.MsgData = new ShortMessage?(msgData);
		int whichChat = this.MsgData.Value.WhichChat;
		ChatPartner? chatPartnerConfigNew = PhoneMsgModel.Instance.GetChatPartnerConfigNew(whichChat);
		if (this.MsgData == null || chatPartnerConfigNew == null)
		{
			return;
		}
		UUIText text = base.GetText(6);
		text.bGameRichText = true;
		text.richText = true;
		string icon = chatPartnerConfigNew.Value.Icon;
		base.SetTextureByPath(icon, base.GetTexture(1), null, null);
	}

	// Token: 0x06013225 RID: 78373 RVA: 0x004BFDEE File Offset: 0x004BDFEE
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
		this.RootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x06013226 RID: 78374 RVA: 0x004BFE18 File Offset: 0x004BE018
	public int? GetMessageDataId()
	{
		if (this.MsgData == null)
		{
			return null;
		}
		return new int?(this.MsgData.Value.Id);
	}

	// Token: 0x04009079 RID: 36985
	private ShortMessage? MsgData;

	// Token: 0x0400907A RID: 36986
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x02008AB5 RID: 35509
	private enum EComponent
	{
		// Token: 0x0402D0BD RID: 184509
		BtnClick,
		// Token: 0x0402D0BE RID: 184510
		TexHeadIcon,
		// Token: 0x0402D0BF RID: 184511
		PanelFold,
		// Token: 0x0402D0C0 RID: 184512
		PanelUnFold,
		// Token: 0x0402D0C1 RID: 184513
		ItemProgressBar,
		// Token: 0x0402D0C2 RID: 184514
		TxtRoleName,
		// Token: 0x0402D0C3 RID: 184515
		TxtMsgInfo
	}
}
