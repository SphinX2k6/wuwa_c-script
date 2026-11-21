using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200152F RID: 5423
	public class ITrapDefenseConditionStepLoadAndRestoreMap : ITrapDefenseConditionStepBase
	{
		// Token: 0x06007AA7 RID: 31399 RVA: 0x001246A0 File Offset: 0x001228A0
		public static ITrapDefenseConditionStepLoadAndRestoreMap Create(ITrapDefenseConditionStepLoadAndRestoreMap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepLoadAndRestoreMap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x06007AA8 RID: 31400 RVA: 0x001246BF File Offset: 0x001228BF
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046A7 RID: 18087
		private ITrapDefenseConditionStepLoadAndRestoreMap Instance;
	}
}
