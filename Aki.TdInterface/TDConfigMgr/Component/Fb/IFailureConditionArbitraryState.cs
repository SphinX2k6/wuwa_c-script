using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C70 RID: 3184
	public class IFailureConditionArbitraryState : ITargetGearGroupFailureCondition
	{
		// Token: 0x060048BA RID: 18618 RVA: 0x000B7C49 File Offset: 0x000B5E49
		public static IFailureConditionArbitraryState Create(IFailureConditionArbitraryState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailureConditionArbitraryState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x060048BB RID: 18619 RVA: 0x000B7C68 File Offset: 0x000B5E68
		public override ETargetGearGroupFailureCondition Type
		{
			get
			{
				return (ETargetGearGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x060048BC RID: 18620 RVA: 0x000B7C75 File Offset: 0x000B5E75
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040028E3 RID: 10467
		private IFailureConditionArbitraryState Instance;
	}
}
