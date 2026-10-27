using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053ED RID: 21485
	public class IImmediateStartConditionT
	{
		// Token: 0x17009E21 RID: 40481
		// (get) Token: 0x0602348B RID: 144523 RVA: 0x004E2A9A File Offset: 0x004E0C9A
		// (set) Token: 0x0602348C RID: 144524 RVA: 0x004E2AA2 File Offset: 0x004E0CA2
		public ESpawnMonsterStartCondition Type { get; set; }

		// Token: 0x0602348D RID: 144525 RVA: 0x004E2AAB File Offset: 0x004E0CAB
		public IImmediateStartConditionT()
		{
			this.Type = ESpawnMonsterStartCondition.Immediate;
		}
	}
}
