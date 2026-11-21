using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002394 RID: 9108
public class CampUtils : IStaticVariableResetter
{
	// Token: 0x06016809 RID: 92169 RVA: 0x00694907 File Offset: 0x00692B07
	static CampUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CampUtils.CreateStaticDefaultValue), new Action(CampUtils.ResetStaticDefaultValue));
	}

	// Token: 0x0601680A RID: 92170 RVA: 0x00694926 File Offset: 0x00692B26
	public static ERelation GetCampRelationship(ECamp selfCamp, ECamp targetCamp)
	{
		return CampUtils.Camp[(int)selfCamp][(int)targetCamp];
	}

	// Token: 0x0601680B RID: 92171 RVA: 0x00694939 File Offset: 0x00692B39
	public static void CreateStaticDefaultValue()
	{
		CampUtils.Camp = new List<List<ERelation>>();
	}

	// Token: 0x0601680C RID: 92172 RVA: 0x00694945 File Offset: 0x00692B45
	public static void ResetStaticDefaultValue()
	{
		CampUtils.Camp = null;
	}

	// Token: 0x0400BF03 RID: 48899
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static List<List<ERelation>> Camp;
}
