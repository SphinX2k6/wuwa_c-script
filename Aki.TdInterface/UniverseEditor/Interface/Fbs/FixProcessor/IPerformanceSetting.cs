using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200476C RID: 18284
	public struct IPerformanceSetting : IFlatbufferObject
	{
		// Token: 0x17008323 RID: 33571
		// (get) Token: 0x0601C255 RID: 115285 RVA: 0x003FCA66 File Offset: 0x003FAC66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C256 RID: 115286 RVA: 0x003FCA73 File Offset: 0x003FAC73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C257 RID: 115287 RVA: 0x003FCA7C File Offset: 0x003FAC7C
		public static IPerformanceSetting GetRootAsIPerformanceSetting(ByteBuffer _bb)
		{
			return IPerformanceSetting.GetRootAsIPerformanceSetting(_bb, default(IPerformanceSetting));
		}

		// Token: 0x0601C258 RID: 115288 RVA: 0x003FCA98 File Offset: 0x003FAC98
		public static IPerformanceSetting GetRootAsIPerformanceSetting(ByteBuffer _bb, IPerformanceSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C259 RID: 115289 RVA: 0x003FCAB5 File Offset: 0x003FACB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C25A RID: 115290 RVA: 0x003FCAC4 File Offset: 0x003FACC4
		public IPerformanceSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008324 RID: 33572
		// (get) Token: 0x0601C25B RID: 115291 RVA: 0x003FCAD4 File Offset: 0x003FACD4
		public string Author
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C25C RID: 115292 RVA: 0x003FCB0B File Offset: 0x003FAD0B
		public Span<byte> GetAuthorBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C25D RID: 115293 RVA: 0x003FCB1A File Offset: 0x003FAD1A
		public byte[] GetAuthorArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008325 RID: 33573
		// (get) Token: 0x0601C25E RID: 115294 RVA: 0x003FCB28 File Offset: 0x003FAD28
		public string Note
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

		// Token: 0x0601C25F RID: 115295 RVA: 0x003FCB5F File Offset: 0x003FAD5F
		public Span<byte> GetNoteBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C260 RID: 115296 RVA: 0x003FCB6E File Offset: 0x003FAD6E
		public byte[] GetNoteArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008326 RID: 33574
		// (get) Token: 0x0601C261 RID: 115297 RVA: 0x003FCB7C File Offset: 0x003FAD7C
		public bool EnableOptimize
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601C262 RID: 115298 RVA: 0x003FCBBC File Offset: 0x003FADBC
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008327 RID: 33575
		// (get) Token: 0x0601C263 RID: 115299 RVA: 0x003FCBFC File Offset: 0x003FADFC
		public int RangeEntitiesLength
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

		// Token: 0x0601C264 RID: 115300 RVA: 0x003FCC28 File Offset: 0x003FAE28
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601C265 RID: 115301 RVA: 0x003FCC38 File Offset: 0x003FAE38
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17008328 RID: 33576
		// (get) Token: 0x0601C266 RID: 115302 RVA: 0x003FCC48 File Offset: 0x003FAE48
		public IHighPerformanceMode? Mode
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IHighPerformanceMode?(default(IHighPerformanceMode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C267 RID: 115303 RVA: 0x003FCCA6 File Offset: 0x003FAEA6
		public static Offset<IPerformanceSetting> CreateIPerformanceSetting(FlatBufferBuilder builder, StringOffset AuthorOffset = default(StringOffset), StringOffset NoteOffset = default(StringOffset), bool EnableOptimize = false, VectorOffset RangeEntitiesOffset = default(VectorOffset), Offset<IHighPerformanceMode> ModeOffset = default(Offset<IHighPerformanceMode>))
		{
			builder.StartTable(5);
			IPerformanceSetting.AddMode(builder, ModeOffset);
			IPerformanceSetting.AddRangeEntities(builder, RangeEntitiesOffset);
			IPerformanceSetting.AddNote(builder, NoteOffset);
			IPerformanceSetting.AddAuthor(builder, AuthorOffset);
			IPerformanceSetting.AddEnableOptimize(builder, EnableOptimize);
			return IPerformanceSetting.EndIPerformanceSetting(builder);
		}

		// Token: 0x0601C268 RID: 115304 RVA: 0x003FCCDA File Offset: 0x003FAEDA
		public static void StartIPerformanceSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601C269 RID: 115305 RVA: 0x003FCCE3 File Offset: 0x003FAEE3
		public static void AddAuthor(FlatBufferBuilder builder, StringOffset authorOffset)
		{
			builder.AddOffset(0, authorOffset.Value, 0);
		}

		// Token: 0x0601C26A RID: 115306 RVA: 0x003FCCF3 File Offset: 0x003FAEF3
		public static void AddNote(FlatBufferBuilder builder, StringOffset noteOffset)
		{
			builder.AddOffset(1, noteOffset.Value, 0);
		}

		// Token: 0x0601C26B RID: 115307 RVA: 0x003FCD03 File Offset: 0x003FAF03
		public static void AddEnableOptimize(FlatBufferBuilder builder, bool enableOptimize)
		{
			builder.AddBool(2, enableOptimize, false);
		}

		// Token: 0x0601C26C RID: 115308 RVA: 0x003FCD0E File Offset: 0x003FAF0E
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(3, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601C26D RID: 115309 RVA: 0x003FCD20 File Offset: 0x003FAF20
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C26E RID: 115310 RVA: 0x003FCD57 File Offset: 0x003FAF57
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C26F RID: 115311 RVA: 0x003FCD71 File Offset: 0x003FAF71
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C270 RID: 115312 RVA: 0x003FCD8F File Offset: 0x003FAF8F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C271 RID: 115313 RVA: 0x003FCDA8 File Offset: 0x003FAFA8
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C272 RID: 115314 RVA: 0x003FCDB3 File Offset: 0x003FAFB3
		public static void AddMode(FlatBufferBuilder builder, Offset<IHighPerformanceMode> modeOffset)
		{
			builder.AddOffset(4, modeOffset.Value, 0);
		}

		// Token: 0x0601C273 RID: 115315 RVA: 0x003FCDC3 File Offset: 0x003FAFC3
		public static Offset<IPerformanceSetting> EndIPerformanceSetting(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceSetting>(builder.EndTable());
		}

		// Token: 0x0601C274 RID: 115316 RVA: 0x003FCDD0 File Offset: 0x003FAFD0
		public IPerformanceSettingT UnPack()
		{
			IPerformanceSettingT performanceSettingT = new IPerformanceSettingT();
			this.UnPackTo(performanceSettingT);
			return performanceSettingT;
		}

		// Token: 0x0601C275 RID: 115317 RVA: 0x003FCDEC File Offset: 0x003FAFEC
		public void UnPackTo(IPerformanceSettingT _o)
		{
			_o.Author = this.Author;
			_o.Note = this.Note;
			_o.EnableOptimize = this.EnableOptimize;
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.Mode = ((this.Mode != null) ? this.Mode.Value.UnPack() : null);
		}

		// Token: 0x0601C276 RID: 115318 RVA: 0x003FCE7C File Offset: 0x003FB07C
		public static Offset<IPerformanceSetting> Pack(FlatBufferBuilder builder, IPerformanceSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformanceSetting>);
			}
			StringOffset authorOffset = (_o.Author == null) ? default(StringOffset) : builder.CreateString(_o.Author);
			StringOffset noteOffset = (_o.Note == null) ? default(StringOffset) : builder.CreateString(_o.Note);
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IPerformanceSetting.CreateRangeEntitiesVector(builder, data);
			}
			Offset<IHighPerformanceMode> modeOffset = (_o.Mode == null) ? default(Offset<IHighPerformanceMode>) : IHighPerformanceMode.Pack(builder, _o.Mode);
			return IPerformanceSetting.CreateIPerformanceSetting(builder, authorOffset, noteOffset, _o.EnableOptimize, rangeEntitiesOffset, modeOffset);
		}

		// Token: 0x0400CA6C RID: 51820
		private Table __p;
	}
}
