using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B01 RID: 11009
	public class SheriffUnlockEnding : ActionParams
	{
		// Token: 0x0600F11D RID: 61725 RVA: 0x0022FA77 File Offset: 0x0022DC77
		[NullableContext(1)]
		public static SheriffUnlockEnding Create(ISheriffUnlockEnding? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockEnding
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CDD RID: 19677
		// (get) Token: 0x0600F11E RID: 61726 RVA: 0x0022FA96 File Offset: 0x0022DC96
		public virtual int EndingId
		{
			get
			{
				return this.Instance.EndingId;
			}
		}

		// Token: 0x0400849F RID: 33951
		private ISheriffUnlockEnding Instance;
	}
}
