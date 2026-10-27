using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D7C RID: 7548
	[NullableContext(1)]
	[Nullable(0)]
	public class IQteHourglassConfig
	{
		// Token: 0x0600A1C5 RID: 41413 RVA: 0x00170464 File Offset: 0x0016E664
		private IQteHourglassConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQteHourglassConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQteHourglassConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQteHourglassConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x0017049C File Offset: 0x0016E69C
		public static IQteHourglassConfig Create([Nullable(2)] IQteHourglassConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteHourglassConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x001704AF File Offset: 0x0016E6AF
		public static IQteHourglassConfig CreateFromSetValue([Nullable(2)] IQteHourglassConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQteHourglassConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x001704C2 File Offset: 0x0016E6C2
		public IQteHourglassConfig_SetValue ToSetValue()
		{
			return new IQteHourglassConfig_SetValue
			{
				QteId = this.QteId,
				TrailTime = this.TrailTime,
				TrailCurveX = this.TrailCurveX,
				TrailCurveY = this.TrailCurveY
			};
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600A1C9 RID: 41417 RVA: 0x001704F9 File Offset: 0x0016E6F9
		// (set) Token: 0x0600A1CA RID: 41418 RVA: 0x00170524 File Offset: 0x0016E724
		public virtual int QteId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QteId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.QteId;
			}
			set
			{
				this.GetOrCreatePoco().QteId = value;
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600A1CB RID: 41419 RVA: 0x00170532 File Offset: 0x0016E732
		// (set) Token: 0x0600A1CC RID: 41420 RVA: 0x00170561 File Offset: 0x0016E761
		public virtual float TrailTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrailTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TrailTime;
			}
			set
			{
				this.GetOrCreatePoco().TrailTime = value;
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600A1CD RID: 41421 RVA: 0x0017056F File Offset: 0x0016E76F
		// (set) Token: 0x0600A1CE RID: 41422 RVA: 0x0017059A File Offset: 0x0016E79A
		public virtual string TrailCurveX
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrailCurveX;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TrailCurveX;
			}
			set
			{
				this.GetOrCreatePoco().TrailCurveX = value;
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600A1CF RID: 41423 RVA: 0x001705A8 File Offset: 0x0016E7A8
		// (set) Token: 0x0600A1D0 RID: 41424 RVA: 0x001705D3 File Offset: 0x0016E7D3
		public virtual string TrailCurveY
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrailCurveY;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TrailCurveY;
			}
			set
			{
				this.GetOrCreatePoco().TrailCurveY = value;
			}
		}

		// Token: 0x04006146 RID: 24902
		[Nullable(2)]
		protected IQteHourglassConfig FbInstance;

		// Token: 0x04006147 RID: 24903
		[Nullable(2)]
		protected IQteHourglassConfig_SetValue PocoInterface;
	}
}
