using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070EB RID: 28907
	public struct IShowTalk : IFlatbufferObject
	{
		// Token: 0x1700D6CE RID: 54990
		// (get) Token: 0x06033379 RID: 209785 RVA: 0x006E7623 File Offset: 0x006E5823
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603337A RID: 209786 RVA: 0x006E7630 File Offset: 0x006E5830
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603337B RID: 209787 RVA: 0x006E7638 File Offset: 0x006E5838
		public static IShowTalk GetRootAsIShowTalk(ByteBuffer _bb)
		{
			return IShowTalk.GetRootAsIShowTalk(_bb, default(IShowTalk));
		}

		// Token: 0x0603337C RID: 209788 RVA: 0x006E7654 File Offset: 0x006E5854
		public static IShowTalk GetRootAsIShowTalk(ByteBuffer _bb, IShowTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603337D RID: 209789 RVA: 0x006E7671 File Offset: 0x006E5871
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603337E RID: 209790 RVA: 0x006E7680 File Offset: 0x006E5880
		public IShowTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6CF RID: 54991
		// (get) Token: 0x0603337F RID: 209791 RVA: 0x006E7690 File Offset: 0x006E5890
		public bool ResetCamera
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06033380 RID: 209792 RVA: 0x006E76D0 File Offset: 0x006E58D0
		public ITalkItem_Union TalkItemsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return ITalkItem_Union.NONE;
			}
			return (ITalkItem_Union)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D6D0 RID: 54992
		// (get) Token: 0x06033381 RID: 209793 RVA: 0x006E7710 File Offset: 0x006E5910
		public int TalkItemsTypeLength
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

		// Token: 0x06033382 RID: 209794 RVA: 0x006E773B File Offset: 0x006E593B
		public Span<ITalkItem_Union> GetTalkItemsTypeBytes()
		{
			return this.__p.__vector_as_span<ITalkItem_Union>(6, 1);
		}

		// Token: 0x06033383 RID: 209795 RVA: 0x006E774C File Offset: 0x006E594C
		public ITalkItem_Union[] GetTalkItemsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ITalkItem_Union[] array = new ITalkItem_Union[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ITalkItem_Union)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06033384 RID: 209796 RVA: 0x006E77B8 File Offset: 0x006E59B8
		public TTable? TalkItems<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700D6D1 RID: 54993
		// (get) Token: 0x06033385 RID: 209797 RVA: 0x006E7800 File Offset: 0x006E5A00
		public int TalkItemsLength
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

		// Token: 0x1700D6D2 RID: 54994
		// (get) Token: 0x06033386 RID: 209798 RVA: 0x006E782C File Offset: 0x006E5A2C
		public IShowTalkOutline? TalkOutline
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IShowTalkOutline?(default(IShowTalkOutline).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D6D3 RID: 54995
		// (get) Token: 0x06033387 RID: 209799 RVA: 0x006E788C File Offset: 0x006E5A8C
		public string SequenceDataAsset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033388 RID: 209800 RVA: 0x006E78C4 File Offset: 0x006E5AC4
		public Span<byte> GetSequenceDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06033389 RID: 209801 RVA: 0x006E78D4 File Offset: 0x006E5AD4
		public byte[] GetSequenceDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0603338A RID: 209802 RVA: 0x006E78E4 File Offset: 0x006E5AE4
		public IShowTalkFrameEvent? TalkFrameEvents(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IShowTalkFrameEvent?(default(IShowTalkFrameEvent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D6D4 RID: 54996
		// (get) Token: 0x0603338B RID: 209803 RVA: 0x006E7948 File Offset: 0x006E5B48
		public int TalkFrameEventsLength
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

		// Token: 0x0603338C RID: 209804 RVA: 0x006E7974 File Offset: 0x006E5B74
		public IShowTalk_TalkSequenceRow? TalkSequence(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IShowTalk_TalkSequenceRow?(default(IShowTalk_TalkSequenceRow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D6D5 RID: 54997
		// (get) Token: 0x0603338D RID: 209805 RVA: 0x006E79D8 File Offset: 0x006E5BD8
		public int TalkSequenceLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0603338E RID: 209806 RVA: 0x006E7A04 File Offset: 0x006E5C04
		public string SequenceNames(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D6D6 RID: 54998
		// (get) Token: 0x0603338F RID: 209807 RVA: 0x006E7A40 File Offset: 0x006E5C40
		public int SequenceNamesLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06033390 RID: 209808 RVA: 0x006E7A6C File Offset: 0x006E5C6C
		public Record_Int_ITalkSequenceTransitions? SequenceTransitions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_ITalkSequenceTransitions?(default(Record_Int_ITalkSequenceTransitions).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D6D7 RID: 54999
		// (get) Token: 0x06033391 RID: 209809 RVA: 0x006E7AD0 File Offset: 0x006E5CD0
		public int SequenceTransitionsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700D6D8 RID: 55000
		// (get) Token: 0x06033392 RID: 209810 RVA: 0x006E7AFC File Offset: 0x006E5CFC
		public bool SaveFinalPos
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D6D9 RID: 55001
		// (get) Token: 0x06033393 RID: 209811 RVA: 0x006E7B3C File Offset: 0x006E5D3C
		public ISetBlendAnim? SeqBlendAnim
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new ISetBlendAnim?(default(ISetBlendAnim).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D6DA RID: 55002
		// (get) Token: 0x06033394 RID: 209812 RVA: 0x006E7B9C File Offset: 0x006E5D9C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033395 RID: 209813 RVA: 0x006E7BDC File Offset: 0x006E5DDC
		public static Offset<IShowTalk> CreateIShowTalk(FlatBufferBuilder builder, bool ResetCamera = false, VectorOffset TalkItems_typeOffset = default(VectorOffset), VectorOffset TalkItemsOffset = default(VectorOffset), Offset<IShowTalkOutline> TalkOutlineOffset = default(Offset<IShowTalkOutline>), StringOffset SequenceDataAssetOffset = default(StringOffset), VectorOffset TalkFrameEventsOffset = default(VectorOffset), VectorOffset TalkSequenceOffset = default(VectorOffset), VectorOffset SequenceNamesOffset = default(VectorOffset), VectorOffset SequenceTransitionsOffset = default(VectorOffset), bool SaveFinalPos = false, Offset<ISetBlendAnim> SeqBlendAnimOffset = default(Offset<ISetBlendAnim>), byte NullMask = 0)
		{
			builder.StartTable(12);
			IShowTalk.AddSeqBlendAnim(builder, SeqBlendAnimOffset);
			IShowTalk.AddSequenceTransitions(builder, SequenceTransitionsOffset);
			IShowTalk.AddSequenceNames(builder, SequenceNamesOffset);
			IShowTalk.AddTalkSequence(builder, TalkSequenceOffset);
			IShowTalk.AddTalkFrameEvents(builder, TalkFrameEventsOffset);
			IShowTalk.AddSequenceDataAsset(builder, SequenceDataAssetOffset);
			IShowTalk.AddTalkOutline(builder, TalkOutlineOffset);
			IShowTalk.AddTalkItems(builder, TalkItemsOffset);
			IShowTalk.AddTalkItemsType(builder, TalkItems_typeOffset);
			IShowTalk.AddNullMask(builder, NullMask);
			IShowTalk.AddSaveFinalPos(builder, SaveFinalPos);
			IShowTalk.AddResetCamera(builder, ResetCamera);
			return IShowTalk.EndIShowTalk(builder);
		}

		// Token: 0x06033396 RID: 209814 RVA: 0x006E7C54 File Offset: 0x006E5E54
		public static void StartIShowTalk(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06033397 RID: 209815 RVA: 0x006E7C5E File Offset: 0x006E5E5E
		public static void AddResetCamera(FlatBufferBuilder builder, bool resetCamera)
		{
			builder.AddBool(0, resetCamera, false);
		}

		// Token: 0x06033398 RID: 209816 RVA: 0x006E7C69 File Offset: 0x006E5E69
		public static void AddTalkItemsType(FlatBufferBuilder builder, VectorOffset talkItemsTypeOffset)
		{
			builder.AddOffset(1, talkItemsTypeOffset.Value, 0);
		}

		// Token: 0x06033399 RID: 209817 RVA: 0x006E7C7C File Offset: 0x006E5E7C
		public static VectorOffset CreateTalkItemsTypeVector(FlatBufferBuilder builder, ITalkItem_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603339A RID: 209818 RVA: 0x006E7CB3 File Offset: 0x006E5EB3
		public static VectorOffset CreateTalkItemsTypeVectorBlock(FlatBufferBuilder builder, ITalkItem_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ITalkItem_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0603339B RID: 209819 RVA: 0x006E7CCD File Offset: 0x006E5ECD
		public static VectorOffset CreateTalkItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<ITalkItem_Union> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ITalkItem_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0603339C RID: 209820 RVA: 0x006E7CEB File Offset: 0x006E5EEB
		public static VectorOffset CreateTalkItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ITalkItem_Union>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603339D RID: 209821 RVA: 0x006E7D04 File Offset: 0x006E5F04
		public static void StartTalkItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603339E RID: 209822 RVA: 0x006E7D0F File Offset: 0x006E5F0F
		public static void AddTalkItems(FlatBufferBuilder builder, VectorOffset talkItemsOffset)
		{
			builder.AddOffset(2, talkItemsOffset.Value, 0);
		}

		// Token: 0x0603339F RID: 209823 RVA: 0x006E7D20 File Offset: 0x006E5F20
		public static VectorOffset CreateTalkItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060333A0 RID: 209824 RVA: 0x006E7D57 File Offset: 0x006E5F57
		public static VectorOffset CreateTalkItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060333A1 RID: 209825 RVA: 0x006E7D71 File Offset: 0x006E5F71
		public static VectorOffset CreateTalkItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060333A2 RID: 209826 RVA: 0x006E7D8F File Offset: 0x006E5F8F
		public static VectorOffset CreateTalkItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060333A3 RID: 209827 RVA: 0x006E7DA8 File Offset: 0x006E5FA8
		public static void StartTalkItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060333A4 RID: 209828 RVA: 0x006E7DB3 File Offset: 0x006E5FB3
		public static void AddTalkOutline(FlatBufferBuilder builder, Offset<IShowTalkOutline> talkOutlineOffset)
		{
			builder.AddOffset(3, talkOutlineOffset.Value, 0);
		}

		// Token: 0x060333A5 RID: 209829 RVA: 0x006E7DC3 File Offset: 0x006E5FC3
		public static void AddSequenceDataAsset(FlatBufferBuilder builder, StringOffset sequenceDataAssetOffset)
		{
			builder.AddOffset(4, sequenceDataAssetOffset.Value, 0);
		}

		// Token: 0x060333A6 RID: 209830 RVA: 0x006E7DD3 File Offset: 0x006E5FD3
		public static void AddTalkFrameEvents(FlatBufferBuilder builder, VectorOffset talkFrameEventsOffset)
		{
			builder.AddOffset(5, talkFrameEventsOffset.Value, 0);
		}

		// Token: 0x060333A7 RID: 209831 RVA: 0x006E7DE4 File Offset: 0x006E5FE4
		public static VectorOffset CreateTalkFrameEventsVector(FlatBufferBuilder builder, Offset<IShowTalkFrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060333A8 RID: 209832 RVA: 0x006E7E24 File Offset: 0x006E6024
		public static VectorOffset CreateTalkFrameEventsVectorBlock(FlatBufferBuilder builder, Offset<IShowTalkFrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTalkFrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060333A9 RID: 209833 RVA: 0x006E7E3E File Offset: 0x006E603E
		public static VectorOffset CreateTalkFrameEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTalkFrameEvent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTalkFrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060333AA RID: 209834 RVA: 0x006E7E5C File Offset: 0x006E605C
		public static VectorOffset CreateTalkFrameEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTalkFrameEvent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060333AB RID: 209835 RVA: 0x006E7E75 File Offset: 0x006E6075
		public static void StartTalkFrameEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060333AC RID: 209836 RVA: 0x006E7E80 File Offset: 0x006E6080
		public static void AddTalkSequence(FlatBufferBuilder builder, VectorOffset talkSequenceOffset)
		{
			builder.AddOffset(6, talkSequenceOffset.Value, 0);
		}

		// Token: 0x060333AD RID: 209837 RVA: 0x006E7E90 File Offset: 0x006E6090
		public static VectorOffset CreateTalkSequenceVector(FlatBufferBuilder builder, Offset<IShowTalk_TalkSequenceRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060333AE RID: 209838 RVA: 0x006E7ED0 File Offset: 0x006E60D0
		public static VectorOffset CreateTalkSequenceVectorBlock(FlatBufferBuilder builder, Offset<IShowTalk_TalkSequenceRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTalk_TalkSequenceRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x060333AF RID: 209839 RVA: 0x006E7EEA File Offset: 0x006E60EA
		public static VectorOffset CreateTalkSequenceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTalk_TalkSequenceRow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTalk_TalkSequenceRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x060333B0 RID: 209840 RVA: 0x006E7F08 File Offset: 0x006E6108
		public static VectorOffset CreateTalkSequenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTalk_TalkSequenceRow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060333B1 RID: 209841 RVA: 0x006E7F21 File Offset: 0x006E6121
		public static void StartTalkSequenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060333B2 RID: 209842 RVA: 0x006E7F2C File Offset: 0x006E612C
		public static void AddSequenceNames(FlatBufferBuilder builder, VectorOffset sequenceNamesOffset)
		{
			builder.AddOffset(7, sequenceNamesOffset.Value, 0);
		}

		// Token: 0x060333B3 RID: 209843 RVA: 0x006E7F3C File Offset: 0x006E613C
		public static VectorOffset CreateSequenceNamesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060333B4 RID: 209844 RVA: 0x006E7F7C File Offset: 0x006E617C
		public static VectorOffset CreateSequenceNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060333B5 RID: 209845 RVA: 0x006E7F96 File Offset: 0x006E6196
		public static VectorOffset CreateSequenceNamesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060333B6 RID: 209846 RVA: 0x006E7FB4 File Offset: 0x006E61B4
		public static VectorOffset CreateSequenceNamesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060333B7 RID: 209847 RVA: 0x006E7FCD File Offset: 0x006E61CD
		public static void StartSequenceNamesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060333B8 RID: 209848 RVA: 0x006E7FD8 File Offset: 0x006E61D8
		public static void AddSequenceTransitions(FlatBufferBuilder builder, VectorOffset sequenceTransitionsOffset)
		{
			builder.AddOffset(8, sequenceTransitionsOffset.Value, 0);
		}

		// Token: 0x060333B9 RID: 209849 RVA: 0x006E7FE8 File Offset: 0x006E61E8
		public static VectorOffset CreateSequenceTransitionsVector(FlatBufferBuilder builder, Offset<Record_Int_ITalkSequenceTransitions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060333BA RID: 209850 RVA: 0x006E8028 File Offset: 0x006E6228
		public static VectorOffset CreateSequenceTransitionsVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_ITalkSequenceTransitions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_ITalkSequenceTransitions>>(data);
			return builder.EndVector();
		}

		// Token: 0x060333BB RID: 209851 RVA: 0x006E8042 File Offset: 0x006E6242
		public static VectorOffset CreateSequenceTransitionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_ITalkSequenceTransitions>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_ITalkSequenceTransitions>>(data);
			return builder.EndVector();
		}

		// Token: 0x060333BC RID: 209852 RVA: 0x006E8060 File Offset: 0x006E6260
		public static VectorOffset CreateSequenceTransitionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_ITalkSequenceTransitions>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060333BD RID: 209853 RVA: 0x006E8079 File Offset: 0x006E6279
		public static void StartSequenceTransitionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060333BE RID: 209854 RVA: 0x006E8084 File Offset: 0x006E6284
		public static void AddSaveFinalPos(FlatBufferBuilder builder, bool saveFinalPos)
		{
			builder.AddBool(9, saveFinalPos, false);
		}

		// Token: 0x060333BF RID: 209855 RVA: 0x006E8090 File Offset: 0x006E6290
		public static void AddSeqBlendAnim(FlatBufferBuilder builder, Offset<ISetBlendAnim> seqBlendAnimOffset)
		{
			builder.AddOffset(10, seqBlendAnimOffset.Value, 0);
		}

		// Token: 0x060333C0 RID: 209856 RVA: 0x006E80A1 File Offset: 0x006E62A1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060333C1 RID: 209857 RVA: 0x006E80AD File Offset: 0x006E62AD
		public static Offset<IShowTalk> EndIShowTalk(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalk>(builder.EndTable());
		}

		// Token: 0x060333C2 RID: 209858 RVA: 0x006E80BC File Offset: 0x006E62BC
		public IShowTalkT UnPack()
		{
			IShowTalkT showTalkT = new IShowTalkT();
			this.UnPackTo(showTalkT);
			return showTalkT;
		}

		// Token: 0x060333C3 RID: 209859 RVA: 0x006E80D8 File Offset: 0x006E62D8
		public void UnPackTo(IShowTalkT _o)
		{
			_o.ResetCamera = this.ResetCamera;
			_o.TalkItems = new List<ITalkItem_UnionUnion>();
			for (int i = 0; i < this.TalkItemsLength; i++)
			{
				ITalkItem_UnionUnion talkItem_UnionUnion = new ITalkItem_UnionUnion();
				talkItem_UnionUnion.Type = this.TalkItemsType(i);
				switch (this.TalkItemsType(i))
				{
				case ITalkItem_Union.ITalkItem:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItem>(i) != null) ? this.TalkItems<ITalkItem>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemDialog:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemDialog>(i) != null) ? this.TalkItems<ITalkItemDialog>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemOption:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemOption>(i) != null) ? this.TalkItems<ITalkItemOption>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemSystemOption:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemSystemOption>(i) != null) ? this.TalkItems<ITalkItemSystemOption>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemCenterText:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemCenterText>(i) != null) ? this.TalkItems<ITalkItemCenterText>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemQte:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemQte>(i) != null) ? this.TalkItems<ITalkItemQte>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemNoTextItem:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemNoTextItem>(i) != null) ? this.TalkItems<ITalkItemNoTextItem>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemPhoneMessage:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemPhoneMessage>(i) != null) ? this.TalkItems<ITalkItemPhoneMessage>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemAvgTalk:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemAvgTalk>(i) != null) ? this.TalkItems<ITalkItemAvgTalk>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemAvgEnter:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemAvgEnter>(i) != null) ? this.TalkItems<ITalkItemAvgEnter>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemAvgExit:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemAvgExit>(i) != null) ? this.TalkItems<ITalkItemAvgExit>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemAvgOption:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemAvgOption>(i) != null) ? this.TalkItems<ITalkItemAvgOption>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemAvgNarration:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemAvgNarration>(i) != null) ? this.TalkItems<ITalkItemAvgNarration>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemAvgCenterText:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemAvgCenterText>(i) != null) ? this.TalkItems<ITalkItemAvgCenterText>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemVisualNovelTalk:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemVisualNovelTalk>(i) != null) ? this.TalkItems<ITalkItemVisualNovelTalk>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemVisualNovelNoTextItem:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemVisualNovelNoTextItem>(i) != null) ? this.TalkItems<ITalkItemVisualNovelNoTextItem>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemVisualNovelNarration:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemVisualNovelNarration>(i) != null) ? this.TalkItems<ITalkItemVisualNovelNarration>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemVisualNovelOption:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemVisualNovelOption>(i) != null) ? this.TalkItems<ITalkItemVisualNovelOption>(i).Value.UnPack() : null);
					break;
				case ITalkItem_Union.ITalkItemVisualNovelCenterText:
					talkItem_UnionUnion.Value = ((this.TalkItems<ITalkItemVisualNovelCenterText>(i) != null) ? this.TalkItems<ITalkItemVisualNovelCenterText>(i).Value.UnPack() : null);
					break;
				}
				_o.TalkItems.Add(talkItem_UnionUnion);
			}
			_o.TalkOutline = ((this.TalkOutline != null) ? this.TalkOutline.Value.UnPack() : null);
			_o.SequenceDataAsset = this.SequenceDataAsset;
			_o.TalkFrameEvents = new List<IShowTalkFrameEventT>();
			for (int j = 0; j < this.TalkFrameEventsLength; j++)
			{
				_o.TalkFrameEvents.Add((this.TalkFrameEvents(j) != null) ? this.TalkFrameEvents(j).Value.UnPack() : null);
			}
			_o.TalkSequence = new List<IShowTalk_TalkSequenceRowT>();
			for (int k = 0; k < this.TalkSequenceLength; k++)
			{
				_o.TalkSequence.Add((this.TalkSequence(k) != null) ? this.TalkSequence(k).Value.UnPack() : null);
			}
			_o.SequenceNames = new List<string>();
			for (int l = 0; l < this.SequenceNamesLength; l++)
			{
				_o.SequenceNames.Add(this.SequenceNames(l));
			}
			_o.SequenceTransitions = new List<Record_Int_ITalkSequenceTransitionsT>();
			for (int m = 0; m < this.SequenceTransitionsLength; m++)
			{
				_o.SequenceTransitions.Add((this.SequenceTransitions(m) != null) ? this.SequenceTransitions(m).Value.UnPack() : null);
			}
			_o.SaveFinalPos = this.SaveFinalPos;
			_o.SeqBlendAnim = ((this.SeqBlendAnim != null) ? this.SeqBlendAnim.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060333C4 RID: 209860 RVA: 0x006E8790 File Offset: 0x006E6990
		public static Offset<IShowTalk> Pack(FlatBufferBuilder builder, IShowTalkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalk>);
			}
			VectorOffset talkItems_typeOffset = default(VectorOffset);
			if (_o.TalkItems != null)
			{
				ITalkItem_Union[] array = new ITalkItem_Union[_o.TalkItems.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.TalkItems[i].Type;
				}
				talkItems_typeOffset = IShowTalk.CreateTalkItemsTypeVector(builder, array);
			}
			VectorOffset talkItemsOffset = default(VectorOffset);
			if (_o.TalkItems != null)
			{
				int[] array2 = new int[_o.TalkItems.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ITalkItem_UnionUnion.Pack(builder, _o.TalkItems[j]);
				}
				talkItemsOffset = IShowTalk.CreateTalkItemsVector(builder, array2);
			}
			Offset<IShowTalkOutline> talkOutlineOffset = (_o.TalkOutline == null) ? default(Offset<IShowTalkOutline>) : IShowTalkOutline.Pack(builder, _o.TalkOutline);
			StringOffset sequenceDataAssetOffset = (_o.SequenceDataAsset == null) ? default(StringOffset) : builder.CreateString(_o.SequenceDataAsset);
			VectorOffset talkFrameEventsOffset = default(VectorOffset);
			if (_o.TalkFrameEvents != null)
			{
				Offset<IShowTalkFrameEvent>[] array3 = new Offset<IShowTalkFrameEvent>[_o.TalkFrameEvents.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IShowTalkFrameEvent.Pack(builder, _o.TalkFrameEvents[k]);
				}
				talkFrameEventsOffset = IShowTalk.CreateTalkFrameEventsVector(builder, array3);
			}
			VectorOffset talkSequenceOffset = default(VectorOffset);
			if (_o.TalkSequence != null)
			{
				Offset<IShowTalk_TalkSequenceRow>[] array4 = new Offset<IShowTalk_TalkSequenceRow>[_o.TalkSequence.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IShowTalk_TalkSequenceRow.Pack(builder, _o.TalkSequence[l]);
				}
				talkSequenceOffset = IShowTalk.CreateTalkSequenceVector(builder, array4);
			}
			VectorOffset sequenceNamesOffset = default(VectorOffset);
			if (_o.SequenceNames != null)
			{
				StringOffset[] array5 = new StringOffset[_o.SequenceNames.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = builder.CreateString(_o.SequenceNames[m]);
				}
				sequenceNamesOffset = IShowTalk.CreateSequenceNamesVector(builder, array5);
			}
			VectorOffset sequenceTransitionsOffset = default(VectorOffset);
			if (_o.SequenceTransitions != null)
			{
				Offset<Record_Int_ITalkSequenceTransitions>[] array6 = new Offset<Record_Int_ITalkSequenceTransitions>[_o.SequenceTransitions.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = Record_Int_ITalkSequenceTransitions.Pack(builder, _o.SequenceTransitions[n]);
				}
				sequenceTransitionsOffset = IShowTalk.CreateSequenceTransitionsVector(builder, array6);
			}
			Offset<ISetBlendAnim> seqBlendAnimOffset = (_o.SeqBlendAnim == null) ? default(Offset<ISetBlendAnim>) : ISetBlendAnim.Pack(builder, _o.SeqBlendAnim);
			return IShowTalk.CreateIShowTalk(builder, _o.ResetCamera, talkItems_typeOffset, talkItemsOffset, talkOutlineOffset, sequenceDataAssetOffset, talkFrameEventsOffset, talkSequenceOffset, sequenceNamesOffset, sequenceTransitionsOffset, _o.SaveFinalPos, seqBlendAnimOffset, _o.NullMask);
		}

		// Token: 0x04011B67 RID: 72551
		private Table __p;
	}
}
