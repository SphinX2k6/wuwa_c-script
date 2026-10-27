using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044A6 RID: 17574
	public struct IDynamicSpawnMonsterRandomPoolConfigs : IFlatbufferObject
	{
		// Token: 0x17007C04 RID: 31748
		// (get) Token: 0x0601A3D4 RID: 107476 RVA: 0x003BFA9F File Offset: 0x003BDC9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A3D5 RID: 107477 RVA: 0x003BFAAC File Offset: 0x003BDCAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A3D6 RID: 107478 RVA: 0x003BFAB4 File Offset: 0x003BDCB4
		public static IDynamicSpawnMonsterRandomPoolConfigs GetRootAsIDynamicSpawnMonsterRandomPoolConfigs(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterRandomPoolConfigs.GetRootAsIDynamicSpawnMonsterRandomPoolConfigs(_bb, default(IDynamicSpawnMonsterRandomPoolConfigs));
		}

		// Token: 0x0601A3D7 RID: 107479 RVA: 0x003BFAD0 File Offset: 0x003BDCD0
		public static IDynamicSpawnMonsterRandomPoolConfigs GetRootAsIDynamicSpawnMonsterRandomPoolConfigs(ByteBuffer _bb, IDynamicSpawnMonsterRandomPoolConfigs obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A3D8 RID: 107480 RVA: 0x003BFAED File Offset: 0x003BDCED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A3D9 RID: 107481 RVA: 0x003BFAFC File Offset: 0x003BDCFC
		public IDynamicSpawnMonsterRandomPoolConfigs __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601A3DA RID: 107482 RVA: 0x003BFB0C File Offset: 0x003BDD0C
		public IDynamicSpawnMonsterRandomPoolConfig? Pools(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSpawnMonsterRandomPoolConfig?(default(IDynamicSpawnMonsterRandomPoolConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007C05 RID: 31749
		// (get) Token: 0x0601A3DB RID: 107483 RVA: 0x003BFB6C File Offset: 0x003BDD6C
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

		// Token: 0x0601A3DC RID: 107484 RVA: 0x003BFB97 File Offset: 0x003BDD97
		public static Offset<IDynamicSpawnMonsterRandomPoolConfigs> CreateIDynamicSpawnMonsterRandomPoolConfigs(FlatBufferBuilder builder, VectorOffset PoolsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IDynamicSpawnMonsterRandomPoolConfigs.AddPools(builder, PoolsOffset);
			return IDynamicSpawnMonsterRandomPoolConfigs.EndIDynamicSpawnMonsterRandomPoolConfigs(builder);
		}

		// Token: 0x0601A3DD RID: 107485 RVA: 0x003BFBAD File Offset: 0x003BDDAD
		public static void StartIDynamicSpawnMonsterRandomPoolConfigs(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A3DE RID: 107486 RVA: 0x003BFBB6 File Offset: 0x003BDDB6
		public static void AddPools(FlatBufferBuilder builder, VectorOffset poolsOffset)
		{
			builder.AddOffset(0, poolsOffset.Value, 0);
		}

		// Token: 0x0601A3DF RID: 107487 RVA: 0x003BFBC8 File Offset: 0x003BDDC8
		public static VectorOffset CreatePoolsVector(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterRandomPoolConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A3E0 RID: 107488 RVA: 0x003BFC08 File Offset: 0x003BDE08
		public static VectorOffset CreatePoolsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterRandomPoolConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSpawnMonsterRandomPoolConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A3E1 RID: 107489 RVA: 0x003BFC22 File Offset: 0x003BDE22
		public static VectorOffset CreatePoolsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSpawnMonsterRandomPoolConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSpawnMonsterRandomPoolConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A3E2 RID: 107490 RVA: 0x003BFC40 File Offset: 0x003BDE40
		public static VectorOffset CreatePoolsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSpawnMonsterRandomPoolConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A3E3 RID: 107491 RVA: 0x003BFC59 File Offset: 0x003BDE59
		public static void StartPoolsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A3E4 RID: 107492 RVA: 0x003BFC64 File Offset: 0x003BDE64
		public static Offset<IDynamicSpawnMonsterRandomPoolConfigs> EndIDynamicSpawnMonsterRandomPoolConfigs(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterRandomPoolConfigs>(builder.EndTable());
		}

		// Token: 0x0601A3E5 RID: 107493 RVA: 0x003BFC74 File Offset: 0x003BDE74
		public IDynamicSpawnMonsterRandomPoolConfigsT UnPack()
		{
			IDynamicSpawnMonsterRandomPoolConfigsT dynamicSpawnMonsterRandomPoolConfigsT = new IDynamicSpawnMonsterRandomPoolConfigsT();
			this.UnPackTo(dynamicSpawnMonsterRandomPoolConfigsT);
			return dynamicSpawnMonsterRandomPoolConfigsT;
		}

		// Token: 0x0601A3E6 RID: 107494 RVA: 0x003BFC90 File Offset: 0x003BDE90
		public void UnPackTo(IDynamicSpawnMonsterRandomPoolConfigsT _o)
		{
			_o.Pools = new List<IDynamicSpawnMonsterRandomPoolConfigT>();
			for (int i = 0; i < this.PoolsLength; i++)
			{
				_o.Pools.Add((this.Pools(i) != null) ? this.Pools(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601A3E7 RID: 107495 RVA: 0x003BFCF0 File Offset: 0x003BDEF0
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

		// Token: 0x0400C4B0 RID: 50352
		private Table __p;
	}
}
