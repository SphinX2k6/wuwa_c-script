using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200152A RID: 5418
	public class ITrapDefenseConditionStepBase
	{
		// Token: 0x06007A98 RID: 31384 RVA: 0x0012459C File Offset: 0x0012279C
		public static ITrapDefenseConditionStepBase Create(ITrapDefenseConditionStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x06007A99 RID: 31385 RVA: 0x001245BB File Offset: 0x001227BB
		public virtual ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046A2 RID: 18082
		private ITrapDefenseConditionStepBase Instance;
	}
}
