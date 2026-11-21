using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C4A RID: 19530
	public class IInstEntityDataT
	{
		// Token: 0x17008A8E RID: 35470
		// (get) Token: 0x0601DF3B RID: 122683 RVA: 0x004331AC File Offset: 0x004313AC
		// (set) Token: 0x0601DF3C RID: 122684 RVA: 0x004331B4 File Offset: 0x004313B4
		public int InstId { get; set; }

		// Token: 0x17008A8F RID: 35471
		// (get) Token: 0x0601DF3D RID: 122685 RVA: 0x004331BD File Offset: 0x004313BD
		// (set) Token: 0x0601DF3E RID: 122686 RVA: 0x004331C5 File Offset: 0x004313C5
		public int EntityConfigId { get; set; }

		// Token: 0x0601DF3F RID: 122687 RVA: 0x004331CE File Offset: 0x004313CE
		public IInstEntityDataT()
		{
			this.InstId = 0;
			this.EntityConfigId = 0;
		}
	}
}
