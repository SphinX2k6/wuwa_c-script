using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4D RID: 28237
	public class IRemoveFlowInteractOptionT
	{
		// Token: 0x1700D260 RID: 53856
		// (get) Token: 0x06031E60 RID: 204384 RVA: 0x006C0835 File Offset: 0x006BEA35
		// (set) Token: 0x06031E61 RID: 204385 RVA: 0x006C083D File Offset: 0x006BEA3D
		public IFlowIndexT Flow { get; set; }

		// Token: 0x1700D261 RID: 53857
		// (get) Token: 0x06031E62 RID: 204386 RVA: 0x006C0846 File Offset: 0x006BEA46
		// (set) Token: 0x06031E63 RID: 204387 RVA: 0x006C084E File Offset: 0x006BEA4E
		public int EntityId { get; set; }

		// Token: 0x1700D262 RID: 53858
		// (get) Token: 0x06031E64 RID: 204388 RVA: 0x006C0857 File Offset: 0x006BEA57
		// (set) Token: 0x06031E65 RID: 204389 RVA: 0x006C085F File Offset: 0x006BEA5F
		public string InteractToken { get; set; }

		// Token: 0x06031E66 RID: 204390 RVA: 0x006C0868 File Offset: 0x006BEA68
		public IRemoveFlowInteractOptionT()
		{
			this.Flow = null;
			this.EntityId = 0;
			this.InteractToken = null;
		}
	}
}
