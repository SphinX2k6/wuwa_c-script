using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001306 RID: 4870
	public class ITrackTarget
	{
		// Token: 0x06006DC1 RID: 28097 RVA: 0x00105510 File Offset: 0x00103710
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

		// Token: 0x06006DC2 RID: 28098 RVA: 0x00105548 File Offset: 0x00103748
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

		// Token: 0x06006DC3 RID: 28099 RVA: 0x0010555B File Offset: 0x0010375B
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

		// Token: 0x06006DC4 RID: 28100 RVA: 0x00105570 File Offset: 0x00103770
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

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x06006DC5 RID: 28101 RVA: 0x001055D6 File Offset: 0x001037D6
		// (set) Token: 0x06006DC6 RID: 28102 RVA: 0x001055FD File Offset: 0x001037FD
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

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x06006DC7 RID: 28103 RVA: 0x0010560C File Offset: 0x0010380C
		// (set) Token: 0x06006DC8 RID: 28104 RVA: 0x00105646 File Offset: 0x00103846
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

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x06006DC9 RID: 28105 RVA: 0x00105654 File Offset: 0x00103854
		// (set) Token: 0x06006DCA RID: 28106 RVA: 0x0010568E File Offset: 0x0010388E
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

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x06006DCB RID: 28107 RVA: 0x0010569C File Offset: 0x0010389C
		// (set) Token: 0x06006DCC RID: 28108 RVA: 0x001056D6 File Offset: 0x001038D6
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

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x06006DCD RID: 28109 RVA: 0x001056E4 File Offset: 0x001038E4
		// (set) Token: 0x06006DCE RID: 28110 RVA: 0x00105745 File Offset: 0x00103945
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

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x06006DCF RID: 28111 RVA: 0x0010575C File Offset: 0x0010395C
		// (set) Token: 0x06006DD0 RID: 28112 RVA: 0x00105796 File Offset: 0x00103996
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

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x06006DD1 RID: 28113 RVA: 0x001057A4 File Offset: 0x001039A4
		// (set) Token: 0x06006DD2 RID: 28114 RVA: 0x00105805 File Offset: 0x00103A05
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

		// Token: 0x0400418B RID: 16779
		[Nullable(2)]
		protected ITrackTarget FbInstance;

		// Token: 0x0400418C RID: 16780
		[Nullable(2)]
		protected ITrackTarget_SetValue PocoInterface;

		// Token: 0x0400418D RID: 16781
		private IZaxisViewRange _ZaxisViewRangeCache;

		// Token: 0x0400418E RID: 16782
		private bool _ZaxisViewRangeInited;

		// Token: 0x0400418F RID: 16783
		private ITrackEffectAutoChange _EffectOptionCache;

		// Token: 0x04004190 RID: 16784
		private bool _EffectOptionInited;
	}
}
