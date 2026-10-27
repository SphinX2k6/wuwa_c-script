using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002A85 RID: 10885
[NullableContext(2)]
[Nullable(0)]
public class FadeEffect : IFadeEffect
{
	// Token: 0x17001E30 RID: 7728
	// (get) Token: 0x06016AA8 RID: 92840 RVA: 0x005BD97E File Offset: 0x005BBB7E
	// (set) Token: 0x06016AA9 RID: 92841 RVA: 0x005BD986 File Offset: 0x005BBB86
	public EFadeInScreenShowType? FadeColor { get; set; }

	// Token: 0x17001E31 RID: 7729
	// (get) Token: 0x06016AAA RID: 92842 RVA: 0x005BD98F File Offset: 0x005BBB8F
	// (set) Token: 0x06016AAB RID: 92843 RVA: 0x005BD997 File Offset: 0x005BBB97
	public float? FadeInTime { get; set; }

	// Token: 0x17001E32 RID: 7730
	// (get) Token: 0x06016AAC RID: 92844 RVA: 0x005BD9A0 File Offset: 0x005BBBA0
	// (set) Token: 0x06016AAD RID: 92845 RVA: 0x005BD9A8 File Offset: 0x005BBBA8
	public float? FadeOutTime { get; set; }

	// Token: 0x17001E33 RID: 7731
	// (get) Token: 0x06016AAE RID: 92846 RVA: 0x005BD9B1 File Offset: 0x005BBBB1
	// (set) Token: 0x06016AAF RID: 92847 RVA: 0x005BD9B9 File Offset: 0x005BBBB9
	public string ScreenEffect { get; set; }
}
