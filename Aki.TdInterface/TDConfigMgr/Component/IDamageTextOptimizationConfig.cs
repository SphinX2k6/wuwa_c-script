using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002EC RID: 748
	public class IDamageTextOptimizationConfig : IPerformanceOptimization
	{
		// Token: 0x06000DD5 RID: 3541 RVA: 0x00033818 File Offset: 0x00031A18
		private IDamageTextOptimizationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDamageTextOptimizationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDamageTextOptimizationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDamageTextOptimizationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00033850 File Offset: 0x00031A50
		public static IDamageTextOptimizationConfig Create([Nullable(2)] IDamageTextOptimizationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDamageTextOptimizationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00033863 File Offset: 0x00031A63
		public static IDamageTextOptimizationConfig CreateFromSetValue([Nullable(2)] IDamageTextOptimizationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDamageTextOptimizationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00033876 File Offset: 0x00031A76
		public new IDamageTextOptimizationConfig_SetValue ToSetValue()
		{
			return new IDamageTextOptimizationConfig_SetValue
			{
				Type = this.Type,
				UseRange = this.UseRange
			};
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00033895 File Offset: 0x00031A95
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x000338C0 File Offset: 0x00031AC0
		public override EPerformanceOptimizationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPerformanceOptimizationType.PlaneMovementOptimization;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x000338D0 File Offset: 0x00031AD0
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x0003390A File Offset: 0x00031B0A
		public virtual bool? UseRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseRange;
				}
				IDamageTextOptimizationConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseRange;
			}
			set
			{
				this.GetOrCreatePoco().UseRange = value;
			}
		}

		// Token: 0x04000CAF RID: 3247
		[Nullable(2)]
		protected new IDamageTextOptimizationConfig FbInstance;

		// Token: 0x04000CB0 RID: 3248
		[Nullable(2)]
		protected new IDamageTextOptimizationConfig_SetValue PocoInterface;
	}
}
