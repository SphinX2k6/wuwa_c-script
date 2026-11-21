using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002478 RID: 9336
	public class SlashAndTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600CB20 RID: 52000 RVA: 0x001CF712 File Offset: 0x001CD912
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

		// Token: 0x04007866 RID: 30822
		[Nullable(2)]
		protected new SlashAndTowerGotoNextFloor FbInstance;
	}
}
