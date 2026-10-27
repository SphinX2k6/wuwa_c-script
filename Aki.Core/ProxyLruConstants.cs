using System;

// Token: 0x02000058 RID: 88
public class ProxyLruConstants : IStaticVariableResetter
{
	// Token: 0x06000280 RID: 640 RVA: 0x0000DEDF File Offset: 0x0000C0DF
	static ProxyLruConstants()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ProxyLruConstants.CreateStaticDefaultValue), new Action(ProxyLruConstants.ResetStaticDefaultValue));
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0000DEFE File Offset: 0x0000C0FE
	public static void CreateStaticDefaultValue()
	{
		ProxyLruConstants.ProxyLruEnable = true;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0000DF06 File Offset: 0x0000C106
	public static void ResetStaticDefaultValue()
	{
		ProxyLruConstants.ProxyLruEnable = true;
	}

	// Token: 0x040001E3 RID: 483
	public static bool ProxyLruEnable;
}
