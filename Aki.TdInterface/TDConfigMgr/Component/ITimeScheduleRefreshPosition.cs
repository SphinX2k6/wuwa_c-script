using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000832 RID: 2098
	public class ITimeScheduleRefreshPosition
	{
		// Token: 0x06002D24 RID: 11556 RVA: 0x00075A28 File Offset: 0x00073C28
		private ITimeScheduleRefreshPosition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleRefreshPosition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleRefreshPosition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleRefreshPosition_SetValue());
			}
			return result;
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00075A60 File Offset: 0x00073C60
		public static ITimeScheduleRefreshPosition Create([Nullable(2)] ITimeScheduleRefreshPosition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleRefreshPosition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00075A73 File Offset: 0x00073C73
		public static ITimeScheduleRefreshPosition CreateFromSetValue([Nullable(2)] ITimeScheduleRefreshPosition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleRefreshPosition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00075A86 File Offset: 0x00073C86
		public ITimeScheduleRefreshPosition_SetValue ToSetValue()
		{
			return new ITimeScheduleRefreshPosition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002D28 RID: 11560 RVA: 0x00075A99 File Offset: 0x00073C99
		// (set) Token: 0x06002D29 RID: 11561 RVA: 0x00075AC4 File Offset: 0x00073CC4
		public virtual ETimeScheduleRefreshPositionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScheduleRefreshPositionType.FixedPositions;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001E26 RID: 7718
		[Nullable(2)]
		protected ITimeScheduleRefreshPosition FbInstance;

		// Token: 0x04001E27 RID: 7719
		[Nullable(2)]
		protected ITimeScheduleRefreshPosition_SetValue PocoInterface;
	}
}
