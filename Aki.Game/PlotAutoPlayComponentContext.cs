using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using UnrealEngine;

// Token: 0x020008E4 RID: 2276
[NullableContext(1)]
[Nullable(0)]
public class PlotAutoPlayComponentContext : IPlotAutoPlayComponentContext
{
	// Token: 0x17000CE2 RID: 3298
	// (get) Token: 0x0600656C RID: 25964 RVA: 0x001FBCC4 File Offset: 0x001F9EC4
	// (set) Token: 0x0600656D RID: 25965 RVA: 0x001FBCCC File Offset: 0x001F9ECC
	public UUIExtendToggle Toggle { get; set; }

	// Token: 0x17000CE3 RID: 3299
	// (get) Token: 0x0600656E RID: 25966 RVA: 0x001FBCD5 File Offset: 0x001F9ED5
	// (set) Token: 0x0600656F RID: 25967 RVA: 0x001FBCDD File Offset: 0x001F9EDD
	public float WaitTime { get; set; }

	// Token: 0x17000CE4 RID: 3300
	// (get) Token: 0x06006570 RID: 25968 RVA: 0x001FBCE6 File Offset: 0x001F9EE6
	// (set) Token: 0x06006571 RID: 25969 RVA: 0x001FBCEE File Offset: 0x001F9EEE
	[Nullable(2)]
	public string AutoInSeqName { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000CE5 RID: 3301
	// (get) Token: 0x06006572 RID: 25970 RVA: 0x001FBCF7 File Offset: 0x001F9EF7
	// (set) Token: 0x06006573 RID: 25971 RVA: 0x001FBCFF File Offset: 0x001F9EFF
	[Nullable(2)]
	public string AutoOutSeqName { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000CE6 RID: 3302
	// (get) Token: 0x06006574 RID: 25972 RVA: 0x001FBD08 File Offset: 0x001F9F08
	// (set) Token: 0x06006575 RID: 25973 RVA: 0x001FBD10 File Offset: 0x001F9F10
	public Func<bool> CheckTalkFinishedDelegate { get; set; }

	// Token: 0x17000CE7 RID: 3303
	// (get) Token: 0x06006576 RID: 25974 RVA: 0x001FBD19 File Offset: 0x001F9F19
	// (set) Token: 0x06006577 RID: 25975 RVA: 0x001FBD21 File Offset: 0x001F9F21
	public Action ContinueToNextTalkDelegate { get; set; }
}
