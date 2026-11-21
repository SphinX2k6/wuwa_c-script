using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAF RID: 28335
	public class IFlowTemplateModeT
	{
		// Token: 0x1700CFD9 RID: 53209
		// (get) Token: 0x06031057 RID: 200791 RVA: 0x006A622C File Offset: 0x006A442C
		// (set) Token: 0x06031058 RID: 200792 RVA: 0x006A6234 File Offset: 0x006A4434
		public int Id { get; set; }

		// Token: 0x1700CFDA RID: 53210
		// (get) Token: 0x06031059 RID: 200793 RVA: 0x006A623D File Offset: 0x006A443D
		// (set) Token: 0x0603105A RID: 200794 RVA: 0x006A6245 File Offset: 0x006A4445
		public int CameraId { get; set; }

		// Token: 0x0603105B RID: 200795 RVA: 0x006A624E File Offset: 0x006A444E
		public IFlowTemplateModeT()
		{
			this.Id = 0;
			this.CameraId = 0;
		}
	}
}
