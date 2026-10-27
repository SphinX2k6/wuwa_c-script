using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE1 RID: 3553
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleGenerateParams
	{
		// Token: 0x06005089 RID: 20617 RVA: 0x000C6E1C File Offset: 0x000C501C
		public static ITimeScheduleGenerateParams Create(ITimeScheduleGenerateParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleGenerateParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x0600508A RID: 20618 RVA: 0x000C6E3B File Offset: 0x000C503B
		public virtual ITimeScheduleGameDailyRefresh RefreshType
		{
			get
			{
				if (this._RefreshTypeInited)
				{
					return this._RefreshTypeCache;
				}
				this._RefreshTypeInited = true;
				this._RefreshTypeCache = ITimeScheduleGameDailyRefresh.Create(this.Instance.RefreshType);
				return this._RefreshTypeCache;
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x0600508B RID: 20619 RVA: 0x000C6E6F File Offset: 0x000C506F
		public virtual int MaxCount
		{
			get
			{
				return this.Instance.MaxCount;
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x0600508C RID: 20620 RVA: 0x000C6E7C File Offset: 0x000C507C
		public virtual int MinCount
		{
			get
			{
				return this.Instance.MinCount;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600508D RID: 20621 RVA: 0x000C6E89 File Offset: 0x000C5089
		public virtual ITimeScheduleRandomSchedulePositionDistribution DistributionType
		{
			get
			{
				if (this._DistributionTypeInited)
				{
					return this._DistributionTypeCache;
				}
				this._DistributionTypeInited = true;
				this._DistributionTypeCache = ITimeScheduleRandomSchedulePositionDistribution.Create(this.Instance.DistributionType);
				return this._DistributionTypeCache;
			}
		}

		// Token: 0x04002E3C RID: 11836
		private ITimeScheduleGenerateParams Instance;

		// Token: 0x04002E3D RID: 11837
		[Nullable(2)]
		private ITimeScheduleGameDailyRefresh _RefreshTypeCache;

		// Token: 0x04002E3E RID: 11838
		private bool _RefreshTypeInited;

		// Token: 0x04002E3F RID: 11839
		[Nullable(2)]
		private ITimeScheduleRandomSchedulePositionDistribution _DistributionTypeCache;

		// Token: 0x04002E40 RID: 11840
		private bool _DistributionTypeInited;
	}
}
