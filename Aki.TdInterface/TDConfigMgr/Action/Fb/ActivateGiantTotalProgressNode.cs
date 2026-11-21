using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D25 RID: 11557
	public class ActivateGiantTotalProgressNode : ActionParams
	{
		// Token: 0x0600FCA5 RID: 64677 RVA: 0x00248746 File Offset: 0x00246946
		public static ActivateGiantTotalProgressNode Create(IActivateGiantTotalProgressNode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActivateGiantTotalProgressNode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040089F5 RID: 35317
		private IActivateGiantTotalProgressNode Instance;
	}
}
