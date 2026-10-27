using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D4 RID: 21716
	public class ILevelAiPointOffsetConfigT
	{
		// Token: 0x1700A002 RID: 40962
		// (get) Token: 0x06023CA0 RID: 146592 RVA: 0x004F27EF File Offset: 0x004F09EF
		// (set) Token: 0x06023CA1 RID: 146593 RVA: 0x004F27F7 File Offset: 0x004F09F7
		public float Radius { get; set; }

		// Token: 0x1700A003 RID: 40963
		// (get) Token: 0x06023CA2 RID: 146594 RVA: 0x004F2800 File Offset: 0x004F0A00
		// (set) Token: 0x06023CA3 RID: 146595 RVA: 0x004F2808 File Offset: 0x004F0A08
		public IVectorInfoT Normal { get; set; }

		// Token: 0x06023CA4 RID: 146596 RVA: 0x004F2811 File Offset: 0x004F0A11
		public ILevelAiPointOffsetConfigT()
		{
			this.Radius = 0f;
			this.Normal = null;
		}
	}
}
