using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290A RID: 10506
	public class FinishDoInteract : ActionParams
	{
		// Token: 0x0600E9A8 RID: 59816 RVA: 0x00227FE0 File Offset: 0x002261E0
		public static FinishDoInteract Create(IFinishDoInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishDoInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040080CA RID: 32970
		private IFinishDoInteract Instance;
	}
}
