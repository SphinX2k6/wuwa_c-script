using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000791 RID: 1937
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleRefreshConfig
	{
		// Token: 0x060029FC RID: 10748 RVA: 0x0006E780 File Offset: 0x0006C980
		private ITimeScheduleRefreshConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleRefreshConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleRefreshConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleRefreshConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x0006E7B8 File Offset: 0x0006C9B8
		public static ITimeScheduleRefreshConfig Create([Nullable(2)] ITimeScheduleRefreshConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleRefreshConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x0006E7CB File Offset: 0x0006C9CB
		public static ITimeScheduleRefreshConfig CreateFromSetValue([Nullable(2)] ITimeScheduleRefreshConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleRefreshConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x0006E7DE File Offset: 0x0006C9DE
		public ITimeScheduleRefreshConfig_SetValue ToSetValue()
		{
			return new ITimeScheduleRefreshConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x0006E7F1 File Offset: 0x0006C9F1
		// (set) Token: 0x06002A01 RID: 10753 RVA: 0x0006E81C File Offset: 0x0006CA1C
		public virtual ETimeScheduleRefreshType Type
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

		// Token: 0x04001C1D RID: 7197
		[Nullable(2)]
		protected ITimeScheduleRefreshConfig FbInstance;

		// Token: 0x04001C1E RID: 7198
		[Nullable(2)]
		protected ITimeScheduleRefreshConfig_SetValue PocoInterface;
	}
}
