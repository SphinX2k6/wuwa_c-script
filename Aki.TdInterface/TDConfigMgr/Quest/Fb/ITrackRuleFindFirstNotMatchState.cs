using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001311 RID: 4881
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackRuleFindFirstNotMatchState : ITrackRuleTypeBase
	{
		// Token: 0x06007017 RID: 28695 RVA: 0x0010EE01 File Offset: 0x0010D001
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

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x06007018 RID: 28696 RVA: 0x0010EE20 File Offset: 0x0010D020
		public override ETrackRuleType Type
		{
			get
			{
				return (ETrackRuleType)this.Instance.Type;
			}
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x06007019 RID: 28697 RVA: 0x0010EE2D File Offset: 0x0010D02D
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040040A7 RID: 16551
		private ITrackRuleFindFirstNotMatchState Instance;
	}
}
