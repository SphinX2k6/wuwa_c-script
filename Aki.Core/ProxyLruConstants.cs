using System;

// Token: 0x0200005A RID: 90
public class ProxyLruConstants : IStaticVariableResetter
{
	// Token: 0x060002BB RID: 699 RVA: 0x0000ECC7 File Offset: 0x0000CEC7
	static ProxyLruConstants()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ProxyLruConstants.CreateStaticDefaultValue), new Action(ProxyLruConstants.ResetStaticDefaultValue));
	}

	// Token: 0x060002BC RID: 700 RVA: 0x0000ECE6 File Offset: 0x0000CEE6
	public static void CreateStaticDefaultValue()
	{
		ProxyLruConstants.ProxyLruEnable = true;
	}

	// Token: 0x060002BD RID: 701 RVA: 0x0000ECEE File Offset: 0x0000CEEE
	public static void ResetStaticDefaultValue()
	{
		ProxyLruConstants.ProxyLruEnable = true;
	}

	// Token: 0x040001F9 RID: 505
	public static bool ProxyLruEnable;
}
