using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200086C RID: 2156
	public class IWalkingPatternStayAwayConfig
	{
		// Token: 0x06002E61 RID: 11873 RVA: 0x00077EE0 File Offset: 0x000760E0
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

		// Token: 0x06002E62 RID: 11874 RVA: 0x00077F18 File Offset: 0x00076118
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

		// Token: 0x06002E63 RID: 11875 RVA: 0x00077F2B File Offset: 0x0007612B
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

		// Token: 0x06002E64 RID: 11876 RVA: 0x00077F3E File Offset: 0x0007613E
		public IWalkingPatternStayAwayConfig_SetValue ToSetValue()
		{
			return new IWalkingPatternStayAwayConfig_SetValue
			{
				SplineDistance = this.SplineDistance,
				StayAwayTime = this.StayAwayTime
			};
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x00077F5D File Offset: 0x0007615D
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x00077F88 File Offset: 0x00076188
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

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x00077F98 File Offset: 0x00076198
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x00077FD2 File Offset: 0x000761D2
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

		// Token: 0x04001EBA RID: 7866
		[Nullable(2)]
		protected IWalkingPatternStayAwayConfig FbInstance;

		// Token: 0x04001EBB RID: 7867
		[Nullable(2)]
		protected IWalkingPatternStayAwayConfig_SetValue PocoInterface;
	}
}
