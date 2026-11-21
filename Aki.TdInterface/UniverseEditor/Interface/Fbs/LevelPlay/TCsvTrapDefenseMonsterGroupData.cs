using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A5B RID: 19035
	public struct TCsvTrapDefenseMonsterGroupData : IFlatbufferObject
	{
		// Token: 0x17008592 RID: 34194
		// (get) Token: 0x0601C9D0 RID: 117200 RVA: 0x00409B68 File Offset: 0x00407D68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C9D1 RID: 117201 RVA: 0x00409B75 File Offset: 0x00407D75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C9D2 RID: 117202 RVA: 0x00409B7C File Offset: 0x00407D7C
		public static TCsvTrapDefenseMonsterGroupData GetRootAsTCsvTrapDefenseMonsterGroupData(ByteBuffer _bb)
		{
			return TCsvTrapDefenseMonsterGroupData.GetRootAsTCsvTrapDefenseMonsterGroupData(_bb, default(TCsvTrapDefenseMonsterGroupData));
		}

		// Token: 0x0601C9D3 RID: 117203 RVA: 0x00409B98 File Offset: 0x00407D98
		public static TCsvTrapDefenseMonsterGroupData GetRootAsTCsvTrapDefenseMonsterGroupData(ByteBuffer _bb, TCsvTrapDefenseMonsterGroupData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C9D4 RID: 117204 RVA: 0x00409BB5 File Offset: 0x00407DB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C9D5 RID: 117205 RVA: 0x00409BC4 File Offset: 0x00407DC4
		public TCsvTrapDefenseMonsterGroupData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008593 RID: 34195
		// (get) Token: 0x0601C9D6 RID: 117206 RVA: 0x00409BD4 File Offset: 0x00407DD4
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

		// Token: 0x0601C9D7 RID: 117207 RVA: 0x00409C10 File Offset: 0x00407E10
		public ITrapDefenseMonsterGroup? Monsters(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITrapDefenseMonsterGroup?(default(ITrapDefenseMonsterGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008594 RID: 34196
		// (get) Token: 0x0601C9D8 RID: 117208 RVA: 0x00409C70 File Offset: 0x00407E70
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

		// Token: 0x0601C9D9 RID: 117209 RVA: 0x00409C9B File Offset: 0x00407E9B
		public static Offset<TCsvTrapDefenseMonsterGroupData> CreateTCsvTrapDefenseMonsterGroupData(FlatBufferBuilder builder, int Id = 0, VectorOffset MonstersOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			TCsvTrapDefenseMonsterGroupData.AddMonsters(builder, MonstersOffset);
			TCsvTrapDefenseMonsterGroupData.AddId(builder, Id);
			return TCsvTrapDefenseMonsterGroupData.EndTCsvTrapDefenseMonsterGroupData(builder);
		}

		// Token: 0x0601C9DA RID: 117210 RVA: 0x00409CB8 File Offset: 0x00407EB8
		public static void StartTCsvTrapDefenseMonsterGroupData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C9DB RID: 117211 RVA: 0x00409CC1 File Offset: 0x00407EC1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C9DC RID: 117212 RVA: 0x00409CCC File Offset: 0x00407ECC
		public static void AddMonsters(FlatBufferBuilder builder, VectorOffset monstersOffset)
		{
			builder.AddOffset(1, monstersOffset.Value, 0);
		}

		// Token: 0x0601C9DD RID: 117213 RVA: 0x00409CDC File Offset: 0x00407EDC
		public static VectorOffset CreateMonstersVector(FlatBufferBuilder builder, Offset<ITrapDefenseMonsterGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C9DE RID: 117214 RVA: 0x00409D1C File Offset: 0x00407F1C
		public static VectorOffset CreateMonstersVectorBlock(FlatBufferBuilder builder, Offset<ITrapDefenseMonsterGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITrapDefenseMonsterGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9DF RID: 117215 RVA: 0x00409D36 File Offset: 0x00407F36
		public static VectorOffset CreateMonstersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITrapDefenseMonsterGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITrapDefenseMonsterGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9E0 RID: 117216 RVA: 0x00409D54 File Offset: 0x00407F54
		public static VectorOffset CreateMonstersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITrapDefenseMonsterGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C9E1 RID: 117217 RVA: 0x00409D6D File Offset: 0x00407F6D
		public static void StartMonstersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C9E2 RID: 117218 RVA: 0x00409D78 File Offset: 0x00407F78
		public static Offset<TCsvTrapDefenseMonsterGroupData> EndTCsvTrapDefenseMonsterGroupData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTrapDefenseMonsterGroupData>(builder.EndTable());
		}

		// Token: 0x0601C9E3 RID: 117219 RVA: 0x00409D88 File Offset: 0x00407F88
		public TCsvTrapDefenseMonsterGroupDataT UnPack()
		{
			TCsvTrapDefenseMonsterGroupDataT tcsvTrapDefenseMonsterGroupDataT = new TCsvTrapDefenseMonsterGroupDataT();
			this.UnPackTo(tcsvTrapDefenseMonsterGroupDataT);
			return tcsvTrapDefenseMonsterGroupDataT;
		}

		// Token: 0x0601C9E4 RID: 117220 RVA: 0x00409DA4 File Offset: 0x00407FA4
		public void UnPackTo(TCsvTrapDefenseMonsterGroupDataT _o)
		{
			_o.Id = this.Id;
			_o.Monsters = new List<ITrapDefenseMonsterGroupT>();
			for (int i = 0; i < this.MonstersLength; i++)
			{
				_o.Monsters.Add((this.Monsters(i) != null) ? this.Monsters(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C9E5 RID: 117221 RVA: 0x00409E10 File Offset: 0x00408010
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

		// Token: 0x0400D104 RID: 53508
		private Table __p;
	}
}
