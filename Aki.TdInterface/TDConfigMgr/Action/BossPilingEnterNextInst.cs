using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014AD RID: 5293
	public class BossPilingEnterNextInst : ActionParams
	{
		// Token: 0x0600788A RID: 30858 RVA: 0x00121008 File Offset: 0x0011F208
		[NullableContext(1)]
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

		// Token: 0x0400460D RID: 17933
		[Nullable(2)]
		protected new BossPilingEnterNextInst FbInstance;
	}
}
