using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200490B RID: 18699
	public struct IDynamicSpawnMonsterRandomPoolConfig : IFlatbufferObject
	{
		// Token: 0x1700823C RID: 33340
		// (get) Token: 0x0601BB85 RID: 113541 RVA: 0x003EB872 File Offset: 0x003E9A72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BB86 RID: 113542 RVA: 0x003EB87F File Offset: 0x003E9A7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BB87 RID: 113543 RVA: 0x003EB888 File Offset: 0x003E9A88
		public static IDynamicSpawnMonsterRandomPoolConfig GetRootAsIDynamicSpawnMonsterRandomPoolConfig(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterRandomPoolConfig.GetRootAsIDynamicSpawnMonsterRandomPoolConfig(_bb, default(IDynamicSpawnMonsterRandomPoolConfig));
		}

		// Token: 0x0601BB88 RID: 113544 RVA: 0x003EB8A4 File Offset: 0x003E9AA4
		public static IDynamicSpawnMonsterRandomPoolConfig GetRootAsIDynamicSpawnMonsterRandomPoolConfig(ByteBuffer _bb, IDynamicSpawnMonsterRandomPoolConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BB89 RID: 113545 RVA: 0x003EB8C1 File Offset: 0x003E9AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BB8A RID: 113546 RVA: 0x003EB8D0 File Offset: 0x003E9AD0
		public IDynamicSpawnMonsterRandomPoolConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700823D RID: 33341
		// (get) Token: 0x0601BB8B RID: 113547 RVA: 0x003EB8E0 File Offset: 0x003E9AE0
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

		// Token: 0x1700823E RID: 33342
		// (get) Token: 0x0601BB8C RID: 113548 RVA: 0x003EB91C File Offset: 0x003E9B1C
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

		// Token: 0x0601BB8D RID: 113549 RVA: 0x003EB958 File Offset: 0x003E9B58
		public IDynamicSpawnMonsterGroup? MonsterGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSpawnMonsterGroup?(default(IDynamicSpawnMonsterGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700823F RID: 33343
		// (get) Token: 0x0601BB8E RID: 113550 RVA: 0x003EB9B8 File Offset: 0x003E9BB8
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

		// Token: 0x0601BB8F RID: 113551 RVA: 0x003EB9E3 File Offset: 0x003E9BE3
		public static Offset<IDynamicSpawnMonsterRandomPoolConfig> CreateIDynamicSpawnMonsterRandomPoolConfig(FlatBufferBuilder builder, int Id = 0, EMonsterSourceType MonsterSource = EMonsterSourceType.EntityTemplate, VectorOffset MonsterGroupOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDynamicSpawnMonsterRandomPoolConfig.AddMonsterGroup(builder, MonsterGroupOffset);
			IDynamicSpawnMonsterRandomPoolConfig.AddId(builder, Id);
			IDynamicSpawnMonsterRandomPoolConfig.AddMonsterSource(builder, MonsterSource);
			return IDynamicSpawnMonsterRandomPoolConfig.EndIDynamicSpawnMonsterRandomPoolConfig(builder);
		}

		// Token: 0x0601BB90 RID: 113552 RVA: 0x003EBA07 File Offset: 0x003E9C07
		public static void StartIDynamicSpawnMonsterRandomPoolConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BB91 RID: 113553 RVA: 0x003EBA10 File Offset: 0x003E9C10
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601BB92 RID: 113554 RVA: 0x003EBA1B File Offset: 0x003E9C1B
		public static void AddMonsterSource(FlatBufferBuilder builder, EMonsterSourceType monsterSource)
		{
			builder.AddByte(1, (byte)monsterSource, 0);
		}

		// Token: 0x0601BB93 RID: 113555 RVA: 0x003EBA26 File Offset: 0x003E9C26
		public static void AddMonsterGroup(FlatBufferBuilder builder, VectorOffset monsterGroupOffset)
		{
			builder.AddOffset(2, monsterGroupOffset.Value, 0);
		}

		// Token: 0x0601BB94 RID: 113556 RVA: 0x003EBA38 File Offset: 0x003E9C38
		public static VectorOffset CreateMonsterGroupVector(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BB95 RID: 113557 RVA: 0x003EBA78 File Offset: 0x003E9C78
		public static VectorOffset CreateMonsterGroupVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSpawnMonsterGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB96 RID: 113558 RVA: 0x003EBA92 File Offset: 0x003E9C92
		public static VectorOffset CreateMonsterGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSpawnMonsterGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSpawnMonsterGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB97 RID: 113559 RVA: 0x003EBAB0 File Offset: 0x003E9CB0
		public static VectorOffset CreateMonsterGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSpawnMonsterGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BB98 RID: 113560 RVA: 0x003EBAC9 File Offset: 0x003E9CC9
		public static void StartMonsterGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BB99 RID: 113561 RVA: 0x003EBAD4 File Offset: 0x003E9CD4
		public static Offset<IDynamicSpawnMonsterRandomPoolConfig> EndIDynamicSpawnMonsterRandomPoolConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterRandomPoolConfig>(builder.EndTable());
		}

		// Token: 0x0601BB9A RID: 113562 RVA: 0x003EBAE4 File Offset: 0x003E9CE4
		public IDynamicSpawnMonsterRandomPoolConfigT UnPack()
		{
			IDynamicSpawnMonsterRandomPoolConfigT dynamicSpawnMonsterRandomPoolConfigT = new IDynamicSpawnMonsterRandomPoolConfigT();
			this.UnPackTo(dynamicSpawnMonsterRandomPoolConfigT);
			return dynamicSpawnMonsterRandomPoolConfigT;
		}

		// Token: 0x0601BB9B RID: 113563 RVA: 0x003EBB00 File Offset: 0x003E9D00
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

		// Token: 0x0601BB9C RID: 113564 RVA: 0x003EBB78 File Offset: 0x003E9D78
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

		// Token: 0x0400CEDA RID: 52954
		private Table __p;
	}
}
