using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x020019F3 RID: 6643
[NullableContext(1)]
[Nullable(0)]
public class PhoneMsgChatData
{
	// Token: 0x1700190B RID: 6411
	// (get) Token: 0x060105F7 RID: 67063 RVA: 0x004C84C3 File Offset: 0x004C66C3
	public bool IsVoicePlayed
	{
		get
		{
			return this.ContentType == EChatMsgType.Voice && this.VoiceEventHash != 0 && PhoneMsgModel.Instance.TryGetVoiceRedDot(this.VoiceEventHash);
		}
	}

	// Token: 0x060105F8 RID: 67064 RVA: 0x004C84E9 File Offset: 0x004C66E9
	public PhoneMsgChatData(EPhoneMsgContentType chatContentType)
	{
		this.ChatContentType = chatContentType;
	}

	// Token: 0x060105F9 RID: 67065 RVA: 0x004C8520 File Offset: 0x004C6720
	public void SetScrollWaitTime(int time)
	{
		if (time > 0)
		{
			this.ScrollWaitTimeType = EPhoneMsgScrollWaitTimeType.LoadConfig;
			this.ScrollWaitTime = time;
			return;
		}
		if (this.ContentStr.Length > 0)
		{
			int length = this.ContentStr.Length;
			foreach (PhoneMsgInputTimeData phoneMsgInputTimeData in PhoneMsgModel.Instance.MsgInputTimeList)
			{
				int delayTime = phoneMsgInputTimeData.GetDelayTime(length);
				if (delayTime >= 0)
				{
					this.ScrollWaitTimeType = EPhoneMsgScrollWaitTimeType.AutoGenByChatNum;
					this.ScrollWaitTime = delayTime;
					return;
				}
			}
		}
		this.ScrollWaitTimeType = EPhoneMsgScrollWaitTimeType.FinalTime;
		this.ScrollWaitTime = 1000;
	}

	// Token: 0x04009101 RID: 37121
	public EPhoneMsgContentType ChatContentType = EPhoneMsgContentType.Tips;

	// Token: 0x04009102 RID: 37122
	public EChatMsgType ContentType;

	// Token: 0x04009103 RID: 37123
	public int SpeakerIcon;

	// Token: 0x04009104 RID: 37124
	public string SpeakerHeadIconPath = "";

	// Token: 0x04009105 RID: 37125
	public string SpeakerName = "";

	// Token: 0x04009106 RID: 37126
	public int ChatDialogId;

	// Token: 0x04009107 RID: 37127
	[Nullable(2)]
	public ITalkItem TalkItem;

	// Token: 0x04009108 RID: 37128
	public string ContentStr = "";

	// Token: 0x04009109 RID: 37129
	public int ContentNum;

	// Token: 0x0400910A RID: 37130
	public bool IsSendError;

	// Token: 0x0400910B RID: 37131
	public bool IsFinish;

	// Token: 0x0400910C RID: 37132
	public int QuestId;

	// Token: 0x0400910D RID: 37133
	public int BirthdayCardItemId;

	// Token: 0x0400910E RID: 37134
	public int DropId;

	// Token: 0x0400910F RID: 37135
	public int ActivityId;

	// Token: 0x04009110 RID: 37136
	public bool IsGroupChat;

	// Token: 0x04009111 RID: 37137
	public int VoiceEventHash;

	// Token: 0x04009112 RID: 37138
	public float VoiceDuration;

	// Token: 0x04009113 RID: 37139
	public EPhoneMessageVoicePushCondition? PushCondition;

	// Token: 0x04009114 RID: 37140
	public bool IsAutoPlay;

	// Token: 0x04009115 RID: 37141
	public int ScrollWaitTime;

	// Token: 0x04009116 RID: 37142
	public EPhoneMsgScrollWaitTimeType ScrollWaitTimeType;

	// Token: 0x04009117 RID: 37143
	public int ShortMessageId;

	// Token: 0x04009118 RID: 37144
	public int ChatPartnerId;

	// Token: 0x04009119 RID: 37145
	public long UnLockTime;
}
