using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CD RID: 26573
	public class IAdjustPlayerCameraT
	{
		// Token: 0x1700C308 RID: 49928
		// (get) Token: 0x0602D559 RID: 185689 RVA: 0x00635105 File Offset: 0x00633305
		// (set) Token: 0x0602D55A RID: 185690 RVA: 0x0063510D File Offset: 0x0063330D
		public TAdjustPlayerCameraOptionUnion Option { get; set; }

		// Token: 0x0602D55B RID: 185691 RVA: 0x00635116 File Offset: 0x00633316
		public IAdjustPlayerCameraT()
		{
			this.Option = null;
		}
	}
}
