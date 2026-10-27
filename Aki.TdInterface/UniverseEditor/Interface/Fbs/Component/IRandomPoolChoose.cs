using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F0 RID: 22512
	public struct IRandomPoolChoose : IFlatbufferObject
	{
		// Token: 0x1700A825 RID: 43045
		// (get) Token: 0x06025D50 RID: 154960 RVA: 0x00537B82 File Offset: 0x00535D82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D51 RID: 154961 RVA: 0x00537B8F File Offset: 0x00535D8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D52 RID: 154962 RVA: 0x00537B98 File Offset: 0x00535D98
		public static IRandomPoolChoose GetRootAsIRandomPoolChoose(ByteBuffer _bb)
		{
			return IRandomPoolChoose.GetRootAsIRandomPoolChoose(_bb, default(IRandomPoolChoose));
		}

		// Token: 0x06025D53 RID: 154963 RVA: 0x00537BB4 File Offset: 0x00535DB4
		public static IRandomPoolChoose GetRootAsIRandomPoolChoose(ByteBuffer _bb, IRandomPoolChoose obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D54 RID: 154964 RVA: 0x00537BD1 File Offset: 0x00535DD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D55 RID: 154965 RVA: 0x00537BE0 File Offset: 0x00535DE0
		public IRandomPoolChoose __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A826 RID: 43046
		// (get) Token: 0x06025D56 RID: 154966 RVA: 0x00537BF0 File Offset: 0x00535DF0
		public EMonsterChooseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterChooseType.RandomPoolChoose;
				}
				return (EMonsterChooseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025D57 RID: 154967 RVA: 0x00537C2C File Offset: 0x00535E2C
		public IRandomPoolConfig? RandomPoolConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRandomPoolConfig?(default(IRandomPoolConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A827 RID: 43047
		// (get) Token: 0x06025D58 RID: 154968 RVA: 0x00537C8C File Offset: 0x00535E8C
		public int RandomPoolConfigsLength
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

		// Token: 0x06025D59 RID: 154969 RVA: 0x00537CB7 File Offset: 0x00535EB7
		public static Offset<IRandomPoolChoose> CreateIRandomPoolChoose(FlatBufferBuilder builder, EMonsterChooseType Type = EMonsterChooseType.RandomPoolChoose, VectorOffset RandomPoolConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRandomPoolChoose.AddRandomPoolConfigs(builder, RandomPoolConfigsOffset);
			IRandomPoolChoose.AddType(builder, Type);
			return IRandomPoolChoose.EndIRandomPoolChoose(builder);
		}

		// Token: 0x06025D5A RID: 154970 RVA: 0x00537CD4 File Offset: 0x00535ED4
		public static void StartIRandomPoolChoose(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025D5B RID: 154971 RVA: 0x00537CDD File Offset: 0x00535EDD
		public static void AddType(FlatBufferBuilder builder, EMonsterChooseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025D5C RID: 154972 RVA: 0x00537CE8 File Offset: 0x00535EE8
		public static void AddRandomPoolConfigs(FlatBufferBuilder builder, VectorOffset randomPoolConfigsOffset)
		{
			builder.AddOffset(1, randomPoolConfigsOffset.Value, 0);
		}

		// Token: 0x06025D5D RID: 154973 RVA: 0x00537CF8 File Offset: 0x00535EF8
		public static VectorOffset CreateRandomPoolConfigsVector(FlatBufferBuilder builder, Offset<IRandomPoolConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025D5E RID: 154974 RVA: 0x00537D38 File Offset: 0x00535F38
		public static VectorOffset CreateRandomPoolConfigsVectorBlock(FlatBufferBuilder builder, Offset<IRandomPoolConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRandomPoolConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025D5F RID: 154975 RVA: 0x00537D52 File Offset: 0x00535F52
		public static VectorOffset CreateRandomPoolConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRandomPoolConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRandomPoolConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025D60 RID: 154976 RVA: 0x00537D70 File Offset: 0x00535F70
		public static VectorOffset CreateRandomPoolConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRandomPoolConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025D61 RID: 154977 RVA: 0x00537D89 File Offset: 0x00535F89
		public static void StartRandomPoolConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025D62 RID: 154978 RVA: 0x00537D94 File Offset: 0x00535F94
		public static Offset<IRandomPoolChoose> EndIRandomPoolChoose(FlatBufferBuilder builder)
		{
			return new Offset<IRandomPoolChoose>(builder.EndTable());
		}

		// Token: 0x06025D63 RID: 154979 RVA: 0x00537DA4 File Offset: 0x00535FA4
		public IRandomPoolChooseT UnPack()
		{
			IRandomPoolChooseT randomPoolChooseT = new IRandomPoolChooseT();
			this.UnPackTo(randomPoolChooseT);
			return randomPoolChooseT;
		}

		// Token: 0x06025D64 RID: 154980 RVA: 0x00537DC0 File Offset: 0x00535FC0
		public void UnPackTo(IRandomPoolChooseT _o)
		{
			_o.Type = this.Type;
			_o.RandomPoolConfigs = new List<IRandomPoolConfigT>();
			for (int i = 0; i < this.RandomPoolConfigsLength; i++)
			{
				_o.RandomPoolConfigs.Add((this.RandomPoolConfigs(i) != null) ? this.RandomPoolConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025D65 RID: 154981 RVA: 0x00537E2C File Offset: 0x0053602C
		public static Offset<IRandomPoolChoose> Pack(FlatBufferBuilder builder, IRandomPoolChooseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomPoolChoose>);
			}
			VectorOffset randomPoolConfigsOffset = default(VectorOffset);
			if (_o.RandomPoolConfigs != null)
			{
				Offset<IRandomPoolConfig>[] array = new Offset<IRandomPoolConfig>[_o.RandomPoolConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRandomPoolConfig.Pack(builder, _o.RandomPoolConfigs[i]);
				}
				randomPoolConfigsOffset = IRandomPoolChoose.CreateRandomPoolConfigsVector(builder, array);
			}
			return IRandomPoolChoose.CreateIRandomPoolChoose(builder, _o.Type, randomPoolConfigsOffset);
		}

		// Token: 0x0400ECE3 RID: 60643
		private Table __p;
	}
}
