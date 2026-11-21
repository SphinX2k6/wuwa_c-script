using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002276 RID: 8822
	public class IVarContext
	{
		// Token: 0x0600C034 RID: 49204 RVA: 0x001BB1E8 File Offset: 0x001B93E8
		private IVarContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVarContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVarContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVarContext_SetValue());
			}
			return result;
		}

		// Token: 0x0600C035 RID: 49205 RVA: 0x001BB220 File Offset: 0x001B9420
		public static IVarContext Create([Nullable(2)] IVarContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVarContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C036 RID: 49206 RVA: 0x001BB233 File Offset: 0x001B9433
		public static IVarContext CreateFromSetValue([Nullable(2)] IVarContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVarContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C037 RID: 49207 RVA: 0x001BB246 File Offset: 0x001B9446
		public IVarContext_SetValue ToSetValue()
		{
			return new IVarContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x0600C038 RID: 49208 RVA: 0x001BB259 File Offset: 0x001B9459
		// (set) Token: 0x0600C039 RID: 49209 RVA: 0x001BB284 File Offset: 0x001B9484
		public virtual EVarContext Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVarContext)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400730C RID: 29452
		[Nullable(2)]
		protected IVarContext FbInstance;

		// Token: 0x0400730D RID: 29453
		[Nullable(2)]
		protected IVarContext_SetValue PocoInterface;
	}
}
