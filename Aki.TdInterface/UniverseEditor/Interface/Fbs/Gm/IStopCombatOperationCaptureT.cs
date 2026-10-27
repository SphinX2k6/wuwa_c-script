using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046AF RID: 18095
	public class IStopCombatOperationCaptureT
	{
		// Token: 0x17008087 RID: 32903
		// (get) Token: 0x0601B7ED RID: 112621 RVA: 0x003E735A File Offset: 0x003E555A
		// (set) Token: 0x0601B7EE RID: 112622 RVA: 0x003E7362 File Offset: 0x003E5562
		public EGmCommand Type { get; set; }

		// Token: 0x0601B7EF RID: 112623 RVA: 0x003E736B File Offset: 0x003E556B
		public IStopCombatOperationCaptureT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
