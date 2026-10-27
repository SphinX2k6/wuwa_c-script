using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200224F RID: 8783
	public class TraceCurrentQuest : ActionParams
	{
		// Token: 0x0600C0B0 RID: 49328 RVA: 0x001BA7EB File Offset: 0x001B89EB
		[NullableContext(1)]
		public static TraceCurrentQuest Create([Nullable(2)] TraceCurrentQuest instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TraceCurrentQuest
			{
				FbInstance = instance
			};
		}

		// Token: 0x040072DD RID: 29405
		[Nullable(2)]
		protected new TraceCurrentQuest FbInstance;
	}
}
