using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1B RID: 3355
	public class IPatrolCycleLooply : ICycleModeType
	{
		// Token: 0x06004C6F RID: 19567 RVA: 0x000BF5AB File Offset: 0x000BD7AB
		public static IPatrolCycleLooply Create(IPatrolCycleLooply? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolCycleLooply
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06004C70 RID: 19568 RVA: 0x000BF5CA File Offset: 0x000BD7CA
		public override EPatrolCycleMode Type
		{
			get
			{
				return (EPatrolCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06004C71 RID: 19569 RVA: 0x000BF5D7 File Offset: 0x000BD7D7
		public virtual bool IsCircle
		{
			get
			{
				return this.Instance.IsCircle;
			}
		}

		// Token: 0x04002B50 RID: 11088
		private IPatrolCycleLooply Instance;
	}
}
