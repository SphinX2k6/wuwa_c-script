using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018E6 RID: 6374
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseSkiConfig : ISkiConfigType
	{
		// Token: 0x060088A5 RID: 34981 RVA: 0x00143138 File Offset: 0x00141338
		private ICloseSkiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseSkiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseSkiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseSkiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060088A6 RID: 34982 RVA: 0x00143170 File Offset: 0x00141370
		public static ICloseSkiConfig Create([Nullable(2)] ICloseSkiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSkiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x00143183 File Offset: 0x00141383
		public static ICloseSkiConfig CreateFromSetValue([Nullable(2)] ICloseSkiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseSkiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x00143196 File Offset: 0x00141396
		public new ICloseSkiConfig_SetValue ToSetValue()
		{
			return new ICloseSkiConfig_SetValue
			{
				Type = this.Type,
				Target = this.Target
			};
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x060088A9 RID: 34985 RVA: 0x001431B5 File Offset: 0x001413B5
		// (set) Token: 0x060088AA RID: 34986 RVA: 0x001431E0 File Offset: 0x001413E0
		public override ESkiConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkiConfig.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x060088AB RID: 34987 RVA: 0x001431EE File Offset: 0x001413EE
		// (set) Token: 0x060088AC RID: 34988 RVA: 0x00143215 File Offset: 0x00141415
		public override ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ICloseSkiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x040055C3 RID: 21955
		[Nullable(2)]
		protected new ICloseSkiConfig FbInstance;

		// Token: 0x040055C4 RID: 21956
		[Nullable(2)]
		protected new ICloseSkiConfig_SetValue PocoInterface;
	}
}
