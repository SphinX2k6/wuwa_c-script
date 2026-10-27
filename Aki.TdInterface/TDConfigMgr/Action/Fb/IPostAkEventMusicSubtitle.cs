using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002822 RID: 10274
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventMusicSubtitle : IPostAkEventType
	{
		// Token: 0x0600E3DC RID: 58332 RVA: 0x00218FE8 File Offset: 0x002171E8
		public static IPostAkEventMusicSubtitle Create(IPostAkEventMusicSubtitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventMusicSubtitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700455A RID: 17754
		// (get) Token: 0x0600E3DD RID: 58333 RVA: 0x00219007 File Offset: 0x00217207
		public override EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x1700455B RID: 17755
		// (get) Token: 0x0600E3DE RID: 58334 RVA: 0x00219014 File Offset: 0x00217214
		public virtual string MusicSubtitleGroupTag
		{
			get
			{
				return this.Instance.MusicSubtitleGroupTag;
			}
		}

		// Token: 0x1700455C RID: 17756
		// (get) Token: 0x0600E3DF RID: 58335 RVA: 0x00219021 File Offset: 0x00217221
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x1700455D RID: 17757
		// (get) Token: 0x0600E3E0 RID: 58336 RVA: 0x00219030 File Offset: 0x00217230
		public virtual bool? IsLoop
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLoop);
			}
		}

		// Token: 0x1700455E RID: 17758
		// (get) Token: 0x0600E3E1 RID: 58337 RVA: 0x00219068 File Offset: 0x00217268
		public virtual bool? IsEndAkEvent
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEndAkEvent);
			}
		}

		// Token: 0x04007E1C RID: 32284
		private IPostAkEventMusicSubtitle Instance;
	}
}
