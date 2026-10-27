using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004871 RID: 18545
	public struct IEditorState : IFlatbufferObject
	{
		// Token: 0x1700861E RID: 34334
		// (get) Token: 0x0601CDD4 RID: 118228 RVA: 0x004146F7 File Offset: 0x004128F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CDD5 RID: 118229 RVA: 0x00414704 File Offset: 0x00412904
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CDD6 RID: 118230 RVA: 0x0041470C File Offset: 0x0041290C
		public static IEditorState GetRootAsIEditorState(ByteBuffer _bb)
		{
			return IEditorState.GetRootAsIEditorState(_bb, default(IEditorState));
		}

		// Token: 0x0601CDD7 RID: 118231 RVA: 0x00414728 File Offset: 0x00412928
		public static IEditorState GetRootAsIEditorState(ByteBuffer _bb, IEditorState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CDD8 RID: 118232 RVA: 0x00414745 File Offset: 0x00412945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CDD9 RID: 118233 RVA: 0x00414754 File Offset: 0x00412954
		public IEditorState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700861F RID: 34335
		// (get) Token: 0x0601CDDA RID: 118234 RVA: 0x00414764 File Offset: 0x00412964
		public bool IsNewJsonNameMode
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008620 RID: 34336
		// (get) Token: 0x0601CDDB RID: 118235 RVA: 0x004147A4 File Offset: 0x004129A4
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

		// Token: 0x17008621 RID: 34337
		// (get) Token: 0x0601CDDC RID: 118236 RVA: 0x004147E4 File Offset: 0x004129E4
		public bool IsLoadingArchive
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008622 RID: 34338
		// (get) Token: 0x0601CDDD RID: 118237 RVA: 0x00414824 File Offset: 0x00412A24
		public bool IsEnableBreakPoint
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008623 RID: 34339
		// (get) Token: 0x0601CDDE RID: 118238 RVA: 0x00414864 File Offset: 0x00412A64
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

		// Token: 0x0601CDDF RID: 118239 RVA: 0x0041489C File Offset: 0x00412A9C
		public Span<byte> GetPlannedBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601CDE0 RID: 118240 RVA: 0x004148AC File Offset: 0x00412AAC
		public byte[] GetPlannedBranchArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0601CDE1 RID: 118241 RVA: 0x004148BC File Offset: 0x00412ABC
		public string AutoCaptureTree(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008624 RID: 34340
		// (get) Token: 0x0601CDE2 RID: 118242 RVA: 0x004148F8 File Offset: 0x00412AF8
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

		// Token: 0x17008625 RID: 34341
		// (get) Token: 0x0601CDE3 RID: 118243 RVA: 0x00414924 File Offset: 0x00412B24
		public IEditorObjectCacheInfo? EditorObjectCacheInfo
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IEditorObjectCacheInfo?(default(IEditorObjectCacheInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008626 RID: 34342
		// (get) Token: 0x0601CDE4 RID: 118244 RVA: 0x00414984 File Offset: 0x00412B84
		public bool IsShowIndividualOwner
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008627 RID: 34343
		// (get) Token: 0x0601CDE5 RID: 118245 RVA: 0x004149C4 File Offset: 0x00412BC4
		public bool IsEnableFlowEditorTreeView
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008628 RID: 34344
		// (get) Token: 0x0601CDE6 RID: 118246 RVA: 0x00414A04 File Offset: 0x00412C04
		public bool HideMachineNotRegistedTip
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008629 RID: 34345
		// (get) Token: 0x0601CDE7 RID: 118247 RVA: 0x00414A44 File Offset: 0x00412C44
		public bool IsDefaultAddPlotConfig
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700862A RID: 34346
		// (get) Token: 0x0601CDE8 RID: 118248 RVA: 0x00414A84 File Offset: 0x00412C84
		public IEditorRestartInfo? EditorRestartInfo
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new IEditorRestartInfo?(default(IEditorRestartInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601CDE9 RID: 118249 RVA: 0x00414AE4 File Offset: 0x00412CE4
		public static Offset<IEditorState> CreateIEditorState(FlatBufferBuilder builder, bool IsNewJsonNameMode = false, long LastWorkSpaceCheckTimestamp = 0L, bool IsLoadingArchive = false, bool IsEnableBreakPoint = false, StringOffset PlannedBranchOffset = default(StringOffset), VectorOffset AutoCaptureTreeOffset = default(VectorOffset), Offset<IEditorObjectCacheInfo> EditorObjectCacheInfoOffset = default(Offset<IEditorObjectCacheInfo>), bool IsShowIndividualOwner = false, bool IsEnableFlowEditorTreeView = false, bool HideMachineNotRegistedTip = false, bool IsDefaultAddPlotConfig = false, Offset<IEditorRestartInfo> EditorRestartInfoOffset = default(Offset<IEditorRestartInfo>))
		{
			builder.StartTable(12);
			IEditorState.AddLastWorkSpaceCheckTimestamp(builder, LastWorkSpaceCheckTimestamp);
			IEditorState.AddEditorRestartInfo(builder, EditorRestartInfoOffset);
			IEditorState.AddEditorObjectCacheInfo(builder, EditorObjectCacheInfoOffset);
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

		// Token: 0x0601CDEA RID: 118250 RVA: 0x00414B5C File Offset: 0x00412D5C
		public static void StartIEditorState(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x0601CDEB RID: 118251 RVA: 0x00414B66 File Offset: 0x00412D66
		public static void AddIsNewJsonNameMode(FlatBufferBuilder builder, bool isNewJsonNameMode)
		{
			builder.AddBool(0, isNewJsonNameMode, false);
		}

		// Token: 0x0601CDEC RID: 118252 RVA: 0x00414B71 File Offset: 0x00412D71
		public static void AddLastWorkSpaceCheckTimestamp(FlatBufferBuilder builder, long lastWorkSpaceCheckTimestamp)
		{
			builder.AddLong(1, lastWorkSpaceCheckTimestamp, 0L);
		}

		// Token: 0x0601CDED RID: 118253 RVA: 0x00414B7D File Offset: 0x00412D7D
		public static void AddIsLoadingArchive(FlatBufferBuilder builder, bool isLoadingArchive)
		{
			builder.AddBool(2, isLoadingArchive, false);
		}

		// Token: 0x0601CDEE RID: 118254 RVA: 0x00414B88 File Offset: 0x00412D88
		public static void AddIsEnableBreakPoint(FlatBufferBuilder builder, bool isEnableBreakPoint)
		{
			builder.AddBool(3, isEnableBreakPoint, false);
		}

		// Token: 0x0601CDEF RID: 118255 RVA: 0x00414B93 File Offset: 0x00412D93
		public static void AddPlannedBranch(FlatBufferBuilder builder, StringOffset plannedBranchOffset)
		{
			builder.AddOffset(4, plannedBranchOffset.Value, 0);
		}

		// Token: 0x0601CDF0 RID: 118256 RVA: 0x00414BA3 File Offset: 0x00412DA3
		public static void AddAutoCaptureTree(FlatBufferBuilder builder, VectorOffset autoCaptureTreeOffset)
		{
			builder.AddOffset(5, autoCaptureTreeOffset.Value, 0);
		}

		// Token: 0x0601CDF1 RID: 118257 RVA: 0x00414BB4 File Offset: 0x00412DB4
		public static VectorOffset CreateAutoCaptureTreeVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CDF2 RID: 118258 RVA: 0x00414BF4 File Offset: 0x00412DF4
		public static VectorOffset CreateAutoCaptureTreeVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CDF3 RID: 118259 RVA: 0x00414C0E File Offset: 0x00412E0E
		public static VectorOffset CreateAutoCaptureTreeVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CDF4 RID: 118260 RVA: 0x00414C2C File Offset: 0x00412E2C
		public static VectorOffset CreateAutoCaptureTreeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CDF5 RID: 118261 RVA: 0x00414C45 File Offset: 0x00412E45
		public static void StartAutoCaptureTreeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CDF6 RID: 118262 RVA: 0x00414C50 File Offset: 0x00412E50
		public static void AddEditorObjectCacheInfo(FlatBufferBuilder builder, Offset<IEditorObjectCacheInfo> editorObjectCacheInfoOffset)
		{
			builder.AddOffset(6, editorObjectCacheInfoOffset.Value, 0);
		}

		// Token: 0x0601CDF7 RID: 118263 RVA: 0x00414C60 File Offset: 0x00412E60
		public static void AddIsShowIndividualOwner(FlatBufferBuilder builder, bool isShowIndividualOwner)
		{
			builder.AddBool(7, isShowIndividualOwner, false);
		}

		// Token: 0x0601CDF8 RID: 118264 RVA: 0x00414C6B File Offset: 0x00412E6B
		public static void AddIsEnableFlowEditorTreeView(FlatBufferBuilder builder, bool isEnableFlowEditorTreeView)
		{
			builder.AddBool(8, isEnableFlowEditorTreeView, false);
		}

		// Token: 0x0601CDF9 RID: 118265 RVA: 0x00414C76 File Offset: 0x00412E76
		public static void AddHideMachineNotRegistedTip(FlatBufferBuilder builder, bool hideMachineNotRegistedTip)
		{
			builder.AddBool(9, hideMachineNotRegistedTip, false);
		}

		// Token: 0x0601CDFA RID: 118266 RVA: 0x00414C82 File Offset: 0x00412E82
		public static void AddIsDefaultAddPlotConfig(FlatBufferBuilder builder, bool isDefaultAddPlotConfig)
		{
			builder.AddBool(10, isDefaultAddPlotConfig, false);
		}

		// Token: 0x0601CDFB RID: 118267 RVA: 0x00414C8E File Offset: 0x00412E8E
		public static void AddEditorRestartInfo(FlatBufferBuilder builder, Offset<IEditorRestartInfo> editorRestartInfoOffset)
		{
			builder.AddOffset(11, editorRestartInfoOffset.Value, 0);
		}

		// Token: 0x0601CDFC RID: 118268 RVA: 0x00414C9F File Offset: 0x00412E9F
		public static Offset<IEditorState> EndIEditorState(FlatBufferBuilder builder)
		{
			return new Offset<IEditorState>(builder.EndTable());
		}

		// Token: 0x0601CDFD RID: 118269 RVA: 0x00414CAC File Offset: 0x00412EAC
		public IEditorStateT UnPack()
		{
			IEditorStateT editorStateT = new IEditorStateT();
			this.UnPackTo(editorStateT);
			return editorStateT;
		}

		// Token: 0x0601CDFE RID: 118270 RVA: 0x00414CC8 File Offset: 0x00412EC8
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
			_o.EditorObjectCacheInfo = ((this.EditorObjectCacheInfo != null) ? this.EditorObjectCacheInfo.Value.UnPack() : null);
			_o.IsShowIndividualOwner = this.IsShowIndividualOwner;
			_o.IsEnableFlowEditorTreeView = this.IsEnableFlowEditorTreeView;
			_o.HideMachineNotRegistedTip = this.HideMachineNotRegistedTip;
			_o.IsDefaultAddPlotConfig = this.IsDefaultAddPlotConfig;
			_o.EditorRestartInfo = ((this.EditorRestartInfo != null) ? this.EditorRestartInfo.Value.UnPack() : null);
		}

		// Token: 0x0601CDFF RID: 118271 RVA: 0x00414DD0 File Offset: 0x00412FD0
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
			Offset<IEditorObjectCacheInfo> editorObjectCacheInfoOffset = (_o.EditorObjectCacheInfo == null) ? default(Offset<IEditorObjectCacheInfo>) : IEditorObjectCacheInfo.Pack(builder, _o.EditorObjectCacheInfo);
			Offset<IEditorRestartInfo> editorRestartInfoOffset = (_o.EditorRestartInfo == null) ? default(Offset<IEditorRestartInfo>) : IEditorRestartInfo.Pack(builder, _o.EditorRestartInfo);
			return IEditorState.CreateIEditorState(builder, _o.IsNewJsonNameMode, _o.LastWorkSpaceCheckTimestamp, _o.IsLoadingArchive, _o.IsEnableBreakPoint, plannedBranchOffset, autoCaptureTreeOffset, editorObjectCacheInfoOffset, _o.IsShowIndividualOwner, _o.IsEnableFlowEditorTreeView, _o.HideMachineNotRegistedTip, _o.IsDefaultAddPlotConfig, editorRestartInfoOffset);
		}

		// Token: 0x0400CE26 RID: 52774
		private Table __p;
	}
}
