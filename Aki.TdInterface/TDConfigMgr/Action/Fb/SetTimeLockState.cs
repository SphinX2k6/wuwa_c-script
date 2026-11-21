using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B70 RID: 11120
	public class SetTimeLockState : ActionParams
	{
		// Token: 0x0600F456 RID: 62550 RVA: 0x0023A225 File Offset: 0x00238425
		public static SetTimeLockState Create(ISetTimeLockState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetTimeLockState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A24 RID: 18980
		// (get) Token: 0x0600F457 RID: 62551 RVA: 0x0023A244 File Offset: 0x00238444
		public virtual ELockState LockState
		{
			get
			{
				return (ELockState)this.Instance.LockState;
			}
		}

		// Token: 0x040085FE RID: 34302
		private ISetTimeLockState Instance;
	}
}
