using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200190F RID: 6415
	public class IActorLookAtUnLock : IActorLookAtData
	{
		// Token: 0x06008699 RID: 34457 RVA: 0x00140310 File Offset: 0x0013E510
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

		// Token: 0x0600869A RID: 34458 RVA: 0x00140348 File Offset: 0x0013E548
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

		// Token: 0x0600869B RID: 34459 RVA: 0x0014035B File Offset: 0x0013E55B
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

		// Token: 0x0600869C RID: 34460 RVA: 0x0014036E File Offset: 0x0013E56E
		public new IActorLookAtUnLock_SetValue ToSetValue()
		{
			return new IActorLookAtUnLock_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x0600869D RID: 34461 RVA: 0x00140381 File Offset: 0x0013E581
		// (set) Token: 0x0600869E RID: 34462 RVA: 0x001403AC File Offset: 0x0013E5AC
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

		// Token: 0x04005551 RID: 21841
		[Nullable(2)]
		protected new IActorLookAtUnLock FbInstance;

		// Token: 0x04005552 RID: 21842
		[Nullable(2)]
		protected new IActorLookAtUnLock_SetValue PocoInterface;
	}
}
