using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F20 RID: 3872
	public class IStateElementalEnableConfig
	{
		// Token: 0x06005709 RID: 22281 RVA: 0x000D55B8 File Offset: 0x000D37B8
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

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x0600570A RID: 22282 RVA: 0x000D55D7 File Offset: 0x000D37D7
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x0600570B RID: 22283 RVA: 0x000D55E4 File Offset: 0x000D37E4
		public virtual bool ElementalEnable
		{
			get
			{
				return this.Instance.ElementalEnable;
			}
		}

		// Token: 0x040031F1 RID: 12785
		private IStateElementalEnableConfig Instance;
	}
}
