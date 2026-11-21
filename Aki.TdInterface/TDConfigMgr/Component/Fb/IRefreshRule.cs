using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7E RID: 2942
	public class IRefreshRule
	{
		// Token: 0x06004354 RID: 17236 RVA: 0x000AAE76 File Offset: 0x000A9076
		public static IRefreshRule Create(IRefreshRule? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshRule
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x000AAE95 File Offset: 0x000A9095
		public virtual ERefreshRule Type
		{
			get
			{
				return (ERefreshRule)this.Instance.Type;
			}
		}

		// Token: 0x04002533 RID: 9523
		private IRefreshRule Instance;
	}
}
