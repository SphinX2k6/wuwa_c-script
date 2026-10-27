using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EE7 RID: 24295
	public struct IBuffsConfig : IFlatbufferObject
	{
		// Token: 0x1700B5A9 RID: 46505
		// (get) Token: 0x06029B8A RID: 170890 RVA: 0x005B9D1D File Offset: 0x005B7F1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B8B RID: 170891 RVA: 0x005B9D2A File Offset: 0x005B7F2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B8C RID: 170892 RVA: 0x005B9D34 File Offset: 0x005B7F34
		public static IBuffsConfig GetRootAsIBuffsConfig(ByteBuffer _bb)
		{
			return IBuffsConfig.GetRootAsIBuffsConfig(_bb, default(IBuffsConfig));
		}

		// Token: 0x06029B8D RID: 170893 RVA: 0x005B9D50 File Offset: 0x005B7F50
		public static IBuffsConfig GetRootAsIBuffsConfig(ByteBuffer _bb, IBuffsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B8E RID: 170894 RVA: 0x005B9D6D File Offset: 0x005B7F6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029B8F RID: 170895 RVA: 0x005B9D7C File Offset: 0x005B7F7C
		public IBuffsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029B90 RID: 170896 RVA: 0x005B9D8C File Offset: 0x005B7F8C
		public IBuffConfig? Buffs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IBuffConfig?(default(IBuffConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B5AA RID: 46506
		// (get) Token: 0x06029B91 RID: 170897 RVA: 0x005B9DEC File Offset: 0x005B7FEC
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

		// Token: 0x06029B92 RID: 170898 RVA: 0x005B9E17 File Offset: 0x005B8017
		public static Offset<IBuffsConfig> CreateIBuffsConfig(FlatBufferBuilder builder, VectorOffset BuffsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IBuffsConfig.AddBuffs(builder, BuffsOffset);
			return IBuffsConfig.EndIBuffsConfig(builder);
		}

		// Token: 0x06029B93 RID: 170899 RVA: 0x005B9E2D File Offset: 0x005B802D
		public static void StartIBuffsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029B94 RID: 170900 RVA: 0x005B9E36 File Offset: 0x005B8036
		public static void AddBuffs(FlatBufferBuilder builder, VectorOffset buffsOffset)
		{
			builder.AddOffset(0, buffsOffset.Value, 0);
		}

		// Token: 0x06029B95 RID: 170901 RVA: 0x005B9E48 File Offset: 0x005B8048
		public static VectorOffset CreateBuffsVector(FlatBufferBuilder builder, Offset<IBuffConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029B96 RID: 170902 RVA: 0x005B9E88 File Offset: 0x005B8088
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, Offset<IBuffConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBuffConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B97 RID: 170903 RVA: 0x005B9EA2 File Offset: 0x005B80A2
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBuffConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBuffConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B98 RID: 170904 RVA: 0x005B9EC0 File Offset: 0x005B80C0
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBuffConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029B99 RID: 170905 RVA: 0x005B9ED9 File Offset: 0x005B80D9
		public static void StartBuffsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029B9A RID: 170906 RVA: 0x005B9EE4 File Offset: 0x005B80E4
		public static Offset<IBuffsConfig> EndIBuffsConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBuffsConfig>(builder.EndTable());
		}

		// Token: 0x06029B9B RID: 170907 RVA: 0x005B9EF4 File Offset: 0x005B80F4
		public IBuffsConfigT UnPack()
		{
			IBuffsConfigT buffsConfigT = new IBuffsConfigT();
			this.UnPackTo(buffsConfigT);
			return buffsConfigT;
		}

		// Token: 0x06029B9C RID: 170908 RVA: 0x005B9F10 File Offset: 0x005B8110
		public void UnPackTo(IBuffsConfigT _o)
		{
			_o.Buffs = new List<IBuffConfigT>();
			for (int i = 0; i < this.BuffsLength; i++)
			{
				_o.Buffs.Add((this.Buffs(i) != null) ? this.Buffs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029B9D RID: 170909 RVA: 0x005B9F70 File Offset: 0x005B8170
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

		// Token: 0x0400F9EC RID: 63980
		private Table __p;
	}
}
