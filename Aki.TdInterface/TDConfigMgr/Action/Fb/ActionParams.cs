using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002777 RID: 10103
	public class ActionParams
	{
		// Token: 0x0600DFE6 RID: 57318 RVA: 0x0020F629 File Offset: 0x0020D829
		public static ActionParams Create(IActionParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActionParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040079CB RID: 31179
		private IActionParams Instance;
	}
}
