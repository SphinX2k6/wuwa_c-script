using System;

// Token: 0x020027A7 RID: 10151
public class CurrentRoleIdHolder : IStaticVariableResetter
{
	// Token: 0x0601975E RID: 104286 RVA: 0x007CC111 File Offset: 0x007CA311
	static CurrentRoleIdHolder()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CurrentRoleIdHolder.CreateStaticDefaultValue), new Action(CurrentRoleIdHolder.ResetStaticDefaultValue));
	}

	// Token: 0x0601975F RID: 104287 RVA: 0x007CC130 File Offset: 0x007CA330
	public static void CreateStaticDefaultValue()
	{
		CurrentRoleIdHolder.currentRoleId = 0;
	}

	// Token: 0x06019760 RID: 104288 RVA: 0x007CC138 File Offset: 0x007CA338
	public static void ResetStaticDefaultValue()
	{
		CurrentRoleIdHolder.currentRoleId = 0;
	}

	// Token: 0x0400DF2E RID: 57134
	public static int currentRoleId;
}
