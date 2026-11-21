using System;
using System.Runtime.CompilerServices;

// Token: 0x0200142F RID: 5167
public class HudUnitUtils : IStaticVariableResetter
{
	// Token: 0x0600CDB2 RID: 52658 RVA: 0x003D3841 File Offset: 0x003D1A41
	static HudUnitUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HudUnitUtils.CreateStaticDefaultValue), new Action(HudUnitUtils.ResetStaticDefaultValue));
	}

	// Token: 0x0600CDB3 RID: 52659 RVA: 0x003D3860 File Offset: 0x003D1A60
	public static void CreateStaticDefaultValue()
	{
		HudUnitUtils.PositionUtil = new HudUnitPositionUtil();
	}

	// Token: 0x0600CDB4 RID: 52660 RVA: 0x003D386C File Offset: 0x003D1A6C
	public static void ResetStaticDefaultValue()
	{
		HudUnitUtils.PositionUtil = null;
	}

	// Token: 0x04007538 RID: 30008
	[Nullable(1)]
	public static HudUnitPositionUtil PositionUtil;
}
