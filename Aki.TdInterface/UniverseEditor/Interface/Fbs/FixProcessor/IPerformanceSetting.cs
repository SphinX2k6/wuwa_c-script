using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BD4 RID: 19412
	public struct IPerformanceSetting : IFlatbufferObject
	{
		// Token: 0x17008964 RID: 35172
		// (get) Token: 0x0601DA2A RID: 121386 RVA: 0x00428D02 File Offset: 0x00426F02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DA2B RID: 121387 RVA: 0x00428D0F File Offset: 0x00426F0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA2C RID: 121388 RVA: 0x00428D18 File Offset: 0x00426F18
		public static IPerformanceSetting GetRootAsIPerformanceSetting(ByteBuffer _bb)
		{
			return IPerformanceSetting.GetRootAsIPerformanceSetting(_bb, default(IPerformanceSetting));
		}

		// Token: 0x0601DA2D RID: 121389 RVA: 0x00428D34 File Offset: 0x00426F34
		public static IPerformanceSetting GetRootAsIPerformanceSetting(ByteBuffer _bb, IPerformanceSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA2E RID: 121390 RVA: 0x00428D51 File Offset: 0x00426F51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA2F RID: 121391 RVA: 0x00428D60 File Offset: 0x00426F60
		public IPerformanceSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008965 RID: 35173
		// (get) Token: 0x0601DA30 RID: 121392 RVA: 0x00428D70 File Offset: 0x00426F70
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

		// Token: 0x0601DA31 RID: 121393 RVA: 0x00428DA7 File Offset: 0x00426FA7
		public Span<byte> GetAuthorBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DA32 RID: 121394 RVA: 0x00428DB6 File Offset: 0x00426FB6
		public byte[] GetAuthorArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008966 RID: 35174
		// (get) Token: 0x0601DA33 RID: 121395 RVA: 0x00428DC4 File Offset: 0x00426FC4
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

		// Token: 0x0601DA34 RID: 121396 RVA: 0x00428DFB File Offset: 0x00426FFB
		public Span<byte> GetNoteBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601DA35 RID: 121397 RVA: 0x00428E0A File Offset: 0x0042700A
		public byte[] GetNoteArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008967 RID: 35175
		// (get) Token: 0x0601DA36 RID: 121398 RVA: 0x00428E18 File Offset: 0x00427018
		public bool EnableOptimize
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DA37 RID: 121399 RVA: 0x00428E58 File Offset: 0x00427058
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008968 RID: 35176
		// (get) Token: 0x0601DA38 RID: 121400 RVA: 0x00428E98 File Offset: 0x00427098
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

		// Token: 0x0601DA39 RID: 121401 RVA: 0x00428EC4 File Offset: 0x004270C4
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601DA3A RID: 121402 RVA: 0x00428ED4 File Offset: 0x004270D4
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17008969 RID: 35177
		// (get) Token: 0x0601DA3B RID: 121403 RVA: 0x00428EE4 File Offset: 0x004270E4
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

		// Token: 0x0601DA3C RID: 121404 RVA: 0x00428F42 File Offset: 0x00427142
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

		// Token: 0x0601DA3D RID: 121405 RVA: 0x00428F76 File Offset: 0x00427176
		public static void StartIPerformanceSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601DA3E RID: 121406 RVA: 0x00428F7F File Offset: 0x0042717F
		public static void AddAuthor(FlatBufferBuilder builder, StringOffset authorOffset)
		{
			builder.AddOffset(0, authorOffset.Value, 0);
		}

		// Token: 0x0601DA3F RID: 121407 RVA: 0x00428F8F File Offset: 0x0042718F
		public static void AddNote(FlatBufferBuilder builder, StringOffset noteOffset)
		{
			builder.AddOffset(1, noteOffset.Value, 0);
		}

		// Token: 0x0601DA40 RID: 121408 RVA: 0x00428F9F File Offset: 0x0042719F
		public static void AddEnableOptimize(FlatBufferBuilder builder, bool enableOptimize)
		{
			builder.AddBool(2, enableOptimize, false);
		}

		// Token: 0x0601DA41 RID: 121409 RVA: 0x00428FAA File Offset: 0x004271AA
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(3, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0601DA42 RID: 121410 RVA: 0x00428FBC File Offset: 0x004271BC
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DA43 RID: 121411 RVA: 0x00428FF3 File Offset: 0x004271F3
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA44 RID: 121412 RVA: 0x0042900D File Offset: 0x0042720D
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA45 RID: 121413 RVA: 0x0042902B File Offset: 0x0042722B
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DA46 RID: 121414 RVA: 0x00429044 File Offset: 0x00427244
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DA47 RID: 121415 RVA: 0x0042904F File Offset: 0x0042724F
		public static void AddMode(FlatBufferBuilder builder, Offset<IHighPerformanceMode> modeOffset)
		{
			builder.AddOffset(4, modeOffset.Value, 0);
		}

		// Token: 0x0601DA48 RID: 121416 RVA: 0x0042905F File Offset: 0x0042725F
		public static Offset<IPerformanceSetting> EndIPerformanceSetting(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceSetting>(builder.EndTable());
		}

		// Token: 0x0601DA49 RID: 121417 RVA: 0x0042906C File Offset: 0x0042726C
		public IPerformanceSettingT UnPack()
		{
			IPerformanceSettingT performanceSettingT = new IPerformanceSettingT();
			this.UnPackTo(performanceSettingT);
			return performanceSettingT;
		}

		// Token: 0x0601DA4A RID: 121418 RVA: 0x00429088 File Offset: 0x00427288
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

		// Token: 0x0601DA4B RID: 121419 RVA: 0x00429118 File Offset: 0x00427318
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

		// Token: 0x0400D49B RID: 54427
		private Table __p;
	}
}
