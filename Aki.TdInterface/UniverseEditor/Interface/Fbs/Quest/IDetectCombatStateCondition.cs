using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DD0 RID: 15824
	public struct IDetectCombatStateCondition : IFlatbufferObject
	{
		// Token: 0x17006D40 RID: 27968
		// (get) Token: 0x0601616F RID: 90479 RVA: 0x0033185A File Offset: 0x0032FA5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016170 RID: 90480 RVA: 0x00331867 File Offset: 0x0032FA67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016171 RID: 90481 RVA: 0x00331870 File Offset: 0x0032FA70
		public static IDetectCombatStateCondition GetRootAsIDetectCombatStateCondition(ByteBuffer _bb)
		{
			return IDetectCombatStateCondition.GetRootAsIDetectCombatStateCondition(_bb, default(IDetectCombatStateCondition));
		}

		// Token: 0x06016172 RID: 90482 RVA: 0x0033188C File Offset: 0x0032FA8C
		public static IDetectCombatStateCondition GetRootAsIDetectCombatStateCondition(ByteBuffer _bb, IDetectCombatStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016173 RID: 90483 RVA: 0x003318A9 File Offset: 0x0032FAA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016174 RID: 90484 RVA: 0x003318B8 File Offset: 0x0032FAB8
		public IDetectCombatStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D41 RID: 27969
		// (get) Token: 0x06016175 RID: 90485 RVA: 0x003318C8 File Offset: 0x0032FAC8
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D42 RID: 27970
		// (get) Token: 0x06016176 RID: 90486 RVA: 0x00331904 File Offset: 0x0032FB04
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006D43 RID: 27971
		// (get) Token: 0x06016177 RID: 90487 RVA: 0x00331964 File Offset: 0x0032FB64
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D44 RID: 27972
		// (get) Token: 0x06016178 RID: 90488 RVA: 0x003319A0 File Offset: 0x0032FBA0
		public string State
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016179 RID: 90489 RVA: 0x003319D8 File Offset: 0x0032FBD8
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601617A RID: 90490 RVA: 0x003319E8 File Offset: 0x0032FBE8
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17006D45 RID: 27973
		// (get) Token: 0x0601617B RID: 90491 RVA: 0x003319F8 File Offset: 0x0032FBF8
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D46 RID: 27974
		// (get) Token: 0x0601617C RID: 90492 RVA: 0x00331A38 File Offset: 0x0032FC38
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601617D RID: 90493 RVA: 0x00331A75 File Offset: 0x0032FC75
		public static Offset<IDetectCombatStateCondition> CreateIDetectCombatStateCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int EntityId = 0, StringOffset StateOffset = default(StringOffset), ECompare Compare = ECompare.Eq, byte NullMask = 0)
		{
			builder.StartTable(6);
			IDetectCombatStateCondition.AddState(builder, StateOffset);
			IDetectCombatStateCondition.AddEntityId(builder, EntityId);
			IDetectCombatStateCondition.AddPreConditions(builder, PreConditionsOffset);
			IDetectCombatStateCondition.AddNullMask(builder, NullMask);
			IDetectCombatStateCondition.AddCompare(builder, Compare);
			IDetectCombatStateCondition.AddType(builder, Type);
			return IDetectCombatStateCondition.EndIDetectCombatStateCondition(builder);
		}

		// Token: 0x0601617E RID: 90494 RVA: 0x00331AB1 File Offset: 0x0032FCB1
		public static void StartIDetectCombatStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601617F RID: 90495 RVA: 0x00331ABA File Offset: 0x0032FCBA
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016180 RID: 90496 RVA: 0x00331AC5 File Offset: 0x0032FCC5
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016181 RID: 90497 RVA: 0x00331AD5 File Offset: 0x0032FCD5
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06016182 RID: 90498 RVA: 0x00331AE0 File Offset: 0x0032FCE0
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x06016183 RID: 90499 RVA: 0x00331AF0 File Offset: 0x0032FCF0
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(4, (byte)compare, 0);
		}

		// Token: 0x06016184 RID: 90500 RVA: 0x00331AFB File Offset: 0x0032FCFB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06016185 RID: 90501 RVA: 0x00331B06 File Offset: 0x0032FD06
		public static Offset<IDetectCombatStateCondition> EndIDetectCombatStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDetectCombatStateCondition>(builder.EndTable());
		}

		// Token: 0x06016186 RID: 90502 RVA: 0x00331B14 File Offset: 0x0032FD14
		public IDetectCombatStateConditionT UnPack()
		{
			IDetectCombatStateConditionT detectCombatStateConditionT = new IDetectCombatStateConditionT();
			this.UnPackTo(detectCombatStateConditionT);
			return detectCombatStateConditionT;
		}

		// Token: 0x06016187 RID: 90503 RVA: 0x00331B30 File Offset: 0x0032FD30
		public void UnPackTo(IDetectCombatStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.State = this.State;
			_o.Compare = this.Compare;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016188 RID: 90504 RVA: 0x00331BA8 File Offset: 0x0032FDA8
		public static Offset<IDetectCombatStateCondition> Pack(FlatBufferBuilder builder, IDetectCombatStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectCombatStateCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IDetectCombatStateCondition.CreateIDetectCombatStateCondition(builder, _o.Type, preConditionsOffset, _o.EntityId, stateOffset, _o.Compare, _o.NullMask);
		}

		// Token: 0x0400B714 RID: 46868
		private Table __p;
	}
}
