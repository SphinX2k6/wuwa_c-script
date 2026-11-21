using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C14 RID: 7188
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowActorUnit
	{
		// Token: 0x060098AC RID: 39084 RVA: 0x001622C0 File Offset: 0x001604C0
		[NullableContext(0)]
		private IFlowActorUnit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowActorUnit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowActorUnit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowActorUnit_SetValue());
			}
			return result;
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x001622F8 File Offset: 0x001604F8
		[NullableContext(0)]
		public static IFlowActorUnit Create([Nullable(2)] IFlowActorUnit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowActorUnit
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098AE RID: 39086 RVA: 0x0016230B File Offset: 0x0016050B
		[NullableContext(0)]
		public static IFlowActorUnit CreateFromSetValue([Nullable(2)] IFlowActorUnit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowActorUnit
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x00162320 File Offset: 0x00160520
		[NullableContext(0)]
		public IFlowActorUnit_SetValue ToSetValue()
		{
			return new IFlowActorUnit_SetValue
			{
				EntityId = this.EntityId,
				TalkerId = this.TalkerId,
				IsPlayer = this.IsPlayer,
				IsResetPosition = this.IsResetPosition,
				SeqFacePath = this.SeqFacePath,
				InitialState = this.InitialState,
				EdTrialCharacterTemplate = this.EdTrialCharacterTemplate
			};
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x060098B0 RID: 39088 RVA: 0x00162386 File Offset: 0x00160586
		// (set) Token: 0x060098B1 RID: 39089 RVA: 0x001623B1 File Offset: 0x001605B1
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x060098B2 RID: 39090 RVA: 0x001623BF File Offset: 0x001605BF
		// (set) Token: 0x060098B3 RID: 39091 RVA: 0x001623EA File Offset: 0x001605EA
		public virtual int TalkerId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkerId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TalkerId;
			}
			set
			{
				this.GetOrCreatePoco().TalkerId = value;
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x060098B4 RID: 39092 RVA: 0x001623F8 File Offset: 0x001605F8
		// (set) Token: 0x060098B5 RID: 39093 RVA: 0x00162423 File Offset: 0x00160623
		public virtual bool IsPlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPlayer;
				}
				return this.PocoInterface != null && this.PocoInterface.IsPlayer;
			}
			set
			{
				this.GetOrCreatePoco().IsPlayer = value;
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x060098B6 RID: 39094 RVA: 0x00162431 File Offset: 0x00160631
		// (set) Token: 0x060098B7 RID: 39095 RVA: 0x0016245C File Offset: 0x0016065C
		public virtual bool IsResetPosition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsResetPosition;
				}
				return this.PocoInterface != null && this.PocoInterface.IsResetPosition;
			}
			set
			{
				this.GetOrCreatePoco().IsResetPosition = value;
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x060098B8 RID: 39096 RVA: 0x0016246A File Offset: 0x0016066A
		// (set) Token: 0x060098B9 RID: 39097 RVA: 0x00162491 File Offset: 0x00160691
		public virtual string SeqFacePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SeqFacePath;
				}
				IFlowActorUnit_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SeqFacePath;
			}
			set
			{
				this.GetOrCreatePoco().SeqFacePath = value;
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x060098BA RID: 39098 RVA: 0x001624A0 File Offset: 0x001606A0
		// (set) Token: 0x060098BB RID: 39099 RVA: 0x00162501 File Offset: 0x00160701
		public virtual IActorInitialState InitialState
		{
			get
			{
				if (this._InitialStateInited)
				{
					return this._InitialStateCache;
				}
				this._InitialStateInited = true;
				if (this.FbInstance != null)
				{
					this._InitialStateCache = IActorInitialState.Create(this.FbInstance.InitialState);
				}
				else
				{
					IFlowActorUnit_SetValue pocoInterface = this.PocoInterface;
					this._InitialStateCache = ((pocoInterface != null) ? pocoInterface.InitialState : null);
				}
				return this._InitialStateCache;
			}
			set
			{
				this.GetOrCreatePoco().InitialState = value;
				this._InitialStateInited = false;
			}
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x060098BC RID: 39100 RVA: 0x00162516 File Offset: 0x00160716
		// (set) Token: 0x060098BD RID: 39101 RVA: 0x0016252D File Offset: 0x0016072D
		public virtual string EdTrialCharacterTemplate
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTrialCharacterTemplate;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTrialCharacterTemplate = value;
			}
		}

		// Token: 0x04005E00 RID: 24064
		protected IFlowActorUnit FbInstance;

		// Token: 0x04005E01 RID: 24065
		protected IFlowActorUnit_SetValue PocoInterface;

		// Token: 0x04005E02 RID: 24066
		[Nullable(0)]
		private IActorInitialState _InitialStateCache;

		// Token: 0x04005E03 RID: 24067
		private bool _InitialStateInited;
	}
}
