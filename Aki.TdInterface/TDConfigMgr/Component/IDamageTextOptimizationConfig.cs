using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002A7 RID: 679
	[NullableContext(1)]
	[Nullable(0)]
	public class IDamageTextOptimizationConfig : IPerformanceOptimization
	{
		// Token: 0x06000CB1 RID: 3249 RVA: 0x00030A28 File Offset: 0x0002EC28
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

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00030A60 File Offset: 0x0002EC60
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

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00030A73 File Offset: 0x0002EC73
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

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00030A86 File Offset: 0x0002EC86
		public new IDamageTextOptimizationConfig_SetValue ToSetValue()
		{
			return new IDamageTextOptimizationConfig_SetValue
			{
				Type = this.Type,
				UseRange = this.UseRange
			};
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00030AA5 File Offset: 0x0002ECA5
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00030AD0 File Offset: 0x0002ECD0
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

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00030AE0 File Offset: 0x0002ECE0
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00030B1A File Offset: 0x0002ED1A
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

		// Token: 0x04000BCA RID: 3018
		[Nullable(2)]
		protected new IDamageTextOptimizationConfig FbInstance;

		// Token: 0x04000BCB RID: 3019
		[Nullable(2)]
		protected new IDamageTextOptimizationConfig_SetValue PocoInterface;
	}
}
