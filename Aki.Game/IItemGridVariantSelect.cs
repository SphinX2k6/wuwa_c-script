using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000D7B RID: 3451
[NullableContext(2)]
public interface IItemGridVariantSelect
{
	// Token: 0x17000F83 RID: 3971
	// (get) Token: 0x06008DBD RID: 36285
	bool IsItemGridVariantSelect { get; }

	// Token: 0x06008DBE RID: 36286
	void RefreshItemShowState(bool stateState);

	// Token: 0x06008DBF RID: 36287
	void RefreshReduceButtonShowState(bool stateState);

	// Token: 0x06008DC0 RID: 36288
	UUIItem GetFinishSelectItem();

	// Token: 0x06008DC1 RID: 36289
	UUIItem GetFinishMiddleItem();

	// Token: 0x06008DC2 RID: 36290
	UUIItem GetControlItem();

	// Token: 0x06008DC3 RID: 36291
	UUIButtonComponent GetReduceButton();

	// Token: 0x06008DC4 RID: 36292
	UUIButtonComponent GetAddButton();

	// Token: 0x06008DC5 RID: 36293
	[NullableContext(1)]
	void SetAddButtonCallBack(Action call);

	// Token: 0x06008DC6 RID: 36294
	[NullableContext(1)]
	void SetReduceClickEvent(Action call);
}
