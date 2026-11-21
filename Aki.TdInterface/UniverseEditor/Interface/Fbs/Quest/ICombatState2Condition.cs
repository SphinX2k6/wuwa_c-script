using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A8 RID: 16808
	public struct ICombatState2Condition : IFlatbufferObject
	{
		// Token: 0x17007219 RID: 29209
		// (get) Token: 0x0601735A RID: 95066 RVA: 0x003503B0 File Offset: 0x0034E5B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601735B RID: 95067 RVA: 0x003503BD File Offset: 0x0034E5BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601735C RID: 95068 RVA: 0x003503C4 File Offset: 0x0034E5C4
		public static ICombatState2Condition GetRootAsICombatState2Condition(ByteBuffer _bb)
		{
			return ICombatState2Condition.GetRootAsICombatState2Condition(_bb, default(ICombatState2Condition));
		}

		// Token: 0x0601735D RID: 95069 RVA: 0x003503E0 File Offset: 0x0034E5E0
		public static ICombatState2Condition GetRootAsICombatState2Condition(ByteBuffer _bb, ICombatState2Condition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601735E RID: 95070 RVA: 0x003503FD File Offset: 0x0034E5FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601735F RID: 95071 RVA: 0x0035040C File Offset: 0x0034E60C
		public ICombatState2Condition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700721A RID: 29210
		// (get) Token: 0x06017360 RID: 95072 RVA: 0x0035041C File Offset: 0x0034E61C
		public int EntityId
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

		// Token: 0x1700721B RID: 29211
		// (get) Token: 0x06017361 RID: 95073 RVA: 0x00350458 File Offset: 0x0034E658
		public string State
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

		// Token: 0x06017362 RID: 95074 RVA: 0x0035048F File Offset: 0x0034E68F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06017363 RID: 95075 RVA: 0x0035049E File Offset: 0x0034E69E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700721C RID: 29212
		// (get) Token: 0x06017364 RID: 95076 RVA: 0x003504AC File Offset: 0x0034E6AC
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700721D RID: 29213
		// (get) Token: 0x06017365 RID: 95077 RVA: 0x003504E8 File Offset: 0x0034E6E8
		public EDetectTarget DetectTarget
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EDetectTarget.ControlledRole;
				}
				return (EDetectTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700721E RID: 29214
		// (get) Token: 0x06017366 RID: 95078 RVA: 0x00350528 File Offset: 0x0034E728
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017367 RID: 95079 RVA: 0x00350565 File Offset: 0x0034E765
		public static Offset<ICombatState2Condition> CreateICombatState2Condition(FlatBufferBuilder builder, int EntityId = 0, StringOffset StateOffset = default(StringOffset), ECompare Compare = ECompare.Eq, EDetectTarget DetectTarget = EDetectTarget.ControlledRole, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICombatState2Condition.AddState(builder, StateOffset);
			ICombatState2Condition.AddEntityId(builder, EntityId);
			ICombatState2Condition.AddNullMask(builder, NullMask);
			ICombatState2Condition.AddDetectTarget(builder, DetectTarget);
			ICombatState2Condition.AddCompare(builder, Compare);
			return ICombatState2Condition.EndICombatState2Condition(builder);
		}

		// Token: 0x06017368 RID: 95080 RVA: 0x00350599 File Offset: 0x0034E799
		public static void StartICombatState2Condition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017369 RID: 95081 RVA: 0x003505A2 File Offset: 0x0034E7A2
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601736A RID: 95082 RVA: 0x003505AD File Offset: 0x0034E7AD
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0601736B RID: 95083 RVA: 0x003505BD File Offset: 0x0034E7BD
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601736C RID: 95084 RVA: 0x003505C8 File Offset: 0x0034E7C8
		public static void AddDetectTarget(FlatBufferBuilder builder, EDetectTarget detectTarget)
		{
			builder.AddByte(3, (byte)detectTarget, 0);
		}

		// Token: 0x0601736D RID: 95085 RVA: 0x003505D3 File Offset: 0x0034E7D3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601736E RID: 95086 RVA: 0x003505DE File Offset: 0x0034E7DE
		public static Offset<ICombatState2Condition> EndICombatState2Condition(FlatBufferBuilder builder)
		{
			return new Offset<ICombatState2Condition>(builder.EndTable());
		}

		// Token: 0x0601736F RID: 95087 RVA: 0x003505EC File Offset: 0x0034E7EC
		public ICombatState2ConditionT UnPack()
		{
			ICombatState2ConditionT combatState2ConditionT = new ICombatState2ConditionT();
			this.UnPackTo(combatState2ConditionT);
			return combatState2ConditionT;
		}

		// Token: 0x06017370 RID: 95088 RVA: 0x00350607 File Offset: 0x0034E807
		public void UnPackTo(ICombatState2ConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
			_o.Compare = this.Compare;
			_o.DetectTarget = this.DetectTarget;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017371 RID: 95089 RVA: 0x00350648 File Offset: 0x0034E848
		public static Offset<ICombatState2Condition> Pack(FlatBufferBuilder builder, ICombatState2ConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICombatState2Condition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ICombatState2Condition.CreateICombatState2Condition(builder, _o.EntityId, stateOffset, _o.Compare, _o.DetectTarget, _o.NullMask);
		}

		// Token: 0x0400C046 RID: 49222
		private Table __p;
	}
}
