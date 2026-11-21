using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200244F RID: 9295
	public class SetTimeLockState : ActionParams
	{
		// Token: 0x0600CA59 RID: 51801 RVA: 0x001CE260 File Offset: 0x001CC460
		private SetTimeLockState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetTimeLockState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetTimeLockState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetTimeLockState_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA5A RID: 51802 RVA: 0x001CE298 File Offset: 0x001CC498
		public static SetTimeLockState Create([Nullable(2)] SetTimeLockState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetTimeLockState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA5B RID: 51803 RVA: 0x001CE2AB File Offset: 0x001CC4AB
		public static SetTimeLockState CreateFromSetValue([Nullable(2)] SetTimeLockState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetTimeLockState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA5C RID: 51804 RVA: 0x001CE2BE File Offset: 0x001CC4BE
		public SetTimeLockState_SetValue ToSetValue()
		{
			return new SetTimeLockState_SetValue
			{
				LockState = this.LockState
			};
		}

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x0600CA5D RID: 51805 RVA: 0x001CE2D1 File Offset: 0x001CC4D1
		// (set) Token: 0x0600CA5E RID: 51806 RVA: 0x001CE2FC File Offset: 0x001CC4FC
		public virtual ELockState LockState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockState;
				}
				if (this.PocoInterface == null)
				{
					return ELockState.Lock;
				}
				return this.PocoInterface.LockState;
			}
			set
			{
				this.GetOrCreatePoco().LockState = value;
			}
		}

		// Token: 0x04007803 RID: 30723
		[Nullable(2)]
		protected new SetTimeLockState FbInstance;

		// Token: 0x04007804 RID: 30724
		[Nullable(2)]
		protected SetTimeLockState_SetValue PocoInterface;
	}
}
