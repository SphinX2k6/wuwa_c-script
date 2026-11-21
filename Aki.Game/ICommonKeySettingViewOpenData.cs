using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

// Token: 0x02001503 RID: 5379
[NullableContext(2)]
internal interface ICommonKeySettingViewOpenData
{
	// Token: 0x170013E2 RID: 5090
	// (get) Token: 0x0600D730 RID: 55088
	// (set) Token: 0x0600D731 RID: 55089
	EKeySettingExclusiveType ViewType { get; set; }

	// Token: 0x170013E3 RID: 5091
	// (get) Token: 0x0600D732 RID: 55090
	// (set) Token: 0x0600D733 RID: 55091
	string BgSourceId { get; set; }
}
