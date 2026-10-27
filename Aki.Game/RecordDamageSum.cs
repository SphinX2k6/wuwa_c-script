using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002EC6 RID: 11974
[NullableContext(1)]
[Nullable(0)]
public class RecordDamageSum
{
	// Token: 0x060198E0 RID: 104672 RVA: 0x0069C404 File Offset: 0x0069A604
	public string[] ToCsvForRole()
	{
		List<string> list = new List<string>();
		list.Add(this.ConfigId.ToString());
		list.Add(this.Name);
		list.Add(this.DamageSourceConfigId.ToString());
		list.Add(this.SourceName);
		list.Add(this.SourceUniqueId.ToString());
		list.Add(this.TotalDamage.ToString());
		for (int i = 0; i < 25; i++)
		{
			list.Add((this.RecordDamage.ContainsKey((ESkillGenre)i) ? this.RecordDamage[(ESkillGenre)i] : 0).ToString());
		}
		return list.ToArray();
	}

	// Token: 0x060198E1 RID: 104673 RVA: 0x0069C4B4 File Offset: 0x0069A6B4
	public string[] ToCsvForMonster()
	{
		List<string> list = new List<string>();
		list.Add(this.ConfigId.ToString());
		list.Add(this.Name);
		list.Add(this.UniqueId.ToString());
		list.Add(this.DamageSourceConfigId.ToString());
		list.Add(this.SourceName);
		list.Add(this.TotalDamage.ToString());
		for (int i = 0; i < 25; i++)
		{
			list.Add((this.RecordDamage.ContainsKey((ESkillGenre)i) ? this.RecordDamage[(ESkillGenre)i] : 0).ToString());
		}
		return list.ToArray();
	}

	// Token: 0x0400BF1D RID: 48925
	public int ConfigId;

	// Token: 0x0400BF1E RID: 48926
	public string Name = "";

	// Token: 0x0400BF1F RID: 48927
	public int UniqueId;

	// Token: 0x0400BF20 RID: 48928
	public int DamageSourceConfigId;

	// Token: 0x0400BF21 RID: 48929
	public string SourceName = "";

	// Token: 0x0400BF22 RID: 48930
	public int SourceUniqueId;

	// Token: 0x0400BF23 RID: 48931
	public int TotalDamage;

	// Token: 0x0400BF24 RID: 48932
	public Dictionary<ESkillGenre, int> RecordDamage = new Dictionary<ESkillGenre, int>();
}
