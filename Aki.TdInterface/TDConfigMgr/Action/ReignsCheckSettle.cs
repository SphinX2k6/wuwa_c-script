using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200213F RID: 8511
	public class ReignsCheckSettle : ActionParams
	{
		// Token: 0x0600BB66 RID: 47974 RVA: 0x001B0BAE File Offset: 0x001AEDAE
		[NullableContext(1)]
		public static ReignsCheckSettle Create([Nullable(2)] ReignsCheckSettle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsCheckSettle
			{
				FbInstance = instance
			};
		}

		// Token: 0x04007012 RID: 28690
		[Nullable(2)]
		protected new ReignsCheckSettle FbInstance;
	}
}
