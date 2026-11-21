using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CE RID: 9166
	public class RestoreTrialCharacter : ActionParams
	{
		// Token: 0x0600C7C8 RID: 51144 RVA: 0x001C93B3 File Offset: 0x001C75B3
		public static RestoreTrialCharacter Create([Nullable(2)] RestoreTrialCharacter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestoreTrialCharacter
			{
				FbInstance = instance
			};
		}

		// Token: 0x040076A5 RID: 30373
		[Nullable(2)]
		protected new RestoreTrialCharacter FbInstance;
	}
}
