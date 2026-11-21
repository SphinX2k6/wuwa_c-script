using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F6 RID: 1270
	public class IItemChangeAdsorbateState
	{
		// Token: 0x0600196A RID: 6506 RVA: 0x0004B922 File Offset: 0x00049B22
		public static IItemChangeAdsorbateState Create([Nullable(2)] IItemChangeAdsorbateState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemChangeAdsorbateState
			{
				FbInstance = instance
			};
		}

		// Token: 0x040012E4 RID: 4836
		[Nullable(2)]
		protected IItemChangeAdsorbateState FbInstance;
	}
}
