using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E02 RID: 7682
[NullableContext(2)]
[Nullable(0)]
public class AttributeInfo : IAttributeInfo
{
	// Token: 0x17001CE9 RID: 7401
	// (get) Token: 0x06012FA1 RID: 77729 RVA: 0x0058E187 File Offset: 0x0058C387
	// (set) Token: 0x06012FA2 RID: 77730 RVA: 0x0058E18F File Offset: 0x0058C38F
	public string Name { get; set; }

	// Token: 0x17001CEA RID: 7402
	// (get) Token: 0x06012FA3 RID: 77731 RVA: 0x0058E198 File Offset: 0x0058C398
	// (set) Token: 0x06012FA4 RID: 77732 RVA: 0x0058E1A0 File Offset: 0x0058C3A0
	public string IconPath { get; set; }

	// Token: 0x17001CEB RID: 7403
	// (get) Token: 0x06012FA5 RID: 77733 RVA: 0x0058E1A9 File Offset: 0x0058C3A9
	// (set) Token: 0x06012FA6 RID: 77734 RVA: 0x0058E1B1 File Offset: 0x0058C3B1
	public bool? ShowArrow { get; set; }

	// Token: 0x17001CEC RID: 7404
	// (get) Token: 0x06012FA7 RID: 77735 RVA: 0x0058E1BA File Offset: 0x0058C3BA
	// (set) Token: 0x06012FA8 RID: 77736 RVA: 0x0058E1C2 File Offset: 0x0058C3C2
	public string PreText { get; set; }

	// Token: 0x17001CED RID: 7405
	// (get) Token: 0x06012FA9 RID: 77737 RVA: 0x0058E1CB File Offset: 0x0058C3CB
	// (set) Token: 0x06012FAA RID: 77738 RVA: 0x0058E1D3 File Offset: 0x0058C3D3
	public string CurText { get; set; }

	// Token: 0x17001CEE RID: 7406
	// (get) Token: 0x06012FAB RID: 77739 RVA: 0x0058E1DC File Offset: 0x0058C3DC
	// (set) Token: 0x06012FAC RID: 77740 RVA: 0x0058E1E4 File Offset: 0x0058C3E4
	public bool? IsNormalBg { get; set; }

	// Token: 0x17001CEF RID: 7407
	// (get) Token: 0x06012FAD RID: 77741 RVA: 0x0058E1ED File Offset: 0x0058C3ED
	// (set) Token: 0x06012FAE RID: 77742 RVA: 0x0058E1F5 File Offset: 0x0058C3F5
	public bool? InnerShowBg { get; set; }

	// Token: 0x17001CF0 RID: 7408
	// (get) Token: 0x06012FAF RID: 77743 RVA: 0x0058E1FE File Offset: 0x0058C3FE
	// (set) Token: 0x06012FB0 RID: 77744 RVA: 0x0058E206 File Offset: 0x0058C406
	public bool? IsLine { get; set; }
}
