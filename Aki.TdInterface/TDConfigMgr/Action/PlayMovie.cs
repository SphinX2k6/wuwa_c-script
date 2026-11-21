using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237C RID: 9084
	public class PlayMovie : ActionParams
	{
		// Token: 0x0600C612 RID: 50706 RVA: 0x001C60B4 File Offset: 0x001C42B4
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

		// Token: 0x0600C613 RID: 50707 RVA: 0x001C60EC File Offset: 0x001C42EC
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

		// Token: 0x0600C614 RID: 50708 RVA: 0x001C60FF File Offset: 0x001C42FF
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

		// Token: 0x0600C615 RID: 50709 RVA: 0x001C6114 File Offset: 0x001C4314
		public PlayMovie_SetValue ToSetValue()
		{
			return new PlayMovie_SetValue
			{
				VideoName = this.VideoName,
				BackgroundFade = this.BackgroundFade,
				ProgramSpecialConfig = this.ProgramSpecialConfig,
				Mp4FadeOutTime = this.Mp4FadeOutTime,
				Mp4FadeInTime = this.Mp4FadeInTime,
				BlackBorderFadeOutTime = this.BlackBorderFadeOutTime,
				Mp4FrameEvents = this.Mp4FrameEvents,
				Mp4BlendAnim = this.Mp4BlendAnim
			};
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x0600C616 RID: 50710 RVA: 0x001C6186 File Offset: 0x001C4386
		// (set) Token: 0x0600C617 RID: 50711 RVA: 0x001C61B1 File Offset: 0x001C43B1
		public virtual string VideoName
		{
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
			set
			{
				this.GetOrCreatePoco().VideoName = value;
			}
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x0600C618 RID: 50712 RVA: 0x001C61C0 File Offset: 0x001C43C0
		// (set) Token: 0x0600C619 RID: 50713 RVA: 0x001C6221 File Offset: 0x001C4421
		[Nullable(2)]
		public virtual IMovieBackgroundFadeData BackgroundFade
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BackgroundFade = value;
				this._BackgroundFadeInited = false;
			}
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x0600C61A RID: 50714 RVA: 0x001C6238 File Offset: 0x001C4438
		// (set) Token: 0x0600C61B RID: 50715 RVA: 0x001C6299 File Offset: 0x001C4499
		[Nullable(2)]
		public virtual IMp4UiReplaceMaterial ProgramSpecialConfig
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ProgramSpecialConfig = value;
				this._ProgramSpecialConfigInited = false;
			}
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x0600C61C RID: 50716 RVA: 0x001C62B0 File Offset: 0x001C44B0
		// (set) Token: 0x0600C61D RID: 50717 RVA: 0x001C62EA File Offset: 0x001C44EA
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

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x0600C61E RID: 50718 RVA: 0x001C62F8 File Offset: 0x001C44F8
		// (set) Token: 0x0600C61F RID: 50719 RVA: 0x001C6332 File Offset: 0x001C4532
		public virtual float? Mp4FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mp4FadeInTime;
				}
				PlayMovie_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Mp4FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().Mp4FadeInTime = value;
			}
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0600C620 RID: 50720 RVA: 0x001C6340 File Offset: 0x001C4540
		// (set) Token: 0x0600C621 RID: 50721 RVA: 0x001C637A File Offset: 0x001C457A
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

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x0600C622 RID: 50722 RVA: 0x001C6388 File Offset: 0x001C4588
		// (set) Token: 0x0600C623 RID: 50723 RVA: 0x001C641B File Offset: 0x001C461B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IMp4FrameEvent> Mp4FrameEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Mp4FrameEvents = value;
				this._Mp4FrameEventsInited = false;
			}
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x0600C624 RID: 50724 RVA: 0x001C6430 File Offset: 0x001C4630
		// (set) Token: 0x0600C625 RID: 50725 RVA: 0x001C6491 File Offset: 0x001C4691
		[Nullable(2)]
		public virtual SetBlendAnim Mp4BlendAnim
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Mp4BlendAnim = value;
				this._Mp4BlendAnimInited = false;
			}
		}

		// Token: 0x040075D7 RID: 30167
		[Nullable(2)]
		protected new PlayMovie FbInstance;

		// Token: 0x040075D8 RID: 30168
		[Nullable(2)]
		protected PlayMovie_SetValue PocoInterface;

		// Token: 0x040075D9 RID: 30169
		private IMovieBackgroundFadeData _BackgroundFadeCache;

		// Token: 0x040075DA RID: 30170
		private bool _BackgroundFadeInited;

		// Token: 0x040075DB RID: 30171
		private IMp4UiReplaceMaterial _ProgramSpecialConfigCache;

		// Token: 0x040075DC RID: 30172
		private bool _ProgramSpecialConfigInited;

		// Token: 0x040075DD RID: 30173
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMp4FrameEvent> _Mp4FrameEventsCache;

		// Token: 0x040075DE RID: 30174
		private bool _Mp4FrameEventsInited;

		// Token: 0x040075DF RID: 30175
		private SetBlendAnim _Mp4BlendAnimCache;

		// Token: 0x040075E0 RID: 30176
		private bool _Mp4BlendAnimInited;
	}
}
