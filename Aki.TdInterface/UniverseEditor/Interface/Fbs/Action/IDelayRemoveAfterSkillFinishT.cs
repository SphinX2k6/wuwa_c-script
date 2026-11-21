using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD0 RID: 27600
	public class IDelayRemoveAfterSkillFinishT
	{
		// Token: 0x1700CA79 RID: 51833
		// (get) Token: 0x0602F828 RID: 194600 RVA: 0x0067A662 File Offset: 0x00678862
		// (set) Token: 0x0602F829 RID: 194601 RVA: 0x0067A66A File Offset: 0x0067886A
		public EDelayRemoveType Type { get; set; }

		// Token: 0x0602F82A RID: 194602 RVA: 0x0067A673 File Offset: 0x00678873
		public IDelayRemoveAfterSkillFinishT()
		{
			this.Type = EDelayRemoveType.DelayRemoveAfterSkillFinish;
		}
	}
}
