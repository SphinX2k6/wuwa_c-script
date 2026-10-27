using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690F RID: 26895
	public struct IHideWorldEntityAndLevelPlayGroup : IFlatbufferObject
	{
		// Token: 0x1700C78B RID: 51083
		// (get) Token: 0x0602EEF8 RID: 192248 RVA: 0x00666AFC File Offset: 0x00664CFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EEF9 RID: 192249 RVA: 0x00666B09 File Offset: 0x00664D09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EEFA RID: 192250 RVA: 0x00666B10 File Offset: 0x00664D10
		public static IHideWorldEntityAndLevelPlayGroup GetRootAsIHideWorldEntityAndLevelPlayGroup(ByteBuffer _bb)
		{
			return IHideWorldEntityAndLevelPlayGroup.GetRootAsIHideWorldEntityAndLevelPlayGroup(_bb, default(IHideWorldEntityAndLevelPlayGroup));
		}

		// Token: 0x0602EEFB RID: 192251 RVA: 0x00666B2C File Offset: 0x00664D2C
		public static IHideWorldEntityAndLevelPlayGroup GetRootAsIHideWorldEntityAndLevelPlayGroup(ByteBuffer _bb, IHideWorldEntityAndLevelPlayGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EEFC RID: 192252 RVA: 0x00666B49 File Offset: 0x00664D49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EEFD RID: 192253 RVA: 0x00666B58 File Offset: 0x00664D58
		public IHideWorldEntityAndLevelPlayGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C78C RID: 51084
		// (get) Token: 0x0602EEFE RID: 192254 RVA: 0x00666B68 File Offset: 0x00664D68
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EEFF RID: 192255 RVA: 0x00666BA4 File Offset: 0x00664DA4
		public int HideRangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C78D RID: 51085
		// (get) Token: 0x0602EF00 RID: 192256 RVA: 0x00666BE4 File Offset: 0x00664DE4
		public int HideRangeEntitiesLength
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

		// Token: 0x0602EF01 RID: 192257 RVA: 0x00666C0F File Offset: 0x00664E0F
		public Span<int> GetHideRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602EF02 RID: 192258 RVA: 0x00666C1E File Offset: 0x00664E1E
		public int[] GetHideRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602EF03 RID: 192259 RVA: 0x00666C2C File Offset: 0x00664E2C
		public int ExcludeEntities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C78E RID: 51086
		// (get) Token: 0x0602EF04 RID: 192260 RVA: 0x00666C6C File Offset: 0x00664E6C
		public int ExcludeEntitiesLength
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

		// Token: 0x0602EF05 RID: 192261 RVA: 0x00666C97 File Offset: 0x00664E97
		public Span<int> GetExcludeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602EF06 RID: 192262 RVA: 0x00666CA6 File Offset: 0x00664EA6
		public int[] GetExcludeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602EF07 RID: 192263 RVA: 0x00666CB4 File Offset: 0x00664EB4
		public int ExcludeLevelPlays(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C78F RID: 51087
		// (get) Token: 0x0602EF08 RID: 192264 RVA: 0x00666CF4 File Offset: 0x00664EF4
		public int ExcludeLevelPlaysLength
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

		// Token: 0x0602EF09 RID: 192265 RVA: 0x00666D20 File Offset: 0x00664F20
		public Span<int> GetExcludeLevelPlaysBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602EF0A RID: 192266 RVA: 0x00666D30 File Offset: 0x00664F30
		public int[] GetExcludeLevelPlaysArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0602EF0B RID: 192267 RVA: 0x00666D40 File Offset: 0x00664F40
		public int AppendEntities(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C790 RID: 51088
		// (get) Token: 0x0602EF0C RID: 192268 RVA: 0x00666D80 File Offset: 0x00664F80
		public int AppendEntitiesLength
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

		// Token: 0x0602EF0D RID: 192269 RVA: 0x00666DAC File Offset: 0x00664FAC
		public Span<int> GetAppendEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0602EF0E RID: 192270 RVA: 0x00666DBC File Offset: 0x00664FBC
		public int[] GetAppendEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x0602EF0F RID: 192271 RVA: 0x00666DCC File Offset: 0x00664FCC
		public int AppendLevelPlays(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C791 RID: 51089
		// (get) Token: 0x0602EF10 RID: 192272 RVA: 0x00666E0C File Offset: 0x0066500C
		public int AppendLevelPlaysLength
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

		// Token: 0x0602EF11 RID: 192273 RVA: 0x00666E38 File Offset: 0x00665038
		public Span<int> GetAppendLevelPlaysBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0602EF12 RID: 192274 RVA: 0x00666E48 File Offset: 0x00665048
		public int[] GetAppendLevelPlaysArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700C792 RID: 51090
		// (get) Token: 0x0602EF13 RID: 192275 RVA: 0x00666E58 File Offset: 0x00665058
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EF14 RID: 192276 RVA: 0x00666E98 File Offset: 0x00665098
		public static Offset<IHideWorldEntityAndLevelPlayGroup> CreateIHideWorldEntityAndLevelPlayGroup(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset HideRangeEntitiesOffset = default(VectorOffset), VectorOffset ExcludeEntitiesOffset = default(VectorOffset), VectorOffset ExcludeLevelPlaysOffset = default(VectorOffset), VectorOffset AppendEntitiesOffset = default(VectorOffset), VectorOffset AppendLevelPlaysOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IHideWorldEntityAndLevelPlayGroup.AddAppendLevelPlays(builder, AppendLevelPlaysOffset);
			IHideWorldEntityAndLevelPlayGroup.AddAppendEntities(builder, AppendEntitiesOffset);
			IHideWorldEntityAndLevelPlayGroup.AddExcludeLevelPlays(builder, ExcludeLevelPlaysOffset);
			IHideWorldEntityAndLevelPlayGroup.AddExcludeEntities(builder, ExcludeEntitiesOffset);
			IHideWorldEntityAndLevelPlayGroup.AddHideRangeEntities(builder, HideRangeEntitiesOffset);
			IHideWorldEntityAndLevelPlayGroup.AddNullMask(builder, NullMask);
			IHideWorldEntityAndLevelPlayGroup.AddType(builder, Type);
			return IHideWorldEntityAndLevelPlayGroup.EndIHideWorldEntityAndLevelPlayGroup(builder);
		}

		// Token: 0x0602EF15 RID: 192277 RVA: 0x00666EE7 File Offset: 0x006650E7
		public static void StartIHideWorldEntityAndLevelPlayGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602EF16 RID: 192278 RVA: 0x00666EF0 File Offset: 0x006650F0
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EF17 RID: 192279 RVA: 0x00666EFB File Offset: 0x006650FB
		public static void AddHideRangeEntities(FlatBufferBuilder builder, VectorOffset hideRangeEntitiesOffset)
		{
			builder.AddOffset(1, hideRangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0602EF18 RID: 192280 RVA: 0x00666F0C File Offset: 0x0066510C
		public static VectorOffset CreateHideRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EF19 RID: 192281 RVA: 0x00666F43 File Offset: 0x00665143
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF1A RID: 192282 RVA: 0x00666F5D File Offset: 0x0066515D
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF1B RID: 192283 RVA: 0x00666F7B File Offset: 0x0066517B
		public static VectorOffset CreateHideRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EF1C RID: 192284 RVA: 0x00666F94 File Offset: 0x00665194
		public static void StartHideRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EF1D RID: 192285 RVA: 0x00666F9F File Offset: 0x0066519F
		public static void AddExcludeEntities(FlatBufferBuilder builder, VectorOffset excludeEntitiesOffset)
		{
			builder.AddOffset(2, excludeEntitiesOffset.Value, 0);
		}

		// Token: 0x0602EF1E RID: 192286 RVA: 0x00666FB0 File Offset: 0x006651B0
		public static VectorOffset CreateExcludeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EF1F RID: 192287 RVA: 0x00666FE7 File Offset: 0x006651E7
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF20 RID: 192288 RVA: 0x00667001 File Offset: 0x00665201
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF21 RID: 192289 RVA: 0x0066701F File Offset: 0x0066521F
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EF22 RID: 192290 RVA: 0x00667038 File Offset: 0x00665238
		public static void StartExcludeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EF23 RID: 192291 RVA: 0x00667043 File Offset: 0x00665243
		public static void AddExcludeLevelPlays(FlatBufferBuilder builder, VectorOffset excludeLevelPlaysOffset)
		{
			builder.AddOffset(3, excludeLevelPlaysOffset.Value, 0);
		}

		// Token: 0x0602EF24 RID: 192292 RVA: 0x00667054 File Offset: 0x00665254
		public static VectorOffset CreateExcludeLevelPlaysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EF25 RID: 192293 RVA: 0x0066708B File Offset: 0x0066528B
		public static VectorOffset CreateExcludeLevelPlaysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF26 RID: 192294 RVA: 0x006670A5 File Offset: 0x006652A5
		public static VectorOffset CreateExcludeLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF27 RID: 192295 RVA: 0x006670C3 File Offset: 0x006652C3
		public static VectorOffset CreateExcludeLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EF28 RID: 192296 RVA: 0x006670DC File Offset: 0x006652DC
		public static void StartExcludeLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EF29 RID: 192297 RVA: 0x006670E7 File Offset: 0x006652E7
		public static void AddAppendEntities(FlatBufferBuilder builder, VectorOffset appendEntitiesOffset)
		{
			builder.AddOffset(4, appendEntitiesOffset.Value, 0);
		}

		// Token: 0x0602EF2A RID: 192298 RVA: 0x006670F8 File Offset: 0x006652F8
		public static VectorOffset CreateAppendEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EF2B RID: 192299 RVA: 0x0066712F File Offset: 0x0066532F
		public static VectorOffset CreateAppendEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF2C RID: 192300 RVA: 0x00667149 File Offset: 0x00665349
		public static VectorOffset CreateAppendEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF2D RID: 192301 RVA: 0x00667167 File Offset: 0x00665367
		public static VectorOffset CreateAppendEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EF2E RID: 192302 RVA: 0x00667180 File Offset: 0x00665380
		public static void StartAppendEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EF2F RID: 192303 RVA: 0x0066718B File Offset: 0x0066538B
		public static void AddAppendLevelPlays(FlatBufferBuilder builder, VectorOffset appendLevelPlaysOffset)
		{
			builder.AddOffset(5, appendLevelPlaysOffset.Value, 0);
		}

		// Token: 0x0602EF30 RID: 192304 RVA: 0x0066719C File Offset: 0x0066539C
		public static VectorOffset CreateAppendLevelPlaysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EF31 RID: 192305 RVA: 0x006671D3 File Offset: 0x006653D3
		public static VectorOffset CreateAppendLevelPlaysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF32 RID: 192306 RVA: 0x006671ED File Offset: 0x006653ED
		public static VectorOffset CreateAppendLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EF33 RID: 192307 RVA: 0x0066720B File Offset: 0x0066540B
		public static VectorOffset CreateAppendLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EF34 RID: 192308 RVA: 0x00667224 File Offset: 0x00665424
		public static void StartAppendLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EF35 RID: 192309 RVA: 0x0066722F File Offset: 0x0066542F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602EF36 RID: 192310 RVA: 0x0066723A File Offset: 0x0066543A
		public static Offset<IHideWorldEntityAndLevelPlayGroup> EndIHideWorldEntityAndLevelPlayGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideWorldEntityAndLevelPlayGroup>(builder.EndTable());
		}

		// Token: 0x0602EF37 RID: 192311 RVA: 0x00667248 File Offset: 0x00665448
		public IHideWorldEntityAndLevelPlayGroupT UnPack()
		{
			IHideWorldEntityAndLevelPlayGroupT hideWorldEntityAndLevelPlayGroupT = new IHideWorldEntityAndLevelPlayGroupT();
			this.UnPackTo(hideWorldEntityAndLevelPlayGroupT);
			return hideWorldEntityAndLevelPlayGroupT;
		}

		// Token: 0x0602EF38 RID: 192312 RVA: 0x00667264 File Offset: 0x00665464
		public void UnPackTo(IHideWorldEntityAndLevelPlayGroupT _o)
		{
			_o.Type = this.Type;
			_o.HideRangeEntities = new List<int>();
			for (int i = 0; i < this.HideRangeEntitiesLength; i++)
			{
				_o.HideRangeEntities.Add(this.HideRangeEntities(i));
			}
			_o.ExcludeEntities = new List<int>();
			for (int j = 0; j < this.ExcludeEntitiesLength; j++)
			{
				_o.ExcludeEntities.Add(this.ExcludeEntities(j));
			}
			_o.ExcludeLevelPlays = new List<int>();
			for (int k = 0; k < this.ExcludeLevelPlaysLength; k++)
			{
				_o.ExcludeLevelPlays.Add(this.ExcludeLevelPlays(k));
			}
			_o.AppendEntities = new List<int>();
			for (int l = 0; l < this.AppendEntitiesLength; l++)
			{
				_o.AppendEntities.Add(this.AppendEntities(l));
			}
			_o.AppendLevelPlays = new List<int>();
			for (int m = 0; m < this.AppendLevelPlaysLength; m++)
			{
				_o.AppendLevelPlays.Add(this.AppendLevelPlays(m));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EF39 RID: 192313 RVA: 0x00667374 File Offset: 0x00665574
		public static Offset<IHideWorldEntityAndLevelPlayGroup> Pack(FlatBufferBuilder builder, IHideWorldEntityAndLevelPlayGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideWorldEntityAndLevelPlayGroup>);
			}
			VectorOffset hideRangeEntitiesOffset = default(VectorOffset);
			if (_o.HideRangeEntities != null)
			{
				int[] data = _o.HideRangeEntities.ToArray();
				hideRangeEntitiesOffset = IHideWorldEntityAndLevelPlayGroup.CreateHideRangeEntitiesVector(builder, data);
			}
			VectorOffset excludeEntitiesOffset = default(VectorOffset);
			if (_o.ExcludeEntities != null)
			{
				int[] data2 = _o.ExcludeEntities.ToArray();
				excludeEntitiesOffset = IHideWorldEntityAndLevelPlayGroup.CreateExcludeEntitiesVector(builder, data2);
			}
			VectorOffset excludeLevelPlaysOffset = default(VectorOffset);
			if (_o.ExcludeLevelPlays != null)
			{
				int[] data3 = _o.ExcludeLevelPlays.ToArray();
				excludeLevelPlaysOffset = IHideWorldEntityAndLevelPlayGroup.CreateExcludeLevelPlaysVector(builder, data3);
			}
			VectorOffset appendEntitiesOffset = default(VectorOffset);
			if (_o.AppendEntities != null)
			{
				int[] data4 = _o.AppendEntities.ToArray();
				appendEntitiesOffset = IHideWorldEntityAndLevelPlayGroup.CreateAppendEntitiesVector(builder, data4);
			}
			VectorOffset appendLevelPlaysOffset = default(VectorOffset);
			if (_o.AppendLevelPlays != null)
			{
				int[] data5 = _o.AppendLevelPlays.ToArray();
				appendLevelPlaysOffset = IHideWorldEntityAndLevelPlayGroup.CreateAppendLevelPlaysVector(builder, data5);
			}
			return IHideWorldEntityAndLevelPlayGroup.CreateIHideWorldEntityAndLevelPlayGroup(builder, _o.Type, hideRangeEntitiesOffset, excludeEntitiesOffset, excludeLevelPlaysOffset, appendEntitiesOffset, appendLevelPlaysOffset, _o.NullMask);
		}

		// Token: 0x04011088 RID: 69768
		private Table __p;
	}
}
