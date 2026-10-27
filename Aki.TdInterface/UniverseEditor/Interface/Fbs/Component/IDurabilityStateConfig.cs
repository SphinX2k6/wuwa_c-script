using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050C9 RID: 20681
	public struct IDurabilityStateConfig : IFlatbufferObject
	{
		// Token: 0x1700967E RID: 38526
		// (get) Token: 0x0602143D RID: 136253 RVA: 0x0049EEBD File Offset: 0x0049D0BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602143E RID: 136254 RVA: 0x0049EECA File Offset: 0x0049D0CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602143F RID: 136255 RVA: 0x0049EED4 File Offset: 0x0049D0D4
		public static IDurabilityStateConfig GetRootAsIDurabilityStateConfig(ByteBuffer _bb)
		{
			return IDurabilityStateConfig.GetRootAsIDurabilityStateConfig(_bb, default(IDurabilityStateConfig));
		}

		// Token: 0x06021440 RID: 136256 RVA: 0x0049EEF0 File Offset: 0x0049D0F0
		public static IDurabilityStateConfig GetRootAsIDurabilityStateConfig(ByteBuffer _bb, IDurabilityStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021441 RID: 136257 RVA: 0x0049EF0D File Offset: 0x0049D10D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021442 RID: 136258 RVA: 0x0049EF1C File Offset: 0x0049D11C
		public IDurabilityStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700967F RID: 38527
		// (get) Token: 0x06021443 RID: 136259 RVA: 0x0049EF2C File Offset: 0x0049D12C
		public bool NonDestructable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021444 RID: 136260 RVA: 0x0049EF6C File Offset: 0x0049D16C
		public IDurabilityState? DurabilityStates(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDurabilityState?(default(IDurabilityState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009680 RID: 38528
		// (get) Token: 0x06021445 RID: 136261 RVA: 0x0049EFCC File Offset: 0x0049D1CC
		public int DurabilityStatesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009681 RID: 38529
		// (get) Token: 0x06021446 RID: 136262 RVA: 0x0049EFF8 File Offset: 0x0049D1F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021447 RID: 136263 RVA: 0x0049F034 File Offset: 0x0049D234
		public static Offset<IDurabilityStateConfig> CreateIDurabilityStateConfig(FlatBufferBuilder builder, bool NonDestructable = false, VectorOffset DurabilityStatesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IDurabilityStateConfig.AddDurabilityStates(builder, DurabilityStatesOffset);
			IDurabilityStateConfig.AddNullMask(builder, NullMask);
			IDurabilityStateConfig.AddNonDestructable(builder, NonDestructable);
			return IDurabilityStateConfig.EndIDurabilityStateConfig(builder);
		}

		// Token: 0x06021448 RID: 136264 RVA: 0x0049F058 File Offset: 0x0049D258
		public static void StartIDurabilityStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021449 RID: 136265 RVA: 0x0049F061 File Offset: 0x0049D261
		public static void AddNonDestructable(FlatBufferBuilder builder, bool nonDestructable)
		{
			builder.AddBool(0, nonDestructable, false);
		}

		// Token: 0x0602144A RID: 136266 RVA: 0x0049F06C File Offset: 0x0049D26C
		public static void AddDurabilityStates(FlatBufferBuilder builder, VectorOffset durabilityStatesOffset)
		{
			builder.AddOffset(1, durabilityStatesOffset.Value, 0);
		}

		// Token: 0x0602144B RID: 136267 RVA: 0x0049F07C File Offset: 0x0049D27C
		public static VectorOffset CreateDurabilityStatesVector(FlatBufferBuilder builder, Offset<IDurabilityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602144C RID: 136268 RVA: 0x0049F0BC File Offset: 0x0049D2BC
		public static VectorOffset CreateDurabilityStatesVectorBlock(FlatBufferBuilder builder, Offset<IDurabilityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDurabilityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602144D RID: 136269 RVA: 0x0049F0D6 File Offset: 0x0049D2D6
		public static VectorOffset CreateDurabilityStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDurabilityState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDurabilityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602144E RID: 136270 RVA: 0x0049F0F4 File Offset: 0x0049D2F4
		public static VectorOffset CreateDurabilityStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDurabilityState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602144F RID: 136271 RVA: 0x0049F10D File Offset: 0x0049D30D
		public static void StartDurabilityStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021450 RID: 136272 RVA: 0x0049F118 File Offset: 0x0049D318
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06021451 RID: 136273 RVA: 0x0049F123 File Offset: 0x0049D323
		public static Offset<IDurabilityStateConfig> EndIDurabilityStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDurabilityStateConfig>(builder.EndTable());
		}

		// Token: 0x06021452 RID: 136274 RVA: 0x0049F130 File Offset: 0x0049D330
		public IDurabilityStateConfigT UnPack()
		{
			IDurabilityStateConfigT durabilityStateConfigT = new IDurabilityStateConfigT();
			this.UnPackTo(durabilityStateConfigT);
			return durabilityStateConfigT;
		}

		// Token: 0x06021453 RID: 136275 RVA: 0x0049F14C File Offset: 0x0049D34C
		public void UnPackTo(IDurabilityStateConfigT _o)
		{
			_o.NonDestructable = this.NonDestructable;
			_o.DurabilityStates = new List<IDurabilityStateT>();
			for (int i = 0; i < this.DurabilityStatesLength; i++)
			{
				_o.DurabilityStates.Add((this.DurabilityStates(i) != null) ? this.DurabilityStates(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021454 RID: 136276 RVA: 0x0049F1C4 File Offset: 0x0049D3C4
		public static Offset<IDurabilityStateConfig> Pack(FlatBufferBuilder builder, IDurabilityStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDurabilityStateConfig>);
			}
			VectorOffset durabilityStatesOffset = default(VectorOffset);
			if (_o.DurabilityStates != null)
			{
				Offset<IDurabilityState>[] array = new Offset<IDurabilityState>[_o.DurabilityStates.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDurabilityState.Pack(builder, _o.DurabilityStates[i]);
				}
				durabilityStatesOffset = IDurabilityStateConfig.CreateDurabilityStatesVector(builder, array);
			}
			return IDurabilityStateConfig.CreateIDurabilityStateConfig(builder, _o.NonDestructable, durabilityStatesOffset, _o.NullMask);
		}

		// Token: 0x0400E10D RID: 57613
		private Table __p;
	}
}
