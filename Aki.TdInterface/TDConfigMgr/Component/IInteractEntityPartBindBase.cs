using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000478 RID: 1144
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEntityPartBindBase
	{
		// Token: 0x0600170D RID: 5901 RVA: 0x000464E4 File Offset: 0x000446E4
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

		// Token: 0x0600170E RID: 5902 RVA: 0x0004651C File Offset: 0x0004471C
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

		// Token: 0x0600170F RID: 5903 RVA: 0x0004652F File Offset: 0x0004472F
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

		// Token: 0x06001710 RID: 5904 RVA: 0x00046542 File Offset: 0x00044742
		public IInteractEntityPartBindBase_SetValue ToSetValue()
		{
			return new IInteractEntityPartBindBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x00046555 File Offset: 0x00044755
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x00046580 File Offset: 0x00044780
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

		// Token: 0x04001163 RID: 4451
		[Nullable(2)]
		protected IInteractEntityPartBindBase FbInstance;

		// Token: 0x04001164 RID: 4452
		[Nullable(2)]
		protected IInteractEntityPartBindBase_SetValue PocoInterface;
	}
}
