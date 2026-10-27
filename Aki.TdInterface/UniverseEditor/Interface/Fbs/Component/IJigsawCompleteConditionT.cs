using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A1 RID: 21665
	public class IJigsawCompleteConditionT
	{
		// Token: 0x17009F87 RID: 40839
		// (get) Token: 0x06023A94 RID: 146068 RVA: 0x004EE116 File Offset: 0x004EC316
		// (set) Token: 0x06023A95 RID: 146069 RVA: 0x004EE11E File Offset: 0x004EC31E
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x06023A96 RID: 146070 RVA: 0x004EE127 File Offset: 0x004EC327
		public IJigsawCompleteConditionT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
		}
	}
}
