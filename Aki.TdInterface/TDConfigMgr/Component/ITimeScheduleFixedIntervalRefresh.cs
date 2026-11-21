using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000826 RID: 2086
	public class ITimeScheduleFixedIntervalRefresh : ITimeScheduleGenerateParams
	{
		// Token: 0x06002CE6 RID: 11494 RVA: 0x0007522C File Offset: 0x0007342C
		private ITimeScheduleFixedIntervalRefresh_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleFixedIntervalRefresh 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleFixedIntervalRefresh_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleFixedIntervalRefresh_SetValue());
			}
			return result;
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00075264 File Offset: 0x00073464
		public static ITimeScheduleFixedIntervalRefresh Create([Nullable(2)] ITimeScheduleFixedIntervalRefresh instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleFixedIntervalRefresh
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00075277 File Offset: 0x00073477
		public static ITimeScheduleFixedIntervalRefresh CreateFromSetValue([Nullable(2)] ITimeScheduleFixedIntervalRefresh_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleFixedIntervalRefresh
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x0007528A File Offset: 0x0007348A
		public new ITimeScheduleFixedIntervalRefresh_SetValue ToSetValue()
		{
			return new ITimeScheduleFixedIntervalRefresh_SetValue
			{
				Type = this.Type,
				RefreshInterval = this.RefreshInterval,
				RefreshCount = this.RefreshCount,
				RefreshPosition = this.RefreshPosition
			};
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x000752C1 File Offset: 0x000734C1
		// (set) Token: 0x06002CEB RID: 11499 RVA: 0x000752EC File Offset: 0x000734EC
		public override ETimeScheduleGenerateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScheduleGenerateType.FixedIntervalRefresh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x000752FC File Offset: 0x000734FC
		// (set) Token: 0x06002CED RID: 11501 RVA: 0x0007535D File Offset: 0x0007355D
		public virtual ITimeScheduleRefreshInterval RefreshInterval
		{
			get
			{
				if (this._RefreshIntervalInited)
				{
					return this._RefreshIntervalCache;
				}
				this._RefreshIntervalInited = true;
				if (this.FbInstance != null)
				{
					this._RefreshIntervalCache = ITimeScheduleRefreshInterval.Create(this.FbInstance.RefreshInterval);
				}
				else
				{
					ITimeScheduleFixedIntervalRefresh_SetValue pocoInterface = this.PocoInterface;
					this._RefreshIntervalCache = ((pocoInterface != null) ? pocoInterface.RefreshInterval : null);
				}
				return this._RefreshIntervalCache;
			}
			set
			{
				this.GetOrCreatePoco().RefreshInterval = value;
				this._RefreshIntervalInited = false;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x00075372 File Offset: 0x00073572
		// (set) Token: 0x06002CEF RID: 11503 RVA: 0x0007539D File Offset: 0x0007359D
		public virtual int RefreshCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RefreshCount;
			}
			set
			{
				this.GetOrCreatePoco().RefreshCount = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000753AC File Offset: 0x000735AC
		// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x0007540D File Offset: 0x0007360D
		public virtual ITimeScheduleFixedPositions RefreshPosition
		{
			get
			{
				if (this._RefreshPositionInited)
				{
					return this._RefreshPositionCache;
				}
				this._RefreshPositionInited = true;
				if (this.FbInstance != null)
				{
					this._RefreshPositionCache = ITimeScheduleFixedPositions.Create(this.FbInstance.RefreshPosition);
				}
				else
				{
					ITimeScheduleFixedIntervalRefresh_SetValue pocoInterface = this.PocoInterface;
					this._RefreshPositionCache = ((pocoInterface != null) ? pocoInterface.RefreshPosition : null);
				}
				return this._RefreshPositionCache;
			}
			set
			{
				this.GetOrCreatePoco().RefreshPosition = value;
				this._RefreshPositionInited = false;
			}
		}

		// Token: 0x04001E01 RID: 7681
		[Nullable(2)]
		protected new ITimeScheduleFixedIntervalRefresh FbInstance;

		// Token: 0x04001E02 RID: 7682
		[Nullable(2)]
		protected new ITimeScheduleFixedIntervalRefresh_SetValue PocoInterface;

		// Token: 0x04001E03 RID: 7683
		private ITimeScheduleRefreshInterval _RefreshIntervalCache;

		// Token: 0x04001E04 RID: 7684
		private bool _RefreshIntervalInited;

		// Token: 0x04001E05 RID: 7685
		private ITimeScheduleFixedPositions _RefreshPositionCache;

		// Token: 0x04001E06 RID: 7686
		private bool _RefreshPositionInited;
	}
}
