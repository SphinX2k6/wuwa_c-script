using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A7 RID: 9383
	public class TetrisGameComplete : ActionParams
	{
		// Token: 0x0600CC16 RID: 52246 RVA: 0x001D1541 File Offset: 0x001CF741
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

		// Token: 0x040078FC RID: 30972
		[Nullable(2)]
		protected new TetrisGameComplete FbInstance;
	}
}
