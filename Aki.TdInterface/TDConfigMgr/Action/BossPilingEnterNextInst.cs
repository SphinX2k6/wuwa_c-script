using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001606 RID: 5638
	public class BossPilingEnterNextInst : ActionParams
	{
		// Token: 0x06007F57 RID: 32599 RVA: 0x0012FC54 File Offset: 0x0012DE54
		public static BossPilingEnterNextInst Create([Nullable(2)] BossPilingEnterNextInst instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BossPilingEnterNextInst
			{
				FbInstance = instance
			};
		}

		// Token: 0x040049A8 RID: 18856
		[Nullable(2)]
		protected new BossPilingEnterNextInst FbInstance;
	}
}
