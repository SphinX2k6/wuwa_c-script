using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005307 RID: 21255
	public class IGraph3dComponentT
	{
		// Token: 0x17009C12 RID: 39954
		// (get) Token: 0x06022B8A RID: 142218 RVA: 0x004CFC39 File Offset: 0x004CDE39
		// (set) Token: 0x06022B8B RID: 142219 RVA: 0x004CFC41 File Offset: 0x004CDE41
		public bool Disabled { get; set; }

		// Token: 0x17009C13 RID: 39955
		// (get) Token: 0x06022B8C RID: 142220 RVA: 0x004CFC4A File Offset: 0x004CDE4A
		// (set) Token: 0x06022B8D RID: 142221 RVA: 0x004CFC52 File Offset: 0x004CDE52
		public IGraph3dNormalT GraphConfig { get; set; }

		// Token: 0x17009C14 RID: 39956
		// (get) Token: 0x06022B8E RID: 142222 RVA: 0x004CFC5B File Offset: 0x004CDE5B
		// (set) Token: 0x06022B8F RID: 142223 RVA: 0x004CFC63 File Offset: 0x004CDE63
		public byte NullMask { get; set; }

		// Token: 0x06022B90 RID: 142224 RVA: 0x004CFC6C File Offset: 0x004CDE6C
		public IGraph3dComponentT()
		{
			this.Disabled = false;
			this.GraphConfig = null;
			this.NullMask = 0;
		}
	}
}
