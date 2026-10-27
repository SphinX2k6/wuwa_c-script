using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BD RID: 29117
	public struct IStateInfo : IFlatbufferObject
	{
		// Token: 0x1700D83A RID: 55354
		// (get) Token: 0x06033A0E RID: 211470 RVA: 0x006F3C5E File Offset: 0x006F1E5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033A0F RID: 211471 RVA: 0x006F3C6B File Offset: 0x006F1E6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033A10 RID: 211472 RVA: 0x006F3C74 File Offset: 0x006F1E74
		public static IStateInfo GetRootAsIStateInfo(ByteBuffer _bb)
		{
			return IStateInfo.GetRootAsIStateInfo(_bb, default(IStateInfo));
		}

		// Token: 0x06033A11 RID: 211473 RVA: 0x006F3C90 File Offset: 0x006F1E90
		public static IStateInfo GetRootAsIStateInfo(ByteBuffer _bb, IStateInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033A12 RID: 211474 RVA: 0x006F3CAD File Offset: 0x006F1EAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033A13 RID: 211475 RVA: 0x006F3CBC File Offset: 0x006F1EBC
		public IStateInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D83B RID: 55355
		// (get) Token: 0x06033A14 RID: 211476 RVA: 0x006F3CCC File Offset: 0x006F1ECC
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

		// Token: 0x06033A15 RID: 211477 RVA: 0x006F3D03 File Offset: 0x006F1F03
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06033A16 RID: 211478 RVA: 0x006F3D12 File Offset: 0x006F1F12
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06033A17 RID: 211479 RVA: 0x006F3D20 File Offset: 0x006F1F20
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D83C RID: 55356
		// (get) Token: 0x06033A18 RID: 211480 RVA: 0x006F3D5C File Offset: 0x006F1F5C
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

		// Token: 0x06033A19 RID: 211481 RVA: 0x006F3D88 File Offset: 0x006F1F88
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D83D RID: 55357
		// (get) Token: 0x06033A1A RID: 211482 RVA: 0x006F3DC4 File Offset: 0x006F1FC4
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

		// Token: 0x06033A1B RID: 211483 RVA: 0x006F3DF0 File Offset: 0x006F1FF0
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D83E RID: 55358
		// (get) Token: 0x06033A1C RID: 211484 RVA: 0x006F3E2C File Offset: 0x006F202C
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

		// Token: 0x1700D83F RID: 55359
		// (get) Token: 0x06033A1D RID: 211485 RVA: 0x006F3E58 File Offset: 0x006F2058
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

		// Token: 0x1700D840 RID: 55360
		// (get) Token: 0x06033A1E RID: 211486 RVA: 0x006F3E98 File Offset: 0x006F2098
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

		// Token: 0x06033A1F RID: 211487 RVA: 0x006F3ED0 File Offset: 0x006F20D0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06033A20 RID: 211488 RVA: 0x006F3EE0 File Offset: 0x006F20E0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700D841 RID: 55361
		// (get) Token: 0x06033A21 RID: 211489 RVA: 0x006F3EF0 File Offset: 0x006F20F0
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06033A22 RID: 211490 RVA: 0x006F3F30 File Offset: 0x006F2130
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D842 RID: 55362
		// (get) Token: 0x06033A23 RID: 211491 RVA: 0x006F3F94 File Offset: 0x006F2194
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

		// Token: 0x1700D843 RID: 55363
		// (get) Token: 0x06033A24 RID: 211492 RVA: 0x006F3FC0 File Offset: 0x006F21C0
		public bool KeepBgm
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D844 RID: 55364
		// (get) Token: 0x06033A25 RID: 211493 RVA: 0x006F4000 File Offset: 0x006F2200
		public bool OnlyPlayOnce
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D845 RID: 55365
		// (get) Token: 0x06033A26 RID: 211494 RVA: 0x006F4040 File Offset: 0x006F2240
		public bool KeepInVehicle
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D846 RID: 55366
		// (get) Token: 0x06033A27 RID: 211495 RVA: 0x006F4080 File Offset: 0x006F2280
		public bool AllowMultiReference
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D847 RID: 55367
		// (get) Token: 0x06033A28 RID: 211496 RVA: 0x006F40C0 File Offset: 0x006F22C0
		public bool IgnoreInPlotHandBook
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D848 RID: 55368
		// (get) Token: 0x06033A29 RID: 211497 RVA: 0x006F4100 File Offset: 0x006F2300
		public bool DontInterruptMatch
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D849 RID: 55369
		// (get) Token: 0x06033A2A RID: 211498 RVA: 0x006F4140 File Offset: 0x006F2340
		public bool IsPreloadFlow
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D84A RID: 55370
		// (get) Token: 0x06033A2B RID: 211499 RVA: 0x006F4180 File Offset: 0x006F2380
		public bool IsClientFlow
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D84B RID: 55371
		// (get) Token: 0x06033A2C RID: 211500 RVA: 0x006F41C0 File Offset: 0x006F23C0
		public bool _ShowImport
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D84C RID: 55372
		// (get) Token: 0x06033A2D RID: 211501 RVA: 0x006F4200 File Offset: 0x006F2400
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

		// Token: 0x1700D84D RID: 55373
		// (get) Token: 0x06033A2E RID: 211502 RVA: 0x006F4260 File Offset: 0x006F2460
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

		// Token: 0x06033A2F RID: 211503 RVA: 0x006F42C0 File Offset: 0x006F24C0
		public int _SelectedIndexes(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D84E RID: 55374
		// (get) Token: 0x06033A30 RID: 211504 RVA: 0x006F4300 File Offset: 0x006F2500
		public int _SelectedIndexesLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06033A31 RID: 211505 RVA: 0x006F432C File Offset: 0x006F252C
		public Span<int> Get_SelectedIndexesBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06033A32 RID: 211506 RVA: 0x006F433C File Offset: 0x006F253C
		public int[] Get_SelectedIndexesArray()
		{
			return this.__p.__vector_as_array<int>(42);
		}

		// Token: 0x1700D84F RID: 55375
		// (get) Token: 0x06033A33 RID: 211507 RVA: 0x006F434C File Offset: 0x006F254C
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033A34 RID: 211508 RVA: 0x006F438C File Offset: 0x006F258C
		public static Offset<IStateInfo> CreateIStateInfo(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), int Id = 0, StringOffset NameOffset = default(StringOffset), bool _folded = false, VectorOffset ActionsOffset = default(VectorOffset), bool KeepBgm = false, bool OnlyPlayOnce = false, bool KeepInVehicle = false, bool AllowMultiReference = false, bool IgnoreInPlotHandBook = false, bool DontInterruptMatch = false, bool IsPreloadFlow = false, bool IsClientFlow = false, bool _showImport = false, Offset<IPosA> PlotPosOffset = default(Offset<IPosA>), Offset<IStateProgramSpecialProcessChangeTeamOptimization> ProgramSpecialProcessOffset = default(Offset<IStateProgramSpecialProcessChangeTeamOptimization>), VectorOffset _SelectedIndexesOffset = default(VectorOffset), ushort NullMask = 0)
		{
			builder.StartTable(21);
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

		// Token: 0x06033A35 RID: 211509 RVA: 0x006F444C File Offset: 0x006F264C
		public static void StartIStateInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(21);
		}

		// Token: 0x06033A36 RID: 211510 RVA: 0x006F4456 File Offset: 0x006F2656
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x06033A37 RID: 211511 RVA: 0x006F4466 File Offset: 0x006F2666
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x06033A38 RID: 211512 RVA: 0x006F4478 File Offset: 0x006F2678
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033A39 RID: 211513 RVA: 0x006F44B8 File Offset: 0x006F26B8
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A3A RID: 211514 RVA: 0x006F44D2 File Offset: 0x006F26D2
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A3B RID: 211515 RVA: 0x006F44F0 File Offset: 0x006F26F0
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033A3C RID: 211516 RVA: 0x006F4509 File Offset: 0x006F2709
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033A3D RID: 211517 RVA: 0x006F4514 File Offset: 0x006F2714
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x06033A3E RID: 211518 RVA: 0x006F4524 File Offset: 0x006F2724
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033A3F RID: 211519 RVA: 0x006F4564 File Offset: 0x006F2764
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A40 RID: 211520 RVA: 0x006F457E File Offset: 0x006F277E
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A41 RID: 211521 RVA: 0x006F459C File Offset: 0x006F279C
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033A42 RID: 211522 RVA: 0x006F45B5 File Offset: 0x006F27B5
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033A43 RID: 211523 RVA: 0x006F45C0 File Offset: 0x006F27C0
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x06033A44 RID: 211524 RVA: 0x006F45D0 File Offset: 0x006F27D0
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033A45 RID: 211525 RVA: 0x006F4610 File Offset: 0x006F2810
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A46 RID: 211526 RVA: 0x006F462A File Offset: 0x006F282A
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A47 RID: 211527 RVA: 0x006F4648 File Offset: 0x006F2848
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033A48 RID: 211528 RVA: 0x006F4661 File Offset: 0x006F2861
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033A49 RID: 211529 RVA: 0x006F466C File Offset: 0x006F286C
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(4, id, 0);
		}

		// Token: 0x06033A4A RID: 211530 RVA: 0x006F4677 File Offset: 0x006F2877
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(5, nameOffset.Value, 0);
		}

		// Token: 0x06033A4B RID: 211531 RVA: 0x006F4687 File Offset: 0x006F2887
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(6, _Folded, false);
		}

		// Token: 0x06033A4C RID: 211532 RVA: 0x006F4692 File Offset: 0x006F2892
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(7, actionsOffset.Value, 0);
		}

		// Token: 0x06033A4D RID: 211533 RVA: 0x006F46A4 File Offset: 0x006F28A4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033A4E RID: 211534 RVA: 0x006F46E4 File Offset: 0x006F28E4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A4F RID: 211535 RVA: 0x006F46FE File Offset: 0x006F28FE
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A50 RID: 211536 RVA: 0x006F471C File Offset: 0x006F291C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033A51 RID: 211537 RVA: 0x006F4735 File Offset: 0x006F2935
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033A52 RID: 211538 RVA: 0x006F4740 File Offset: 0x006F2940
		public static void AddKeepBgm(FlatBufferBuilder builder, bool keepBgm)
		{
			builder.AddBool(8, keepBgm, false);
		}

		// Token: 0x06033A53 RID: 211539 RVA: 0x006F474B File Offset: 0x006F294B
		public static void AddOnlyPlayOnce(FlatBufferBuilder builder, bool onlyPlayOnce)
		{
			builder.AddBool(9, onlyPlayOnce, false);
		}

		// Token: 0x06033A54 RID: 211540 RVA: 0x006F4757 File Offset: 0x006F2957
		public static void AddKeepInVehicle(FlatBufferBuilder builder, bool keepInVehicle)
		{
			builder.AddBool(10, keepInVehicle, false);
		}

		// Token: 0x06033A55 RID: 211541 RVA: 0x006F4763 File Offset: 0x006F2963
		public static void AddAllowMultiReference(FlatBufferBuilder builder, bool allowMultiReference)
		{
			builder.AddBool(11, allowMultiReference, false);
		}

		// Token: 0x06033A56 RID: 211542 RVA: 0x006F476F File Offset: 0x006F296F
		public static void AddIgnoreInPlotHandBook(FlatBufferBuilder builder, bool ignoreInPlotHandBook)
		{
			builder.AddBool(12, ignoreInPlotHandBook, false);
		}

		// Token: 0x06033A57 RID: 211543 RVA: 0x006F477B File Offset: 0x006F297B
		public static void AddDontInterruptMatch(FlatBufferBuilder builder, bool dontInterruptMatch)
		{
			builder.AddBool(13, dontInterruptMatch, false);
		}

		// Token: 0x06033A58 RID: 211544 RVA: 0x006F4787 File Offset: 0x006F2987
		public static void AddIsPreloadFlow(FlatBufferBuilder builder, bool isPreloadFlow)
		{
			builder.AddBool(14, isPreloadFlow, false);
		}

		// Token: 0x06033A59 RID: 211545 RVA: 0x006F4793 File Offset: 0x006F2993
		public static void AddIsClientFlow(FlatBufferBuilder builder, bool isClientFlow)
		{
			builder.AddBool(15, isClientFlow, false);
		}

		// Token: 0x06033A5A RID: 211546 RVA: 0x006F479F File Offset: 0x006F299F
		public static void Add_ShowImport(FlatBufferBuilder builder, bool _ShowImport)
		{
			builder.AddBool(16, _ShowImport, false);
		}

		// Token: 0x06033A5B RID: 211547 RVA: 0x006F47AB File Offset: 0x006F29AB
		public static void AddPlotPos(FlatBufferBuilder builder, Offset<IPosA> plotPosOffset)
		{
			builder.AddOffset(17, plotPosOffset.Value, 0);
		}

		// Token: 0x06033A5C RID: 211548 RVA: 0x006F47BC File Offset: 0x006F29BC
		public static void AddProgramSpecialProcess(FlatBufferBuilder builder, Offset<IStateProgramSpecialProcessChangeTeamOptimization> programSpecialProcessOffset)
		{
			builder.AddOffset(18, programSpecialProcessOffset.Value, 0);
		}

		// Token: 0x06033A5D RID: 211549 RVA: 0x006F47CD File Offset: 0x006F29CD
		public static void Add_SelectedIndexes(FlatBufferBuilder builder, VectorOffset _SelectedIndexesOffset)
		{
			builder.AddOffset(19, _SelectedIndexesOffset.Value, 0);
		}

		// Token: 0x06033A5E RID: 211550 RVA: 0x006F47E0 File Offset: 0x006F29E0
		public static VectorOffset Create_SelectedIndexesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033A5F RID: 211551 RVA: 0x006F4817 File Offset: 0x006F2A17
		public static VectorOffset Create_SelectedIndexesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A60 RID: 211552 RVA: 0x006F4831 File Offset: 0x006F2A31
		public static VectorOffset Create_SelectedIndexesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A61 RID: 211553 RVA: 0x006F484F File Offset: 0x006F2A4F
		public static VectorOffset Create_SelectedIndexesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033A62 RID: 211554 RVA: 0x006F4868 File Offset: 0x006F2A68
		public static void Start_SelectedIndexesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033A63 RID: 211555 RVA: 0x006F4873 File Offset: 0x006F2A73
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(20, nullMask, 0);
		}

		// Token: 0x06033A64 RID: 211556 RVA: 0x006F487F File Offset: 0x006F2A7F
		public static Offset<IStateInfo> EndIStateInfo(FlatBufferBuilder builder)
		{
			return new Offset<IStateInfo>(builder.EndTable());
		}

		// Token: 0x06033A65 RID: 211557 RVA: 0x006F488C File Offset: 0x006F2A8C
		public IStateInfoT UnPack()
		{
			IStateInfoT stateInfoT = new IStateInfoT();
			this.UnPackTo(stateInfoT);
			return stateInfoT;
		}

		// Token: 0x06033A66 RID: 211558 RVA: 0x006F48A8 File Offset: 0x006F2AA8
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
			_o._SelectedIndexes = new List<int>();
			for (int m = 0; m < this._SelectedIndexesLength; m++)
			{
				_o._SelectedIndexes.Add(this._SelectedIndexes(m));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033A67 RID: 211559 RVA: 0x006F4AD4 File Offset: 0x006F2CD4
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
			return IStateInfo.CreateIStateInfo(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Id, nameOffset, _o._Folded, actionsOffset, _o.KeepBgm, _o.OnlyPlayOnce, _o.KeepInVehicle, _o.AllowMultiReference, _o.IgnoreInPlotHandBook, _o.DontInterruptMatch, _o.IsPreloadFlow, _o.IsClientFlow, _o._ShowImport, plotPosOffset, programSpecialProcessOffset, selectedIndexesOffset, _o.NullMask);
		}

		// Token: 0x04011C8B RID: 72843
		private Table __p;
	}
}
