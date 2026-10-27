using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002889 RID: 10377
[NullableContext(2)]
[Nullable(0)]
public class LevelUpSuccessEffectData : ILevelUpSuccessEffectData
{
	// Token: 0x17001C9E RID: 7326
	// (get) Token: 0x060155BE RID: 87486 RVA: 0x005634BB File Offset: 0x005616BB
	// (set) Token: 0x060155BF RID: 87487 RVA: 0x005634C3 File Offset: 0x005616C3
	public string Title { get; set; }

	// Token: 0x17001C9F RID: 7327
	// (get) Token: 0x060155C0 RID: 87488 RVA: 0x005634CC File Offset: 0x005616CC
	// (set) Token: 0x060155C1 RID: 87489 RVA: 0x005634D4 File Offset: 0x005616D4
	public string AudioId { get; set; }

	// Token: 0x17001CA0 RID: 7328
	// (get) Token: 0x060155C2 RID: 87490 RVA: 0x005634DD File Offset: 0x005616DD
	// (set) Token: 0x060155C3 RID: 87491 RVA: 0x005634E5 File Offset: 0x005616E5
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<SingleText> TextList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001CA1 RID: 7329
	// (get) Token: 0x060155C4 RID: 87492 RVA: 0x005634EE File Offset: 0x005616EE
	// (set) Token: 0x060155C5 RID: 87493 RVA: 0x005634F6 File Offset: 0x005616F6
	public string ClickText { get; set; }

	// Token: 0x17001CA2 RID: 7330
	// (get) Token: 0x060155C6 RID: 87494 RVA: 0x005634FF File Offset: 0x005616FF
	// (set) Token: 0x060155C7 RID: 87495 RVA: 0x00563507 File Offset: 0x00561707
	public Action ClickFunction { get; set; }
}
