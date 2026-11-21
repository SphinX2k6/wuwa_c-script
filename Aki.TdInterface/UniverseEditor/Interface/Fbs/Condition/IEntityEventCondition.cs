using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005100 RID: 20736
	public struct IEntityEventCondition : IFlatbufferObject
	{
		// Token: 0x17009496 RID: 38038
		// (get) Token: 0x06020963 RID: 133475 RVA: 0x00484DE6 File Offset: 0x00482FE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020964 RID: 133476 RVA: 0x00484DF3 File Offset: 0x00482FF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020965 RID: 133477 RVA: 0x00484DFC File Offset: 0x00482FFC
		public static IEntityEventCondition GetRootAsIEntityEventCondition(ByteBuffer _bb)
		{
			return IEntityEventCondition.GetRootAsIEntityEventCondition(_bb, default(IEntityEventCondition));
		}

		// Token: 0x06020966 RID: 133478 RVA: 0x00484E18 File Offset: 0x00483018
		public static IEntityEventCondition GetRootAsIEntityEventCondition(ByteBuffer _bb, IEntityEventCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020967 RID: 133479 RVA: 0x00484E35 File Offset: 0x00483035
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020968 RID: 133480 RVA: 0x00484E44 File Offset: 0x00483044
		public IEntityEventCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009497 RID: 38039
		// (get) Token: 0x06020969 RID: 133481 RVA: 0x00484E54 File Offset: 0x00483054
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

		// Token: 0x17009498 RID: 38040
		// (get) Token: 0x0602096A RID: 133482 RVA: 0x00484E90 File Offset: 0x00483090
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

		// Token: 0x0602096B RID: 133483 RVA: 0x00484EC7 File Offset: 0x004830C7
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602096C RID: 133484 RVA: 0x00484ED6 File Offset: 0x004830D6
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009499 RID: 38041
		// (get) Token: 0x0602096D RID: 133485 RVA: 0x00484EE4 File Offset: 0x004830E4
		public bool IsDead
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700949A RID: 38042
		// (get) Token: 0x0602096E RID: 133486 RVA: 0x00484F24 File Offset: 0x00483124
		public bool IsLocked
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700949B RID: 38043
		// (get) Token: 0x0602096F RID: 133487 RVA: 0x00484F64 File Offset: 0x00483164
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

		// Token: 0x06020970 RID: 133488 RVA: 0x00484FA1 File Offset: 0x004831A1
		public static Offset<IEntityEventCondition> CreateIEntityEventCondition(FlatBufferBuilder builder, int EntityId = 0, StringOffset StateOffset = default(StringOffset), bool IsDead = false, bool IsLocked = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityEventCondition.AddState(builder, StateOffset);
			IEntityEventCondition.AddEntityId(builder, EntityId);
			IEntityEventCondition.AddNullMask(builder, NullMask);
			IEntityEventCondition.AddIsLocked(builder, IsLocked);
			IEntityEventCondition.AddIsDead(builder, IsDead);
			return IEntityEventCondition.EndIEntityEventCondition(builder);
		}

		// Token: 0x06020971 RID: 133489 RVA: 0x00484FD5 File Offset: 0x004831D5
		public static void StartIEntityEventCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020972 RID: 133490 RVA: 0x00484FDE File Offset: 0x004831DE
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06020973 RID: 133491 RVA: 0x00484FE9 File Offset: 0x004831E9
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06020974 RID: 133492 RVA: 0x00484FF9 File Offset: 0x004831F9
		public static void AddIsDead(FlatBufferBuilder builder, bool isDead)
		{
			builder.AddBool(2, isDead, false);
		}

		// Token: 0x06020975 RID: 133493 RVA: 0x00485004 File Offset: 0x00483204
		public static void AddIsLocked(FlatBufferBuilder builder, bool isLocked)
		{
			builder.AddBool(3, isLocked, false);
		}

		// Token: 0x06020976 RID: 133494 RVA: 0x0048500F File Offset: 0x0048320F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020977 RID: 133495 RVA: 0x0048501A File Offset: 0x0048321A
		public static Offset<IEntityEventCondition> EndIEntityEventCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityEventCondition>(builder.EndTable());
		}

		// Token: 0x06020978 RID: 133496 RVA: 0x00485028 File Offset: 0x00483228
		public IEntityEventConditionT UnPack()
		{
			IEntityEventConditionT entityEventConditionT = new IEntityEventConditionT();
			this.UnPackTo(entityEventConditionT);
			return entityEventConditionT;
		}

		// Token: 0x06020979 RID: 133497 RVA: 0x00485043 File Offset: 0x00483243
		public void UnPackTo(IEntityEventConditionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
			_o.IsDead = this.IsDead;
			_o.IsLocked = this.IsLocked;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602097A RID: 133498 RVA: 0x00485084 File Offset: 0x00483284
		public static Offset<IEntityEventCondition> Pack(FlatBufferBuilder builder, IEntityEventConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityEventCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IEntityEventCondition.CreateIEntityEventCondition(builder, _o.EntityId, stateOffset, _o.IsDead, _o.IsLocked, _o.NullMask);
		}

		// Token: 0x0400E0BE RID: 57534
		private Table __p;
	}
}
