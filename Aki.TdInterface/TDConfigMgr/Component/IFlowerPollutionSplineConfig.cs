using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E9 RID: 1001
	public class IFlowerPollutionSplineConfig
	{
		// Token: 0x060013C1 RID: 5057 RVA: 0x000402A0 File Offset: 0x0003E4A0
		private IFlowerPollutionSplineConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowerPollutionSplineConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowerPollutionSplineConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowerPollutionSplineConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x000402D8 File Offset: 0x0003E4D8
		public static IFlowerPollutionSplineConfig Create([Nullable(2)] IFlowerPollutionSplineConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowerPollutionSplineConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000402EB File Offset: 0x0003E4EB
		public static IFlowerPollutionSplineConfig CreateFromSetValue([Nullable(2)] IFlowerPollutionSplineConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowerPollutionSplineConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000402FE File Offset: 0x0003E4FE
		public IFlowerPollutionSplineConfig_SetValue ToSetValue()
		{
			return new IFlowerPollutionSplineConfig_SetValue
			{
				SplineEntityIds = this.SplineEntityIds
			};
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00040311 File Offset: 0x0003E511
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x00040338 File Offset: 0x0003E538
		public virtual List<int> SplineEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityIds;
				}
				IFlowerPollutionSplineConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SplineEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityIds = value;
			}
		}

		// Token: 0x04000FD8 RID: 4056
		[Nullable(2)]
		protected IFlowerPollutionSplineConfig FbInstance;

		// Token: 0x04000FD9 RID: 4057
		[Nullable(2)]
		protected IFlowerPollutionSplineConfig_SetValue PocoInterface;
	}
}
