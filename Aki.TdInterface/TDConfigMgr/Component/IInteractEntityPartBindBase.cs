using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D1 RID: 1233
	public class IInteractEntityPartBindBase
	{
		// Token: 0x060018A7 RID: 6311 RVA: 0x0004A22C File Offset: 0x0004842C
		private IInteractEntityPartBindBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractEntityPartBindBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractEntityPartBindBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractEntityPartBindBase_SetValue());
			}
			return result;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0004A264 File Offset: 0x00048464
		public static IInteractEntityPartBindBase Create([Nullable(2)] IInteractEntityPartBindBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartBindBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0004A277 File Offset: 0x00048477
		public static IInteractEntityPartBindBase CreateFromSetValue([Nullable(2)] IInteractEntityPartBindBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractEntityPartBindBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0004A28A File Offset: 0x0004848A
		public IInteractEntityPartBindBase_SetValue ToSetValue()
		{
			return new IInteractEntityPartBindBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0004A29D File Offset: 0x0004849D
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x0004A2C8 File Offset: 0x000484C8
		public virtual EInteractEntityPartBindType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractEntityPartBindType.Prefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001285 RID: 4741
		[Nullable(2)]
		protected IInteractEntityPartBindBase FbInstance;

		// Token: 0x04001286 RID: 4742
		[Nullable(2)]
		protected IInteractEntityPartBindBase_SetValue PocoInterface;
	}
}
