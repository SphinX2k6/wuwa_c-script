using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B3 RID: 10675
	public class MowingTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600EC25 RID: 60453 RVA: 0x00227FC6 File Offset: 0x002261C6
		[NullableContext(1)]
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

		// Token: 0x04008207 RID: 33287
		private IMowingTowerGotoNextFloor Instance;
	}
}
