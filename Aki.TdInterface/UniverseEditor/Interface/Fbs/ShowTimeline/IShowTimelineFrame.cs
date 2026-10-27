using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB9 RID: 15289
	public struct IShowTimelineFrame : IFlatbufferObject
	{
		// Token: 0x170068DA RID: 26842
		// (get) Token: 0x06014FA9 RID: 85929 RVA: 0x0030AD0B File Offset: 0x00308F0B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014FAA RID: 85930 RVA: 0x0030AD18 File Offset: 0x00308F18
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014FAB RID: 85931 RVA: 0x0030AD20 File Offset: 0x00308F20
		public static IShowTimelineFrame GetRootAsIShowTimelineFrame(ByteBuffer _bb)
		{
			return IShowTimelineFrame.GetRootAsIShowTimelineFrame(_bb, default(IShowTimelineFrame));
		}

		// Token: 0x06014FAC RID: 85932 RVA: 0x0030AD3C File Offset: 0x00308F3C
		public static IShowTimelineFrame GetRootAsIShowTimelineFrame(ByteBuffer _bb, IShowTimelineFrame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014FAD RID: 85933 RVA: 0x0030AD59 File Offset: 0x00308F59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014FAE RID: 85934 RVA: 0x0030AD68 File Offset: 0x00308F68
		public IShowTimelineFrame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068DB RID: 26843
		// (get) Token: 0x06014FAF RID: 85935 RVA: 0x0030AD78 File Offset: 0x00308F78
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

		// Token: 0x170068DC RID: 26844
		// (get) Token: 0x06014FB0 RID: 85936 RVA: 0x0030ADB4 File Offset: 0x00308FB4
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

		// Token: 0x06014FB1 RID: 85937 RVA: 0x0030ADF0 File Offset: 0x00308FF0
		public TShowTimeline EntriesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TShowTimeline.NONE;
			}
			return (TShowTimeline)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170068DD RID: 26845
		// (get) Token: 0x06014FB2 RID: 85938 RVA: 0x0030AE30 File Offset: 0x00309030
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

		// Token: 0x06014FB3 RID: 85939 RVA: 0x0030AE5B File Offset: 0x0030905B
		public Span<TShowTimeline> GetEntriesTypeBytes()
		{
			return this.__p.__vector_as_span<TShowTimeline>(8, 1);
		}

		// Token: 0x06014FB4 RID: 85940 RVA: 0x0030AE6C File Offset: 0x0030906C
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

		// Token: 0x06014FB5 RID: 85941 RVA: 0x0030AED8 File Offset: 0x003090D8
		public TTable? Entries<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170068DE RID: 26846
		// (get) Token: 0x06014FB6 RID: 85942 RVA: 0x0030AF20 File Offset: 0x00309120
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

		// Token: 0x170068DF RID: 26847
		// (get) Token: 0x06014FB7 RID: 85943 RVA: 0x0030AF4C File Offset: 0x0030914C
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

		// Token: 0x06014FB8 RID: 85944 RVA: 0x0030AF89 File Offset: 0x00309189
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

		// Token: 0x06014FB9 RID: 85945 RVA: 0x0030AFBD File Offset: 0x003091BD
		public static void StartIShowTimelineFrame(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06014FBA RID: 85946 RVA: 0x0030AFC6 File Offset: 0x003091C6
		public static void AddFrame(FlatBufferBuilder builder, int frame)
		{
			builder.AddInt(0, frame, 0);
		}

		// Token: 0x06014FBB RID: 85947 RVA: 0x0030AFD1 File Offset: 0x003091D1
		public static void AddFrameInterval(FlatBufferBuilder builder, int frameInterval)
		{
			builder.AddInt(1, frameInterval, 0);
		}

		// Token: 0x06014FBC RID: 85948 RVA: 0x0030AFDC File Offset: 0x003091DC
		public static void AddEntriesType(FlatBufferBuilder builder, VectorOffset entriesTypeOffset)
		{
			builder.AddOffset(2, entriesTypeOffset.Value, 0);
		}

		// Token: 0x06014FBD RID: 85949 RVA: 0x0030AFEC File Offset: 0x003091EC
		public static VectorOffset CreateEntriesTypeVector(FlatBufferBuilder builder, TShowTimeline[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06014FBE RID: 85950 RVA: 0x0030B023 File Offset: 0x00309223
		public static VectorOffset CreateEntriesTypeVectorBlock(FlatBufferBuilder builder, TShowTimeline[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TShowTimeline>(data);
			return builder.EndVector();
		}

		// Token: 0x06014FBF RID: 85951 RVA: 0x0030B03D File Offset: 0x0030923D
		public static VectorOffset CreateEntriesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TShowTimeline> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TShowTimeline>(data);
			return builder.EndVector();
		}

		// Token: 0x06014FC0 RID: 85952 RVA: 0x0030B05B File Offset: 0x0030925B
		public static VectorOffset CreateEntriesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TShowTimeline>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014FC1 RID: 85953 RVA: 0x0030B074 File Offset: 0x00309274
		public static void StartEntriesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06014FC2 RID: 85954 RVA: 0x0030B07F File Offset: 0x0030927F
		public static void AddEntries(FlatBufferBuilder builder, VectorOffset entriesOffset)
		{
			builder.AddOffset(3, entriesOffset.Value, 0);
		}

		// Token: 0x06014FC3 RID: 85955 RVA: 0x0030B090 File Offset: 0x00309290
		public static VectorOffset CreateEntriesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06014FC4 RID: 85956 RVA: 0x0030B0C7 File Offset: 0x003092C7
		public static VectorOffset CreateEntriesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06014FC5 RID: 85957 RVA: 0x0030B0E1 File Offset: 0x003092E1
		public static VectorOffset CreateEntriesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06014FC6 RID: 85958 RVA: 0x0030B0FF File Offset: 0x003092FF
		public static VectorOffset CreateEntriesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014FC7 RID: 85959 RVA: 0x0030B118 File Offset: 0x00309318
		public static void StartEntriesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014FC8 RID: 85960 RVA: 0x0030B123 File Offset: 0x00309323
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06014FC9 RID: 85961 RVA: 0x0030B12E File Offset: 0x0030932E
		public static Offset<IShowTimelineFrame> EndIShowTimelineFrame(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineFrame>(builder.EndTable());
		}

		// Token: 0x06014FCA RID: 85962 RVA: 0x0030B13C File Offset: 0x0030933C
		public IShowTimelineFrameT UnPack()
		{
			IShowTimelineFrameT showTimelineFrameT = new IShowTimelineFrameT();
			this.UnPackTo(showTimelineFrameT);
			return showTimelineFrameT;
		}

		// Token: 0x06014FCB RID: 85963 RVA: 0x0030B158 File Offset: 0x00309358
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

		// Token: 0x06014FCC RID: 85964 RVA: 0x0030B304 File Offset: 0x00309504
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

		// Token: 0x0400B13F RID: 45375
		private Table __p;
	}
}
