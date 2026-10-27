using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007C9 RID: 1993
	[NullableContext(1)]
	[Nullable(0)]
	public class IWalkingPatternStayAwayConfig
	{
		// Token: 0x06002B31 RID: 11057 RVA: 0x00070B7C File Offset: 0x0006ED7C
		private IWalkingPatternStayAwayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWalkingPatternStayAwayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWalkingPatternStayAwayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWalkingPatternStayAwayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00070BB4 File Offset: 0x0006EDB4
		public static IWalkingPatternStayAwayConfig Create([Nullable(2)] IWalkingPatternStayAwayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWalkingPatternStayAwayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00070BC7 File Offset: 0x0006EDC7
		public static IWalkingPatternStayAwayConfig CreateFromSetValue([Nullable(2)] IWalkingPatternStayAwayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWalkingPatternStayAwayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00070BDA File Offset: 0x0006EDDA
		public IWalkingPatternStayAwayConfig_SetValue ToSetValue()
		{
			return new IWalkingPatternStayAwayConfig_SetValue
			{
				SplineDistance = this.SplineDistance,
				StayAwayTime = this.StayAwayTime
			};
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x00070BF9 File Offset: 0x0006EDF9
		// (set) Token: 0x06002B36 RID: 11062 RVA: 0x00070C24 File Offset: 0x0006EE24
		public virtual int SplineDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineDistance;
			}
			set
			{
				this.GetOrCreatePoco().SplineDistance = value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x00070C34 File Offset: 0x0006EE34
		// (set) Token: 0x06002B38 RID: 11064 RVA: 0x00070C6E File Offset: 0x0006EE6E
		public virtual int? StayAwayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StayAwayTime;
				}
				IWalkingPatternStayAwayConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StayAwayTime;
			}
			set
			{
				this.GetOrCreatePoco().StayAwayTime = value;
			}
		}

		// Token: 0x04001CAE RID: 7342
		[Nullable(2)]
		protected IWalkingPatternStayAwayConfig FbInstance;

		// Token: 0x04001CAF RID: 7343
		[Nullable(2)]
		protected IWalkingPatternStayAwayConfig_SetValue PocoInterface;
	}
}
