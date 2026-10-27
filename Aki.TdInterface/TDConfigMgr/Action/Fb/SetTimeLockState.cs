using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289B RID: 10395
	public class SetTimeLockState : ActionParams
	{
		// Token: 0x0600E627 RID: 58919 RVA: 0x0021D2A5 File Offset: 0x0021B4A5
		[NullableContext(1)]
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

		// Token: 0x170046B3 RID: 18099
		// (get) Token: 0x0600E628 RID: 58920 RVA: 0x0021D2C4 File Offset: 0x0021B4C4
		public virtual ELockState LockState
		{
			get
			{
				return (ELockState)this.Instance.LockState;
			}
		}

		// Token: 0x04007F3F RID: 32575
		private ISetTimeLockState Instance;
	}
}
