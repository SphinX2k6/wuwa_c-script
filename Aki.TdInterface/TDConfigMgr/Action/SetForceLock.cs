using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021B9 RID: 8633
	[NullableContext(1)]
	[Nullable(0)]
	public class SetForceLock : ActionParams
	{
		// Token: 0x0600BDA4 RID: 48548 RVA: 0x001B4D10 File Offset: 0x001B2F10
		private SetForceLock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetForceLock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetForceLock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetForceLock_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDA5 RID: 48549 RVA: 0x001B4D48 File Offset: 0x001B2F48
		public static SetForceLock Create([Nullable(2)] SetForceLock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetForceLock
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDA6 RID: 48550 RVA: 0x001B4D5B File Offset: 0x001B2F5B
		public static SetForceLock CreateFromSetValue([Nullable(2)] SetForceLock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetForceLock
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x001B4D6E File Offset: 0x001B2F6E
		public SetForceLock_SetValue ToSetValue()
		{
			return new SetForceLock_SetValue
			{
				EntityId = this.EntityId,
				IsLocked = this.IsLocked
			};
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0600BDA8 RID: 48552 RVA: 0x001B4D8D File Offset: 0x001B2F8D
		// (set) Token: 0x0600BDA9 RID: 48553 RVA: 0x001B4DB8 File Offset: 0x001B2FB8
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0600BDAA RID: 48554 RVA: 0x001B4DC6 File Offset: 0x001B2FC6
		// (set) Token: 0x0600BDAB RID: 48555 RVA: 0x001B4DF1 File Offset: 0x001B2FF1
		public virtual bool IsLocked
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLocked;
				}
				return this.PocoInterface != null && this.PocoInterface.IsLocked;
			}
			set
			{
				this.GetOrCreatePoco().IsLocked = value;
			}
		}

		// Token: 0x04007134 RID: 28980
		[Nullable(2)]
		protected new SetForceLock FbInstance;

		// Token: 0x04007135 RID: 28981
		[Nullable(2)]
		protected SetForceLock_SetValue PocoInterface;
	}
}
