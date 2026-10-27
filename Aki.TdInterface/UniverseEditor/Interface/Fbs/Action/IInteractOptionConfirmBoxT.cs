using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006997 RID: 27031
	public class IInteractOptionConfirmBoxT
	{
		// Token: 0x1700C88A RID: 51338
		// (get) Token: 0x0602F39F RID: 193439 RVA: 0x0066EE7D File Offset: 0x0066D07D
		// (set) Token: 0x0602F3A0 RID: 193440 RVA: 0x0066EE85 File Offset: 0x0066D085
		public TInteractOptionConfirmBoxOptionUnion Type { get; set; }

		// Token: 0x0602F3A1 RID: 193441 RVA: 0x0066EE8E File Offset: 0x0066D08E
		public IInteractOptionConfirmBoxT()
		{
			this.Type = null;
		}
	}
}
