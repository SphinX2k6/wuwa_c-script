using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD6 RID: 3030
	public class IAutoConfig
	{
		// Token: 0x060045A8 RID: 17832 RVA: 0x000B0584 File Offset: 0x000AE784
		[NullableContext(1)]
		public static IAutoConfig Create(IAutoConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAutoConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x000B05A3 File Offset: 0x000AE7A3
		public virtual bool IsCircle
		{
			get
			{
				return this.Instance.IsCircle;
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x060045AA RID: 17834 RVA: 0x000B05B0 File Offset: 0x000AE7B0
		public virtual int Interval
		{
			get
			{
				return this.Instance.Interval;
			}
		}

		// Token: 0x040027AF RID: 10159
		private IAutoConfig Instance;
	}
}
