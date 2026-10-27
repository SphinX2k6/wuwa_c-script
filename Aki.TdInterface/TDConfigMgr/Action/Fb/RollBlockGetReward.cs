using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACB RID: 10955
	public class RollBlockGetReward : ActionParams
	{
		// Token: 0x0600F053 RID: 61523 RVA: 0x0022E638 File Offset: 0x0022C838
		[NullableContext(1)]
		public static RollBlockGetReward Create(IRollBlockGetReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockGetReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008431 RID: 33841
		private IRollBlockGetReward Instance;
	}
}
