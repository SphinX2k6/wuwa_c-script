using System;
using System.Runtime.CompilerServices;

// Token: 0x0200259A RID: 9626
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoConditionData
{
	// Token: 0x060137E7 RID: 79847 RVA: 0x004DE8DB File Offset: 0x004DCADB
	public FightPhotoConditionData(string text, EFightPhotoConditionType conditionType)
	{
		this.Text = text;
		this.ConditionType = conditionType;
	}

	// Token: 0x04009320 RID: 37664
	public string Text;

	// Token: 0x04009321 RID: 37665
	public EFightPhotoConditionType ConditionType;
}
