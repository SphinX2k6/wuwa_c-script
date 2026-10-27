using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001715 RID: 5909
	public class ExitMovieCamera : ActionParams
	{
		// Token: 0x06007D2F RID: 32047 RVA: 0x0012C77C File Offset: 0x0012A97C
		[NullableContext(1)]
		public static ExitMovieCamera Create([Nullable(2)] ExitMovieCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitMovieCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004FEB RID: 20459
		[Nullable(2)]
		protected new ExitMovieCamera FbInstance;
	}
}
