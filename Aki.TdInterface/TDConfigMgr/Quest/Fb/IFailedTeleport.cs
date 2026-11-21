using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200158D RID: 5517
	public class IFailedTeleport
	{
		// Token: 0x06007C62 RID: 31842 RVA: 0x00127907 File Offset: 0x00125B07
		public static IFailedTeleport Create(IFailedTeleport? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailedTeleport
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x06007C63 RID: 31843 RVA: 0x00127926 File Offset: 0x00125B26
		public virtual Aki.TDConfigMgr.Action.Fb.PosA Position
		{
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				this._PositionCache = Aki.TDConfigMgr.Action.Fb.PosA.Create(this.Instance.Position);
				return this._PositionCache;
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x06007C64 RID: 31844 RVA: 0x0012795C File Offset: 0x00125B5C
		public virtual int? PositionEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PositionEntityId);
			}
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x06007C65 RID: 31845 RVA: 0x00127992 File Offset: 0x00125B92
		public virtual bool IsConfirm
		{
			get
			{
				return this.Instance.IsConfirm;
			}
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x06007C66 RID: 31846 RVA: 0x0012799F File Offset: 0x00125B9F
		public virtual int ConfirmId
		{
			get
			{
				return this.Instance.ConfirmId;
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x06007C67 RID: 31847 RVA: 0x001279AC File Offset: 0x00125BAC
		public virtual Aki.TDConfigMgr.Action.ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this._TransitionOptionInited)
				{
					return this._TransitionOptionCache;
				}
				this._TransitionOptionInited = true;
				this._TransitionOptionCache = QuestReadHelper.ReadIFailedTeleport_TransitionOption(this.Instance);
				return this._TransitionOptionCache;
			}
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x06007C68 RID: 31848 RVA: 0x001279DC File Offset: 0x00125BDC
		public virtual bool? GravityFlip
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.GravityFlip);
			}
		}

		// Token: 0x040047B7 RID: 18359
		private IFailedTeleport Instance;

		// Token: 0x040047B8 RID: 18360
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PosA _PositionCache;

		// Token: 0x040047B9 RID: 18361
		private bool _PositionInited;

		// Token: 0x040047BA RID: 18362
		private Aki.TDConfigMgr.Action.ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x040047BB RID: 18363
		private bool _TransitionOptionInited;
	}
}
