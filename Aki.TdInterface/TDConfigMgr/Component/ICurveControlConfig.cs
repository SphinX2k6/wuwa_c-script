using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002DA RID: 730
	public class ICurveControlConfig
	{
		// Token: 0x06000D7B RID: 3451 RVA: 0x00032E38 File Offset: 0x00031038
		private ICurveControlConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICurveControlConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICurveControlConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICurveControlConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00032E70 File Offset: 0x00031070
		public static ICurveControlConfig Create([Nullable(2)] ICurveControlConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICurveControlConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00032E83 File Offset: 0x00031083
		public static ICurveControlConfig CreateFromSetValue([Nullable(2)] ICurveControlConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICurveControlConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00032E96 File Offset: 0x00031096
		public ICurveControlConfig_SetValue ToSetValue()
		{
			return new ICurveControlConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00032EA9 File Offset: 0x000310A9
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x00032ED4 File Offset: 0x000310D4
		public virtual ECurveControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECurveControlType.ChargeSlash;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000C87 RID: 3207
		[Nullable(2)]
		protected ICurveControlConfig FbInstance;

		// Token: 0x04000C88 RID: 3208
		[Nullable(2)]
		protected ICurveControlConfig_SetValue PocoInterface;
	}
}
