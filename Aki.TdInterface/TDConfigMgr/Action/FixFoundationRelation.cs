using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A6 RID: 6310
	public class FixFoundationRelation : ActionParams
	{
		// Token: 0x0600846D RID: 33901 RVA: 0x0013C350 File Offset: 0x0013A550
		public static FixFoundationRelation Create([Nullable(2)] FixFoundationRelation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixFoundationRelation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400544B RID: 21579
		[Nullable(2)]
		protected new FixFoundationRelation FbInstance;
	}
}
