using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A0 RID: 9120
	public class ReignsCheckSettle : ActionParams
	{
		// Token: 0x0600C6F4 RID: 50932 RVA: 0x001C7D62 File Offset: 0x001C5F62
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

		// Token: 0x04007647 RID: 30279
		[Nullable(2)]
		protected new ReignsCheckSettle FbInstance;
	}
}
