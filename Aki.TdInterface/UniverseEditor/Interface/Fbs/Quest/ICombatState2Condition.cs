using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D91 RID: 15761
	public struct ICombatState2Condition : IFlatbufferObject
	{
		// Token: 0x17006C5F RID: 27743
		// (get) Token: 0x06015E22 RID: 89634 RVA: 0x00329084 File Offset: 0x00327284
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015E23 RID: 89635 RVA: 0x00329091 File Offset: 0x00327291
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015E24 RID: 89636 RVA: 0x00329098 File Offset: 0x00327298
		public static ICombatState2Condition GetRootAsICombatState2Condition(ByteBuffer _bb)
		{
			return ICombatState2Condition.GetRootAsICombatState2Condition(_bb, default(ICombatState2Condition));
		}

		// Token: 0x06015E25 RID: 89637 RVA: 0x003290B4 File Offset: 0x003272B4
		public static ICombatState2Condition GetRootAsICombatState2Condition(ByteBuffer _bb, ICombatState2Condition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015E26 RID: 89638 RVA: 0x003290D1 File Offset: 0x003272D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015E27 RID: 89639 RVA: 0x003290E0 File Offset: 0x003272E0
		public ICombatState2Condition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C60 RID: 27744
		// (get) Token: 0x06015E28 RID: 89640 RVA: 0x003290F0 File Offset: 0x003272F0
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

		// Token: 0x17006C61 RID: 27745
		// (get) Token: 0x06015E29 RID: 89641 RVA: 0x0032912C File Offset: 0x0032732C
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

		// Token: 0x06015E2A RID: 89642 RVA: 0x00329163 File Offset: 0x00327363
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015E2B RID: 89643 RVA: 0x00329172 File Offset: 0x00327372
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006C62 RID: 27746
		// (get) Token: 0x06015E2C RID: 89644 RVA: 0x00329180 File Offset: 0x00327380
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

		// Token: 0x17006C63 RID: 27747
		// (get) Token: 0x06015E2D RID: 89645 RVA: 0x003291BC File Offset: 0x003273BC
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

		// Token: 0x17006C64 RID: 27748
		// (get) Token: 0x06015E2E RID: 89646 RVA: 0x003291FC File Offset: 0x003273FC
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

		// Token: 0x06015E2F RID: 89647 RVA: 0x00329239 File Offset: 0x00327439
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

		// Token: 0x06015E30 RID: 89648 RVA: 0x0032926D File Offset: 0x0032746D
		public static void StartICombatState2Condition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015E31 RID: 89649 RVA: 0x00329276 File Offset: 0x00327476
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06015E32 RID: 89650 RVA: 0x00329281 File Offset: 0x00327481
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06015E33 RID: 89651 RVA: 0x00329291 File Offset: 0x00327491
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06015E34 RID: 89652 RVA: 0x0032929C File Offset: 0x0032749C
		public static void AddDetectTarget(FlatBufferBuilder builder, EDetectTarget detectTarget)
		{
			builder.AddByte(3, (byte)detectTarget, 0);
		}

		// Token: 0x06015E35 RID: 89653 RVA: 0x003292A7 File Offset: 0x003274A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06015E36 RID: 89654 RVA: 0x003292B2 File Offset: 0x003274B2
		public static Offset<ICombatState2Condition> EndICombatState2Condition(FlatBufferBuilder builder)
		{
			return new Offset<ICombatState2Condition>(builder.EndTable());
		}

		// Token: 0x06015E37 RID: 89655 RVA: 0x003292C0 File Offset: 0x003274C0
		public ICombatState2ConditionT UnPack()
		{
			ICombatState2ConditionT combatState2ConditionT = new ICombatState2ConditionT();
			this.UnPackTo(combatState2ConditionT);
			return combatState2ConditionT;
		}

		// Token: 0x06015E38 RID: 89656 RVA: 0x003292DB File Offset: 0x003274DB
		public void UnPackTo(ICombatState2ConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
			_o.Compare = this.Compare;
			_o.DetectTarget = this.DetectTarget;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015E39 RID: 89657 RVA: 0x0032931C File Offset: 0x0032751C
		public static Offset<ICombatState2Condition> Pack(FlatBufferBuilder builder, ICombatState2ConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICombatState2Condition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ICombatState2Condition.CreateICombatState2Condition(builder, _o.EntityId, stateOffset, _o.Compare, _o.DetectTarget, _o.NullMask);
		}

		// Token: 0x0400B699 RID: 46745
		private Table __p;
	}
}
