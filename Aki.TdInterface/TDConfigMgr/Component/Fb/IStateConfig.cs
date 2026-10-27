using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AD3 RID: 2771
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateConfig
	{
		// Token: 0x06003FD5 RID: 16341 RVA: 0x000A3352 File Offset: 0x000A1552
		public static IStateConfig Create(IStateConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06003FD6 RID: 16342 RVA: 0x000A3371 File Offset: 0x000A1571
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x000A337E File Offset: 0x000A157E
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x0400238A RID: 9098
		private IStateConfig Instance;
	}
}
