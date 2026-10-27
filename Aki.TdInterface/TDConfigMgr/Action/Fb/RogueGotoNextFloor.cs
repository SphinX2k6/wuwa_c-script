using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026C5 RID: 9925
	public class RogueGotoNextFloor : ActionParams
	{
		// Token: 0x0600DDFB RID: 56827 RVA: 0x0020F3C2 File Offset: 0x0020D5C2
		[NullableContext(1)]
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

		// Token: 0x04007B41 RID: 31553
		private IRogueGotoNextFloor Instance;
	}
}
