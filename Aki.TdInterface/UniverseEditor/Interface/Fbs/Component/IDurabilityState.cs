using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200562B RID: 22059
	public struct IDurabilityState : IFlatbufferObject
	{
		// Token: 0x17009E66 RID: 40550
		// (get) Token: 0x06023379 RID: 144249 RVA: 0x004D8C16 File Offset: 0x004D6E16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602337A RID: 144250 RVA: 0x004D8C23 File Offset: 0x004D6E23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602337B RID: 144251 RVA: 0x004D8C2C File Offset: 0x004D6E2C
		public static IDurabilityState GetRootAsIDurabilityState(ByteBuffer _bb)
		{
			return IDurabilityState.GetRootAsIDurabilityState(_bb, default(IDurabilityState));
		}

		// Token: 0x0602337C RID: 144252 RVA: 0x004D8C48 File Offset: 0x004D6E48
		public static IDurabilityState GetRootAsIDurabilityState(ByteBuffer _bb, IDurabilityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602337D RID: 144253 RVA: 0x004D8C65 File Offset: 0x004D6E65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602337E RID: 144254 RVA: 0x004D8C74 File Offset: 0x004D6E74
		public IDurabilityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E67 RID: 40551
		// (get) Token: 0x0602337F RID: 144255 RVA: 0x004D8C84 File Offset: 0x004D6E84
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

		// Token: 0x17009E68 RID: 40552
		// (get) Token: 0x06023380 RID: 144256 RVA: 0x004D8CC0 File Offset: 0x004D6EC0
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

		// Token: 0x06023381 RID: 144257 RVA: 0x004D8CF7 File Offset: 0x004D6EF7
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023382 RID: 144258 RVA: 0x004D8D06 File Offset: 0x004D6F06
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06023383 RID: 144259 RVA: 0x004D8D14 File Offset: 0x004D6F14
		public static Offset<IDurabilityState> CreateIDurabilityState(FlatBufferBuilder builder, int Durability = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDurabilityState.AddState(builder, StateOffset);
			IDurabilityState.AddDurability(builder, Durability);
			return IDurabilityState.EndIDurabilityState(builder);
		}

		// Token: 0x06023384 RID: 144260 RVA: 0x004D8D31 File Offset: 0x004D6F31
		public static void StartIDurabilityState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023385 RID: 144261 RVA: 0x004D8D3A File Offset: 0x004D6F3A
		public static void AddDurability(FlatBufferBuilder builder, int durability)
		{
			builder.AddInt(0, durability, 0);
		}

		// Token: 0x06023386 RID: 144262 RVA: 0x004D8D45 File Offset: 0x004D6F45
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06023387 RID: 144263 RVA: 0x004D8D55 File Offset: 0x004D6F55
		public static Offset<IDurabilityState> EndIDurabilityState(FlatBufferBuilder builder)
		{
			return new Offset<IDurabilityState>(builder.EndTable());
		}

		// Token: 0x06023388 RID: 144264 RVA: 0x004D8D64 File Offset: 0x004D6F64
		public IDurabilityStateT UnPack()
		{
			IDurabilityStateT durabilityStateT = new IDurabilityStateT();
			this.UnPackTo(durabilityStateT);
			return durabilityStateT;
		}

		// Token: 0x06023389 RID: 144265 RVA: 0x004D8D7F File Offset: 0x004D6F7F
		public void UnPackTo(IDurabilityStateT _o)
		{
			_o.Durability = this.Durability;
			_o.State = this.State;
		}

		// Token: 0x0602338A RID: 144266 RVA: 0x004D8D9C File Offset: 0x004D6F9C
		public static Offset<IDurabilityState> Pack(FlatBufferBuilder builder, IDurabilityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDurabilityState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IDurabilityState.CreateIDurabilityState(builder, _o.Durability, stateOffset);
		}

		// Token: 0x0400ED07 RID: 60679
		private Table __p;
	}
}
