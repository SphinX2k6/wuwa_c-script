using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x0200652A RID: 25898
	public struct IBuffsConfig : IFlatbufferObject
	{
		// Token: 0x1700BF14 RID: 48916
		// (get) Token: 0x0602C23E RID: 180798 RVA: 0x00603201 File Offset: 0x00601401
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C23F RID: 180799 RVA: 0x0060320E File Offset: 0x0060140E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C240 RID: 180800 RVA: 0x00603218 File Offset: 0x00601418
		public static IBuffsConfig GetRootAsIBuffsConfig(ByteBuffer _bb)
		{
			return IBuffsConfig.GetRootAsIBuffsConfig(_bb, default(IBuffsConfig));
		}

		// Token: 0x0602C241 RID: 180801 RVA: 0x00603234 File Offset: 0x00601434
		public static IBuffsConfig GetRootAsIBuffsConfig(ByteBuffer _bb, IBuffsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C242 RID: 180802 RVA: 0x00603251 File Offset: 0x00601451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C243 RID: 180803 RVA: 0x00603260 File Offset: 0x00601460
		public IBuffsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C244 RID: 180804 RVA: 0x00603270 File Offset: 0x00601470
		public IBuffConfig? Buffs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IBuffConfig?(default(IBuffConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BF15 RID: 48917
		// (get) Token: 0x0602C245 RID: 180805 RVA: 0x006032D0 File Offset: 0x006014D0
		public int BuffsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602C246 RID: 180806 RVA: 0x006032FB File Offset: 0x006014FB
		public static Offset<IBuffsConfig> CreateIBuffsConfig(FlatBufferBuilder builder, VectorOffset BuffsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IBuffsConfig.AddBuffs(builder, BuffsOffset);
			return IBuffsConfig.EndIBuffsConfig(builder);
		}

		// Token: 0x0602C247 RID: 180807 RVA: 0x00603311 File Offset: 0x00601511
		public static void StartIBuffsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C248 RID: 180808 RVA: 0x0060331A File Offset: 0x0060151A
		public static void AddBuffs(FlatBufferBuilder builder, VectorOffset buffsOffset)
		{
			builder.AddOffset(0, buffsOffset.Value, 0);
		}

		// Token: 0x0602C249 RID: 180809 RVA: 0x0060332C File Offset: 0x0060152C
		public static VectorOffset CreateBuffsVector(FlatBufferBuilder builder, Offset<IBuffConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C24A RID: 180810 RVA: 0x0060336C File Offset: 0x0060156C
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, Offset<IBuffConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBuffConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C24B RID: 180811 RVA: 0x00603386 File Offset: 0x00601586
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBuffConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBuffConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C24C RID: 180812 RVA: 0x006033A4 File Offset: 0x006015A4
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBuffConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C24D RID: 180813 RVA: 0x006033BD File Offset: 0x006015BD
		public static void StartBuffsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C24E RID: 180814 RVA: 0x006033C8 File Offset: 0x006015C8
		public static Offset<IBuffsConfig> EndIBuffsConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBuffsConfig>(builder.EndTable());
		}

		// Token: 0x0602C24F RID: 180815 RVA: 0x006033D8 File Offset: 0x006015D8
		public IBuffsConfigT UnPack()
		{
			IBuffsConfigT buffsConfigT = new IBuffsConfigT();
			this.UnPackTo(buffsConfigT);
			return buffsConfigT;
		}

		// Token: 0x0602C250 RID: 180816 RVA: 0x006033F4 File Offset: 0x006015F4
		public void UnPackTo(IBuffsConfigT _o)
		{
			_o.Buffs = new List<IBuffConfigT>();
			for (int i = 0; i < this.BuffsLength; i++)
			{
				_o.Buffs.Add((this.Buffs(i) != null) ? this.Buffs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602C251 RID: 180817 RVA: 0x00603454 File Offset: 0x00601654
		public static Offset<IBuffsConfig> Pack(FlatBufferBuilder builder, IBuffsConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffsConfig>);
			}
			VectorOffset buffsOffset = default(VectorOffset);
			if (_o.Buffs != null)
			{
				Offset<IBuffConfig>[] array = new Offset<IBuffConfig>[_o.Buffs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IBuffConfig.Pack(builder, _o.Buffs[i]);
				}
				buffsOffset = IBuffsConfig.CreateBuffsVector(builder, array);
			}
			return IBuffsConfig.CreateIBuffsConfig(builder, buffsOffset);
		}

		// Token: 0x04010750 RID: 67408
		private Table __p;
	}
}
