using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002D08 RID: 11528
public class LevelUpConditionData
{
	// Token: 0x060183D2 RID: 99282 RVA: 0x0062B68E File Offset: 0x0062988E
	public bool CheckAllCondition()
	{
		return this.HasHighQuality && this.HasBeStrength && this.HasResonance;
	}

	// Token: 0x060183D3 RID: 99283 RVA: 0x0062B6A8 File Offset: 0x006298A8
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

	// Token: 0x0400B417 RID: 46103
	public bool HasHighQuality;

	// Token: 0x0400B418 RID: 46104
	public bool HasBeStrength;

	// Token: 0x0400B419 RID: 46105
	public bool HasResonance;
}
