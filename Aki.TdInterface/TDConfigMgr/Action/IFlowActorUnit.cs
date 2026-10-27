using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A7F RID: 6783
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowActorUnit
	{
		// Token: 0x06009142 RID: 37186 RVA: 0x00152394 File Offset: 0x00150594
		[NullableContext(1)]
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

		// Token: 0x06009143 RID: 37187 RVA: 0x001523CC File Offset: 0x001505CC
		[NullableContext(1)]
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

		// Token: 0x06009144 RID: 37188 RVA: 0x001523DF File Offset: 0x001505DF
		[NullableContext(1)]
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

		// Token: 0x06009145 RID: 37189 RVA: 0x001523F4 File Offset: 0x001505F4
		[NullableContext(1)]
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

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x06009146 RID: 37190 RVA: 0x0015245A File Offset: 0x0015065A
		// (set) Token: 0x06009147 RID: 37191 RVA: 0x00152485 File Offset: 0x00150685
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

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x06009148 RID: 37192 RVA: 0x00152493 File Offset: 0x00150693
		// (set) Token: 0x06009149 RID: 37193 RVA: 0x001524BE File Offset: 0x001506BE
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

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0600914A RID: 37194 RVA: 0x001524CC File Offset: 0x001506CC
		// (set) Token: 0x0600914B RID: 37195 RVA: 0x001524F7 File Offset: 0x001506F7
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

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0600914C RID: 37196 RVA: 0x00152505 File Offset: 0x00150705
		// (set) Token: 0x0600914D RID: 37197 RVA: 0x00152530 File Offset: 0x00150730
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

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x0600914E RID: 37198 RVA: 0x0015253E File Offset: 0x0015073E
		// (set) Token: 0x0600914F RID: 37199 RVA: 0x00152565 File Offset: 0x00150765
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

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x06009150 RID: 37200 RVA: 0x00152574 File Offset: 0x00150774
		// (set) Token: 0x06009151 RID: 37201 RVA: 0x001525D5 File Offset: 0x001507D5
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

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x06009152 RID: 37202 RVA: 0x001525EA File Offset: 0x001507EA
		// (set) Token: 0x06009153 RID: 37203 RVA: 0x00152601 File Offset: 0x00150801
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

		// Token: 0x0400599B RID: 22939
		protected IFlowActorUnit FbInstance;

		// Token: 0x0400599C RID: 22940
		protected IFlowActorUnit_SetValue PocoInterface;

		// Token: 0x0400599D RID: 22941
		[Nullable(1)]
		private IActorInitialState _InitialStateCache;

		// Token: 0x0400599E RID: 22942
		private bool _InitialStateInited;
	}
}
