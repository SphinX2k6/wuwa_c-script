using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF2 RID: 11506
	public class DangoAbyssGotoNextFloor : ActionParams
	{
		// Token: 0x0600FBF2 RID: 64498 RVA: 0x0024759F File Offset: 0x0024579F
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

		// Token: 0x0400899A RID: 35226
		private IDangoAbyssGotoNextFloor Instance;
	}
}
