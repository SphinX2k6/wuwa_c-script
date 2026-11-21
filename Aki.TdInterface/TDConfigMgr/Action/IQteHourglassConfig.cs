using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F8D RID: 8077
	public class IQteHourglassConfig
	{
		// Token: 0x0600ABB1 RID: 43953 RVA: 0x00184888 File Offset: 0x00182A88
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

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x001848C0 File Offset: 0x00182AC0
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

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x001848D3 File Offset: 0x00182AD3
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

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x001848E6 File Offset: 0x00182AE6
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

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0600ABB5 RID: 43957 RVA: 0x0018491D File Offset: 0x00182B1D
		// (set) Token: 0x0600ABB6 RID: 43958 RVA: 0x00184948 File Offset: 0x00182B48
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

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0600ABB7 RID: 43959 RVA: 0x00184956 File Offset: 0x00182B56
		// (set) Token: 0x0600ABB8 RID: 43960 RVA: 0x00184985 File Offset: 0x00182B85
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

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0600ABB9 RID: 43961 RVA: 0x00184993 File Offset: 0x00182B93
		// (set) Token: 0x0600ABBA RID: 43962 RVA: 0x001849BE File Offset: 0x00182BBE
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

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0600ABBB RID: 43963 RVA: 0x001849CC File Offset: 0x00182BCC
		// (set) Token: 0x0600ABBC RID: 43964 RVA: 0x001849F7 File Offset: 0x00182BF7
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

		// Token: 0x040066C2 RID: 26306
		[Nullable(2)]
		protected IQteHourglassConfig FbInstance;

		// Token: 0x040066C3 RID: 26307
		[Nullable(2)]
		protected IQteHourglassConfig_SetValue PocoInterface;
	}
}
