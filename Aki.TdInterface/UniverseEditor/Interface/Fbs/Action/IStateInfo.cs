using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007992 RID: 31122
	public struct IStateInfo : IFlatbufferObject
	{
		// Token: 0x1700E431 RID: 58417
		// (get) Token: 0x06036D0C RID: 224524 RVA: 0x00754F2A File Offset: 0x0075312A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036D0D RID: 224525 RVA: 0x00754F37 File Offset: 0x00753137
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036D0E RID: 224526 RVA: 0x00754F40 File Offset: 0x00753140
		public static IStateInfo GetRootAsIStateInfo(ByteBuffer _bb)
		{
			return IStateInfo.GetRootAsIStateInfo(_bb, default(IStateInfo));
		}

		// Token: 0x06036D0F RID: 224527 RVA: 0x00754F5C File Offset: 0x0075315C
		public static IStateInfo GetRootAsIStateInfo(ByteBuffer _bb, IStateInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036D10 RID: 224528 RVA: 0x00754F79 File Offset: 0x00753179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036D11 RID: 224529 RVA: 0x00754F88 File Offset: 0x00753188
		public IStateInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E432 RID: 58418
		// (get) Token: 0x06036D12 RID: 224530 RVA: 0x00754F98 File Offset: 0x00753198
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

		// Token: 0x06036D13 RID: 224531 RVA: 0x00754FCF File Offset: 0x007531CF
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036D14 RID: 224532 RVA: 0x00754FDE File Offset: 0x007531DE
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06036D15 RID: 224533 RVA: 0x00754FEC File Offset: 0x007531EC
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E433 RID: 58419
		// (get) Token: 0x06036D16 RID: 224534 RVA: 0x00755028 File Offset: 0x00753228
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

		// Token: 0x06036D17 RID: 224535 RVA: 0x00755054 File Offset: 0x00753254
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E434 RID: 58420
		// (get) Token: 0x06036D18 RID: 224536 RVA: 0x00755090 File Offset: 0x00753290
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

		// Token: 0x06036D19 RID: 224537 RVA: 0x007550BC File Offset: 0x007532BC
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E435 RID: 58421
		// (get) Token: 0x06036D1A RID: 224538 RVA: 0x007550F8 File Offset: 0x007532F8
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

		// Token: 0x1700E436 RID: 58422
		// (get) Token: 0x06036D1B RID: 224539 RVA: 0x00755124 File Offset: 0x00753324
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

		// Token: 0x1700E437 RID: 58423
		// (get) Token: 0x06036D1C RID: 224540 RVA: 0x00755164 File Offset: 0x00753364
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

		// Token: 0x06036D1D RID: 224541 RVA: 0x0075519C File Offset: 0x0075339C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06036D1E RID: 224542 RVA: 0x007551AC File Offset: 0x007533AC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700E438 RID: 58424
		// (get) Token: 0x06036D1F RID: 224543 RVA: 0x007551BC File Offset: 0x007533BC
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06036D20 RID: 224544 RVA: 0x007551FC File Offset: 0x007533FC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E439 RID: 58425
		// (get) Token: 0x06036D21 RID: 224545 RVA: 0x00755260 File Offset: 0x00753460
		public int ActionsLength
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

		// Token: 0x1700E43A RID: 58426
		// (get) Token: 0x06036D22 RID: 224546 RVA: 0x0075528C File Offset: 0x0075348C
		public bool KeepBgm
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E43B RID: 58427
		// (get) Token: 0x06036D23 RID: 224547 RVA: 0x007552CC File Offset: 0x007534CC
		public bool OnlyPlayOnce
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E43C RID: 58428
		// (get) Token: 0x06036D24 RID: 224548 RVA: 0x0075530C File Offset: 0x0075350C
		public bool KeepInVehicle
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E43D RID: 58429
		// (get) Token: 0x06036D25 RID: 224549 RVA: 0x0075534C File Offset: 0x0075354C
		public bool AllowMultiReference
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E43E RID: 58430
		// (get) Token: 0x06036D26 RID: 224550 RVA: 0x0075538C File Offset: 0x0075358C
		public bool IgnoreInPlotHandBook
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E43F RID: 58431
		// (get) Token: 0x06036D27 RID: 224551 RVA: 0x007553CC File Offset: 0x007535CC
		public bool DontInterruptMatch
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E440 RID: 58432
		// (get) Token: 0x06036D28 RID: 224552 RVA: 0x0075540C File Offset: 0x0075360C
		public bool IsPreloadFlow
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E441 RID: 58433
		// (get) Token: 0x06036D29 RID: 224553 RVA: 0x0075544C File Offset: 0x0075364C
		public bool IsClientFlow
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E442 RID: 58434
		// (get) Token: 0x06036D2A RID: 224554 RVA: 0x0075548C File Offset: 0x0075368C
		public bool _ShowImport
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E443 RID: 58435
		// (get) Token: 0x06036D2B RID: 224555 RVA: 0x007554CC File Offset: 0x007536CC
		public IPosA? PlotPos
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E444 RID: 58436
		// (get) Token: 0x06036D2C RID: 224556 RVA: 0x0075552C File Offset: 0x0075372C
		public IStateProgramSpecialProcessChangeTeamOptimization? ProgramSpecialProcess
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return new IStateProgramSpecialProcessChangeTeamOptimization?(default(IStateProgramSpecialProcessChangeTeamOptimization).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E445 RID: 58437
		// (get) Token: 0x06036D2D RID: 224557 RVA: 0x0075558C File Offset: 0x0075378C
		public bool UseConditionalText
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06036D2E RID: 224558 RVA: 0x007555CC File Offset: 0x007537CC
		public int _SelectedIndexes(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E446 RID: 58438
		// (get) Token: 0x06036D2F RID: 224559 RVA: 0x0075560C File Offset: 0x0075380C
		public int _SelectedIndexesLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06036D30 RID: 224560 RVA: 0x00755638 File Offset: 0x00753838
		public Span<int> Get_SelectedIndexesBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x06036D31 RID: 224561 RVA: 0x00755648 File Offset: 0x00753848
		public int[] Get_SelectedIndexesArray()
		{
			return this.__p.__vector_as_array<int>(44);
		}

		// Token: 0x1700E447 RID: 58439
		// (get) Token: 0x06036D32 RID: 224562 RVA: 0x00755658 File Offset: 0x00753858
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036D33 RID: 224563 RVA: 0x00755698 File Offset: 0x00753898
		public static Offset<IStateInfo> CreateIStateInfo(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), int Id = 0, StringOffset NameOffset = default(StringOffset), bool _folded = false, VectorOffset ActionsOffset = default(VectorOffset), bool KeepBgm = false, bool OnlyPlayOnce = false, bool KeepInVehicle = false, bool AllowMultiReference = false, bool IgnoreInPlotHandBook = false, bool DontInterruptMatch = false, bool IsPreloadFlow = false, bool IsClientFlow = false, bool _showImport = false, Offset<IPosA> PlotPosOffset = default(Offset<IPosA>), Offset<IStateProgramSpecialProcessChangeTeamOptimization> ProgramSpecialProcessOffset = default(Offset<IStateProgramSpecialProcessChangeTeamOptimization>), bool UseConditionalText = false, VectorOffset _SelectedIndexesOffset = default(VectorOffset), ushort NullMask = 0)
		{
			builder.StartTable(22);
			IStateInfo.Add_SelectedIndexes(builder, _SelectedIndexesOffset);
			IStateInfo.AddProgramSpecialProcess(builder, ProgramSpecialProcessOffset);
			IStateInfo.AddPlotPos(builder, PlotPosOffset);
			IStateInfo.AddActions(builder, ActionsOffset);
			IStateInfo.AddName(builder, NameOffset);
			IStateInfo.AddId(builder, Id);
			IStateInfo.AddWeakReference(builder, WeakReferenceOffset);
			IStateInfo.AddReference(builder, ReferenceOffset);
			IStateInfo.AddChildren(builder, ChildrenOffset);
			IStateInfo.AddObjType(builder, ObjTypeOffset);
			IStateInfo.AddNullMask(builder, NullMask);
			IStateInfo.AddUseConditionalText(builder, UseConditionalText);
			IStateInfo.Add_ShowImport(builder, _showImport);
			IStateInfo.AddIsClientFlow(builder, IsClientFlow);
			IStateInfo.AddIsPreloadFlow(builder, IsPreloadFlow);
			IStateInfo.AddDontInterruptMatch(builder, DontInterruptMatch);
			IStateInfo.AddIgnoreInPlotHandBook(builder, IgnoreInPlotHandBook);
			IStateInfo.AddAllowMultiReference(builder, AllowMultiReference);
			IStateInfo.AddKeepInVehicle(builder, KeepInVehicle);
			IStateInfo.AddOnlyPlayOnce(builder, OnlyPlayOnce);
			IStateInfo.AddKeepBgm(builder, KeepBgm);
			IStateInfo.Add_Folded(builder, _folded);
			return IStateInfo.EndIStateInfo(builder);
		}

		// Token: 0x06036D34 RID: 224564 RVA: 0x00755760 File Offset: 0x00753960
		public static void StartIStateInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(22);
		}

		// Token: 0x06036D35 RID: 224565 RVA: 0x0075576A File Offset: 0x0075396A
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x06036D36 RID: 224566 RVA: 0x0075577A File Offset: 0x0075397A
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x06036D37 RID: 224567 RVA: 0x0075578C File Offset: 0x0075398C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036D38 RID: 224568 RVA: 0x007557CC File Offset: 0x007539CC
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D39 RID: 224569 RVA: 0x007557E6 File Offset: 0x007539E6
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D3A RID: 224570 RVA: 0x00755804 File Offset: 0x00753A04
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036D3B RID: 224571 RVA: 0x0075581D File Offset: 0x00753A1D
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036D3C RID: 224572 RVA: 0x00755828 File Offset: 0x00753A28
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x06036D3D RID: 224573 RVA: 0x00755838 File Offset: 0x00753A38
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036D3E RID: 224574 RVA: 0x00755878 File Offset: 0x00753A78
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D3F RID: 224575 RVA: 0x00755892 File Offset: 0x00753A92
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D40 RID: 224576 RVA: 0x007558B0 File Offset: 0x00753AB0
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036D41 RID: 224577 RVA: 0x007558C9 File Offset: 0x00753AC9
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036D42 RID: 224578 RVA: 0x007558D4 File Offset: 0x00753AD4
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x06036D43 RID: 224579 RVA: 0x007558E4 File Offset: 0x00753AE4
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036D44 RID: 224580 RVA: 0x00755924 File Offset: 0x00753B24
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D45 RID: 224581 RVA: 0x0075593E File Offset: 0x00753B3E
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D46 RID: 224582 RVA: 0x0075595C File Offset: 0x00753B5C
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036D47 RID: 224583 RVA: 0x00755975 File Offset: 0x00753B75
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036D48 RID: 224584 RVA: 0x00755980 File Offset: 0x00753B80
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(4, id, 0);
		}

		// Token: 0x06036D49 RID: 224585 RVA: 0x0075598B File Offset: 0x00753B8B
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(5, nameOffset.Value, 0);
		}

		// Token: 0x06036D4A RID: 224586 RVA: 0x0075599B File Offset: 0x00753B9B
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(6, _Folded, false);
		}

		// Token: 0x06036D4B RID: 224587 RVA: 0x007559A6 File Offset: 0x00753BA6
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(7, actionsOffset.Value, 0);
		}

		// Token: 0x06036D4C RID: 224588 RVA: 0x007559B8 File Offset: 0x00753BB8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036D4D RID: 224589 RVA: 0x007559F8 File Offset: 0x00753BF8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D4E RID: 224590 RVA: 0x00755A12 File Offset: 0x00753C12
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D4F RID: 224591 RVA: 0x00755A30 File Offset: 0x00753C30
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036D50 RID: 224592 RVA: 0x00755A49 File Offset: 0x00753C49
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036D51 RID: 224593 RVA: 0x00755A54 File Offset: 0x00753C54
		public static void AddKeepBgm(FlatBufferBuilder builder, bool keepBgm)
		{
			builder.AddBool(8, keepBgm, false);
		}

		// Token: 0x06036D52 RID: 224594 RVA: 0x00755A5F File Offset: 0x00753C5F
		public static void AddOnlyPlayOnce(FlatBufferBuilder builder, bool onlyPlayOnce)
		{
			builder.AddBool(9, onlyPlayOnce, false);
		}

		// Token: 0x06036D53 RID: 224595 RVA: 0x00755A6B File Offset: 0x00753C6B
		public static void AddKeepInVehicle(FlatBufferBuilder builder, bool keepInVehicle)
		{
			builder.AddBool(10, keepInVehicle, false);
		}

		// Token: 0x06036D54 RID: 224596 RVA: 0x00755A77 File Offset: 0x00753C77
		public static void AddAllowMultiReference(FlatBufferBuilder builder, bool allowMultiReference)
		{
			builder.AddBool(11, allowMultiReference, false);
		}

		// Token: 0x06036D55 RID: 224597 RVA: 0x00755A83 File Offset: 0x00753C83
		public static void AddIgnoreInPlotHandBook(FlatBufferBuilder builder, bool ignoreInPlotHandBook)
		{
			builder.AddBool(12, ignoreInPlotHandBook, false);
		}

		// Token: 0x06036D56 RID: 224598 RVA: 0x00755A8F File Offset: 0x00753C8F
		public static void AddDontInterruptMatch(FlatBufferBuilder builder, bool dontInterruptMatch)
		{
			builder.AddBool(13, dontInterruptMatch, false);
		}

		// Token: 0x06036D57 RID: 224599 RVA: 0x00755A9B File Offset: 0x00753C9B
		public static void AddIsPreloadFlow(FlatBufferBuilder builder, bool isPreloadFlow)
		{
			builder.AddBool(14, isPreloadFlow, false);
		}

		// Token: 0x06036D58 RID: 224600 RVA: 0x00755AA7 File Offset: 0x00753CA7
		public static void AddIsClientFlow(FlatBufferBuilder builder, bool isClientFlow)
		{
			builder.AddBool(15, isClientFlow, false);
		}

		// Token: 0x06036D59 RID: 224601 RVA: 0x00755AB3 File Offset: 0x00753CB3
		public static void Add_ShowImport(FlatBufferBuilder builder, bool _ShowImport)
		{
			builder.AddBool(16, _ShowImport, false);
		}

		// Token: 0x06036D5A RID: 224602 RVA: 0x00755ABF File Offset: 0x00753CBF
		public static void AddPlotPos(FlatBufferBuilder builder, Offset<IPosA> plotPosOffset)
		{
			builder.AddOffset(17, plotPosOffset.Value, 0);
		}

		// Token: 0x06036D5B RID: 224603 RVA: 0x00755AD0 File Offset: 0x00753CD0
		public static void AddProgramSpecialProcess(FlatBufferBuilder builder, Offset<IStateProgramSpecialProcessChangeTeamOptimization> programSpecialProcessOffset)
		{
			builder.AddOffset(18, programSpecialProcessOffset.Value, 0);
		}

		// Token: 0x06036D5C RID: 224604 RVA: 0x00755AE1 File Offset: 0x00753CE1
		public static void AddUseConditionalText(FlatBufferBuilder builder, bool useConditionalText)
		{
			builder.AddBool(19, useConditionalText, false);
		}

		// Token: 0x06036D5D RID: 224605 RVA: 0x00755AED File Offset: 0x00753CED
		public static void Add_SelectedIndexes(FlatBufferBuilder builder, VectorOffset _SelectedIndexesOffset)
		{
			builder.AddOffset(20, _SelectedIndexesOffset.Value, 0);
		}

		// Token: 0x06036D5E RID: 224606 RVA: 0x00755B00 File Offset: 0x00753D00
		public static VectorOffset Create_SelectedIndexesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036D5F RID: 224607 RVA: 0x00755B37 File Offset: 0x00753D37
		public static VectorOffset Create_SelectedIndexesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D60 RID: 224608 RVA: 0x00755B51 File Offset: 0x00753D51
		public static VectorOffset Create_SelectedIndexesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036D61 RID: 224609 RVA: 0x00755B6F File Offset: 0x00753D6F
		public static VectorOffset Create_SelectedIndexesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036D62 RID: 224610 RVA: 0x00755B88 File Offset: 0x00753D88
		public static void Start_SelectedIndexesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036D63 RID: 224611 RVA: 0x00755B93 File Offset: 0x00753D93
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(21, nullMask, 0);
		}

		// Token: 0x06036D64 RID: 224612 RVA: 0x00755B9F File Offset: 0x00753D9F
		public static Offset<IStateInfo> EndIStateInfo(FlatBufferBuilder builder)
		{
			return new Offset<IStateInfo>(builder.EndTable());
		}

		// Token: 0x06036D65 RID: 224613 RVA: 0x00755BAC File Offset: 0x00753DAC
		public IStateInfoT UnPack()
		{
			IStateInfoT stateInfoT = new IStateInfoT();
			this.UnPackTo(stateInfoT);
			return stateInfoT;
		}

		// Token: 0x06036D66 RID: 224614 RVA: 0x00755BC8 File Offset: 0x00753DC8
		public void UnPackTo(IStateInfoT _o)
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
			_o._Folded = this._Folded;
			_o.Actions = new List<IActionInfoT>();
			for (int l = 0; l < this.ActionsLength; l++)
			{
				_o.Actions.Add((this.Actions(l) != null) ? this.Actions(l).Value.UnPack() : null);
			}
			_o.KeepBgm = this.KeepBgm;
			_o.OnlyPlayOnce = this.OnlyPlayOnce;
			_o.KeepInVehicle = this.KeepInVehicle;
			_o.AllowMultiReference = this.AllowMultiReference;
			_o.IgnoreInPlotHandBook = this.IgnoreInPlotHandBook;
			_o.DontInterruptMatch = this.DontInterruptMatch;
			_o.IsPreloadFlow = this.IsPreloadFlow;
			_o.IsClientFlow = this.IsClientFlow;
			_o._ShowImport = this._ShowImport;
			_o.PlotPos = ((this.PlotPos != null) ? this.PlotPos.Value.UnPack() : null);
			_o.ProgramSpecialProcess = ((this.ProgramSpecialProcess != null) ? this.ProgramSpecialProcess.Value.UnPack() : null);
			_o.UseConditionalText = this.UseConditionalText;
			_o._SelectedIndexes = new List<int>();
			for (int m = 0; m < this._SelectedIndexesLength; m++)
			{
				_o._SelectedIndexes.Add(this._SelectedIndexes(m));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036D67 RID: 224615 RVA: 0x00755E00 File Offset: 0x00754000
		public static Offset<IStateInfo> Pack(FlatBufferBuilder builder, IStateInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateInfo>);
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
				childrenOffset = IStateInfo.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IStateInfo.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IStateInfo.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array4 = new Offset<IActionInfo>[_o.Actions.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IActionInfo.Pack(builder, _o.Actions[l]);
				}
				actionsOffset = IStateInfo.CreateActionsVector(builder, array4);
			}
			Offset<IPosA> plotPosOffset = (_o.PlotPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.PlotPos);
			Offset<IStateProgramSpecialProcessChangeTeamOptimization> programSpecialProcessOffset = (_o.ProgramSpecialProcess == null) ? default(Offset<IStateProgramSpecialProcessChangeTeamOptimization>) : IStateProgramSpecialProcessChangeTeamOptimization.Pack(builder, _o.ProgramSpecialProcess);
			VectorOffset selectedIndexesOffset = default(VectorOffset);
			if (_o._SelectedIndexes != null)
			{
				int[] data = _o._SelectedIndexes.ToArray();
				selectedIndexesOffset = IStateInfo.Create_SelectedIndexesVector(builder, data);
			}
			return IStateInfo.CreateIStateInfo(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Id, nameOffset, _o._Folded, actionsOffset, _o.KeepBgm, _o.OnlyPlayOnce, _o.KeepInVehicle, _o.AllowMultiReference, _o.IgnoreInPlotHandBook, _o.DontInterruptMatch, _o.IsPreloadFlow, _o.IsClientFlow, _o._ShowImport, plotPosOffset, programSpecialProcessOffset, _o.UseConditionalText, selectedIndexesOffset, _o.NullMask);
		}

		// Token: 0x04012C8C RID: 76940
		private Table __p;
	}
}
