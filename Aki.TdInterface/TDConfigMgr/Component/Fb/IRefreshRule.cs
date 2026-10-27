using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AB4 RID: 2740
	public class IRefreshRule
	{
		// Token: 0x06003F2A RID: 16170 RVA: 0x000A1882 File Offset: 0x0009FA82
		[NullableContext(1)]
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

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06003F2B RID: 16171 RVA: 0x000A18A1 File Offset: 0x0009FAA1
		public virtual ERefreshRule Type
		{
			get
			{
				return (ERefreshRule)this.Instance.Type;
			}
		}

		// Token: 0x04002317 RID: 8983
		private IRefreshRule Instance;
	}
}
