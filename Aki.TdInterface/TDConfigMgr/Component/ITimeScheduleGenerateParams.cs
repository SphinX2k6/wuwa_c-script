using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200078B RID: 1931
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleGenerateParams
	{
		// Token: 0x060029DE RID: 10718 RVA: 0x0006E400 File Offset: 0x0006C600
		private ITimeScheduleGenerateParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleGenerateParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleGenerateParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleGenerateParams_SetValue());
			}
			return result;
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x0006E438 File Offset: 0x0006C638
		public static ITimeScheduleGenerateParams Create([Nullable(2)] ITimeScheduleGenerateParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleGenerateParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x0006E44B File Offset: 0x0006C64B
		public static ITimeScheduleGenerateParams CreateFromSetValue([Nullable(2)] ITimeScheduleGenerateParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleGenerateParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x0006E45E File Offset: 0x0006C65E
		public ITimeScheduleGenerateParams_SetValue ToSetValue()
		{
			return new ITimeScheduleGenerateParams_SetValue
			{
				RefreshType = this.RefreshType,
				MaxCount = this.MaxCount,
				MinCount = this.MinCount,
				DistributionType = this.DistributionType
			};
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x0006E498 File Offset: 0x0006C698
		// (set) Token: 0x060029E3 RID: 10723 RVA: 0x0006E4F9 File Offset: 0x0006C6F9
		public virtual ITimeScheduleGameDailyRefresh RefreshType
		{
			get
			{
				if (this._RefreshTypeInited)
				{
					return this._RefreshTypeCache;
				}
				this._RefreshTypeInited = true;
				if (this.FbInstance != null)
				{
					this._RefreshTypeCache = ITimeScheduleGameDailyRefresh.Create(this.FbInstance.RefreshType);
				}
				else
				{
					ITimeScheduleGenerateParams_SetValue pocoInterface = this.PocoInterface;
					this._RefreshTypeCache = ((pocoInterface != null) ? pocoInterface.RefreshType : null);
				}
				return this._RefreshTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().RefreshType = value;
				this._RefreshTypeInited = false;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x0006E50E File Offset: 0x0006C70E
		// (set) Token: 0x060029E5 RID: 10725 RVA: 0x0006E539 File Offset: 0x0006C739
		public virtual int MaxCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxCount;
			}
			set
			{
				this.GetOrCreatePoco().MaxCount = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x0006E547 File Offset: 0x0006C747
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x0006E572 File Offset: 0x0006C772
		public virtual int MinCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MinCount;
			}
			set
			{
				this.GetOrCreatePoco().MinCount = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x0006E580 File Offset: 0x0006C780
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x0006E5E1 File Offset: 0x0006C7E1
		public virtual ITimeScheduleRandomSchedulePositionDistribution DistributionType
		{
			get
			{
				if (this._DistributionTypeInited)
				{
					return this._DistributionTypeCache;
				}
				this._DistributionTypeInited = true;
				if (this.FbInstance != null)
				{
					this._DistributionTypeCache = ITimeScheduleRandomSchedulePositionDistribution.Create(this.FbInstance.DistributionType);
				}
				else
				{
					ITimeScheduleGenerateParams_SetValue pocoInterface = this.PocoInterface;
					this._DistributionTypeCache = ((pocoInterface != null) ? pocoInterface.DistributionType : null);
				}
				return this._DistributionTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().DistributionType = value;
				this._DistributionTypeInited = false;
			}
		}

		// Token: 0x04001C0D RID: 7181
		[Nullable(2)]
		protected ITimeScheduleGenerateParams FbInstance;

		// Token: 0x04001C0E RID: 7182
		[Nullable(2)]
		protected ITimeScheduleGenerateParams_SetValue PocoInterface;

		// Token: 0x04001C0F RID: 7183
		private ITimeScheduleGameDailyRefresh _RefreshTypeCache;

		// Token: 0x04001C10 RID: 7184
		private bool _RefreshTypeInited;

		// Token: 0x04001C11 RID: 7185
		private ITimeScheduleRandomSchedulePositionDistribution _DistributionTypeCache;

		// Token: 0x04001C12 RID: 7186
		private bool _DistributionTypeInited;
	}
}
