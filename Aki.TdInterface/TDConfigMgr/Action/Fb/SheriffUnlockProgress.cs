using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DF2 RID: 11762
	public class SheriffUnlockProgress : ActionParams
	{
		// Token: 0x0600FFC8 RID: 65480 RVA: 0x0024D6CD File Offset: 0x0024B8CD
		public static SheriffUnlockProgress Create(ISheriffUnlockProgress? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockProgress
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005092 RID: 20626
		// (get) Token: 0x0600FFC9 RID: 65481 RVA: 0x0024D6EC File Offset: 0x0024B8EC
		public virtual int ProgressId
		{
			get
			{
				return this.Instance.ProgressId;
			}
		}

		// Token: 0x04008BA0 RID: 35744
		private ISheriffUnlockProgress Instance;
	}
}
