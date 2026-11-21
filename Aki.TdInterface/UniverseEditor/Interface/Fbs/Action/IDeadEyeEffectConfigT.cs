using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BBE RID: 27582
	public class IDeadEyeEffectConfigT
	{
		// Token: 0x1700CA62 RID: 51810
		// (get) Token: 0x0602F7B2 RID: 194482 RVA: 0x00679C2A File Offset: 0x00677E2A
		// (set) Token: 0x0602F7B3 RID: 194483 RVA: 0x00679C32 File Offset: 0x00677E32
		public string FilterEffect { get; set; }

		// Token: 0x1700CA63 RID: 51811
		// (get) Token: 0x0602F7B4 RID: 194484 RVA: 0x00679C3B File Offset: 0x00677E3B
		// (set) Token: 0x0602F7B5 RID: 194485 RVA: 0x00679C43 File Offset: 0x00677E43
		public string TargetIdleMaterialDa { get; set; }

		// Token: 0x1700CA64 RID: 51812
		// (get) Token: 0x0602F7B6 RID: 194486 RVA: 0x00679C4C File Offset: 0x00677E4C
		// (set) Token: 0x0602F7B7 RID: 194487 RVA: 0x00679C54 File Offset: 0x00677E54
		public string TargetLockedMaterialDa { get; set; }

		// Token: 0x0602F7B8 RID: 194488 RVA: 0x00679C5D File Offset: 0x00677E5D
		public IDeadEyeEffectConfigT()
		{
			this.FilterEffect = null;
			this.TargetIdleMaterialDa = null;
			this.TargetLockedMaterialDa = null;
		}
	}
}
