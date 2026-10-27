using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CA6 RID: 7334
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenQteConfig
	{
		// Token: 0x06009D67 RID: 40295 RVA: 0x00168844 File Offset: 0x00166A44
		private IOpenQteConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenQteConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenQteConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenQteConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x0016887C File Offset: 0x00166A7C
		public static IOpenQteConfig Create([Nullable(2)] IOpenQteConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenQteConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x0016888F File Offset: 0x00166A8F
		public static IOpenQteConfig CreateFromSetValue([Nullable(2)] IOpenQteConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenQteConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x001688A2 File Offset: 0x00166AA2
		public IOpenQteConfig_SetValue ToSetValue()
		{
			return new IOpenQteConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x06009D6B RID: 40299 RVA: 0x001688B5 File Offset: 0x00166AB5
		// (set) Token: 0x06009D6C RID: 40300 RVA: 0x001688E0 File Offset: 0x00166AE0
		public virtual EOpenQteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOpenQteType.PanelQte;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F4A RID: 24394
		[Nullable(2)]
		protected IOpenQteConfig FbInstance;

		// Token: 0x04005F4B RID: 24395
		[Nullable(2)]
		protected IOpenQteConfig_SetValue PocoInterface;
	}
}
