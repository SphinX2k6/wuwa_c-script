using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B5 RID: 10677
	public class RoleTowerGotoNextFloor : ActionParams
	{
		// Token: 0x0600EC29 RID: 60457 RVA: 0x00228014 File Offset: 0x00226214
		[NullableContext(1)]
		public static RoleTowerGotoNextFloor Create(IRoleTowerGotoNextFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoleTowerGotoNextFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008209 RID: 33289
		private IRoleTowerGotoNextFloor Instance;
	}
}
