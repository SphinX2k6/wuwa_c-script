using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

// Token: 0x02002031 RID: 8241
[NullableContext(2)]
[Nullable(0)]
internal class CommonKeySettingViewOpenData : ICommonKeySettingViewOpenData
{
	// Token: 0x170013B7 RID: 5047
	// (get) Token: 0x060102CC RID: 66252 RVA: 0x003F08B9 File Offset: 0x003EEAB9
	// (set) Token: 0x060102CD RID: 66253 RVA: 0x003F08C1 File Offset: 0x003EEAC1
	public EKeySettingExclusiveType ViewType { get; set; }

	// Token: 0x170013B8 RID: 5048
	// (get) Token: 0x060102CE RID: 66254 RVA: 0x003F08CA File Offset: 0x003EEACA
	// (set) Token: 0x060102CF RID: 66255 RVA: 0x003F08D2 File Offset: 0x003EEAD2
	public string BgSourceId { get; set; }
}
