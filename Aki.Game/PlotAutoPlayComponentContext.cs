using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using UnrealEngine;

// Token: 0x02001430 RID: 5168
[NullableContext(1)]
[Nullable(0)]
public class PlotAutoPlayComponentContext : IPlotAutoPlayComponentContext
{
	// Token: 0x17000CC2 RID: 3266
	// (get) Token: 0x060091D7 RID: 37335 RVA: 0x001F3188 File Offset: 0x001F1388
	// (set) Token: 0x060091D8 RID: 37336 RVA: 0x001F3190 File Offset: 0x001F1390
	public UUIExtendToggle Toggle { get; set; }

	// Token: 0x17000CC3 RID: 3267
	// (get) Token: 0x060091D9 RID: 37337 RVA: 0x001F3199 File Offset: 0x001F1399
	// (set) Token: 0x060091DA RID: 37338 RVA: 0x001F31A1 File Offset: 0x001F13A1
	public float WaitTime { get; set; }

	// Token: 0x17000CC4 RID: 3268
	// (get) Token: 0x060091DB RID: 37339 RVA: 0x001F31AA File Offset: 0x001F13AA
	// (set) Token: 0x060091DC RID: 37340 RVA: 0x001F31B2 File Offset: 0x001F13B2
	[Nullable(2)]
	public string AutoInSeqName { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000CC5 RID: 3269
	// (get) Token: 0x060091DD RID: 37341 RVA: 0x001F31BB File Offset: 0x001F13BB
	// (set) Token: 0x060091DE RID: 37342 RVA: 0x001F31C3 File Offset: 0x001F13C3
	[Nullable(2)]
	public string AutoOutSeqName { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000CC6 RID: 3270
	// (get) Token: 0x060091DF RID: 37343 RVA: 0x001F31CC File Offset: 0x001F13CC
	// (set) Token: 0x060091E0 RID: 37344 RVA: 0x001F31D4 File Offset: 0x001F13D4
	public Func<bool> CheckTalkFinishedDelegate { get; set; }

	// Token: 0x17000CC7 RID: 3271
	// (get) Token: 0x060091E1 RID: 37345 RVA: 0x001F31DD File Offset: 0x001F13DD
	// (set) Token: 0x060091E2 RID: 37346 RVA: 0x001F31E5 File Offset: 0x001F13E5
	public Action ContinueToNextTalkDelegate { get; set; }
}
