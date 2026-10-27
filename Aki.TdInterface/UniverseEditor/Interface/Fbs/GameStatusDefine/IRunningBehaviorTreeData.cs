using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046FD RID: 18173
	public struct IRunningBehaviorTreeData : IFlatbufferObject
	{
		// Token: 0x170081F7 RID: 33271
		// (get) Token: 0x0601BD55 RID: 114005 RVA: 0x003F1D04 File Offset: 0x003EFF04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BD56 RID: 114006 RVA: 0x003F1D11 File Offset: 0x003EFF11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BD57 RID: 114007 RVA: 0x003F1D18 File Offset: 0x003EFF18
		public static IRunningBehaviorTreeData GetRootAsIRunningBehaviorTreeData(ByteBuffer _bb)
		{
			return IRunningBehaviorTreeData.GetRootAsIRunningBehaviorTreeData(_bb, default(IRunningBehaviorTreeData));
		}

		// Token: 0x0601BD58 RID: 114008 RVA: 0x003F1D34 File Offset: 0x003EFF34
		public static IRunningBehaviorTreeData GetRootAsIRunningBehaviorTreeData(ByteBuffer _bb, IRunningBehaviorTreeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BD59 RID: 114009 RVA: 0x003F1D51 File Offset: 0x003EFF51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BD5A RID: 114010 RVA: 0x003F1D60 File Offset: 0x003EFF60
		public IRunningBehaviorTreeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081F8 RID: 33272
		// (get) Token: 0x0601BD5B RID: 114011 RVA: 0x003F1D70 File Offset: 0x003EFF70
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

		// Token: 0x0601BD5C RID: 114012 RVA: 0x003F1DD0 File Offset: 0x003EFFD0
		public IRunningTree? LevelPlays(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRunningTree?(default(IRunningTree).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081F9 RID: 33273
		// (get) Token: 0x0601BD5D RID: 114013 RVA: 0x003F1E30 File Offset: 0x003F0030
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

		// Token: 0x0601BD5E RID: 114014 RVA: 0x003F1E5C File Offset: 0x003F005C
		public int FinishedQuests(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170081FA RID: 33274
		// (get) Token: 0x0601BD5F RID: 114015 RVA: 0x003F1E9C File Offset: 0x003F009C
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

		// Token: 0x0601BD60 RID: 114016 RVA: 0x003F1EC7 File Offset: 0x003F00C7
		public Span<int> GetFinishedQuestsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601BD61 RID: 114017 RVA: 0x003F1ED6 File Offset: 0x003F00D6
		public int[] GetFinishedQuestsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601BD62 RID: 114018 RVA: 0x003F1EE4 File Offset: 0x003F00E4
		public int FinishedLevelPlays(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170081FB RID: 33275
		// (get) Token: 0x0601BD63 RID: 114019 RVA: 0x003F1F24 File Offset: 0x003F0124
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

		// Token: 0x0601BD64 RID: 114020 RVA: 0x003F1F50 File Offset: 0x003F0150
		public Span<int> GetFinishedLevelPlaysBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601BD65 RID: 114021 RVA: 0x003F1F60 File Offset: 0x003F0160
		public int[] GetFinishedLevelPlaysArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601BD66 RID: 114022 RVA: 0x003F1F70 File Offset: 0x003F0170
		public Record_String_String? GlobalVars(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_String?(default(Record_String_String).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081FC RID: 33276
		// (get) Token: 0x0601BD67 RID: 114023 RVA: 0x003F1FD4 File Offset: 0x003F01D4
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

		// Token: 0x0601BD68 RID: 114024 RVA: 0x003F2000 File Offset: 0x003F0200
		public IGameCurrBreakNodeEventInfo? TriggerBreakNodes(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IGameCurrBreakNodeEventInfo?(default(IGameCurrBreakNodeEventInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081FD RID: 33277
		// (get) Token: 0x0601BD69 RID: 114025 RVA: 0x003F2064 File Offset: 0x003F0264
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

		// Token: 0x0601BD6A RID: 114026 RVA: 0x003F2090 File Offset: 0x003F0290
		public IHideRangeInfo? HideRangeInfos(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IHideRangeInfo?(default(IHideRangeInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081FE RID: 33278
		// (get) Token: 0x0601BD6B RID: 114027 RVA: 0x003F20F4 File Offset: 0x003F02F4
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

		// Token: 0x170081FF RID: 33279
		// (get) Token: 0x0601BD6C RID: 114028 RVA: 0x003F2120 File Offset: 0x003F0320
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

		// Token: 0x0601BD6D RID: 114029 RVA: 0x003F2158 File Offset: 0x003F0358
		public Span<byte> GetHideGroupInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601BD6E RID: 114030 RVA: 0x003F2168 File Offset: 0x003F0368
		public byte[] GetHideGroupInfoArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x0601BD6F RID: 114031 RVA: 0x003F2178 File Offset: 0x003F0378
		public Record_String_IRunningFlowInfo? FlowInfos(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_IRunningFlowInfo?(default(Record_String_IRunningFlowInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008200 RID: 33280
		// (get) Token: 0x0601BD70 RID: 114032 RVA: 0x003F21DC File Offset: 0x003F03DC
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

		// Token: 0x17008201 RID: 33281
		// (get) Token: 0x0601BD71 RID: 114033 RVA: 0x003F2208 File Offset: 0x003F0408
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

		// Token: 0x0601BD72 RID: 114034 RVA: 0x003F2248 File Offset: 0x003F0448
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

		// Token: 0x0601BD73 RID: 114035 RVA: 0x003F22B0 File Offset: 0x003F04B0
		public static void StartIRunningBehaviorTreeData(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0601BD74 RID: 114036 RVA: 0x003F22BA File Offset: 0x003F04BA
		public static void AddQuest(FlatBufferBuilder builder, Offset<IRunningQuests> questOffset)
		{
			builder.AddOffset(0, questOffset.Value, 0);
		}

		// Token: 0x0601BD75 RID: 114037 RVA: 0x003F22CA File Offset: 0x003F04CA
		public static void AddLevelPlays(FlatBufferBuilder builder, VectorOffset levelPlaysOffset)
		{
			builder.AddOffset(1, levelPlaysOffset.Value, 0);
		}

		// Token: 0x0601BD76 RID: 114038 RVA: 0x003F22DC File Offset: 0x003F04DC
		public static VectorOffset CreateLevelPlaysVector(FlatBufferBuilder builder, Offset<IRunningTree>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD77 RID: 114039 RVA: 0x003F231C File Offset: 0x003F051C
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, Offset<IRunningTree>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRunningTree>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD78 RID: 114040 RVA: 0x003F2336 File Offset: 0x003F0536
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRunningTree>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRunningTree>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD79 RID: 114041 RVA: 0x003F2354 File Offset: 0x003F0554
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRunningTree>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD7A RID: 114042 RVA: 0x003F236D File Offset: 0x003F056D
		public static void StartLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD7B RID: 114043 RVA: 0x003F2378 File Offset: 0x003F0578
		public static void AddFinishedQuests(FlatBufferBuilder builder, VectorOffset finishedQuestsOffset)
		{
			builder.AddOffset(2, finishedQuestsOffset.Value, 0);
		}

		// Token: 0x0601BD7C RID: 114044 RVA: 0x003F2388 File Offset: 0x003F0588
		public static VectorOffset CreateFinishedQuestsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD7D RID: 114045 RVA: 0x003F23BF File Offset: 0x003F05BF
		public static VectorOffset CreateFinishedQuestsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD7E RID: 114046 RVA: 0x003F23D9 File Offset: 0x003F05D9
		public static VectorOffset CreateFinishedQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD7F RID: 114047 RVA: 0x003F23F7 File Offset: 0x003F05F7
		public static VectorOffset CreateFinishedQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD80 RID: 114048 RVA: 0x003F2410 File Offset: 0x003F0610
		public static void StartFinishedQuestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD81 RID: 114049 RVA: 0x003F241B File Offset: 0x003F061B
		public static void AddFinishedLevelPlays(FlatBufferBuilder builder, VectorOffset finishedLevelPlaysOffset)
		{
			builder.AddOffset(3, finishedLevelPlaysOffset.Value, 0);
		}

		// Token: 0x0601BD82 RID: 114050 RVA: 0x003F242C File Offset: 0x003F062C
		public static VectorOffset CreateFinishedLevelPlaysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD83 RID: 114051 RVA: 0x003F2463 File Offset: 0x003F0663
		public static VectorOffset CreateFinishedLevelPlaysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD84 RID: 114052 RVA: 0x003F247D File Offset: 0x003F067D
		public static VectorOffset CreateFinishedLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD85 RID: 114053 RVA: 0x003F249B File Offset: 0x003F069B
		public static VectorOffset CreateFinishedLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD86 RID: 114054 RVA: 0x003F24B4 File Offset: 0x003F06B4
		public static void StartFinishedLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD87 RID: 114055 RVA: 0x003F24BF File Offset: 0x003F06BF
		public static void AddGlobalVars(FlatBufferBuilder builder, VectorOffset globalVarsOffset)
		{
			builder.AddOffset(4, globalVarsOffset.Value, 0);
		}

		// Token: 0x0601BD88 RID: 114056 RVA: 0x003F24D0 File Offset: 0x003F06D0
		public static VectorOffset CreateGlobalVarsVector(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD89 RID: 114057 RVA: 0x003F2510 File Offset: 0x003F0710
		public static VectorOffset CreateGlobalVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD8A RID: 114058 RVA: 0x003F252A File Offset: 0x003F072A
		public static VectorOffset CreateGlobalVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_String>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD8B RID: 114059 RVA: 0x003F2548 File Offset: 0x003F0748
		public static VectorOffset CreateGlobalVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_String>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD8C RID: 114060 RVA: 0x003F2561 File Offset: 0x003F0761
		public static void StartGlobalVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD8D RID: 114061 RVA: 0x003F256C File Offset: 0x003F076C
		public static void AddTriggerBreakNodes(FlatBufferBuilder builder, VectorOffset triggerBreakNodesOffset)
		{
			builder.AddOffset(5, triggerBreakNodesOffset.Value, 0);
		}

		// Token: 0x0601BD8E RID: 114062 RVA: 0x003F257C File Offset: 0x003F077C
		public static VectorOffset CreateTriggerBreakNodesVector(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeEventInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD8F RID: 114063 RVA: 0x003F25BC File Offset: 0x003F07BC
		public static VectorOffset CreateTriggerBreakNodesVectorBlock(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeEventInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGameCurrBreakNodeEventInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD90 RID: 114064 RVA: 0x003F25D6 File Offset: 0x003F07D6
		public static VectorOffset CreateTriggerBreakNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGameCurrBreakNodeEventInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGameCurrBreakNodeEventInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD91 RID: 114065 RVA: 0x003F25F4 File Offset: 0x003F07F4
		public static VectorOffset CreateTriggerBreakNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGameCurrBreakNodeEventInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD92 RID: 114066 RVA: 0x003F260D File Offset: 0x003F080D
		public static void StartTriggerBreakNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD93 RID: 114067 RVA: 0x003F2618 File Offset: 0x003F0818
		public static void AddHideRangeInfos(FlatBufferBuilder builder, VectorOffset hideRangeInfosOffset)
		{
			builder.AddOffset(6, hideRangeInfosOffset.Value, 0);
		}

		// Token: 0x0601BD94 RID: 114068 RVA: 0x003F2628 File Offset: 0x003F0828
		public static VectorOffset CreateHideRangeInfosVector(FlatBufferBuilder builder, Offset<IHideRangeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD95 RID: 114069 RVA: 0x003F2668 File Offset: 0x003F0868
		public static VectorOffset CreateHideRangeInfosVectorBlock(FlatBufferBuilder builder, Offset<IHideRangeInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHideRangeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD96 RID: 114070 RVA: 0x003F2682 File Offset: 0x003F0882
		public static VectorOffset CreateHideRangeInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHideRangeInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHideRangeInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD97 RID: 114071 RVA: 0x003F26A0 File Offset: 0x003F08A0
		public static VectorOffset CreateHideRangeInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHideRangeInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD98 RID: 114072 RVA: 0x003F26B9 File Offset: 0x003F08B9
		public static void StartHideRangeInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD99 RID: 114073 RVA: 0x003F26C4 File Offset: 0x003F08C4
		public static void AddHideGroupInfo(FlatBufferBuilder builder, StringOffset hideGroupInfoOffset)
		{
			builder.AddOffset(7, hideGroupInfoOffset.Value, 0);
		}

		// Token: 0x0601BD9A RID: 114074 RVA: 0x003F26D4 File Offset: 0x003F08D4
		public static void AddFlowInfos(FlatBufferBuilder builder, VectorOffset flowInfosOffset)
		{
			builder.AddOffset(8, flowInfosOffset.Value, 0);
		}

		// Token: 0x0601BD9B RID: 114075 RVA: 0x003F26E4 File Offset: 0x003F08E4
		public static VectorOffset CreateFlowInfosVector(FlatBufferBuilder builder, Offset<Record_String_IRunningFlowInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD9C RID: 114076 RVA: 0x003F2724 File Offset: 0x003F0924
		public static VectorOffset CreateFlowInfosVectorBlock(FlatBufferBuilder builder, Offset<Record_String_IRunningFlowInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_IRunningFlowInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD9D RID: 114077 RVA: 0x003F273E File Offset: 0x003F093E
		public static VectorOffset CreateFlowInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_IRunningFlowInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_IRunningFlowInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD9E RID: 114078 RVA: 0x003F275C File Offset: 0x003F095C
		public static VectorOffset CreateFlowInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_IRunningFlowInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD9F RID: 114079 RVA: 0x003F2775 File Offset: 0x003F0975
		public static void StartFlowInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BDA0 RID: 114080 RVA: 0x003F2780 File Offset: 0x003F0980
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0601BDA1 RID: 114081 RVA: 0x003F278C File Offset: 0x003F098C
		public static Offset<IRunningBehaviorTreeData> EndIRunningBehaviorTreeData(FlatBufferBuilder builder)
		{
			return new Offset<IRunningBehaviorTreeData>(builder.EndTable());
		}

		// Token: 0x0601BDA2 RID: 114082 RVA: 0x003F279C File Offset: 0x003F099C
		public IRunningBehaviorTreeDataT UnPack()
		{
			IRunningBehaviorTreeDataT runningBehaviorTreeDataT = new IRunningBehaviorTreeDataT();
			this.UnPackTo(runningBehaviorTreeDataT);
			return runningBehaviorTreeDataT;
		}

		// Token: 0x0601BDA3 RID: 114083 RVA: 0x003F27B8 File Offset: 0x003F09B8
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

		// Token: 0x0601BDA4 RID: 114084 RVA: 0x003F2A34 File Offset: 0x003F0C34
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

		// Token: 0x0400C9AE RID: 51630
		private Table __p;
	}
}
