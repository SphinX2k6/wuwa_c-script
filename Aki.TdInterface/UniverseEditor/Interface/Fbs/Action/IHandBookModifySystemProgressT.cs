using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F63 RID: 28515
	public class IHandBookModifySystemProgressT
	{
		// Token: 0x1700D0EF RID: 53487
		// (get) Token: 0x060315BC RID: 202172 RVA: 0x006B1D21 File Offset: 0x006AFF21
		// (set) Token: 0x060315BD RID: 202173 RVA: 0x006B1D29 File Offset: 0x006AFF29
		public THandBookProgressOptionUnion Operation { get; set; }

		// Token: 0x060315BE RID: 202174 RVA: 0x006B1D32 File Offset: 0x006AFF32
		public IHandBookModifySystemProgressT()
		{
			this.Operation = null;
		}
	}
}
