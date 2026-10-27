using System;

// Token: 0x02003238 RID: 12856
public class CurrentRoleIdHolder : IStaticVariableResetter
{
	// Token: 0x0601BBC9 RID: 113609 RVA: 0x007A3884 File Offset: 0x007A1A84
	static CurrentRoleIdHolder()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CurrentRoleIdHolder.CreateStaticDefaultValue), new Action(CurrentRoleIdHolder.ResetStaticDefaultValue));
	}

	// Token: 0x0601BBCA RID: 113610 RVA: 0x007A38A3 File Offset: 0x007A1AA3
	public static void CreateStaticDefaultValue()
	{
		CurrentRoleIdHolder.currentRoleId = 0;
	}

	// Token: 0x0601BBCB RID: 113611 RVA: 0x007A38AB File Offset: 0x007A1AAB
	public static void ResetStaticDefaultValue()
	{
		CurrentRoleIdHolder.currentRoleId = 0;
	}

	// Token: 0x0400DA8F RID: 55951
	public static int currentRoleId;
}
