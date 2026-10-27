using System;
using System.Runtime.CompilerServices;

// Token: 0x02002969 RID: 10601
[NullableContext(1)]
[Nullable(0)]
public class SdkLoadPopUpViewData
{
	// Token: 0x06015E81 RID: 89729 RVA: 0x0058696E File Offset: 0x00584B6E
	public static SdkLoadPopUpViewData Create(int forceCloseTime, string openReason)
	{
		return new SdkLoadPopUpViewData
		{
			ForceCloseTime = forceCloseTime,
			OpenReason = openReason
		};
	}

	// Token: 0x0400A311 RID: 41745
	public int ForceCloseTime = 5;

	// Token: 0x0400A312 RID: 41746
	public string OpenReason = "";
}
