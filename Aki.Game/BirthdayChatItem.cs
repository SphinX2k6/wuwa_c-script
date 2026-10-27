using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002537 RID: 9527
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BirthdayChatItem : SyncGridProxyAbstract<PhoneMsgChatData>
{
	// Token: 0x06013260 RID: 78432 RVA: 0x004C0D34 File Offset: 0x004BEF34
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

	// Token: 0x06013261 RID: 78433 RVA: 0x004C0E20 File Offset: 0x004BF020
	protected override void OnStart()
	{
		base.GetSprite(4).SetUIActive(false);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.GetButton(3).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x06013262 RID: 78434 RVA: 0x004C0E68 File Offset: 0x004BF068
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

	// Token: 0x06013263 RID: 78435 RVA: 0x004C0ED4 File Offset: 0x004BF0D4
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

	// Token: 0x06013264 RID: 78436 RVA: 0x004C0F20 File Offset: 0x004BF120
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

	// Token: 0x06013265 RID: 78437 RVA: 0x004C0F6C File Offset: 0x004BF16C
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

	// Token: 0x06013266 RID: 78438 RVA: 0x004C1044 File Offset: 0x004BF244
	public UniTask PlayBirthdayAnimationAsync()
	{
		BirthdayChatItem.<PlayBirthdayAnimationAsync>d__10 <PlayBirthdayAnimationAsync>d__;
		<PlayBirthdayAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayBirthdayAnimationAsync>d__.<>4__this = this;
		<PlayBirthdayAnimationAsync>d__.<>1__state = -1;
		<PlayBirthdayAnimationAsync>d__.<>t__builder.Start<BirthdayChatItem.<PlayBirthdayAnimationAsync>d__10>(ref <PlayBirthdayAnimationAsync>d__);
		return <PlayBirthdayAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013267 RID: 78439 RVA: 0x004C1087 File Offset: 0x004BF287
	public void StopBirthdayAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("In", false, true);
	}

	// Token: 0x06013268 RID: 78440 RVA: 0x004C109C File Offset: 0x004BF29C
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

	// Token: 0x04009096 RID: 37014
	[Nullable(2)]
	private PhoneMsgChatData PhoneMsgChatData;

	// Token: 0x04009097 RID: 37015
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009098 RID: 37016
	private readonly Dictionary<string, int> TextureLoadResourceIds = new Dictionary<string, int>();

	// Token: 0x02008ABE RID: 35518
	[NullableContext(0)]
	private enum EItemBirthdayComponent
	{
		// Token: 0x0402D0E4 RID: 184548
		TexCake,
		// Token: 0x0402D0E5 RID: 184549
		TxtDesc,
		// Token: 0x0402D0E6 RID: 184550
		TxtTitle,
		// Token: 0x0402D0E7 RID: 184551
		BtnGoTo,
		// Token: 0x0402D0E8 RID: 184552
		SpriteFinish,
		// Token: 0x0402D0E9 RID: 184553
		TexBg,
		// Token: 0x0402D0EA RID: 184554
		TexTransitionBg,
		// Token: 0x0402D0EB RID: 184555
		TexTransitionIcon
	}
}
