using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B17 RID: 19223
	public class IStopCombatOperationCaptureT
	{
		// Token: 0x170086C8 RID: 34504
		// (get) Token: 0x0601CFC2 RID: 118722 RVA: 0x004135F6 File Offset: 0x004117F6
		// (set) Token: 0x0601CFC3 RID: 118723 RVA: 0x004135FE File Offset: 0x004117FE
		public EGmCommand Type { get; set; }

		// Token: 0x0601CFC4 RID: 118724 RVA: 0x00413607 File Offset: 0x00411807
		public IStopCombatOperationCaptureT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
