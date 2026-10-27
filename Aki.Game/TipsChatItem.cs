using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002533 RID: 9523
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TipsChatItem : SyncGridProxyAbstract<PhoneMsgChatData>
{
	// Token: 0x0601324C RID: 78412 RVA: 0x004C0808 File Offset: 0x004BEA08
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0601324D RID: 78413 RVA: 0x004C0864 File Offset: 0x004BEA64
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		UUIText text = base.GetText(1);
		UUIText text2 = base.GetText(2);
		text.bGameRichText = true;
		text.richText = true;
		text2.bGameRichText = true;
		text2.richText = true;
	}

	// Token: 0x0601324E RID: 78414 RVA: 0x004C08AC File Offset: 0x004BEAAC
	[NullableContext(1)]
	public override void Refresh(PhoneMsgChatData data)
	{
		this.PhoneMsgChatData = data;
		bool flag = true;
		base.GetItem(0).SetUIActive(flag);
		base.GetText(1).SetUIActive(flag);
		base.GetText(2).SetUIActive(!flag);
		if (flag)
		{
			base.GetText(1).SetText(this.PhoneMsgChatData.ContentStr, true);
			return;
		}
		base.GetText(2).SetText(this.PhoneMsgChatData.ContentStr, true);
	}

	// Token: 0x0601324F RID: 78415 RVA: 0x004C0920 File Offset: 0x004BEB20
	public UniTask PlayTipsAnimationAsync()
	{
		TipsChatItem.<PlayTipsAnimationAsync>d__6 <PlayTipsAnimationAsync>d__;
		<PlayTipsAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayTipsAnimationAsync>d__.<>4__this = this;
		<PlayTipsAnimationAsync>d__.<>1__state = -1;
		<PlayTipsAnimationAsync>d__.<>t__builder.Start<TipsChatItem.<PlayTipsAnimationAsync>d__6>(ref <PlayTipsAnimationAsync>d__);
		return <PlayTipsAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013250 RID: 78416 RVA: 0x004C0963 File Offset: 0x004BEB63
	public void StopTipsAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("In", false, true);
	}

	// Token: 0x04009091 RID: 37009
	private PhoneMsgChatData PhoneMsgChatData;

	// Token: 0x04009092 RID: 37010
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008ABA RID: 35514
	[NullableContext(0)]
	private enum EItemTipsComponent
	{
		// Token: 0x0402D0D1 RID: 184529
		PnlWarn,
		// Token: 0x0402D0D2 RID: 184530
		TxtWarn,
		// Token: 0x0402D0D3 RID: 184531
		TxtTips
	}
}
