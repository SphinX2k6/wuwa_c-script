using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A2 RID: 29346
	public class ITalkBackgroundSpineImageT
	{
		// Token: 0x1700D9A9 RID: 55721
		// (get) Token: 0x06034119 RID: 213273 RVA: 0x006FFD4C File Offset: 0x006FDF4C
		// (set) Token: 0x0603411A RID: 213274 RVA: 0x006FFD54 File Offset: 0x006FDF54
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x1700D9AA RID: 55722
		// (get) Token: 0x0603411B RID: 213275 RVA: 0x006FFD5D File Offset: 0x006FDF5D
		// (set) Token: 0x0603411C RID: 213276 RVA: 0x006FFD65 File Offset: 0x006FDF65
		public int Id { get; set; }

		// Token: 0x1700D9AB RID: 55723
		// (get) Token: 0x0603411D RID: 213277 RVA: 0x006FFD6E File Offset: 0x006FDF6E
		// (set) Token: 0x0603411E RID: 213278 RVA: 0x006FFD76 File Offset: 0x006FDF76
		public bool IsLoop { get; set; }

		// Token: 0x1700D9AC RID: 55724
		// (get) Token: 0x0603411F RID: 213279 RVA: 0x006FFD7F File Offset: 0x006FDF7F
		// (set) Token: 0x06034120 RID: 213280 RVA: 0x006FFD87 File Offset: 0x006FDF87
		public byte NullMask { get; set; }

		// Token: 0x06034121 RID: 213281 RVA: 0x006FFD90 File Offset: 0x006FDF90
		public ITalkBackgroundSpineImageT()
		{
			this.Type = ETalkBackgroundType.Clean;
			this.Id = 0;
			this.IsLoop = false;
			this.NullMask = 0;
		}
	}
}
