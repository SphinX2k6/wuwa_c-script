using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078B7 RID: 30903
	public struct IShowTalk : IFlatbufferObject
	{
		// Token: 0x1700E2B1 RID: 58033
		// (get) Token: 0x0603661B RID: 222747 RVA: 0x00747C2F File Offset: 0x00745E2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603661C RID: 222748 RVA: 0x00747C3C File Offset: 0x00745E3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603661D RID: 222749 RVA: 0x00747C44 File Offset: 0x00745E44
		public static IShowTalk GetRootAsIShowTalk(ByteBuffer _bb)
		{
			return IShowTalk.GetRootAsIShowTalk(_bb, default(IShowTalk));
		}

		// Token: 0x0603661E RID: 222750 RVA: 0x00747C60 File Offset: 0x00745E60
		public static IShowTalk GetRootAsIShowTalk(ByteBuffer _bb, IShowTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603661F RID: 222751 RVA: 0x00747C7D File Offset: 0x00745E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036620 RID: 222752 RVA: 0x00747C8C File Offset: 0x00745E8C
		public IShowTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2B2 RID: 58034
		// (get) Token: 0x06036621 RID: 222753 RVA: 0x00747C9C File Offset: 0x00745E9C
		public bool ResetCamera
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06036622 RID: 222754 RVA: 0x00747CDC File Offset: 0x00745EDC
		public ITalkItem_Union TalkItemsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return ITalkItem_Union.NONE;
			}
			return (ITalkItem_Union)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700E2B3 RID: 58035
		// (get) Token: 0x06036623 RID: 222755 RVA: 0x00747D1C File Offset: 0x00745F1C
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

		// Token: 0x06036624 RID: 222756 RVA: 0x00747D47 File Offset: 0x00745F47
		public Span<ITalkItem_Union> GetTalkItemsTypeBytes()
		{
			return this.__p.__vector_as_span<ITalkItem_Union>(6, 1);
		}

		// Token: 0x06036625 RID: 222757 RVA: 0x00747D58 File Offset: 0x00745F58
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

		// Token: 0x06036626 RID: 222758 RVA: 0x00747DC4 File Offset: 0x00745FC4
		public TTable? TalkItems<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700E2B4 RID: 58036
		// (get) Token: 0x06036627 RID: 222759 RVA: 0x00747E0C File Offset: 0x0074600C
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

		// Token: 0x1700E2B5 RID: 58037
		// (get) Token: 0x06036628 RID: 222760 RVA: 0x00747E38 File Offset: 0x00746038
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

		// Token: 0x1700E2B6 RID: 58038
		// (get) Token: 0x06036629 RID: 222761 RVA: 0x00747E98 File Offset: 0x00746098
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

		// Token: 0x0603662A RID: 222762 RVA: 0x00747ED0 File Offset: 0x007460D0
		public Span<byte> GetSequenceDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0603662B RID: 222763 RVA: 0x00747EE0 File Offset: 0x007460E0
		public byte[] GetSequenceDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0603662C RID: 222764 RVA: 0x00747EF0 File Offset: 0x007460F0
		public IShowTalkFrameEvent? TalkFrameEvents(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IShowTalkFrameEvent?(default(IShowTalkFrameEvent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E2B7 RID: 58039
		// (get) Token: 0x0603662D RID: 222765 RVA: 0x00747F54 File Offset: 0x00746154
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

		// Token: 0x0603662E RID: 222766 RVA: 0x00747F80 File Offset: 0x00746180
		public IShowTalk_TalkSequenceRow? TalkSequence(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IShowTalk_TalkSequenceRow?(default(IShowTalk_TalkSequenceRow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E2B8 RID: 58040
		// (get) Token: 0x0603662F RID: 222767 RVA: 0x00747FE4 File Offset: 0x007461E4
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

		// Token: 0x06036630 RID: 222768 RVA: 0x00748010 File Offset: 0x00746210
		public string SequenceNames(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E2B9 RID: 58041
		// (get) Token: 0x06036631 RID: 222769 RVA: 0x0074804C File Offset: 0x0074624C
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

		// Token: 0x06036632 RID: 222770 RVA: 0x00748078 File Offset: 0x00746278
		public Record_Int_ITalkSequenceTransitions? SequenceTransitions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_ITalkSequenceTransitions?(default(Record_Int_ITalkSequenceTransitions).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E2BA RID: 58042
		// (get) Token: 0x06036633 RID: 222771 RVA: 0x007480DC File Offset: 0x007462DC
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

		// Token: 0x1700E2BB RID: 58043
		// (get) Token: 0x06036634 RID: 222772 RVA: 0x00748108 File Offset: 0x00746308
		public bool SaveFinalPos
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E2BC RID: 58044
		// (get) Token: 0x06036635 RID: 222773 RVA: 0x00748148 File Offset: 0x00746348
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

		// Token: 0x1700E2BD RID: 58045
		// (get) Token: 0x06036636 RID: 222774 RVA: 0x007481A8 File Offset: 0x007463A8
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

		// Token: 0x06036637 RID: 222775 RVA: 0x007481E8 File Offset: 0x007463E8
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

		// Token: 0x06036638 RID: 222776 RVA: 0x00748260 File Offset: 0x00746460
		public static void StartIShowTalk(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06036639 RID: 222777 RVA: 0x0074826A File Offset: 0x0074646A
		public static void AddResetCamera(FlatBufferBuilder builder, bool resetCamera)
		{
			builder.AddBool(0, resetCamera, false);
		}

		// Token: 0x0603663A RID: 222778 RVA: 0x00748275 File Offset: 0x00746475
		public static void AddTalkItemsType(FlatBufferBuilder builder, VectorOffset talkItemsTypeOffset)
		{
			builder.AddOffset(1, talkItemsTypeOffset.Value, 0);
		}

		// Token: 0x0603663B RID: 222779 RVA: 0x00748288 File Offset: 0x00746488
		public static VectorOffset CreateTalkItemsTypeVector(FlatBufferBuilder builder, ITalkItem_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603663C RID: 222780 RVA: 0x007482BF File Offset: 0x007464BF
		public static VectorOffset CreateTalkItemsTypeVectorBlock(FlatBufferBuilder builder, ITalkItem_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ITalkItem_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0603663D RID: 222781 RVA: 0x007482D9 File Offset: 0x007464D9
		public static VectorOffset CreateTalkItemsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<ITalkItem_Union> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ITalkItem_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0603663E RID: 222782 RVA: 0x007482F7 File Offset: 0x007464F7
		public static VectorOffset CreateTalkItemsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ITalkItem_Union>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603663F RID: 222783 RVA: 0x00748310 File Offset: 0x00746510
		public static void StartTalkItemsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06036640 RID: 222784 RVA: 0x0074831B File Offset: 0x0074651B
		public static void AddTalkItems(FlatBufferBuilder builder, VectorOffset talkItemsOffset)
		{
			builder.AddOffset(2, talkItemsOffset.Value, 0);
		}

		// Token: 0x06036641 RID: 222785 RVA: 0x0074832C File Offset: 0x0074652C
		public static VectorOffset CreateTalkItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036642 RID: 222786 RVA: 0x00748363 File Offset: 0x00746563
		public static VectorOffset CreateTalkItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036643 RID: 222787 RVA: 0x0074837D File Offset: 0x0074657D
		public static VectorOffset CreateTalkItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036644 RID: 222788 RVA: 0x0074839B File Offset: 0x0074659B
		public static VectorOffset CreateTalkItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036645 RID: 222789 RVA: 0x007483B4 File Offset: 0x007465B4
		public static void StartTalkItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036646 RID: 222790 RVA: 0x007483BF File Offset: 0x007465BF
		public static void AddTalkOutline(FlatBufferBuilder builder, Offset<IShowTalkOutline> talkOutlineOffset)
		{
			builder.AddOffset(3, talkOutlineOffset.Value, 0);
		}

		// Token: 0x06036647 RID: 222791 RVA: 0x007483CF File Offset: 0x007465CF
		public static void AddSequenceDataAsset(FlatBufferBuilder builder, StringOffset sequenceDataAssetOffset)
		{
			builder.AddOffset(4, sequenceDataAssetOffset.Value, 0);
		}

		// Token: 0x06036648 RID: 222792 RVA: 0x007483DF File Offset: 0x007465DF
		public static void AddTalkFrameEvents(FlatBufferBuilder builder, VectorOffset talkFrameEventsOffset)
		{
			builder.AddOffset(5, talkFrameEventsOffset.Value, 0);
		}

		// Token: 0x06036649 RID: 222793 RVA: 0x007483F0 File Offset: 0x007465F0
		public static VectorOffset CreateTalkFrameEventsVector(FlatBufferBuilder builder, Offset<IShowTalkFrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603664A RID: 222794 RVA: 0x00748430 File Offset: 0x00746630
		public static VectorOffset CreateTalkFrameEventsVectorBlock(FlatBufferBuilder builder, Offset<IShowTalkFrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTalkFrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603664B RID: 222795 RVA: 0x0074844A File Offset: 0x0074664A
		public static VectorOffset CreateTalkFrameEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTalkFrameEvent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTalkFrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603664C RID: 222796 RVA: 0x00748468 File Offset: 0x00746668
		public static VectorOffset CreateTalkFrameEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTalkFrameEvent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603664D RID: 222797 RVA: 0x00748481 File Offset: 0x00746681
		public static void StartTalkFrameEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603664E RID: 222798 RVA: 0x0074848C File Offset: 0x0074668C
		public static void AddTalkSequence(FlatBufferBuilder builder, VectorOffset talkSequenceOffset)
		{
			builder.AddOffset(6, talkSequenceOffset.Value, 0);
		}

		// Token: 0x0603664F RID: 222799 RVA: 0x0074849C File Offset: 0x0074669C
		public static VectorOffset CreateTalkSequenceVector(FlatBufferBuilder builder, Offset<IShowTalk_TalkSequenceRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036650 RID: 222800 RVA: 0x007484DC File Offset: 0x007466DC
		public static VectorOffset CreateTalkSequenceVectorBlock(FlatBufferBuilder builder, Offset<IShowTalk_TalkSequenceRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTalk_TalkSequenceRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036651 RID: 222801 RVA: 0x007484F6 File Offset: 0x007466F6
		public static VectorOffset CreateTalkSequenceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTalk_TalkSequenceRow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTalk_TalkSequenceRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036652 RID: 222802 RVA: 0x00748514 File Offset: 0x00746714
		public static VectorOffset CreateTalkSequenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTalk_TalkSequenceRow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036653 RID: 222803 RVA: 0x0074852D File Offset: 0x0074672D
		public static void StartTalkSequenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036654 RID: 222804 RVA: 0x00748538 File Offset: 0x00746738
		public static void AddSequenceNames(FlatBufferBuilder builder, VectorOffset sequenceNamesOffset)
		{
			builder.AddOffset(7, sequenceNamesOffset.Value, 0);
		}

		// Token: 0x06036655 RID: 222805 RVA: 0x00748548 File Offset: 0x00746748
		public static VectorOffset CreateSequenceNamesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036656 RID: 222806 RVA: 0x00748588 File Offset: 0x00746788
		public static VectorOffset CreateSequenceNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06036657 RID: 222807 RVA: 0x007485A2 File Offset: 0x007467A2
		public static VectorOffset CreateSequenceNamesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06036658 RID: 222808 RVA: 0x007485C0 File Offset: 0x007467C0
		public static VectorOffset CreateSequenceNamesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036659 RID: 222809 RVA: 0x007485D9 File Offset: 0x007467D9
		public static void StartSequenceNamesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603665A RID: 222810 RVA: 0x007485E4 File Offset: 0x007467E4
		public static void AddSequenceTransitions(FlatBufferBuilder builder, VectorOffset sequenceTransitionsOffset)
		{
			builder.AddOffset(8, sequenceTransitionsOffset.Value, 0);
		}

		// Token: 0x0603665B RID: 222811 RVA: 0x007485F4 File Offset: 0x007467F4
		public static VectorOffset CreateSequenceTransitionsVector(FlatBufferBuilder builder, Offset<Record_Int_ITalkSequenceTransitions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603665C RID: 222812 RVA: 0x00748634 File Offset: 0x00746834
		public static VectorOffset CreateSequenceTransitionsVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_ITalkSequenceTransitions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_ITalkSequenceTransitions>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603665D RID: 222813 RVA: 0x0074864E File Offset: 0x0074684E
		public static VectorOffset CreateSequenceTransitionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_ITalkSequenceTransitions>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_ITalkSequenceTransitions>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603665E RID: 222814 RVA: 0x0074866C File Offset: 0x0074686C
		public static VectorOffset CreateSequenceTransitionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_ITalkSequenceTransitions>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603665F RID: 222815 RVA: 0x00748685 File Offset: 0x00746885
		public static void StartSequenceTransitionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036660 RID: 222816 RVA: 0x00748690 File Offset: 0x00746890
		public static void AddSaveFinalPos(FlatBufferBuilder builder, bool saveFinalPos)
		{
			builder.AddBool(9, saveFinalPos, false);
		}

		// Token: 0x06036661 RID: 222817 RVA: 0x0074869C File Offset: 0x0074689C
		public static void AddSeqBlendAnim(FlatBufferBuilder builder, Offset<ISetBlendAnim> seqBlendAnimOffset)
		{
			builder.AddOffset(10, seqBlendAnimOffset.Value, 0);
		}

		// Token: 0x06036662 RID: 222818 RVA: 0x007486AD File Offset: 0x007468AD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x06036663 RID: 222819 RVA: 0x007486B9 File Offset: 0x007468B9
		public static Offset<IShowTalk> EndIShowTalk(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalk>(builder.EndTable());
		}

		// Token: 0x06036664 RID: 222820 RVA: 0x007486C8 File Offset: 0x007468C8
		public IShowTalkT UnPack()
		{
			IShowTalkT showTalkT = new IShowTalkT();
			this.UnPackTo(showTalkT);
			return showTalkT;
		}

		// Token: 0x06036665 RID: 222821 RVA: 0x007486E4 File Offset: 0x007468E4
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

		// Token: 0x06036666 RID: 222822 RVA: 0x00748D9C File Offset: 0x00746F9C
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

		// Token: 0x04012B55 RID: 76629
		private Table __p;
	}
}
