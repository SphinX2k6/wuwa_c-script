using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013F5 RID: 5109
	public class IRoleTowerConditionStepTeamUpgrade : IRoleTowerConditionStepBase
	{
		// Token: 0x0600744A RID: 29770 RVA: 0x001164FE File Offset: 0x001146FE
		[NullableContext(1)]
		public static IRoleTowerConditionStepTeamUpgrade Create(IRoleTowerConditionStepTeamUpgrade? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepTeamUpgrade
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x0600744B RID: 29771 RVA: 0x0011651D File Offset: 0x0011471D
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004349 RID: 17225
		private IRoleTowerConditionStepTeamUpgrade Instance;
	}
}
