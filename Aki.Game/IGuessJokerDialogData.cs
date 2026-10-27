using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200102D RID: 4141
[NullableContext(2)]
public interface IGuessJokerDialogData
{
	// Token: 0x1700088D RID: 2189
	// (get) Token: 0x06006A4E RID: 27214
	Func<EGuessJokerPlayerType, UUIItem> GetDialogItem { get; }

	// Token: 0x1700088E RID: 2190
	// (get) Token: 0x06006A4F RID: 27215
	Func<EGuessJokerPlayerType, UUIText> GetDialogText { get; }

	// Token: 0x1700088F RID: 2191
	// (get) Token: 0x06006A50 RID: 27216
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

	// Token: 0x17000890 RID: 2192
	// (get) Token: 0x06006A51 RID: 27217
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

	// Token: 0x17000891 RID: 2193
	// (get) Token: 0x06006A52 RID: 27218
	Action<EGuessJokerPlayerType> OnCancelDialogStartAnim { get; }
}
