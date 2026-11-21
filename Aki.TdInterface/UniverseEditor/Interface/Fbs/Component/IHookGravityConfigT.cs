using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005946 RID: 22854
	public class IHookGravityConfigT
	{
		// Token: 0x1700A5CE RID: 42446
		// (get) Token: 0x060252EE RID: 152302 RVA: 0x0051A2AB File Offset: 0x005184AB
		// (set) Token: 0x060252EF RID: 152303 RVA: 0x0051A2B3 File Offset: 0x005184B3
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700A5CF RID: 42447
		// (get) Token: 0x060252F0 RID: 152304 RVA: 0x0051A2BC File Offset: 0x005184BC
		// (set) Token: 0x060252F1 RID: 152305 RVA: 0x0051A2C4 File Offset: 0x005184C4
		public int SafePointId { get; set; }

		// Token: 0x1700A5D0 RID: 42448
		// (get) Token: 0x060252F2 RID: 152306 RVA: 0x0051A2CD File Offset: 0x005184CD
		// (set) Token: 0x060252F3 RID: 152307 RVA: 0x0051A2D5 File Offset: 0x005184D5
		public int CameraLookAtPointId { get; set; }

		// Token: 0x1700A5D1 RID: 42449
		// (get) Token: 0x060252F4 RID: 152308 RVA: 0x0051A2DE File Offset: 0x005184DE
		// (set) Token: 0x060252F5 RID: 152309 RVA: 0x0051A2E6 File Offset: 0x005184E6
		public byte NullMask { get; set; }

		// Token: 0x060252F6 RID: 152310 RVA: 0x0051A2EF File Offset: 0x005184EF
		public IHookGravityConfigT()
		{
			this.GravityDirection = null;
			this.SafePointId = 0;
			this.CameraLookAtPointId = 0;
			this.NullMask = 0;
		}
	}
}
