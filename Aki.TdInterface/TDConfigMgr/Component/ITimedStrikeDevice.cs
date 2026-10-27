using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000772 RID: 1906
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimedStrikeDevice : IProgressBarControl
	{
		// Token: 0x0600293F RID: 10559 RVA: 0x0006CECC File Offset: 0x0006B0CC
		private ITimedStrikeDevice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimedStrikeDevice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimedStrikeDevice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimedStrikeDevice_SetValue());
			}
			return result;
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x0006CF04 File Offset: 0x0006B104
		public static ITimedStrikeDevice Create([Nullable(2)] ITimedStrikeDevice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimedStrikeDevice
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x0006CF17 File Offset: 0x0006B117
		public static ITimedStrikeDevice CreateFromSetValue([Nullable(2)] ITimedStrikeDevice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimedStrikeDevice
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x0006CF2C File Offset: 0x0006B12C
		public new ITimedStrikeDevice_SetValue ToSetValue()
		{
			return new ITimedStrikeDevice_SetValue
			{
				Type = this.Type,
				MaxValue = this.MaxValue,
				InitValue = this.InitValue,
				ProgressPerformanceAttribute = this.ProgressPerformanceAttribute,
				AddValue = this.AddValue,
				Timeout = this.Timeout,
				FallbackValue = this.FallbackValue,
				FallbackInterval = this.FallbackInterval,
				ZeroValuePerformanceAttribute = this.ZeroValuePerformanceAttribute,
				AscendPerformanceAttribute = this.AscendPerformanceAttribute,
				DescendPerformanceAttribute = this.DescendPerformanceAttribute
			};
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x0006CFC2 File Offset: 0x0006B1C2
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x0006CFED File Offset: 0x0006B1ED
		public override EProgressBarControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarControlType.CaptureStrategicPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x0006CFFB File Offset: 0x0006B1FB
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x0006D026 File Offset: 0x0006B226
		public override int MaxValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxValue;
			}
			set
			{
				this.GetOrCreatePoco().MaxValue = value;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x0006D034 File Offset: 0x0006B234
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x0006D05F File Offset: 0x0006B25F
		public override int InitValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InitValue;
			}
			set
			{
				this.GetOrCreatePoco().InitValue = value;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x0006D070 File Offset: 0x0006B270
		// (set) Token: 0x0600294A RID: 10570 RVA: 0x0006D0AA File Offset: 0x0006B2AA
		public override int? ProgressPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressPerformanceAttribute;
				}
				ITimedStrikeDevice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProgressPerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().ProgressPerformanceAttribute = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x0006D0B8 File Offset: 0x0006B2B8
		// (set) Token: 0x0600294C RID: 10572 RVA: 0x0006D0E3 File Offset: 0x0006B2E3
		public virtual int AddValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AddValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AddValue;
			}
			set
			{
				this.GetOrCreatePoco().AddValue = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x0006D0F1 File Offset: 0x0006B2F1
		// (set) Token: 0x0600294E RID: 10574 RVA: 0x0006D11C File Offset: 0x0006B31C
		public virtual int Timeout
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Timeout;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Timeout;
			}
			set
			{
				this.GetOrCreatePoco().Timeout = value;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x0006D12A File Offset: 0x0006B32A
		// (set) Token: 0x06002950 RID: 10576 RVA: 0x0006D155 File Offset: 0x0006B355
		public virtual int FallbackValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FallbackValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FallbackValue;
			}
			set
			{
				this.GetOrCreatePoco().FallbackValue = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x0006D163 File Offset: 0x0006B363
		// (set) Token: 0x06002952 RID: 10578 RVA: 0x0006D18E File Offset: 0x0006B38E
		public virtual int FallbackInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FallbackInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FallbackInterval;
			}
			set
			{
				this.GetOrCreatePoco().FallbackInterval = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x0006D19C File Offset: 0x0006B39C
		// (set) Token: 0x06002954 RID: 10580 RVA: 0x0006D1D6 File Offset: 0x0006B3D6
		public virtual int? ZeroValuePerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ZeroValuePerformanceAttribute;
				}
				ITimedStrikeDevice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ZeroValuePerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().ZeroValuePerformanceAttribute = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x0006D1E4 File Offset: 0x0006B3E4
		// (set) Token: 0x06002956 RID: 10582 RVA: 0x0006D21E File Offset: 0x0006B41E
		public virtual int? AscendPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AscendPerformanceAttribute;
				}
				ITimedStrikeDevice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AscendPerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().AscendPerformanceAttribute = value;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x0006D22C File Offset: 0x0006B42C
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x0006D266 File Offset: 0x0006B466
		public virtual int? DescendPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DescendPerformanceAttribute;
				}
				ITimedStrikeDevice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DescendPerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().DescendPerformanceAttribute = value;
			}
		}

		// Token: 0x04001BB2 RID: 7090
		[Nullable(2)]
		protected new ITimedStrikeDevice FbInstance;

		// Token: 0x04001BB3 RID: 7091
		[Nullable(2)]
		protected new ITimedStrikeDevice_SetValue PocoInterface;
	}
}
