using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000276 RID: 630
	public class ICircuitConnectModeBase
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x0002D8A8 File Offset: 0x0002BAA8
		private ICircuitConnectModeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectModeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectModeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectModeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0002D8E0 File Offset: 0x0002BAE0
		public static ICircuitConnectModeBase Create([Nullable(2)] ICircuitConnectModeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectModeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0002D8F3 File Offset: 0x0002BAF3
		public static ICircuitConnectModeBase CreateFromSetValue([Nullable(2)] ICircuitConnectModeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectModeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0002D906 File Offset: 0x0002BB06
		public ICircuitConnectModeBase_SetValue ToSetValue()
		{
			return new ICircuitConnectModeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0002D919 File Offset: 0x0002BB19
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x0002D944 File Offset: 0x0002BB44
		public virtual ECircuitConnectMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECircuitConnectMode.TwoRings;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000B1A RID: 2842
		[Nullable(2)]
		protected ICircuitConnectModeBase FbInstance;

		// Token: 0x04000B1B RID: 2843
		[Nullable(2)]
		protected ICircuitConnectModeBase_SetValue PocoInterface;
	}
}
