using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045F6 RID: 17910
	public struct TCsvTrapDefenseWaveData : IFlatbufferObject
	{
		// Token: 0x17007F56 RID: 32598
		// (get) Token: 0x0601B217 RID: 111127 RVA: 0x003DDC78 File Offset: 0x003DBE78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B218 RID: 111128 RVA: 0x003DDC85 File Offset: 0x003DBE85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B219 RID: 111129 RVA: 0x003DDC8C File Offset: 0x003DBE8C
		public static TCsvTrapDefenseWaveData GetRootAsTCsvTrapDefenseWaveData(ByteBuffer _bb)
		{
			return TCsvTrapDefenseWaveData.GetRootAsTCsvTrapDefenseWaveData(_bb, default(TCsvTrapDefenseWaveData));
		}

		// Token: 0x0601B21A RID: 111130 RVA: 0x003DDCA8 File Offset: 0x003DBEA8
		public static TCsvTrapDefenseWaveData GetRootAsTCsvTrapDefenseWaveData(ByteBuffer _bb, TCsvTrapDefenseWaveData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B21B RID: 111131 RVA: 0x003DDCC5 File Offset: 0x003DBEC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B21C RID: 111132 RVA: 0x003DDCD4 File Offset: 0x003DBED4
		public TCsvTrapDefenseWaveData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F57 RID: 32599
		// (get) Token: 0x0601B21D RID: 111133 RVA: 0x003DDCE4 File Offset: 0x003DBEE4
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

		// Token: 0x0601B21E RID: 111134 RVA: 0x003DDD20 File Offset: 0x003DBF20
		public ITrapDefenseSpawnMonster? SpawnMonsters(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITrapDefenseSpawnMonster?(default(ITrapDefenseSpawnMonster).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007F58 RID: 32600
		// (get) Token: 0x0601B21F RID: 111135 RVA: 0x003DDD80 File Offset: 0x003DBF80
		public int SpawnMonstersLength
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

		// Token: 0x0601B220 RID: 111136 RVA: 0x003DDDAB File Offset: 0x003DBFAB
		public static Offset<TCsvTrapDefenseWaveData> CreateTCsvTrapDefenseWaveData(FlatBufferBuilder builder, int Id = 0, VectorOffset SpawnMonstersOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			TCsvTrapDefenseWaveData.AddSpawnMonsters(builder, SpawnMonstersOffset);
			TCsvTrapDefenseWaveData.AddId(builder, Id);
			return TCsvTrapDefenseWaveData.EndTCsvTrapDefenseWaveData(builder);
		}

		// Token: 0x0601B221 RID: 111137 RVA: 0x003DDDC8 File Offset: 0x003DBFC8
		public static void StartTCsvTrapDefenseWaveData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B222 RID: 111138 RVA: 0x003DDDD1 File Offset: 0x003DBFD1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B223 RID: 111139 RVA: 0x003DDDDC File Offset: 0x003DBFDC
		public static void AddSpawnMonsters(FlatBufferBuilder builder, VectorOffset spawnMonstersOffset)
		{
			builder.AddOffset(1, spawnMonstersOffset.Value, 0);
		}

		// Token: 0x0601B224 RID: 111140 RVA: 0x003DDDEC File Offset: 0x003DBFEC
		public static VectorOffset CreateSpawnMonstersVector(FlatBufferBuilder builder, Offset<ITrapDefenseSpawnMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B225 RID: 111141 RVA: 0x003DDE2C File Offset: 0x003DC02C
		public static VectorOffset CreateSpawnMonstersVectorBlock(FlatBufferBuilder builder, Offset<ITrapDefenseSpawnMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITrapDefenseSpawnMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B226 RID: 111142 RVA: 0x003DDE46 File Offset: 0x003DC046
		public static VectorOffset CreateSpawnMonstersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITrapDefenseSpawnMonster>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITrapDefenseSpawnMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B227 RID: 111143 RVA: 0x003DDE64 File Offset: 0x003DC064
		public static VectorOffset CreateSpawnMonstersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITrapDefenseSpawnMonster>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B228 RID: 111144 RVA: 0x003DDE7D File Offset: 0x003DC07D
		public static void StartSpawnMonstersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B229 RID: 111145 RVA: 0x003DDE88 File Offset: 0x003DC088
		public static Offset<TCsvTrapDefenseWaveData> EndTCsvTrapDefenseWaveData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTrapDefenseWaveData>(builder.EndTable());
		}

		// Token: 0x0601B22A RID: 111146 RVA: 0x003DDE98 File Offset: 0x003DC098
		public TCsvTrapDefenseWaveDataT UnPack()
		{
			TCsvTrapDefenseWaveDataT tcsvTrapDefenseWaveDataT = new TCsvTrapDefenseWaveDataT();
			this.UnPackTo(tcsvTrapDefenseWaveDataT);
			return tcsvTrapDefenseWaveDataT;
		}

		// Token: 0x0601B22B RID: 111147 RVA: 0x003DDEB4 File Offset: 0x003DC0B4
		public void UnPackTo(TCsvTrapDefenseWaveDataT _o)
		{
			_o.Id = this.Id;
			_o.SpawnMonsters = new List<ITrapDefenseSpawnMonsterT>();
			for (int i = 0; i < this.SpawnMonstersLength; i++)
			{
				_o.SpawnMonsters.Add((this.SpawnMonsters(i) != null) ? this.SpawnMonsters(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B22C RID: 111148 RVA: 0x003DDF20 File Offset: 0x003DC120
		public static Offset<TCsvTrapDefenseWaveData> Pack(FlatBufferBuilder builder, TCsvTrapDefenseWaveDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvTrapDefenseWaveData>);
			}
			VectorOffset spawnMonstersOffset = default(VectorOffset);
			if (_o.SpawnMonsters != null)
			{
				Offset<ITrapDefenseSpawnMonster>[] array = new Offset<ITrapDefenseSpawnMonster>[_o.SpawnMonsters.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITrapDefenseSpawnMonster.Pack(builder, _o.SpawnMonsters[i]);
				}
				spawnMonstersOffset = TCsvTrapDefenseWaveData.CreateSpawnMonstersVector(builder, array);
			}
			return TCsvTrapDefenseWaveData.CreateTCsvTrapDefenseWaveData(builder, _o.Id, spawnMonstersOffset);
		}

		// Token: 0x0400C6D8 RID: 50904
		private Table __p;
	}
}
