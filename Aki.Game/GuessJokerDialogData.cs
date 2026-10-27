using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200102E RID: 4142
[NullableContext(2)]
[Nullable(0)]
public class GuessJokerDialogData : IGuessJokerDialogData
{
	// Token: 0x17000892 RID: 2194
	// (get) Token: 0x06006A53 RID: 27219 RVA: 0x00155316 File Offset: 0x00153516
	// (set) Token: 0x06006A54 RID: 27220 RVA: 0x0015531E File Offset: 0x0015351E
	public Func<EGuessJokerPlayerType, UUIItem> GetDialogItem { get; set; }

	// Token: 0x17000893 RID: 2195
	// (get) Token: 0x06006A55 RID: 27221 RVA: 0x00155327 File Offset: 0x00153527
	// (set) Token: 0x06006A56 RID: 27222 RVA: 0x0015532F File Offset: 0x0015352F
	public Func<EGuessJokerPlayerType, UUIText> GetDialogText { get; set; }

	// Token: 0x17000894 RID: 2196
	// (get) Token: 0x06006A57 RID: 27223 RVA: 0x00155338 File Offset: 0x00153538
	// (set) Token: 0x06006A58 RID: 27224 RVA: 0x00155340 File Offset: 0x00153540
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

	// Token: 0x17000895 RID: 2197
	// (get) Token: 0x06006A59 RID: 27225 RVA: 0x00155349 File Offset: 0x00153549
	// (set) Token: 0x06006A5A RID: 27226 RVA: 0x00155351 File Offset: 0x00153551
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

	// Token: 0x17000896 RID: 2198
	// (get) Token: 0x06006A5B RID: 27227 RVA: 0x0015535A File Offset: 0x0015355A
	// (set) Token: 0x06006A5C RID: 27228 RVA: 0x00155362 File Offset: 0x00153562
	public Action<EGuessJokerPlayerType> OnCancelDialogStartAnim { get; set; }
}
