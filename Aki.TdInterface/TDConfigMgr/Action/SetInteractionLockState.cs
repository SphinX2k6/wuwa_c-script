using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021BD RID: 8637
	[NullableContext(1)]
	[Nullable(0)]
	public class SetInteractionLockState : ActionParams
	{
		// Token: 0x0600BDB8 RID: 48568 RVA: 0x001B4F0C File Offset: 0x001B310C
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

		// Token: 0x0600BDB9 RID: 48569 RVA: 0x001B4F44 File Offset: 0x001B3144
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

		// Token: 0x0600BDBA RID: 48570 RVA: 0x001B4F57 File Offset: 0x001B3157
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

		// Token: 0x0600BDBB RID: 48571 RVA: 0x001B4F6A File Offset: 0x001B316A
		public SetInteractionLockState_SetValue ToSetValue()
		{
			return new SetInteractionLockState_SetValue
			{
				IsLock = this.IsLock
			};
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0600BDBC RID: 48572 RVA: 0x001B4F7D File Offset: 0x001B317D
		// (set) Token: 0x0600BDBD RID: 48573 RVA: 0x001B4FA8 File Offset: 0x001B31A8
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

		// Token: 0x0400713C RID: 28988
		[Nullable(2)]
		protected new SetInteractionLockState FbInstance;

		// Token: 0x0400713D RID: 28989
		[Nullable(2)]
		protected SetInteractionLockState_SetValue PocoInterface;
	}
}
