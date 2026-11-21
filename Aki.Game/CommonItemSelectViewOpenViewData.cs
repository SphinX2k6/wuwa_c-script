using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000CAF RID: 3247
[NullableContext(2)]
[Nullable(0)]
public class CommonItemSelectViewOpenViewData<T> : UiPopViewData
{
	// Token: 0x040051FE RID: 20990
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<T> ItemDataBaseList;

	// Token: 0x040051FF RID: 20991
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ISelectedData> SelectedDataList;

	// Token: 0x04005200 RID: 20992
	public SelectableComponentData SelectableComponentData;

	// Token: 0x04005201 RID: 20993
	public CommonIntensifyPropExpData ExpData;

	// Token: 0x04005202 RID: 20994
	public ESelectableComponentType SelectableComponentType;

	// Token: 0x04005203 RID: 20995
	public EFilterSortGroupId UseWayId;

	// Token: 0x04005204 RID: 20996
	public bool InitSortToggleState;
}
