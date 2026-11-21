using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EDD RID: 3805
	public class ITimeScheduleFixedIntervalRefresh : ITimeScheduleGenerateParams
	{
		// Token: 0x060055B0 RID: 21936 RVA: 0x000D26E5 File Offset: 0x000D08E5
		public static ITimeScheduleFixedIntervalRefresh Create(ITimeScheduleFixedIntervalRefresh? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleFixedIntervalRefresh
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x060055B1 RID: 21937 RVA: 0x000D2704 File Offset: 0x000D0904
		public override ETimeScheduleGenerateType Type
		{
			get
			{
				return (ETimeScheduleGenerateType)this.Instance.Type;
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x000D2711 File Offset: 0x000D0911
		public virtual ITimeScheduleRefreshInterval RefreshInterval
		{
			get
			{
				if (this._RefreshIntervalInited)
				{
					return this._RefreshIntervalCache;
				}
				this._RefreshIntervalInited = true;
				this._RefreshIntervalCache = ITimeScheduleRefreshInterval.Create(this.Instance.RefreshInterval);
				return this._RefreshIntervalCache;
			}
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x060055B3 RID: 21939 RVA: 0x000D2745 File Offset: 0x000D0945
		public virtual int RefreshCount
		{
			get
			{
				return this.Instance.RefreshCount;
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x000D2752 File Offset: 0x000D0952
		public virtual ITimeScheduleFixedPositions RefreshPosition
		{
			get
			{
				if (this._RefreshPositionInited)
				{
					return this._RefreshPositionCache;
				}
				this._RefreshPositionInited = true;
				this._RefreshPositionCache = ITimeScheduleFixedPositions.Create(this.Instance.RefreshPosition);
				return this._RefreshPositionCache;
			}
		}

		// Token: 0x04003104 RID: 12548
		private ITimeScheduleFixedIntervalRefresh Instance;

		// Token: 0x04003105 RID: 12549
		[Nullable(2)]
		private ITimeScheduleRefreshInterval _RefreshIntervalCache;

		// Token: 0x04003106 RID: 12550
		private bool _RefreshIntervalInited;

		// Token: 0x04003107 RID: 12551
		[Nullable(2)]
		private ITimeScheduleFixedPositions _RefreshPositionCache;

		// Token: 0x04003108 RID: 12552
		private bool _RefreshPositionInited;
	}
}
