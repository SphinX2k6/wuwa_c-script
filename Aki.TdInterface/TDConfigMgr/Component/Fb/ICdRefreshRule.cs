using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7F RID: 2943
	public class ICdRefreshRule : IRefreshRule
	{
		// Token: 0x06004357 RID: 17239 RVA: 0x000AAEAA File Offset: 0x000A90AA
		public static ICdRefreshRule Create(ICdRefreshRule? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICdRefreshRule
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x000AAEC9 File Offset: 0x000A90C9
		public override ERefreshRule Type
		{
			get
			{
				return (ERefreshRule)this.Instance.Type;
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x000AAED6 File Offset: 0x000A90D6
		public virtual int Cd
		{
			get
			{
				return this.Instance.Cd;
			}
		}

		// Token: 0x04002534 RID: 9524
		private ICdRefreshRule Instance;
	}
}
