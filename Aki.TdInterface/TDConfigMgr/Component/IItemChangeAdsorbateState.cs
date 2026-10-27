using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200049D RID: 1181
	public class IItemChangeAdsorbateState
	{
		// Token: 0x060017D0 RID: 6096 RVA: 0x00047BDA File Offset: 0x00045DDA
		[NullableContext(1)]
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

		// Token: 0x040011C2 RID: 4546
		[Nullable(2)]
		protected IItemChangeAdsorbateState FbInstance;
	}
}
