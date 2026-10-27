using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF5 RID: 10997
	public class TetrisGameComplete : ActionParams
	{
		// Token: 0x0600F0F3 RID: 61683 RVA: 0x0022F68A File Offset: 0x0022D88A
		[NullableContext(1)]
		public static TetrisGameComplete Create(ITetrisGameComplete? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TetrisGameComplete
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008489 RID: 33929
		private ITetrisGameComplete Instance;
	}
}
