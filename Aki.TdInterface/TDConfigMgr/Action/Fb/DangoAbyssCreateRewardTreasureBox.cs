using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF3 RID: 11507
	public class DangoAbyssCreateRewardTreasureBox : ActionParams
	{
		// Token: 0x0600FBF4 RID: 64500 RVA: 0x002475C6 File Offset: 0x002457C6
		public static DangoAbyssCreateRewardTreasureBox Create(IDangoAbyssCreateRewardTreasureBox? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DangoAbyssCreateRewardTreasureBox
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400899B RID: 35227
		private IDangoAbyssCreateRewardTreasureBox Instance;
	}
}
