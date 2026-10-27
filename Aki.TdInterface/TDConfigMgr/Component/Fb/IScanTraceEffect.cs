using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A9F RID: 2719
	[NullableContext(1)]
	[Nullable(0)]
	public class IScanTraceEffect
	{
		// Token: 0x06003EA1 RID: 16033 RVA: 0x000A04E6 File Offset: 0x0009E6E6
		public static IScanTraceEffect Create(IScanTraceEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScanTraceEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x000A0505 File Offset: 0x0009E705
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06003EA3 RID: 16035 RVA: 0x000A0512 File Offset: 0x0009E712
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x040022CE RID: 8910
		private IScanTraceEffect Instance;
	}
}
