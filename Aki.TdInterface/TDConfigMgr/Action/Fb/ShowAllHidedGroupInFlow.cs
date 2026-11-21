using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B08 RID: 11016
	public class ShowAllHidedGroupInFlow : ActionParams
	{
		// Token: 0x0600F263 RID: 62051 RVA: 0x002368DE File Offset: 0x00234ADE
		public static ShowAllHidedGroupInFlow Create(IShowAllHidedGroupInFlow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowAllHidedGroupInFlow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008506 RID: 34054
		private IShowAllHidedGroupInFlow Instance;
	}
}
