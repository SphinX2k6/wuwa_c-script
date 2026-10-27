using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000787 RID: 1927
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleGameDailyRefresh : ITimeScheduleRefreshConfig
	{
		// Token: 0x060029CA RID: 10698 RVA: 0x0006E140 File Offset: 0x0006C340
		private ITimeScheduleGameDailyRefresh_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleGameDailyRefresh 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleGameDailyRefresh_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleGameDailyRefresh_SetValue());
			}
			return result;
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x0006E178 File Offset: 0x0006C378
		public static ITimeScheduleGameDailyRefresh Create([Nullable(2)] ITimeScheduleGameDailyRefresh instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleGameDailyRefresh
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x0006E18B File Offset: 0x0006C38B
		public static ITimeScheduleGameDailyRefresh CreateFromSetValue([Nullable(2)] ITimeScheduleGameDailyRefresh_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleGameDailyRefresh
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x0006E19E File Offset: 0x0006C39E
		public new ITimeScheduleGameDailyRefresh_SetValue ToSetValue()
		{
			return new ITimeScheduleGameDailyRefresh_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x0006E1B1 File Offset: 0x0006C3B1
		// (set) Token: 0x060029CF RID: 10703 RVA: 0x0006E1DC File Offset: 0x0006C3DC
		public override ETimeScheduleRefreshType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScheduleRefreshType.GameDaily;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001BFF RID: 7167
		[Nullable(2)]
		protected new ITimeScheduleGameDailyRefresh FbInstance;

		// Token: 0x04001C00 RID: 7168
		[Nullable(2)]
		protected new ITimeScheduleGameDailyRefresh_SetValue PocoInterface;
	}
}
