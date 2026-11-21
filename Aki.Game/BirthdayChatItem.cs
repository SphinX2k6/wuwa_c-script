using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A20 RID: 6688
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BirthdayChatItem : SyncGridProxyAbstract<PhoneMsgChatData>
{
	// Token: 0x06010733 RID: 67379 RVA: 0x004CF2F8 File Offset: 0x004CD4F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUITextureTransitionComponent)),
			new ValueTuple<int, Type>(7, typeof(UUITextureTransitionComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnGoToClick))
		};
	}

	// Token: 0x06010734 RID: 67380 RVA: 0x004CF3E4 File Offset: 0x004CD5E4
	protected override void OnStart()
	{
		base.GetSprite(4).SetUIActive(false);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.GetButton(3).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x06010735 RID: 67381 RVA: 0x004CF42C File Offset: 0x004CD62C
	public override void Refresh(PhoneMsgChatData data)
	{
		this.PhoneMsgChatData = data;
		if (ConfigBirthDayByItemId.GetConfig(data.BirthdayCardItemId, true) == null)
		{
			return;
		}
		UiAsyncTask task = new UiAsyncTask("BirthdayChatItem.UpdateBirthdayItemAs", () => this.UpdateBirthdayItemAsync(data), null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06010736 RID: 67382 RVA: 0x004CF498 File Offset: 0x004CD698
	private UniTask UpdateBirthdayItemAsync(PhoneMsgChatData data)
	{
		BirthdayChatItem.<UpdateBirthdayItemAsync>d__7 <UpdateBirthdayItemAsync>d__;
		<UpdateBirthdayItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateBirthdayItemAsync>d__.<>4__this = this;
		<UpdateBirthdayItemAsync>d__.data = data;
		<UpdateBirthdayItemAsync>d__.<>1__state = -1;
		<UpdateBirthdayItemAsync>d__.<>t__builder.Start<BirthdayChatItem.<UpdateBirthdayItemAsync>d__7>(ref <UpdateBirthdayItemAsync>d__);
		return <UpdateBirthdayItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010737 RID: 67383 RVA: 0x004CF4E4 File Offset: 0x004CD6E4
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<UTexture> LoadTextureAsyncWithCancel(string path)
	{
		BirthdayChatItem.<LoadTextureAsyncWithCancel>d__8 <LoadTextureAsyncWithCancel>d__;
		<LoadTextureAsyncWithCancel>d__.<>t__builder = AsyncUniTaskMethodBuilder<UTexture>.Create();
		<LoadTextureAsyncWithCancel>d__.<>4__this = this;
		<LoadTextureAsyncWithCancel>d__.path = path;
		<LoadTextureAsyncWithCancel>d__.<>1__state = -1;
		<LoadTextureAsyncWithCancel>d__.<>t__builder.Start<BirthdayChatItem.<LoadTextureAsyncWithCancel>d__8>(ref <LoadTextureAsyncWithCancel>d__);
		return <LoadTextureAsyncWithCancel>d__.<>t__builder.Task;
	}

	// Token: 0x06010738 RID: 67384 RVA: 0x004CF530 File Offset: 0x004CD730
	private void OnGoToClick()
	{
		if (this.PhoneMsgChatData == null)
		{
			return;
		}
		int birthdayCardItemId = this.PhoneMsgChatData.BirthdayCardItemId;
		if (birthdayCardItemId == 0)
		{
			return;
		}
		BirthdayController.Instance.UseBirthdayItem(birthdayCardItemId);
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(this.PhoneMsgChatData.ShortMessageId);
		if (phoneMsgConfig == null)
		{
			return;
		}
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = PhoneMsgModel.Instance.GetPhoneMsgShortMsgDataByShortMsgId(this.PhoneMsgChatData.ShortMessageId);
		long l_received_time = 0L;
		if (phoneMsgShortMsgDataByShortMsgId != null)
		{
			l_received_time = phoneMsgShortMsgDataByShortMsgId.UnLockTime;
		}
		OnJumpInShortMessageLogEvent onJumpInShortMessageLogEvent = new OnJumpInShortMessageLogEvent();
		onJumpInShortMessageLogEvent.i_id = this.PhoneMsgChatData.ShortMessageId;
		onJumpInShortMessageLogEvent.i_type = (this.PhoneMsgChatData.IsGroupChat ? 1 : 2);
		onJumpInShortMessageLogEvent.i_role_id = phoneMsgConfig.Value.WhichChat;
		onJumpInShortMessageLogEvent.l_received_time = l_received_time;
		onJumpInShortMessageLogEvent.i_trigger_type = 2;
		LogReportController.Instance.LogReport(onJumpInShortMessageLogEvent);
	}

	// Token: 0x06010739 RID: 67385 RVA: 0x004CF608 File Offset: 0x004CD808
	public UniTask PlayBirthdayAnimationAsync()
	{
		BirthdayChatItem.<PlayBirthdayAnimationAsync>d__10 <PlayBirthdayAnimationAsync>d__;
		<PlayBirthdayAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayBirthdayAnimationAsync>d__.<>4__this = this;
		<PlayBirthdayAnimationAsync>d__.<>1__state = -1;
		<PlayBirthdayAnimationAsync>d__.<>t__builder.Start<BirthdayChatItem.<PlayBirthdayAnimationAsync>d__10>(ref <PlayBirthdayAnimationAsync>d__);
		return <PlayBirthdayAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601073A RID: 67386 RVA: 0x004CF64B File Offset: 0x004CD84B
	public void StopBirthdayAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("In", false, true);
	}

	// Token: 0x0601073B RID: 67387 RVA: 0x004CF660 File Offset: 0x004CD860
	protected override void OnBeforeDestroy()
	{
		foreach (KeyValuePair<string, int> keyValuePair in this.TextureLoadResourceIds)
		{
			if (keyValuePair.Value != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(keyValuePair.Value);
			}
		}
		this.TextureLoadResourceIds.Clear();
	}

	// Token: 0x040091F0 RID: 37360
	[Nullable(2)]
	private PhoneMsgChatData PhoneMsgChatData;

	// Token: 0x040091F1 RID: 37361
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040091F2 RID: 37362
	private readonly Dictionary<string, int> TextureLoadResourceIds = new Dictionary<string, int>();

	// Token: 0x02007C47 RID: 31815
	[NullableContext(0)]
	private enum EItemBirthdayComponent
	{
		// Token: 0x04028404 RID: 164868
		TexCake,
		// Token: 0x04028405 RID: 164869
		TxtDesc,
		// Token: 0x04028406 RID: 164870
		TxtTitle,
		// Token: 0x04028407 RID: 164871
		BtnGoTo,
		// Token: 0x04028408 RID: 164872
		SpriteFinish,
		// Token: 0x04028409 RID: 164873
		TexBg,
		// Token: 0x0402840A RID: 164874
		TexTransitionBg,
		// Token: 0x0402840B RID: 164875
		TexTransitionIcon
	}
}
