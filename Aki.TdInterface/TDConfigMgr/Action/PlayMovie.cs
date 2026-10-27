using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200211B RID: 8475
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayMovie : ActionParams
	{
		// Token: 0x0600BA86 RID: 47750 RVA: 0x001AEF54 File Offset: 0x001AD154
		[NullableContext(1)]
		private PlayMovie_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayMovie 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayMovie_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayMovie_SetValue());
			}
			return result;
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x001AEF8C File Offset: 0x001AD18C
		[NullableContext(1)]
		public static PlayMovie Create([Nullable(2)] PlayMovie instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayMovie
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BA88 RID: 47752 RVA: 0x001AEF9F File Offset: 0x001AD19F
		[NullableContext(1)]
		public static PlayMovie CreateFromSetValue([Nullable(2)] PlayMovie_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayMovie
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BA89 RID: 47753 RVA: 0x001AEFB4 File Offset: 0x001AD1B4
		[NullableContext(1)]
		public PlayMovie_SetValue ToSetValue()
		{
			return new PlayMovie_SetValue
			{
				VideoName = this.VideoName,
				BackgroundFade = this.BackgroundFade,
				ProgramSpecialConfig = this.ProgramSpecialConfig,
				Mp4FadeOutTime = this.Mp4FadeOutTime,
				BlackBorderFadeOutTime = this.BlackBorderFadeOutTime,
				Mp4FrameEvents = this.Mp4FrameEvents,
				Mp4BlendAnim = this.Mp4BlendAnim
			};
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600BA8A RID: 47754 RVA: 0x001AF01A File Offset: 0x001AD21A
		// (set) Token: 0x0600BA8B RID: 47755 RVA: 0x001AF045 File Offset: 0x001AD245
		[Nullable(1)]
		public virtual string VideoName
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VideoName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.VideoName;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().VideoName = value;
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600BA8C RID: 47756 RVA: 0x001AF054 File Offset: 0x001AD254
		// (set) Token: 0x0600BA8D RID: 47757 RVA: 0x001AF0B5 File Offset: 0x001AD2B5
		public virtual IMovieBackgroundFadeData BackgroundFade
		{
			get
			{
				if (this._BackgroundFadeInited)
				{
					return this._BackgroundFadeCache;
				}
				this._BackgroundFadeInited = true;
				if (this.FbInstance != null)
				{
					this._BackgroundFadeCache = IMovieBackgroundFadeData.Create(this.FbInstance.BackgroundFade);
				}
				else
				{
					PlayMovie_SetValue pocoInterface = this.PocoInterface;
					this._BackgroundFadeCache = ((pocoInterface != null) ? pocoInterface.BackgroundFade : null);
				}
				return this._BackgroundFadeCache;
			}
			set
			{
				this.GetOrCreatePoco().BackgroundFade = value;
				this._BackgroundFadeInited = false;
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600BA8E RID: 47758 RVA: 0x001AF0CC File Offset: 0x001AD2CC
		// (set) Token: 0x0600BA8F RID: 47759 RVA: 0x001AF12D File Offset: 0x001AD32D
		public virtual IMp4UiReplaceMaterial ProgramSpecialConfig
		{
			get
			{
				if (this._ProgramSpecialConfigInited)
				{
					return this._ProgramSpecialConfigCache;
				}
				this._ProgramSpecialConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ProgramSpecialConfigCache = IMp4UiReplaceMaterial.Create(this.FbInstance.ProgramSpecialConfig);
				}
				else
				{
					PlayMovie_SetValue pocoInterface = this.PocoInterface;
					this._ProgramSpecialConfigCache = ((pocoInterface != null) ? pocoInterface.ProgramSpecialConfig : null);
				}
				return this._ProgramSpecialConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().ProgramSpecialConfig = value;
				this._ProgramSpecialConfigInited = false;
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600BA90 RID: 47760 RVA: 0x001AF144 File Offset: 0x001AD344
		// (set) Token: 0x0600BA91 RID: 47761 RVA: 0x001AF17E File Offset: 0x001AD37E
		public virtual float? Mp4FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mp4FadeOutTime;
				}
				PlayMovie_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Mp4FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().Mp4FadeOutTime = value;
			}
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600BA92 RID: 47762 RVA: 0x001AF18C File Offset: 0x001AD38C
		// (set) Token: 0x0600BA93 RID: 47763 RVA: 0x001AF1C6 File Offset: 0x001AD3C6
		public virtual float? BlackBorderFadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlackBorderFadeOutTime;
				}
				PlayMovie_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BlackBorderFadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().BlackBorderFadeOutTime = value;
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600BA94 RID: 47764 RVA: 0x001AF1D4 File Offset: 0x001AD3D4
		// (set) Token: 0x0600BA95 RID: 47765 RVA: 0x001AF267 File Offset: 0x001AD467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IMp4FrameEvent> Mp4FrameEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._Mp4FrameEventsInited)
				{
					return this._Mp4FrameEventsCache;
				}
				this._Mp4FrameEventsInited = true;
				if (this.FbInstance != null)
				{
					List<IMp4FrameEvent> mp4FrameEvents = this.FbInstance.Mp4FrameEvents;
					if (mp4FrameEvents != null)
					{
						this._Mp4FrameEventsCache = new List<IMp4FrameEvent>(mp4FrameEvents.Count);
						for (int i = 0; i < mp4FrameEvents.Count; i++)
						{
							this._Mp4FrameEventsCache.Add(IMp4FrameEvent.Create(mp4FrameEvents[i]));
						}
					}
				}
				else
				{
					PlayMovie_SetValue pocoInterface = this.PocoInterface;
					this._Mp4FrameEventsCache = ((pocoInterface != null) ? pocoInterface.Mp4FrameEvents : null);
				}
				return this._Mp4FrameEventsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Mp4FrameEvents = value;
				this._Mp4FrameEventsInited = false;
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600BA96 RID: 47766 RVA: 0x001AF27C File Offset: 0x001AD47C
		// (set) Token: 0x0600BA97 RID: 47767 RVA: 0x001AF2DD File Offset: 0x001AD4DD
		public virtual SetBlendAnim Mp4BlendAnim
		{
			get
			{
				if (this._Mp4BlendAnimInited)
				{
					return this._Mp4BlendAnimCache;
				}
				this._Mp4BlendAnimInited = true;
				if (this.FbInstance != null)
				{
					this._Mp4BlendAnimCache = SetBlendAnim.Create(this.FbInstance.Mp4BlendAnim);
				}
				else
				{
					PlayMovie_SetValue pocoInterface = this.PocoInterface;
					this._Mp4BlendAnimCache = ((pocoInterface != null) ? pocoInterface.Mp4BlendAnim : null);
				}
				return this._Mp4BlendAnimCache;
			}
			set
			{
				this.GetOrCreatePoco().Mp4BlendAnim = value;
				this._Mp4BlendAnimInited = false;
			}
		}

		// Token: 0x04006FA3 RID: 28579
		protected new PlayMovie FbInstance;

		// Token: 0x04006FA4 RID: 28580
		protected PlayMovie_SetValue PocoInterface;

		// Token: 0x04006FA5 RID: 28581
		[Nullable(1)]
		private IMovieBackgroundFadeData _BackgroundFadeCache;

		// Token: 0x04006FA6 RID: 28582
		private bool _BackgroundFadeInited;

		// Token: 0x04006FA7 RID: 28583
		[Nullable(1)]
		private IMp4UiReplaceMaterial _ProgramSpecialConfigCache;

		// Token: 0x04006FA8 RID: 28584
		private bool _ProgramSpecialConfigInited;

		// Token: 0x04006FA9 RID: 28585
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMp4FrameEvent> _Mp4FrameEventsCache;

		// Token: 0x04006FAA RID: 28586
		private bool _Mp4FrameEventsInited;

		// Token: 0x04006FAB RID: 28587
		[Nullable(1)]
		private SetBlendAnim _Mp4BlendAnimCache;

		// Token: 0x04006FAC RID: 28588
		private bool _Mp4BlendAnimInited;
	}
}
