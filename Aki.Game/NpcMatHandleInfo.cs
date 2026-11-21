using System;

// Token: 0x02002745 RID: 10053
public class NpcMatHandleInfo : IStaticVariableResetter
{
	// Token: 0x0601938F RID: 103311 RVA: 0x007B3417 File Offset: 0x007B1617
	static NpcMatHandleInfo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NpcMatHandleInfo.CreateStaticDefaultValue), new Action(NpcMatHandleInfo.ResetStaticDefaultValue));
	}

	// Token: 0x06019390 RID: 103312 RVA: 0x007B3436 File Offset: 0x007B1636
	public static void CreateStaticDefaultValue()
	{
		NpcMatHandleInfo.IdGenerator = 0;
	}

	// Token: 0x06019391 RID: 103313 RVA: 0x007B343E File Offset: 0x007B163E
	public static void ResetStaticDefaultValue()
	{
		NpcMatHandleInfo.IdGenerator = 0;
	}

	// Token: 0x0400DC8B RID: 56459
	private static int IdGenerator;

	// Token: 0x0400DC8C RID: 56460
	public int Id = ++NpcMatHandleInfo.IdGenerator;

	// Token: 0x0400DC8D RID: 56461
	public EMatDataType Type;

	// Token: 0x0400DC8E RID: 56462
	public int Handle;
}
