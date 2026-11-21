using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D9 RID: 21721
	public class ICircuitConnectLayoutT
	{
		// Token: 0x17009B2F RID: 39727
		// (get) Token: 0x0602249F RID: 140447 RVA: 0x004BA1CA File Offset: 0x004B83CA
		// (set) Token: 0x060224A0 RID: 140448 RVA: 0x004BA1D2 File Offset: 0x004B83D2
		public TCircuitConnectLayoutTypeUnion ElementType { get; set; }

		// Token: 0x17009B30 RID: 39728
		// (get) Token: 0x060224A1 RID: 140449 RVA: 0x004BA1DB File Offset: 0x004B83DB
		// (set) Token: 0x060224A2 RID: 140450 RVA: 0x004BA1E3 File Offset: 0x004B83E3
		public IVectorInfoT Position { get; set; }

		// Token: 0x17009B31 RID: 39729
		// (get) Token: 0x060224A3 RID: 140451 RVA: 0x004BA1EC File Offset: 0x004B83EC
		// (set) Token: 0x060224A4 RID: 140452 RVA: 0x004BA1F4 File Offset: 0x004B83F4
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x060224A5 RID: 140453 RVA: 0x004BA1FD File Offset: 0x004B83FD
		public ICircuitConnectLayoutT()
		{
			this.ElementType = null;
			this.Position = null;
			this.Rotation = null;
		}
	}
}
