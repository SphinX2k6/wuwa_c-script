using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CD6 RID: 19670
	public struct IEditorState : IFlatbufferObject
	{
		// Token: 0x17008C68 RID: 35944
		// (get) Token: 0x0601E5C5 RID: 124357 RVA: 0x00440F9F File Offset: 0x0043F19F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E5C6 RID: 124358 RVA: 0x00440FAC File Offset: 0x0043F1AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E5C7 RID: 124359 RVA: 0x00440FB4 File Offset: 0x0043F1B4
		public static IEditorState GetRootAsIEditorState(ByteBuffer _bb)
		{
			return IEditorState.GetRootAsIEditorState(_bb, default(IEditorState));
		}

		// Token: 0x0601E5C8 RID: 124360 RVA: 0x00440FD0 File Offset: 0x0043F1D0
		public static IEditorState GetRootAsIEditorState(ByteBuffer _bb, IEditorState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E5C9 RID: 124361 RVA: 0x00440FED File Offset: 0x0043F1ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E5CA RID: 124362 RVA: 0x00440FFC File Offset: 0x0043F1FC
		public IEditorState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C69 RID: 35945
		// (get) Token: 0x0601E5CB RID: 124363 RVA: 0x0044100C File Offset: 0x0043F20C
		public bool IsNewJsonNameMode
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C6A RID: 35946
		// (get) Token: 0x0601E5CC RID: 124364 RVA: 0x0044104C File Offset: 0x0043F24C
		public long LastWorkSpaceCheckTimestamp
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C6B RID: 35947
		// (get) Token: 0x0601E5CD RID: 124365 RVA: 0x0044108C File Offset: 0x0043F28C
		public bool IsLoadingArchive
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C6C RID: 35948
		// (get) Token: 0x0601E5CE RID: 124366 RVA: 0x004410CC File Offset: 0x0043F2CC
		public bool IsEnableBreakPoint
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C6D RID: 35949
		// (get) Token: 0x0601E5CF RID: 124367 RVA: 0x0044110C File Offset: 0x0043F30C
		public string PlannedBranch
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

		// Token: 0x0601E5D0 RID: 124368 RVA: 0x00441144 File Offset: 0x0043F344
		public Span<byte> GetPlannedBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601E5D1 RID: 124369 RVA: 0x00441154 File Offset: 0x0043F354
		public byte[] GetPlannedBranchArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0601E5D2 RID: 124370 RVA: 0x00441164 File Offset: 0x0043F364
		public string AutoCaptureTree(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008C6E RID: 35950
		// (get) Token: 0x0601E5D3 RID: 124371 RVA: 0x004411A0 File Offset: 0x0043F3A0
		public int AutoCaptureTreeLength
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

		// Token: 0x17008C6F RID: 35951
		// (get) Token: 0x0601E5D4 RID: 124372 RVA: 0x004411CC File Offset: 0x0043F3CC
		public bool IsShowIndividualOwner
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C70 RID: 35952
		// (get) Token: 0x0601E5D5 RID: 124373 RVA: 0x0044120C File Offset: 0x0043F40C
		public bool IsEnableFlowEditorTreeView
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C71 RID: 35953
		// (get) Token: 0x0601E5D6 RID: 124374 RVA: 0x0044124C File Offset: 0x0043F44C
		public bool HideMachineNotRegistedTip
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C72 RID: 35954
		// (get) Token: 0x0601E5D7 RID: 124375 RVA: 0x0044128C File Offset: 0x0043F48C
		public bool IsDefaultAddPlotConfig
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C73 RID: 35955
		// (get) Token: 0x0601E5D8 RID: 124376 RVA: 0x004412CC File Offset: 0x0043F4CC
		public IEditorRestartInfo? EditorRestartInfo
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IEditorRestartInfo?(default(IEditorRestartInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601E5D9 RID: 124377 RVA: 0x0044132C File Offset: 0x0043F52C
		public static Offset<IEditorState> CreateIEditorState(FlatBufferBuilder builder, bool IsNewJsonNameMode = false, long LastWorkSpaceCheckTimestamp = 0L, bool IsLoadingArchive = false, bool IsEnableBreakPoint = false, StringOffset PlannedBranchOffset = default(StringOffset), VectorOffset AutoCaptureTreeOffset = default(VectorOffset), bool IsShowIndividualOwner = false, bool IsEnableFlowEditorTreeView = false, bool HideMachineNotRegistedTip = false, bool IsDefaultAddPlotConfig = false, Offset<IEditorRestartInfo> EditorRestartInfoOffset = default(Offset<IEditorRestartInfo>))
		{
			builder.StartTable(11);
			IEditorState.AddLastWorkSpaceCheckTimestamp(builder, LastWorkSpaceCheckTimestamp);
			IEditorState.AddEditorRestartInfo(builder, EditorRestartInfoOffset);
			IEditorState.AddAutoCaptureTree(builder, AutoCaptureTreeOffset);
			IEditorState.AddPlannedBranch(builder, PlannedBranchOffset);
			IEditorState.AddIsDefaultAddPlotConfig(builder, IsDefaultAddPlotConfig);
			IEditorState.AddHideMachineNotRegistedTip(builder, HideMachineNotRegistedTip);
			IEditorState.AddIsEnableFlowEditorTreeView(builder, IsEnableFlowEditorTreeView);
			IEditorState.AddIsShowIndividualOwner(builder, IsShowIndividualOwner);
			IEditorState.AddIsEnableBreakPoint(builder, IsEnableBreakPoint);
			IEditorState.AddIsLoadingArchive(builder, IsLoadingArchive);
			IEditorState.AddIsNewJsonNameMode(builder, IsNewJsonNameMode);
			return IEditorState.EndIEditorState(builder);
		}

		// Token: 0x0601E5DA RID: 124378 RVA: 0x0044139C File Offset: 0x0043F59C
		public static void StartIEditorState(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0601E5DB RID: 124379 RVA: 0x004413A6 File Offset: 0x0043F5A6
		public static void AddIsNewJsonNameMode(FlatBufferBuilder builder, bool isNewJsonNameMode)
		{
			builder.AddBool(0, isNewJsonNameMode, false);
		}

		// Token: 0x0601E5DC RID: 124380 RVA: 0x004413B1 File Offset: 0x0043F5B1
		public static void AddLastWorkSpaceCheckTimestamp(FlatBufferBuilder builder, long lastWorkSpaceCheckTimestamp)
		{
			builder.AddLong(1, lastWorkSpaceCheckTimestamp, 0L);
		}

		// Token: 0x0601E5DD RID: 124381 RVA: 0x004413BD File Offset: 0x0043F5BD
		public static void AddIsLoadingArchive(FlatBufferBuilder builder, bool isLoadingArchive)
		{
			builder.AddBool(2, isLoadingArchive, false);
		}

		// Token: 0x0601E5DE RID: 124382 RVA: 0x004413C8 File Offset: 0x0043F5C8
		public static void AddIsEnableBreakPoint(FlatBufferBuilder builder, bool isEnableBreakPoint)
		{
			builder.AddBool(3, isEnableBreakPoint, false);
		}

		// Token: 0x0601E5DF RID: 124383 RVA: 0x004413D3 File Offset: 0x0043F5D3
		public static void AddPlannedBranch(FlatBufferBuilder builder, StringOffset plannedBranchOffset)
		{
			builder.AddOffset(4, plannedBranchOffset.Value, 0);
		}

		// Token: 0x0601E5E0 RID: 124384 RVA: 0x004413E3 File Offset: 0x0043F5E3
		public static void AddAutoCaptureTree(FlatBufferBuilder builder, VectorOffset autoCaptureTreeOffset)
		{
			builder.AddOffset(5, autoCaptureTreeOffset.Value, 0);
		}

		// Token: 0x0601E5E1 RID: 124385 RVA: 0x004413F4 File Offset: 0x0043F5F4
		public static VectorOffset CreateAutoCaptureTreeVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E5E2 RID: 124386 RVA: 0x00441434 File Offset: 0x0043F634
		public static VectorOffset CreateAutoCaptureTreeVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E5E3 RID: 124387 RVA: 0x0044144E File Offset: 0x0043F64E
		public static VectorOffset CreateAutoCaptureTreeVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E5E4 RID: 124388 RVA: 0x0044146C File Offset: 0x0043F66C
		public static VectorOffset CreateAutoCaptureTreeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E5E5 RID: 124389 RVA: 0x00441485 File Offset: 0x0043F685
		public static void StartAutoCaptureTreeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E5E6 RID: 124390 RVA: 0x00441490 File Offset: 0x0043F690
		public static void AddIsShowIndividualOwner(FlatBufferBuilder builder, bool isShowIndividualOwner)
		{
			builder.AddBool(6, isShowIndividualOwner, false);
		}

		// Token: 0x0601E5E7 RID: 124391 RVA: 0x0044149B File Offset: 0x0043F69B
		public static void AddIsEnableFlowEditorTreeView(FlatBufferBuilder builder, bool isEnableFlowEditorTreeView)
		{
			builder.AddBool(7, isEnableFlowEditorTreeView, false);
		}

		// Token: 0x0601E5E8 RID: 124392 RVA: 0x004414A6 File Offset: 0x0043F6A6
		public static void AddHideMachineNotRegistedTip(FlatBufferBuilder builder, bool hideMachineNotRegistedTip)
		{
			builder.AddBool(8, hideMachineNotRegistedTip, false);
		}

		// Token: 0x0601E5E9 RID: 124393 RVA: 0x004414B1 File Offset: 0x0043F6B1
		public static void AddIsDefaultAddPlotConfig(FlatBufferBuilder builder, bool isDefaultAddPlotConfig)
		{
			builder.AddBool(9, isDefaultAddPlotConfig, false);
		}

		// Token: 0x0601E5EA RID: 124394 RVA: 0x004414BD File Offset: 0x0043F6BD
		public static void AddEditorRestartInfo(FlatBufferBuilder builder, Offset<IEditorRestartInfo> editorRestartInfoOffset)
		{
			builder.AddOffset(10, editorRestartInfoOffset.Value, 0);
		}

		// Token: 0x0601E5EB RID: 124395 RVA: 0x004414CE File Offset: 0x0043F6CE
		public static Offset<IEditorState> EndIEditorState(FlatBufferBuilder builder)
		{
			return new Offset<IEditorState>(builder.EndTable());
		}

		// Token: 0x0601E5EC RID: 124396 RVA: 0x004414DC File Offset: 0x0043F6DC
		public IEditorStateT UnPack()
		{
			IEditorStateT editorStateT = new IEditorStateT();
			this.UnPackTo(editorStateT);
			return editorStateT;
		}

		// Token: 0x0601E5ED RID: 124397 RVA: 0x004414F8 File Offset: 0x0043F6F8
		public void UnPackTo(IEditorStateT _o)
		{
			_o.IsNewJsonNameMode = this.IsNewJsonNameMode;
			_o.LastWorkSpaceCheckTimestamp = this.LastWorkSpaceCheckTimestamp;
			_o.IsLoadingArchive = this.IsLoadingArchive;
			_o.IsEnableBreakPoint = this.IsEnableBreakPoint;
			_o.PlannedBranch = this.PlannedBranch;
			_o.AutoCaptureTree = new List<string>();
			for (int i = 0; i < this.AutoCaptureTreeLength; i++)
			{
				_o.AutoCaptureTree.Add(this.AutoCaptureTree(i));
			}
			_o.IsShowIndividualOwner = this.IsShowIndividualOwner;
			_o.IsEnableFlowEditorTreeView = this.IsEnableFlowEditorTreeView;
			_o.HideMachineNotRegistedTip = this.HideMachineNotRegistedTip;
			_o.IsDefaultAddPlotConfig = this.IsDefaultAddPlotConfig;
			_o.EditorRestartInfo = ((this.EditorRestartInfo != null) ? this.EditorRestartInfo.Value.UnPack() : null);
		}

		// Token: 0x0601E5EE RID: 124398 RVA: 0x004415D0 File Offset: 0x0043F7D0
		public static Offset<IEditorState> Pack(FlatBufferBuilder builder, IEditorStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorState>);
			}
			StringOffset plannedBranchOffset = (_o.PlannedBranch == null) ? default(StringOffset) : builder.CreateString(_o.PlannedBranch);
			VectorOffset autoCaptureTreeOffset = default(VectorOffset);
			if (_o.AutoCaptureTree != null)
			{
				StringOffset[] array = new StringOffset[_o.AutoCaptureTree.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.AutoCaptureTree[i]);
				}
				autoCaptureTreeOffset = IEditorState.CreateAutoCaptureTreeVector(builder, array);
			}
			Offset<IEditorRestartInfo> editorRestartInfoOffset = (_o.EditorRestartInfo == null) ? default(Offset<IEditorRestartInfo>) : IEditorRestartInfo.Pack(builder, _o.EditorRestartInfo);
			return IEditorState.CreateIEditorState(builder, _o.IsNewJsonNameMode, _o.LastWorkSpaceCheckTimestamp, _o.IsLoadingArchive, _o.IsEnableBreakPoint, plannedBranchOffset, autoCaptureTreeOffset, _o.IsShowIndividualOwner, _o.IsEnableFlowEditorTreeView, _o.HideMachineNotRegistedTip, _o.IsDefaultAddPlotConfig, editorRestartInfoOffset);
		}

		// Token: 0x0400D860 RID: 55392
		private Table __p;
	}
}
