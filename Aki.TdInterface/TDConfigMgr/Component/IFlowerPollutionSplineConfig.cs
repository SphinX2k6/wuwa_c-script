using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A0 RID: 928
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowerPollutionSplineConfig
	{
		// Token: 0x0600127B RID: 4731 RVA: 0x0003CF68 File Offset: 0x0003B168
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

		// Token: 0x0600127C RID: 4732 RVA: 0x0003CFA0 File Offset: 0x0003B1A0
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

		// Token: 0x0600127D RID: 4733 RVA: 0x0003CFB3 File Offset: 0x0003B1B3
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

		// Token: 0x0600127E RID: 4734 RVA: 0x0003CFC6 File Offset: 0x0003B1C6
		public IFlowerPollutionSplineConfig_SetValue ToSetValue()
		{
			return new IFlowerPollutionSplineConfig_SetValue
			{
				SplineEntityIds = this.SplineEntityIds
			};
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x0003CFD9 File Offset: 0x0003B1D9
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x0003D000 File Offset: 0x0003B200
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

		// Token: 0x04000EE0 RID: 3808
		[Nullable(2)]
		protected IFlowerPollutionSplineConfig FbInstance;

		// Token: 0x04000EE1 RID: 3809
		[Nullable(2)]
		protected IFlowerPollutionSplineConfig_SetValue PocoInterface;
	}
}
