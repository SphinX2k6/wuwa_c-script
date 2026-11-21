using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E04 RID: 7684
[NullableContext(2)]
[Nullable(0)]
public class LevelUpSuccessEffectData : ILevelUpSuccessEffectData
{
	// Token: 0x17001CF6 RID: 7414
	// (get) Token: 0x06012FBC RID: 77756 RVA: 0x0058E217 File Offset: 0x0058C417
	// (set) Token: 0x06012FBD RID: 77757 RVA: 0x0058E21F File Offset: 0x0058C41F
	public string Title { get; set; }

	// Token: 0x17001CF7 RID: 7415
	// (get) Token: 0x06012FBE RID: 77758 RVA: 0x0058E228 File Offset: 0x0058C428
	// (set) Token: 0x06012FBF RID: 77759 RVA: 0x0058E230 File Offset: 0x0058C430
	public string AudioId { get; set; }

	// Token: 0x17001CF8 RID: 7416
	// (get) Token: 0x06012FC0 RID: 77760 RVA: 0x0058E239 File Offset: 0x0058C439
	// (set) Token: 0x06012FC1 RID: 77761 RVA: 0x0058E241 File Offset: 0x0058C441
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

	// Token: 0x17001CF9 RID: 7417
	// (get) Token: 0x06012FC2 RID: 77762 RVA: 0x0058E24A File Offset: 0x0058C44A
	// (set) Token: 0x06012FC3 RID: 77763 RVA: 0x0058E252 File Offset: 0x0058C452
	public string ClickText { get; set; }

	// Token: 0x17001CFA RID: 7418
	// (get) Token: 0x06012FC4 RID: 77764 RVA: 0x0058E25B File Offset: 0x0058C45B
	// (set) Token: 0x06012FC5 RID: 77765 RVA: 0x0058E263 File Offset: 0x0058C463
	public Action ClickFunction { get; set; }
}
