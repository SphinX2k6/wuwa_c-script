using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DBF RID: 11711
	public class RollBlockGetReward : ActionParams
	{
		// Token: 0x0600FF09 RID: 65289 RVA: 0x0024C344 File Offset: 0x0024A544
		public static RollBlockGetReward Create(IRollBlockGetReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockGetReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008B35 RID: 35637
		private IRollBlockGetReward Instance;
	}
}
