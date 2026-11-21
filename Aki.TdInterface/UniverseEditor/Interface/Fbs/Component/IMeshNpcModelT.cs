using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE1 RID: 23265
	public class IMeshNpcModelT
	{
		// Token: 0x1700A9C0 RID: 43456
		// (get) Token: 0x06026354 RID: 156500 RVA: 0x0053C72B File Offset: 0x0053A92B
		// (set) Token: 0x06026355 RID: 156501 RVA: 0x0053C733 File Offset: 0x0053A933
		public ENpcModelType Type { get; set; }

		// Token: 0x1700A9C1 RID: 43457
		// (get) Token: 0x06026356 RID: 156502 RVA: 0x0053C73C File Offset: 0x0053A93C
		// (set) Token: 0x06026357 RID: 156503 RVA: 0x0053C744 File Offset: 0x0053A944
		public string Mesh { get; set; }

		// Token: 0x06026358 RID: 156504 RVA: 0x0053C74D File Offset: 0x0053A94D
		public IMeshNpcModelT()
		{
			this.Type = ENpcModelType.Mesh;
			this.Mesh = null;
		}
	}
}
