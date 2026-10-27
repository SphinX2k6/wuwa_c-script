using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557B RID: 21883
	public struct IMonsterGachaItemComponent : IFlatbufferObject
	{
		// Token: 0x1700A1B8 RID: 41400
		// (get) Token: 0x06024387 RID: 148359 RVA: 0x00500A7B File Offset: 0x004FEC7B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024388 RID: 148360 RVA: 0x00500A88 File Offset: 0x004FEC88
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024389 RID: 148361 RVA: 0x00500A90 File Offset: 0x004FEC90
		public static IMonsterGachaItemComponent GetRootAsIMonsterGachaItemComponent(ByteBuffer _bb)
		{
			return IMonsterGachaItemComponent.GetRootAsIMonsterGachaItemComponent(_bb, default(IMonsterGachaItemComponent));
		}

		// Token: 0x0602438A RID: 148362 RVA: 0x00500AAC File Offset: 0x004FECAC
		public static IMonsterGachaItemComponent GetRootAsIMonsterGachaItemComponent(ByteBuffer _bb, IMonsterGachaItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602438B RID: 148363 RVA: 0x00500AC9 File Offset: 0x004FECC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602438C RID: 148364 RVA: 0x00500AD8 File Offset: 0x004FECD8
		public IMonsterGachaItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1B9 RID: 41401
		// (get) Token: 0x0602438D RID: 148365 RVA: 0x00500AE8 File Offset: 0x004FECE8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A1BA RID: 41402
		// (get) Token: 0x0602438E RID: 148366 RVA: 0x00500B28 File Offset: 0x004FED28
		public string MaterialDataPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602438F RID: 148367 RVA: 0x00500B5F File Offset: 0x004FED5F
		public Span<byte> GetMaterialDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024390 RID: 148368 RVA: 0x00500B6E File Offset: 0x004FED6E
		public byte[] GetMaterialDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A1BB RID: 41403
		// (get) Token: 0x06024391 RID: 148369 RVA: 0x00500B7C File Offset: 0x004FED7C
		public EMonsterMatchType MonsterType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EMonsterMatchType.Normal;
				}
				return (EMonsterMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024392 RID: 148370 RVA: 0x00500BB8 File Offset: 0x004FEDB8
		public int MonsterEntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A1BC RID: 41404
		// (get) Token: 0x06024393 RID: 148371 RVA: 0x00500BF8 File Offset: 0x004FEDF8
		public int MonsterEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06024394 RID: 148372 RVA: 0x00500C24 File Offset: 0x004FEE24
		public Span<int> GetMonsterEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06024395 RID: 148373 RVA: 0x00500C34 File Offset: 0x004FEE34
		public int[] GetMonsterEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700A1BD RID: 41405
		// (get) Token: 0x06024396 RID: 148374 RVA: 0x00500C44 File Offset: 0x004FEE44
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024397 RID: 148375 RVA: 0x00500C81 File Offset: 0x004FEE81
		public static Offset<IMonsterGachaItemComponent> CreateIMonsterGachaItemComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset MaterialDataPathOffset = default(StringOffset), EMonsterMatchType MonsterType = EMonsterMatchType.Normal, VectorOffset MonsterEntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IMonsterGachaItemComponent.AddMonsterEntityIds(builder, MonsterEntityIdsOffset);
			IMonsterGachaItemComponent.AddMaterialDataPath(builder, MaterialDataPathOffset);
			IMonsterGachaItemComponent.AddNullMask(builder, NullMask);
			IMonsterGachaItemComponent.AddMonsterType(builder, MonsterType);
			IMonsterGachaItemComponent.AddDisabled(builder, Disabled);
			return IMonsterGachaItemComponent.EndIMonsterGachaItemComponent(builder);
		}

		// Token: 0x06024398 RID: 148376 RVA: 0x00500CB5 File Offset: 0x004FEEB5
		public static void StartIMonsterGachaItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024399 RID: 148377 RVA: 0x00500CBE File Offset: 0x004FEEBE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602439A RID: 148378 RVA: 0x00500CC9 File Offset: 0x004FEEC9
		public static void AddMaterialDataPath(FlatBufferBuilder builder, StringOffset materialDataPathOffset)
		{
			builder.AddOffset(1, materialDataPathOffset.Value, 0);
		}

		// Token: 0x0602439B RID: 148379 RVA: 0x00500CD9 File Offset: 0x004FEED9
		public static void AddMonsterType(FlatBufferBuilder builder, EMonsterMatchType monsterType)
		{
			builder.AddByte(2, (byte)monsterType, 0);
		}

		// Token: 0x0602439C RID: 148380 RVA: 0x00500CE4 File Offset: 0x004FEEE4
		public static void AddMonsterEntityIds(FlatBufferBuilder builder, VectorOffset monsterEntityIdsOffset)
		{
			builder.AddOffset(3, monsterEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602439D RID: 148381 RVA: 0x00500CF4 File Offset: 0x004FEEF4
		public static VectorOffset CreateMonsterEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602439E RID: 148382 RVA: 0x00500D2B File Offset: 0x004FEF2B
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602439F RID: 148383 RVA: 0x00500D45 File Offset: 0x004FEF45
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060243A0 RID: 148384 RVA: 0x00500D63 File Offset: 0x004FEF63
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060243A1 RID: 148385 RVA: 0x00500D7C File Offset: 0x004FEF7C
		public static void StartMonsterEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060243A2 RID: 148386 RVA: 0x00500D87 File Offset: 0x004FEF87
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060243A3 RID: 148387 RVA: 0x00500D92 File Offset: 0x004FEF92
		public static Offset<IMonsterGachaItemComponent> EndIMonsterGachaItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterGachaItemComponent>(builder.EndTable());
		}

		// Token: 0x060243A4 RID: 148388 RVA: 0x00500DA0 File Offset: 0x004FEFA0
		public IMonsterGachaItemComponentT UnPack()
		{
			IMonsterGachaItemComponentT monsterGachaItemComponentT = new IMonsterGachaItemComponentT();
			this.UnPackTo(monsterGachaItemComponentT);
			return monsterGachaItemComponentT;
		}

		// Token: 0x060243A5 RID: 148389 RVA: 0x00500DBC File Offset: 0x004FEFBC
		public void UnPackTo(IMonsterGachaItemComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MaterialDataPath = this.MaterialDataPath;
			_o.MonsterType = this.MonsterType;
			_o.MonsterEntityIds = new List<int>();
			for (int i = 0; i < this.MonsterEntityIdsLength; i++)
			{
				_o.MonsterEntityIds.Add(this.MonsterEntityIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060243A6 RID: 148390 RVA: 0x00500E28 File Offset: 0x004FF028
		public static Offset<IMonsterGachaItemComponent> Pack(FlatBufferBuilder builder, IMonsterGachaItemComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterGachaItemComponent>);
			}
			StringOffset materialDataPathOffset = (_o.MaterialDataPath == null) ? default(StringOffset) : builder.CreateString(_o.MaterialDataPath);
			VectorOffset monsterEntityIdsOffset = default(VectorOffset);
			if (_o.MonsterEntityIds != null)
			{
				int[] data = _o.MonsterEntityIds.ToArray();
				monsterEntityIdsOffset = IMonsterGachaItemComponent.CreateMonsterEntityIdsVector(builder, data);
			}
			return IMonsterGachaItemComponent.CreateIMonsterGachaItemComponent(builder, _o.Disabled, materialDataPathOffset, _o.MonsterType, monsterEntityIdsOffset, _o.NullMask);
		}

		// Token: 0x0400E8A8 RID: 59560
		private Table __p;
	}
}
