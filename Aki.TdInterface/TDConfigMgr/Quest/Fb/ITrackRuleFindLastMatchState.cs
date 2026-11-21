using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001460 RID: 5216
	public class ITrackRuleFindLastMatchState : ITrackRuleTypeBase
	{
		// Token: 0x060076B3 RID: 30387 RVA: 0x0011D32C File Offset: 0x0011B52C
		public static ITrackRuleFindLastMatchState Create(ITrackRuleFindLastMatchState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackRuleFindLastMatchState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x060076B4 RID: 30388 RVA: 0x0011D34B File Offset: 0x0011B54B
		public override ETrackRuleType Type
		{
			get
			{
				return (ETrackRuleType)this.Instance.Type;
			}
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x060076B5 RID: 30389 RVA: 0x0011D358 File Offset: 0x0011B558
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04004422 RID: 17442
		private ITrackRuleFindLastMatchState Instance;
	}
}
