using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288D RID: 10381
	public class TakePlotPhoto : ActionParams
	{
		// Token: 0x0600E5F0 RID: 58864 RVA: 0x0021CC07 File Offset: 0x0021AE07
		[NullableContext(1)]
		public static TakePlotPhoto Create(ITakePlotPhoto? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TakePlotPhoto
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007F1F RID: 32543
		private ITakePlotPhoto Instance;
	}
}
