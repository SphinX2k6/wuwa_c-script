using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F6D RID: 8045
public class HudUnitUtils : IStaticVariableResetter
{
	// Token: 0x0600F993 RID: 63891 RVA: 0x003C7D55 File Offset: 0x003C5F55
	static HudUnitUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HudUnitUtils.CreateStaticDefaultValue), new Action(HudUnitUtils.ResetStaticDefaultValue));
	}

	// Token: 0x0600F994 RID: 63892 RVA: 0x003C7D74 File Offset: 0x003C5F74
	public static void CreateStaticDefaultValue()
	{
		HudUnitUtils.PositionUtil = new HudUnitPositionUtil();
	}

	// Token: 0x0600F995 RID: 63893 RVA: 0x003C7D80 File Offset: 0x003C5F80
	public static void ResetStaticDefaultValue()
	{
		HudUnitUtils.PositionUtil = null;
	}

	// Token: 0x04007457 RID: 29783
	[Nullable(1)]
	public static HudUnitPositionUtil PositionUtil;
}
