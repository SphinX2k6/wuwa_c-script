using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E2 RID: 22242
	public struct IEntityGroupFailureArbitraryState : IFlatbufferObject
	{
		// Token: 0x1700A05B RID: 41051
		// (get) Token: 0x06023B05 RID: 146181 RVA: 0x004E84A4 File Offset: 0x004E66A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B06 RID: 146182 RVA: 0x004E84B1 File Offset: 0x004E66B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B07 RID: 146183 RVA: 0x004E84B8 File Offset: 0x004E66B8
		public static IEntityGroupFailureArbitraryState GetRootAsIEntityGroupFailureArbitraryState(ByteBuffer _bb)
		{
			return IEntityGroupFailureArbitraryState.GetRootAsIEntityGroupFailureArbitraryState(_bb, default(IEntityGroupFailureArbitraryState));
		}

		// Token: 0x06023B08 RID: 146184 RVA: 0x004E84D4 File Offset: 0x004E66D4
		public static IEntityGroupFailureArbitraryState GetRootAsIEntityGroupFailureArbitraryState(ByteBuffer _bb, IEntityGroupFailureArbitraryState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B09 RID: 146185 RVA: 0x004E84F1 File Offset: 0x004E66F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B0A RID: 146186 RVA: 0x004E8500 File Offset: 0x004E6700
		public IEntityGroupFailureArbitraryState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A05C RID: 41052
		// (get) Token: 0x06023B0B RID: 146187 RVA: 0x004E8510 File Offset: 0x004E6710
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

		// Token: 0x1700A05D RID: 41053
		// (get) Token: 0x06023B0C RID: 146188 RVA: 0x004E854C File Offset: 0x004E674C
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

		// Token: 0x06023B0D RID: 146189 RVA: 0x004E8583 File Offset: 0x004E6783
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023B0E RID: 146190 RVA: 0x004E8592 File Offset: 0x004E6792
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06023B0F RID: 146191 RVA: 0x004E85A0 File Offset: 0x004E67A0
		public static Offset<IEntityGroupFailureArbitraryState> CreateIEntityGroupFailureArbitraryState(FlatBufferBuilder builder, EEntityGroupFailureCondition Type = EEntityGroupFailureCondition.SequentialState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityGroupFailureArbitraryState.AddState(builder, StateOffset);
			IEntityGroupFailureArbitraryState.AddType(builder, Type);
			return IEntityGroupFailureArbitraryState.EndIEntityGroupFailureArbitraryState(builder);
		}

		// Token: 0x06023B10 RID: 146192 RVA: 0x004E85BD File Offset: 0x004E67BD
		public static void StartIEntityGroupFailureArbitraryState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023B11 RID: 146193 RVA: 0x004E85C6 File Offset: 0x004E67C6
		public static void AddType(FlatBufferBuilder builder, EEntityGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023B12 RID: 146194 RVA: 0x004E85D1 File Offset: 0x004E67D1
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06023B13 RID: 146195 RVA: 0x004E85E1 File Offset: 0x004E67E1
		public static Offset<IEntityGroupFailureArbitraryState> EndIEntityGroupFailureArbitraryState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupFailureArbitraryState>(builder.EndTable());
		}

		// Token: 0x06023B14 RID: 146196 RVA: 0x004E85F0 File Offset: 0x004E67F0
		public IEntityGroupFailureArbitraryStateT UnPack()
		{
			IEntityGroupFailureArbitraryStateT entityGroupFailureArbitraryStateT = new IEntityGroupFailureArbitraryStateT();
			this.UnPackTo(entityGroupFailureArbitraryStateT);
			return entityGroupFailureArbitraryStateT;
		}

		// Token: 0x06023B15 RID: 146197 RVA: 0x004E860B File Offset: 0x004E680B
		public void UnPackTo(IEntityGroupFailureArbitraryStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06023B16 RID: 146198 RVA: 0x004E8628 File Offset: 0x004E6828
		public static Offset<IEntityGroupFailureArbitraryState> Pack(FlatBufferBuilder builder, IEntityGroupFailureArbitraryStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityGroupFailureArbitraryState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IEntityGroupFailureArbitraryState.CreateIEntityGroupFailureArbitraryState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400EE4A RID: 61002
		private Table __p;
	}
}
