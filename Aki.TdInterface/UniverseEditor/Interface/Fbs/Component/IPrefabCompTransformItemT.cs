using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D80 RID: 23936
	public class IPrefabCompTransformItemT
	{
		// Token: 0x1700B02E RID: 45102
		// (get) Token: 0x06027DBD RID: 163261 RVA: 0x00573E0F File Offset: 0x0057200F
		// (set) Token: 0x06027DBE RID: 163262 RVA: 0x00573E17 File Offset: 0x00572017
		public bool IsAbsolute { get; set; }

		// Token: 0x1700B02F RID: 45103
		// (get) Token: 0x06027DBF RID: 163263 RVA: 0x00573E20 File Offset: 0x00572020
		// (set) Token: 0x06027DC0 RID: 163264 RVA: 0x00573E28 File Offset: 0x00572028
		public IVectorInfoT Value { get; set; }

		// Token: 0x06027DC1 RID: 163265 RVA: 0x00573E31 File Offset: 0x00572031
		public IPrefabCompTransformItemT()
		{
			this.IsAbsolute = false;
			this.Value = null;
		}
	}
}
