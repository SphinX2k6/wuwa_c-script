using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FC1 RID: 16321
	public struct IShowTimelineFrame : IFlatbufferObject
	{
		// Token: 0x17006E7D RID: 28285
		// (get) Token: 0x06016481 RID: 91265 RVA: 0x00331567 File Offset: 0x0032F767
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016482 RID: 91266 RVA: 0x00331574 File Offset: 0x0032F774
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016483 RID: 91267 RVA: 0x0033157C File Offset: 0x0032F77C
		public static IShowTimelineFrame GetRootAsIShowTimelineFrame(ByteBuffer _bb)
		{
			return IShowTimelineFrame.GetRootAsIShowTimelineFrame(_bb, default(IShowTimelineFrame));
		}

		// Token: 0x06016484 RID: 91268 RVA: 0x00331598 File Offset: 0x0032F798
		public static IShowTimelineFrame GetRootAsIShowTimelineFrame(ByteBuffer _bb, IShowTimelineFrame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016485 RID: 91269 RVA: 0x003315B5 File Offset: 0x0032F7B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016486 RID: 91270 RVA: 0x003315C4 File Offset: 0x0032F7C4
		public IShowTimelineFrame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E7E RID: 28286
		// (get) Token: 0x06016487 RID: 91271 RVA: 0x003315D4 File Offset: 0x0032F7D4
		public int Frame
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

		// Token: 0x17006E7F RID: 28287
		// (get) Token: 0x06016488 RID: 91272 RVA: 0x00331610 File Offset: 0x0032F810
		public int FrameInterval
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

		// Token: 0x06016489 RID: 91273 RVA: 0x0033164C File Offset: 0x0032F84C
		public TShowTimeline EntriesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TShowTimeline.NONE;
			}
			return (TShowTimeline)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17006E80 RID: 28288
		// (get) Token: 0x0601648A RID: 91274 RVA: 0x0033168C File Offset: 0x0032F88C
		public int EntriesTypeLength
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

		// Token: 0x0601648B RID: 91275 RVA: 0x003316B7 File Offset: 0x0032F8B7
		public Span<TShowTimeline> GetEntriesTypeBytes()
		{
			return this.__p.__vector_as_span<TShowTimeline>(8, 1);
		}

		// Token: 0x0601648C RID: 91276 RVA: 0x003316C8 File Offset: 0x0032F8C8
		public TShowTimeline[] GetEntriesTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TShowTimeline[] array = new TShowTimeline[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TShowTimeline)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601648D RID: 91277 RVA: 0x00331734 File Offset: 0x0032F934
		public TTable? Entries<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17006E81 RID: 28289
		// (get) Token: 0x0601648E RID: 91278 RVA: 0x0033177C File Offset: 0x0032F97C
		public int EntriesLength
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

		// Token: 0x17006E82 RID: 28290
		// (get) Token: 0x0601648F RID: 91279 RVA: 0x003317A8 File Offset: 0x0032F9A8
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

		// Token: 0x06016490 RID: 91280 RVA: 0x003317E5 File Offset: 0x0032F9E5
		public static Offset<IShowTimelineFrame> CreateIShowTimelineFrame(FlatBufferBuilder builder, int Frame = 0, int FrameInterval = 0, VectorOffset Entries_typeOffset = default(VectorOffset), VectorOffset EntriesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IShowTimelineFrame.AddEntries(builder, EntriesOffset);
			IShowTimelineFrame.AddEntriesType(builder, Entries_typeOffset);
			IShowTimelineFrame.AddFrameInterval(builder, FrameInterval);
			IShowTimelineFrame.AddFrame(builder, Frame);
			IShowTimelineFrame.AddNullMask(builder, NullMask);
			return IShowTimelineFrame.EndIShowTimelineFrame(builder);
		}

		// Token: 0x06016491 RID: 91281 RVA: 0x00331819 File Offset: 0x0032FA19
		public static void StartIShowTimelineFrame(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016492 RID: 91282 RVA: 0x00331822 File Offset: 0x0032FA22
		public static void AddFrame(FlatBufferBuilder builder, int frame)
		{
			builder.AddInt(0, frame, 0);
		}

		// Token: 0x06016493 RID: 91283 RVA: 0x0033182D File Offset: 0x0032FA2D
		public static void AddFrameInterval(FlatBufferBuilder builder, int frameInterval)
		{
			builder.AddInt(1, frameInterval, 0);
		}

		// Token: 0x06016494 RID: 91284 RVA: 0x00331838 File Offset: 0x0032FA38
		public static void AddEntriesType(FlatBufferBuilder builder, VectorOffset entriesTypeOffset)
		{
			builder.AddOffset(2, entriesTypeOffset.Value, 0);
		}

		// Token: 0x06016495 RID: 91285 RVA: 0x00331848 File Offset: 0x0032FA48
		public static VectorOffset CreateEntriesTypeVector(FlatBufferBuilder builder, TShowTimeline[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016496 RID: 91286 RVA: 0x0033187F File Offset: 0x0032FA7F
		public static VectorOffset CreateEntriesTypeVectorBlock(FlatBufferBuilder builder, TShowTimeline[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TShowTimeline>(data);
			return builder.EndVector();
		}

		// Token: 0x06016497 RID: 91287 RVA: 0x00331899 File Offset: 0x0032FA99
		public static VectorOffset CreateEntriesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TShowTimeline> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TShowTimeline>(data);
			return builder.EndVector();
		}

		// Token: 0x06016498 RID: 91288 RVA: 0x003318B7 File Offset: 0x0032FAB7
		public static VectorOffset CreateEntriesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TShowTimeline>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016499 RID: 91289 RVA: 0x003318D0 File Offset: 0x0032FAD0
		public static void StartEntriesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601649A RID: 91290 RVA: 0x003318DB File Offset: 0x0032FADB
		public static void AddEntries(FlatBufferBuilder builder, VectorOffset entriesOffset)
		{
			builder.AddOffset(3, entriesOffset.Value, 0);
		}

		// Token: 0x0601649B RID: 91291 RVA: 0x003318EC File Offset: 0x0032FAEC
		public static VectorOffset CreateEntriesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601649C RID: 91292 RVA: 0x00331923 File Offset: 0x0032FB23
		public static VectorOffset CreateEntriesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601649D RID: 91293 RVA: 0x0033193D File Offset: 0x0032FB3D
		public static VectorOffset CreateEntriesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601649E RID: 91294 RVA: 0x0033195B File Offset: 0x0032FB5B
		public static VectorOffset CreateEntriesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601649F RID: 91295 RVA: 0x00331974 File Offset: 0x0032FB74
		public static void StartEntriesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060164A0 RID: 91296 RVA: 0x0033197F File Offset: 0x0032FB7F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060164A1 RID: 91297 RVA: 0x0033198A File Offset: 0x0032FB8A
		public static Offset<IShowTimelineFrame> EndIShowTimelineFrame(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineFrame>(builder.EndTable());
		}

		// Token: 0x060164A2 RID: 91298 RVA: 0x00331998 File Offset: 0x0032FB98
		public IShowTimelineFrameT UnPack()
		{
			IShowTimelineFrameT showTimelineFrameT = new IShowTimelineFrameT();
			this.UnPackTo(showTimelineFrameT);
			return showTimelineFrameT;
		}

		// Token: 0x060164A3 RID: 91299 RVA: 0x003319B4 File Offset: 0x0032FBB4
		public void UnPackTo(IShowTimelineFrameT _o)
		{
			_o.Frame = this.Frame;
			_o.FrameInterval = this.FrameInterval;
			_o.Entries = new List<TShowTimelineUnion>();
			for (int i = 0; i < this.EntriesLength; i++)
			{
				TShowTimelineUnion tshowTimelineUnion = new TShowTimelineUnion();
				tshowTimelineUnion.Type = this.EntriesType(i);
				switch (this.EntriesType(i))
				{
				case TShowTimeline.IShowTimelineAction:
					tshowTimelineUnion.Value = ((this.Entries<IShowTimelineAction>(i) != null) ? this.Entries<IShowTimelineAction>(i).Value.UnPack() : null);
					break;
				case TShowTimeline.IShowTimelineBuff:
					tshowTimelineUnion.Value = ((this.Entries<IShowTimelineBuff>(i) != null) ? this.Entries<IShowTimelineBuff>(i).Value.UnPack() : null);
					break;
				case TShowTimeline.IShowTimelineCheckpoint:
					tshowTimelineUnion.Value = ((this.Entries<IShowTimelineCheckpoint>(i) != null) ? this.Entries<IShowTimelineCheckpoint>(i).Value.UnPack() : null);
					break;
				case TShowTimeline.IShowTimelineGuide:
					tshowTimelineUnion.Value = ((this.Entries<IShowTimelineGuide>(i) != null) ? this.Entries<IShowTimelineGuide>(i).Value.UnPack() : null);
					break;
				case TShowTimeline.IShowTimelineInput:
					tshowTimelineUnion.Value = ((this.Entries<IShowTimelineInput>(i) != null) ? this.Entries<IShowTimelineInput>(i).Value.UnPack() : null);
					break;
				}
				_o.Entries.Add(tshowTimelineUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060164A4 RID: 91300 RVA: 0x00331B60 File Offset: 0x0032FD60
		public static Offset<IShowTimelineFrame> Pack(FlatBufferBuilder builder, IShowTimelineFrameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineFrame>);
			}
			VectorOffset entries_typeOffset = default(VectorOffset);
			if (_o.Entries != null)
			{
				TShowTimeline[] array = new TShowTimeline[_o.Entries.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Entries[i].Type;
				}
				entries_typeOffset = IShowTimelineFrame.CreateEntriesTypeVector(builder, array);
			}
			VectorOffset entriesOffset = default(VectorOffset);
			if (_o.Entries != null)
			{
				int[] array2 = new int[_o.Entries.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TShowTimelineUnion.Pack(builder, _o.Entries[j]);
				}
				entriesOffset = IShowTimelineFrame.CreateEntriesVector(builder, array2);
			}
			return IShowTimelineFrame.CreateIShowTimelineFrame(builder, _o.Frame, _o.FrameInterval, entries_typeOffset, entriesOffset, _o.NullMask);
		}

		// Token: 0x0400BABE RID: 47806
		private Table __p;
	}
}
