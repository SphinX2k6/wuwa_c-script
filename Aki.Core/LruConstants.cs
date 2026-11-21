using System;

// Token: 0x02000052 RID: 82
public class LruConstants : IStaticVariableResetter
{
	// Token: 0x0600024F RID: 591 RVA: 0x0000CC50 File Offset: 0x0000AE50
	static LruConstants()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LruConstants.CreateStaticDefaultValue), new Action(LruConstants.ResetStaticDefaultValue));
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0000CC6F File Offset: 0x0000AE6F
	public static void CreateStaticDefaultValue()
	{
		LruConstants.IsLruEnabledGlobal = true;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x0000CC77 File Offset: 0x0000AE77
	public static void ResetStaticDefaultValue()
	{
		LruConstants.IsLruEnabledGlobal = true;
	}

	// Token: 0x040001CC RID: 460
	public static bool IsLruEnabledGlobal;
}
