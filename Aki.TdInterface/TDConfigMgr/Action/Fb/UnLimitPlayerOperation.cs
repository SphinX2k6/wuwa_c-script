using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9A RID: 10906
	public class UnLimitPlayerOperation : ActionParams
	{
		// Token: 0x0600F098 RID: 61592 RVA: 0x00233FA7 File Offset: 0x002321A7
		public static UnLimitPlayerOperation Create(IUnLimitPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnLimitPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400844E RID: 33870
		private IUnLimitPlayerOperation Instance;
	}
}
