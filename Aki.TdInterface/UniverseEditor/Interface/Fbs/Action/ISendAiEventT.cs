using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F5E RID: 28510
	public class ISendAiEventT
	{
		// Token: 0x1700D3D2 RID: 54226
		// (get) Token: 0x060325E1 RID: 206305 RVA: 0x006CCCD2 File Offset: 0x006CAED2
		// (set) Token: 0x060325E2 RID: 206306 RVA: 0x006CCCDA File Offset: 0x006CAEDA
		public int EntityId { get; set; }

		// Token: 0x1700D3D3 RID: 54227
		// (get) Token: 0x060325E3 RID: 206307 RVA: 0x006CCCE3 File Offset: 0x006CAEE3
		// (set) Token: 0x060325E4 RID: 206308 RVA: 0x006CCCEB File Offset: 0x006CAEEB
		public EAiEventType EventType { get; set; }

		// Token: 0x1700D3D4 RID: 54228
		// (get) Token: 0x060325E5 RID: 206309 RVA: 0x006CCCF4 File Offset: 0x006CAEF4
		// (set) Token: 0x060325E6 RID: 206310 RVA: 0x006CCCFC File Offset: 0x006CAEFC
		public byte NullMask { get; set; }

		// Token: 0x060325E7 RID: 206311 RVA: 0x006CCD05 File Offset: 0x006CAF05
		public ISendAiEventT()
		{
			this.EntityId = 0;
			this.EventType = EAiEventType.CatAndDogPlayFlow;
			this.NullMask = 0;
		}
	}
}
