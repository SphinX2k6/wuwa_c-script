using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CA1 RID: 11425
	public class SlashAndTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600FABE RID: 64190 RVA: 0x00245971 File Offset: 0x00243B71
		public static SlashAndTowerGotoNextFloor Create(ISlashAndTowerGotoNextFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlashAndTowerGotoNextFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040088F9 RID: 35065
		private ISlashAndTowerGotoNextFloor Instance;
	}
}
