using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E1E RID: 28190
	public struct IFindSunSpirit : IFlatbufferObject
	{
		// Token: 0x1700CE9C RID: 52892
		// (get) Token: 0x06030AC4 RID: 199364 RVA: 0x0069B4C9 File Offset: 0x006996C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030AC5 RID: 199365 RVA: 0x0069B4D6 File Offset: 0x006996D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030AC6 RID: 199366 RVA: 0x0069B4E0 File Offset: 0x006996E0
		public static IFindSunSpirit GetRootAsIFindSunSpirit(ByteBuffer _bb)
		{
			return IFindSunSpirit.GetRootAsIFindSunSpirit(_bb, default(IFindSunSpirit));
		}

		// Token: 0x06030AC7 RID: 199367 RVA: 0x0069B4FC File Offset: 0x006996FC
		public static IFindSunSpirit GetRootAsIFindSunSpirit(ByteBuffer _bb, IFindSunSpirit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030AC8 RID: 199368 RVA: 0x0069B519 File Offset: 0x00699719
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030AC9 RID: 199369 RVA: 0x0069B528 File Offset: 0x00699728
		public IFindSunSpirit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE9D RID: 52893
		// (get) Token: 0x06030ACA RID: 199370 RVA: 0x0069B538 File Offset: 0x00699738
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

		// Token: 0x1700CE9E RID: 52894
		// (get) Token: 0x06030ACB RID: 199371 RVA: 0x0069B574 File Offset: 0x00699774
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

		// Token: 0x1700CE9F RID: 52895
		// (get) Token: 0x06030ACC RID: 199372 RVA: 0x0069B5B0 File Offset: 0x006997B0
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

		// Token: 0x1700CEA0 RID: 52896
		// (get) Token: 0x06030ACD RID: 199373 RVA: 0x0069B610 File Offset: 0x00699810
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

		// Token: 0x06030ACE RID: 199374 RVA: 0x0069B670 File Offset: 0x00699870
		public int SunSpiritEntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CEA1 RID: 52897
		// (get) Token: 0x06030ACF RID: 199375 RVA: 0x0069B6B0 File Offset: 0x006998B0
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

		// Token: 0x06030AD0 RID: 199376 RVA: 0x0069B6DC File Offset: 0x006998DC
		public Span<int> GetSunSpiritEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06030AD1 RID: 199377 RVA: 0x0069B6EC File Offset: 0x006998EC
		public int[] GetSunSpiritEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x06030AD2 RID: 199378 RVA: 0x0069B6FC File Offset: 0x006998FC
		public int TargetLocationIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CEA2 RID: 52898
		// (get) Token: 0x06030AD3 RID: 199379 RVA: 0x0069B73C File Offset: 0x0069993C
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

		// Token: 0x06030AD4 RID: 199380 RVA: 0x0069B768 File Offset: 0x00699968
		public Span<int> GetTargetLocationIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06030AD5 RID: 199381 RVA: 0x0069B778 File Offset: 0x00699978
		public int[] GetTargetLocationIdsArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700CEA3 RID: 52899
		// (get) Token: 0x06030AD6 RID: 199382 RVA: 0x0069B788 File Offset: 0x00699988
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

		// Token: 0x06030AD7 RID: 199383 RVA: 0x0069B7E8 File Offset: 0x006999E8
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

		// Token: 0x06030AD8 RID: 199384 RVA: 0x0069B837 File Offset: 0x00699A37
		public static void StartIFindSunSpirit(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06030AD9 RID: 199385 RVA: 0x0069B840 File Offset: 0x00699A40
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030ADA RID: 199386 RVA: 0x0069B84B File Offset: 0x00699A4B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06030ADB RID: 199387 RVA: 0x0069B856 File Offset: 0x00699A56
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x06030ADC RID: 199388 RVA: 0x0069B866 File Offset: 0x00699A66
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(3, directionOffset.Value, 0);
		}

		// Token: 0x06030ADD RID: 199389 RVA: 0x0069B876 File Offset: 0x00699A76
		public static void AddSunSpiritEntityIds(FlatBufferBuilder builder, VectorOffset sunSpiritEntityIdsOffset)
		{
			builder.AddOffset(4, sunSpiritEntityIdsOffset.Value, 0);
		}

		// Token: 0x06030ADE RID: 199390 RVA: 0x0069B888 File Offset: 0x00699A88
		public static VectorOffset CreateSunSpiritEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030ADF RID: 199391 RVA: 0x0069B8BF File Offset: 0x00699ABF
		public static VectorOffset CreateSunSpiritEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030AE0 RID: 199392 RVA: 0x0069B8D9 File Offset: 0x00699AD9
		public static VectorOffset CreateSunSpiritEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030AE1 RID: 199393 RVA: 0x0069B8F7 File Offset: 0x00699AF7
		public static VectorOffset CreateSunSpiritEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030AE2 RID: 199394 RVA: 0x0069B910 File Offset: 0x00699B10
		public static void StartSunSpiritEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030AE3 RID: 199395 RVA: 0x0069B91B File Offset: 0x00699B1B
		public static void AddTargetLocationIds(FlatBufferBuilder builder, VectorOffset targetLocationIdsOffset)
		{
			builder.AddOffset(5, targetLocationIdsOffset.Value, 0);
		}

		// Token: 0x06030AE4 RID: 199396 RVA: 0x0069B92C File Offset: 0x00699B2C
		public static VectorOffset CreateTargetLocationIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030AE5 RID: 199397 RVA: 0x0069B963 File Offset: 0x00699B63
		public static VectorOffset CreateTargetLocationIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030AE6 RID: 199398 RVA: 0x0069B97D File Offset: 0x00699B7D
		public static VectorOffset CreateTargetLocationIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030AE7 RID: 199399 RVA: 0x0069B99B File Offset: 0x00699B9B
		public static VectorOffset CreateTargetLocationIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030AE8 RID: 199400 RVA: 0x0069B9B4 File Offset: 0x00699BB4
		public static void StartTargetLocationIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030AE9 RID: 199401 RVA: 0x0069B9BF File Offset: 0x00699BBF
		public static void AddDifficultyReductionConfig(FlatBufferBuilder builder, Offset<ISunSpiritDifficultyReduction> difficultyReductionConfigOffset)
		{
			builder.AddOffset(6, difficultyReductionConfigOffset.Value, 0);
		}

		// Token: 0x06030AEA RID: 199402 RVA: 0x0069B9CF File Offset: 0x00699BCF
		public static Offset<IFindSunSpirit> EndIFindSunSpirit(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpirit>(builder.EndTable());
		}

		// Token: 0x06030AEB RID: 199403 RVA: 0x0069B9DC File Offset: 0x00699BDC
		public IFindSunSpiritT UnPack()
		{
			IFindSunSpiritT findSunSpiritT = new IFindSunSpiritT();
			this.UnPackTo(findSunSpiritT);
			return findSunSpiritT;
		}

		// Token: 0x06030AEC RID: 199404 RVA: 0x0069B9F8 File Offset: 0x00699BF8
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

		// Token: 0x06030AED RID: 199405 RVA: 0x0069BB0C File Offset: 0x00699D0C
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

		// Token: 0x04011CDE RID: 72926
		private Table __p;
	}
}
