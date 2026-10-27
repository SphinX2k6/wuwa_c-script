using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A06 RID: 10758
	public class DangoAbyssCreateRewardTreasureBox : ActionParams
	{
		// Token: 0x0600ED5D RID: 60765 RVA: 0x00229C42 File Offset: 0x00227E42
		[NullableContext(1)]
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

		// Token: 0x040082AA RID: 33450
		private IDangoAbyssCreateRewardTreasureBox Instance;
	}
}
