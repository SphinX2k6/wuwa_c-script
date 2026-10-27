using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050C6 RID: 20678
	public struct IDurabilityState : IFlatbufferObject
	{
		// Token: 0x17009679 RID: 38521
		// (get) Token: 0x06021425 RID: 136229 RVA: 0x0049EC8A File Offset: 0x0049CE8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021426 RID: 136230 RVA: 0x0049EC97 File Offset: 0x0049CE97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021427 RID: 136231 RVA: 0x0049ECA0 File Offset: 0x0049CEA0
		public static IDurabilityState GetRootAsIDurabilityState(ByteBuffer _bb)
		{
			return IDurabilityState.GetRootAsIDurabilityState(_bb, default(IDurabilityState));
		}

		// Token: 0x06021428 RID: 136232 RVA: 0x0049ECBC File Offset: 0x0049CEBC
		public static IDurabilityState GetRootAsIDurabilityState(ByteBuffer _bb, IDurabilityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021429 RID: 136233 RVA: 0x0049ECD9 File Offset: 0x0049CED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602142A RID: 136234 RVA: 0x0049ECE8 File Offset: 0x0049CEE8
		public IDurabilityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700967A RID: 38522
		// (get) Token: 0x0602142B RID: 136235 RVA: 0x0049ECF8 File Offset: 0x0049CEF8
		public int Durability
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

		// Token: 0x1700967B RID: 38523
		// (get) Token: 0x0602142C RID: 136236 RVA: 0x0049ED34 File Offset: 0x0049CF34
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

		// Token: 0x0602142D RID: 136237 RVA: 0x0049ED6B File Offset: 0x0049CF6B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602142E RID: 136238 RVA: 0x0049ED7A File Offset: 0x0049CF7A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602142F RID: 136239 RVA: 0x0049ED88 File Offset: 0x0049CF88
		public static Offset<IDurabilityState> CreateIDurabilityState(FlatBufferBuilder builder, int Durability = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDurabilityState.AddState(builder, StateOffset);
			IDurabilityState.AddDurability(builder, Durability);
			return IDurabilityState.EndIDurabilityState(builder);
		}

		// Token: 0x06021430 RID: 136240 RVA: 0x0049EDA5 File Offset: 0x0049CFA5
		public static void StartIDurabilityState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021431 RID: 136241 RVA: 0x0049EDAE File Offset: 0x0049CFAE
		public static void AddDurability(FlatBufferBuilder builder, int durability)
		{
			builder.AddInt(0, durability, 0);
		}

		// Token: 0x06021432 RID: 136242 RVA: 0x0049EDB9 File Offset: 0x0049CFB9
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06021433 RID: 136243 RVA: 0x0049EDC9 File Offset: 0x0049CFC9
		public static Offset<IDurabilityState> EndIDurabilityState(FlatBufferBuilder builder)
		{
			return new Offset<IDurabilityState>(builder.EndTable());
		}

		// Token: 0x06021434 RID: 136244 RVA: 0x0049EDD8 File Offset: 0x0049CFD8
		public IDurabilityStateT UnPack()
		{
			IDurabilityStateT durabilityStateT = new IDurabilityStateT();
			this.UnPackTo(durabilityStateT);
			return durabilityStateT;
		}

		// Token: 0x06021435 RID: 136245 RVA: 0x0049EDF3 File Offset: 0x0049CFF3
		public void UnPackTo(IDurabilityStateT _o)
		{
			_o.Durability = this.Durability;
			_o.State = this.State;
		}

		// Token: 0x06021436 RID: 136246 RVA: 0x0049EE10 File Offset: 0x0049D010
		public static Offset<IDurabilityState> Pack(FlatBufferBuilder builder, IDurabilityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDurabilityState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IDurabilityState.CreateIDurabilityState(builder, _o.Durability, stateOffset);
		}

		// Token: 0x0400E10A RID: 57610
		private Table __p;
	}
}
