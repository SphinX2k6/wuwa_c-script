using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249A RID: 9370
	public class TakePlotPhoto : ActionParams
	{
		// Token: 0x0600CBCA RID: 52170 RVA: 0x001D0BAB File Offset: 0x001CEDAB
		public static TakePlotPhoto Create([Nullable(2)] TakePlotPhoto instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TakePlotPhoto
			{
				FbInstance = instance
			};
		}

		// Token: 0x040078D1 RID: 30929
		[Nullable(2)]
		protected new TakePlotPhoto FbInstance;
	}
}
