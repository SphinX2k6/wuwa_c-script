using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200517D RID: 20861
	public struct IEntityGroupFailureArbitraryState : IFlatbufferObject
	{
		// Token: 0x1700986C RID: 39020
		// (get) Token: 0x06021BAD RID: 138157 RVA: 0x004AE484 File Offset: 0x004AC684
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021BAE RID: 138158 RVA: 0x004AE491 File Offset: 0x004AC691
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021BAF RID: 138159 RVA: 0x004AE498 File Offset: 0x004AC698
		public static IEntityGroupFailureArbitraryState GetRootAsIEntityGroupFailureArbitraryState(ByteBuffer _bb)
		{
			return IEntityGroupFailureArbitraryState.GetRootAsIEntityGroupFailureArbitraryState(_bb, default(IEntityGroupFailureArbitraryState));
		}

		// Token: 0x06021BB0 RID: 138160 RVA: 0x004AE4B4 File Offset: 0x004AC6B4
		public static IEntityGroupFailureArbitraryState GetRootAsIEntityGroupFailureArbitraryState(ByteBuffer _bb, IEntityGroupFailureArbitraryState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021BB1 RID: 138161 RVA: 0x004AE4D1 File Offset: 0x004AC6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021BB2 RID: 138162 RVA: 0x004AE4E0 File Offset: 0x004AC6E0
		public IEntityGroupFailureArbitraryState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700986D RID: 39021
		// (get) Token: 0x06021BB3 RID: 138163 RVA: 0x004AE4F0 File Offset: 0x004AC6F0
		public EEntityGroupFailureCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityGroupFailureCondition.SequentialState;
				}
				return (EEntityGroupFailureCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700986E RID: 39022
		// (get) Token: 0x06021BB4 RID: 138164 RVA: 0x004AE52C File Offset: 0x004AC72C
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

		// Token: 0x06021BB5 RID: 138165 RVA: 0x004AE563 File Offset: 0x004AC763
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021BB6 RID: 138166 RVA: 0x004AE572 File Offset: 0x004AC772
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06021BB7 RID: 138167 RVA: 0x004AE580 File Offset: 0x004AC780
		public static Offset<IEntityGroupFailureArbitraryState> CreateIEntityGroupFailureArbitraryState(FlatBufferBuilder builder, EEntityGroupFailureCondition Type = EEntityGroupFailureCondition.SequentialState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityGroupFailureArbitraryState.AddState(builder, StateOffset);
			IEntityGroupFailureArbitraryState.AddType(builder, Type);
			return IEntityGroupFailureArbitraryState.EndIEntityGroupFailureArbitraryState(builder);
		}

		// Token: 0x06021BB8 RID: 138168 RVA: 0x004AE59D File Offset: 0x004AC79D
		public static void StartIEntityGroupFailureArbitraryState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021BB9 RID: 138169 RVA: 0x004AE5A6 File Offset: 0x004AC7A6
		public static void AddType(FlatBufferBuilder builder, EEntityGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021BBA RID: 138170 RVA: 0x004AE5B1 File Offset: 0x004AC7B1
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06021BBB RID: 138171 RVA: 0x004AE5C1 File Offset: 0x004AC7C1
		public static Offset<IEntityGroupFailureArbitraryState> EndIEntityGroupFailureArbitraryState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupFailureArbitraryState>(builder.EndTable());
		}

		// Token: 0x06021BBC RID: 138172 RVA: 0x004AE5D0 File Offset: 0x004AC7D0
		public IEntityGroupFailureArbitraryStateT UnPack()
		{
			IEntityGroupFailureArbitraryStateT entityGroupFailureArbitraryStateT = new IEntityGroupFailureArbitraryStateT();
			this.UnPackTo(entityGroupFailureArbitraryStateT);
			return entityGroupFailureArbitraryStateT;
		}

		// Token: 0x06021BBD RID: 138173 RVA: 0x004AE5EB File Offset: 0x004AC7EB
		public void UnPackTo(IEntityGroupFailureArbitraryStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06021BBE RID: 138174 RVA: 0x004AE608 File Offset: 0x004AC808
		public static Offset<IEntityGroupFailureArbitraryState> Pack(FlatBufferBuilder builder, IEntityGroupFailureArbitraryStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityGroupFailureArbitraryState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IEntityGroupFailureArbitraryState.CreateIEntityGroupFailureArbitraryState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400E24C RID: 57932
		private Table __p;
	}
}
