using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A1A RID: 6682
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TipsChatItem : SyncGridProxyAbstract<PhoneMsgChatData>
{
	// Token: 0x06010710 RID: 67344 RVA: 0x004CE7B4 File Offset: 0x004CC9B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06010711 RID: 67345 RVA: 0x004CE810 File Offset: 0x004CCA10
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

	// Token: 0x06010712 RID: 67346 RVA: 0x004CE858 File Offset: 0x004CCA58
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

	// Token: 0x06010713 RID: 67347 RVA: 0x004CE8CC File Offset: 0x004CCACC
	public UniTask PlayTipsAnimationAsync()
	{
		TipsChatItem.<PlayTipsAnimationAsync>d__6 <PlayTipsAnimationAsync>d__;
		<PlayTipsAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayTipsAnimationAsync>d__.<>4__this = this;
		<PlayTipsAnimationAsync>d__.<>1__state = -1;
		<PlayTipsAnimationAsync>d__.<>t__builder.Start<TipsChatItem.<PlayTipsAnimationAsync>d__6>(ref <PlayTipsAnimationAsync>d__);
		return <PlayTipsAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010714 RID: 67348 RVA: 0x004CE90F File Offset: 0x004CCB0F
	public void StopTipsAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("In", false, true);
	}

	// Token: 0x040091E8 RID: 37352
	private PhoneMsgChatData PhoneMsgChatData;

	// Token: 0x040091E9 RID: 37353
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007C41 RID: 31809
	[NullableContext(0)]
	private enum EItemTipsComponent
	{
		// Token: 0x040283E5 RID: 164837
		PnlWarn,
		// Token: 0x040283E6 RID: 164838
		TxtWarn,
		// Token: 0x040283E7 RID: 164839
		TxtTips
	}
}
