using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005446 RID: 21574
	public class IBeamReflectionConfigT
	{
		// Token: 0x17009948 RID: 39240
		// (get) Token: 0x06021D94 RID: 138644 RVA: 0x004AAA0D File Offset: 0x004A8C0D
		// (set) Token: 0x06021D95 RID: 138645 RVA: 0x004AAA15 File Offset: 0x004A8C15
		public IVectorInfoT NormalVector { get; set; }

		// Token: 0x06021D96 RID: 138646 RVA: 0x004AAA1E File Offset: 0x004A8C1E
		public IBeamReflectionConfigT()
		{
			this.NormalVector = null;
		}
	}
}
