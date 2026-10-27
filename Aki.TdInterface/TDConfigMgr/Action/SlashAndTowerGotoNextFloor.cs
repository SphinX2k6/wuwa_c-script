using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200220D RID: 8717
	public class SlashAndTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600BF64 RID: 48996 RVA: 0x001B8086 File Offset: 0x001B6286
		[NullableContext(1)]
		public static SlashAndTowerGotoNextFloor Create([Nullable(2)] SlashAndTowerGotoNextFloor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlashAndTowerGotoNextFloor
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400721D RID: 29213
		[Nullable(2)]
		protected new SlashAndTowerGotoNextFloor FbInstance;
	}
}
