using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005181 RID: 20865
	public class IEntityGroupFailureConditionT
	{
		// Token: 0x17009873 RID: 39027
		// (get) Token: 0x06021BD3 RID: 138195 RVA: 0x004AE7EA File Offset: 0x004AC9EA
		// (set) Token: 0x06021BD4 RID: 138196 RVA: 0x004AE7F2 File Offset: 0x004AC9F2
		public EEntityGroupFailureCondition Type { get; set; }

		// Token: 0x06021BD5 RID: 138197 RVA: 0x004AE7FB File Offset: 0x004AC9FB
		public IEntityGroupFailureConditionT()
		{
			this.Type = EEntityGroupFailureCondition.SequentialState;
		}
	}
}
