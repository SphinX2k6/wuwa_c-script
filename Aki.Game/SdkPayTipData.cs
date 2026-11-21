using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EE3 RID: 7907
[NullableContext(1)]
[Nullable(0)]
public class SdkPayTipData
{
	// Token: 0x06013883 RID: 80003 RVA: 0x005B1913 File Offset: 0x005AFB13
	public static SdkPayTipData Create(string payStateSpritePath, string payResultTextId, string payContentTextId, int countDownTime, string countDownTextId)
	{
		return new SdkPayTipData
		{
			PayStateSpritePath = payStateSpritePath,
			PayResultTextId = payResultTextId,
			PayContentTextId = payContentTextId,
			CountDownTime = countDownTime,
			CountDownTextId = countDownTextId
		};
	}

	// Token: 0x0400A6F6 RID: 42742
	public string PayStateSpritePath = "";

	// Token: 0x0400A6F7 RID: 42743
	public string PayResultTextId = "";

	// Token: 0x0400A6F8 RID: 42744
	public string PayContentTextId = "";

	// Token: 0x0400A6F9 RID: 42745
	public int CountDownTime;

	// Token: 0x0400A6FA RID: 42746
	public string CountDownTextId = "";
}
