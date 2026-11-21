using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001576 RID: 5494
	public class ITrackReturnDungeon
	{
		// Token: 0x06007BC6 RID: 31686 RVA: 0x0012641A File Offset: 0x0012461A
		public static ITrackReturnDungeon Create(ITrackReturnDungeon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackReturnDungeon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x06007BC7 RID: 31687 RVA: 0x00126439 File Offset: 0x00124639
		public virtual int DungeonId
		{
			get
			{
				return this.Instance.DungeonId;
			}
		}

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x06007BC8 RID: 31688 RVA: 0x00126448 File Offset: 0x00124648
		public virtual bool? IsRegroup
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsRegroup);
			}
		}

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x06007BC9 RID: 31689 RVA: 0x0012647E File Offset: 0x0012467E
		public virtual ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this._TransitionOptionInited)
				{
					return this._TransitionOptionCache;
				}
				this._TransitionOptionInited = true;
				this._TransitionOptionCache = QuestReadHelper.ReadITrackReturnDungeon_TransitionOption(this.Instance);
				return this._TransitionOptionCache;
			}
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x06007BCA RID: 31690 RVA: 0x001264AD File Offset: 0x001246AD
		[Nullable(2)]
		public virtual string TidTip
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.TidTip;
			}
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x06007BCB RID: 31691 RVA: 0x001264BA File Offset: 0x001246BA
		[Nullable(2)]
		public virtual string EdTidTip
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04004760 RID: 18272
		private ITrackReturnDungeon Instance;

		// Token: 0x04004761 RID: 18273
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x04004762 RID: 18274
		private bool _TransitionOptionInited;
	}
}
