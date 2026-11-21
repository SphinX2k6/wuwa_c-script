using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD3 RID: 27603
	public class IDelayRemoveTypeT
	{
		// Token: 0x1700CA7C RID: 51836
		// (get) Token: 0x0602F83A RID: 194618 RVA: 0x0067A7DA File Offset: 0x006789DA
		// (set) Token: 0x0602F83B RID: 194619 RVA: 0x0067A7E2 File Offset: 0x006789E2
		public EDelayRemoveType Type { get; set; }

		// Token: 0x0602F83C RID: 194620 RVA: 0x0067A7EB File Offset: 0x006789EB
		public IDelayRemoveTypeT()
		{
			this.Type = EDelayRemoveType.DelayRemoveAfterSkillFinish;
		}
	}
}
