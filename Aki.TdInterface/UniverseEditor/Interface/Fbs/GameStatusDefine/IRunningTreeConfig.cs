using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Entity;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B77 RID: 19319
	public struct IRunningTreeConfig : IFlatbufferObject
	{
		// Token: 0x17008884 RID: 34948
		// (get) Token: 0x0601D658 RID: 120408 RVA: 0x00420B7A File Offset: 0x0041ED7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D659 RID: 120409 RVA: 0x00420B87 File Offset: 0x0041ED87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D65A RID: 120410 RVA: 0x00420B90 File Offset: 0x0041ED90
		public static IRunningTreeConfig GetRootAsIRunningTreeConfig(ByteBuffer _bb)
		{
			return IRunningTreeConfig.GetRootAsIRunningTreeConfig(_bb, default(IRunningTreeConfig));
		}

		// Token: 0x0601D65B RID: 120411 RVA: 0x00420BAC File Offset: 0x0041EDAC
		public static IRunningTreeConfig GetRootAsIRunningTreeConfig(ByteBuffer _bb, IRunningTreeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D65C RID: 120412 RVA: 0x00420BC9 File Offset: 0x0041EDC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D65D RID: 120413 RVA: 0x00420BD8 File Offset: 0x0041EDD8
		public IRunningTreeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008885 RID: 34949
		// (get) Token: 0x0601D65E RID: 120414 RVA: 0x00420BE8 File Offset: 0x0041EDE8
		public int TreeId
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

		// Token: 0x0601D65F RID: 120415 RVA: 0x00420C24 File Offset: 0x0041EE24
		public IRunningNodeStatus? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRunningNodeStatus?(default(IRunningNodeStatus).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008886 RID: 34950
		// (get) Token: 0x0601D660 RID: 120416 RVA: 0x00420C84 File Offset: 0x0041EE84
		public int NodesLength
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

		// Token: 0x0601D661 RID: 120417 RVA: 0x00420CB0 File Offset: 0x0041EEB0
		public Record_String_String? Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_String?(default(Record_String_String).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008887 RID: 34951
		// (get) Token: 0x0601D662 RID: 120418 RVA: 0x00420D10 File Offset: 0x0041EF10
		public int VarsLength
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

		// Token: 0x0601D663 RID: 120419 RVA: 0x00420D3C File Offset: 0x0041EF3C
		public Record_String_String? SystemVars(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_String?(default(Record_String_String).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008888 RID: 34952
		// (get) Token: 0x0601D664 RID: 120420 RVA: 0x00420DA0 File Offset: 0x0041EFA0
		public int SystemVarsLength
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

		// Token: 0x17008889 RID: 34953
		// (get) Token: 0x0601D665 RID: 120421 RVA: 0x00420DCC File Offset: 0x0041EFCC
		public IGameCurrBreakNodeInfo? BreakNodeInfo
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IGameCurrBreakNodeInfo?(default(IGameCurrBreakNodeInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700888A RID: 34954
		// (get) Token: 0x0601D666 RID: 120422 RVA: 0x00420E2C File Offset: 0x0041F02C
		public bool OnSave
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D667 RID: 120423 RVA: 0x00420E6C File Offset: 0x0041F06C
		public int Saves(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700888B RID: 34955
		// (get) Token: 0x0601D668 RID: 120424 RVA: 0x00420EAC File Offset: 0x0041F0AC
		public int SavesLength
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

		// Token: 0x0601D669 RID: 120425 RVA: 0x00420ED8 File Offset: 0x0041F0D8
		public Span<int> GetSavesBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0601D66A RID: 120426 RVA: 0x00420EE8 File Offset: 0x0041F0E8
		public int[] GetSavesArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x0601D66B RID: 120427 RVA: 0x00420EF8 File Offset: 0x0041F0F8
		public string OptionGuids(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700888C RID: 34956
		// (get) Token: 0x0601D66C RID: 120428 RVA: 0x00420F34 File Offset: 0x0041F134
		public int OptionGuidsLength
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

		// Token: 0x0601D66D RID: 120429 RVA: 0x00420F60 File Offset: 0x0041F160
		public Record_Int_EActionState? AllActions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_EActionState?(default(Record_Int_EActionState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700888D RID: 34957
		// (get) Token: 0x0601D66E RID: 120430 RVA: 0x00420FC4 File Offset: 0x0041F1C4
		public int AllActionsLength
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

		// Token: 0x1700888E RID: 34958
		// (get) Token: 0x0601D66F RID: 120431 RVA: 0x00420FF0 File Offset: 0x0041F1F0
		public IInstEntityData? ResetEntityData
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IInstEntityData?(default(IInstEntityData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700888F RID: 34959
		// (get) Token: 0x0601D670 RID: 120432 RVA: 0x00421050 File Offset: 0x0041F250
		public IInstEntityData? ResurrectionEntityData
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IInstEntityData?(default(IInstEntityData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008890 RID: 34960
		// (get) Token: 0x0601D671 RID: 120433 RVA: 0x004210B0 File Offset: 0x0041F2B0
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

		// Token: 0x0601D672 RID: 120434 RVA: 0x004210F0 File Offset: 0x0041F2F0
		public static Offset<IRunningTreeConfig> CreateIRunningTreeConfig(FlatBufferBuilder builder, int TreeId = 0, VectorOffset NodesOffset = default(VectorOffset), VectorOffset VarsOffset = default(VectorOffset), VectorOffset SystemVarsOffset = default(VectorOffset), Offset<IGameCurrBreakNodeInfo> BreakNodeInfoOffset = default(Offset<IGameCurrBreakNodeInfo>), bool OnSave = false, VectorOffset SavesOffset = default(VectorOffset), VectorOffset OptionGuidsOffset = default(VectorOffset), VectorOffset AllActionsOffset = default(VectorOffset), Offset<IInstEntityData> ResetEntityDataOffset = default(Offset<IInstEntityData>), Offset<IInstEntityData> ResurrectionEntityDataOffset = default(Offset<IInstEntityData>), byte NullMask = 0)
		{
			builder.StartTable(12);
			IRunningTreeConfig.AddResurrectionEntityData(builder, ResurrectionEntityDataOffset);
			IRunningTreeConfig.AddResetEntityData(builder, ResetEntityDataOffset);
			IRunningTreeConfig.AddAllActions(builder, AllActionsOffset);
			IRunningTreeConfig.AddOptionGuids(builder, OptionGuidsOffset);
			IRunningTreeConfig.AddSaves(builder, SavesOffset);
			IRunningTreeConfig.AddBreakNodeInfo(builder, BreakNodeInfoOffset);
			IRunningTreeConfig.AddSystemVars(builder, SystemVarsOffset);
			IRunningTreeConfig.AddVars(builder, VarsOffset);
			IRunningTreeConfig.AddNodes(builder, NodesOffset);
			IRunningTreeConfig.AddTreeId(builder, TreeId);
			IRunningTreeConfig.AddNullMask(builder, NullMask);
			IRunningTreeConfig.AddOnSave(builder, OnSave);
			return IRunningTreeConfig.EndIRunningTreeConfig(builder);
		}

		// Token: 0x0601D673 RID: 120435 RVA: 0x00421168 File Offset: 0x0041F368
		public static void StartIRunningTreeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x0601D674 RID: 120436 RVA: 0x00421172 File Offset: 0x0041F372
		public static void AddTreeId(FlatBufferBuilder builder, int treeId)
		{
			builder.AddInt(0, treeId, 0);
		}

		// Token: 0x0601D675 RID: 120437 RVA: 0x0042117D File Offset: 0x0041F37D
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x0601D676 RID: 120438 RVA: 0x00421190 File Offset: 0x0041F390
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IRunningNodeStatus>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D677 RID: 120439 RVA: 0x004211D0 File Offset: 0x0041F3D0
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IRunningNodeStatus>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRunningNodeStatus>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D678 RID: 120440 RVA: 0x004211EA File Offset: 0x0041F3EA
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRunningNodeStatus>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRunningNodeStatus>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D679 RID: 120441 RVA: 0x00421208 File Offset: 0x0041F408
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRunningNodeStatus>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D67A RID: 120442 RVA: 0x00421221 File Offset: 0x0041F421
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D67B RID: 120443 RVA: 0x0042122C File Offset: 0x0041F42C
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601D67C RID: 120444 RVA: 0x0042123C File Offset: 0x0041F43C
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D67D RID: 120445 RVA: 0x0042127C File Offset: 0x0041F47C
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D67E RID: 120446 RVA: 0x00421296 File Offset: 0x0041F496
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_String>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D67F RID: 120447 RVA: 0x004212B4 File Offset: 0x0041F4B4
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_String>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D680 RID: 120448 RVA: 0x004212CD File Offset: 0x0041F4CD
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D681 RID: 120449 RVA: 0x004212D8 File Offset: 0x0041F4D8
		public static void AddSystemVars(FlatBufferBuilder builder, VectorOffset systemVarsOffset)
		{
			builder.AddOffset(3, systemVarsOffset.Value, 0);
		}

		// Token: 0x0601D682 RID: 120450 RVA: 0x004212E8 File Offset: 0x0041F4E8
		public static VectorOffset CreateSystemVarsVector(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D683 RID: 120451 RVA: 0x00421328 File Offset: 0x0041F528
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D684 RID: 120452 RVA: 0x00421342 File Offset: 0x0041F542
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_String>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D685 RID: 120453 RVA: 0x00421360 File Offset: 0x0041F560
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_String>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D686 RID: 120454 RVA: 0x00421379 File Offset: 0x0041F579
		public static void StartSystemVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D687 RID: 120455 RVA: 0x00421384 File Offset: 0x0041F584
		public static void AddBreakNodeInfo(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeInfo> breakNodeInfoOffset)
		{
			builder.AddOffset(4, breakNodeInfoOffset.Value, 0);
		}

		// Token: 0x0601D688 RID: 120456 RVA: 0x00421394 File Offset: 0x0041F594
		public static void AddOnSave(FlatBufferBuilder builder, bool onSave)
		{
			builder.AddBool(5, onSave, false);
		}

		// Token: 0x0601D689 RID: 120457 RVA: 0x0042139F File Offset: 0x0041F59F
		public static void AddSaves(FlatBufferBuilder builder, VectorOffset savesOffset)
		{
			builder.AddOffset(6, savesOffset.Value, 0);
		}

		// Token: 0x0601D68A RID: 120458 RVA: 0x004213B0 File Offset: 0x0041F5B0
		public static VectorOffset CreateSavesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D68B RID: 120459 RVA: 0x004213E7 File Offset: 0x0041F5E7
		public static VectorOffset CreateSavesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D68C RID: 120460 RVA: 0x00421401 File Offset: 0x0041F601
		public static VectorOffset CreateSavesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D68D RID: 120461 RVA: 0x0042141F File Offset: 0x0041F61F
		public static VectorOffset CreateSavesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D68E RID: 120462 RVA: 0x00421438 File Offset: 0x0041F638
		public static void StartSavesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D68F RID: 120463 RVA: 0x00421443 File Offset: 0x0041F643
		public static void AddOptionGuids(FlatBufferBuilder builder, VectorOffset optionGuidsOffset)
		{
			builder.AddOffset(7, optionGuidsOffset.Value, 0);
		}

		// Token: 0x0601D690 RID: 120464 RVA: 0x00421454 File Offset: 0x0041F654
		public static VectorOffset CreateOptionGuidsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D691 RID: 120465 RVA: 0x00421494 File Offset: 0x0041F694
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D692 RID: 120466 RVA: 0x004214AE File Offset: 0x0041F6AE
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D693 RID: 120467 RVA: 0x004214CC File Offset: 0x0041F6CC
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D694 RID: 120468 RVA: 0x004214E5 File Offset: 0x0041F6E5
		public static void StartOptionGuidsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D695 RID: 120469 RVA: 0x004214F0 File Offset: 0x0041F6F0
		public static void AddAllActions(FlatBufferBuilder builder, VectorOffset allActionsOffset)
		{
			builder.AddOffset(8, allActionsOffset.Value, 0);
		}

		// Token: 0x0601D696 RID: 120470 RVA: 0x00421500 File Offset: 0x0041F700
		public static VectorOffset CreateAllActionsVector(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D697 RID: 120471 RVA: 0x00421540 File Offset: 0x0041F740
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D698 RID: 120472 RVA: 0x0042155A File Offset: 0x0041F75A
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_EActionState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D699 RID: 120473 RVA: 0x00421578 File Offset: 0x0041F778
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_EActionState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D69A RID: 120474 RVA: 0x00421591 File Offset: 0x0041F791
		public static void StartAllActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D69B RID: 120475 RVA: 0x0042159C File Offset: 0x0041F79C
		public static void AddResetEntityData(FlatBufferBuilder builder, Offset<IInstEntityData> resetEntityDataOffset)
		{
			builder.AddOffset(9, resetEntityDataOffset.Value, 0);
		}

		// Token: 0x0601D69C RID: 120476 RVA: 0x004215AD File Offset: 0x0041F7AD
		public static void AddResurrectionEntityData(FlatBufferBuilder builder, Offset<IInstEntityData> resurrectionEntityDataOffset)
		{
			builder.AddOffset(10, resurrectionEntityDataOffset.Value, 0);
		}

		// Token: 0x0601D69D RID: 120477 RVA: 0x004215BE File Offset: 0x0041F7BE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x0601D69E RID: 120478 RVA: 0x004215CA File Offset: 0x0041F7CA
		public static Offset<IRunningTreeConfig> EndIRunningTreeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRunningTreeConfig>(builder.EndTable());
		}

		// Token: 0x0601D69F RID: 120479 RVA: 0x004215D8 File Offset: 0x0041F7D8
		public IRunningTreeConfigT UnPack()
		{
			IRunningTreeConfigT runningTreeConfigT = new IRunningTreeConfigT();
			this.UnPackTo(runningTreeConfigT);
			return runningTreeConfigT;
		}

		// Token: 0x0601D6A0 RID: 120480 RVA: 0x004215F4 File Offset: 0x0041F7F4
		public void UnPackTo(IRunningTreeConfigT _o)
		{
			_o.TreeId = this.TreeId;
			_o.Nodes = new List<IRunningNodeStatusT>();
			for (int i = 0; i < this.NodesLength; i++)
			{
				_o.Nodes.Add((this.Nodes(i) != null) ? this.Nodes(i).Value.UnPack() : null);
			}
			_o.Vars = new List<Record_String_StringT>();
			for (int j = 0; j < this.VarsLength; j++)
			{
				_o.Vars.Add((this.Vars(j) != null) ? this.Vars(j).Value.UnPack() : null);
			}
			_o.SystemVars = new List<Record_String_StringT>();
			for (int k = 0; k < this.SystemVarsLength; k++)
			{
				_o.SystemVars.Add((this.SystemVars(k) != null) ? this.SystemVars(k).Value.UnPack() : null);
			}
			_o.BreakNodeInfo = ((this.BreakNodeInfo != null) ? this.BreakNodeInfo.Value.UnPack() : null);
			_o.OnSave = this.OnSave;
			_o.Saves = new List<int>();
			for (int l = 0; l < this.SavesLength; l++)
			{
				_o.Saves.Add(this.Saves(l));
			}
			_o.OptionGuids = new List<string>();
			for (int m = 0; m < this.OptionGuidsLength; m++)
			{
				_o.OptionGuids.Add(this.OptionGuids(m));
			}
			_o.AllActions = new List<Record_Int_EActionStateT>();
			for (int n = 0; n < this.AllActionsLength; n++)
			{
				_o.AllActions.Add((this.AllActions(n) != null) ? this.AllActions(n).Value.UnPack() : null);
			}
			_o.ResetEntityData = ((this.ResetEntityData != null) ? this.ResetEntityData.Value.UnPack() : null);
			_o.ResurrectionEntityData = ((this.ResurrectionEntityData != null) ? this.ResurrectionEntityData.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D6A1 RID: 120481 RVA: 0x00421880 File Offset: 0x0041FA80
		public static Offset<IRunningTreeConfig> Pack(FlatBufferBuilder builder, IRunningTreeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunningTreeConfig>);
			}
			VectorOffset nodesOffset = default(VectorOffset);
			if (_o.Nodes != null)
			{
				Offset<IRunningNodeStatus>[] array = new Offset<IRunningNodeStatus>[_o.Nodes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRunningNodeStatus.Pack(builder, _o.Nodes[i]);
				}
				nodesOffset = IRunningTreeConfig.CreateNodesVector(builder, array);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<Record_String_String>[] array2 = new Offset<Record_String_String>[_o.Vars.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = Record_String_String.Pack(builder, _o.Vars[j]);
				}
				varsOffset = IRunningTreeConfig.CreateVarsVector(builder, array2);
			}
			VectorOffset systemVarsOffset = default(VectorOffset);
			if (_o.SystemVars != null)
			{
				Offset<Record_String_String>[] array3 = new Offset<Record_String_String>[_o.SystemVars.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = Record_String_String.Pack(builder, _o.SystemVars[k]);
				}
				systemVarsOffset = IRunningTreeConfig.CreateSystemVarsVector(builder, array3);
			}
			Offset<IGameCurrBreakNodeInfo> breakNodeInfoOffset = (_o.BreakNodeInfo == null) ? default(Offset<IGameCurrBreakNodeInfo>) : IGameCurrBreakNodeInfo.Pack(builder, _o.BreakNodeInfo);
			VectorOffset savesOffset = default(VectorOffset);
			if (_o.Saves != null)
			{
				int[] data = _o.Saves.ToArray();
				savesOffset = IRunningTreeConfig.CreateSavesVector(builder, data);
			}
			VectorOffset optionGuidsOffset = default(VectorOffset);
			if (_o.OptionGuids != null)
			{
				StringOffset[] array4 = new StringOffset[_o.OptionGuids.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = builder.CreateString(_o.OptionGuids[l]);
				}
				optionGuidsOffset = IRunningTreeConfig.CreateOptionGuidsVector(builder, array4);
			}
			VectorOffset allActionsOffset = default(VectorOffset);
			if (_o.AllActions != null)
			{
				Offset<Record_Int_EActionState>[] array5 = new Offset<Record_Int_EActionState>[_o.AllActions.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = Record_Int_EActionState.Pack(builder, _o.AllActions[m]);
				}
				allActionsOffset = IRunningTreeConfig.CreateAllActionsVector(builder, array5);
			}
			Offset<IInstEntityData> resetEntityDataOffset = (_o.ResetEntityData == null) ? default(Offset<IInstEntityData>) : IInstEntityData.Pack(builder, _o.ResetEntityData);
			Offset<IInstEntityData> resurrectionEntityDataOffset = (_o.ResurrectionEntityData == null) ? default(Offset<IInstEntityData>) : IInstEntityData.Pack(builder, _o.ResurrectionEntityData);
			return IRunningTreeConfig.CreateIRunningTreeConfig(builder, _o.TreeId, nodesOffset, varsOffset, systemVarsOffset, breakNodeInfoOffset, _o.OnSave, savesOffset, optionGuidsOffset, allActionsOffset, resetEntityDataOffset, resurrectionEntityDataOffset, _o.NullMask);
		}

		// Token: 0x0400D406 RID: 54278
		private Table __p;
	}
}
