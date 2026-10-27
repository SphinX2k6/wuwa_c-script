using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200530A RID: 21258
	public class IGraph3dEdgeBaseT
	{
		// Token: 0x17009C19 RID: 39961
		// (get) Token: 0x06022BA4 RID: 142244 RVA: 0x004CFEE2 File Offset: 0x004CE0E2
		// (set) Token: 0x06022BA5 RID: 142245 RVA: 0x004CFEEA File Offset: 0x004CE0EA
		public int Id { get; set; }

		// Token: 0x17009C1A RID: 39962
		// (get) Token: 0x06022BA6 RID: 142246 RVA: 0x004CFEF3 File Offset: 0x004CE0F3
		// (set) Token: 0x06022BA7 RID: 142247 RVA: 0x004CFEFB File Offset: 0x004CE0FB
		public int From { get; set; }

		// Token: 0x17009C1B RID: 39963
		// (get) Token: 0x06022BA8 RID: 142248 RVA: 0x004CFF04 File Offset: 0x004CE104
		// (set) Token: 0x06022BA9 RID: 142249 RVA: 0x004CFF0C File Offset: 0x004CE10C
		public int To { get; set; }

		// Token: 0x06022BAA RID: 142250 RVA: 0x004CFF15 File Offset: 0x004CE115
		public IGraph3dEdgeBaseT()
		{
			this.Id = 0;
			this.From = 0;
			this.To = 0;
		}
	}
}
