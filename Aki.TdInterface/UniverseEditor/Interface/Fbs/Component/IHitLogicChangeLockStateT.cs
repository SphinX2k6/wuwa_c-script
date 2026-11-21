using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591C RID: 22812
	public class IHitLogicChangeLockStateT
	{
		// Token: 0x1700A575 RID: 42357
		// (get) Token: 0x0602516A RID: 151914 RVA: 0x0051723E File Offset: 0x0051543E
		// (set) Token: 0x0602516B RID: 151915 RVA: 0x00517246 File Offset: 0x00515446
		public EHitLogicType Type { get; set; }

		// Token: 0x0602516C RID: 151916 RVA: 0x0051724F File Offset: 0x0051544F
		public IHitLogicChangeLockStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
		}
	}
}
