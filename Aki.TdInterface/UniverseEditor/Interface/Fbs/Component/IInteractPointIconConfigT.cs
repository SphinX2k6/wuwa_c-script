using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059EE RID: 23022
	public class IInteractPointIconConfigT
	{
		// Token: 0x1700A74F RID: 42831
		// (get) Token: 0x0602597D RID: 153981 RVA: 0x00527C2F File Offset: 0x00525E2F
		// (set) Token: 0x0602597E RID: 153982 RVA: 0x00527C37 File Offset: 0x00525E37
		public float MaxShowDistance { get; set; }

		// Token: 0x1700A750 RID: 42832
		// (get) Token: 0x0602597F RID: 153983 RVA: 0x00527C40 File Offset: 0x00525E40
		// (set) Token: 0x06025980 RID: 153984 RVA: 0x00527C48 File Offset: 0x00525E48
		public IVectorInfoT Offset { get; set; }

		// Token: 0x06025981 RID: 153985 RVA: 0x00527C51 File Offset: 0x00525E51
		public IInteractPointIconConfigT()
		{
			this.MaxShowDistance = 0f;
			this.Offset = null;
		}
	}
}
