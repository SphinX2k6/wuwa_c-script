using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A1 RID: 6305
	public class FinishTalk : ActionParams
	{
		// Token: 0x06008451 RID: 33873 RVA: 0x0013C03D File Offset: 0x0013A23D
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

		// Token: 0x0400543F RID: 21567
		[Nullable(2)]
		protected new FinishTalk FbInstance;
	}
}
