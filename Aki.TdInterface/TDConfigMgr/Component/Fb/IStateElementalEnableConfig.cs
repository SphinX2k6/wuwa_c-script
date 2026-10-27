using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E24 RID: 3620
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateElementalEnableConfig
	{
		// Token: 0x060051E2 RID: 20962 RVA: 0x000C9CF0 File Offset: 0x000C7EF0
		public static IStateElementalEnableConfig Create(IStateElementalEnableConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateElementalEnableConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x060051E3 RID: 20963 RVA: 0x000C9D0F File Offset: 0x000C7F0F
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x000C9D1C File Offset: 0x000C7F1C
		public virtual bool ElementalEnable
		{
			get
			{
				return this.Instance.ElementalEnable;
			}
		}

		// Token: 0x04002F29 RID: 12073
		private IStateElementalEnableConfig Instance;
	}
}
