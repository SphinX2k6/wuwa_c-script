using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005892 RID: 22674
	public class IRotatorComponent2T
	{
		// Token: 0x1700A9B1 RID: 43441
		// (get) Token: 0x060263A0 RID: 156576 RVA: 0x00545045 File Offset: 0x00543245
		// (set) Token: 0x060263A1 RID: 156577 RVA: 0x0054504D File Offset: 0x0054324D
		public bool Disabled { get; set; }

		// Token: 0x1700A9B2 RID: 43442
		// (get) Token: 0x060263A2 RID: 156578 RVA: 0x00545056 File Offset: 0x00543256
		// (set) Token: 0x060263A3 RID: 156579 RVA: 0x0054505E File Offset: 0x0054325E
		public List<IStateRotationConfigT> Config { get; set; }

		// Token: 0x1700A9B3 RID: 43443
		// (get) Token: 0x060263A4 RID: 156580 RVA: 0x00545067 File Offset: 0x00543267
		// (set) Token: 0x060263A5 RID: 156581 RVA: 0x0054506F File Offset: 0x0054326F
		public byte NullMask { get; set; }

		// Token: 0x060263A6 RID: 156582 RVA: 0x00545078 File Offset: 0x00543278
		public IRotatorComponent2T()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
