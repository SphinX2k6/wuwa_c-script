using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x0200250C RID: 9484
[NullableContext(1)]
[Nullable(0)]
public class PhoneMsgChatData
{
	// Token: 0x170018D1 RID: 6353
	// (get) Token: 0x06013138 RID: 78136 RVA: 0x004BA773 File Offset: 0x004B8973
	public bool IsVoicePlayed
	{
		get
		{
			return this.ContentType == EChatMsgType.Voice && this.VoiceEventHash != 0 && PhoneMsgModel.Instance.TryGetVoiceRedDot(this.VoiceEventHash);
		}
	}

	// Token: 0x06013139 RID: 78137 RVA: 0x004BA799 File Offset: 0x004B8999
	public PhoneMsgChatData(EPhoneMsgContentType chatContentType)
	{
		this.ChatContentType = chatContentType;
	}

	// Token: 0x0601313A RID: 78138 RVA: 0x004BA7D0 File Offset: 0x004B89D0
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

	// Token: 0x04008FB5 RID: 36789
	public EPhoneMsgContentType ChatContentType = EPhoneMsgContentType.Tips;

	// Token: 0x04008FB6 RID: 36790
	public EChatMsgType ContentType;

	// Token: 0x04008FB7 RID: 36791
	public int SpeakerIcon;

	// Token: 0x04008FB8 RID: 36792
	public string SpeakerHeadIconPath = "";

	// Token: 0x04008FB9 RID: 36793
	public string SpeakerName = "";

	// Token: 0x04008FBA RID: 36794
	public int ChatDialogId;

	// Token: 0x04008FBB RID: 36795
	[Nullable(2)]
	public ITalkItem TalkItem;

	// Token: 0x04008FBC RID: 36796
	public string ContentStr = "";

	// Token: 0x04008FBD RID: 36797
	public int ContentNum;

	// Token: 0x04008FBE RID: 36798
	public bool IsSendError;

	// Token: 0x04008FBF RID: 36799
	public bool IsFinish;

	// Token: 0x04008FC0 RID: 36800
	public int QuestId;

	// Token: 0x04008FC1 RID: 36801
	public int BirthdayCardItemId;

	// Token: 0x04008FC2 RID: 36802
	public int DropId;

	// Token: 0x04008FC3 RID: 36803
	public bool IsGroupChat;

	// Token: 0x04008FC4 RID: 36804
	public int VoiceEventHash;

	// Token: 0x04008FC5 RID: 36805
	public float VoiceDuration;

	// Token: 0x04008FC6 RID: 36806
	public EPhoneMessageVoicePushCondition? PushCondition;

	// Token: 0x04008FC7 RID: 36807
	public bool IsAutoPlay;

	// Token: 0x04008FC8 RID: 36808
	public int ScrollWaitTime;

	// Token: 0x04008FC9 RID: 36809
	public EPhoneMsgScrollWaitTimeType ScrollWaitTimeType;

	// Token: 0x04008FCA RID: 36810
	public int ShortMessageId;

	// Token: 0x04008FCB RID: 36811
	public int ChatPartnerId;

	// Token: 0x04008FCC RID: 36812
	public long UnLockTime;
}
