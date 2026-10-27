using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8C RID: 27532
	public class IMpcEffectParamBaseT
	{
		// Token: 0x1700CCAB RID: 52395
		// (get) Token: 0x060305AF RID: 198063 RVA: 0x00691AC6 File Offset: 0x0068FCC6
		// (set) Token: 0x060305B0 RID: 198064 RVA: 0x00691ACE File Offset: 0x0068FCCE
		public EMpcEffectParamType Type { get; set; }

		// Token: 0x060305B1 RID: 198065 RVA: 0x00691AD7 File Offset: 0x0068FCD7
		public IMpcEffectParamBaseT()
		{
			this.Type = EMpcEffectParamType.PostProcessVolumeCenterPosition;
		}
	}
}
