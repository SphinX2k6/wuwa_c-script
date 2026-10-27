using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011CA RID: 4554
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackTarget
	{
		// Token: 0x06006780 RID: 26496 RVA: 0x000F7C04 File Offset: 0x000F5E04
		private ITrackTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x000F7C3C File Offset: 0x000F5E3C
		public static ITrackTarget Create([Nullable(2)] ITrackTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x000F7C4F File Offset: 0x000F5E4F
		public static ITrackTarget CreateFromSetValue([Nullable(2)] ITrackTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x000F7C64 File Offset: 0x000F5E64
		public ITrackTarget_SetValue ToSetValue()
		{
			return new ITrackTarget_SetValue
			{
				TrackType = this.TrackType,
				TrackViewMode = this.TrackViewMode,
				Range = this.Range,
				ViewRange = this.ViewRange,
				ZaxisViewRange = this.ZaxisViewRange,
				Effect = this.Effect,
				EffectOption = this.EffectOption
			};
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06006784 RID: 26500 RVA: 0x000F7CCA File Offset: 0x000F5ECA
		// (set) Token: 0x06006785 RID: 26501 RVA: 0x000F7CF1 File Offset: 0x000F5EF1
		public virtual ITrackType TrackType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrackType;
				}
				ITrackTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TrackType;
			}
			set
			{
				this.GetOrCreatePoco().TrackType = value;
			}
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06006786 RID: 26502 RVA: 0x000F7D00 File Offset: 0x000F5F00
		// (set) Token: 0x06006787 RID: 26503 RVA: 0x000F7D3A File Offset: 0x000F5F3A
		public virtual ETrackViewMode? TrackViewMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrackViewMode;
				}
				ITrackTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TrackViewMode;
			}
			set
			{
				this.GetOrCreatePoco().TrackViewMode = value;
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06006788 RID: 26504 RVA: 0x000F7D48 File Offset: 0x000F5F48
		// (set) Token: 0x06006789 RID: 26505 RVA: 0x000F7D82 File Offset: 0x000F5F82
		public virtual float? Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				ITrackTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x0600678A RID: 26506 RVA: 0x000F7D90 File Offset: 0x000F5F90
		// (set) Token: 0x0600678B RID: 26507 RVA: 0x000F7DCA File Offset: 0x000F5FCA
		public virtual float? ViewRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ViewRange;
				}
				ITrackTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ViewRange;
			}
			set
			{
				this.GetOrCreatePoco().ViewRange = value;
			}
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x0600678C RID: 26508 RVA: 0x000F7DD8 File Offset: 0x000F5FD8
		// (set) Token: 0x0600678D RID: 26509 RVA: 0x000F7E39 File Offset: 0x000F6039
		[Nullable(2)]
		public virtual IZaxisViewRange ZaxisViewRange
		{
			[NullableContext(2)]
			get
			{
				if (this._ZaxisViewRangeInited)
				{
					return this._ZaxisViewRangeCache;
				}
				this._ZaxisViewRangeInited = true;
				if (this.FbInstance != null)
				{
					this._ZaxisViewRangeCache = IZaxisViewRange.Create(this.FbInstance.ZaxisViewRange);
				}
				else
				{
					ITrackTarget_SetValue pocoInterface = this.PocoInterface;
					this._ZaxisViewRangeCache = ((pocoInterface != null) ? pocoInterface.ZaxisViewRange : null);
				}
				return this._ZaxisViewRangeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ZaxisViewRange = value;
				this._ZaxisViewRangeInited = false;
			}
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x0600678E RID: 26510 RVA: 0x000F7E50 File Offset: 0x000F6050
		// (set) Token: 0x0600678F RID: 26511 RVA: 0x000F7E8A File Offset: 0x000F608A
		public virtual ETrackEffect? Effect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Effect;
				}
				ITrackTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Effect;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
			}
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06006790 RID: 26512 RVA: 0x000F7E98 File Offset: 0x000F6098
		// (set) Token: 0x06006791 RID: 26513 RVA: 0x000F7EF9 File Offset: 0x000F60F9
		[Nullable(2)]
		public virtual ITrackEffectAutoChange EffectOption
		{
			[NullableContext(2)]
			get
			{
				if (this._EffectOptionInited)
				{
					return this._EffectOptionCache;
				}
				this._EffectOptionInited = true;
				if (this.FbInstance != null)
				{
					this._EffectOptionCache = ITrackEffectAutoChange.Create(this.FbInstance.EffectOption);
				}
				else
				{
					ITrackTarget_SetValue pocoInterface = this.PocoInterface;
					this._EffectOptionCache = ((pocoInterface != null) ? pocoInterface.EffectOption : null);
				}
				return this._EffectOptionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EffectOption = value;
				this._EffectOptionInited = false;
			}
		}

		// Token: 0x04003E1D RID: 15901
		[Nullable(2)]
		protected ITrackTarget FbInstance;

		// Token: 0x04003E1E RID: 15902
		[Nullable(2)]
		protected ITrackTarget_SetValue PocoInterface;

		// Token: 0x04003E1F RID: 15903
		private IZaxisViewRange _ZaxisViewRangeCache;

		// Token: 0x04003E20 RID: 15904
		private bool _ZaxisViewRangeInited;

		// Token: 0x04003E21 RID: 15905
		private ITrackEffectAutoChange _EffectOptionCache;

		// Token: 0x04003E22 RID: 15906
		private bool _EffectOptionInited;
	}
}
