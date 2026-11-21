using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277B RID: 10107
	public class FinishCondition : ActionParams
	{
		// Token: 0x0600DFF3 RID: 57331 RVA: 0x0020F757 File Offset: 0x0020D957
		public static FinishCondition Create(IFinishCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040079D1 RID: 31185
		private IFinishCondition Instance;
	}
}
