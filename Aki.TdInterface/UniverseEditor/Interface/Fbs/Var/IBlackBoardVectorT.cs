using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DFA RID: 15866
	public class IBlackBoardVectorT
	{
		// Token: 0x17006B31 RID: 27441
		// (get) Token: 0x0601550D RID: 87309 RVA: 0x00314BF5 File Offset: 0x00312DF5
		// (set) Token: 0x0601550E RID: 87310 RVA: 0x00314BFD File Offset: 0x00312DFD
		public EBlackBoardType Type { get; set; }

		// Token: 0x17006B32 RID: 27442
		// (get) Token: 0x0601550F RID: 87311 RVA: 0x00314C06 File Offset: 0x00312E06
		// (set) Token: 0x06015510 RID: 87312 RVA: 0x00314C0E File Offset: 0x00312E0E
		public string Key { get; set; }

		// Token: 0x17006B33 RID: 27443
		// (get) Token: 0x06015511 RID: 87313 RVA: 0x00314C17 File Offset: 0x00312E17
		// (set) Token: 0x06015512 RID: 87314 RVA: 0x00314C1F File Offset: 0x00312E1F
		public IVectorInfoT Vector { get; set; }

		// Token: 0x06015513 RID: 87315 RVA: 0x00314C28 File Offset: 0x00312E28
		public IBlackBoardVectorT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Vector = null;
		}
	}
}
