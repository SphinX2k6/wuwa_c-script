using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004742 RID: 18242
	public struct IMontagesConfig : IFlatbufferObject
	{
		// Token: 0x170082E6 RID: 33510
		// (get) Token: 0x0601C121 RID: 114977 RVA: 0x003FA2FC File Offset: 0x003F84FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C122 RID: 114978 RVA: 0x003FA309 File Offset: 0x003F8509
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C123 RID: 114979 RVA: 0x003FA310 File Offset: 0x003F8510
		public static IMontagesConfig GetRootAsIMontagesConfig(ByteBuffer _bb)
		{
			return IMontagesConfig.GetRootAsIMontagesConfig(_bb, default(IMontagesConfig));
		}

		// Token: 0x0601C124 RID: 114980 RVA: 0x003FA32C File Offset: 0x003F852C
		public static IMontagesConfig GetRootAsIMontagesConfig(ByteBuffer _bb, IMontagesConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C125 RID: 114981 RVA: 0x003FA349 File Offset: 0x003F8549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C126 RID: 114982 RVA: 0x003FA358 File Offset: 0x003F8558
		public IMontagesConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C127 RID: 114983 RVA: 0x003FA368 File Offset: 0x003F8568
		public IMontageConfig? Montages(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IMontageConfig?(default(IMontageConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082E7 RID: 33511
		// (get) Token: 0x0601C128 RID: 114984 RVA: 0x003FA3C8 File Offset: 0x003F85C8
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

		// Token: 0x0601C129 RID: 114985 RVA: 0x003FA3F3 File Offset: 0x003F85F3
		public static Offset<IMontagesConfig> CreateIMontagesConfig(FlatBufferBuilder builder, VectorOffset MontagesOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IMontagesConfig.AddMontages(builder, MontagesOffset);
			return IMontagesConfig.EndIMontagesConfig(builder);
		}

		// Token: 0x0601C12A RID: 114986 RVA: 0x003FA409 File Offset: 0x003F8609
		public static void StartIMontagesConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C12B RID: 114987 RVA: 0x003FA412 File Offset: 0x003F8612
		public static void AddMontages(FlatBufferBuilder builder, VectorOffset montagesOffset)
		{
			builder.AddOffset(0, montagesOffset.Value, 0);
		}

		// Token: 0x0601C12C RID: 114988 RVA: 0x003FA424 File Offset: 0x003F8624
		public static VectorOffset CreateMontagesVector(FlatBufferBuilder builder, Offset<IMontageConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C12D RID: 114989 RVA: 0x003FA464 File Offset: 0x003F8664
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, Offset<IMontageConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C12E RID: 114990 RVA: 0x003FA47E File Offset: 0x003F867E
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C12F RID: 114991 RVA: 0x003FA49C File Offset: 0x003F869C
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C130 RID: 114992 RVA: 0x003FA4B5 File Offset: 0x003F86B5
		public static void StartMontagesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C131 RID: 114993 RVA: 0x003FA4C0 File Offset: 0x003F86C0
		public static Offset<IMontagesConfig> EndIMontagesConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMontagesConfig>(builder.EndTable());
		}

		// Token: 0x0601C132 RID: 114994 RVA: 0x003FA4D0 File Offset: 0x003F86D0
		public IMontagesConfigT UnPack()
		{
			IMontagesConfigT montagesConfigT = new IMontagesConfigT();
			this.UnPackTo(montagesConfigT);
			return montagesConfigT;
		}

		// Token: 0x0601C133 RID: 114995 RVA: 0x003FA4EC File Offset: 0x003F86EC
		public void UnPackTo(IMontagesConfigT _o)
		{
			_o.Montages = new List<IMontageConfigT>();
			for (int i = 0; i < this.MontagesLength; i++)
			{
				_o.Montages.Add((this.Montages(i) != null) ? this.Montages(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C134 RID: 114996 RVA: 0x003FA54C File Offset: 0x003F874C
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

		// Token: 0x0400CA31 RID: 51761
		private Table __p;
	}
}
