using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200655F RID: 25951
	public class IDelayRemoveAfterSkillFinishT
	{
		// Token: 0x1700C0DE RID: 49374
		// (get) Token: 0x0602D06C RID: 184428 RVA: 0x0062DE9E File Offset: 0x0062C09E
		// (set) Token: 0x0602D06D RID: 184429 RVA: 0x0062DEA6 File Offset: 0x0062C0A6
		public EDelayRemoveType Type { get; set; }

		// Token: 0x0602D06E RID: 184430 RVA: 0x0062DEAF File Offset: 0x0062C0AF
		public IDelayRemoveAfterSkillFinishT()
		{
			this.Type = EDelayRemoveType.DelayRemoveAfterSkillFinish;
		}
	}
}
