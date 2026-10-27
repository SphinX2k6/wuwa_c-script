using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using UnrealEngine;

// Token: 0x02001ED6 RID: 7894
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryMainButtonConfig : IHonamiStoryMainButtonConfig
{
	// Token: 0x170012F8 RID: 4856
	// (get) Token: 0x0600F2BA RID: 62138 RVA: 0x003A81E0 File Offset: 0x003A63E0
	// (set) Token: 0x0600F2BB RID: 62139 RVA: 0x003A81E8 File Offset: 0x003A63E8
	public EHonamiStoryMainButtonFunctionType Type { get; set; }

	// Token: 0x170012F9 RID: 4857
	// (get) Token: 0x0600F2BC RID: 62140 RVA: 0x003A81F1 File Offset: 0x003A63F1
	// (set) Token: 0x0600F2BD RID: 62141 RVA: 0x003A81F9 File Offset: 0x003A63F9
	public EHonamiStoryMainComponent ComponentId { get; set; }

	// Token: 0x170012FA RID: 4858
	// (get) Token: 0x0600F2BE RID: 62142 RVA: 0x003A8202 File Offset: 0x003A6402
	// (set) Token: 0x0600F2BF RID: 62143 RVA: 0x003A820A File Offset: 0x003A640A
	public EFunctionType? FunctionId { get; set; }

	// Token: 0x170012FB RID: 4859
	// (get) Token: 0x0600F2C0 RID: 62144 RVA: 0x003A8213 File Offset: 0x003A6413
	// (set) Token: 0x0600F2C1 RID: 62145 RVA: 0x003A821B File Offset: 0x003A641B
	public Func<bool> ShowRedDot { get; set; }

	// Token: 0x170012FC RID: 4860
	// (get) Token: 0x0600F2C2 RID: 62146 RVA: 0x003A8224 File Offset: 0x003A6424
	// (set) Token: 0x0600F2C3 RID: 62147 RVA: 0x003A822C File Offset: 0x003A642C
	public Action<UUIText> SetTextCallback { get; set; }

	// Token: 0x170012FD RID: 4861
	// (get) Token: 0x0600F2C4 RID: 62148 RVA: 0x003A8235 File Offset: 0x003A6435
	// (set) Token: 0x0600F2C5 RID: 62149 RVA: 0x003A823D File Offset: 0x003A643D
	public Action OnClickCallback { get; set; }

	// Token: 0x170012FE RID: 4862
	// (get) Token: 0x0600F2C6 RID: 62150 RVA: 0x003A8246 File Offset: 0x003A6446
	// (set) Token: 0x0600F2C7 RID: 62151 RVA: 0x003A824E File Offset: 0x003A644E
	public Func<bool> ShowCallback { get; set; }

	// Token: 0x170012FF RID: 4863
	// (get) Token: 0x0600F2C8 RID: 62152 RVA: 0x003A8257 File Offset: 0x003A6457
	// (set) Token: 0x0600F2C9 RID: 62153 RVA: 0x003A825F File Offset: 0x003A645F
	public string SpecialSequenceName { get; set; }

	// Token: 0x17001300 RID: 4864
	// (get) Token: 0x0600F2CA RID: 62154 RVA: 0x003A8268 File Offset: 0x003A6468
	// (set) Token: 0x0600F2CB RID: 62155 RVA: 0x003A8270 File Offset: 0x003A6470
	public string SpecialParamName { get; set; }
}
