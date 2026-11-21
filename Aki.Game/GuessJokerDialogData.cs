using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020004E2 RID: 1250
[NullableContext(2)]
[Nullable(0)]
public class GuessJokerDialogData : IGuessJokerDialogData
{
	// Token: 0x170008B2 RID: 2226
	// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x0015DC3E File Offset: 0x0015BE3E
	// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x0015DC46 File Offset: 0x0015BE46
	public Func<EGuessJokerPlayerType, UUIItem> GetDialogItem { get; set; }

	// Token: 0x170008B3 RID: 2227
	// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0015DC4F File Offset: 0x0015BE4F
	// (set) Token: 0x06003DEB RID: 15851 RVA: 0x0015DC57 File Offset: 0x0015BE57
	public Func<EGuessJokerPlayerType, UUIText> GetDialogText { get; set; }

	// Token: 0x170008B4 RID: 2228
	// (get) Token: 0x06003DEC RID: 15852 RVA: 0x0015DC60 File Offset: 0x0015BE60
	// (set) Token: 0x06003DED RID: 15853 RVA: 0x0015DC68 File Offset: 0x0015BE68
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<EGuessJokerPlayerType, string, Action> OnDialogStart { [return: Nullable(new byte[]
	{
		2,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1
	})] set; }

	// Token: 0x170008B5 RID: 2229
	// (get) Token: 0x06003DEE RID: 15854 RVA: 0x0015DC71 File Offset: 0x0015BE71
	// (set) Token: 0x06003DEF RID: 15855 RVA: 0x0015DC79 File Offset: 0x0015BE79
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<EGuessJokerPlayerType, Action> OnDialogEnd { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170008B6 RID: 2230
	// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x0015DC82 File Offset: 0x0015BE82
	// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x0015DC8A File Offset: 0x0015BE8A
	public Action<EGuessJokerPlayerType> OnCancelDialogStartAnim { get; set; }
}
