using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D42 RID: 11586
	public class ReignsCheckSettle : ActionParams
	{
		// Token: 0x0600FD0A RID: 64778 RVA: 0x00248F2B File Offset: 0x0024712B
		public static ReignsCheckSettle Create(IReignsCheckSettle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsCheckSettle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008A24 RID: 35364
		private IReignsCheckSettle Instance;
	}
}
