using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7B RID: 28539
	public struct ISeqEventAddTagToSelf : IFlatbufferObject
	{
		// Token: 0x1700D3FB RID: 54267
		// (get) Token: 0x060326B8 RID: 206520 RVA: 0x006CE565 File Offset: 0x006CC765
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060326B9 RID: 206521 RVA: 0x006CE572 File Offset: 0x006CC772
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060326BA RID: 206522 RVA: 0x006CE57C File Offset: 0x006CC77C
		public static ISeqEventAddTagToSelf GetRootAsISeqEventAddTagToSelf(ByteBuffer _bb)
		{
			return ISeqEventAddTagToSelf.GetRootAsISeqEventAddTagToSelf(_bb, default(ISeqEventAddTagToSelf));
		}

		// Token: 0x060326BB RID: 206523 RVA: 0x006CE598 File Offset: 0x006CC798
		public static ISeqEventAddTagToSelf GetRootAsISeqEventAddTagToSelf(ByteBuffer _bb, ISeqEventAddTagToSelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060326BC RID: 206524 RVA: 0x006CE5B5 File Offset: 0x006CC7B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060326BD RID: 206525 RVA: 0x006CE5C4 File Offset: 0x006CC7C4
		public ISeqEventAddTagToSelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060326BE RID: 206526 RVA: 0x006CE5D4 File Offset: 0x006CC7D4
		public int Tags(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D3FC RID: 54268
		// (get) Token: 0x060326BF RID: 206527 RVA: 0x006CE614 File Offset: 0x006CC814
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

		// Token: 0x060326C0 RID: 206528 RVA: 0x006CE63F File Offset: 0x006CC83F
		public Span<int> GetTagsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x060326C1 RID: 206529 RVA: 0x006CE64E File Offset: 0x006CC84E
		public int[] GetTagsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x060326C2 RID: 206530 RVA: 0x006CE65C File Offset: 0x006CC85C
		public static Offset<ISeqEventAddTagToSelf> CreateISeqEventAddTagToSelf(FlatBufferBuilder builder, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ISeqEventAddTagToSelf.AddTags(builder, TagsOffset);
			return ISeqEventAddTagToSelf.EndISeqEventAddTagToSelf(builder);
		}

		// Token: 0x060326C3 RID: 206531 RVA: 0x006CE672 File Offset: 0x006CC872
		public static void StartISeqEventAddTagToSelf(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060326C4 RID: 206532 RVA: 0x006CE67B File Offset: 0x006CC87B
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(0, tagsOffset.Value, 0);
		}

		// Token: 0x060326C5 RID: 206533 RVA: 0x006CE68C File Offset: 0x006CC88C
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060326C6 RID: 206534 RVA: 0x006CE6C3 File Offset: 0x006CC8C3
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060326C7 RID: 206535 RVA: 0x006CE6DD File Offset: 0x006CC8DD
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060326C8 RID: 206536 RVA: 0x006CE6FB File Offset: 0x006CC8FB
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060326C9 RID: 206537 RVA: 0x006CE714 File Offset: 0x006CC914
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060326CA RID: 206538 RVA: 0x006CE71F File Offset: 0x006CC91F
		public static Offset<ISeqEventAddTagToSelf> EndISeqEventAddTagToSelf(FlatBufferBuilder builder)
		{
			return new Offset<ISeqEventAddTagToSelf>(builder.EndTable());
		}

		// Token: 0x060326CB RID: 206539 RVA: 0x006CE72C File Offset: 0x006CC92C
		public ISeqEventAddTagToSelfT UnPack()
		{
			ISeqEventAddTagToSelfT seqEventAddTagToSelfT = new ISeqEventAddTagToSelfT();
			this.UnPackTo(seqEventAddTagToSelfT);
			return seqEventAddTagToSelfT;
		}

		// Token: 0x060326CC RID: 206540 RVA: 0x006CE748 File Offset: 0x006CC948
		public void UnPackTo(ISeqEventAddTagToSelfT _o)
		{
			_o.Tags = new List<int>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
		}

		// Token: 0x060326CD RID: 206541 RVA: 0x006CE784 File Offset: 0x006CC984
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

		// Token: 0x04011977 RID: 72055
		private Table __p;
	}
}
