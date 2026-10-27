using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002781 RID: 10113
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowActorUnit
	{
		// Token: 0x0600E124 RID: 57636 RVA: 0x002144A2 File Offset: 0x002126A2
		[NullableContext(1)]
		public static IFlowActorUnit Create(IFlowActorUnit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowActorUnit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043E4 RID: 17380
		// (get) Token: 0x0600E125 RID: 57637 RVA: 0x002144C1 File Offset: 0x002126C1
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170043E5 RID: 17381
		// (get) Token: 0x0600E126 RID: 57638 RVA: 0x002144CE File Offset: 0x002126CE
		public virtual int TalkerId
		{
			get
			{
				return this.Instance.TalkerId;
			}
		}

		// Token: 0x170043E6 RID: 17382
		// (get) Token: 0x0600E127 RID: 57639 RVA: 0x002144DB File Offset: 0x002126DB
		public virtual bool IsPlayer
		{
			get
			{
				return this.Instance.IsPlayer;
			}
		}

		// Token: 0x170043E7 RID: 17383
		// (get) Token: 0x0600E128 RID: 57640 RVA: 0x002144E8 File Offset: 0x002126E8
		public virtual bool IsResetPosition
		{
			get
			{
				return this.Instance.IsResetPosition;
			}
		}

		// Token: 0x170043E8 RID: 17384
		// (get) Token: 0x0600E129 RID: 57641 RVA: 0x002144F5 File Offset: 0x002126F5
		public virtual string SeqFacePath
		{
			get
			{
				return this.Instance.SeqFacePath;
			}
		}

		// Token: 0x170043E9 RID: 17385
		// (get) Token: 0x0600E12A RID: 57642 RVA: 0x00214502 File Offset: 0x00212702
		public virtual IActorInitialState InitialState
		{
			get
			{
				if (this._InitialStateInited)
				{
					return this._InitialStateCache;
				}
				this._InitialStateInited = true;
				this._InitialStateCache = IActorInitialState.Create(this.Instance.InitialState);
				return this._InitialStateCache;
			}
		}

		// Token: 0x170043EA RID: 17386
		// (get) Token: 0x0600E12B RID: 57643 RVA: 0x00214536 File Offset: 0x00212736
		public virtual string EdTrialCharacterTemplate
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007CBF RID: 31935
		private IFlowActorUnit Instance;

		// Token: 0x04007CC0 RID: 31936
		private IActorInitialState _InitialStateCache;

		// Token: 0x04007CC1 RID: 31937
		private bool _InitialStateInited;
	}
}
