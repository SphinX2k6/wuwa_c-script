using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AFE RID: 11006
	public class SheriffUnlockProgress : ActionParams
	{
		// Token: 0x0600F112 RID: 61714 RVA: 0x0022F9C1 File Offset: 0x0022DBC1
		[NullableContext(1)]
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

		// Token: 0x17004CD8 RID: 19672
		// (get) Token: 0x0600F113 RID: 61715 RVA: 0x0022F9E0 File Offset: 0x0022DBE0
		public virtual int ProgressId
		{
			get
			{
				return this.Instance.ProgressId;
			}
		}

		// Token: 0x0400849C RID: 33948
		private ISheriffUnlockProgress Instance;
	}
}
