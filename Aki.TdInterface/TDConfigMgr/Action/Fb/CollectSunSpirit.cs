using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB4 RID: 10932
	public class CollectSunSpirit : ActionParams
	{
		// Token: 0x0600EFF6 RID: 61430 RVA: 0x0022DD25 File Offset: 0x0022BF25
		[NullableContext(1)]
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

		// Token: 0x04008402 RID: 33794
		private ICollectSunSpirit Instance;
	}
}
