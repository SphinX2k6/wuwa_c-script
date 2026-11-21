using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1C RID: 3356
	public class IPatrolCycleOncely : ICycleModeType
	{
		// Token: 0x06004C73 RID: 19571 RVA: 0x000BF5EC File Offset: 0x000BD7EC
		public static IPatrolCycleOncely Create(IPatrolCycleOncely? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolCycleOncely
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06004C74 RID: 19572 RVA: 0x000BF60B File Offset: 0x000BD80B
		public override EPatrolCycleMode Type
		{
			get
			{
				return (EPatrolCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x04002B51 RID: 11089
		private IPatrolCycleOncely Instance;
	}
}
