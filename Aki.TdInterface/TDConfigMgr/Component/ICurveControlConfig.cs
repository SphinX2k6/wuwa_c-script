using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000295 RID: 661
	[NullableContext(1)]
	[Nullable(0)]
	public class ICurveControlConfig
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x00030048 File Offset: 0x0002E248
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

		// Token: 0x06000C58 RID: 3160 RVA: 0x00030080 File Offset: 0x0002E280
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

		// Token: 0x06000C59 RID: 3161 RVA: 0x00030093 File Offset: 0x0002E293
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

		// Token: 0x06000C5A RID: 3162 RVA: 0x000300A6 File Offset: 0x0002E2A6
		public ICurveControlConfig_SetValue ToSetValue()
		{
			return new ICurveControlConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x000300B9 File Offset: 0x0002E2B9
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x000300E4 File Offset: 0x0002E2E4
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

		// Token: 0x04000BA2 RID: 2978
		[Nullable(2)]
		protected ICurveControlConfig FbInstance;

		// Token: 0x04000BA3 RID: 2979
		[Nullable(2)]
		protected ICurveControlConfig_SetValue PocoInterface;
	}
}
