using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A86 RID: 10886
	public class RestoreTrialCharacter : ActionParams
	{
		// Token: 0x0600F048 RID: 61512 RVA: 0x00233776 File Offset: 0x00231976
		public static RestoreTrialCharacter Create(IRestoreTrialCharacter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestoreTrialCharacter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008426 RID: 33830
		private IRestoreTrialCharacter Instance;
	}
}
