using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200223C RID: 8764
	public class TetrisGameComplete : ActionParams
	{
		// Token: 0x0600C058 RID: 49240 RVA: 0x001B9E75 File Offset: 0x001B8075
		[NullableContext(1)]
		public static TetrisGameComplete Create([Nullable(2)] TetrisGameComplete instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TetrisGameComplete
			{
				FbInstance = instance
			};
		}

		// Token: 0x040072B2 RID: 29362
		[Nullable(2)]
		protected new TetrisGameComplete FbInstance;
	}
}
