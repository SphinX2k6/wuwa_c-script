using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200155B RID: 5467
	public class DestroyAllChild : ActionParams
	{
		// Token: 0x06007B87 RID: 31623 RVA: 0x001299B8 File Offset: 0x00127BB8
		[NullableContext(1)]
		public static DestroyAllChild Create([Nullable(2)] DestroyAllChild instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyAllChild
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004724 RID: 18212
		[Nullable(2)]
		protected new DestroyAllChild FbInstance;
	}
}
