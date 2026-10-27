using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A4D RID: 6733
[NullableContext(1)]
[Nullable(0)]
public static class DangoAbyssRankItemHelper
{
	// Token: 0x0600C638 RID: 50744 RVA: 0x002D0F7B File Offset: 0x002CF17B
	public static string GetPosTexture(int index)
	{
		if (index == 0)
		{
			return "FormationOnline1PIcon";
		}
		if (index == 1)
		{
			return "FormationOnline2PIcon";
		}
		return "FormationOnline3PIcon";
	}

	// Token: 0x04005B53 RID: 23379
	private const string FIRSTPLAYER_ICON = "FormationOnline1PIcon";

	// Token: 0x04005B54 RID: 23380
	private const string SECONDPLAYER_ICON = "FormationOnline2PIcon";

	// Token: 0x04005B55 RID: 23381
	private const string THIRDPLAYER_ICON = "FormationOnline3PIcon";
}
