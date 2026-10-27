using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B7 RID: 9655
	public class FinishState : ActionParams
	{
		// Token: 0x0600D93A RID: 55610 RVA: 0x0020693A File Offset: 0x00204B3A
		[NullableContext(1)]
		public static FinishState Create(IFinishState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040078AB RID: 30891
		private IFinishState Instance;
	}
}
