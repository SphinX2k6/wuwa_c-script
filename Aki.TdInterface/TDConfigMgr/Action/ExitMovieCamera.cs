using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001892 RID: 6290
	public class ExitMovieCamera : ActionParams
	{
		// Token: 0x0600840D RID: 33805 RVA: 0x0013B828 File Offset: 0x00139A28
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

		// Token: 0x0400541A RID: 21530
		[Nullable(2)]
		protected new ExitMovieCamera FbInstance;
	}
}
