using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C04 RID: 3076
[NullableContext(2)]
[Nullable(0)]
internal class CalabashAttributeData
{
	// Token: 0x04004F03 RID: 20227
	public ECalabashAttributeDataType Type = ECalabashAttributeDataType.Default;

	// Token: 0x04004F04 RID: 20228
	public string Name;

	// Token: 0x04004F05 RID: 20229
	public TableTextArgNew Value;

	// Token: 0x04004F06 RID: 20230
	public bool IsUp;

	// Token: 0x04004F07 RID: 20231
	public bool IsCost;

	// Token: 0x04004F08 RID: 20232
	public int CostCount;

	// Token: 0x04004F09 RID: 20233
	public bool CurrentSelect;

	// Token: 0x04004F0A RID: 20234
	public int CurrentSelectLevel;

	// Token: 0x04004F0B RID: 20235
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<CalabashAttributeData> ClickCallBack;

	// Token: 0x04004F0C RID: 20236
	public bool IsToggleRaycast;
}
