using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DC RID: 21724
	public struct ILevelAIState : IFlatbufferObject
	{
		// Token: 0x1700A02C RID: 41004
		// (get) Token: 0x06023D1A RID: 146714 RVA: 0x004F3B6A File Offset: 0x004F1D6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023D1B RID: 146715 RVA: 0x004F3B77 File Offset: 0x004F1D77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023D1C RID: 146716 RVA: 0x004F3B80 File Offset: 0x004F1D80
		public static ILevelAIState GetRootAsILevelAIState(ByteBuffer _bb)
		{
			return ILevelAIState.GetRootAsILevelAIState(_bb, default(ILevelAIState));
		}

		// Token: 0x06023D1D RID: 146717 RVA: 0x004F3B9C File Offset: 0x004F1D9C
		public static ILevelAIState GetRootAsILevelAIState(ByteBuffer _bb, ILevelAIState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023D1E RID: 146718 RVA: 0x004F3BB9 File Offset: 0x004F1DB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023D1F RID: 146719 RVA: 0x004F3BC8 File Offset: 0x004F1DC8
		public ILevelAIState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A02D RID: 41005
		// (get) Token: 0x06023D20 RID: 146720 RVA: 0x004F3BD8 File Offset: 0x004F1DD8
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

		// Token: 0x1700A02E RID: 41006
		// (get) Token: 0x06023D21 RID: 146721 RVA: 0x004F3C14 File Offset: 0x004F1E14
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

		// Token: 0x06023D22 RID: 146722 RVA: 0x004F3C4B File Offset: 0x004F1E4B
		public Span<byte> GetStateNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023D23 RID: 146723 RVA: 0x004F3C5A File Offset: 0x004F1E5A
		public byte[] GetStateNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A02F RID: 41007
		// (get) Token: 0x06023D24 RID: 146724 RVA: 0x004F3C68 File Offset: 0x004F1E68
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

		// Token: 0x1700A030 RID: 41008
		// (get) Token: 0x06023D25 RID: 146725 RVA: 0x004F3CC8 File Offset: 0x004F1EC8
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

		// Token: 0x06023D26 RID: 146726 RVA: 0x004F3D08 File Offset: 0x004F1F08
		public TTable? Behaviour<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023D27 RID: 146727 RVA: 0x004F3D50 File Offset: 0x004F1F50
		public IInteractBehaviourActions BehaviourAsIInteractBehaviourActions()
		{
			return this.Behaviour<IInteractBehaviourActions>().Value;
		}

		// Token: 0x06023D28 RID: 146728 RVA: 0x004F3D6C File Offset: 0x004F1F6C
		public ILevelAIBehaviourSpline BehaviourAsILevelAIBehaviourSpline()
		{
			return this.Behaviour<ILevelAIBehaviourSpline>().Value;
		}

		// Token: 0x06023D29 RID: 146729 RVA: 0x004F3D87 File Offset: 0x004F1F87
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

		// Token: 0x06023D2A RID: 146730 RVA: 0x004F3DBB File Offset: 0x004F1FBB
		public static void StartILevelAIState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023D2B RID: 146731 RVA: 0x004F3DC4 File Offset: 0x004F1FC4
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(0, stateId, 0);
		}

		// Token: 0x06023D2C RID: 146732 RVA: 0x004F3DCF File Offset: 0x004F1FCF
		public static void AddStateName(FlatBufferBuilder builder, StringOffset stateNameOffset)
		{
			builder.AddOffset(1, stateNameOffset.Value, 0);
		}

		// Token: 0x06023D2D RID: 146733 RVA: 0x004F3DDF File Offset: 0x004F1FDF
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06023D2E RID: 146734 RVA: 0x004F3DEF File Offset: 0x004F1FEF
		public static void AddBehaviourType(FlatBufferBuilder builder, TLevelAIBehaviour behaviourType)
		{
			builder.AddByte(3, (byte)behaviourType, 0);
		}

		// Token: 0x06023D2F RID: 146735 RVA: 0x004F3DFA File Offset: 0x004F1FFA
		public static void AddBehaviour(FlatBufferBuilder builder, int behaviourOffset)
		{
			builder.AddOffset(4, behaviourOffset, 0);
		}

		// Token: 0x06023D30 RID: 146736 RVA: 0x004F3E05 File Offset: 0x004F2005
		public static Offset<ILevelAIState> EndILevelAIState(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAIState>(builder.EndTable());
		}

		// Token: 0x06023D31 RID: 146737 RVA: 0x004F3E14 File Offset: 0x004F2014
		public ILevelAIStateT UnPack()
		{
			ILevelAIStateT levelAIStateT = new ILevelAIStateT();
			this.UnPackTo(levelAIStateT);
			return levelAIStateT;
		}

		// Token: 0x06023D32 RID: 146738 RVA: 0x004F3E30 File Offset: 0x004F2030
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

		// Token: 0x06023D33 RID: 146739 RVA: 0x004F3F20 File Offset: 0x004F2120
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

		// Token: 0x0400E7AB RID: 59307
		private Table __p;
	}
}
