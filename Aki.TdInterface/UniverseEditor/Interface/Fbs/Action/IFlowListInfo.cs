using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E99 RID: 28313
	public struct IFlowListInfo : IFlatbufferObject
	{
		// Token: 0x1700CF95 RID: 53141
		// (get) Token: 0x06030F34 RID: 200500 RVA: 0x006A3B90 File Offset: 0x006A1D90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030F35 RID: 200501 RVA: 0x006A3B9D File Offset: 0x006A1D9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030F36 RID: 200502 RVA: 0x006A3BA4 File Offset: 0x006A1DA4
		public static IFlowListInfo GetRootAsIFlowListInfo(ByteBuffer _bb)
		{
			return IFlowListInfo.GetRootAsIFlowListInfo(_bb, default(IFlowListInfo));
		}

		// Token: 0x06030F37 RID: 200503 RVA: 0x006A3BC0 File Offset: 0x006A1DC0
		public static IFlowListInfo GetRootAsIFlowListInfo(ByteBuffer _bb, IFlowListInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030F38 RID: 200504 RVA: 0x006A3BDD File Offset: 0x006A1DDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030F39 RID: 200505 RVA: 0x006A3BEC File Offset: 0x006A1DEC
		public IFlowListInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF96 RID: 53142
		// (get) Token: 0x06030F3A RID: 200506 RVA: 0x006A3BFC File Offset: 0x006A1DFC
		public int Id
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

		// Token: 0x06030F3B RID: 200507 RVA: 0x006A3C38 File Offset: 0x006A1E38
		public Record_Int_IFlowTextConfig? Texts(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_IFlowTextConfig?(default(Record_Int_IFlowTextConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CF97 RID: 53143
		// (get) Token: 0x06030F3C RID: 200508 RVA: 0x006A3C98 File Offset: 0x006A1E98
		public int TextsLength
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

		// Token: 0x06030F3D RID: 200509 RVA: 0x006A3CC4 File Offset: 0x006A1EC4
		public IFlowInfo? Flows(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IFlowInfo?(default(IFlowInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CF98 RID: 53144
		// (get) Token: 0x06030F3E RID: 200510 RVA: 0x006A3D24 File Offset: 0x006A1F24
		public int FlowsLength
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

		// Token: 0x1700CF99 RID: 53145
		// (get) Token: 0x06030F3F RID: 200511 RVA: 0x006A3D50 File Offset: 0x006A1F50
		public int _SelectedFlowId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F40 RID: 200512 RVA: 0x006A3D90 File Offset: 0x006A1F90
		public IFlowSelectedNode? _MultiSelectedNodes(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IFlowSelectedNode?(default(IFlowSelectedNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CF9A RID: 53146
		// (get) Token: 0x06030F41 RID: 200513 RVA: 0x006A3DF4 File Offset: 0x006A1FF4
		public int _MultiSelectedNodesLength
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

		// Token: 0x1700CF9B RID: 53147
		// (get) Token: 0x06030F42 RID: 200514 RVA: 0x006A3E20 File Offset: 0x006A2020
		public string _FilterText
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

		// Token: 0x06030F43 RID: 200515 RVA: 0x006A3E58 File Offset: 0x006A2058
		public Span<byte> Get_FilterTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06030F44 RID: 200516 RVA: 0x006A3E68 File Offset: 0x006A2068
		public byte[] Get_FilterTextArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700CF9C RID: 53148
		// (get) Token: 0x06030F45 RID: 200517 RVA: 0x006A3E78 File Offset: 0x006A2078
		public string _HighlightText
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F46 RID: 200518 RVA: 0x006A3EB0 File Offset: 0x006A20B0
		public Span<byte> Get_HighlightTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06030F47 RID: 200519 RVA: 0x006A3EC0 File Offset: 0x006A20C0
		public byte[] Get_HighlightTextArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x06030F48 RID: 200520 RVA: 0x006A3ED0 File Offset: 0x006A20D0
		public EAction _FilterActions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return EAction.Undefined;
			}
			return (EAction)this.__p.bb.GetUshort(this.__p.__vector(num) + j * 2);
		}

		// Token: 0x1700CF9D RID: 53149
		// (get) Token: 0x06030F49 RID: 200521 RVA: 0x006A3F10 File Offset: 0x006A2110
		public int _FilterActionsLength
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

		// Token: 0x06030F4A RID: 200522 RVA: 0x006A3F3C File Offset: 0x006A213C
		public Span<EAction> Get_FilterActionsBytes()
		{
			return this.__p.__vector_as_span<EAction>(18, 2);
		}

		// Token: 0x06030F4B RID: 200523 RVA: 0x006A3F4C File Offset: 0x006A214C
		public EAction[] Get_FilterActionsArray()
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EAction[] array = new EAction[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EAction)this.__p.bb.GetUshort(num2 + i * 2);
			}
			return array;
		}

		// Token: 0x06030F4C RID: 200524 RVA: 0x006A3FB8 File Offset: 0x006A21B8
		public EAction _HighlightActions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return EAction.Undefined;
			}
			return (EAction)this.__p.bb.GetUshort(this.__p.__vector(num) + j * 2);
		}

		// Token: 0x1700CF9E RID: 53150
		// (get) Token: 0x06030F4D RID: 200525 RVA: 0x006A3FF8 File Offset: 0x006A21F8
		public int _HighlightActionsLength
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

		// Token: 0x06030F4E RID: 200526 RVA: 0x006A4024 File Offset: 0x006A2224
		public Span<EAction> Get_HighlightActionsBytes()
		{
			return this.__p.__vector_as_span<EAction>(20, 2);
		}

		// Token: 0x06030F4F RID: 200527 RVA: 0x006A4034 File Offset: 0x006A2234
		public EAction[] Get_HighlightActionsArray()
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EAction[] array = new EAction[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EAction)this.__p.bb.GetUshort(num2 + i * 2);
			}
			return array;
		}

		// Token: 0x1700CF9F RID: 53151
		// (get) Token: 0x06030F50 RID: 200528 RVA: 0x006A40A0 File Offset: 0x006A22A0
		public string _FilterEntityIdText
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F51 RID: 200529 RVA: 0x006A40D8 File Offset: 0x006A22D8
		public Span<byte> Get_FilterEntityIdTextBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06030F52 RID: 200530 RVA: 0x006A40E8 File Offset: 0x006A22E8
		public byte[] Get_FilterEntityIdTextArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700CFA0 RID: 53152
		// (get) Token: 0x06030F53 RID: 200531 RVA: 0x006A40F8 File Offset: 0x006A22F8
		public string _HighlightEntityIdText
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F54 RID: 200532 RVA: 0x006A4130 File Offset: 0x006A2330
		public Span<byte> Get_HighlightEntityIdTextBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06030F55 RID: 200533 RVA: 0x006A4140 File Offset: 0x006A2340
		public byte[] Get_HighlightEntityIdTextArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x06030F56 RID: 200534 RVA: 0x006A4150 File Offset: 0x006A2350
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CFA1 RID: 53153
		// (get) Token: 0x06030F57 RID: 200535 RVA: 0x006A418C File Offset: 0x006A238C
		public int _HighlightDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700CFA2 RID: 53154
		// (get) Token: 0x06030F58 RID: 200536 RVA: 0x006A41B8 File Offset: 0x006A23B8
		public string _FocusDataPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F59 RID: 200537 RVA: 0x006A41F0 File Offset: 0x006A23F0
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06030F5A RID: 200538 RVA: 0x006A4200 File Offset: 0x006A2400
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(28);
		}

		// Token: 0x1700CFA3 RID: 53155
		// (get) Token: 0x06030F5B RID: 200539 RVA: 0x006A4210 File Offset: 0x006A2410
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

		// Token: 0x06030F5C RID: 200540 RVA: 0x006A4250 File Offset: 0x006A2450
		public static Offset<IFlowListInfo> CreateIFlowListInfo(FlatBufferBuilder builder, int Id = 0, VectorOffset TextsOffset = default(VectorOffset), VectorOffset FlowsOffset = default(VectorOffset), int _selectedFlowId = 0, VectorOffset _multiSelectedNodesOffset = default(VectorOffset), StringOffset _filterTextOffset = default(StringOffset), StringOffset _highlightTextOffset = default(StringOffset), VectorOffset _filterActionsOffset = default(VectorOffset), VectorOffset _highlightActionsOffset = default(VectorOffset), StringOffset _filterEntityIdTextOffset = default(StringOffset), StringOffset _highlightEntityIdTextOffset = default(StringOffset), VectorOffset _highlightDataPathsOffset = default(VectorOffset), StringOffset _focusDataPathOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(14);
			IFlowListInfo.Add_FocusDataPath(builder, _focusDataPathOffset);
			IFlowListInfo.Add_HighlightDataPaths(builder, _highlightDataPathsOffset);
			IFlowListInfo.Add_HighlightEntityIdText(builder, _highlightEntityIdTextOffset);
			IFlowListInfo.Add_FilterEntityIdText(builder, _filterEntityIdTextOffset);
			IFlowListInfo.Add_HighlightActions(builder, _highlightActionsOffset);
			IFlowListInfo.Add_FilterActions(builder, _filterActionsOffset);
			IFlowListInfo.Add_HighlightText(builder, _highlightTextOffset);
			IFlowListInfo.Add_FilterText(builder, _filterTextOffset);
			IFlowListInfo.Add_MultiSelectedNodes(builder, _multiSelectedNodesOffset);
			IFlowListInfo.Add_SelectedFlowId(builder, _selectedFlowId);
			IFlowListInfo.AddFlows(builder, FlowsOffset);
			IFlowListInfo.AddTexts(builder, TextsOffset);
			IFlowListInfo.AddId(builder, Id);
			IFlowListInfo.AddNullMask(builder, NullMask);
			return IFlowListInfo.EndIFlowListInfo(builder);
		}

		// Token: 0x06030F5D RID: 200541 RVA: 0x006A42D8 File Offset: 0x006A24D8
		public static void StartIFlowListInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06030F5E RID: 200542 RVA: 0x006A42E2 File Offset: 0x006A24E2
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06030F5F RID: 200543 RVA: 0x006A42ED File Offset: 0x006A24ED
		public static void AddTexts(FlatBufferBuilder builder, VectorOffset textsOffset)
		{
			builder.AddOffset(1, textsOffset.Value, 0);
		}

		// Token: 0x06030F60 RID: 200544 RVA: 0x006A4300 File Offset: 0x006A2500
		public static VectorOffset CreateTextsVector(FlatBufferBuilder builder, Offset<Record_Int_IFlowTextConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030F61 RID: 200545 RVA: 0x006A4340 File Offset: 0x006A2540
		public static VectorOffset CreateTextsVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_IFlowTextConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_IFlowTextConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F62 RID: 200546 RVA: 0x006A435A File Offset: 0x006A255A
		public static VectorOffset CreateTextsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_IFlowTextConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_IFlowTextConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F63 RID: 200547 RVA: 0x006A4378 File Offset: 0x006A2578
		public static VectorOffset CreateTextsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_IFlowTextConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030F64 RID: 200548 RVA: 0x006A4391 File Offset: 0x006A2591
		public static void StartTextsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030F65 RID: 200549 RVA: 0x006A439C File Offset: 0x006A259C
		public static void AddFlows(FlatBufferBuilder builder, VectorOffset flowsOffset)
		{
			builder.AddOffset(2, flowsOffset.Value, 0);
		}

		// Token: 0x06030F66 RID: 200550 RVA: 0x006A43AC File Offset: 0x006A25AC
		public static VectorOffset CreateFlowsVector(FlatBufferBuilder builder, Offset<IFlowInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030F67 RID: 200551 RVA: 0x006A43EC File Offset: 0x006A25EC
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, Offset<IFlowInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F68 RID: 200552 RVA: 0x006A4406 File Offset: 0x006A2606
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F69 RID: 200553 RVA: 0x006A4424 File Offset: 0x006A2624
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030F6A RID: 200554 RVA: 0x006A443D File Offset: 0x006A263D
		public static void StartFlowsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030F6B RID: 200555 RVA: 0x006A4448 File Offset: 0x006A2648
		public static void Add_SelectedFlowId(FlatBufferBuilder builder, int _SelectedFlowId)
		{
			builder.AddInt(3, _SelectedFlowId, 0);
		}

		// Token: 0x06030F6C RID: 200556 RVA: 0x006A4453 File Offset: 0x006A2653
		public static void Add_MultiSelectedNodes(FlatBufferBuilder builder, VectorOffset _MultiSelectedNodesOffset)
		{
			builder.AddOffset(4, _MultiSelectedNodesOffset.Value, 0);
		}

		// Token: 0x06030F6D RID: 200557 RVA: 0x006A4464 File Offset: 0x006A2664
		public static VectorOffset Create_MultiSelectedNodesVector(FlatBufferBuilder builder, Offset<IFlowSelectedNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030F6E RID: 200558 RVA: 0x006A44A4 File Offset: 0x006A26A4
		public static VectorOffset Create_MultiSelectedNodesVectorBlock(FlatBufferBuilder builder, Offset<IFlowSelectedNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowSelectedNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F6F RID: 200559 RVA: 0x006A44BE File Offset: 0x006A26BE
		public static VectorOffset Create_MultiSelectedNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowSelectedNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowSelectedNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F70 RID: 200560 RVA: 0x006A44DC File Offset: 0x006A26DC
		public static VectorOffset Create_MultiSelectedNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowSelectedNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030F71 RID: 200561 RVA: 0x006A44F5 File Offset: 0x006A26F5
		public static void Start_MultiSelectedNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030F72 RID: 200562 RVA: 0x006A4500 File Offset: 0x006A2700
		public static void Add_FilterText(FlatBufferBuilder builder, StringOffset _FilterTextOffset)
		{
			builder.AddOffset(5, _FilterTextOffset.Value, 0);
		}

		// Token: 0x06030F73 RID: 200563 RVA: 0x006A4510 File Offset: 0x006A2710
		public static void Add_HighlightText(FlatBufferBuilder builder, StringOffset _HighlightTextOffset)
		{
			builder.AddOffset(6, _HighlightTextOffset.Value, 0);
		}

		// Token: 0x06030F74 RID: 200564 RVA: 0x006A4520 File Offset: 0x006A2720
		public static void Add_FilterActions(FlatBufferBuilder builder, VectorOffset _FilterActionsOffset)
		{
			builder.AddOffset(7, _FilterActionsOffset.Value, 0);
		}

		// Token: 0x06030F75 RID: 200565 RVA: 0x006A4530 File Offset: 0x006A2730
		public static VectorOffset Create_FilterActionsVector(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddUshort((ushort)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030F76 RID: 200566 RVA: 0x006A4567 File Offset: 0x006A2767
		public static VectorOffset Create_FilterActionsVectorBlock(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F77 RID: 200567 RVA: 0x006A4581 File Offset: 0x006A2781
		public static VectorOffset Create_FilterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<EAction> data)
		{
			builder.StartVector(2, data.Count, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F78 RID: 200568 RVA: 0x006A459F File Offset: 0x006A279F
		public static VectorOffset Create_FilterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030F79 RID: 200569 RVA: 0x006A45B8 File Offset: 0x006A27B8
		public static void Start_FilterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		// Token: 0x06030F7A RID: 200570 RVA: 0x006A45C3 File Offset: 0x006A27C3
		public static void Add_HighlightActions(FlatBufferBuilder builder, VectorOffset _HighlightActionsOffset)
		{
			builder.AddOffset(8, _HighlightActionsOffset.Value, 0);
		}

		// Token: 0x06030F7B RID: 200571 RVA: 0x006A45D4 File Offset: 0x006A27D4
		public static VectorOffset Create_HighlightActionsVector(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddUshort((ushort)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030F7C RID: 200572 RVA: 0x006A460B File Offset: 0x006A280B
		public static VectorOffset Create_HighlightActionsVectorBlock(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F7D RID: 200573 RVA: 0x006A4625 File Offset: 0x006A2825
		public static VectorOffset Create_HighlightActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<EAction> data)
		{
			builder.StartVector(2, data.Count, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F7E RID: 200574 RVA: 0x006A4643 File Offset: 0x006A2843
		public static VectorOffset Create_HighlightActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030F7F RID: 200575 RVA: 0x006A465C File Offset: 0x006A285C
		public static void Start_HighlightActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		// Token: 0x06030F80 RID: 200576 RVA: 0x006A4667 File Offset: 0x006A2867
		public static void Add_FilterEntityIdText(FlatBufferBuilder builder, StringOffset _FilterEntityIdTextOffset)
		{
			builder.AddOffset(9, _FilterEntityIdTextOffset.Value, 0);
		}

		// Token: 0x06030F81 RID: 200577 RVA: 0x006A4678 File Offset: 0x006A2878
		public static void Add_HighlightEntityIdText(FlatBufferBuilder builder, StringOffset _HighlightEntityIdTextOffset)
		{
			builder.AddOffset(10, _HighlightEntityIdTextOffset.Value, 0);
		}

		// Token: 0x06030F82 RID: 200578 RVA: 0x006A4689 File Offset: 0x006A2889
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(11, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x06030F83 RID: 200579 RVA: 0x006A469C File Offset: 0x006A289C
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030F84 RID: 200580 RVA: 0x006A46DC File Offset: 0x006A28DC
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F85 RID: 200581 RVA: 0x006A46F6 File Offset: 0x006A28F6
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F86 RID: 200582 RVA: 0x006A4714 File Offset: 0x006A2914
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030F87 RID: 200583 RVA: 0x006A472D File Offset: 0x006A292D
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030F88 RID: 200584 RVA: 0x006A4738 File Offset: 0x006A2938
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(12, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x06030F89 RID: 200585 RVA: 0x006A4749 File Offset: 0x006A2949
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x06030F8A RID: 200586 RVA: 0x006A4755 File Offset: 0x006A2955
		public static Offset<IFlowListInfo> EndIFlowListInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFlowListInfo>(builder.EndTable());
		}

		// Token: 0x06030F8B RID: 200587 RVA: 0x006A4764 File Offset: 0x006A2964
		public IFlowListInfoT UnPack()
		{
			IFlowListInfoT flowListInfoT = new IFlowListInfoT();
			this.UnPackTo(flowListInfoT);
			return flowListInfoT;
		}

		// Token: 0x06030F8C RID: 200588 RVA: 0x006A4780 File Offset: 0x006A2980
		public void UnPackTo(IFlowListInfoT _o)
		{
			_o.Id = this.Id;
			_o.Texts = new List<Record_Int_IFlowTextConfigT>();
			for (int i = 0; i < this.TextsLength; i++)
			{
				_o.Texts.Add((this.Texts(i) != null) ? this.Texts(i).Value.UnPack() : null);
			}
			_o.Flows = new List<IFlowInfoT>();
			for (int j = 0; j < this.FlowsLength; j++)
			{
				_o.Flows.Add((this.Flows(j) != null) ? this.Flows(j).Value.UnPack() : null);
			}
			_o._SelectedFlowId = this._SelectedFlowId;
			_o._MultiSelectedNodes = new List<IFlowSelectedNodeT>();
			for (int k = 0; k < this._MultiSelectedNodesLength; k++)
			{
				_o._MultiSelectedNodes.Add((this._MultiSelectedNodes(k) != null) ? this._MultiSelectedNodes(k).Value.UnPack() : null);
			}
			_o._FilterText = this._FilterText;
			_o._HighlightText = this._HighlightText;
			_o._FilterActions = new List<EAction>();
			for (int l = 0; l < this._FilterActionsLength; l++)
			{
				_o._FilterActions.Add(this._FilterActions(l));
			}
			_o._HighlightActions = new List<EAction>();
			for (int m = 0; m < this._HighlightActionsLength; m++)
			{
				_o._HighlightActions.Add(this._HighlightActions(m));
			}
			_o._FilterEntityIdText = this._FilterEntityIdText;
			_o._HighlightEntityIdText = this._HighlightEntityIdText;
			_o._HighlightDataPaths = new List<string>();
			for (int n = 0; n < this._HighlightDataPathsLength; n++)
			{
				_o._HighlightDataPaths.Add(this._HighlightDataPaths(n));
			}
			_o._FocusDataPath = this._FocusDataPath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030F8D RID: 200589 RVA: 0x006A4988 File Offset: 0x006A2B88
		public static Offset<IFlowListInfo> Pack(FlatBufferBuilder builder, IFlowListInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowListInfo>);
			}
			VectorOffset textsOffset = default(VectorOffset);
			if (_o.Texts != null)
			{
				Offset<Record_Int_IFlowTextConfig>[] array = new Offset<Record_Int_IFlowTextConfig>[_o.Texts.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Record_Int_IFlowTextConfig.Pack(builder, _o.Texts[i]);
				}
				textsOffset = IFlowListInfo.CreateTextsVector(builder, array);
			}
			VectorOffset flowsOffset = default(VectorOffset);
			if (_o.Flows != null)
			{
				Offset<IFlowInfo>[] array2 = new Offset<IFlowInfo>[_o.Flows.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IFlowInfo.Pack(builder, _o.Flows[j]);
				}
				flowsOffset = IFlowListInfo.CreateFlowsVector(builder, array2);
			}
			VectorOffset multiSelectedNodesOffset = default(VectorOffset);
			if (_o._MultiSelectedNodes != null)
			{
				Offset<IFlowSelectedNode>[] array3 = new Offset<IFlowSelectedNode>[_o._MultiSelectedNodes.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IFlowSelectedNode.Pack(builder, _o._MultiSelectedNodes[k]);
				}
				multiSelectedNodesOffset = IFlowListInfo.Create_MultiSelectedNodesVector(builder, array3);
			}
			StringOffset filterTextOffset = (_o._FilterText == null) ? default(StringOffset) : builder.CreateString(_o._FilterText);
			StringOffset highlightTextOffset = (_o._HighlightText == null) ? default(StringOffset) : builder.CreateString(_o._HighlightText);
			VectorOffset filterActionsOffset = default(VectorOffset);
			if (_o._FilterActions != null)
			{
				EAction[] data = _o._FilterActions.ToArray();
				filterActionsOffset = IFlowListInfo.Create_FilterActionsVector(builder, data);
			}
			VectorOffset highlightActionsOffset = default(VectorOffset);
			if (_o._HighlightActions != null)
			{
				EAction[] data2 = _o._HighlightActions.ToArray();
				highlightActionsOffset = IFlowListInfo.Create_HighlightActionsVector(builder, data2);
			}
			StringOffset filterEntityIdTextOffset = (_o._FilterEntityIdText == null) ? default(StringOffset) : builder.CreateString(_o._FilterEntityIdText);
			StringOffset highlightEntityIdTextOffset = (_o._HighlightEntityIdText == null) ? default(StringOffset) : builder.CreateString(_o._HighlightEntityIdText);
			VectorOffset highlightDataPathsOffset = default(VectorOffset);
			if (_o._HighlightDataPaths != null)
			{
				StringOffset[] array4 = new StringOffset[_o._HighlightDataPaths.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = builder.CreateString(_o._HighlightDataPaths[l]);
				}
				highlightDataPathsOffset = IFlowListInfo.Create_HighlightDataPathsVector(builder, array4);
			}
			StringOffset focusDataPathOffset = (_o._FocusDataPath == null) ? default(StringOffset) : builder.CreateString(_o._FocusDataPath);
			return IFlowListInfo.CreateIFlowListInfo(builder, _o.Id, textsOffset, flowsOffset, _o._SelectedFlowId, multiSelectedNodesOffset, filterTextOffset, highlightTextOffset, filterActionsOffset, highlightActionsOffset, filterEntityIdTextOffset, highlightEntityIdTextOffset, highlightDataPathsOffset, focusDataPathOffset, _o.NullMask);
		}

		// Token: 0x04011D7E RID: 73086
		private Table __p;
	}
}
