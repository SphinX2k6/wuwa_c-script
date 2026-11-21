using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002419 RID: 9241
[NullableContext(1)]
[Nullable(0)]
public class RecordDamageSum
{
	// Token: 0x060171D3 RID: 94675 RVA: 0x006C2644 File Offset: 0x006C0844
	public string[] ToCsvForRole()
	{
		List<string> list = new List<string>();
		list.Add(this.ConfigId.ToString());
		list.Add(this.Name);
		list.Add(this.DamageSourceConfigId.ToString());
		list.Add(this.SourceName);
		list.Add(this.SourceUniqueId.ToString());
		list.Add(this.TotalDamage.ToString());
		for (int i = 0; i < 15; i++)
		{
			list.Add((this.RecordDamage.ContainsKey((ESkillGenre)i) ? this.RecordDamage[(ESkillGenre)i] : 0).ToString());
		}
		return list.ToArray();
	}

	// Token: 0x060171D4 RID: 94676 RVA: 0x006C26F4 File Offset: 0x006C08F4
	public string[] ToCsvForMonster()
	{
		List<string> list = new List<string>();
		list.Add(this.ConfigId.ToString());
		list.Add(this.Name);
		list.Add(this.UniqueId.ToString());
		list.Add(this.DamageSourceConfigId.ToString());
		list.Add(this.SourceName);
		list.Add(this.TotalDamage.ToString());
		for (int i = 0; i < 15; i++)
		{
			list.Add((this.RecordDamage.ContainsKey((ESkillGenre)i) ? this.RecordDamage[(ESkillGenre)i] : 0).ToString());
		}
		return list.ToArray();
	}

	// Token: 0x0400C2B8 RID: 49848
	public int ConfigId;

	// Token: 0x0400C2B9 RID: 49849
	public string Name = "";

	// Token: 0x0400C2BA RID: 49850
	public int UniqueId;

	// Token: 0x0400C2BB RID: 49851
	public int DamageSourceConfigId;

	// Token: 0x0400C2BC RID: 49852
	public string SourceName = "";

	// Token: 0x0400C2BD RID: 49853
	public int SourceUniqueId;

	// Token: 0x0400C2BE RID: 49854
	public int TotalDamage;

	// Token: 0x0400C2BF RID: 49855
	public Dictionary<ESkillGenre, int> RecordDamage = new Dictionary<ESkillGenre, int>();
}
