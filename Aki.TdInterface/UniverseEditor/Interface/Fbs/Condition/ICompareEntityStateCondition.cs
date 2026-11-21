using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005085 RID: 20613
	public struct ICompareEntityStateCondition : IFlatbufferObject
	{
		// Token: 0x1700938D RID: 37773
		// (get) Token: 0x060203DA RID: 132058 RVA: 0x00477DA6 File Offset: 0x00475FA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060203DB RID: 132059 RVA: 0x00477DB3 File Offset: 0x00475FB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060203DC RID: 132060 RVA: 0x00477DBC File Offset: 0x00475FBC
		public static ICompareEntityStateCondition GetRootAsICompareEntityStateCondition(ByteBuffer _bb)
		{
			return ICompareEntityStateCondition.GetRootAsICompareEntityStateCondition(_bb, default(ICompareEntityStateCondition));
		}

		// Token: 0x060203DD RID: 132061 RVA: 0x00477DD8 File Offset: 0x00475FD8
		public static ICompareEntityStateCondition GetRootAsICompareEntityStateCondition(ByteBuffer _bb, ICompareEntityStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060203DE RID: 132062 RVA: 0x00477DF5 File Offset: 0x00475FF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060203DF RID: 132063 RVA: 0x00477E04 File Offset: 0x00476004
		public ICompareEntityStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700938E RID: 37774
		// (get) Token: 0x060203E0 RID: 132064 RVA: 0x00477E14 File Offset: 0x00476014
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700938F RID: 37775
		// (get) Token: 0x060203E1 RID: 132065 RVA: 0x00477E50 File Offset: 0x00476050
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009390 RID: 37776
		// (get) Token: 0x060203E2 RID: 132066 RVA: 0x00477E8C File Offset: 0x0047608C
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

		// Token: 0x17009391 RID: 37777
		// (get) Token: 0x060203E3 RID: 132067 RVA: 0x00477EC8 File Offset: 0x004760C8
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

		// Token: 0x060203E4 RID: 132068 RVA: 0x00477F00 File Offset: 0x00476100
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060203E5 RID: 132069 RVA: 0x00477F10 File Offset: 0x00476110
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060203E6 RID: 132070 RVA: 0x00477F1F File Offset: 0x0047611F
		public static Offset<ICompareEntityStateCondition> CreateICompareEntityStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, ECompare Compare = ECompare.Eq, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ICompareEntityStateCondition.AddState(builder, StateOffset);
			ICompareEntityStateCondition.AddEntityId(builder, EntityId);
			ICompareEntityStateCondition.AddCompare(builder, Compare);
			ICompareEntityStateCondition.AddType(builder, Type);
			return ICompareEntityStateCondition.EndICompareEntityStateCondition(builder);
		}

		// Token: 0x060203E7 RID: 132071 RVA: 0x00477F4B File Offset: 0x0047614B
		public static void StartICompareEntityStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060203E8 RID: 132072 RVA: 0x00477F54 File Offset: 0x00476154
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060203E9 RID: 132073 RVA: 0x00477F5F File Offset: 0x0047615F
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060203EA RID: 132074 RVA: 0x00477F6A File Offset: 0x0047616A
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x060203EB RID: 132075 RVA: 0x00477F75 File Offset: 0x00476175
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x060203EC RID: 132076 RVA: 0x00477F85 File Offset: 0x00476185
		public static Offset<ICompareEntityStateCondition> EndICompareEntityStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareEntityStateCondition>(builder.EndTable());
		}

		// Token: 0x060203ED RID: 132077 RVA: 0x00477F94 File Offset: 0x00476194
		public ICompareEntityStateConditionT UnPack()
		{
			ICompareEntityStateConditionT compareEntityStateConditionT = new ICompareEntityStateConditionT();
			this.UnPackTo(compareEntityStateConditionT);
			return compareEntityStateConditionT;
		}

		// Token: 0x060203EE RID: 132078 RVA: 0x00477FAF File Offset: 0x004761AF
		public void UnPackTo(ICompareEntityStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Compare = this.Compare;
			_o.State = this.State;
		}

		// Token: 0x060203EF RID: 132079 RVA: 0x00477FE4 File Offset: 0x004761E4
		public static Offset<ICompareEntityStateCondition> Pack(FlatBufferBuilder builder, ICompareEntityStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareEntityStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ICompareEntityStateCondition.CreateICompareEntityStateCondition(builder, _o.Type, _o.EntityId, _o.Compare, stateOffset);
		}

		// Token: 0x0400DF79 RID: 57209
		private Table __p;
	}
}
