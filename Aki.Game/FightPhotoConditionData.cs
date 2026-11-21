using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A85 RID: 6789
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoConditionData
{
	// Token: 0x06010CC9 RID: 68809 RVA: 0x004ED3FF File Offset: 0x004EB5FF
	public FightPhotoConditionData(string text, EFightPhotoConditionType conditionType)
	{
		this.Text = text;
		this.ConditionType = conditionType;
	}

	// Token: 0x04009478 RID: 38008
	public string Text;

	// Token: 0x04009479 RID: 38009
	public EFightPhotoConditionType ConditionType;
}
