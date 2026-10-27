using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF6 RID: 10998
	public class TetrisTriggerDelayFall : ActionParams
	{
		// Token: 0x0600F0F5 RID: 61685 RVA: 0x0022F6B1 File Offset: 0x0022D8B1
		[NullableContext(1)]
		public static TetrisTriggerDelayFall Create(ITetrisTriggerDelayFall? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TetrisTriggerDelayFall
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400848A RID: 33930
		private ITetrisTriggerDelayFall Instance;
	}
}
