using System;
using System.Runtime.CompilerServices;

// Token: 0x0200174B RID: 5963
[NullableContext(2)]
[Nullable(0)]
internal class CalabashAttributeData
{
	// Token: 0x04004E5A RID: 20058
	public ECalabashAttributeDataType Type = ECalabashAttributeDataType.Default;

	// Token: 0x04004E5B RID: 20059
	public string Name;

	// Token: 0x04004E5C RID: 20060
	public TableTextArgNew Value;

	// Token: 0x04004E5D RID: 20061
	public bool IsUp;

	// Token: 0x04004E5E RID: 20062
	public bool IsCost;

	// Token: 0x04004E5F RID: 20063
	public int CostCount;

	// Token: 0x04004E60 RID: 20064
	public bool CurrentSelect;

	// Token: 0x04004E61 RID: 20065
	public int CurrentSelectLevel;

	// Token: 0x04004E62 RID: 20066
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<CalabashAttributeData> ClickCallBack;

	// Token: 0x04004E63 RID: 20067
	public bool IsToggleRaycast;
}
