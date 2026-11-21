using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005121 RID: 20769
	public struct IGramophoneCheckCondition : IFlatbufferObject
	{
		// Token: 0x170094D3 RID: 38099
		// (get) Token: 0x06020A6B RID: 133739 RVA: 0x0048685A File Offset: 0x00484A5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020A6C RID: 133740 RVA: 0x00486867 File Offset: 0x00484A67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020A6D RID: 133741 RVA: 0x00486870 File Offset: 0x00484A70
		public static IGramophoneCheckCondition GetRootAsIGramophoneCheckCondition(ByteBuffer _bb)
		{
			return IGramophoneCheckCondition.GetRootAsIGramophoneCheckCondition(_bb, default(IGramophoneCheckCondition));
		}

		// Token: 0x06020A6E RID: 133742 RVA: 0x0048688C File Offset: 0x00484A8C
		public static IGramophoneCheckCondition GetRootAsIGramophoneCheckCondition(ByteBuffer _bb, IGramophoneCheckCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020A6F RID: 133743 RVA: 0x004868A9 File Offset: 0x00484AA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020A70 RID: 133744 RVA: 0x004868B8 File Offset: 0x00484AB8
		public IGramophoneCheckCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094D4 RID: 38100
		// (get) Token: 0x06020A71 RID: 133745 RVA: 0x004868C8 File Offset: 0x00484AC8
		public ECommonMatchType CheckType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonMatchType.MatchAll;
				}
				return (ECommonMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020A72 RID: 133746 RVA: 0x00486904 File Offset: 0x00484B04
		public int PlayList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170094D5 RID: 38101
		// (get) Token: 0x06020A73 RID: 133747 RVA: 0x00486944 File Offset: 0x00484B44
		public int PlayListLength
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

		// Token: 0x06020A74 RID: 133748 RVA: 0x0048696F File Offset: 0x00484B6F
		public Span<int> GetPlayListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06020A75 RID: 133749 RVA: 0x0048697E File Offset: 0x00484B7E
		public int[] GetPlayListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06020A76 RID: 133750 RVA: 0x0048698C File Offset: 0x00484B8C
		public static Offset<IGramophoneCheckCondition> CreateIGramophoneCheckCondition(FlatBufferBuilder builder, ECommonMatchType CheckType = ECommonMatchType.MatchAll, VectorOffset PlayListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IGramophoneCheckCondition.AddPlayList(builder, PlayListOffset);
			IGramophoneCheckCondition.AddCheckType(builder, CheckType);
			return IGramophoneCheckCondition.EndIGramophoneCheckCondition(builder);
		}

		// Token: 0x06020A77 RID: 133751 RVA: 0x004869A9 File Offset: 0x00484BA9
		public static void StartIGramophoneCheckCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020A78 RID: 133752 RVA: 0x004869B2 File Offset: 0x00484BB2
		public static void AddCheckType(FlatBufferBuilder builder, ECommonMatchType checkType)
		{
			builder.AddByte(0, (byte)checkType, 0);
		}

		// Token: 0x06020A79 RID: 133753 RVA: 0x004869BD File Offset: 0x00484BBD
		public static void AddPlayList(FlatBufferBuilder builder, VectorOffset playListOffset)
		{
			builder.AddOffset(1, playListOffset.Value, 0);
		}

		// Token: 0x06020A7A RID: 133754 RVA: 0x004869D0 File Offset: 0x00484BD0
		public static VectorOffset CreatePlayListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020A7B RID: 133755 RVA: 0x00486A07 File Offset: 0x00484C07
		public static VectorOffset CreatePlayListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020A7C RID: 133756 RVA: 0x00486A21 File Offset: 0x00484C21
		public static VectorOffset CreatePlayListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020A7D RID: 133757 RVA: 0x00486A3F File Offset: 0x00484C3F
		public static VectorOffset CreatePlayListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020A7E RID: 133758 RVA: 0x00486A58 File Offset: 0x00484C58
		public static void StartPlayListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020A7F RID: 133759 RVA: 0x00486A63 File Offset: 0x00484C63
		public static Offset<IGramophoneCheckCondition> EndIGramophoneCheckCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGramophoneCheckCondition>(builder.EndTable());
		}

		// Token: 0x06020A80 RID: 133760 RVA: 0x00486A70 File Offset: 0x00484C70
		public IGramophoneCheckConditionT UnPack()
		{
			IGramophoneCheckConditionT gramophoneCheckConditionT = new IGramophoneCheckConditionT();
			this.UnPackTo(gramophoneCheckConditionT);
			return gramophoneCheckConditionT;
		}

		// Token: 0x06020A81 RID: 133761 RVA: 0x00486A8C File Offset: 0x00484C8C
		public void UnPackTo(IGramophoneCheckConditionT _o)
		{
			_o.CheckType = this.CheckType;
			_o.PlayList = new List<int>();
			for (int i = 0; i < this.PlayListLength; i++)
			{
				_o.PlayList.Add(this.PlayList(i));
			}
		}

		// Token: 0x06020A82 RID: 133762 RVA: 0x00486AD4 File Offset: 0x00484CD4
		public static Offset<IGramophoneCheckCondition> Pack(FlatBufferBuilder builder, IGramophoneCheckConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGramophoneCheckCondition>);
			}
			VectorOffset playListOffset = default(VectorOffset);
			if (_o.PlayList != null)
			{
				int[] data = _o.PlayList.ToArray();
				playListOffset = IGramophoneCheckCondition.CreatePlayListVector(builder, data);
			}
			return IGramophoneCheckCondition.CreateIGramophoneCheckCondition(builder, _o.CheckType, playListOffset);
		}

		// Token: 0x0400E0EF RID: 57583
		private Table __p;
	}
}
