using System;
using Aki.Config;

// Token: 0x02002515 RID: 9493
public class PhoneMsgInputTimeData
{
	// Token: 0x06013150 RID: 78160 RVA: 0x004BACBB File Offset: 0x004B8EBB
	public PhoneMsgInputTimeData(PhoneInputTime config)
	{
		this.DelayTime = config.DelayTime;
		this.MinChatNum = config.StartChatNum;
		this.MaxChatNum = config.EndChatNum;
	}

	// Token: 0x06013151 RID: 78161 RVA: 0x004BACEA File Offset: 0x004B8EEA
	public int GetDelayTime(int chatNum)
	{
		if (this.MinChatNum <= chatNum && (this.MaxChatNum == 0 || chatNum < this.MaxChatNum))
		{
			return this.DelayTime;
		}
		return -1;
	}

	// Token: 0x04008FF3 RID: 36851
	public int DelayTime;

	// Token: 0x04008FF4 RID: 36852
	public int MinChatNum;

	// Token: 0x04008FF5 RID: 36853
	public int MaxChatNum;
}
