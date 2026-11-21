using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007741 RID: 30529
	public struct ISeqEventAddTagToSelf : IFlatbufferObject
	{
		// Token: 0x1700DFCA RID: 57290
		// (get) Token: 0x06035908 RID: 219400 RVA: 0x0072DF1D File Offset: 0x0072C11D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035909 RID: 219401 RVA: 0x0072DF2A File Offset: 0x0072C12A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603590A RID: 219402 RVA: 0x0072DF34 File Offset: 0x0072C134
		public static ISeqEventAddTagToSelf GetRootAsISeqEventAddTagToSelf(ByteBuffer _bb)
		{
			return ISeqEventAddTagToSelf.GetRootAsISeqEventAddTagToSelf(_bb, default(ISeqEventAddTagToSelf));
		}

		// Token: 0x0603590B RID: 219403 RVA: 0x0072DF50 File Offset: 0x0072C150
		public static ISeqEventAddTagToSelf GetRootAsISeqEventAddTagToSelf(ByteBuffer _bb, ISeqEventAddTagToSelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603590C RID: 219404 RVA: 0x0072DF6D File Offset: 0x0072C16D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603590D RID: 219405 RVA: 0x0072DF7C File Offset: 0x0072C17C
		public ISeqEventAddTagToSelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603590E RID: 219406 RVA: 0x0072DF8C File Offset: 0x0072C18C
		public int Tags(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DFCB RID: 57291
		// (get) Token: 0x0603590F RID: 219407 RVA: 0x0072DFCC File Offset: 0x0072C1CC
		public int TagsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06035910 RID: 219408 RVA: 0x0072DFF7 File Offset: 0x0072C1F7
		public Span<int> GetTagsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06035911 RID: 219409 RVA: 0x0072E006 File Offset: 0x0072C206
		public int[] GetTagsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06035912 RID: 219410 RVA: 0x0072E014 File Offset: 0x0072C214
		public static Offset<ISeqEventAddTagToSelf> CreateISeqEventAddTagToSelf(FlatBufferBuilder builder, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ISeqEventAddTagToSelf.AddTags(builder, TagsOffset);
			return ISeqEventAddTagToSelf.EndISeqEventAddTagToSelf(builder);
		}

		// Token: 0x06035913 RID: 219411 RVA: 0x0072E02A File Offset: 0x0072C22A
		public static void StartISeqEventAddTagToSelf(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035914 RID: 219412 RVA: 0x0072E033 File Offset: 0x0072C233
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(0, tagsOffset.Value, 0);
		}

		// Token: 0x06035915 RID: 219413 RVA: 0x0072E044 File Offset: 0x0072C244
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035916 RID: 219414 RVA: 0x0072E07B File Offset: 0x0072C27B
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035917 RID: 219415 RVA: 0x0072E095 File Offset: 0x0072C295
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035918 RID: 219416 RVA: 0x0072E0B3 File Offset: 0x0072C2B3
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035919 RID: 219417 RVA: 0x0072E0CC File Offset: 0x0072C2CC
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603591A RID: 219418 RVA: 0x0072E0D7 File Offset: 0x0072C2D7
		public static Offset<ISeqEventAddTagToSelf> EndISeqEventAddTagToSelf(FlatBufferBuilder builder)
		{
			return new Offset<ISeqEventAddTagToSelf>(builder.EndTable());
		}

		// Token: 0x0603591B RID: 219419 RVA: 0x0072E0E4 File Offset: 0x0072C2E4
		public ISeqEventAddTagToSelfT UnPack()
		{
			ISeqEventAddTagToSelfT seqEventAddTagToSelfT = new ISeqEventAddTagToSelfT();
			this.UnPackTo(seqEventAddTagToSelfT);
			return seqEventAddTagToSelfT;
		}

		// Token: 0x0603591C RID: 219420 RVA: 0x0072E100 File Offset: 0x0072C300
		public void UnPackTo(ISeqEventAddTagToSelfT _o)
		{
			_o.Tags = new List<int>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
		}

		// Token: 0x0603591D RID: 219421 RVA: 0x0072E13C File Offset: 0x0072C33C
		public static Offset<ISeqEventAddTagToSelf> Pack(FlatBufferBuilder builder, ISeqEventAddTagToSelfT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeqEventAddTagToSelf>);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				int[] data = _o.Tags.ToArray();
				tagsOffset = ISeqEventAddTagToSelf.CreateTagsVector(builder, data);
			}
			return ISeqEventAddTagToSelf.CreateISeqEventAddTagToSelf(builder, tagsOffset);
		}

		// Token: 0x04012959 RID: 76121
		private Table __p;
	}
}
