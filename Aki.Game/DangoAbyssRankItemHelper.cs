using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F0C RID: 3852
[NullableContext(1)]
[Nullable(0)]
public static class DangoAbyssRankItemHelper
{
	// Token: 0x06009A48 RID: 39496 RVA: 0x002DC08F File Offset: 0x002DA28F
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

	// Token: 0x04005C22 RID: 23586
	private const string FIRSTPLAYER_ICON = "FormationOnline1PIcon";

	// Token: 0x04005C23 RID: 23587
	private const string SECONDPLAYER_ICON = "FormationOnline2PIcon";

	// Token: 0x04005C24 RID: 23588
	private const string THIRDPLAYER_ICON = "FormationOnline3PIcon";
}
