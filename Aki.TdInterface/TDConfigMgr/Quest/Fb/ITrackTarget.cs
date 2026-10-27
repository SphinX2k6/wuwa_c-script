using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001318 RID: 4888
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackTarget
	{
		// Token: 0x06007039 RID: 28729 RVA: 0x0010F23A File Offset: 0x0010D43A
		[NullableContext(1)]
		public static ITrackTarget Create(ITrackTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x0600703A RID: 28730 RVA: 0x0010F259 File Offset: 0x0010D459
		[Nullable(1)]
		public virtual ITrackType TrackType
		{
			[NullableContext(1)]
			get
			{
				if (this._TrackTypeInited)
				{
					return this._TrackTypeCache;
				}
				this._TrackTypeInited = true;
				this._TrackTypeCache = QuestReadHelper.ReadITrackTarget_TrackType(this.Instance);
				return this._TrackTypeCache;
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x0600703B RID: 28731 RVA: 0x0010F288 File Offset: 0x0010D488
		public virtual ETrackViewMode? TrackViewMode
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new ETrackViewMode?((ETrackViewMode)this.Instance.TrackViewMode);
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x0600703C RID: 28732 RVA: 0x0010F2C0 File Offset: 0x0010D4C0
		public virtual float? Range
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Range);
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x0600703D RID: 28733 RVA: 0x0010F2F8 File Offset: 0x0010D4F8
		public virtual float? ViewRange
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ViewRange);
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x0600703E RID: 28734 RVA: 0x0010F32E File Offset: 0x0010D52E
		public virtual IZaxisViewRange ZaxisViewRange
		{
			get
			{
				if (this._ZaxisViewRangeInited)
				{
					return this._ZaxisViewRangeCache;
				}
				this._ZaxisViewRangeInited = true;
				this._ZaxisViewRangeCache = IZaxisViewRange.Create(this.Instance.ZaxisViewRange);
				return this._ZaxisViewRangeCache;
			}
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x0600703F RID: 28735 RVA: 0x0010F364 File Offset: 0x0010D564
		public virtual ETrackEffect? Effect
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new ETrackEffect?((ETrackEffect)this.Instance.Effect);
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x06007040 RID: 28736 RVA: 0x0010F39A File Offset: 0x0010D59A
		public virtual ITrackEffectAutoChange EffectOption
		{
			get
			{
				if (this._EffectOptionInited)
				{
					return this._EffectOptionCache;
				}
				this._EffectOptionInited = true;
				this._EffectOptionCache = ITrackEffectAutoChange.Create(this.Instance.EffectOption);
				return this._EffectOptionCache;
			}
		}

		// Token: 0x040040BE RID: 16574
		private ITrackTarget Instance;

		// Token: 0x040040BF RID: 16575
		[Nullable(1)]
		private ITrackType _TrackTypeCache;

		// Token: 0x040040C0 RID: 16576
		private bool _TrackTypeInited;

		// Token: 0x040040C1 RID: 16577
		private IZaxisViewRange _ZaxisViewRangeCache;

		// Token: 0x040040C2 RID: 16578
		private bool _ZaxisViewRangeInited;

		// Token: 0x040040C3 RID: 16579
		private ITrackEffectAutoChange _EffectOptionCache;

		// Token: 0x040040C4 RID: 16580
		private bool _EffectOptionInited;
	}
}
