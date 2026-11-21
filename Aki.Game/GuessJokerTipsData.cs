using System;
using System.Runtime.CompilerServices;

// Token: 0x02000516 RID: 1302
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerTipsData : IGuessJokerTipsData
{
	// Token: 0x170008E6 RID: 2278
	// (get) Token: 0x06003F69 RID: 16233 RVA: 0x00163F3F File Offset: 0x0016213F
	// (set) Token: 0x06003F6A RID: 16234 RVA: 0x00163F47 File Offset: 0x00162147
	public string TextId { get; set; } = "";

	// Token: 0x170008E7 RID: 2279
	// (get) Token: 0x06003F6B RID: 16235 RVA: 0x00163F50 File Offset: 0x00162150
	// (set) Token: 0x06003F6C RID: 16236 RVA: 0x00163F58 File Offset: 0x00162158
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
