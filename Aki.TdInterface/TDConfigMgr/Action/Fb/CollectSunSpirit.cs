using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DA8 RID: 11688
	public class CollectSunSpirit : ActionParams
	{
		// Token: 0x0600FEAC RID: 65196 RVA: 0x0024BA31 File Offset: 0x00249C31
		public static CollectSunSpirit Create(ICollectSunSpirit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CollectSunSpirit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008B06 RID: 35590
		private ICollectSunSpirit Instance;
	}
}
