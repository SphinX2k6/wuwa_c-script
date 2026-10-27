using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F14 RID: 20244
	public class IBeamReflectionConfigT
	{
		// Token: 0x170091C6 RID: 37318
		// (get) Token: 0x06020024 RID: 131108 RVA: 0x00474679 File Offset: 0x00472879
		// (set) Token: 0x06020025 RID: 131109 RVA: 0x00474681 File Offset: 0x00472881
		public IVectorInfoT NormalVector { get; set; }

		// Token: 0x06020026 RID: 131110 RVA: 0x0047468A File Offset: 0x0047288A
		public IBeamReflectionConfigT()
		{
			this.NormalVector = null;
		}
	}
}
