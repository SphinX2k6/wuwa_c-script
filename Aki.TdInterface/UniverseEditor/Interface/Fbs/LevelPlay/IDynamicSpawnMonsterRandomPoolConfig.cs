using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044A3 RID: 17571
	public struct IDynamicSpawnMonsterRandomPoolConfig : IFlatbufferObject
	{
		// Token: 0x17007BFD RID: 31741
		// (get) Token: 0x0601A3B4 RID: 107444 RVA: 0x003BF666 File Offset: 0x003BD866
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A3B5 RID: 107445 RVA: 0x003BF673 File Offset: 0x003BD873
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A3B6 RID: 107446 RVA: 0x003BF67C File Offset: 0x003BD87C
		public static IDynamicSpawnMonsterRandomPoolConfig GetRootAsIDynamicSpawnMonsterRandomPoolConfig(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterRandomPoolConfig.GetRootAsIDynamicSpawnMonsterRandomPoolConfig(_bb, default(IDynamicSpawnMonsterRandomPoolConfig));
		}

		// Token: 0x0601A3B7 RID: 107447 RVA: 0x003BF698 File Offset: 0x003BD898
		public static IDynamicSpawnMonsterRandomPoolConfig GetRootAsIDynamicSpawnMonsterRandomPoolConfig(ByteBuffer _bb, IDynamicSpawnMonsterRandomPoolConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A3B8 RID: 107448 RVA: 0x003BF6B5 File Offset: 0x003BD8B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A3B9 RID: 107449 RVA: 0x003BF6C4 File Offset: 0x003BD8C4
		public IDynamicSpawnMonsterRandomPoolConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BFE RID: 31742
		// (get) Token: 0x0601A3BA RID: 107450 RVA: 0x003BF6D4 File Offset: 0x003BD8D4
		public int Id
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

		// Token: 0x17007BFF RID: 31743
		// (get) Token: 0x0601A3BB RID: 107451 RVA: 0x003BF710 File Offset: 0x003BD910
		public EMonsterSourceType MonsterSource
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EMonsterSourceType.EntityTemplate;
				}
				return (EMonsterSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A3BC RID: 107452 RVA: 0x003BF74C File Offset: 0x003BD94C
		public IDynamicSpawnMonsterGroup? MonsterGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSpawnMonsterGroup?(default(IDynamicSpawnMonsterGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007C00 RID: 31744
		// (get) Token: 0x0601A3BD RID: 107453 RVA: 0x003BF7AC File Offset: 0x003BD9AC
		public int MonsterGroupLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601A3BE RID: 107454 RVA: 0x003BF7D7 File Offset: 0x003BD9D7
		public static Offset<IDynamicSpawnMonsterRandomPoolConfig> CreateIDynamicSpawnMonsterRandomPoolConfig(FlatBufferBuilder builder, int Id = 0, EMonsterSourceType MonsterSource = EMonsterSourceType.EntityTemplate, VectorOffset MonsterGroupOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDynamicSpawnMonsterRandomPoolConfig.AddMonsterGroup(builder, MonsterGroupOffset);
			IDynamicSpawnMonsterRandomPoolConfig.AddId(builder, Id);
			IDynamicSpawnMonsterRandomPoolConfig.AddMonsterSource(builder, MonsterSource);
			return IDynamicSpawnMonsterRandomPoolConfig.EndIDynamicSpawnMonsterRandomPoolConfig(builder);
		}

		// Token: 0x0601A3BF RID: 107455 RVA: 0x003BF7FB File Offset: 0x003BD9FB
		public static void StartIDynamicSpawnMonsterRandomPoolConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A3C0 RID: 107456 RVA: 0x003BF804 File Offset: 0x003BDA04
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A3C1 RID: 107457 RVA: 0x003BF80F File Offset: 0x003BDA0F
		public static void AddMonsterSource(FlatBufferBuilder builder, EMonsterSourceType monsterSource)
		{
			builder.AddByte(1, (byte)monsterSource, 0);
		}

		// Token: 0x0601A3C2 RID: 107458 RVA: 0x003BF81A File Offset: 0x003BDA1A
		public static void AddMonsterGroup(FlatBufferBuilder builder, VectorOffset monsterGroupOffset)
		{
			builder.AddOffset(2, monsterGroupOffset.Value, 0);
		}

		// Token: 0x0601A3C3 RID: 107459 RVA: 0x003BF82C File Offset: 0x003BDA2C
		public static VectorOffset CreateMonsterGroupVector(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A3C4 RID: 107460 RVA: 0x003BF86C File Offset: 0x003BDA6C
		public static VectorOffset CreateMonsterGroupVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSpawnMonsterGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A3C5 RID: 107461 RVA: 0x003BF886 File Offset: 0x003BDA86
		public static VectorOffset CreateMonsterGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSpawnMonsterGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSpawnMonsterGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A3C6 RID: 107462 RVA: 0x003BF8A4 File Offset: 0x003BDAA4
		public static VectorOffset CreateMonsterGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSpawnMonsterGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A3C7 RID: 107463 RVA: 0x003BF8BD File Offset: 0x003BDABD
		public static void StartMonsterGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A3C8 RID: 107464 RVA: 0x003BF8C8 File Offset: 0x003BDAC8
		public static Offset<IDynamicSpawnMonsterRandomPoolConfig> EndIDynamicSpawnMonsterRandomPoolConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterRandomPoolConfig>(builder.EndTable());
		}

		// Token: 0x0601A3C9 RID: 107465 RVA: 0x003BF8D8 File Offset: 0x003BDAD8
		public IDynamicSpawnMonsterRandomPoolConfigT UnPack()
		{
			IDynamicSpawnMonsterRandomPoolConfigT dynamicSpawnMonsterRandomPoolConfigT = new IDynamicSpawnMonsterRandomPoolConfigT();
			this.UnPackTo(dynamicSpawnMonsterRandomPoolConfigT);
			return dynamicSpawnMonsterRandomPoolConfigT;
		}

		// Token: 0x0601A3CA RID: 107466 RVA: 0x003BF8F4 File Offset: 0x003BDAF4
		public void UnPackTo(IDynamicSpawnMonsterRandomPoolConfigT _o)
		{
			_o.Id = this.Id;
			_o.MonsterSource = this.MonsterSource;
			_o.MonsterGroup = new List<IDynamicSpawnMonsterGroupT>();
			for (int i = 0; i < this.MonsterGroupLength; i++)
			{
				_o.MonsterGroup.Add((this.MonsterGroup(i) != null) ? this.MonsterGroup(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601A3CB RID: 107467 RVA: 0x003BF96C File Offset: 0x003BDB6C
		public static Offset<IDynamicSpawnMonsterRandomPoolConfig> Pack(FlatBufferBuilder builder, IDynamicSpawnMonsterRandomPoolConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSpawnMonsterRandomPoolConfig>);
			}
			VectorOffset monsterGroupOffset = default(VectorOffset);
			if (_o.MonsterGroup != null)
			{
				Offset<IDynamicSpawnMonsterGroup>[] array = new Offset<IDynamicSpawnMonsterGroup>[_o.MonsterGroup.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDynamicSpawnMonsterGroup.Pack(builder, _o.MonsterGroup[i]);
				}
				monsterGroupOffset = IDynamicSpawnMonsterRandomPoolConfig.CreateMonsterGroupVector(builder, array);
			}
			return IDynamicSpawnMonsterRandomPoolConfig.CreateIDynamicSpawnMonsterRandomPoolConfig(builder, _o.Id, _o.MonsterSource, monsterGroupOffset);
		}

		// Token: 0x0400C4AC RID: 50348
		private Table __p;
	}
}
