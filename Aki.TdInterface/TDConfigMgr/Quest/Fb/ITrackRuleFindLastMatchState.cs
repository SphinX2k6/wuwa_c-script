using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001310 RID: 4880
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackRuleFindLastMatchState : ITrackRuleTypeBase
	{
		// Token: 0x06007013 RID: 28691 RVA: 0x0010EDC0 File Offset: 0x0010CFC0
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

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x06007014 RID: 28692 RVA: 0x0010EDDF File Offset: 0x0010CFDF
		public override ETrackRuleType Type
		{
			get
			{
				return (ETrackRuleType)this.Instance.Type;
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x06007015 RID: 28693 RVA: 0x0010EDEC File Offset: 0x0010CFEC
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040040A6 RID: 16550
		private ITrackRuleFindLastMatchState Instance;
	}
}
