using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA2 RID: 2978
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailureConditionArbitraryState : ITargetGearGroupFailureCondition
	{
		// Token: 0x06004461 RID: 17505 RVA: 0x000ADB85 File Offset: 0x000ABD85
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

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06004462 RID: 17506 RVA: 0x000ADBA4 File Offset: 0x000ABDA4
		public override ETargetGearGroupFailureCondition Type
		{
			get
			{
				return (ETargetGearGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x000ADBB1 File Offset: 0x000ABDB1
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x0400269B RID: 9883
		private IFailureConditionArbitraryState Instance;
	}
}
