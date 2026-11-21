using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289B RID: 10395
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayMovie : ActionParams
	{
		// Token: 0x0600E7A1 RID: 59297 RVA: 0x002242BD File Offset: 0x002224BD
		[NullableContext(0)]
		public static PlayMovie Create(IPlayMovie? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayMovie
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004319 RID: 17177
		// (get) Token: 0x0600E7A2 RID: 59298 RVA: 0x002242DC File Offset: 0x002224DC
		[Nullable(0)]
		public virtual string VideoName
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.VideoName;
			}
		}

		// Token: 0x1700431A RID: 17178
		// (get) Token: 0x0600E7A3 RID: 59299 RVA: 0x002242E9 File Offset: 0x002224E9
		public virtual IMovieBackgroundFadeData BackgroundFade
		{
			get
			{
				if (this._BackgroundFadeInited)
				{
					return this._BackgroundFadeCache;
				}
				this._BackgroundFadeInited = true;
				this._BackgroundFadeCache = IMovieBackgroundFadeData.Create(this.Instance.BackgroundFade);
				return this._BackgroundFadeCache;
			}
		}

		// Token: 0x1700431B RID: 17179
		// (get) Token: 0x0600E7A4 RID: 59300 RVA: 0x0022431D File Offset: 0x0022251D
		public virtual IMp4UiReplaceMaterial ProgramSpecialConfig
		{
			get
			{
				if (this._ProgramSpecialConfigInited)
				{
					return this._ProgramSpecialConfigCache;
				}
				this._ProgramSpecialConfigInited = true;
				this._ProgramSpecialConfigCache = IMp4UiReplaceMaterial.Create(this.Instance.ProgramSpecialConfig);
				return this._ProgramSpecialConfigCache;
			}
		}

		// Token: 0x1700431C RID: 17180
		// (get) Token: 0x0600E7A5 RID: 59301 RVA: 0x00224354 File Offset: 0x00222554
		public virtual float? Mp4FadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Mp4FadeOutTime);
			}
		}

		// Token: 0x1700431D RID: 17181
		// (get) Token: 0x0600E7A6 RID: 59302 RVA: 0x0022438C File Offset: 0x0022258C
		public virtual float? Mp4FadeInTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Mp4FadeInTime);
			}
		}

		// Token: 0x1700431E RID: 17182
		// (get) Token: 0x0600E7A7 RID: 59303 RVA: 0x002243C4 File Offset: 0x002225C4
		public virtual float? BlackBorderFadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.BlackBorderFadeOutTime);
			}
		}

		// Token: 0x1700431F RID: 17183
		// (get) Token: 0x0600E7A8 RID: 59304 RVA: 0x002243FC File Offset: 0x002225FC
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
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int mp4FrameEventsLength = this.Instance.Mp4FrameEventsLength;
				this._Mp4FrameEventsCache = new List<IMp4FrameEvent>(mp4FrameEventsLength);
				for (int i = 0; i < mp4FrameEventsLength; i++)
				{
					this._Mp4FrameEventsCache.Add(IMp4FrameEvent.Create(this.Instance.Mp4FrameEvents(i)));
				}
				return this._Mp4FrameEventsCache;
			}
		}

		// Token: 0x17004320 RID: 17184
		// (get) Token: 0x0600E7A9 RID: 59305 RVA: 0x00224476 File Offset: 0x00222676
		public virtual SetBlendAnim Mp4BlendAnim
		{
			get
			{
				if (this._Mp4BlendAnimInited)
				{
					return this._Mp4BlendAnimCache;
				}
				this._Mp4BlendAnimInited = true;
				this._Mp4BlendAnimCache = SetBlendAnim.Create(this.Instance.Mp4BlendAnim);
				return this._Mp4BlendAnimCache;
			}
		}

		// Token: 0x04007F91 RID: 32657
		private IPlayMovie Instance;

		// Token: 0x04007F92 RID: 32658
		private IMovieBackgroundFadeData _BackgroundFadeCache;

		// Token: 0x04007F93 RID: 32659
		private bool _BackgroundFadeInited;

		// Token: 0x04007F94 RID: 32660
		private IMp4UiReplaceMaterial _ProgramSpecialConfigCache;

		// Token: 0x04007F95 RID: 32661
		private bool _ProgramSpecialConfigInited;

		// Token: 0x04007F96 RID: 32662
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMp4FrameEvent> _Mp4FrameEventsCache;

		// Token: 0x04007F97 RID: 32663
		private bool _Mp4FrameEventsInited;

		// Token: 0x04007F98 RID: 32664
		private SetBlendAnim _Mp4BlendAnimCache;

		// Token: 0x04007F99 RID: 32665
		private bool _Mp4BlendAnimInited;
	}
}
