using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CA2 RID: 11426
	public class RoleTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600FAC0 RID: 64192 RVA: 0x00245998 File Offset: 0x00243B98
		public static RoleTowerGotoNextFloor Create(IRoleTowerGotoNextFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoleTowerGotoNextFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040088FA RID: 35066
		private IRoleTowerGotoNextFloor Instance;
	}
}
