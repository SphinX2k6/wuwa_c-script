using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F4B RID: 8011
	public class IPostAkEventMusicSubtitle : IPostAkEventType
	{
		// Token: 0x0600AA75 RID: 43637 RVA: 0x0018275C File Offset: 0x0018095C
		private IPostAkEventMusicSubtitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPostAkEventMusicSubtitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPostAkEventMusicSubtitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPostAkEventMusicSubtitle_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x00182794 File Offset: 0x00180994
		public static IPostAkEventMusicSubtitle Create([Nullable(2)] IPostAkEventMusicSubtitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventMusicSubtitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x001827A7 File Offset: 0x001809A7
		public static IPostAkEventMusicSubtitle CreateFromSetValue([Nullable(2)] IPostAkEventMusicSubtitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPostAkEventMusicSubtitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA78 RID: 43640 RVA: 0x001827BC File Offset: 0x001809BC
		public new IPostAkEventMusicSubtitle_SetValue ToSetValue()
		{
			return new IPostAkEventMusicSubtitle_SetValue
			{
				Type = this.Type,
				MusicSubtitleGroupTag = this.MusicSubtitleGroupTag,
				AkEvent = this.AkEvent,
				IsLoop = this.IsLoop,
				IsEndAkEvent = this.IsEndAkEvent
			};
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600AA79 RID: 43641 RVA: 0x0018280A File Offset: 0x00180A0A
		// (set) Token: 0x0600AA7A RID: 43642 RVA: 0x00182835 File Offset: 0x00180A35
		public override EPostAkEvent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPostAkEvent.Global;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600AA7B RID: 43643 RVA: 0x00182843 File Offset: 0x00180A43
		// (set) Token: 0x0600AA7C RID: 43644 RVA: 0x0018286E File Offset: 0x00180A6E
		public virtual string MusicSubtitleGroupTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MusicSubtitleGroupTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MusicSubtitleGroupTag;
			}
			set
			{
				this.GetOrCreatePoco().MusicSubtitleGroupTag = value;
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600AA7D RID: 43645 RVA: 0x0018287C File Offset: 0x00180A7C
		// (set) Token: 0x0600AA7E RID: 43646 RVA: 0x001828A7 File Offset: 0x00180AA7
		public virtual string AkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AkEvent;
			}
			set
			{
				this.GetOrCreatePoco().AkEvent = value;
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600AA7F RID: 43647 RVA: 0x001828B8 File Offset: 0x00180AB8
		// (set) Token: 0x0600AA80 RID: 43648 RVA: 0x001828F2 File Offset: 0x00180AF2
		public virtual bool? IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				IPostAkEventMusicSubtitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600AA81 RID: 43649 RVA: 0x00182900 File Offset: 0x00180B00
		// (set) Token: 0x0600AA82 RID: 43650 RVA: 0x0018293A File Offset: 0x00180B3A
		public virtual bool? IsEndAkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEndAkEvent;
				}
				IPostAkEventMusicSubtitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsEndAkEvent;
			}
			set
			{
				this.GetOrCreatePoco().IsEndAkEvent = value;
			}
		}

		// Token: 0x0400663B RID: 26171
		[Nullable(2)]
		protected new IPostAkEventMusicSubtitle FbInstance;

		// Token: 0x0400663C RID: 26172
		[Nullable(2)]
		protected new IPostAkEventMusicSubtitle_SetValue PocoInterface;
	}
}
