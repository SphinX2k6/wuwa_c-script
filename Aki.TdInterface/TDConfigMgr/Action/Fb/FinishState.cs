using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002866 RID: 10342
	public class FinishState : ActionParams
	{
		// Token: 0x0600E6B4 RID: 59060 RVA: 0x0022260E File Offset: 0x0022080E
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

		// Token: 0x04007F12 RID: 32530
		private IFinishState Instance;
	}
}
