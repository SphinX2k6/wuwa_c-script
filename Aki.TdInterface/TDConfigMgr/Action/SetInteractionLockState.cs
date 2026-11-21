using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002428 RID: 9256
	public class SetInteractionLockState : ActionParams
	{
		// Token: 0x0600C972 RID: 51570 RVA: 0x001CC544 File Offset: 0x001CA744
		private SetInteractionLockState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetInteractionLockState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetInteractionLockState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetInteractionLockState_SetValue());
			}
			return result;
		}

		// Token: 0x0600C973 RID: 51571 RVA: 0x001CC57C File Offset: 0x001CA77C
		public static SetInteractionLockState Create([Nullable(2)] SetInteractionLockState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetInteractionLockState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C974 RID: 51572 RVA: 0x001CC58F File Offset: 0x001CA78F
		public static SetInteractionLockState CreateFromSetValue([Nullable(2)] SetInteractionLockState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetInteractionLockState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C975 RID: 51573 RVA: 0x001CC5A2 File Offset: 0x001CA7A2
		public SetInteractionLockState_SetValue ToSetValue()
		{
			return new SetInteractionLockState_SetValue
			{
				IsLock = this.IsLock
			};
		}

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0600C976 RID: 51574 RVA: 0x001CC5B5 File Offset: 0x001CA7B5
		// (set) Token: 0x0600C977 RID: 51575 RVA: 0x001CC5E0 File Offset: 0x001CA7E0
		public virtual bool IsLock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLock;
				}
				return this.PocoInterface != null && this.PocoInterface.IsLock;
			}
			set
			{
				this.GetOrCreatePoco().IsLock = value;
			}
		}

		// Token: 0x04007784 RID: 30596
		[Nullable(2)]
		protected new SetInteractionLockState FbInstance;

		// Token: 0x04007785 RID: 30597
		[Nullable(2)]
		protected SetInteractionLockState_SetValue PocoInterface;
	}
}
