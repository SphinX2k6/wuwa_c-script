using System;
using System.Runtime.CompilerServices;

// Token: 0x02001062 RID: 4194
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerTipsData : IGuessJokerTipsData
{
	// Token: 0x170008C6 RID: 2246
	// (get) Token: 0x06006BD4 RID: 27604 RVA: 0x0015B5F7 File Offset: 0x001597F7
	// (set) Token: 0x06006BD5 RID: 27605 RVA: 0x0015B5FF File Offset: 0x001597FF
	public string TextId { get; set; } = "";

	// Token: 0x170008C7 RID: 2247
	// (get) Token: 0x06006BD6 RID: 27606 RVA: 0x0015B608 File Offset: 0x00159808
	// (set) Token: 0x06006BD7 RID: 27607 RVA: 0x0015B610 File Offset: 0x00159810
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] TextParam { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
