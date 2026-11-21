using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007116 RID: 28950
	public class ILiveParamConfigT
	{
		// Token: 0x1700D40B RID: 54283
		// (get) Token: 0x060324B1 RID: 206001 RVA: 0x006CCFC6 File Offset: 0x006CB1C6
		// (set) Token: 0x060324B2 RID: 206002 RVA: 0x006CCFCE File Offset: 0x006CB1CE
		public ELiveParamType Type { get; set; }

		// Token: 0x060324B3 RID: 206003 RVA: 0x006CCFD7 File Offset: 0x006CB1D7
		public ILiveParamConfigT()
		{
			this.Type = ELiveParamType.Heat;
		}
	}
}
