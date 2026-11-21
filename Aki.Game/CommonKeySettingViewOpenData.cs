using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

// Token: 0x02001504 RID: 5380
[NullableContext(2)]
[Nullable(0)]
internal class CommonKeySettingViewOpenData : ICommonKeySettingViewOpenData
{
	// Token: 0x170013E4 RID: 5092
	// (get) Token: 0x0600D734 RID: 55092 RVA: 0x003FCEB1 File Offset: 0x003FB0B1
	// (set) Token: 0x0600D735 RID: 55093 RVA: 0x003FCEB9 File Offset: 0x003FB0B9
	public EKeySettingExclusiveType ViewType { get; set; }

	// Token: 0x170013E5 RID: 5093
	// (get) Token: 0x0600D736 RID: 55094 RVA: 0x003FCEC2 File Offset: 0x003FB0C2
	// (set) Token: 0x0600D737 RID: 55095 RVA: 0x003FCECA File Offset: 0x003FB0CA
	public string BgSourceId { get; set; }
}
