using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A13 RID: 6675
public class PhoneMsgTipViewA : UiPanelBase
{
	// Token: 0x060106E2 RID: 67298 RVA: 0x004CD970 File Offset: 0x004CBB70
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

	// Token: 0x060106E3 RID: 67299 RVA: 0x004CDA24 File Offset: 0x004CBC24
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

	// Token: 0x060106E4 RID: 67300 RVA: 0x004CDA6C File Offset: 0x004CBC6C
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

	// Token: 0x060106E5 RID: 67301 RVA: 0x004CDAFA File Offset: 0x004CBCFA
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

	// Token: 0x060106E6 RID: 67302 RVA: 0x004CDB24 File Offset: 0x004CBD24
	public int? GetMessageDataId()
	{
		if (this.MsgData == null)
		{
			return null;
		}
		return new int?(this.MsgData.Value.Id);
	}

	// Token: 0x040091CE RID: 37326
	private ShortMessage? MsgData;

	// Token: 0x040091CF RID: 37327
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x02007C3C RID: 31804
	private enum EComponent
	{
		// Token: 0x040283D1 RID: 164817
		BtnClick,
		// Token: 0x040283D2 RID: 164818
		TexHeadIcon,
		// Token: 0x040283D3 RID: 164819
		PanelFold,
		// Token: 0x040283D4 RID: 164820
		PanelUnFold,
		// Token: 0x040283D5 RID: 164821
		ItemProgressBar,
		// Token: 0x040283D6 RID: 164822
		TxtRoleName,
		// Token: 0x040283D7 RID: 164823
		TxtMsgInfo
	}
}
