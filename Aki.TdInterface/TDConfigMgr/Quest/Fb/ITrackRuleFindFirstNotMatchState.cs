using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001461 RID: 5217
	public class ITrackRuleFindFirstNotMatchState : ITrackRuleTypeBase
	{
		// Token: 0x060076B7 RID: 30391 RVA: 0x0011D36D File Offset: 0x0011B56D
		public static ITrackRuleFindFirstNotMatchState Create(ITrackRuleFindFirstNotMatchState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackRuleFindFirstNotMatchState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x060076B8 RID: 30392 RVA: 0x0011D38C File Offset: 0x0011B58C
		public override ETrackRuleType Type
		{
			get
			{
				return (ETrackRuleType)this.Instance.Type;
			}
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x060076B9 RID: 30393 RVA: 0x0011D399 File Offset: 0x0011B599
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04004423 RID: 17443
		private ITrackRuleFindFirstNotMatchState Instance;
	}
}
