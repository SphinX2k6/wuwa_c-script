using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D88 RID: 19848
	public struct IFrequencyDetectGraphicsLine : IFlatbufferObject
	{
		// Token: 0x17008E01 RID: 36353
		// (get) Token: 0x0601EC57 RID: 126039 RVA: 0x0044D7BA File Offset: 0x0044B9BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC58 RID: 126040 RVA: 0x0044D7C7 File Offset: 0x0044B9C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC59 RID: 126041 RVA: 0x0044D7D0 File Offset: 0x0044B9D0
		public static IFrequencyDetectGraphicsLine GetRootAsIFrequencyDetectGraphicsLine(ByteBuffer _bb)
		{
			return IFrequencyDetectGraphicsLine.GetRootAsIFrequencyDetectGraphicsLine(_bb, default(IFrequencyDetectGraphicsLine));
		}

		// Token: 0x0601EC5A RID: 126042 RVA: 0x0044D7EC File Offset: 0x0044B9EC
		public static IFrequencyDetectGraphicsLine GetRootAsIFrequencyDetectGraphicsLine(ByteBuffer _bb, IFrequencyDetectGraphicsLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC5B RID: 126043 RVA: 0x0044D809 File Offset: 0x0044BA09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC5C RID: 126044 RVA: 0x0044D818 File Offset: 0x0044BA18
		public IFrequencyDetectGraphicsLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E02 RID: 36354
		// (get) Token: 0x0601EC5D RID: 126045 RVA: 0x0044D828 File Offset: 0x0044BA28
		public string Id
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

		// Token: 0x0601EC5E RID: 126046 RVA: 0x0044D85F File Offset: 0x0044BA5F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601EC5F RID: 126047 RVA: 0x0044D86E File Offset: 0x0044BA6E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008E03 RID: 36355
		// (get) Token: 0x0601EC60 RID: 126048 RVA: 0x0044D87C File Offset: 0x0044BA7C
		public bool Closed
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601EC61 RID: 126049 RVA: 0x0044D8BC File Offset: 0x0044BABC
		public IFrequencyDetectGraphicsSegment? Segments(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IFrequencyDetectGraphicsSegment?(default(IFrequencyDetectGraphicsSegment).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008E04 RID: 36356
		// (get) Token: 0x0601EC62 RID: 126050 RVA: 0x0044D91C File Offset: 0x0044BB1C
		public int SegmentsLength
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

		// Token: 0x0601EC63 RID: 126051 RVA: 0x0044D947 File Offset: 0x0044BB47
		public static Offset<IFrequencyDetectGraphicsLine> CreateIFrequencyDetectGraphicsLine(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), bool Closed = false, VectorOffset SegmentsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IFrequencyDetectGraphicsLine.AddSegments(builder, SegmentsOffset);
			IFrequencyDetectGraphicsLine.AddId(builder, IdOffset);
			IFrequencyDetectGraphicsLine.AddClosed(builder, Closed);
			return IFrequencyDetectGraphicsLine.EndIFrequencyDetectGraphicsLine(builder);
		}

		// Token: 0x0601EC64 RID: 126052 RVA: 0x0044D96B File Offset: 0x0044BB6B
		public static void StartIFrequencyDetectGraphicsLine(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EC65 RID: 126053 RVA: 0x0044D974 File Offset: 0x0044BB74
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601EC66 RID: 126054 RVA: 0x0044D984 File Offset: 0x0044BB84
		public static void AddClosed(FlatBufferBuilder builder, bool closed)
		{
			builder.AddBool(1, closed, false);
		}

		// Token: 0x0601EC67 RID: 126055 RVA: 0x0044D98F File Offset: 0x0044BB8F
		public static void AddSegments(FlatBufferBuilder builder, VectorOffset segmentsOffset)
		{
			builder.AddOffset(2, segmentsOffset.Value, 0);
		}

		// Token: 0x0601EC68 RID: 126056 RVA: 0x0044D9A0 File Offset: 0x0044BBA0
		public static VectorOffset CreateSegmentsVector(FlatBufferBuilder builder, Offset<IFrequencyDetectGraphicsSegment>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EC69 RID: 126057 RVA: 0x0044D9E0 File Offset: 0x0044BBE0
		public static VectorOffset CreateSegmentsVectorBlock(FlatBufferBuilder builder, Offset<IFrequencyDetectGraphicsSegment>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFrequencyDetectGraphicsSegment>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EC6A RID: 126058 RVA: 0x0044D9FA File Offset: 0x0044BBFA
		public static VectorOffset CreateSegmentsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFrequencyDetectGraphicsSegment>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFrequencyDetectGraphicsSegment>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EC6B RID: 126059 RVA: 0x0044DA18 File Offset: 0x0044BC18
		public static VectorOffset CreateSegmentsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFrequencyDetectGraphicsSegment>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EC6C RID: 126060 RVA: 0x0044DA31 File Offset: 0x0044BC31
		public static void StartSegmentsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EC6D RID: 126061 RVA: 0x0044DA3C File Offset: 0x0044BC3C
		public static Offset<IFrequencyDetectGraphicsLine> EndIFrequencyDetectGraphicsLine(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetectGraphicsLine>(builder.EndTable());
		}

		// Token: 0x0601EC6E RID: 126062 RVA: 0x0044DA4C File Offset: 0x0044BC4C
		public IFrequencyDetectGraphicsLineT UnPack()
		{
			IFrequencyDetectGraphicsLineT frequencyDetectGraphicsLineT = new IFrequencyDetectGraphicsLineT();
			this.UnPackTo(frequencyDetectGraphicsLineT);
			return frequencyDetectGraphicsLineT;
		}

		// Token: 0x0601EC6F RID: 126063 RVA: 0x0044DA68 File Offset: 0x0044BC68
		public void UnPackTo(IFrequencyDetectGraphicsLineT _o)
		{
			_o.Id = this.Id;
			_o.Closed = this.Closed;
			_o.Segments = new List<IFrequencyDetectGraphicsSegmentT>();
			for (int i = 0; i < this.SegmentsLength; i++)
			{
				_o.Segments.Add((this.Segments(i) != null) ? this.Segments(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601EC70 RID: 126064 RVA: 0x0044DAE0 File Offset: 0x0044BCE0
		public static Offset<IFrequencyDetectGraphicsLine> Pack(FlatBufferBuilder builder, IFrequencyDetectGraphicsLineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetectGraphicsLine>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			VectorOffset segmentsOffset = default(VectorOffset);
			if (_o.Segments != null)
			{
				Offset<IFrequencyDetectGraphicsSegment>[] array = new Offset<IFrequencyDetectGraphicsSegment>[_o.Segments.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFrequencyDetectGraphicsSegment.Pack(builder, _o.Segments[i]);
				}
				segmentsOffset = IFrequencyDetectGraphicsLine.CreateSegmentsVector(builder, array);
			}
			return IFrequencyDetectGraphicsLine.CreateIFrequencyDetectGraphicsLine(builder, idOffset, _o.Closed, segmentsOffset);
		}

		// Token: 0x0400D9DC RID: 55772
		private Table __p;
	}
}
