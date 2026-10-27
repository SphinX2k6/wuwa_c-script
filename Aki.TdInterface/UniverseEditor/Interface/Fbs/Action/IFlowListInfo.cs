using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006819 RID: 26649
	public struct IFlowListInfo : IFlatbufferObject
	{
		// Token: 0x1700C5DD RID: 50653
		// (get) Token: 0x0602E6E2 RID: 190178 RVA: 0x0065628F File Offset: 0x0065448F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E6E3 RID: 190179 RVA: 0x0065629C File Offset: 0x0065449C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E6E4 RID: 190180 RVA: 0x006562A4 File Offset: 0x006544A4
		public static IFlowListInfo GetRootAsIFlowListInfo(ByteBuffer _bb)
		{
			return IFlowListInfo.GetRootAsIFlowListInfo(_bb, default(IFlowListInfo));
		}

		// Token: 0x0602E6E5 RID: 190181 RVA: 0x006562C0 File Offset: 0x006544C0
		public static IFlowListInfo GetRootAsIFlowListInfo(ByteBuffer _bb, IFlowListInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E6E6 RID: 190182 RVA: 0x006562DD File Offset: 0x006544DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E6E7 RID: 190183 RVA: 0x006562EC File Offset: 0x006544EC
		public IFlowListInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5DE RID: 50654
		// (get) Token: 0x0602E6E8 RID: 190184 RVA: 0x006562FC File Offset: 0x006544FC
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

		// Token: 0x0602E6E9 RID: 190185 RVA: 0x00656338 File Offset: 0x00654538
		public Record_Int_IFlowTextConfig? Texts(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_IFlowTextConfig?(default(Record_Int_IFlowTextConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C5DF RID: 50655
		// (get) Token: 0x0602E6EA RID: 190186 RVA: 0x00656398 File Offset: 0x00654598
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

		// Token: 0x0602E6EB RID: 190187 RVA: 0x006563C4 File Offset: 0x006545C4
		public IFlowInfo? Flows(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IFlowInfo?(default(IFlowInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C5E0 RID: 50656
		// (get) Token: 0x0602E6EC RID: 190188 RVA: 0x00656424 File Offset: 0x00654624
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

		// Token: 0x1700C5E1 RID: 50657
		// (get) Token: 0x0602E6ED RID: 190189 RVA: 0x00656450 File Offset: 0x00654650
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

		// Token: 0x1700C5E2 RID: 50658
		// (get) Token: 0x0602E6EE RID: 190190 RVA: 0x00656490 File Offset: 0x00654690
		public string _FilterText
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

		// Token: 0x0602E6EF RID: 190191 RVA: 0x006564C8 File Offset: 0x006546C8
		public Span<byte> Get_FilterTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602E6F0 RID: 190192 RVA: 0x006564D8 File Offset: 0x006546D8
		public byte[] Get_FilterTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700C5E3 RID: 50659
		// (get) Token: 0x0602E6F1 RID: 190193 RVA: 0x006564E8 File Offset: 0x006546E8
		public string _HighlightText
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

		// Token: 0x0602E6F2 RID: 190194 RVA: 0x00656520 File Offset: 0x00654720
		public Span<byte> Get_HighlightTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602E6F3 RID: 190195 RVA: 0x00656530 File Offset: 0x00654730
		public byte[] Get_HighlightTextArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0602E6F4 RID: 190196 RVA: 0x00656540 File Offset: 0x00654740
		public EAction _FilterActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return EAction.Undefined;
			}
			return (EAction)this.__p.bb.GetUshort(this.__p.__vector(num) + j * 2);
		}

		// Token: 0x1700C5E4 RID: 50660
		// (get) Token: 0x0602E6F5 RID: 190197 RVA: 0x00656580 File Offset: 0x00654780
		public int _FilterActionsLength
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

		// Token: 0x0602E6F6 RID: 190198 RVA: 0x006565AC File Offset: 0x006547AC
		public Span<EAction> Get_FilterActionsBytes()
		{
			return this.__p.__vector_as_span<EAction>(16, 2);
		}

		// Token: 0x0602E6F7 RID: 190199 RVA: 0x006565BC File Offset: 0x006547BC
		public EAction[] Get_FilterActionsArray()
		{
			int num = this.__p.__offset(16);
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

		// Token: 0x0602E6F8 RID: 190200 RVA: 0x00656628 File Offset: 0x00654828
		public EAction _HighlightActions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return EAction.Undefined;
			}
			return (EAction)this.__p.bb.GetUshort(this.__p.__vector(num) + j * 2);
		}

		// Token: 0x1700C5E5 RID: 50661
		// (get) Token: 0x0602E6F9 RID: 190201 RVA: 0x00656668 File Offset: 0x00654868
		public int _HighlightActionsLength
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

		// Token: 0x0602E6FA RID: 190202 RVA: 0x00656694 File Offset: 0x00654894
		public Span<EAction> Get_HighlightActionsBytes()
		{
			return this.__p.__vector_as_span<EAction>(18, 2);
		}

		// Token: 0x0602E6FB RID: 190203 RVA: 0x006566A4 File Offset: 0x006548A4
		public EAction[] Get_HighlightActionsArray()
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

		// Token: 0x1700C5E6 RID: 50662
		// (get) Token: 0x0602E6FC RID: 190204 RVA: 0x00656710 File Offset: 0x00654910
		public string _FilterEntityIdText
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E6FD RID: 190205 RVA: 0x00656748 File Offset: 0x00654948
		public Span<byte> Get_FilterEntityIdTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0602E6FE RID: 190206 RVA: 0x00656758 File Offset: 0x00654958
		public byte[] Get_FilterEntityIdTextArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x1700C5E7 RID: 50663
		// (get) Token: 0x0602E6FF RID: 190207 RVA: 0x00656768 File Offset: 0x00654968
		public string _HighlightEntityIdText
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

		// Token: 0x0602E700 RID: 190208 RVA: 0x006567A0 File Offset: 0x006549A0
		public Span<byte> Get_HighlightEntityIdTextBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0602E701 RID: 190209 RVA: 0x006567B0 File Offset: 0x006549B0
		public byte[] Get_HighlightEntityIdTextArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x0602E702 RID: 190210 RVA: 0x006567C0 File Offset: 0x006549C0
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C5E8 RID: 50664
		// (get) Token: 0x0602E703 RID: 190211 RVA: 0x006567FC File Offset: 0x006549FC
		public int _HighlightDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700C5E9 RID: 50665
		// (get) Token: 0x0602E704 RID: 190212 RVA: 0x00656828 File Offset: 0x00654A28
		public string _FocusDataPath
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E705 RID: 190213 RVA: 0x00656860 File Offset: 0x00654A60
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0602E706 RID: 190214 RVA: 0x00656870 File Offset: 0x00654A70
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(26);
		}

		// Token: 0x1700C5EA RID: 50666
		// (get) Token: 0x0602E707 RID: 190215 RVA: 0x00656880 File Offset: 0x00654A80
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E708 RID: 190216 RVA: 0x006568C0 File Offset: 0x00654AC0
		public static Offset<IFlowListInfo> CreateIFlowListInfo(FlatBufferBuilder builder, int Id = 0, VectorOffset TextsOffset = default(VectorOffset), VectorOffset FlowsOffset = default(VectorOffset), int _selectedFlowId = 0, StringOffset _filterTextOffset = default(StringOffset), StringOffset _highlightTextOffset = default(StringOffset), VectorOffset _filterActionsOffset = default(VectorOffset), VectorOffset _highlightActionsOffset = default(VectorOffset), StringOffset _filterEntityIdTextOffset = default(StringOffset), StringOffset _highlightEntityIdTextOffset = default(StringOffset), VectorOffset _highlightDataPathsOffset = default(VectorOffset), StringOffset _focusDataPathOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(13);
			IFlowListInfo.Add_FocusDataPath(builder, _focusDataPathOffset);
			IFlowListInfo.Add_HighlightDataPaths(builder, _highlightDataPathsOffset);
			IFlowListInfo.Add_HighlightEntityIdText(builder, _highlightEntityIdTextOffset);
			IFlowListInfo.Add_FilterEntityIdText(builder, _filterEntityIdTextOffset);
			IFlowListInfo.Add_HighlightActions(builder, _highlightActionsOffset);
			IFlowListInfo.Add_FilterActions(builder, _filterActionsOffset);
			IFlowListInfo.Add_HighlightText(builder, _highlightTextOffset);
			IFlowListInfo.Add_FilterText(builder, _filterTextOffset);
			IFlowListInfo.Add_SelectedFlowId(builder, _selectedFlowId);
			IFlowListInfo.AddFlows(builder, FlowsOffset);
			IFlowListInfo.AddTexts(builder, TextsOffset);
			IFlowListInfo.AddId(builder, Id);
			IFlowListInfo.AddNullMask(builder, NullMask);
			return IFlowListInfo.EndIFlowListInfo(builder);
		}

		// Token: 0x0602E709 RID: 190217 RVA: 0x00656940 File Offset: 0x00654B40
		public static void StartIFlowListInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0602E70A RID: 190218 RVA: 0x0065694A File Offset: 0x00654B4A
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602E70B RID: 190219 RVA: 0x00656955 File Offset: 0x00654B55
		public static void AddTexts(FlatBufferBuilder builder, VectorOffset textsOffset)
		{
			builder.AddOffset(1, textsOffset.Value, 0);
		}

		// Token: 0x0602E70C RID: 190220 RVA: 0x00656968 File Offset: 0x00654B68
		public static VectorOffset CreateTextsVector(FlatBufferBuilder builder, Offset<Record_Int_IFlowTextConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E70D RID: 190221 RVA: 0x006569A8 File Offset: 0x00654BA8
		public static VectorOffset CreateTextsVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_IFlowTextConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_IFlowTextConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E70E RID: 190222 RVA: 0x006569C2 File Offset: 0x00654BC2
		public static VectorOffset CreateTextsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_IFlowTextConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_IFlowTextConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E70F RID: 190223 RVA: 0x006569E0 File Offset: 0x00654BE0
		public static VectorOffset CreateTextsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_IFlowTextConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E710 RID: 190224 RVA: 0x006569F9 File Offset: 0x00654BF9
		public static void StartTextsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E711 RID: 190225 RVA: 0x00656A04 File Offset: 0x00654C04
		public static void AddFlows(FlatBufferBuilder builder, VectorOffset flowsOffset)
		{
			builder.AddOffset(2, flowsOffset.Value, 0);
		}

		// Token: 0x0602E712 RID: 190226 RVA: 0x00656A14 File Offset: 0x00654C14
		public static VectorOffset CreateFlowsVector(FlatBufferBuilder builder, Offset<IFlowInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E713 RID: 190227 RVA: 0x00656A54 File Offset: 0x00654C54
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, Offset<IFlowInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E714 RID: 190228 RVA: 0x00656A6E File Offset: 0x00654C6E
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E715 RID: 190229 RVA: 0x00656A8C File Offset: 0x00654C8C
		public static VectorOffset CreateFlowsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E716 RID: 190230 RVA: 0x00656AA5 File Offset: 0x00654CA5
		public static void StartFlowsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E717 RID: 190231 RVA: 0x00656AB0 File Offset: 0x00654CB0
		public static void Add_SelectedFlowId(FlatBufferBuilder builder, int _SelectedFlowId)
		{
			builder.AddInt(3, _SelectedFlowId, 0);
		}

		// Token: 0x0602E718 RID: 190232 RVA: 0x00656ABB File Offset: 0x00654CBB
		public static void Add_FilterText(FlatBufferBuilder builder, StringOffset _FilterTextOffset)
		{
			builder.AddOffset(4, _FilterTextOffset.Value, 0);
		}

		// Token: 0x0602E719 RID: 190233 RVA: 0x00656ACB File Offset: 0x00654CCB
		public static void Add_HighlightText(FlatBufferBuilder builder, StringOffset _HighlightTextOffset)
		{
			builder.AddOffset(5, _HighlightTextOffset.Value, 0);
		}

		// Token: 0x0602E71A RID: 190234 RVA: 0x00656ADB File Offset: 0x00654CDB
		public static void Add_FilterActions(FlatBufferBuilder builder, VectorOffset _FilterActionsOffset)
		{
			builder.AddOffset(6, _FilterActionsOffset.Value, 0);
		}

		// Token: 0x0602E71B RID: 190235 RVA: 0x00656AEC File Offset: 0x00654CEC
		public static VectorOffset Create_FilterActionsVector(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddUshort((ushort)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E71C RID: 190236 RVA: 0x00656B23 File Offset: 0x00654D23
		public static VectorOffset Create_FilterActionsVectorBlock(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E71D RID: 190237 RVA: 0x00656B3D File Offset: 0x00654D3D
		public static VectorOffset Create_FilterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<EAction> data)
		{
			builder.StartVector(2, data.Count, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E71E RID: 190238 RVA: 0x00656B5B File Offset: 0x00654D5B
		public static VectorOffset Create_FilterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E71F RID: 190239 RVA: 0x00656B74 File Offset: 0x00654D74
		public static void Start_FilterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		// Token: 0x0602E720 RID: 190240 RVA: 0x00656B7F File Offset: 0x00654D7F
		public static void Add_HighlightActions(FlatBufferBuilder builder, VectorOffset _HighlightActionsOffset)
		{
			builder.AddOffset(7, _HighlightActionsOffset.Value, 0);
		}

		// Token: 0x0602E721 RID: 190241 RVA: 0x00656B90 File Offset: 0x00654D90
		public static VectorOffset Create_HighlightActionsVector(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddUshort((ushort)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E722 RID: 190242 RVA: 0x00656BC7 File Offset: 0x00654DC7
		public static VectorOffset Create_HighlightActionsVectorBlock(FlatBufferBuilder builder, EAction[] data)
		{
			builder.StartVector(2, data.Length, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E723 RID: 190243 RVA: 0x00656BE1 File Offset: 0x00654DE1
		public static VectorOffset Create_HighlightActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<EAction> data)
		{
			builder.StartVector(2, data.Count, 2);
			builder.Add<EAction>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E724 RID: 190244 RVA: 0x00656BFF File Offset: 0x00654DFF
		public static VectorOffset Create_HighlightActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E725 RID: 190245 RVA: 0x00656C18 File Offset: 0x00654E18
		public static void Start_HighlightActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		// Token: 0x0602E726 RID: 190246 RVA: 0x00656C23 File Offset: 0x00654E23
		public static void Add_FilterEntityIdText(FlatBufferBuilder builder, StringOffset _FilterEntityIdTextOffset)
		{
			builder.AddOffset(8, _FilterEntityIdTextOffset.Value, 0);
		}

		// Token: 0x0602E727 RID: 190247 RVA: 0x00656C33 File Offset: 0x00654E33
		public static void Add_HighlightEntityIdText(FlatBufferBuilder builder, StringOffset _HighlightEntityIdTextOffset)
		{
			builder.AddOffset(9, _HighlightEntityIdTextOffset.Value, 0);
		}

		// Token: 0x0602E728 RID: 190248 RVA: 0x00656C44 File Offset: 0x00654E44
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(10, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x0602E729 RID: 190249 RVA: 0x00656C58 File Offset: 0x00654E58
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E72A RID: 190250 RVA: 0x00656C98 File Offset: 0x00654E98
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E72B RID: 190251 RVA: 0x00656CB2 File Offset: 0x00654EB2
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E72C RID: 190252 RVA: 0x00656CD0 File Offset: 0x00654ED0
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E72D RID: 190253 RVA: 0x00656CE9 File Offset: 0x00654EE9
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E72E RID: 190254 RVA: 0x00656CF4 File Offset: 0x00654EF4
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(11, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x0602E72F RID: 190255 RVA: 0x00656D05 File Offset: 0x00654F05
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0602E730 RID: 190256 RVA: 0x00656D11 File Offset: 0x00654F11
		public static Offset<IFlowListInfo> EndIFlowListInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFlowListInfo>(builder.EndTable());
		}

		// Token: 0x0602E731 RID: 190257 RVA: 0x00656D20 File Offset: 0x00654F20
		public IFlowListInfoT UnPack()
		{
			IFlowListInfoT flowListInfoT = new IFlowListInfoT();
			this.UnPackTo(flowListInfoT);
			return flowListInfoT;
		}

		// Token: 0x0602E732 RID: 190258 RVA: 0x00656D3C File Offset: 0x00654F3C
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
			_o._FilterText = this._FilterText;
			_o._HighlightText = this._HighlightText;
			_o._FilterActions = new List<EAction>();
			for (int k = 0; k < this._FilterActionsLength; k++)
			{
				_o._FilterActions.Add(this._FilterActions(k));
			}
			_o._HighlightActions = new List<EAction>();
			for (int l = 0; l < this._HighlightActionsLength; l++)
			{
				_o._HighlightActions.Add(this._HighlightActions(l));
			}
			_o._FilterEntityIdText = this._FilterEntityIdText;
			_o._HighlightEntityIdText = this._HighlightEntityIdText;
			_o._HighlightDataPaths = new List<string>();
			for (int m = 0; m < this._HighlightDataPathsLength; m++)
			{
				_o._HighlightDataPaths.Add(this._HighlightDataPaths(m));
			}
			_o._FocusDataPath = this._FocusDataPath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E733 RID: 190259 RVA: 0x00656EEC File Offset: 0x006550EC
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
				StringOffset[] array3 = new StringOffset[_o._HighlightDataPaths.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o._HighlightDataPaths[k]);
				}
				highlightDataPathsOffset = IFlowListInfo.Create_HighlightDataPathsVector(builder, array3);
			}
			StringOffset focusDataPathOffset = (_o._FocusDataPath == null) ? default(StringOffset) : builder.CreateString(_o._FocusDataPath);
			return IFlowListInfo.CreateIFlowListInfo(builder, _o.Id, textsOffset, flowsOffset, _o._SelectedFlowId, filterTextOffset, highlightTextOffset, filterActionsOffset, highlightActionsOffset, filterEntityIdTextOffset, highlightEntityIdTextOffset, highlightDataPathsOffset, focusDataPathOffset, _o.NullMask);
		}

		// Token: 0x04010F4B RID: 69451
		private Table __p;
	}
}
