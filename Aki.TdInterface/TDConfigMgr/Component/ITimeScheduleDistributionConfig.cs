using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000783 RID: 1923
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleDistributionConfig
	{
		// Token: 0x060029B8 RID: 10680 RVA: 0x0006DF88 File Offset: 0x0006C188
		private ITimeScheduleDistributionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleDistributionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleDistributionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleDistributionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x0006DFC0 File Offset: 0x0006C1C0
		public static ITimeScheduleDistributionConfig Create([Nullable(2)] ITimeScheduleDistributionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleDistributionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x0006DFD3 File Offset: 0x0006C1D3
		public static ITimeScheduleDistributionConfig CreateFromSetValue([Nullable(2)] ITimeScheduleDistributionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleDistributionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x0006DFE6 File Offset: 0x0006C1E6
		public ITimeScheduleDistributionConfig_SetValue ToSetValue()
		{
			return new ITimeScheduleDistributionConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x0006DFF9 File Offset: 0x0006C1F9
		// (set) Token: 0x060029BD RID: 10685 RVA: 0x0006E024 File Offset: 0x0006C224
		public virtual ETimeScheduleDistributionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScheduleDistributionType.RandomSchedulePosition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001BF8 RID: 7160
		[Nullable(2)]
		protected ITimeScheduleDistributionConfig FbInstance;

		// Token: 0x04001BF9 RID: 7161
		[Nullable(2)]
		protected ITimeScheduleDistributionConfig_SetValue PocoInterface;
	}
}
