using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002E38 RID: 11832
public class CampUtils : IStaticVariableResetter
{
	// Token: 0x06018F3C RID: 102204 RVA: 0x0066EA6F File Offset: 0x0066CC6F
	static CampUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CampUtils.CreateStaticDefaultValue), new Action(CampUtils.ResetStaticDefaultValue));
	}

	// Token: 0x06018F3D RID: 102205 RVA: 0x0066EA8E File Offset: 0x0066CC8E
	public static ERelation GetCampRelationship(ECamp selfCamp, ECamp targetCamp)
	{
		return CampUtils.Camp[(int)selfCamp][(int)targetCamp];
	}

	// Token: 0x06018F3E RID: 102206 RVA: 0x0066EAA1 File Offset: 0x0066CCA1
	public static void CreateStaticDefaultValue()
	{
		CampUtils.Camp = new List<List<ERelation>>();
	}

	// Token: 0x06018F3F RID: 102207 RVA: 0x0066EAAD File Offset: 0x0066CCAD
	public static void ResetStaticDefaultValue()
	{
		CampUtils.Camp = null;
	}

	// Token: 0x0400BB75 RID: 47989
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static List<List<ERelation>> Camp;
}
