using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF5 RID: 10997
	public class IPostAkEventMusicSubtitle : IPostAkEventType
	{
		// Token: 0x0600F201 RID: 61953 RVA: 0x00235E4C File Offset: 0x0023404C
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

		// Token: 0x170048C5 RID: 18629
		// (get) Token: 0x0600F202 RID: 61954 RVA: 0x00235E6B File Offset: 0x0023406B
		public override EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x170048C6 RID: 18630
		// (get) Token: 0x0600F203 RID: 61955 RVA: 0x00235E78 File Offset: 0x00234078
		public virtual string MusicSubtitleGroupTag
		{
			get
			{
				return this.Instance.MusicSubtitleGroupTag;
			}
		}

		// Token: 0x170048C7 RID: 18631
		// (get) Token: 0x0600F204 RID: 61956 RVA: 0x00235E85 File Offset: 0x00234085
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x170048C8 RID: 18632
		// (get) Token: 0x0600F205 RID: 61957 RVA: 0x00235E94 File Offset: 0x00234094
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

		// Token: 0x170048C9 RID: 18633
		// (get) Token: 0x0600F206 RID: 61958 RVA: 0x00235ECC File Offset: 0x002340CC
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

		// Token: 0x040084D9 RID: 34009
		private IPostAkEventMusicSubtitle Instance;
	}
}
