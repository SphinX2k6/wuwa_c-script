using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200166E RID: 5742
	public class CollectSunSpirit : ActionParams
	{
		// Token: 0x06008167 RID: 33127 RVA: 0x00133660 File Offset: 0x00131860
		public static CollectSunSpirit Create([Nullable(2)] CollectSunSpirit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CollectSunSpirit
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004A9C RID: 19100
		[Nullable(2)]
		protected new CollectSunSpirit FbInstance;
	}
}
