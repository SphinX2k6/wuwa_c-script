using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A53 RID: 10835
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowActorUnit
	{
		// Token: 0x0600EF42 RID: 61250 RVA: 0x00231236 File Offset: 0x0022F436
		[NullableContext(0)]
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

		// Token: 0x1700474A RID: 18250
		// (get) Token: 0x0600EF43 RID: 61251 RVA: 0x00231255 File Offset: 0x0022F455
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700474B RID: 18251
		// (get) Token: 0x0600EF44 RID: 61252 RVA: 0x00231262 File Offset: 0x0022F462
		public virtual int TalkerId
		{
			get
			{
				return this.Instance.TalkerId;
			}
		}

		// Token: 0x1700474C RID: 18252
		// (get) Token: 0x0600EF45 RID: 61253 RVA: 0x0023126F File Offset: 0x0022F46F
		public virtual bool IsPlayer
		{
			get
			{
				return this.Instance.IsPlayer;
			}
		}

		// Token: 0x1700474D RID: 18253
		// (get) Token: 0x0600EF46 RID: 61254 RVA: 0x0023127C File Offset: 0x0022F47C
		public virtual bool IsResetPosition
		{
			get
			{
				return this.Instance.IsResetPosition;
			}
		}

		// Token: 0x1700474E RID: 18254
		// (get) Token: 0x0600EF47 RID: 61255 RVA: 0x00231289 File Offset: 0x0022F489
		public virtual string SeqFacePath
		{
			get
			{
				return this.Instance.SeqFacePath;
			}
		}

		// Token: 0x1700474F RID: 18255
		// (get) Token: 0x0600EF48 RID: 61256 RVA: 0x00231296 File Offset: 0x0022F496
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

		// Token: 0x17004750 RID: 18256
		// (get) Token: 0x0600EF49 RID: 61257 RVA: 0x002312CA File Offset: 0x0022F4CA
		public virtual string EdTrialCharacterTemplate
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04008375 RID: 33653
		private IFlowActorUnit Instance;

		// Token: 0x04008376 RID: 33654
		private IActorInitialState _InitialStateCache;

		// Token: 0x04008377 RID: 33655
		private bool _InitialStateInited;
	}
}
