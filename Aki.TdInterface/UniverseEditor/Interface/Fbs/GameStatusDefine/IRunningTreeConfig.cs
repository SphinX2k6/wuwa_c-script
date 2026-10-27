using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Entity;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x0200470F RID: 18191
	public struct IRunningTreeConfig : IFlatbufferObject
	{
		// Token: 0x17008243 RID: 33347
		// (get) Token: 0x0601BE83 RID: 114307 RVA: 0x003F48DE File Offset: 0x003F2ADE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BE84 RID: 114308 RVA: 0x003F48EB File Offset: 0x003F2AEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BE85 RID: 114309 RVA: 0x003F48F4 File Offset: 0x003F2AF4
		public static IRunningTreeConfig GetRootAsIRunningTreeConfig(ByteBuffer _bb)
		{
			return IRunningTreeConfig.GetRootAsIRunningTreeConfig(_bb, default(IRunningTreeConfig));
		}

		// Token: 0x0601BE86 RID: 114310 RVA: 0x003F4910 File Offset: 0x003F2B10
		public static IRunningTreeConfig GetRootAsIRunningTreeConfig(ByteBuffer _bb, IRunningTreeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BE87 RID: 114311 RVA: 0x003F492D File Offset: 0x003F2B2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BE88 RID: 114312 RVA: 0x003F493C File Offset: 0x003F2B3C
		public IRunningTreeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008244 RID: 33348
		// (get) Token: 0x0601BE89 RID: 114313 RVA: 0x003F494C File Offset: 0x003F2B4C
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

		// Token: 0x0601BE8A RID: 114314 RVA: 0x003F4988 File Offset: 0x003F2B88
		public IRunningNodeStatus? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRunningNodeStatus?(default(IRunningNodeStatus).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008245 RID: 33349
		// (get) Token: 0x0601BE8B RID: 114315 RVA: 0x003F49E8 File Offset: 0x003F2BE8
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

		// Token: 0x0601BE8C RID: 114316 RVA: 0x003F4A14 File Offset: 0x003F2C14
		public Record_String_String? Vars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_String?(default(Record_String_String).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008246 RID: 33350
		// (get) Token: 0x0601BE8D RID: 114317 RVA: 0x003F4A74 File Offset: 0x003F2C74
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

		// Token: 0x0601BE8E RID: 114318 RVA: 0x003F4AA0 File Offset: 0x003F2CA0
		public Record_String_String? SystemVars(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_String?(default(Record_String_String).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008247 RID: 33351
		// (get) Token: 0x0601BE8F RID: 114319 RVA: 0x003F4B04 File Offset: 0x003F2D04
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

		// Token: 0x17008248 RID: 33352
		// (get) Token: 0x0601BE90 RID: 114320 RVA: 0x003F4B30 File Offset: 0x003F2D30
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

		// Token: 0x17008249 RID: 33353
		// (get) Token: 0x0601BE91 RID: 114321 RVA: 0x003F4B90 File Offset: 0x003F2D90
		public bool OnSave
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601BE92 RID: 114322 RVA: 0x003F4BD0 File Offset: 0x003F2DD0
		public int Saves(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700824A RID: 33354
		// (get) Token: 0x0601BE93 RID: 114323 RVA: 0x003F4C10 File Offset: 0x003F2E10
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

		// Token: 0x0601BE94 RID: 114324 RVA: 0x003F4C3C File Offset: 0x003F2E3C
		public Span<int> GetSavesBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0601BE95 RID: 114325 RVA: 0x003F4C4C File Offset: 0x003F2E4C
		public int[] GetSavesArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x0601BE96 RID: 114326 RVA: 0x003F4C5C File Offset: 0x003F2E5C
		public string OptionGuids(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700824B RID: 33355
		// (get) Token: 0x0601BE97 RID: 114327 RVA: 0x003F4C98 File Offset: 0x003F2E98
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

		// Token: 0x0601BE98 RID: 114328 RVA: 0x003F4CC4 File Offset: 0x003F2EC4
		public Record_Int_EActionState? AllActions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_EActionState?(default(Record_Int_EActionState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700824C RID: 33356
		// (get) Token: 0x0601BE99 RID: 114329 RVA: 0x003F4D28 File Offset: 0x003F2F28
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

		// Token: 0x1700824D RID: 33357
		// (get) Token: 0x0601BE9A RID: 114330 RVA: 0x003F4D54 File Offset: 0x003F2F54
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

		// Token: 0x1700824E RID: 33358
		// (get) Token: 0x0601BE9B RID: 114331 RVA: 0x003F4DB4 File Offset: 0x003F2FB4
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

		// Token: 0x1700824F RID: 33359
		// (get) Token: 0x0601BE9C RID: 114332 RVA: 0x003F4E14 File Offset: 0x003F3014
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

		// Token: 0x0601BE9D RID: 114333 RVA: 0x003F4E54 File Offset: 0x003F3054
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

		// Token: 0x0601BE9E RID: 114334 RVA: 0x003F4ECC File Offset: 0x003F30CC
		public static void StartIRunningTreeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x0601BE9F RID: 114335 RVA: 0x003F4ED6 File Offset: 0x003F30D6
		public static void AddTreeId(FlatBufferBuilder builder, int treeId)
		{
			builder.AddInt(0, treeId, 0);
		}

		// Token: 0x0601BEA0 RID: 114336 RVA: 0x003F4EE1 File Offset: 0x003F30E1
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x0601BEA1 RID: 114337 RVA: 0x003F4EF4 File Offset: 0x003F30F4
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IRunningNodeStatus>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEA2 RID: 114338 RVA: 0x003F4F34 File Offset: 0x003F3134
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IRunningNodeStatus>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRunningNodeStatus>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEA3 RID: 114339 RVA: 0x003F4F4E File Offset: 0x003F314E
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRunningNodeStatus>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRunningNodeStatus>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEA4 RID: 114340 RVA: 0x003F4F6C File Offset: 0x003F316C
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRunningNodeStatus>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEA5 RID: 114341 RVA: 0x003F4F85 File Offset: 0x003F3185
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEA6 RID: 114342 RVA: 0x003F4F90 File Offset: 0x003F3190
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(2, varsOffset.Value, 0);
		}

		// Token: 0x0601BEA7 RID: 114343 RVA: 0x003F4FA0 File Offset: 0x003F31A0
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEA8 RID: 114344 RVA: 0x003F4FE0 File Offset: 0x003F31E0
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEA9 RID: 114345 RVA: 0x003F4FFA File Offset: 0x003F31FA
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_String>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEAA RID: 114346 RVA: 0x003F5018 File Offset: 0x003F3218
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_String>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEAB RID: 114347 RVA: 0x003F5031 File Offset: 0x003F3231
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEAC RID: 114348 RVA: 0x003F503C File Offset: 0x003F323C
		public static void AddSystemVars(FlatBufferBuilder builder, VectorOffset systemVarsOffset)
		{
			builder.AddOffset(3, systemVarsOffset.Value, 0);
		}

		// Token: 0x0601BEAD RID: 114349 RVA: 0x003F504C File Offset: 0x003F324C
		public static VectorOffset CreateSystemVarsVector(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEAE RID: 114350 RVA: 0x003F508C File Offset: 0x003F328C
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, Offset<Record_String_String>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEAF RID: 114351 RVA: 0x003F50A6 File Offset: 0x003F32A6
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_String>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_String>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEB0 RID: 114352 RVA: 0x003F50C4 File Offset: 0x003F32C4
		public static VectorOffset CreateSystemVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_String>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEB1 RID: 114353 RVA: 0x003F50DD File Offset: 0x003F32DD
		public static void StartSystemVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEB2 RID: 114354 RVA: 0x003F50E8 File Offset: 0x003F32E8
		public static void AddBreakNodeInfo(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeInfo> breakNodeInfoOffset)
		{
			builder.AddOffset(4, breakNodeInfoOffset.Value, 0);
		}

		// Token: 0x0601BEB3 RID: 114355 RVA: 0x003F50F8 File Offset: 0x003F32F8
		public static void AddOnSave(FlatBufferBuilder builder, bool onSave)
		{
			builder.AddBool(5, onSave, false);
		}

		// Token: 0x0601BEB4 RID: 114356 RVA: 0x003F5103 File Offset: 0x003F3303
		public static void AddSaves(FlatBufferBuilder builder, VectorOffset savesOffset)
		{
			builder.AddOffset(6, savesOffset.Value, 0);
		}

		// Token: 0x0601BEB5 RID: 114357 RVA: 0x003F5114 File Offset: 0x003F3314
		public static VectorOffset CreateSavesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEB6 RID: 114358 RVA: 0x003F514B File Offset: 0x003F334B
		public static VectorOffset CreateSavesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEB7 RID: 114359 RVA: 0x003F5165 File Offset: 0x003F3365
		public static VectorOffset CreateSavesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEB8 RID: 114360 RVA: 0x003F5183 File Offset: 0x003F3383
		public static VectorOffset CreateSavesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEB9 RID: 114361 RVA: 0x003F519C File Offset: 0x003F339C
		public static void StartSavesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEBA RID: 114362 RVA: 0x003F51A7 File Offset: 0x003F33A7
		public static void AddOptionGuids(FlatBufferBuilder builder, VectorOffset optionGuidsOffset)
		{
			builder.AddOffset(7, optionGuidsOffset.Value, 0);
		}

		// Token: 0x0601BEBB RID: 114363 RVA: 0x003F51B8 File Offset: 0x003F33B8
		public static VectorOffset CreateOptionGuidsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEBC RID: 114364 RVA: 0x003F51F8 File Offset: 0x003F33F8
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEBD RID: 114365 RVA: 0x003F5212 File Offset: 0x003F3412
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEBE RID: 114366 RVA: 0x003F5230 File Offset: 0x003F3430
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEBF RID: 114367 RVA: 0x003F5249 File Offset: 0x003F3449
		public static void StartOptionGuidsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEC0 RID: 114368 RVA: 0x003F5254 File Offset: 0x003F3454
		public static void AddAllActions(FlatBufferBuilder builder, VectorOffset allActionsOffset)
		{
			builder.AddOffset(8, allActionsOffset.Value, 0);
		}

		// Token: 0x0601BEC1 RID: 114369 RVA: 0x003F5264 File Offset: 0x003F3464
		public static VectorOffset CreateAllActionsVector(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEC2 RID: 114370 RVA: 0x003F52A4 File Offset: 0x003F34A4
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEC3 RID: 114371 RVA: 0x003F52BE File Offset: 0x003F34BE
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_EActionState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEC4 RID: 114372 RVA: 0x003F52DC File Offset: 0x003F34DC
		public static VectorOffset CreateAllActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_EActionState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEC5 RID: 114373 RVA: 0x003F52F5 File Offset: 0x003F34F5
		public static void StartAllActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEC6 RID: 114374 RVA: 0x003F5300 File Offset: 0x003F3500
		public static void AddResetEntityData(FlatBufferBuilder builder, Offset<IInstEntityData> resetEntityDataOffset)
		{
			builder.AddOffset(9, resetEntityDataOffset.Value, 0);
		}

		// Token: 0x0601BEC7 RID: 114375 RVA: 0x003F5311 File Offset: 0x003F3511
		public static void AddResurrectionEntityData(FlatBufferBuilder builder, Offset<IInstEntityData> resurrectionEntityDataOffset)
		{
			builder.AddOffset(10, resurrectionEntityDataOffset.Value, 0);
		}

		// Token: 0x0601BEC8 RID: 114376 RVA: 0x003F5322 File Offset: 0x003F3522
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x0601BEC9 RID: 114377 RVA: 0x003F532E File Offset: 0x003F352E
		public static Offset<IRunningTreeConfig> EndIRunningTreeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRunningTreeConfig>(builder.EndTable());
		}

		// Token: 0x0601BECA RID: 114378 RVA: 0x003F533C File Offset: 0x003F353C
		public IRunningTreeConfigT UnPack()
		{
			IRunningTreeConfigT runningTreeConfigT = new IRunningTreeConfigT();
			this.UnPackTo(runningTreeConfigT);
			return runningTreeConfigT;
		}

		// Token: 0x0601BECB RID: 114379 RVA: 0x003F5358 File Offset: 0x003F3558
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

		// Token: 0x0601BECC RID: 114380 RVA: 0x003F55E4 File Offset: 0x003F37E4
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

		// Token: 0x0400C9D7 RID: 51671
		private Table __p;
	}
}
