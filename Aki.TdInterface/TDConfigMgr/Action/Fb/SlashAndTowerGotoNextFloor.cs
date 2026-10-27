using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B4 RID: 10676
	public class SlashAndTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600EC27 RID: 60455 RVA: 0x00227FED File Offset: 0x002261ED
		[NullableContext(1)]
		public static SlashAndTowerGotoNextFloor Create(ISlashAndTowerGotoNextFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlashAndTowerGotoNextFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008208 RID: 33288
		private ISlashAndTowerGotoNextFloor Instance;
	}
}
