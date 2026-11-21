using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200490E RID: 18702
	public struct IDynamicSpawnMonsterRandomPoolConfigs : IFlatbufferObject
	{
		// Token: 0x17008243 RID: 33347
		// (get) Token: 0x0601BBA5 RID: 113573 RVA: 0x003EBCAB File Offset: 0x003E9EAB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BBA6 RID: 113574 RVA: 0x003EBCB8 File Offset: 0x003E9EB8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BBA7 RID: 113575 RVA: 0x003EBCC0 File Offset: 0x003E9EC0
		public static IDynamicSpawnMonsterRandomPoolConfigs GetRootAsIDynamicSpawnMonsterRandomPoolConfigs(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterRandomPoolConfigs.GetRootAsIDynamicSpawnMonsterRandomPoolConfigs(_bb, default(IDynamicSpawnMonsterRandomPoolConfigs));
		}

		// Token: 0x0601BBA8 RID: 113576 RVA: 0x003EBCDC File Offset: 0x003E9EDC
		public static IDynamicSpawnMonsterRandomPoolConfigs GetRootAsIDynamicSpawnMonsterRandomPoolConfigs(ByteBuffer _bb, IDynamicSpawnMonsterRandomPoolConfigs obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BBA9 RID: 113577 RVA: 0x003EBCF9 File Offset: 0x003E9EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BBAA RID: 113578 RVA: 0x003EBD08 File Offset: 0x003E9F08
		public IDynamicSpawnMonsterRandomPoolConfigs __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601BBAB RID: 113579 RVA: 0x003EBD18 File Offset: 0x003E9F18
		public IDynamicSpawnMonsterRandomPoolConfig? Pools(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSpawnMonsterRandomPoolConfig?(default(IDynamicSpawnMonsterRandomPoolConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008244 RID: 33348
		// (get) Token: 0x0601BBAC RID: 113580 RVA: 0x003EBD78 File Offset: 0x003E9F78
		public int PoolsLength
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

		// Token: 0x0601BBAD RID: 113581 RVA: 0x003EBDA3 File Offset: 0x003E9FA3
		public static Offset<IDynamicSpawnMonsterRandomPoolConfigs> CreateIDynamicSpawnMonsterRandomPoolConfigs(FlatBufferBuilder builder, VectorOffset PoolsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IDynamicSpawnMonsterRandomPoolConfigs.AddPools(builder, PoolsOffset);
			return IDynamicSpawnMonsterRandomPoolConfigs.EndIDynamicSpawnMonsterRandomPoolConfigs(builder);
		}

		// Token: 0x0601BBAE RID: 113582 RVA: 0x003EBDB9 File Offset: 0x003E9FB9
		public static void StartIDynamicSpawnMonsterRandomPoolConfigs(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BBAF RID: 113583 RVA: 0x003EBDC2 File Offset: 0x003E9FC2
		public static void AddPools(FlatBufferBuilder builder, VectorOffset poolsOffset)
		{
			builder.AddOffset(0, poolsOffset.Value, 0);
		}

		// Token: 0x0601BBB0 RID: 113584 RVA: 0x003EBDD4 File Offset: 0x003E9FD4
		public static VectorOffset CreatePoolsVector(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterRandomPoolConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BBB1 RID: 113585 RVA: 0x003EBE14 File Offset: 0x003EA014
		public static VectorOffset CreatePoolsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterRandomPoolConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSpawnMonsterRandomPoolConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BBB2 RID: 113586 RVA: 0x003EBE2E File Offset: 0x003EA02E
		public static VectorOffset CreatePoolsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSpawnMonsterRandomPoolConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSpawnMonsterRandomPoolConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BBB3 RID: 113587 RVA: 0x003EBE4C File Offset: 0x003EA04C
		public static VectorOffset CreatePoolsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSpawnMonsterRandomPoolConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BBB4 RID: 113588 RVA: 0x003EBE65 File Offset: 0x003EA065
		public static void StartPoolsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BBB5 RID: 113589 RVA: 0x003EBE70 File Offset: 0x003EA070
		public static Offset<IDynamicSpawnMonsterRandomPoolConfigs> EndIDynamicSpawnMonsterRandomPoolConfigs(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterRandomPoolConfigs>(builder.EndTable());
		}

		// Token: 0x0601BBB6 RID: 113590 RVA: 0x003EBE80 File Offset: 0x003EA080
		public IDynamicSpawnMonsterRandomPoolConfigsT UnPack()
		{
			IDynamicSpawnMonsterRandomPoolConfigsT dynamicSpawnMonsterRandomPoolConfigsT = new IDynamicSpawnMonsterRandomPoolConfigsT();
			this.UnPackTo(dynamicSpawnMonsterRandomPoolConfigsT);
			return dynamicSpawnMonsterRandomPoolConfigsT;
		}

		// Token: 0x0601BBB7 RID: 113591 RVA: 0x003EBE9C File Offset: 0x003EA09C
		public void UnPackTo(IDynamicSpawnMonsterRandomPoolConfigsT _o)
		{
			_o.Pools = new List<IDynamicSpawnMonsterRandomPoolConfigT>();
			for (int i = 0; i < this.PoolsLength; i++)
			{
				_o.Pools.Add((this.Pools(i) != null) ? this.Pools(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601BBB8 RID: 113592 RVA: 0x003EBEFC File Offset: 0x003EA0FC
		public static Offset<IDynamicSpawnMonsterRandomPoolConfigs> Pack(FlatBufferBuilder builder, IDynamicSpawnMonsterRandomPoolConfigsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSpawnMonsterRandomPoolConfigs>);
			}
			VectorOffset poolsOffset = default(VectorOffset);
			if (_o.Pools != null)
			{
				Offset<IDynamicSpawnMonsterRandomPoolConfig>[] array = new Offset<IDynamicSpawnMonsterRandomPoolConfig>[_o.Pools.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDynamicSpawnMonsterRandomPoolConfig.Pack(builder, _o.Pools[i]);
				}
				poolsOffset = IDynamicSpawnMonsterRandomPoolConfigs.CreatePoolsVector(builder, array);
			}
			return IDynamicSpawnMonsterRandomPoolConfigs.CreateIDynamicSpawnMonsterRandomPoolConfigs(builder, poolsOffset);
		}

		// Token: 0x0400CEDE RID: 52958
		private Table __p;
	}
}
