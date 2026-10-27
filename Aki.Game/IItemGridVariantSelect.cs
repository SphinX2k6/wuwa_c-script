using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020018C2 RID: 6338
[NullableContext(2)]
public interface IItemGridVariantSelect
{
	// Token: 0x17000F60 RID: 3936
	// (get) Token: 0x0600B9D4 RID: 47572
	bool IsItemGridVariantSelect { get; }

	// Token: 0x0600B9D5 RID: 47573
	void RefreshItemShowState(bool stateState);

	// Token: 0x0600B9D6 RID: 47574
	void RefreshReduceButtonShowState(bool stateState);

	// Token: 0x0600B9D7 RID: 47575
	UUIItem GetFinishSelectItem();

	// Token: 0x0600B9D8 RID: 47576
	UUIItem GetFinishMiddleItem();

	// Token: 0x0600B9D9 RID: 47577
	UUIItem GetControlItem();

	// Token: 0x0600B9DA RID: 47578
	UUIButtonComponent GetReduceButton();

	// Token: 0x0600B9DB RID: 47579
	UUIButtonComponent GetAddButton();

	// Token: 0x0600B9DC RID: 47580
	[NullableContext(1)]
	void SetAddButtonCallBack(Action call);

	// Token: 0x0600B9DD RID: 47581
	[NullableContext(1)]
	void SetReduceClickEvent(Action call);
}
