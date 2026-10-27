using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200222F RID: 8751
	public class TakePlotPhoto : ActionParams
	{
		// Token: 0x0600C00C RID: 49164 RVA: 0x001B94DF File Offset: 0x001B76DF
		[NullableContext(1)]
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

		// Token: 0x04007287 RID: 29319
		[Nullable(2)]
		protected new TakePlotPhoto FbInstance;
	}
}
