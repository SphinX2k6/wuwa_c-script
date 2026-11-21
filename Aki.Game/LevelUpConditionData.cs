using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002262 RID: 8802
public class LevelUpConditionData
{
	// Token: 0x06015C73 RID: 89203 RVA: 0x00651686 File Offset: 0x0064F886
	public bool CheckAllCondition()
	{
		return this.HasHighQuality && this.HasBeStrength && this.HasResonance;
	}

	// Token: 0x06015C74 RID: 89204 RVA: 0x006516A0 File Offset: 0x0064F8A0
	[NullableContext(1)]
	public string[] GetConditionTextList()
	{
		List<string> list = new List<string>();
		if (this.HasHighQuality)
		{
			string textById = TextConfig.Instance.GetTextById("WeaponHighQuality");
			list.Add(textById);
		}
		if (this.HasBeStrength)
		{
			string textById2 = TextConfig.Instance.GetTextById("WeaponHasLevelUp");
			list.Add(textById2);
		}
		if (this.HasResonance)
		{
			string textById3 = TextConfig.Instance.GetTextById("WeaponHasResonance");
			list.Add(textById3);
		}
		return list.ToArray();
	}

	// Token: 0x0400B78C RID: 46988
	public bool HasHighQuality;

	// Token: 0x0400B78D RID: 46989
	public bool HasBeStrength;

	// Token: 0x0400B78E RID: 46990
	public bool HasResonance;
}
