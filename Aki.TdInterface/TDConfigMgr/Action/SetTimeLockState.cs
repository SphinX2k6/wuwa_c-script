using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E4 RID: 8676
	[NullableContext(1)]
	[Nullable(0)]
	public class SetTimeLockState : ActionParams
	{
		// Token: 0x0600BE9D RID: 48797 RVA: 0x001B6BD4 File Offset: 0x001B4DD4
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

		// Token: 0x0600BE9E RID: 48798 RVA: 0x001B6C0C File Offset: 0x001B4E0C
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

		// Token: 0x0600BE9F RID: 48799 RVA: 0x001B6C1F File Offset: 0x001B4E1F
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

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x001B6C32 File Offset: 0x001B4E32
		public SetTimeLockState_SetValue ToSetValue()
		{
			return new SetTimeLockState_SetValue
			{
				LockState = this.LockState
			};
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0600BEA1 RID: 48801 RVA: 0x001B6C45 File Offset: 0x001B4E45
		// (set) Token: 0x0600BEA2 RID: 48802 RVA: 0x001B6C70 File Offset: 0x001B4E70
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

		// Token: 0x040071BA RID: 29114
		[Nullable(2)]
		protected new SetTimeLockState FbInstance;

		// Token: 0x040071BB RID: 29115
		[Nullable(2)]
		protected SetTimeLockState_SetValue PocoInterface;
	}
}
