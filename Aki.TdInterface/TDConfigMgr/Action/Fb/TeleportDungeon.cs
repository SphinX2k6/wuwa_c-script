using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002969 RID: 10601
	public class TeleportDungeon : ActionParams
	{
		// Token: 0x0600EB49 RID: 60233 RVA: 0x0022ACE7 File Offset: 0x00228EE7
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

		// Token: 0x17004525 RID: 17701
		// (get) Token: 0x0600EB4A RID: 60234 RVA: 0x0022AD06 File Offset: 0x00228F06
		public virtual int DungeonId
		{
			get
			{
				return this.Instance.DungeonId;
			}
		}

		// Token: 0x17004526 RID: 17702
		// (get) Token: 0x0600EB4B RID: 60235 RVA: 0x0022AD13 File Offset: 0x00228F13
		public virtual bool IsRegroup
		{
			get
			{
				return this.Instance.IsRegroup;
			}
		}

		// Token: 0x17004527 RID: 17703
		// (get) Token: 0x0600EB4C RID: 60236 RVA: 0x0022AD20 File Offset: 0x00228F20
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

		// Token: 0x17004528 RID: 17704
		// (get) Token: 0x0600EB4D RID: 60237 RVA: 0x0022AD56 File Offset: 0x00228F56
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

		// Token: 0x17004529 RID: 17705
		// (get) Token: 0x0600EB4E RID: 60238 RVA: 0x0022AD88 File Offset: 0x00228F88
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

		// Token: 0x1700452A RID: 17706
		// (get) Token: 0x0600EB4F RID: 60239 RVA: 0x0022ADC0 File Offset: 0x00228FC0
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

		// Token: 0x1700452B RID: 17707
		// (get) Token: 0x0600EB50 RID: 60240 RVA: 0x0022ADF8 File Offset: 0x00228FF8
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

		// Token: 0x1700452C RID: 17708
		// (get) Token: 0x0600EB51 RID: 60241 RVA: 0x0022AE30 File Offset: 0x00229030
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

		// Token: 0x04008199 RID: 33177
		private ITeleportDungeon Instance;

		// Token: 0x0400819A RID: 33178
		private ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x0400819B RID: 33179
		private bool _TransitionOptionInited;
	}
}
