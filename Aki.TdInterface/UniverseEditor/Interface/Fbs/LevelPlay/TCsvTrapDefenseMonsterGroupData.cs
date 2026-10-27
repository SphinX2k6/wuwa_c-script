using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045F3 RID: 17907
	public struct TCsvTrapDefenseMonsterGroupData : IFlatbufferObject
	{
		// Token: 0x17007F51 RID: 32593
		// (get) Token: 0x0601B1FB RID: 111099 RVA: 0x003DD8CC File Offset: 0x003DBACC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B1FC RID: 111100 RVA: 0x003DD8D9 File Offset: 0x003DBAD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B1FD RID: 111101 RVA: 0x003DD8E0 File Offset: 0x003DBAE0
		public static TCsvTrapDefenseMonsterGroupData GetRootAsTCsvTrapDefenseMonsterGroupData(ByteBuffer _bb)
		{
			return TCsvTrapDefenseMonsterGroupData.GetRootAsTCsvTrapDefenseMonsterGroupData(_bb, default(TCsvTrapDefenseMonsterGroupData));
		}

		// Token: 0x0601B1FE RID: 111102 RVA: 0x003DD8FC File Offset: 0x003DBAFC
		public static TCsvTrapDefenseMonsterGroupData GetRootAsTCsvTrapDefenseMonsterGroupData(ByteBuffer _bb, TCsvTrapDefenseMonsterGroupData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B1FF RID: 111103 RVA: 0x003DD919 File Offset: 0x003DBB19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B200 RID: 111104 RVA: 0x003DD928 File Offset: 0x003DBB28
		public TCsvTrapDefenseMonsterGroupData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F52 RID: 32594
		// (get) Token: 0x0601B201 RID: 111105 RVA: 0x003DD938 File Offset: 0x003DBB38
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

		// Token: 0x0601B202 RID: 111106 RVA: 0x003DD974 File Offset: 0x003DBB74
		public ITrapDefenseMonsterGroup? Monsters(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITrapDefenseMonsterGroup?(default(ITrapDefenseMonsterGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007F53 RID: 32595
		// (get) Token: 0x0601B203 RID: 111107 RVA: 0x003DD9D4 File Offset: 0x003DBBD4
		public int MonstersLength
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

		// Token: 0x0601B204 RID: 111108 RVA: 0x003DD9FF File Offset: 0x003DBBFF
		public static Offset<TCsvTrapDefenseMonsterGroupData> CreateTCsvTrapDefenseMonsterGroupData(FlatBufferBuilder builder, int Id = 0, VectorOffset MonstersOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			TCsvTrapDefenseMonsterGroupData.AddMonsters(builder, MonstersOffset);
			TCsvTrapDefenseMonsterGroupData.AddId(builder, Id);
			return TCsvTrapDefenseMonsterGroupData.EndTCsvTrapDefenseMonsterGroupData(builder);
		}

		// Token: 0x0601B205 RID: 111109 RVA: 0x003DDA1C File Offset: 0x003DBC1C
		public static void StartTCsvTrapDefenseMonsterGroupData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B206 RID: 111110 RVA: 0x003DDA25 File Offset: 0x003DBC25
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B207 RID: 111111 RVA: 0x003DDA30 File Offset: 0x003DBC30
		public static void AddMonsters(FlatBufferBuilder builder, VectorOffset monstersOffset)
		{
			builder.AddOffset(1, monstersOffset.Value, 0);
		}

		// Token: 0x0601B208 RID: 111112 RVA: 0x003DDA40 File Offset: 0x003DBC40
		public static VectorOffset CreateMonstersVector(FlatBufferBuilder builder, Offset<ITrapDefenseMonsterGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B209 RID: 111113 RVA: 0x003DDA80 File Offset: 0x003DBC80
		public static VectorOffset CreateMonstersVectorBlock(FlatBufferBuilder builder, Offset<ITrapDefenseMonsterGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITrapDefenseMonsterGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B20A RID: 111114 RVA: 0x003DDA9A File Offset: 0x003DBC9A
		public static VectorOffset CreateMonstersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITrapDefenseMonsterGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITrapDefenseMonsterGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B20B RID: 111115 RVA: 0x003DDAB8 File Offset: 0x003DBCB8
		public static VectorOffset CreateMonstersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITrapDefenseMonsterGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B20C RID: 111116 RVA: 0x003DDAD1 File Offset: 0x003DBCD1
		public static void StartMonstersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B20D RID: 111117 RVA: 0x003DDADC File Offset: 0x003DBCDC
		public static Offset<TCsvTrapDefenseMonsterGroupData> EndTCsvTrapDefenseMonsterGroupData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTrapDefenseMonsterGroupData>(builder.EndTable());
		}

		// Token: 0x0601B20E RID: 111118 RVA: 0x003DDAEC File Offset: 0x003DBCEC
		public TCsvTrapDefenseMonsterGroupDataT UnPack()
		{
			TCsvTrapDefenseMonsterGroupDataT tcsvTrapDefenseMonsterGroupDataT = new TCsvTrapDefenseMonsterGroupDataT();
			this.UnPackTo(tcsvTrapDefenseMonsterGroupDataT);
			return tcsvTrapDefenseMonsterGroupDataT;
		}

		// Token: 0x0601B20F RID: 111119 RVA: 0x003DDB08 File Offset: 0x003DBD08
		public void UnPackTo(TCsvTrapDefenseMonsterGroupDataT _o)
		{
			_o.Id = this.Id;
			_o.Monsters = new List<ITrapDefenseMonsterGroupT>();
			for (int i = 0; i < this.MonstersLength; i++)
			{
				_o.Monsters.Add((this.Monsters(i) != null) ? this.Monsters(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B210 RID: 111120 RVA: 0x003DDB74 File Offset: 0x003DBD74
		public static Offset<TCsvTrapDefenseMonsterGroupData> Pack(FlatBufferBuilder builder, TCsvTrapDefenseMonsterGroupDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvTrapDefenseMonsterGroupData>);
			}
			VectorOffset monstersOffset = default(VectorOffset);
			if (_o.Monsters != null)
			{
				Offset<ITrapDefenseMonsterGroup>[] array = new Offset<ITrapDefenseMonsterGroup>[_o.Monsters.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITrapDefenseMonsterGroup.Pack(builder, _o.Monsters[i]);
				}
				monstersOffset = TCsvTrapDefenseMonsterGroupData.CreateMonstersVector(builder, array);
			}
			return TCsvTrapDefenseMonsterGroupData.CreateTCsvTrapDefenseMonsterGroupData(builder, _o.Id, monstersOffset);
		}

		// Token: 0x0400C6D5 RID: 50901
		private Table __p;
	}
}
