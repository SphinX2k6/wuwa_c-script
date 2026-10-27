using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679E RID: 26526
	public struct IFindSunSpirit : IFlatbufferObject
	{
		// Token: 0x1700C4E6 RID: 50406
		// (get) Token: 0x0602E27E RID: 189054 RVA: 0x0064DD85 File Offset: 0x0064BF85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E27F RID: 189055 RVA: 0x0064DD92 File Offset: 0x0064BF92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E280 RID: 189056 RVA: 0x0064DD9C File Offset: 0x0064BF9C
		public static IFindSunSpirit GetRootAsIFindSunSpirit(ByteBuffer _bb)
		{
			return IFindSunSpirit.GetRootAsIFindSunSpirit(_bb, default(IFindSunSpirit));
		}

		// Token: 0x0602E281 RID: 189057 RVA: 0x0064DDB8 File Offset: 0x0064BFB8
		public static IFindSunSpirit GetRootAsIFindSunSpirit(ByteBuffer _bb, IFindSunSpirit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E282 RID: 189058 RVA: 0x0064DDD5 File Offset: 0x0064BFD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E283 RID: 189059 RVA: 0x0064DDE4 File Offset: 0x0064BFE4
		public IFindSunSpirit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4E7 RID: 50407
		// (get) Token: 0x0602E284 RID: 189060 RVA: 0x0064DDF4 File Offset: 0x0064BFF4
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4E8 RID: 50408
		// (get) Token: 0x0602E285 RID: 189061 RVA: 0x0064DE30 File Offset: 0x0064C030
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4E9 RID: 50409
		// (get) Token: 0x0602E286 RID: 189062 RVA: 0x0064DE6C File Offset: 0x0064C06C
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C4EA RID: 50410
		// (get) Token: 0x0602E287 RID: 189063 RVA: 0x0064DECC File Offset: 0x0064C0CC
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E288 RID: 189064 RVA: 0x0064DF2C File Offset: 0x0064C12C
		public int SunSpiritEntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C4EB RID: 50411
		// (get) Token: 0x0602E289 RID: 189065 RVA: 0x0064DF6C File Offset: 0x0064C16C
		public int SunSpiritEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602E28A RID: 189066 RVA: 0x0064DF98 File Offset: 0x0064C198
		public Span<int> GetSunSpiritEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0602E28B RID: 189067 RVA: 0x0064DFA8 File Offset: 0x0064C1A8
		public int[] GetSunSpiritEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x0602E28C RID: 189068 RVA: 0x0064DFB8 File Offset: 0x0064C1B8
		public int TargetLocationIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C4EC RID: 50412
		// (get) Token: 0x0602E28D RID: 189069 RVA: 0x0064DFF8 File Offset: 0x0064C1F8
		public int TargetLocationIdsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602E28E RID: 189070 RVA: 0x0064E024 File Offset: 0x0064C224
		public Span<int> GetTargetLocationIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0602E28F RID: 189071 RVA: 0x0064E034 File Offset: 0x0064C234
		public int[] GetTargetLocationIdsArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700C4ED RID: 50413
		// (get) Token: 0x0602E290 RID: 189072 RVA: 0x0064E044 File Offset: 0x0064C244
		public ISunSpiritDifficultyReduction? DifficultyReductionConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ISunSpiritDifficultyReduction?(default(ISunSpiritDifficultyReduction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E291 RID: 189073 RVA: 0x0064E0A4 File Offset: 0x0064C2A4
		public static Offset<IFindSunSpirit> CreateIFindSunSpirit(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Id = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), VectorOffset SunSpiritEntityIdsOffset = default(VectorOffset), VectorOffset TargetLocationIdsOffset = default(VectorOffset), Offset<ISunSpiritDifficultyReduction> DifficultyReductionConfigOffset = default(Offset<ISunSpiritDifficultyReduction>))
		{
			builder.StartTable(7);
			IFindSunSpirit.AddDifficultyReductionConfig(builder, DifficultyReductionConfigOffset);
			IFindSunSpirit.AddTargetLocationIds(builder, TargetLocationIdsOffset);
			IFindSunSpirit.AddSunSpiritEntityIds(builder, SunSpiritEntityIdsOffset);
			IFindSunSpirit.AddDirection(builder, DirectionOffset);
			IFindSunSpirit.AddPos(builder, PosOffset);
			IFindSunSpirit.AddId(builder, Id);
			IFindSunSpirit.AddType(builder, Type);
			return IFindSunSpirit.EndIFindSunSpirit(builder);
		}

		// Token: 0x0602E292 RID: 189074 RVA: 0x0064E0F3 File Offset: 0x0064C2F3
		public static void StartIFindSunSpirit(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602E293 RID: 189075 RVA: 0x0064E0FC File Offset: 0x0064C2FC
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E294 RID: 189076 RVA: 0x0064E107 File Offset: 0x0064C307
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602E295 RID: 189077 RVA: 0x0064E112 File Offset: 0x0064C312
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0602E296 RID: 189078 RVA: 0x0064E122 File Offset: 0x0064C322
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(3, directionOffset.Value, 0);
		}

		// Token: 0x0602E297 RID: 189079 RVA: 0x0064E132 File Offset: 0x0064C332
		public static void AddSunSpiritEntityIds(FlatBufferBuilder builder, VectorOffset sunSpiritEntityIdsOffset)
		{
			builder.AddOffset(4, sunSpiritEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602E298 RID: 189080 RVA: 0x0064E144 File Offset: 0x0064C344
		public static VectorOffset CreateSunSpiritEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E299 RID: 189081 RVA: 0x0064E17B File Offset: 0x0064C37B
		public static VectorOffset CreateSunSpiritEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E29A RID: 189082 RVA: 0x0064E195 File Offset: 0x0064C395
		public static VectorOffset CreateSunSpiritEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E29B RID: 189083 RVA: 0x0064E1B3 File Offset: 0x0064C3B3
		public static VectorOffset CreateSunSpiritEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E29C RID: 189084 RVA: 0x0064E1CC File Offset: 0x0064C3CC
		public static void StartSunSpiritEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E29D RID: 189085 RVA: 0x0064E1D7 File Offset: 0x0064C3D7
		public static void AddTargetLocationIds(FlatBufferBuilder builder, VectorOffset targetLocationIdsOffset)
		{
			builder.AddOffset(5, targetLocationIdsOffset.Value, 0);
		}

		// Token: 0x0602E29E RID: 189086 RVA: 0x0064E1E8 File Offset: 0x0064C3E8
		public static VectorOffset CreateTargetLocationIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E29F RID: 189087 RVA: 0x0064E21F File Offset: 0x0064C41F
		public static VectorOffset CreateTargetLocationIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E2A0 RID: 189088 RVA: 0x0064E239 File Offset: 0x0064C439
		public static VectorOffset CreateTargetLocationIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E2A1 RID: 189089 RVA: 0x0064E257 File Offset: 0x0064C457
		public static VectorOffset CreateTargetLocationIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E2A2 RID: 189090 RVA: 0x0064E270 File Offset: 0x0064C470
		public static void StartTargetLocationIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E2A3 RID: 189091 RVA: 0x0064E27B File Offset: 0x0064C47B
		public static void AddDifficultyReductionConfig(FlatBufferBuilder builder, Offset<ISunSpiritDifficultyReduction> difficultyReductionConfigOffset)
		{
			builder.AddOffset(6, difficultyReductionConfigOffset.Value, 0);
		}

		// Token: 0x0602E2A4 RID: 189092 RVA: 0x0064E28B File Offset: 0x0064C48B
		public static Offset<IFindSunSpirit> EndIFindSunSpirit(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpirit>(builder.EndTable());
		}

		// Token: 0x0602E2A5 RID: 189093 RVA: 0x0064E298 File Offset: 0x0064C498
		public IFindSunSpiritT UnPack()
		{
			IFindSunSpiritT findSunSpiritT = new IFindSunSpiritT();
			this.UnPackTo(findSunSpiritT);
			return findSunSpiritT;
		}

		// Token: 0x0602E2A6 RID: 189094 RVA: 0x0064E2B4 File Offset: 0x0064C4B4
		public void UnPackTo(IFindSunSpiritT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.SunSpiritEntityIds = new List<int>();
			for (int i = 0; i < this.SunSpiritEntityIdsLength; i++)
			{
				_o.SunSpiritEntityIds.Add(this.SunSpiritEntityIds(i));
			}
			_o.TargetLocationIds = new List<int>();
			for (int j = 0; j < this.TargetLocationIdsLength; j++)
			{
				_o.TargetLocationIds.Add(this.TargetLocationIds(j));
			}
			_o.DifficultyReductionConfig = ((this.DifficultyReductionConfig != null) ? this.DifficultyReductionConfig.Value.UnPack() : null);
		}

		// Token: 0x0602E2A7 RID: 189095 RVA: 0x0064E3C8 File Offset: 0x0064C5C8
		public static Offset<IFindSunSpirit> Pack(FlatBufferBuilder builder, IFindSunSpiritT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpirit>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			VectorOffset sunSpiritEntityIdsOffset = default(VectorOffset);
			if (_o.SunSpiritEntityIds != null)
			{
				int[] data = _o.SunSpiritEntityIds.ToArray();
				sunSpiritEntityIdsOffset = IFindSunSpirit.CreateSunSpiritEntityIdsVector(builder, data);
			}
			VectorOffset targetLocationIdsOffset = default(VectorOffset);
			if (_o.TargetLocationIds != null)
			{
				int[] data2 = _o.TargetLocationIds.ToArray();
				targetLocationIdsOffset = IFindSunSpirit.CreateTargetLocationIdsVector(builder, data2);
			}
			Offset<ISunSpiritDifficultyReduction> difficultyReductionConfigOffset = (_o.DifficultyReductionConfig == null) ? default(Offset<ISunSpiritDifficultyReduction>) : ISunSpiritDifficultyReduction.Pack(builder, _o.DifficultyReductionConfig);
			return IFindSunSpirit.CreateIFindSunSpirit(builder, _o.Type, _o.Id, posOffset, directionOffset, sunSpiritEntityIdsOffset, targetLocationIdsOffset, difficultyReductionConfigOffset);
		}

		// Token: 0x04010EAC RID: 69292
		private Table __p;
	}
}
