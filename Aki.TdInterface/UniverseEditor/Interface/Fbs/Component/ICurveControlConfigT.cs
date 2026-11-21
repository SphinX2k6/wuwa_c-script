using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AE RID: 21934
	public class ICurveControlConfigT
	{
		// Token: 0x17009D11 RID: 40209
		// (get) Token: 0x06022E51 RID: 142929 RVA: 0x004CE26A File Offset: 0x004CC46A
		// (set) Token: 0x06022E52 RID: 142930 RVA: 0x004CE272 File Offset: 0x004CC472
		public ECurveControlType Type { get; set; }

		// Token: 0x06022E53 RID: 142931 RVA: 0x004CE27B File Offset: 0x004CC47B
		public ICurveControlConfigT()
		{
			this.Type = ECurveControlType.ChargeSlash;
		}
	}
}
