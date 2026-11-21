using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CA0 RID: 11424
	public class MowingTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600FABC RID: 64188 RVA: 0x0024594A File Offset: 0x00243B4A
		public static MowingTowerGotoNextFloor Create(IMowingTowerGotoNextFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MowingTowerGotoNextFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040088F8 RID: 35064
		private IMowingTowerGotoNextFloor Instance;
	}
}
