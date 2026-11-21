using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AEA RID: 19178
	public class IRecordCombatOperationCaptureCheckpointT
	{
		// Token: 0x1700866D RID: 34413
		// (get) Token: 0x0601CE50 RID: 118352 RVA: 0x004111F6 File Offset: 0x0040F3F6
		// (set) Token: 0x0601CE51 RID: 118353 RVA: 0x004111FE File Offset: 0x0040F3FE
		public EGmCommand Type { get; set; }

		// Token: 0x0601CE52 RID: 118354 RVA: 0x00411207 File Offset: 0x0040F407
		public IRecordCombatOperationCaptureCheckpointT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
