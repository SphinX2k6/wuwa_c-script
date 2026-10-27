using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004416 RID: 17430
	public class ISubWpDataT
	{
		// Token: 0x17007AF7 RID: 31479
		// (get) Token: 0x06019F5A RID: 106330 RVA: 0x003B6697 File Offset: 0x003B4897
		// (set) Token: 0x06019F5B RID: 106331 RVA: 0x003B669F File Offset: 0x003B489F
		public int SubWpId { get; set; }

		// Token: 0x17007AF8 RID: 31480
		// (get) Token: 0x06019F5C RID: 106332 RVA: 0x003B66A8 File Offset: 0x003B48A8
		// (set) Token: 0x06019F5D RID: 106333 RVA: 0x003B66B0 File Offset: 0x003B48B0
		public IVectorInfoT Location { get; set; }

		// Token: 0x06019F5E RID: 106334 RVA: 0x003B66B9 File Offset: 0x003B48B9
		public ISubWpDataT()
		{
			this.SubWpId = 0;
			this.Location = null;
		}
	}
}
