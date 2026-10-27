using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001729 RID: 5929
	public class FixFoundationRelation : ActionParams
	{
		// Token: 0x06007D8F RID: 32143 RVA: 0x0012D2A4 File Offset: 0x0012B4A4
		[NullableContext(1)]
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

		// Token: 0x0400501C RID: 20508
		[Nullable(2)]
		protected new FixFoundationRelation FbInstance;
	}
}
