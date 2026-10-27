using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B3 RID: 10163
	public class RestoreTrialCharacter : ActionParams
	{
		// Token: 0x0600E226 RID: 57894 RVA: 0x002169A2 File Offset: 0x00214BA2
		[NullableContext(1)]
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

		// Token: 0x04007D6F RID: 32111
		private IRestoreTrialCharacter Instance;
	}
}
