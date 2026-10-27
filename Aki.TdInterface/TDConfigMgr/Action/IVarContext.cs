using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200202D RID: 8237
	[NullableContext(1)]
	[Nullable(0)]
	public class IVarContext
	{
		// Token: 0x0600B50E RID: 46350 RVA: 0x001A4A7C File Offset: 0x001A2C7C
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

		// Token: 0x0600B50F RID: 46351 RVA: 0x001A4AB4 File Offset: 0x001A2CB4
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

		// Token: 0x0600B510 RID: 46352 RVA: 0x001A4AC7 File Offset: 0x001A2CC7
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

		// Token: 0x0600B511 RID: 46353 RVA: 0x001A4ADA File Offset: 0x001A2CDA
		public IVarContext_SetValue ToSetValue()
		{
			return new IVarContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600B512 RID: 46354 RVA: 0x001A4AED File Offset: 0x001A2CED
		// (set) Token: 0x0600B513 RID: 46355 RVA: 0x001A4B18 File Offset: 0x001A2D18
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

		// Token: 0x04006D03 RID: 27907
		[Nullable(2)]
		protected IVarContext FbInstance;

		// Token: 0x04006D04 RID: 27908
		[Nullable(2)]
		protected IVarContext_SetValue PocoInterface;
	}
}
