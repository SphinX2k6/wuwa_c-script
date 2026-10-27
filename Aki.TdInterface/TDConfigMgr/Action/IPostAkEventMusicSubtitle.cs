using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D3A RID: 7482
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventMusicSubtitle : IPostAkEventType
	{
		// Token: 0x0600A089 RID: 41097 RVA: 0x0016E338 File Offset: 0x0016C538
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

		// Token: 0x0600A08A RID: 41098 RVA: 0x0016E370 File Offset: 0x0016C570
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

		// Token: 0x0600A08B RID: 41099 RVA: 0x0016E383 File Offset: 0x0016C583
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

		// Token: 0x0600A08C RID: 41100 RVA: 0x0016E398 File Offset: 0x0016C598
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

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600A08D RID: 41101 RVA: 0x0016E3E6 File Offset: 0x0016C5E6
		// (set) Token: 0x0600A08E RID: 41102 RVA: 0x0016E411 File Offset: 0x0016C611
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

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600A08F RID: 41103 RVA: 0x0016E41F File Offset: 0x0016C61F
		// (set) Token: 0x0600A090 RID: 41104 RVA: 0x0016E44A File Offset: 0x0016C64A
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

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600A091 RID: 41105 RVA: 0x0016E458 File Offset: 0x0016C658
		// (set) Token: 0x0600A092 RID: 41106 RVA: 0x0016E483 File Offset: 0x0016C683
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

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600A093 RID: 41107 RVA: 0x0016E494 File Offset: 0x0016C694
		// (set) Token: 0x0600A094 RID: 41108 RVA: 0x0016E4CE File Offset: 0x0016C6CE
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

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600A095 RID: 41109 RVA: 0x0016E4DC File Offset: 0x0016C6DC
		// (set) Token: 0x0600A096 RID: 41110 RVA: 0x0016E516 File Offset: 0x0016C716
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

		// Token: 0x040060BF RID: 24767
		[Nullable(2)]
		protected new IPostAkEventMusicSubtitle FbInstance;

		// Token: 0x040060C0 RID: 24768
		[Nullable(2)]
		protected new IPostAkEventMusicSubtitle_SetValue PocoInterface;
	}
}
