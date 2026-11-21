using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004BF RID: 1215
	public class IInitStateBarrierLock : IInitState
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x0004989C File Offset: 0x00047A9C
		private IInitStateBarrierLock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateBarrierLock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateBarrierLock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateBarrierLock_SetValue());
			}
			return result;
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000498D4 File Offset: 0x00047AD4
		public static IInitStateBarrierLock Create([Nullable(2)] IInitStateBarrierLock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateBarrierLock
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x000498E7 File Offset: 0x00047AE7
		public static IInitStateBarrierLock CreateFromSetValue([Nullable(2)] IInitStateBarrierLock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateBarrierLock
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x000498FA File Offset: 0x00047AFA
		public new IInitStateBarrierLock_SetValue ToSetValue()
		{
			return new IInitStateBarrierLock_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0004990D File Offset: 0x00047B0D
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x00049938 File Offset: 0x00047B38
		public override EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400125F RID: 4703
		[Nullable(2)]
		protected new IInitStateBarrierLock FbInstance;

		// Token: 0x04001260 RID: 4704
		[Nullable(2)]
		protected new IInitStateBarrierLock_SetValue PocoInterface;
	}
}
