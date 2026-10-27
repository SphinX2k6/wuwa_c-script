using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001435 RID: 5173
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailedTeleport
	{
		// Token: 0x0600759D RID: 30109 RVA: 0x00118EBB File Offset: 0x001170BB
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

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x0600759E RID: 30110 RVA: 0x00118EDA File Offset: 0x001170DA
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

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x0600759F RID: 30111 RVA: 0x00118F10 File Offset: 0x00117110
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

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x060075A0 RID: 30112 RVA: 0x00118F46 File Offset: 0x00117146
		public virtual bool IsConfirm
		{
			get
			{
				return this.Instance.IsConfirm;
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x060075A1 RID: 30113 RVA: 0x00118F53 File Offset: 0x00117153
		public virtual int ConfirmId
		{
			get
			{
				return this.Instance.ConfirmId;
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x060075A2 RID: 30114 RVA: 0x00118F60 File Offset: 0x00117160
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

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x060075A3 RID: 30115 RVA: 0x00118F90 File Offset: 0x00117190
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

		// Token: 0x04004423 RID: 17443
		private IFailedTeleport Instance;

		// Token: 0x04004424 RID: 17444
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PosA _PositionCache;

		// Token: 0x04004425 RID: 17445
		private bool _PositionInited;

		// Token: 0x04004426 RID: 17446
		private Aki.TDConfigMgr.Action.ITeleportTransitionType _TransitionOptionCache;

		// Token: 0x04004427 RID: 17447
		private bool _TransitionOptionInited;
	}
}
