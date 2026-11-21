using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BAA RID: 19370
	public struct IMontagesConfig : IFlatbufferObject
	{
		// Token: 0x17008927 RID: 35111
		// (get) Token: 0x0601D8F6 RID: 121078 RVA: 0x00426598 File Offset: 0x00424798
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D8F7 RID: 121079 RVA: 0x004265A5 File Offset: 0x004247A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D8F8 RID: 121080 RVA: 0x004265AC File Offset: 0x004247AC
		public static IMontagesConfig GetRootAsIMontagesConfig(ByteBuffer _bb)
		{
			return IMontagesConfig.GetRootAsIMontagesConfig(_bb, default(IMontagesConfig));
		}

		// Token: 0x0601D8F9 RID: 121081 RVA: 0x004265C8 File Offset: 0x004247C8
		public static IMontagesConfig GetRootAsIMontagesConfig(ByteBuffer _bb, IMontagesConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D8FA RID: 121082 RVA: 0x004265E5 File Offset: 0x004247E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D8FB RID: 121083 RVA: 0x004265F4 File Offset: 0x004247F4
		public IMontagesConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601D8FC RID: 121084 RVA: 0x00426604 File Offset: 0x00424804
		public IMontageConfig? Montages(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IMontageConfig?(default(IMontageConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008928 RID: 35112
		// (get) Token: 0x0601D8FD RID: 121085 RVA: 0x00426664 File Offset: 0x00424864
		public int MontagesLength
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

		// Token: 0x0601D8FE RID: 121086 RVA: 0x0042668F File Offset: 0x0042488F
		public static Offset<IMontagesConfig> CreateIMontagesConfig(FlatBufferBuilder builder, VectorOffset MontagesOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IMontagesConfig.AddMontages(builder, MontagesOffset);
			return IMontagesConfig.EndIMontagesConfig(builder);
		}

		// Token: 0x0601D8FF RID: 121087 RVA: 0x004266A5 File Offset: 0x004248A5
		public static void StartIMontagesConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D900 RID: 121088 RVA: 0x004266AE File Offset: 0x004248AE
		public static void AddMontages(FlatBufferBuilder builder, VectorOffset montagesOffset)
		{
			builder.AddOffset(0, montagesOffset.Value, 0);
		}

		// Token: 0x0601D901 RID: 121089 RVA: 0x004266C0 File Offset: 0x004248C0
		public static VectorOffset CreateMontagesVector(FlatBufferBuilder builder, Offset<IMontageConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D902 RID: 121090 RVA: 0x00426700 File Offset: 0x00424900
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, Offset<IMontageConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D903 RID: 121091 RVA: 0x0042671A File Offset: 0x0042491A
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D904 RID: 121092 RVA: 0x00426738 File Offset: 0x00424938
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D905 RID: 121093 RVA: 0x00426751 File Offset: 0x00424951
		public static void StartMontagesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D906 RID: 121094 RVA: 0x0042675C File Offset: 0x0042495C
		public static Offset<IMontagesConfig> EndIMontagesConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMontagesConfig>(builder.EndTable());
		}

		// Token: 0x0601D907 RID: 121095 RVA: 0x0042676C File Offset: 0x0042496C
		public IMontagesConfigT UnPack()
		{
			IMontagesConfigT montagesConfigT = new IMontagesConfigT();
			this.UnPackTo(montagesConfigT);
			return montagesConfigT;
		}

		// Token: 0x0601D908 RID: 121096 RVA: 0x00426788 File Offset: 0x00424988
		public void UnPackTo(IMontagesConfigT _o)
		{
			_o.Montages = new List<IMontageConfigT>();
			for (int i = 0; i < this.MontagesLength; i++)
			{
				_o.Montages.Add((this.Montages(i) != null) ? this.Montages(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D909 RID: 121097 RVA: 0x004267E8 File Offset: 0x004249E8
		public static Offset<IMontagesConfig> Pack(FlatBufferBuilder builder, IMontagesConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontagesConfig>);
			}
			VectorOffset montagesOffset = default(VectorOffset);
			if (_o.Montages != null)
			{
				Offset<IMontageConfig>[] array = new Offset<IMontageConfig>[_o.Montages.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMontageConfig.Pack(builder, _o.Montages[i]);
				}
				montagesOffset = IMontagesConfig.CreateMontagesVector(builder, array);
			}
			return IMontagesConfig.CreateIMontagesConfig(builder, montagesOffset);
		}

		// Token: 0x0400D460 RID: 54368
		private Table __p;
	}
}
