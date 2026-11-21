using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200562E RID: 22062
	public struct IDurabilityStateConfig : IFlatbufferObject
	{
		// Token: 0x17009E6B RID: 40555
		// (get) Token: 0x06023391 RID: 144273 RVA: 0x004D8E49 File Offset: 0x004D7049
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023392 RID: 144274 RVA: 0x004D8E56 File Offset: 0x004D7056
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023393 RID: 144275 RVA: 0x004D8E60 File Offset: 0x004D7060
		public static IDurabilityStateConfig GetRootAsIDurabilityStateConfig(ByteBuffer _bb)
		{
			return IDurabilityStateConfig.GetRootAsIDurabilityStateConfig(_bb, default(IDurabilityStateConfig));
		}

		// Token: 0x06023394 RID: 144276 RVA: 0x004D8E7C File Offset: 0x004D707C
		public static IDurabilityStateConfig GetRootAsIDurabilityStateConfig(ByteBuffer _bb, IDurabilityStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023395 RID: 144277 RVA: 0x004D8E99 File Offset: 0x004D7099
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023396 RID: 144278 RVA: 0x004D8EA8 File Offset: 0x004D70A8
		public IDurabilityStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E6C RID: 40556
		// (get) Token: 0x06023397 RID: 144279 RVA: 0x004D8EB8 File Offset: 0x004D70B8
		public bool NonDestructable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023398 RID: 144280 RVA: 0x004D8EF8 File Offset: 0x004D70F8
		public IDurabilityState? DurabilityStates(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDurabilityState?(default(IDurabilityState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009E6D RID: 40557
		// (get) Token: 0x06023399 RID: 144281 RVA: 0x004D8F58 File Offset: 0x004D7158
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

		// Token: 0x17009E6E RID: 40558
		// (get) Token: 0x0602339A RID: 144282 RVA: 0x004D8F84 File Offset: 0x004D7184
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

		// Token: 0x0602339B RID: 144283 RVA: 0x004D8FC0 File Offset: 0x004D71C0
		public static Offset<IDurabilityStateConfig> CreateIDurabilityStateConfig(FlatBufferBuilder builder, bool NonDestructable = false, VectorOffset DurabilityStatesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IDurabilityStateConfig.AddDurabilityStates(builder, DurabilityStatesOffset);
			IDurabilityStateConfig.AddNullMask(builder, NullMask);
			IDurabilityStateConfig.AddNonDestructable(builder, NonDestructable);
			return IDurabilityStateConfig.EndIDurabilityStateConfig(builder);
		}

		// Token: 0x0602339C RID: 144284 RVA: 0x004D8FE4 File Offset: 0x004D71E4
		public static void StartIDurabilityStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602339D RID: 144285 RVA: 0x004D8FED File Offset: 0x004D71ED
		public static void AddNonDestructable(FlatBufferBuilder builder, bool nonDestructable)
		{
			builder.AddBool(0, nonDestructable, false);
		}

		// Token: 0x0602339E RID: 144286 RVA: 0x004D8FF8 File Offset: 0x004D71F8
		public static void AddDurabilityStates(FlatBufferBuilder builder, VectorOffset durabilityStatesOffset)
		{
			builder.AddOffset(1, durabilityStatesOffset.Value, 0);
		}

		// Token: 0x0602339F RID: 144287 RVA: 0x004D9008 File Offset: 0x004D7208
		public static VectorOffset CreateDurabilityStatesVector(FlatBufferBuilder builder, Offset<IDurabilityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060233A0 RID: 144288 RVA: 0x004D9048 File Offset: 0x004D7248
		public static VectorOffset CreateDurabilityStatesVectorBlock(FlatBufferBuilder builder, Offset<IDurabilityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDurabilityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x060233A1 RID: 144289 RVA: 0x004D9062 File Offset: 0x004D7262
		public static VectorOffset CreateDurabilityStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDurabilityState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDurabilityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x060233A2 RID: 144290 RVA: 0x004D9080 File Offset: 0x004D7280
		public static VectorOffset CreateDurabilityStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDurabilityState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060233A3 RID: 144291 RVA: 0x004D9099 File Offset: 0x004D7299
		public static void StartDurabilityStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060233A4 RID: 144292 RVA: 0x004D90A4 File Offset: 0x004D72A4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060233A5 RID: 144293 RVA: 0x004D90AF File Offset: 0x004D72AF
		public static Offset<IDurabilityStateConfig> EndIDurabilityStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDurabilityStateConfig>(builder.EndTable());
		}

		// Token: 0x060233A6 RID: 144294 RVA: 0x004D90BC File Offset: 0x004D72BC
		public IDurabilityStateConfigT UnPack()
		{
			IDurabilityStateConfigT durabilityStateConfigT = new IDurabilityStateConfigT();
			this.UnPackTo(durabilityStateConfigT);
			return durabilityStateConfigT;
		}

		// Token: 0x060233A7 RID: 144295 RVA: 0x004D90D8 File Offset: 0x004D72D8
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

		// Token: 0x060233A8 RID: 144296 RVA: 0x004D9150 File Offset: 0x004D7350
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

		// Token: 0x0400ED0A RID: 60682
		private Table __p;
	}
}
