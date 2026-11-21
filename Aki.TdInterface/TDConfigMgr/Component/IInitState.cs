using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004BD RID: 1213
	public class IInitState
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x000497E0 File Offset: 0x000479E0
		private IInitState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitState_SetValue());
			}
			return result;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00049818 File Offset: 0x00047A18
		public static IInitState Create([Nullable(2)] IInitState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0004982B File Offset: 0x00047A2B
		public static IInitState CreateFromSetValue([Nullable(2)] IInitState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0004983E File Offset: 0x00047A3E
		public IInitState_SetValue ToSetValue()
		{
			return new IInitState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00049851 File Offset: 0x00047A51
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x0004987C File Offset: 0x00047A7C
		public virtual EInitStateType Type
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

		// Token: 0x0400125C RID: 4700
		[Nullable(2)]
		protected IInitState FbInstance;

		// Token: 0x0400125D RID: 4701
		[Nullable(2)]
		protected IInitState_SetValue PocoInterface;
	}
}
