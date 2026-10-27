using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200078F RID: 1935
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleRandomSchedulePositionDistribution : ITimeScheduleDistributionConfig
	{
		// Token: 0x060029F4 RID: 10740 RVA: 0x0006E6C4 File Offset: 0x0006C8C4
		private ITimeScheduleRandomSchedulePositionDistribution_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleRandomSchedulePositionDistribution 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleRandomSchedulePositionDistribution_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleRandomSchedulePositionDistribution_SetValue());
			}
			return result;
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x0006E6FC File Offset: 0x0006C8FC
		public static ITimeScheduleRandomSchedulePositionDistribution Create([Nullable(2)] ITimeScheduleRandomSchedulePositionDistribution instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleRandomSchedulePositionDistribution
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x0006E70F File Offset: 0x0006C90F
		public static ITimeScheduleRandomSchedulePositionDistribution CreateFromSetValue([Nullable(2)] ITimeScheduleRandomSchedulePositionDistribution_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleRandomSchedulePositionDistribution
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x0006E722 File Offset: 0x0006C922
		public new ITimeScheduleRandomSchedulePositionDistribution_SetValue ToSetValue()
		{
			return new ITimeScheduleRandomSchedulePositionDistribution_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x0006E735 File Offset: 0x0006C935
		// (set) Token: 0x060029F9 RID: 10745 RVA: 0x0006E760 File Offset: 0x0006C960
		public override ETimeScheduleDistributionType Type
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

		// Token: 0x04001C1A RID: 7194
		[Nullable(2)]
		protected new ITimeScheduleRandomSchedulePositionDistribution FbInstance;

		// Token: 0x04001C1B RID: 7195
		[Nullable(2)]
		protected new ITimeScheduleRandomSchedulePositionDistribution_SetValue PocoInterface;
	}
}
