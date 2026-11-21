using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001905 RID: 6405
	public class IActorLookAtLockable : IActorLookAtData
	{
		// Token: 0x06008663 RID: 34403 RVA: 0x0013FCF4 File Offset: 0x0013DEF4
		private IActorLookAtLockable_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtLockable 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtLockable_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtLockable_SetValue());
			}
			return result;
		}

		// Token: 0x06008664 RID: 34404 RVA: 0x0013FD2C File Offset: 0x0013DF2C
		public static IActorLookAtLockable Create([Nullable(2)] IActorLookAtLockable instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtLockable
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008665 RID: 34405 RVA: 0x0013FD3F File Offset: 0x0013DF3F
		public static IActorLookAtLockable CreateFromSetValue([Nullable(2)] IActorLookAtLockable_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtLockable
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008666 RID: 34406 RVA: 0x0013FD52 File Offset: 0x0013DF52
		public new IActorLookAtLockable_SetValue ToSetValue()
		{
			return new IActorLookAtLockable_SetValue
			{
				Type = this.Type,
				Lock = this.Lock
			};
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x06008667 RID: 34407 RVA: 0x0013FD71 File Offset: 0x0013DF71
		// (set) Token: 0x06008668 RID: 34408 RVA: 0x0013FD9C File Offset: 0x0013DF9C
		public override EActorLookAtMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorLookAtMode.Talker;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x06008669 RID: 34409 RVA: 0x0013FDAC File Offset: 0x0013DFAC
		// (set) Token: 0x0600866A RID: 34410 RVA: 0x0013FDE6 File Offset: 0x0013DFE6
		public virtual bool? Lock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Lock;
				}
				IActorLookAtLockable_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Lock;
			}
			set
			{
				this.GetOrCreatePoco().Lock = value;
			}
		}

		// Token: 0x04005539 RID: 21817
		[Nullable(2)]
		protected new IActorLookAtLockable FbInstance;

		// Token: 0x0400553A RID: 21818
		[Nullable(2)]
		protected new IActorLookAtLockable_SetValue PocoInterface;
	}
}
