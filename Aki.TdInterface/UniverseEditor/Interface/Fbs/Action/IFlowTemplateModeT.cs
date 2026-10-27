using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006829 RID: 26665
	public class IFlowTemplateModeT
	{
		// Token: 0x1700C615 RID: 50709
		// (get) Token: 0x0602E7CF RID: 190415 RVA: 0x006582EC File Offset: 0x006564EC
		// (set) Token: 0x0602E7D0 RID: 190416 RVA: 0x006582F4 File Offset: 0x006564F4
		public int Id { get; set; }

		// Token: 0x1700C616 RID: 50710
		// (get) Token: 0x0602E7D1 RID: 190417 RVA: 0x006582FD File Offset: 0x006564FD
		// (set) Token: 0x0602E7D2 RID: 190418 RVA: 0x00658305 File Offset: 0x00656505
		public int CameraId { get; set; }

		// Token: 0x0602E7D3 RID: 190419 RVA: 0x0065830E File Offset: 0x0065650E
		public IFlowTemplateModeT()
		{
			this.Id = 0;
			this.CameraId = 0;
		}
	}
}
