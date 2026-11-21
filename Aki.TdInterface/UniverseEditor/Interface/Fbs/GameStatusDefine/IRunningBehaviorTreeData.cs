using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B65 RID: 19301
	public struct IRunningBehaviorTreeData : IFlatbufferObject
	{
		// Token: 0x17008838 RID: 34872
		// (get) Token: 0x0601D52A RID: 120106 RVA: 0x0041DFA0 File Offset: 0x0041C1A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D52B RID: 120107 RVA: 0x0041DFAD File Offset: 0x0041C1AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D52C RID: 120108 RVA: 0x0041DFB4 File Offset: 0x0041C1B4
		public static IRunningBehaviorTreeData GetRootAsIRunningBehaviorTreeData(ByteBuffer _bb)
		{
			return IRunningBehaviorTreeData.GetRootAsIRunningBehaviorTreeData(_bb, default(IRunningBehaviorTreeData));
		}

		// Token: 0x0601D52D RID: 120109 RVA: 0x0041DFD0 File Offset: 0x0041C1D0
		public static IRunningBehaviorTreeData GetRootAsIRunningBehaviorTreeData(ByteBuffer _bb, IRunningBehaviorTreeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D52E RID: 120110 RVA: 0x0041DFED File Offset: 0x0041C1ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D52F RID: 120111 RVA: 0x0041DFFC File Offset: 0x0041C1FC
		public IRunningBehaviorTreeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008839 RID: 34873
		// (get) Token: 0x0601D530 RID: 120112 RVA: 0x0041E00C File Offset: 0x0041C20C
		public IRunningQuests? Quest
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IRunningQuests?(default(IRunningQuests).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D531 RID: 120113 RVA: 0x0041E06C File Offset: 0x0041C26C
		public IRunningTree? LevelPlays(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRunningTree?(default(IRunningTree).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700883A RID: 34874
		// (get) Token: 0x0601D532 RID: 120114 RVA: 0x0041E0CC File Offset: 0x0041C2CC
		public int LevelPlaysLength
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

		// Token: 0x0601D533 RID: 120115 RVA: 0x0041E0F8 File Offset: 0x0041C2F8
		public int FinishedQuests(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700883B RID: 34875
		// (get) Token: 0x0601D534 RID: 120116 RVA: 0x0041E138 File Offset: 0x0041C338
		public int FinishedQuestsLength
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

		// Token: 0x0601D535 RID: 120117 RVA: 0x0041E163 File Offset: 0x0041C363
		public Span<int> GetFinishedQuestsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601D536 RID: 120118 RVA: 0x0041E172 File Offset: 0x0041C372
		public int[] GetFinishedQuestsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601D537 RID: 120119 RVA: 0x0041E180 File Offset: 0x0041C380
		public int FinishedLevelPlays(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700883C RID: 34876
		// (get) Token: 0x0601D538 RID: 120120 RVA: 0x0041E1C0 File Offset: 0x0041C3C0
		public int FinishedLevelPlaysLength
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

		// Token: 0x0601D539 RID: 120121 RVA: 0x0041E1EC File Offset: 0x0041C3EC
		public Span<int> GetFinishedLevelPlaysBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601D53A RID: 120122 RVA: 0x0041E1FC File Offset: 0x0041C3FC
		public int[] GetFinishedLevelPlaysArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601D53B RID: 120123 RVA: 0x0041E20C File Offset: 0x0041C40C
		public Record_String_String? GlobalVars(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_String?(default(Record_String_String).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700883D RID: 34877
		// (get) Token: 0x0601D53C RID: 120124 RVA: 0x0041E270 File Offset: 0x0041C470
		public int GlobalVarsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601D53D RID: 120125 RVA: 0x0041E29C File Offset: 0x0041C49C
		public IGameCurrBreakNodeEventInfo? TriggerBreakNodes(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IGameCurrBreakNodeEventInfo?(default(IGameCurrBreakNodeEventInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700883E RID: 34878
		// (get) Token: 0x0601D53E RID: 120126 RVA: 0x0041E300 File Offset: 0x0041C500
		public int TriggerBreakNodesLength
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

		// Token: 0x0601D53F RID: 120127 RVA: 0x0041E32C File Offset: 0x0041C52C
		public IHideRangeInfo? HideRangeInfos(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IHideRangeInfo?(default(IHideRangeInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700883F RID: 34879
		// (get) Token: 0x0601D540 RID: 120128 RVA: 0x0041E390 File Offset: 0x0041C590
		public int HideRangeInfosLength
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

		// Token: 0x17008840 RID: 34880
		// (get) Token: 0x0601D541 RID: 120129 RVA: 0x0041E3BC File Offset: 0x0041C5BC
		public string HideGroupInfo
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D542 RID: 120130 RVA: 0x0041E3F4 File Offset: 0x0041C5F4
		public Span<byte> GetHideGroupInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601D543 RID: 120131 RVA: 0x0041E404 File Offset: 0x0041C604
		public byte[] GetHideGroupInfoArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x0601D544 RID: 120132 RVA: 0x0041E414 File Offset: 0x0041C614
		public Record_String_IRunningFlowInfo? FlowInfos(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_IRunningFlowInfo?(default(Record_String_IRunningFlowInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008841 RID: 34881
		// (get) Token: 0x0601D545 RID: 120133 RVA: 0x0041E478 File Offset: 0x0041C678
		public int FlowInfosLength
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

		// Token: 0x17008842 RID: 34882
		// (get) Token: 0x0601D546 RID: 120134 RVA: 0x0041E4A4 File Offset: 0x0041C6A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D547 RID: 120135 RVA: 0x0041E4E4 File Offset: 0x0041C6E4
		public static Offset<IRunningBehaviorTreeData> CreateIRunningBehaviorTreeData(FlatBufferBuilder builder, Offset<IRunningQuests> QuestOffset = default(Offset<IRunningQuests>), VectorOffset LevelPlaysOffset = default(VectorOffset), VectorOffset FinishedQuestsOffset = default(VectorOffset), VectorOffset FinishedLevelPlaysOffset = default(VectorOffset), VectorOffset GlobalVarsOffset = default(VectorOffset), VectorOffset TriggerBreakNodesOffset = default(VectorOffset), VectorOffset HideRangeInfosOffset = default(VectorOffset), StringOffset HideGroupInfoOffset = default(StringOffset), VectorOffset FlowInfosOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(10);
			IRunningBehaviorTreeData.AddFlowInfos(builder, FlowInfosOffset);
			IRunningBehaviorTreeData.AddHideGroupInfo(builder, HideGroupInfoOffset);
			IRunningBehaviorTreeData.AddHideRangeInfos(builder, HideRangeInfosOffset);
			IRunningBehaviorTreeData.AddTriggerBreakNodes(builder, TriggerBreakNodesOffset);
			IRunningBehaviorTreeData.AddGlobalVars(builder, GlobalVarsOffset);
			IRunningBehaviorTreeData.AddFinishedLevelPlays(builder, FinishedLevelPlaysOffset);
			IRunningBehaviorTreeData.AddFinishedQuests(builder, FinishedQuestsOffset);
			IRunningBehaviorTreeData.AddLevelPlays(builder, LevelPlaysOffset);
			IRunningBehaviorTreeData.AddQuest(builder, QuestOffset);
			IRunningBehaviorTreeData.AddNullMask(builder, NullMask);
			return IRunningBehaviorTreeData.EndIRunningBehaviorTreeData(builder);
		}

		// Token: 0x0601D548 RID: 120136 RVA: 0x0041E54C File Offset: 0x0041C74C
		public static void StartIRunningBehaviorTreeData(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0601D549 RID: 120137 RVA: 0x0041E556 File Offset: 0x0041C756
		public static void AddQuest(FlatBufferBuilder builder, Offset<IRunningQuests> questOffset)
		{
			builder.AddOffset(0, questOffset.Value, 0);
		}

		// Token: 0x0601D54A RID: 120138 RVA: 0x0041E566 File Offset: 0x0041C766
		public static void AddLevelPlays(FlatBufferBuilder builder, VectorOffset levelPlaysOffset)
		{
			builder.AddOffset(1, levelPlaysOffset.Value, 0);
		}

		// Token: 0x0601D54B RID: 120139 RVA: 0x0041E578 File Offset: 0x0041C778
		public static VectorOffset CreateLevelPlaysVector(FlatBufferBuilder builder, Offset<IRunningTree>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D54C RID: 120140 RVA: 0x0041E5B8 File Offset: 0x0041C7B8
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, Offset<IRunningTree>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRunningTree>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D54D RID: 120141 RVA: 0x0041E5D2 File Offset: 0x0041C7D2
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRunningTree>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRunningTree>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D54E RID: 120142 RVA: 0x0041E5F0 File Offset: 0x0041C7F0
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRunningTree>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D54F RID: 120143 RVA: 0x0041E609 File Offset: 0x0041C809
		public static void StartLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D550 RID: 120144 RVA: 0x0041E614 File Offset: 0x0041C814
		public static void AddFinishedQuests(FlatBufferBuilder builder, VectorOffset finishedQuestsOffset)
		{
			builder.AddOffset(2, finishedQuestsOffset.Value, 0);
		}

		// Token: 0x0601D551 RID: 120145 RVA: 0x0041E624 File Offset: 0x0041C824
		public static VectorOffset CreateFinishedQuestsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D552 RID: 120146 RVA: 0x0041E65B File Offset: 0x0041C85B
		public static VectorOffset CreateFinishedQuestsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D553 RID: 120147 RVA: 0x0041E675 File Offset: 0x0041C875
		public static VectorOffset CreateFinishedQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D554 RID: 120148 RVA: 0x0041E693 File Offset: 0x0041C893
		public static VectorOffset CreateFinishedQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D555 RID: 120149 RVA: 0x0041E6AC File Offset: 0x0041C8AC
		public static void StartFinishedQuestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D556 RID: 120150 RVA: 0x0041E6B7 File Offset: 0x0041C8B7
		public static void AddFinishedLevelPlays(FlatBufferBuilder builder, VectorOffset finishedLevelPlaysOffset)
		{
			builder.AddOffset(3, finishedLevelPlaysOffset.Value, 0);
		}

		// Token: 0x0601D557 RID: 120151 RVA: 0x0041E6C8 File Offset: 0x0041C8C8
		public static VectorOffset CreateFinishedLevelPlaysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D558 RID: 120152 RVA: 0x0041E6FF File Offset: 0x0041C8FF
		public static VectorOffset CreateFinishedLevelPlaysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D559 RID: 120153 RVA: 0x0041E719 File Offset: 0x0041C919
		public static VectorOffset CreateFinishedLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D55A RID: 120154 RVA: 0x0041E737 File Offset: 0x0041C937
		public static VectorOffset CreateFinishedLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D55B RID: 120155 RVA: 0x0041E750 File Offset: 0x0041C950
		public static void StartFinishedLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D55C RID: 120156 RVA: 0x0041E75B File Offset: 0x0041C95B
		public static void AddGlobalVars(FlatBufferBuilder builder, VectorOffset globalVarsOffset)
		{
			builder.AddOffset(4, globalVarsOffset.Value, 0);
		}

		// Token: 0x0601D55D RID: 120157 RVA: 0x0041E76C File Offset: 0x0041C96C
		public static VectorOffset CreateGlobalVarsVector(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D55E RID: 120158 RVA: 0x0041E7AC File Offset: 0x0041C9AC
		public static VectorOffset CreateGlobalVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D55F RID: 120159 RVA: 0x0041E7C6 File Offset: 0x0041C9C6
		public static VectorOffset CreateGlobalVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_String>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D560 RID: 120160 RVA: 0x0041E7E4 File Offset: 0x0041C9E4
		public static VectorOffset CreateGlobalVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_String>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D561 RID: 120161 RVA: 0x0041E7FD File Offset: 0x0041C9FD
		public static void StartGlobalVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D562 RID: 120162 RVA: 0x0041E808 File Offset: 0x0041CA08
		public static void AddTriggerBreakNodes(FlatBufferBuilder builder, VectorOffset triggerBreakNodesOffset)
		{
			builder.AddOffset(5, triggerBreakNodesOffset.Value, 0);
		}

		// Token: 0x0601D563 RID: 120163 RVA: 0x0041E818 File Offset: 0x0041CA18
		public static VectorOffset CreateTriggerBreakNodesVector(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeEventInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D564 RID: 120164 RVA: 0x0041E858 File Offset: 0x0041CA58
		public static VectorOffset CreateTriggerBreakNodesVectorBlock(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeEventInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGameCurrBreakNodeEventInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D565 RID: 120165 RVA: 0x0041E872 File Offset: 0x0041CA72
		public static VectorOffset CreateTriggerBreakNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGameCurrBreakNodeEventInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGameCurrBreakNodeEventInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D566 RID: 120166 RVA: 0x0041E890 File Offset: 0x0041CA90
		public static VectorOffset CreateTriggerBreakNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGameCurrBreakNodeEventInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D567 RID: 120167 RVA: 0x0041E8A9 File Offset: 0x0041CAA9
		public static void StartTriggerBreakNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D568 RID: 120168 RVA: 0x0041E8B4 File Offset: 0x0041CAB4
		public static void AddHideRangeInfos(FlatBufferBuilder builder, VectorOffset hideRangeInfosOffset)
		{
			builder.AddOffset(6, hideRangeInfosOffset.Value, 0);
		}

		// Token: 0x0601D569 RID: 120169 RVA: 0x0041E8C4 File Offset: 0x0041CAC4
		public static VectorOffset CreateHideRangeInfosVector(FlatBufferBuilder builder, Offset<IHideRangeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D56A RID: 120170 RVA: 0x0041E904 File Offset: 0x0041CB04
		public static VectorOffset CreateHideRangeInfosVectorBlock(FlatBufferBuilder builder, Offset<IHideRangeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHideRangeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D56B RID: 120171 RVA: 0x0041E91E File Offset: 0x0041CB1E
		public static VectorOffset CreateHideRangeInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHideRangeInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHideRangeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D56C RID: 120172 RVA: 0x0041E93C File Offset: 0x0041CB3C
		public static VectorOffset CreateHideRangeInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHideRangeInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D56D RID: 120173 RVA: 0x0041E955 File Offset: 0x0041CB55
		public static void StartHideRangeInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D56E RID: 120174 RVA: 0x0041E960 File Offset: 0x0041CB60
		public static void AddHideGroupInfo(FlatBufferBuilder builder, StringOffset hideGroupInfoOffset)
		{
			builder.AddOffset(7, hideGroupInfoOffset.Value, 0);
		}

		// Token: 0x0601D56F RID: 120175 RVA: 0x0041E970 File Offset: 0x0041CB70
		public static void AddFlowInfos(FlatBufferBuilder builder, VectorOffset flowInfosOffset)
		{
			builder.AddOffset(8, flowInfosOffset.Value, 0);
		}

		// Token: 0x0601D570 RID: 120176 RVA: 0x0041E980 File Offset: 0x0041CB80
		public static VectorOffset CreateFlowInfosVector(FlatBufferBuilder builder, Offset<Record_String_IRunningFlowInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D571 RID: 120177 RVA: 0x0041E9C0 File Offset: 0x0041CBC0
		public static VectorOffset CreateFlowInfosVectorBlock(FlatBufferBuilder builder, Offset<Record_String_IRunningFlowInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_IRunningFlowInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D572 RID: 120178 RVA: 0x0041E9DA File Offset: 0x0041CBDA
		public static VectorOffset CreateFlowInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_IRunningFlowInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_IRunningFlowInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D573 RID: 120179 RVA: 0x0041E9F8 File Offset: 0x0041CBF8
		public static VectorOffset CreateFlowInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_IRunningFlowInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D574 RID: 120180 RVA: 0x0041EA11 File Offset: 0x0041CC11
		public static void StartFlowInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D575 RID: 120181 RVA: 0x0041EA1C File Offset: 0x0041CC1C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0601D576 RID: 120182 RVA: 0x0041EA28 File Offset: 0x0041CC28
		public static Offset<IRunningBehaviorTreeData> EndIRunningBehaviorTreeData(FlatBufferBuilder builder)
		{
			return new Offset<IRunningBehaviorTreeData>(builder.EndTable());
		}

		// Token: 0x0601D577 RID: 120183 RVA: 0x0041EA38 File Offset: 0x0041CC38
		public IRunningBehaviorTreeDataT UnPack()
		{
			IRunningBehaviorTreeDataT runningBehaviorTreeDataT = new IRunningBehaviorTreeDataT();
			this.UnPackTo(runningBehaviorTreeDataT);
			return runningBehaviorTreeDataT;
		}

		// Token: 0x0601D578 RID: 120184 RVA: 0x0041EA54 File Offset: 0x0041CC54
		public void UnPackTo(IRunningBehaviorTreeDataT _o)
		{
			_o.Quest = ((this.Quest != null) ? this.Quest.Value.UnPack() : null);
			_o.LevelPlays = new List<IRunningTreeT>();
			for (int i = 0; i < this.LevelPlaysLength; i++)
			{
				_o.LevelPlays.Add((this.LevelPlays(i) != null) ? this.LevelPlays(i).Value.UnPack() : null);
			}
			_o.FinishedQuests = new List<int>();
			for (int j = 0; j < this.FinishedQuestsLength; j++)
			{
				_o.FinishedQuests.Add(this.FinishedQuests(j));
			}
			_o.FinishedLevelPlays = new List<int>();
			for (int k = 0; k < this.FinishedLevelPlaysLength; k++)
			{
				_o.FinishedLevelPlays.Add(this.FinishedLevelPlays(k));
			}
			_o.GlobalVars = new List<Record_String_StringT>();
			for (int l = 0; l < this.GlobalVarsLength; l++)
			{
				_o.GlobalVars.Add((this.GlobalVars(l) != null) ? this.GlobalVars(l).Value.UnPack() : null);
			}
			_o.TriggerBreakNodes = new List<IGameCurrBreakNodeEventInfoT>();
			for (int m = 0; m < this.TriggerBreakNodesLength; m++)
			{
				_o.TriggerBreakNodes.Add((this.TriggerBreakNodes(m) != null) ? this.TriggerBreakNodes(m).Value.UnPack() : null);
			}
			_o.HideRangeInfos = new List<IHideRangeInfoT>();
			for (int n = 0; n < this.HideRangeInfosLength; n++)
			{
				_o.HideRangeInfos.Add((this.HideRangeInfos(n) != null) ? this.HideRangeInfos(n).Value.UnPack() : null);
			}
			_o.HideGroupInfo = this.HideGroupInfo;
			_o.FlowInfos = new List<Record_String_IRunningFlowInfoT>();
			for (int num = 0; num < this.FlowInfosLength; num++)
			{
				_o.FlowInfos.Add((this.FlowInfos(num) != null) ? this.FlowInfos(num).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D579 RID: 120185 RVA: 0x0041ECD0 File Offset: 0x0041CED0
		public static Offset<IRunningBehaviorTreeData> Pack(FlatBufferBuilder builder, IRunningBehaviorTreeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunningBehaviorTreeData>);
			}
			Offset<IRunningQuests> questOffset = (_o.Quest == null) ? default(Offset<IRunningQuests>) : IRunningQuests.Pack(builder, _o.Quest);
			VectorOffset levelPlaysOffset = default(VectorOffset);
			if (_o.LevelPlays != null)
			{
				Offset<IRunningTree>[] array = new Offset<IRunningTree>[_o.LevelPlays.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRunningTree.Pack(builder, _o.LevelPlays[i]);
				}
				levelPlaysOffset = IRunningBehaviorTreeData.CreateLevelPlaysVector(builder, array);
			}
			VectorOffset finishedQuestsOffset = default(VectorOffset);
			if (_o.FinishedQuests != null)
			{
				int[] data = _o.FinishedQuests.ToArray();
				finishedQuestsOffset = IRunningBehaviorTreeData.CreateFinishedQuestsVector(builder, data);
			}
			VectorOffset finishedLevelPlaysOffset = default(VectorOffset);
			if (_o.FinishedLevelPlays != null)
			{
				int[] data2 = _o.FinishedLevelPlays.ToArray();
				finishedLevelPlaysOffset = IRunningBehaviorTreeData.CreateFinishedLevelPlaysVector(builder, data2);
			}
			VectorOffset globalVarsOffset = default(VectorOffset);
			if (_o.GlobalVars != null)
			{
				Offset<Record_String_String>[] array2 = new Offset<Record_String_String>[_o.GlobalVars.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = Record_String_String.Pack(builder, _o.GlobalVars[j]);
				}
				globalVarsOffset = IRunningBehaviorTreeData.CreateGlobalVarsVector(builder, array2);
			}
			VectorOffset triggerBreakNodesOffset = default(VectorOffset);
			if (_o.TriggerBreakNodes != null)
			{
				Offset<IGameCurrBreakNodeEventInfo>[] array3 = new Offset<IGameCurrBreakNodeEventInfo>[_o.TriggerBreakNodes.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IGameCurrBreakNodeEventInfo.Pack(builder, _o.TriggerBreakNodes[k]);
				}
				triggerBreakNodesOffset = IRunningBehaviorTreeData.CreateTriggerBreakNodesVector(builder, array3);
			}
			VectorOffset hideRangeInfosOffset = default(VectorOffset);
			if (_o.HideRangeInfos != null)
			{
				Offset<IHideRangeInfo>[] array4 = new Offset<IHideRangeInfo>[_o.HideRangeInfos.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IHideRangeInfo.Pack(builder, _o.HideRangeInfos[l]);
				}
				hideRangeInfosOffset = IRunningBehaviorTreeData.CreateHideRangeInfosVector(builder, array4);
			}
			StringOffset hideGroupInfoOffset = (_o.HideGroupInfo == null) ? default(StringOffset) : builder.CreateString(_o.HideGroupInfo);
			VectorOffset flowInfosOffset = default(VectorOffset);
			if (_o.FlowInfos != null)
			{
				Offset<Record_String_IRunningFlowInfo>[] array5 = new Offset<Record_String_IRunningFlowInfo>[_o.FlowInfos.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = Record_String_IRunningFlowInfo.Pack(builder, _o.FlowInfos[m]);
				}
				flowInfosOffset = IRunningBehaviorTreeData.CreateFlowInfosVector(builder, array5);
			}
			return IRunningBehaviorTreeData.CreateIRunningBehaviorTreeData(builder, questOffset, levelPlaysOffset, finishedQuestsOffset, finishedLevelPlaysOffset, globalVarsOffset, triggerBreakNodesOffset, hideRangeInfosOffset, hideGroupInfoOffset, flowInfosOffset, _o.NullMask);
		}

		// Token: 0x0400D3DD RID: 54237
		private Table __p;
	}
}
