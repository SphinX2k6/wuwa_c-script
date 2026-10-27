using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001724 RID: 5924
	public class FinishTalk : ActionParams
	{
		// Token: 0x06007D73 RID: 32115 RVA: 0x0012CF91 File Offset: 0x0012B191
		[NullableContext(1)]
		public static FinishTalk Create([Nullable(2)] FinishTalk instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishTalk
			{
				FbInstance = instance
			};
		}

		// Token: 0x04005010 RID: 20496
		[Nullable(2)]
		protected new FinishTalk FbInstance;
	}
}
