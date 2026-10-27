using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004682 RID: 18050
	public class IRecordCombatOperationCaptureCheckpointT
	{
		// Token: 0x1700802C RID: 32812
		// (get) Token: 0x0601B67B RID: 112251 RVA: 0x003E4F5A File Offset: 0x003E315A
		// (set) Token: 0x0601B67C RID: 112252 RVA: 0x003E4F62 File Offset: 0x003E3162
		public EGmCommand Type { get; set; }

		// Token: 0x0601B67D RID: 112253 RVA: 0x003E4F6B File Offset: 0x003E316B
		public IRecordCombatOperationCaptureCheckpointT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
