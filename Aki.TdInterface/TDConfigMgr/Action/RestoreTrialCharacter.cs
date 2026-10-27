using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200216D RID: 8557
	public class RestoreTrialCharacter : ActionParams
	{
		// Token: 0x0600BC3A RID: 48186 RVA: 0x001B21FF File Offset: 0x001B03FF
		[NullableContext(1)]
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

		// Token: 0x04007070 RID: 28784
		[Nullable(2)]
		protected new RestoreTrialCharacter FbInstance;
	}
}
