using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

// Token: 0x02002030 RID: 8240
[NullableContext(2)]
internal interface ICommonKeySettingViewOpenData
{
	// Token: 0x170013B5 RID: 5045
	// (get) Token: 0x060102C8 RID: 66248
	// (set) Token: 0x060102C9 RID: 66249
	EKeySettingExclusiveType ViewType { get; set; }

	// Token: 0x170013B6 RID: 5046
	// (get) Token: 0x060102CA RID: 66250
	// (set) Token: 0x060102CB RID: 66251
	string BgSourceId { get; set; }
}
