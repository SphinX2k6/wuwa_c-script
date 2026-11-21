using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D2 RID: 29394
	public class IMpcEffectParamBaseT
	{
		// Token: 0x1700D790 RID: 55184
		// (get) Token: 0x06033407 RID: 209927 RVA: 0x006EA0E6 File Offset: 0x006E82E6
		// (set) Token: 0x06033408 RID: 209928 RVA: 0x006EA0EE File Offset: 0x006E82EE
		public EMpcEffectParamType Type { get; set; }

		// Token: 0x06033409 RID: 209929 RVA: 0x006EA0F7 File Offset: 0x006E82F7
		public IMpcEffectParamBaseT()
		{
			this.Type = EMpcEffectParamType.PostProcessVolumeCenterPosition;
		}
	}
}
