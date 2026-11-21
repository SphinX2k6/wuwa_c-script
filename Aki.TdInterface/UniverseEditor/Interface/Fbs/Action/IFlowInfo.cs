using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E96 RID: 28310
	public struct IFlowInfo : IFlatbufferObject
	{
		// Token: 0x1700CF7A RID: 53114
		// (get) Token: 0x06030EC6 RID: 200390 RVA: 0x006A2939 File Offset: 0x006A0B39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030EC7 RID: 200391 RVA: 0x006A2946 File Offset: 0x006A0B46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030EC8 RID: 200392 RVA: 0x006A2950 File Offset: 0x006A0B50
		public static IFlowInfo GetRootAsIFlowInfo(ByteBuffer _bb)
		{
			return IFlowInfo.GetRootAsIFlowInfo(_bb, default(IFlowInfo));
		}

		// Token: 0x06030EC9 RID: 200393 RVA: 0x006A296C File Offset: 0x006A0B6C
		public static IFlowInfo GetRootAsIFlowInfo(ByteBuffer _bb, IFlowInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030ECA RID: 200394 RVA: 0x006A2989 File Offset: 0x006A0B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030ECB RID: 200395 RVA: 0x006A2998 File Offset: 0x006A0B98
		public IFlowInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF7B RID: 53115
		// (get) Token: 0x06030ECC RID: 200396 RVA: 0x006A29A8 File Offset: 0x006A0BA8
		public string ObjType
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

		// Token: 0x06030ECD RID: 200397 RVA: 0x006A29DF File Offset: 0x006A0BDF
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06030ECE RID: 200398 RVA: 0x006A29EE File Offset: 0x006A0BEE
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06030ECF RID: 200399 RVA: 0x006A29FC File Offset: 0x006A0BFC
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CF7C RID: 53116
		// (get) Token: 0x06030ED0 RID: 200400 RVA: 0x006A2A38 File Offset: 0x006A0C38
		public int ChildrenLength
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

		// Token: 0x06030ED1 RID: 200401 RVA: 0x006A2A64 File Offset: 0x006A0C64
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CF7D RID: 53117
		// (get) Token: 0x06030ED2 RID: 200402 RVA: 0x006A2AA0 File Offset: 0x006A0CA0
		public int ReferenceLength
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

		// Token: 0x06030ED3 RID: 200403 RVA: 0x006A2ACC File Offset: 0x006A0CCC
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CF7E RID: 53118
		// (get) Token: 0x06030ED4 RID: 200404 RVA: 0x006A2B08 File Offset: 0x006A0D08
		public int WeakReferenceLength
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

		// Token: 0x1700CF7F RID: 53119
		// (get) Token: 0x06030ED5 RID: 200405 RVA: 0x006A2B34 File Offset: 0x006A0D34
		public int Id
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF80 RID: 53120
		// (get) Token: 0x06030ED6 RID: 200406 RVA: 0x006A2B74 File Offset: 0x006A0D74
		public string Name
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030ED7 RID: 200407 RVA: 0x006A2BAC File Offset: 0x006A0DAC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06030ED8 RID: 200408 RVA: 0x006A2BBC File Offset: 0x006A0DBC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700CF81 RID: 53121
		// (get) Token: 0x06030ED9 RID: 200409 RVA: 0x006A2BCC File Offset: 0x006A0DCC
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF82 RID: 53122
		// (get) Token: 0x06030EDA RID: 200410 RVA: 0x006A2C0C File Offset: 0x006A0E0C
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF83 RID: 53123
		// (get) Token: 0x06030EDB RID: 200411 RVA: 0x006A2C4C File Offset: 0x006A0E4C
		public int _SelectedStateId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030EDC RID: 200412 RVA: 0x006A2C8C File Offset: 0x006A0E8C
		public int _SelectedStateIds(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CF84 RID: 53124
		// (get) Token: 0x06030EDD RID: 200413 RVA: 0x006A2CCC File Offset: 0x006A0ECC
		public int _SelectedStateIdsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06030EDE RID: 200414 RVA: 0x006A2CF8 File Offset: 0x006A0EF8
		public Span<int> Get_SelectedStateIdsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06030EDF RID: 200415 RVA: 0x006A2D08 File Offset: 0x006A0F08
		public int[] Get_SelectedStateIdsArray()
		{
			return this.__p.__vector_as_array<int>(22);
		}

		// Token: 0x1700CF85 RID: 53125
		// (get) Token: 0x06030EE0 RID: 200416 RVA: 0x006A2D18 File Offset: 0x006A0F18
		public TVarContext VarContextType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return TVarContext.NONE;
				}
				return (TVarContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030EE1 RID: 200417 RVA: 0x006A2D58 File Offset: 0x006A0F58
		public TTable? VarContext<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030EE2 RID: 200418 RVA: 0x006A2DA0 File Offset: 0x006A0FA0
		public IBehaviorTreeFragmentContext VarContextAsIBehaviorTreeFragmentContext()
		{
			return this.VarContext<IBehaviorTreeFragmentContext>().Value;
		}

		// Token: 0x06030EE3 RID: 200419 RVA: 0x006A2DBC File Offset: 0x006A0FBC
		public ICommonBtContext VarContextAsICommonBtContext()
		{
			return this.VarContext<ICommonBtContext>().Value;
		}

		// Token: 0x06030EE4 RID: 200420 RVA: 0x006A2DD8 File Offset: 0x006A0FD8
		public IEntityTemplateContext VarContextAsIEntityTemplateContext()
		{
			return this.VarContext<IEntityTemplateContext>().Value;
		}

		// Token: 0x06030EE5 RID: 200421 RVA: 0x006A2DF4 File Offset: 0x006A0FF4
		public IEntityVarContext VarContextAsIEntityVarContext()
		{
			return this.VarContext<IEntityVarContext>().Value;
		}

		// Token: 0x06030EE6 RID: 200422 RVA: 0x006A2E10 File Offset: 0x006A1010
		public ILevelPlayVarContext VarContextAsILevelPlayVarContext()
		{
			return this.VarContext<ILevelPlayVarContext>().Value;
		}

		// Token: 0x06030EE7 RID: 200423 RVA: 0x006A2E2C File Offset: 0x006A102C
		public IQuestVarContext VarContextAsIQuestVarContext()
		{
			return this.VarContext<IQuestVarContext>().Value;
		}

		// Token: 0x06030EE8 RID: 200424 RVA: 0x006A2E48 File Offset: 0x006A1048
		public IStateInfo? States(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IStateInfo?(default(IStateInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CF86 RID: 53126
		// (get) Token: 0x06030EE9 RID: 200425 RVA: 0x006A2EAC File Offset: 0x006A10AC
		public int StatesLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700CF87 RID: 53127
		// (get) Token: 0x06030EEA RID: 200426 RVA: 0x006A2ED8 File Offset: 0x006A10D8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030EEB RID: 200427 RVA: 0x006A2F18 File Offset: 0x006A1118
		public static Offset<IFlowInfo> CreateIFlowInfo(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), int Id = 0, StringOffset NameOffset = default(StringOffset), int DungeonId = 0, bool _folded = false, int _selectedStateId = 0, VectorOffset _selectedStateIdsOffset = default(VectorOffset), TVarContext VarContext_type = TVarContext.NONE, int VarContextOffset = 0, VectorOffset StatesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(14);
			IFlowInfo.AddStates(builder, StatesOffset);
			IFlowInfo.AddVarContext(builder, VarContextOffset);
			IFlowInfo.Add_SelectedStateIds(builder, _selectedStateIdsOffset);
			IFlowInfo.Add_SelectedStateId(builder, _selectedStateId);
			IFlowInfo.AddDungeonId(builder, DungeonId);
			IFlowInfo.AddName(builder, NameOffset);
			IFlowInfo.AddId(builder, Id);
			IFlowInfo.AddWeakReference(builder, WeakReferenceOffset);
			IFlowInfo.AddReference(builder, ReferenceOffset);
			IFlowInfo.AddChildren(builder, ChildrenOffset);
			IFlowInfo.AddObjType(builder, ObjTypeOffset);
			IFlowInfo.AddNullMask(builder, NullMask);
			IFlowInfo.AddVarContextType(builder, VarContext_type);
			IFlowInfo.Add_Folded(builder, _folded);
			return IFlowInfo.EndIFlowInfo(builder);
		}

		// Token: 0x06030EEC RID: 200428 RVA: 0x006A2FA0 File Offset: 0x006A11A0
		public static void StartIFlowInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06030EED RID: 200429 RVA: 0x006A2FAA File Offset: 0x006A11AA
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x06030EEE RID: 200430 RVA: 0x006A2FBA File Offset: 0x006A11BA
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x06030EEF RID: 200431 RVA: 0x006A2FCC File Offset: 0x006A11CC
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030EF0 RID: 200432 RVA: 0x006A300C File Offset: 0x006A120C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030EF1 RID: 200433 RVA: 0x006A3026 File Offset: 0x006A1226
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030EF2 RID: 200434 RVA: 0x006A3044 File Offset: 0x006A1244
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030EF3 RID: 200435 RVA: 0x006A305D File Offset: 0x006A125D
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030EF4 RID: 200436 RVA: 0x006A3068 File Offset: 0x006A1268
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x06030EF5 RID: 200437 RVA: 0x006A3078 File Offset: 0x006A1278
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030EF6 RID: 200438 RVA: 0x006A30B8 File Offset: 0x006A12B8
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030EF7 RID: 200439 RVA: 0x006A30D2 File Offset: 0x006A12D2
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030EF8 RID: 200440 RVA: 0x006A30F0 File Offset: 0x006A12F0
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030EF9 RID: 200441 RVA: 0x006A3109 File Offset: 0x006A1309
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030EFA RID: 200442 RVA: 0x006A3114 File Offset: 0x006A1314
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x06030EFB RID: 200443 RVA: 0x006A3124 File Offset: 0x006A1324
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030EFC RID: 200444 RVA: 0x006A3164 File Offset: 0x006A1364
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030EFD RID: 200445 RVA: 0x006A317E File Offset: 0x006A137E
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030EFE RID: 200446 RVA: 0x006A319C File Offset: 0x006A139C
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030EFF RID: 200447 RVA: 0x006A31B5 File Offset: 0x006A13B5
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030F00 RID: 200448 RVA: 0x006A31C0 File Offset: 0x006A13C0
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(4, id, 0);
		}

		// Token: 0x06030F01 RID: 200449 RVA: 0x006A31CB File Offset: 0x006A13CB
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(5, nameOffset.Value, 0);
		}

		// Token: 0x06030F02 RID: 200450 RVA: 0x006A31DB File Offset: 0x006A13DB
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(6, dungeonId, 0);
		}

		// Token: 0x06030F03 RID: 200451 RVA: 0x006A31E6 File Offset: 0x006A13E6
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(7, _Folded, false);
		}

		// Token: 0x06030F04 RID: 200452 RVA: 0x006A31F1 File Offset: 0x006A13F1
		public static void Add_SelectedStateId(FlatBufferBuilder builder, int _SelectedStateId)
		{
			builder.AddInt(8, _SelectedStateId, 0);
		}

		// Token: 0x06030F05 RID: 200453 RVA: 0x006A31FC File Offset: 0x006A13FC
		public static void Add_SelectedStateIds(FlatBufferBuilder builder, VectorOffset _SelectedStateIdsOffset)
		{
			builder.AddOffset(9, _SelectedStateIdsOffset.Value, 0);
		}

		// Token: 0x06030F06 RID: 200454 RVA: 0x006A3210 File Offset: 0x006A1410
		public static VectorOffset Create_SelectedStateIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030F07 RID: 200455 RVA: 0x006A3247 File Offset: 0x006A1447
		public static VectorOffset Create_SelectedStateIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F08 RID: 200456 RVA: 0x006A3261 File Offset: 0x006A1461
		public static VectorOffset Create_SelectedStateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F09 RID: 200457 RVA: 0x006A327F File Offset: 0x006A147F
		public static VectorOffset Create_SelectedStateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030F0A RID: 200458 RVA: 0x006A3298 File Offset: 0x006A1498
		public static void Start_SelectedStateIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030F0B RID: 200459 RVA: 0x006A32A3 File Offset: 0x006A14A3
		public static void AddVarContextType(FlatBufferBuilder builder, TVarContext varContextType)
		{
			builder.AddByte(10, (byte)varContextType, 0);
		}

		// Token: 0x06030F0C RID: 200460 RVA: 0x006A32AF File Offset: 0x006A14AF
		public static void AddVarContext(FlatBufferBuilder builder, int varContextOffset)
		{
			builder.AddOffset(11, varContextOffset, 0);
		}

		// Token: 0x06030F0D RID: 200461 RVA: 0x006A32BB File Offset: 0x006A14BB
		public static void AddStates(FlatBufferBuilder builder, VectorOffset statesOffset)
		{
			builder.AddOffset(12, statesOffset.Value, 0);
		}

		// Token: 0x06030F0E RID: 200462 RVA: 0x006A32CC File Offset: 0x006A14CC
		public static VectorOffset CreateStatesVector(FlatBufferBuilder builder, Offset<IStateInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030F0F RID: 200463 RVA: 0x006A330C File Offset: 0x006A150C
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, Offset<IStateInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F10 RID: 200464 RVA: 0x006A3326 File Offset: 0x006A1526
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F11 RID: 200465 RVA: 0x006A3344 File Offset: 0x006A1544
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030F12 RID: 200466 RVA: 0x006A335D File Offset: 0x006A155D
		public static void StartStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030F13 RID: 200467 RVA: 0x006A3368 File Offset: 0x006A1568
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x06030F14 RID: 200468 RVA: 0x006A3374 File Offset: 0x006A1574
		public static Offset<IFlowInfo> EndIFlowInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFlowInfo>(builder.EndTable());
		}

		// Token: 0x06030F15 RID: 200469 RVA: 0x006A3384 File Offset: 0x006A1584
		public IFlowInfoT UnPack()
		{
			IFlowInfoT flowInfoT = new IFlowInfoT();
			this.UnPackTo(flowInfoT);
			return flowInfoT;
		}

		// Token: 0x06030F16 RID: 200470 RVA: 0x006A33A0 File Offset: 0x006A15A0
		public void UnPackTo(IFlowInfoT _o)
		{
			_o.ObjType = this.ObjType;
			_o.Children = new List<string>();
			for (int i = 0; i < this.ChildrenLength; i++)
			{
				_o.Children.Add(this.Children(i));
			}
			_o.Reference = new List<string>();
			for (int j = 0; j < this.ReferenceLength; j++)
			{
				_o.Reference.Add(this.Reference(j));
			}
			_o.WeakReference = new List<string>();
			for (int k = 0; k < this.WeakReferenceLength; k++)
			{
				_o.WeakReference.Add(this.WeakReference(k));
			}
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.DungeonId = this.DungeonId;
			_o._Folded = this._Folded;
			_o._SelectedStateId = this._SelectedStateId;
			_o._SelectedStateIds = new List<int>();
			for (int l = 0; l < this._SelectedStateIdsLength; l++)
			{
				_o._SelectedStateIds.Add(this._SelectedStateIds(l));
			}
			_o.VarContext = new TVarContextUnion();
			_o.VarContext.Type = this.VarContextType;
			switch (this.VarContextType)
			{
			case TVarContext.IBehaviorTreeFragmentContext:
				_o.VarContext.Value = ((this.VarContext<IBehaviorTreeFragmentContext>() != null) ? this.VarContext<IBehaviorTreeFragmentContext>().Value.UnPack() : null);
				break;
			case TVarContext.ICommonBtContext:
				_o.VarContext.Value = ((this.VarContext<ICommonBtContext>() != null) ? this.VarContext<ICommonBtContext>().Value.UnPack() : null);
				break;
			case TVarContext.IEntityTemplateContext:
				_o.VarContext.Value = ((this.VarContext<IEntityTemplateContext>() != null) ? this.VarContext<IEntityTemplateContext>().Value.UnPack() : null);
				break;
			case TVarContext.IEntityVarContext:
				_o.VarContext.Value = ((this.VarContext<IEntityVarContext>() != null) ? this.VarContext<IEntityVarContext>().Value.UnPack() : null);
				break;
			case TVarContext.ILevelPlayVarContext:
				_o.VarContext.Value = ((this.VarContext<ILevelPlayVarContext>() != null) ? this.VarContext<ILevelPlayVarContext>().Value.UnPack() : null);
				break;
			case TVarContext.IQuestVarContext:
				_o.VarContext.Value = ((this.VarContext<IQuestVarContext>() != null) ? this.VarContext<IQuestVarContext>().Value.UnPack() : null);
				break;
			}
			_o.States = new List<IStateInfoT>();
			for (int m = 0; m < this.StatesLength; m++)
			{
				_o.States.Add((this.States(m) != null) ? this.States(m).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030F17 RID: 200471 RVA: 0x006A36BC File Offset: 0x006A18BC
		public static Offset<IFlowInfo> Pack(FlatBufferBuilder builder, IFlowInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowInfo>);
			}
			StringOffset objTypeOffset = (_o.ObjType == null) ? default(StringOffset) : builder.CreateString(_o.ObjType);
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				StringOffset[] array = new StringOffset[_o.Children.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Children[i]);
				}
				childrenOffset = IFlowInfo.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IFlowInfo.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IFlowInfo.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			VectorOffset selectedStateIdsOffset = default(VectorOffset);
			if (_o._SelectedStateIds != null)
			{
				int[] data = _o._SelectedStateIds.ToArray();
				selectedStateIdsOffset = IFlowInfo.Create_SelectedStateIdsVector(builder, data);
			}
			TVarContext varContext_type = (_o.VarContext == null) ? TVarContext.NONE : _o.VarContext.Type;
			int varContextOffset = (_o.VarContext == null) ? 0 : TVarContextUnion.Pack(builder, _o.VarContext);
			VectorOffset statesOffset = default(VectorOffset);
			if (_o.States != null)
			{
				Offset<IStateInfo>[] array4 = new Offset<IStateInfo>[_o.States.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IStateInfo.Pack(builder, _o.States[l]);
				}
				statesOffset = IFlowInfo.CreateStatesVector(builder, array4);
			}
			return IFlowInfo.CreateIFlowInfo(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Id, nameOffset, _o.DungeonId, _o._Folded, _o._SelectedStateId, selectedStateIdsOffset, varContext_type, varContextOffset, statesOffset, _o.NullMask);
		}

		// Token: 0x04011D70 RID: 73072
		private Table __p;
	}
}
