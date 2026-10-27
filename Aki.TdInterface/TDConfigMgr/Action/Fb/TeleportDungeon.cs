using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026A6 RID: 9894
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportDungeon : ActionParams
	{
		// Token: 0x0600DD72 RID: 56690 RVA: 0x0020E547 File Offset: 0x0020C747
		public static TeleportDungeon Create(ITeleportDungeon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TeleportDungeon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x0600DD73 RID: 56691 RVA: 0x0020E566 File Offset: 0x0020C766
		public virtual int DungeonId
		{
			get
			{
				return this.Instance.DungeonId;
			}
		}

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x0600DD74 RID: 56692 RVA: 0x0020E573 File Offset: 0x0020C773
		public virtual bool IsRegroup
		{
			get
			{
				return this.Instance.IsRegroup;
			}
		}

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x0600DD75 RID: 56693 RVA: 0x0020E580 File Offset: 0x0020C780
		public virtual int? LocationEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.LocationEntityId);
			}
		}

		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x0600DD76 RID: 56694 RVA: 0x0020E5B6 File Offset: 0x0020C7B6
		public virtual ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this._TransitionOptionInited)
				{
					return this._TransitionOptionCache;
				}
				this._TransitionOptionInited = true;
				this._TransitionOptionCache = ActionReadHelper.ReadTeleportDungeon_TransitionOption(this.Instance);
				return this._TransitionOptionCache;
			}
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x0600DD77 RID: 56695 RVA: 0x0020E5E8 File Offset: 0x0020C7E8
		public virtual bool? IsNeedSecondaryConfirmation
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNeedSecondaryConfirmation);
			}
		}

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x0600DD78 RID: 56696 RVA: 0x0020E620 File Offset: 0x0020C820
		public virtual bool? UseLocationEntityGravity
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseLocationEntityGravity);
			}
		}

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x0600DD79 RID: 56697 RVA: 0x0020E658 File Offset: 0x0020C858
		public virtual bool? ContinueSave
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ContinueSave);
			}
		}

		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x0600DD7A RID: 56698 RVA: 0x0020E690 File Offset: 0x0020C890
		public virtual bool? IsBanMapSound
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsBanMapSound);
			}
		}

		// Token: 0x04007AFC RID: 31484
		private ITeleportDungeon Instance;

		// Token: 0x04007AFD RID: 31485
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x04007AFE RID: 31486
		private bool _TransitionOptionInited;
	}
}
