using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200133D RID: 4925
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestScheduleConfig
	{
		// Token: 0x060070DF RID: 28895 RVA: 0x00110411 File Offset: 0x0010E611
		[NullableContext(1)]
		public static IQuestScheduleConfig Create(IQuestScheduleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x060070E0 RID: 28896 RVA: 0x00110430 File Offset: 0x0010E630
		public virtual EQuestScheduleUiType UiType
		{
			get
			{
				return (EQuestScheduleUiType)this.Instance.UiType;
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x060070E1 RID: 28897 RVA: 0x0011043D File Offset: 0x0010E63D
		[Nullable(1)]
		public virtual IQuestScheduleMainTitle MainTitle
		{
			[NullableContext(1)]
			get
			{
				if (this._MainTitleInited)
				{
					return this._MainTitleCache;
				}
				this._MainTitleInited = true;
				this._MainTitleCache = IQuestScheduleMainTitle.Create(this.Instance.MainTitle);
				return this._MainTitleCache;
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x060070E2 RID: 28898 RVA: 0x00110474 File Offset: 0x0010E674
		[Nullable(1)]
		public virtual List<IQuestScheduleSubTitle> SubTitles
		{
			[NullableContext(1)]
			get
			{
				if (this._SubTitlesInited)
				{
					return this._SubTitlesCache;
				}
				this._SubTitlesInited = true;
				int subTitlesLength = this.Instance.SubTitlesLength;
				this._SubTitlesCache = new List<IQuestScheduleSubTitle>(subTitlesLength);
				for (int i = 0; i < subTitlesLength; i++)
				{
					this._SubTitlesCache.Add(IQuestScheduleSubTitle.Create(this.Instance.SubTitles(i)));
				}
				return this._SubTitlesCache;
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x060070E3 RID: 28899 RVA: 0x001104DD File Offset: 0x0010E6DD
		public virtual ITrackTarget TrackTarget
		{
			get
			{
				if (this._TrackTargetInited)
				{
					return this._TrackTargetCache;
				}
				this._TrackTargetInited = true;
				this._TrackTargetCache = ITrackTarget.Create(this.Instance.TrackTarget);
				return this._TrackTargetCache;
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x060070E4 RID: 28900 RVA: 0x00110511 File Offset: 0x0010E711
		public virtual ILevelPlayTrackRadius TrackRadius
		{
			get
			{
				if (this._TrackRadiusInited)
				{
					return this._TrackRadiusCache;
				}
				this._TrackRadiusInited = true;
				this._TrackRadiusCache = ILevelPlayTrackRadius.Create(this.Instance.TrackRadius);
				return this._TrackRadiusCache;
			}
		}

		// Token: 0x04004121 RID: 16673
		private IQuestScheduleConfig Instance;

		// Token: 0x04004122 RID: 16674
		private IQuestScheduleMainTitle _MainTitleCache;

		// Token: 0x04004123 RID: 16675
		private bool _MainTitleInited;

		// Token: 0x04004124 RID: 16676
		[Nullable(1)]
		private List<IQuestScheduleSubTitle> _SubTitlesCache;

		// Token: 0x04004125 RID: 16677
		private bool _SubTitlesInited;

		// Token: 0x04004126 RID: 16678
		private ITrackTarget _TrackTargetCache;

		// Token: 0x04004127 RID: 16679
		private bool _TrackTargetInited;

		// Token: 0x04004128 RID: 16680
		private ILevelPlayTrackRadius _TrackRadiusCache;

		// Token: 0x04004129 RID: 16681
		private bool _TrackRadiusInited;
	}
}
