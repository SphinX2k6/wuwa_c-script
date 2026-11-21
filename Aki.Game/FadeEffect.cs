using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002001 RID: 8193
[NullableContext(2)]
[Nullable(0)]
public class FadeEffect : IFadeEffect
{
	// Token: 0x17001E88 RID: 7816
	// (get) Token: 0x060144CD RID: 83149 RVA: 0x005E9BAE File Offset: 0x005E7DAE
	// (set) Token: 0x060144CE RID: 83150 RVA: 0x005E9BB6 File Offset: 0x005E7DB6
	public EFadeInScreenShowType? FadeColor { get; set; }

	// Token: 0x17001E89 RID: 7817
	// (get) Token: 0x060144CF RID: 83151 RVA: 0x005E9BBF File Offset: 0x005E7DBF
	// (set) Token: 0x060144D0 RID: 83152 RVA: 0x005E9BC7 File Offset: 0x005E7DC7
	public float? FadeInTime { get; set; }

	// Token: 0x17001E8A RID: 7818
	// (get) Token: 0x060144D1 RID: 83153 RVA: 0x005E9BD0 File Offset: 0x005E7DD0
	// (set) Token: 0x060144D2 RID: 83154 RVA: 0x005E9BD8 File Offset: 0x005E7DD8
	public float? FadeOutTime { get; set; }

	// Token: 0x17001E8B RID: 7819
	// (get) Token: 0x060144D3 RID: 83155 RVA: 0x005E9BE1 File Offset: 0x005E7DE1
	// (set) Token: 0x060144D4 RID: 83156 RVA: 0x005E9BE9 File Offset: 0x005E7DE9
	public string ScreenEffect { get; set; }
}
