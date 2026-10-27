using System;

// Token: 0x020031D6 RID: 12758
public class NpcMatHandleInfo : IStaticVariableResetter
{
	// Token: 0x0601B834 RID: 112692 RVA: 0x0078B622 File Offset: 0x00789822
	static NpcMatHandleInfo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NpcMatHandleInfo.CreateStaticDefaultValue), new Action(NpcMatHandleInfo.ResetStaticDefaultValue));
	}

	// Token: 0x0601B835 RID: 112693 RVA: 0x0078B641 File Offset: 0x00789841
	public static void CreateStaticDefaultValue()
	{
		NpcMatHandleInfo.IdGenerator = 0;
	}

	// Token: 0x0601B836 RID: 112694 RVA: 0x0078B649 File Offset: 0x00789849
	public static void ResetStaticDefaultValue()
	{
		NpcMatHandleInfo.IdGenerator = 0;
	}

	// Token: 0x0400D804 RID: 55300
	private static int IdGenerator;

	// Token: 0x0400D805 RID: 55301
	public int Id = ++NpcMatHandleInfo.IdGenerator;

	// Token: 0x0400D806 RID: 55302
	public EMatDataType Type;

	// Token: 0x0400D807 RID: 55303
	public int Handle;
}
