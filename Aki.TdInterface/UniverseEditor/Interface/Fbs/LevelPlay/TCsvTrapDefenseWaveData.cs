using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A5E RID: 19038
	public struct TCsvTrapDefenseWaveData : IFlatbufferObject
	{
		// Token: 0x17008597 RID: 34199
		// (get) Token: 0x0601C9EC RID: 117228 RVA: 0x00409F14 File Offset: 0x00408114
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C9ED RID: 117229 RVA: 0x00409F21 File Offset: 0x00408121
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C9EE RID: 117230 RVA: 0x00409F28 File Offset: 0x00408128
		public static TCsvTrapDefenseWaveData GetRootAsTCsvTrapDefenseWaveData(ByteBuffer _bb)
		{
			return TCsvTrapDefenseWaveData.GetRootAsTCsvTrapDefenseWaveData(_bb, default(TCsvTrapDefenseWaveData));
		}

		// Token: 0x0601C9EF RID: 117231 RVA: 0x00409F44 File Offset: 0x00408144
		public static TCsvTrapDefenseWaveData GetRootAsTCsvTrapDefenseWaveData(ByteBuffer _bb, TCsvTrapDefenseWaveData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C9F0 RID: 117232 RVA: 0x00409F61 File Offset: 0x00408161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C9F1 RID: 117233 RVA: 0x00409F70 File Offset: 0x00408170
		public TCsvTrapDefenseWaveData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008598 RID: 34200
		// (get) Token: 0x0601C9F2 RID: 117234 RVA: 0x00409F80 File Offset: 0x00408180
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

		// Token: 0x0601C9F3 RID: 117235 RVA: 0x00409FBC File Offset: 0x004081BC
		public ITrapDefenseSpawnMonster? SpawnMonsters(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITrapDefenseSpawnMonster?(default(ITrapDefenseSpawnMonster).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008599 RID: 34201
		// (get) Token: 0x0601C9F4 RID: 117236 RVA: 0x0040A01C File Offset: 0x0040821C
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

		// Token: 0x0601C9F5 RID: 117237 RVA: 0x0040A047 File Offset: 0x00408247
		public static Offset<TCsvTrapDefenseWaveData> CreateTCsvTrapDefenseWaveData(FlatBufferBuilder builder, int Id = 0, VectorOffset SpawnMonstersOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			TCsvTrapDefenseWaveData.AddSpawnMonsters(builder, SpawnMonstersOffset);
			TCsvTrapDefenseWaveData.AddId(builder, Id);
			return TCsvTrapDefenseWaveData.EndTCsvTrapDefenseWaveData(builder);
		}

		// Token: 0x0601C9F6 RID: 117238 RVA: 0x0040A064 File Offset: 0x00408264
		public static void StartTCsvTrapDefenseWaveData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C9F7 RID: 117239 RVA: 0x0040A06D File Offset: 0x0040826D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C9F8 RID: 117240 RVA: 0x0040A078 File Offset: 0x00408278
		public static void AddSpawnMonsters(FlatBufferBuilder builder, VectorOffset spawnMonstersOffset)
		{
			builder.AddOffset(1, spawnMonstersOffset.Value, 0);
		}

		// Token: 0x0601C9F9 RID: 117241 RVA: 0x0040A088 File Offset: 0x00408288
		public static VectorOffset CreateSpawnMonstersVector(FlatBufferBuilder builder, Offset<ITrapDefenseSpawnMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C9FA RID: 117242 RVA: 0x0040A0C8 File Offset: 0x004082C8
		public static VectorOffset CreateSpawnMonstersVectorBlock(FlatBufferBuilder builder, Offset<ITrapDefenseSpawnMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITrapDefenseSpawnMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9FB RID: 117243 RVA: 0x0040A0E2 File Offset: 0x004082E2
		public static VectorOffset CreateSpawnMonstersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITrapDefenseSpawnMonster>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITrapDefenseSpawnMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9FC RID: 117244 RVA: 0x0040A100 File Offset: 0x00408300
		public static VectorOffset CreateSpawnMonstersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITrapDefenseSpawnMonster>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C9FD RID: 117245 RVA: 0x0040A119 File Offset: 0x00408319
		public static void StartSpawnMonstersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C9FE RID: 117246 RVA: 0x0040A124 File Offset: 0x00408324
		public static Offset<TCsvTrapDefenseWaveData> EndTCsvTrapDefenseWaveData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTrapDefenseWaveData>(builder.EndTable());
		}

		// Token: 0x0601C9FF RID: 117247 RVA: 0x0040A134 File Offset: 0x00408334
		public TCsvTrapDefenseWaveDataT UnPack()
		{
			TCsvTrapDefenseWaveDataT tcsvTrapDefenseWaveDataT = new TCsvTrapDefenseWaveDataT();
			this.UnPackTo(tcsvTrapDefenseWaveDataT);
			return tcsvTrapDefenseWaveDataT;
		}

		// Token: 0x0601CA00 RID: 117248 RVA: 0x0040A150 File Offset: 0x00408350
		public void UnPackTo(TCsvTrapDefenseWaveDataT _o)
		{
			_o.Id = this.Id;
			_o.SpawnMonsters = new List<ITrapDefenseSpawnMonsterT>();
			for (int i = 0; i < this.SpawnMonstersLength; i++)
			{
				_o.SpawnMonsters.Add((this.SpawnMonsters(i) != null) ? this.SpawnMonsters(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601CA01 RID: 117249 RVA: 0x0040A1BC File Offset: 0x004083BC
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

		// Token: 0x0400D107 RID: 53511
		private Table __p;
	}
}
