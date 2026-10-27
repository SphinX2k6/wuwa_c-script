using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200178E RID: 6030
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAtUnLock : IActorLookAtData
	{
		// Token: 0x06007FA9 RID: 32681 RVA: 0x001310B0 File Offset: 0x0012F2B0
		private IActorLookAtUnLock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtUnLock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtUnLock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtUnLock_SetValue());
			}
			return result;
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x001310E8 File Offset: 0x0012F2E8
		public static IActorLookAtUnLock Create([Nullable(2)] IActorLookAtUnLock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtUnLock
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x001310FB File Offset: 0x0012F2FB
		public static IActorLookAtUnLock CreateFromSetValue([Nullable(2)] IActorLookAtUnLock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtUnLock
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x0013110E File Offset: 0x0012F30E
		public new IActorLookAtUnLock_SetValue ToSetValue()
		{
			return new IActorLookAtUnLock_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x06007FAD RID: 32685 RVA: 0x00131121 File Offset: 0x0012F321
		// (set) Token: 0x06007FAE RID: 32686 RVA: 0x0013114C File Offset: 0x0012F34C
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

		// Token: 0x0400511B RID: 20763
		[Nullable(2)]
		protected new IActorLookAtUnLock FbInstance;

		// Token: 0x0400511C RID: 20764
		[Nullable(2)]
		protected new IActorLookAtUnLock_SetValue PocoInterface;
	}
}
