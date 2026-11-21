using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EE4 RID: 7908
[NullableContext(1)]
[Nullable(0)]
public class SdkLoadPopUpViewData
{
	// Token: 0x06013885 RID: 80005 RVA: 0x005B1972 File Offset: 0x005AFB72
	public static SdkLoadPopUpViewData Create(int forceCloseTime, string openReason)
	{
		return new SdkLoadPopUpViewData
		{
			ForceCloseTime = forceCloseTime,
			OpenReason = openReason
		};
	}

	// Token: 0x0400A6FB RID: 42747
	public int ForceCloseTime = 5;

	// Token: 0x0400A6FC RID: 42748
	public string OpenReason = "";
}
