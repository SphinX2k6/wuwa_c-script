using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020017F6 RID: 6134
[NullableContext(2)]
[Nullable(0)]
public class CommonItemSelectViewOpenViewData<T> : UiPopViewData
{
	// Token: 0x04005153 RID: 20819
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<T> ItemDataBaseList;

	// Token: 0x04005154 RID: 20820
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ISelectedData> SelectedDataList;

	// Token: 0x04005155 RID: 20821
	public SelectableComponentData SelectableComponentData;

	// Token: 0x04005156 RID: 20822
	public CommonIntensifyPropExpData ExpData;

	// Token: 0x04005157 RID: 20823
	public ESelectableComponentType SelectableComponentType;

	// Token: 0x04005158 RID: 20824
	public EFilterSortGroupId UseWayId;

	// Token: 0x04005159 RID: 20825
	public bool InitSortToggleState;
}
