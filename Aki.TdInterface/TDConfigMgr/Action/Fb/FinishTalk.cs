using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002863 RID: 10339
	public class FinishTalk : ActionParams
	{
		// Token: 0x0600E69F RID: 59039 RVA: 0x00222334 File Offset: 0x00220534
		public static FinishTalk Create(IFinishTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007F0B RID: 32523
		private IFinishTalk Instance;
	}
}
