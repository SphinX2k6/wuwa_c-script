using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C0A RID: 23562
	public class BossPilingNewBuffInfo : IBossPilingNewBuffInfo
	{
		// Token: 0x17008DA5 RID: 36261
		// (get) Token: 0x0603B8AD RID: 243885 RVA: 0x00E32254 File Offset: 0x00E30454
		// (set) Token: 0x0603B8AE RID: 243886 RVA: 0x00E3225C File Offset: 0x00E3045C
		public int BuffId { get; set; }

		// Token: 0x17008DA6 RID: 36262
		// (get) Token: 0x0603B8AF RID: 243887 RVA: 0x00E32265 File Offset: 0x00E30465
		// (set) Token: 0x0603B8B0 RID: 243888 RVA: 0x00E3226D File Offset: 0x00E3046D
		public int OldValue { get; set; }

		// Token: 0x17008DA7 RID: 36263
		// (get) Token: 0x0603B8B1 RID: 243889 RVA: 0x00E32276 File Offset: 0x00E30476
		// (set) Token: 0x0603B8B2 RID: 243890 RVA: 0x00E3227E File Offset: 0x00E3047E
		public int NewValue { get; set; }

		// Token: 0x17008DA8 RID: 36264
		// (get) Token: 0x0603B8B3 RID: 243891 RVA: 0x00E32287 File Offset: 0x00E30487
		// (set) Token: 0x0603B8B4 RID: 243892 RVA: 0x00E3228F File Offset: 0x00E3048F
		public bool NeedAccelerate { get; set; }
	}
}
