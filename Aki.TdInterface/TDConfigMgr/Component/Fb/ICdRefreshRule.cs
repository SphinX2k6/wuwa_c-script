using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AB5 RID: 2741
	public class ICdRefreshRule : IRefreshRule
	{
		// Token: 0x06003F2D RID: 16173 RVA: 0x000A18B6 File Offset: 0x0009FAB6
		[NullableContext(1)]
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

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x000A18D5 File Offset: 0x0009FAD5
		public override ERefreshRule Type
		{
			get
			{
				return (ERefreshRule)this.Instance.Type;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06003F2F RID: 16175 RVA: 0x000A18E2 File Offset: 0x0009FAE2
		public virtual int Cd
		{
			get
			{
				return this.Instance.Cd;
			}
		}

		// Token: 0x04002318 RID: 8984
		private ICdRefreshRule Instance;
	}
}
