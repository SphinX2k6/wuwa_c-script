using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A62 RID: 23138
	public struct ILevelAIState : IFlatbufferObject
	{
		// Token: 0x1700A866 RID: 43110
		// (get) Token: 0x06025DD2 RID: 155090 RVA: 0x00530BDE File Offset: 0x0052EDDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025DD3 RID: 155091 RVA: 0x00530BEB File Offset: 0x0052EDEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025DD4 RID: 155092 RVA: 0x00530BF4 File Offset: 0x0052EDF4
		public static ILevelAIState GetRootAsILevelAIState(ByteBuffer _bb)
		{
			return ILevelAIState.GetRootAsILevelAIState(_bb, default(ILevelAIState));
		}

		// Token: 0x06025DD5 RID: 155093 RVA: 0x00530C10 File Offset: 0x0052EE10
		public static ILevelAIState GetRootAsILevelAIState(ByteBuffer _bb, ILevelAIState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025DD6 RID: 155094 RVA: 0x00530C2D File Offset: 0x0052EE2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025DD7 RID: 155095 RVA: 0x00530C3C File Offset: 0x0052EE3C
		public ILevelAIState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A867 RID: 43111
		// (get) Token: 0x06025DD8 RID: 155096 RVA: 0x00530C4C File Offset: 0x0052EE4C
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A868 RID: 43112
		// (get) Token: 0x06025DD9 RID: 155097 RVA: 0x00530C88 File Offset: 0x0052EE88
		public string StateName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025DDA RID: 155098 RVA: 0x00530CBF File Offset: 0x0052EEBF
		public Span<byte> GetStateNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025DDB RID: 155099 RVA: 0x00530CCE File Offset: 0x0052EECE
		public byte[] GetStateNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A869 RID: 43113
		// (get) Token: 0x06025DDC RID: 155100 RVA: 0x00530CDC File Offset: 0x0052EEDC
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A86A RID: 43114
		// (get) Token: 0x06025DDD RID: 155101 RVA: 0x00530D3C File Offset: 0x0052EF3C
		public TLevelAIBehaviour BehaviourType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TLevelAIBehaviour.NONE;
				}
				return (TLevelAIBehaviour)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025DDE RID: 155102 RVA: 0x00530D7C File Offset: 0x0052EF7C
		public TTable? Behaviour<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025DDF RID: 155103 RVA: 0x00530DC4 File Offset: 0x0052EFC4
		public IInteractBehaviourActions BehaviourAsIInteractBehaviourActions()
		{
			return this.Behaviour<IInteractBehaviourActions>().Value;
		}

		// Token: 0x06025DE0 RID: 155104 RVA: 0x00530DE0 File Offset: 0x0052EFE0
		public ILevelAIBehaviourSpline BehaviourAsILevelAIBehaviourSpline()
		{
			return this.Behaviour<ILevelAIBehaviourSpline>().Value;
		}

		// Token: 0x06025DE1 RID: 155105 RVA: 0x00530DFB File Offset: 0x0052EFFB
		public static Offset<ILevelAIState> CreateILevelAIState(FlatBufferBuilder builder, int StateId = 0, StringOffset StateNameOffset = default(StringOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TLevelAIBehaviour Behaviour_type = TLevelAIBehaviour.NONE, int BehaviourOffset = 0)
		{
			builder.StartTable(5);
			ILevelAIState.AddBehaviour(builder, BehaviourOffset);
			ILevelAIState.AddCondition(builder, ConditionOffset);
			ILevelAIState.AddStateName(builder, StateNameOffset);
			ILevelAIState.AddStateId(builder, StateId);
			ILevelAIState.AddBehaviourType(builder, Behaviour_type);
			return ILevelAIState.EndILevelAIState(builder);
		}

		// Token: 0x06025DE2 RID: 155106 RVA: 0x00530E2F File Offset: 0x0052F02F
		public static void StartILevelAIState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025DE3 RID: 155107 RVA: 0x00530E38 File Offset: 0x0052F038
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(0, stateId, 0);
		}

		// Token: 0x06025DE4 RID: 155108 RVA: 0x00530E43 File Offset: 0x0052F043
		public static void AddStateName(FlatBufferBuilder builder, StringOffset stateNameOffset)
		{
			builder.AddOffset(1, stateNameOffset.Value, 0);
		}

		// Token: 0x06025DE5 RID: 155109 RVA: 0x00530E53 File Offset: 0x0052F053
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06025DE6 RID: 155110 RVA: 0x00530E63 File Offset: 0x0052F063
		public static void AddBehaviourType(FlatBufferBuilder builder, TLevelAIBehaviour behaviourType)
		{
			builder.AddByte(3, (byte)behaviourType, 0);
		}

		// Token: 0x06025DE7 RID: 155111 RVA: 0x00530E6E File Offset: 0x0052F06E
		public static void AddBehaviour(FlatBufferBuilder builder, int behaviourOffset)
		{
			builder.AddOffset(4, behaviourOffset, 0);
		}

		// Token: 0x06025DE8 RID: 155112 RVA: 0x00530E79 File Offset: 0x0052F079
		public static Offset<ILevelAIState> EndILevelAIState(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAIState>(builder.EndTable());
		}

		// Token: 0x06025DE9 RID: 155113 RVA: 0x00530E88 File Offset: 0x0052F088
		public ILevelAIStateT UnPack()
		{
			ILevelAIStateT levelAIStateT = new ILevelAIStateT();
			this.UnPackTo(levelAIStateT);
			return levelAIStateT;
		}

		// Token: 0x06025DEA RID: 155114 RVA: 0x00530EA4 File Offset: 0x0052F0A4
		public void UnPackTo(ILevelAIStateT _o)
		{
			_o.StateId = this.StateId;
			_o.StateName = this.StateName;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Behaviour = new TLevelAIBehaviourUnion();
			_o.Behaviour.Type = this.BehaviourType;
			TLevelAIBehaviour behaviourType = this.BehaviourType;
			if (behaviourType == TLevelAIBehaviour.IInteractBehaviourActions)
			{
				_o.Behaviour.Value = ((this.Behaviour<IInteractBehaviourActions>() != null) ? this.Behaviour<IInteractBehaviourActions>().Value.UnPack() : null);
				return;
			}
			if (behaviourType != TLevelAIBehaviour.ILevelAIBehaviourSpline)
			{
				return;
			}
			_o.Behaviour.Value = ((this.Behaviour<ILevelAIBehaviourSpline>() != null) ? this.Behaviour<ILevelAIBehaviourSpline>().Value.UnPack() : null);
		}

		// Token: 0x06025DEB RID: 155115 RVA: 0x00530F94 File Offset: 0x0052F194
		public static Offset<ILevelAIState> Pack(FlatBufferBuilder builder, ILevelAIStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAIState>);
			}
			StringOffset stateNameOffset = (_o.StateName == null) ? default(StringOffset) : builder.CreateString(_o.StateName);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			TLevelAIBehaviour behaviour_type = (_o.Behaviour == null) ? TLevelAIBehaviour.NONE : _o.Behaviour.Type;
			int behaviourOffset = (_o.Behaviour == null) ? 0 : TLevelAIBehaviourUnion.Pack(builder, _o.Behaviour);
			return ILevelAIState.CreateILevelAIState(builder, _o.StateId, stateNameOffset, conditionOffset, behaviour_type, behaviourOffset);
		}

		// Token: 0x0400F3DC RID: 62428
		private Table __p;
	}
}
