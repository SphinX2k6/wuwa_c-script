using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025DC RID: 9692
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayMovie : ActionParams
	{
		// Token: 0x0600D9D9 RID: 55769 RVA: 0x00207C09 File Offset: 0x00205E09
		[NullableContext(1)]
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

		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x0600D9DA RID: 55770 RVA: 0x00207C28 File Offset: 0x00205E28
		[Nullable(1)]
		public virtual string VideoName
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.VideoName;
			}
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x0600D9DB RID: 55771 RVA: 0x00207C35 File Offset: 0x00205E35
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

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x0600D9DC RID: 55772 RVA: 0x00207C69 File Offset: 0x00205E69
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

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x0600D9DD RID: 55773 RVA: 0x00207CA0 File Offset: 0x00205EA0
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

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x0600D9DE RID: 55774 RVA: 0x00207CD8 File Offset: 0x00205ED8
		public virtual float? BlackBorderFadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.BlackBorderFadeOutTime);
			}
		}

		// Token: 0x17003FE8 RID: 16360
		// (get) Token: 0x0600D9DF RID: 55775 RVA: 0x00207D10 File Offset: 0x00205F10
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
				if ((this.Instance.NullMask & 4) == 0)
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

		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x0600D9E0 RID: 55776 RVA: 0x00207D8A File Offset: 0x00205F8A
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

		// Token: 0x040078FA RID: 30970
		private IPlayMovie Instance;

		// Token: 0x040078FB RID: 30971
		private IMovieBackgroundFadeData _BackgroundFadeCache;

		// Token: 0x040078FC RID: 30972
		private bool _BackgroundFadeInited;

		// Token: 0x040078FD RID: 30973
		private IMp4UiReplaceMaterial _ProgramSpecialConfigCache;

		// Token: 0x040078FE RID: 30974
		private bool _ProgramSpecialConfigInited;

		// Token: 0x040078FF RID: 30975
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMp4FrameEvent> _Mp4FrameEventsCache;

		// Token: 0x04007900 RID: 30976
		private bool _Mp4FrameEventsInited;

		// Token: 0x04007901 RID: 30977
		private SetBlendAnim _Mp4BlendAnimCache;

		// Token: 0x04007902 RID: 30978
		private bool _Mp4BlendAnimInited;
	}
}
