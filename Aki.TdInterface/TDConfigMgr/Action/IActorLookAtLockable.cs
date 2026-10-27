using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001784 RID: 6020
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAtLockable : IActorLookAtData
	{
		// Token: 0x06007F73 RID: 32627 RVA: 0x00130A94 File Offset: 0x0012EC94
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

		// Token: 0x06007F74 RID: 32628 RVA: 0x00130ACC File Offset: 0x0012ECCC
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

		// Token: 0x06007F75 RID: 32629 RVA: 0x00130ADF File Offset: 0x0012ECDF
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

		// Token: 0x06007F76 RID: 32630 RVA: 0x00130AF2 File Offset: 0x0012ECF2
		public new IActorLookAtLockable_SetValue ToSetValue()
		{
			return new IActorLookAtLockable_SetValue
			{
				Type = this.Type,
				Lock = this.Lock
			};
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x06007F77 RID: 32631 RVA: 0x00130B11 File Offset: 0x0012ED11
		// (set) Token: 0x06007F78 RID: 32632 RVA: 0x00130B3C File Offset: 0x0012ED3C
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

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x06007F79 RID: 32633 RVA: 0x00130B4C File Offset: 0x0012ED4C
		// (set) Token: 0x06007F7A RID: 32634 RVA: 0x00130B86 File Offset: 0x0012ED86
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

		// Token: 0x04005103 RID: 20739
		[Nullable(2)]
		protected new IActorLookAtLockable FbInstance;

		// Token: 0x04005104 RID: 20740
		[Nullable(2)]
		protected new IActorLookAtLockable_SetValue PocoInterface;
	}
}
