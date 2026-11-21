using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B6B RID: 11115
	public class ActivateResetPoint : ActionParams
	{
		// Token: 0x0600F447 RID: 62535 RVA: 0x0023A092 File Offset: 0x00238292
		public static ActivateResetPoint Create(IActivateResetPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActivateResetPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040085F5 RID: 34293
		private IActivateResetPoint Instance;
	}
}
