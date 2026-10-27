using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A6 RID: 29094
	public class ISpringArmSoftZoneConfigT
	{
		// Token: 0x1700D813 RID: 55315
		// (get) Token: 0x0603395E RID: 211294 RVA: 0x006F275A File Offset: 0x006F095A
		// (set) Token: 0x0603395F RID: 211295 RVA: 0x006F2762 File Offset: 0x006F0962
		public ISingleAxisSpringArmSoftZoneConfigT LeftRightConfig { get; set; }

		// Token: 0x1700D814 RID: 55316
		// (get) Token: 0x06033960 RID: 211296 RVA: 0x006F276B File Offset: 0x006F096B
		// (set) Token: 0x06033961 RID: 211297 RVA: 0x006F2773 File Offset: 0x006F0973
		public ISingleAxisSpringArmSoftZoneConfigT ForwardBackConfig { get; set; }

		// Token: 0x1700D815 RID: 55317
		// (get) Token: 0x06033962 RID: 211298 RVA: 0x006F277C File Offset: 0x006F097C
		// (set) Token: 0x06033963 RID: 211299 RVA: 0x006F2784 File Offset: 0x006F0984
		public ISingleAxisSpringArmSoftZoneConfigT UpDownConfig { get; set; }

		// Token: 0x06033964 RID: 211300 RVA: 0x006F278D File Offset: 0x006F098D
		public ISpringArmSoftZoneConfigT()
		{
			this.LeftRightConfig = null;
			this.ForwardBackConfig = null;
			this.UpDownConfig = null;
		}
	}
}
