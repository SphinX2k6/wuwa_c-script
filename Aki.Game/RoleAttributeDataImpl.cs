using System;
using System.Runtime.CompilerServices;

// Token: 0x020027C3 RID: 10179
[NullableContext(1)]
[Nullable(0)]
public class RoleAttributeDataImpl : IRoleAttributeData
{
	// Token: 0x17001B35 RID: 6965
	// (get) Token: 0x06014EF9 RID: 85753 RVA: 0x00550AFE File Offset: 0x0054ECFE
	// (set) Token: 0x06014EFA RID: 85754 RVA: 0x00550B06 File Offset: 0x0054ED06
	public string Name { get; set; }

	// Token: 0x17001B36 RID: 6966
	// (get) Token: 0x06014EFB RID: 85755 RVA: 0x00550B0F File Offset: 0x0054ED0F
	// (set) Token: 0x06014EFC RID: 85756 RVA: 0x00550B17 File Offset: 0x0054ED17
	public int Level { get; set; }

	// Token: 0x17001B37 RID: 6967
	// (get) Token: 0x06014EFD RID: 85757 RVA: 0x00550B20 File Offset: 0x0054ED20
	// (set) Token: 0x06014EFE RID: 85758 RVA: 0x00550B28 File Offset: 0x0054ED28
	public int BreakLevel { get; set; }

	// Token: 0x17001B38 RID: 6968
	// (get) Token: 0x06014EFF RID: 85759 RVA: 0x00550B31 File Offset: 0x0054ED31
	// (set) Token: 0x06014F00 RID: 85760 RVA: 0x00550B39 File Offset: 0x0054ED39
	public int Exp { get; set; }
}
