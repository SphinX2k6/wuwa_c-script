using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B9D RID: 11165
	public class ExitMovieCamera : ActionParams
	{
		// Token: 0x0600F61C RID: 63004 RVA: 0x0023DBCE File Offset: 0x0023BDCE
		public static ExitMovieCamera Create(IExitMovieCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitMovieCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040086F5 RID: 34549
		private IExitMovieCamera Instance;
	}
}
