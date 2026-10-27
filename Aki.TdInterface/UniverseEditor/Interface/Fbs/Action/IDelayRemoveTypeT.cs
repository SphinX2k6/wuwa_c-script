using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006562 RID: 25954
	public class IDelayRemoveTypeT
	{
		// Token: 0x1700C0E1 RID: 49377
		// (get) Token: 0x0602D07E RID: 184446 RVA: 0x0062E016 File Offset: 0x0062C216
		// (set) Token: 0x0602D07F RID: 184447 RVA: 0x0062E01E File Offset: 0x0062C21E
		public EDelayRemoveType Type { get; set; }

		// Token: 0x0602D080 RID: 184448 RVA: 0x0062E027 File Offset: 0x0062C227
		public IDelayRemoveTypeT()
		{
			this.Type = EDelayRemoveType.DelayRemoveAfterSkillFinish;
		}
	}
}
