using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200148D RID: 5261
	public class IQuestScheduleConfig
	{
		// Token: 0x0600777F RID: 30591 RVA: 0x0011E97D File Offset: 0x0011CB7D
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

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x06007780 RID: 30592 RVA: 0x0011E99C File Offset: 0x0011CB9C
		public virtual EQuestScheduleUiType UiType
		{
			get
			{
				return (EQuestScheduleUiType)this.Instance.UiType;
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x06007781 RID: 30593 RVA: 0x0011E9A9 File Offset: 0x0011CBA9
		public virtual IQuestScheduleMainTitle MainTitle
		{
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

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x06007782 RID: 30594 RVA: 0x0011E9E0 File Offset: 0x0011CBE0
		public virtual List<IQuestScheduleSubTitle> SubTitles
		{
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

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x06007783 RID: 30595 RVA: 0x0011EA49 File Offset: 0x0011CC49
		[Nullable(2)]
		public virtual ITrackTarget TrackTarget
		{
			[NullableContext(2)]
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

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x06007784 RID: 30596 RVA: 0x0011EA7D File Offset: 0x0011CC7D
		[Nullable(2)]
		public virtual ILevelPlayTrackRadius TrackRadius
		{
			[NullableContext(2)]
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

		// Token: 0x0400449D RID: 17565
		private IQuestScheduleConfig Instance;

		// Token: 0x0400449E RID: 17566
		[Nullable(2)]
		private IQuestScheduleMainTitle _MainTitleCache;

		// Token: 0x0400449F RID: 17567
		private bool _MainTitleInited;

		// Token: 0x040044A0 RID: 17568
		private List<IQuestScheduleSubTitle> _SubTitlesCache;

		// Token: 0x040044A1 RID: 17569
		private bool _SubTitlesInited;

		// Token: 0x040044A2 RID: 17570
		[Nullable(2)]
		private ITrackTarget _TrackTargetCache;

		// Token: 0x040044A3 RID: 17571
		private bool _TrackTargetInited;

		// Token: 0x040044A4 RID: 17572
		[Nullable(2)]
		private ILevelPlayTrackRadius _TrackRadiusCache;

		// Token: 0x040044A5 RID: 17573
		private bool _TrackRadiusInited;
	}
}
