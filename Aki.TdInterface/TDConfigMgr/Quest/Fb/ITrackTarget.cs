using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001468 RID: 5224
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackTarget
	{
		// Token: 0x060076D9 RID: 30425 RVA: 0x0011D7A6 File Offset: 0x0011B9A6
		[NullableContext(0)]
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

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x060076DA RID: 30426 RVA: 0x0011D7C5 File Offset: 0x0011B9C5
		[Nullable(0)]
		public virtual ITrackType TrackType
		{
			[NullableContext(0)]
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

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x060076DB RID: 30427 RVA: 0x0011D7F4 File Offset: 0x0011B9F4
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

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x060076DC RID: 30428 RVA: 0x0011D82C File Offset: 0x0011BA2C
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

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x060076DD RID: 30429 RVA: 0x0011D864 File Offset: 0x0011BA64
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

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x060076DE RID: 30430 RVA: 0x0011D89A File Offset: 0x0011BA9A
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

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x060076DF RID: 30431 RVA: 0x0011D8D0 File Offset: 0x0011BAD0
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

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x060076E0 RID: 30432 RVA: 0x0011D906 File Offset: 0x0011BB06
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

		// Token: 0x0400443A RID: 17466
		private ITrackTarget Instance;

		// Token: 0x0400443B RID: 17467
		[Nullable(0)]
		private ITrackType _TrackTypeCache;

		// Token: 0x0400443C RID: 17468
		private bool _TrackTypeInited;

		// Token: 0x0400443D RID: 17469
		private IZaxisViewRange _ZaxisViewRangeCache;

		// Token: 0x0400443E RID: 17470
		private bool _ZaxisViewRangeInited;

		// Token: 0x0400443F RID: 17471
		private ITrackEffectAutoChange _EffectOptionCache;

		// Token: 0x04004440 RID: 17472
		private bool _EffectOptionInited;
	}
}
