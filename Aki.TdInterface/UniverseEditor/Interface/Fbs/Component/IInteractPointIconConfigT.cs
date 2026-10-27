using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005468 RID: 21608
	public class IInteractPointIconConfigT
	{
		// Token: 0x17009F15 RID: 40725
		// (get) Token: 0x060238C5 RID: 145605 RVA: 0x004EABBB File Offset: 0x004E8DBB
		// (set) Token: 0x060238C6 RID: 145606 RVA: 0x004EABC3 File Offset: 0x004E8DC3
		public float MaxShowDistance { get; set; }

		// Token: 0x17009F16 RID: 40726
		// (get) Token: 0x060238C7 RID: 145607 RVA: 0x004EABCC File Offset: 0x004E8DCC
		// (set) Token: 0x060238C8 RID: 145608 RVA: 0x004EABD4 File Offset: 0x004E8DD4
		public IVectorInfoT Offset { get; set; }

		// Token: 0x060238C9 RID: 145609 RVA: 0x004EABDD File Offset: 0x004E8DDD
		public IInteractPointIconConfigT()
		{
			this.MaxShowDistance = 0f;
			this.Offset = null;
		}
	}
}
