using System;
using System.Runtime.CompilerServices;

// Token: 0x02002968 RID: 10600
[NullableContext(1)]
[Nullable(0)]
public class SdkPayTipData
{
	// Token: 0x06015E7F RID: 89727 RVA: 0x0058690F File Offset: 0x00584B0F
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

	// Token: 0x0400A30C RID: 41740
	public string PayStateSpritePath = "";

	// Token: 0x0400A30D RID: 41741
	public string PayResultTextId = "";

	// Token: 0x0400A30E RID: 41742
	public string PayContentTextId = "";

	// Token: 0x0400A30F RID: 41743
	public int CountDownTime;

	// Token: 0x0400A310 RID: 41744
	public string CountDownTextId = "";
}
