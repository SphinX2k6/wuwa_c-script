using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AEC RID: 2796
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityGroupFailureArbitraryState : IEntityGroupFailureCondition
	{
		// Token: 0x0600405E RID: 16478 RVA: 0x000A451E File Offset: 0x000A271E
		public static IEntityGroupFailureArbitraryState Create(IEntityGroupFailureArbitraryState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityGroupFailureArbitraryState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x0600405F RID: 16479 RVA: 0x000A453D File Offset: 0x000A273D
		public override EEntityGroupFailureCondition Type
		{
			get
			{
				return (EEntityGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x000A454A File Offset: 0x000A274A
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040023DB RID: 9179
		private IEntityGroupFailureArbitraryState Instance;
	}
}
