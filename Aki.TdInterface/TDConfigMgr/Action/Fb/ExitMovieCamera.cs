using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C8 RID: 10440
	public class ExitMovieCamera : ActionParams
	{
		// Token: 0x0600E7ED RID: 59373 RVA: 0x00220C4E File Offset: 0x0021EE4E
		[NullableContext(1)]
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

		// Token: 0x04008036 RID: 32822
		private IExitMovieCamera Instance;
	}
}
