using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A05 RID: 10757
	public class DangoAbyssGotoNextFloor : ActionParams
	{
		// Token: 0x0600ED5B RID: 60763 RVA: 0x00229C1B File Offset: 0x00227E1B
		[NullableContext(1)]
		public static DangoAbyssGotoNextFloor Create(IDangoAbyssGotoNextFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DangoAbyssGotoNextFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040082A9 RID: 33449
		private IDangoAbyssGotoNextFloor Instance;
	}
}
