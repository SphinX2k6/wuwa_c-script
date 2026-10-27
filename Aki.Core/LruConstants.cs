using System;

// Token: 0x02000052 RID: 82
public class LruConstants : IStaticVariableResetter
{
	// Token: 0x0600024E RID: 590 RVA: 0x0000CF6C File Offset: 0x0000B16C
	static LruConstants()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LruConstants.CreateStaticDefaultValue), new Action(LruConstants.ResetStaticDefaultValue));
	}

	// Token: 0x0600024F RID: 591 RVA: 0x0000CF8B File Offset: 0x0000B18B
	public static void CreateStaticDefaultValue()
	{
		LruConstants.IsLruEnabledGlobal = true;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0000CF93 File Offset: 0x0000B193
	public static void ResetStaticDefaultValue()
	{
		LruConstants.IsLruEnabledGlobal = true;
	}

	// Token: 0x040001CA RID: 458
	public static bool IsLruEnabledGlobal;
}
