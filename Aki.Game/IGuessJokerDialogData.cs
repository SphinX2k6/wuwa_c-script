using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020004E1 RID: 1249
[NullableContext(2)]
public interface IGuessJokerDialogData
{
	// Token: 0x170008AD RID: 2221
	// (get) Token: 0x06003DE3 RID: 15843
	Func<EGuessJokerPlayerType, UUIItem> GetDialogItem { get; }

	// Token: 0x170008AE RID: 2222
	// (get) Token: 0x06003DE4 RID: 15844
	Func<EGuessJokerPlayerType, UUIText> GetDialogText { get; }

	// Token: 0x170008AF RID: 2223
	// (get) Token: 0x06003DE5 RID: 15845
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	Action<EGuessJokerPlayerType, string, Action> OnDialogStart { [return: Nullable(new byte[]
	{
		2,
		1,
		1
	})] get; }

	// Token: 0x170008B0 RID: 2224
	// (get) Token: 0x06003DE6 RID: 15846
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Action<EGuessJokerPlayerType, Action> OnDialogEnd { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; }

	// Token: 0x170008B1 RID: 2225
	// (get) Token: 0x06003DE7 RID: 15847
	Action<EGuessJokerPlayerType> OnCancelDialogStartAnim { get; }
}
