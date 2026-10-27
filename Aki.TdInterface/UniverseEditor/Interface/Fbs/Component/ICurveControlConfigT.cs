using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200504C RID: 20556
	public class ICurveControlConfigT
	{
		// Token: 0x1700952B RID: 38187
		// (get) Token: 0x06020F17 RID: 134935 RVA: 0x004945B6 File Offset: 0x004927B6
		// (set) Token: 0x06020F18 RID: 134936 RVA: 0x004945BE File Offset: 0x004927BE
		public ECurveControlType Type { get; set; }

		// Token: 0x06020F19 RID: 134937 RVA: 0x004945C7 File Offset: 0x004927C7
		public ICurveControlConfigT()
		{
			this.Type = ECurveControlType.ChargeSlash;
		}
	}
}
