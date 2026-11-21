using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002989 RID: 10633
	public class RogueGotoNextFloor : ActionParams
	{
		// Token: 0x0600EBD7 RID: 60375 RVA: 0x0022BC02 File Offset: 0x00229E02
		public static RogueGotoNextFloor Create(IRogueGotoNextFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RogueGotoNextFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040081E1 RID: 33249
		private IRogueGotoNextFloor Instance;
	}
}
