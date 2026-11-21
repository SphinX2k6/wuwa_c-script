using System;
using Aki.Config;

// Token: 0x020019FC RID: 6652
public class PhoneMsgInputTimeData
{
	// Token: 0x0601060F RID: 67087 RVA: 0x004C8A1F File Offset: 0x004C6C1F
	public PhoneMsgInputTimeData(PhoneInputTime config)
	{
		this.DelayTime = config.DelayTime;
		this.MinChatNum = config.StartChatNum;
		this.MaxChatNum = config.EndChatNum;
	}

	// Token: 0x06010610 RID: 67088 RVA: 0x004C8A4E File Offset: 0x004C6C4E
	public int GetDelayTime(int chatNum)
	{
		if (this.MinChatNum <= chatNum && (this.MaxChatNum == 0 || chatNum < this.MaxChatNum))
		{
			return this.DelayTime;
		}
		return -1;
	}

	// Token: 0x04009147 RID: 37191
	public int DelayTime;

	// Token: 0x04009148 RID: 37192
	public int MinChatNum;

	// Token: 0x04009149 RID: 37193
	public int MaxChatNum;
}
