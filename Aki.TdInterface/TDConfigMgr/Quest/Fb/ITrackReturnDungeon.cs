using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141E RID: 5150
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackReturnDungeon
	{
		// Token: 0x06007501 RID: 29953 RVA: 0x001179CE File Offset: 0x00115BCE
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

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x06007502 RID: 29954 RVA: 0x001179ED File Offset: 0x00115BED
		public virtual int DungeonId
		{
			get
			{
				return this.Instance.DungeonId;
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x06007503 RID: 29955 RVA: 0x001179FC File Offset: 0x00115BFC
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

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x06007504 RID: 29956 RVA: 0x00117A32 File Offset: 0x00115C32
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

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x06007505 RID: 29957 RVA: 0x00117A61 File Offset: 0x00115C61
		[Nullable(2)]
		public virtual string TidTip
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.TidTip;
			}
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x06007506 RID: 29958 RVA: 0x00117A6E File Offset: 0x00115C6E
		[Nullable(2)]
		public virtual string EdTidTip
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040043CC RID: 17356
		private ITrackReturnDungeon Instance;

		// Token: 0x040043CD RID: 17357
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x040043CE RID: 17358
		private bool _TransitionOptionInited;
	}
}
