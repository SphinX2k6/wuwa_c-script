using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E77 RID: 20087
	public struct IAiComponent : IFlatbufferObject
	{
		// Token: 0x17008FD8 RID: 36824
		// (get) Token: 0x0601F8F4 RID: 129268 RVA: 0x00465150 File Offset: 0x00463350
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F8F5 RID: 129269 RVA: 0x0046515D File Offset: 0x0046335D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F8F6 RID: 129270 RVA: 0x00465164 File Offset: 0x00463364
		public static IAiComponent GetRootAsIAiComponent(ByteBuffer _bb)
		{
			return IAiComponent.GetRootAsIAiComponent(_bb, default(IAiComponent));
		}

		// Token: 0x0601F8F7 RID: 129271 RVA: 0x00465180 File Offset: 0x00463380
		public static IAiComponent GetRootAsIAiComponent(ByteBuffer _bb, IAiComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F8F8 RID: 129272 RVA: 0x0046519D File Offset: 0x0046339D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F8F9 RID: 129273 RVA: 0x004651AC File Offset: 0x004633AC
		public IAiComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FD9 RID: 36825
		// (get) Token: 0x0601F8FA RID: 129274 RVA: 0x004651BC File Offset: 0x004633BC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008FDA RID: 36826
		// (get) Token: 0x0601F8FB RID: 129275 RVA: 0x004651FC File Offset: 0x004633FC
		public int AiId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FDB RID: 36827
		// (get) Token: 0x0601F8FC RID: 129276 RVA: 0x00465238 File Offset: 0x00463438
		public IPatrol? Patrol
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPatrol?(default(IPatrol).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008FDC RID: 36828
		// (get) Token: 0x0601F8FD RID: 129277 RVA: 0x00465298 File Offset: 0x00463498
		public TInitState InitStateType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TInitState.NONE;
				}
				return (TInitState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F8FE RID: 129278 RVA: 0x004652D8 File Offset: 0x004634D8
		public TTable? InitState<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F8FF RID: 129279 RVA: 0x00465320 File Offset: 0x00463520
		public IInitStateBarrierLock InitStateAsIInitStateBarrierLock()
		{
			return this.InitState<IInitStateBarrierLock>().Value;
		}

		// Token: 0x0601F900 RID: 129280 RVA: 0x0046533C File Offset: 0x0046353C
		public IInitStateBirth InitStateAsIInitStateBirth()
		{
			return this.InitState<IInitStateBirth>().Value;
		}

		// Token: 0x0601F901 RID: 129281 RVA: 0x00465358 File Offset: 0x00463558
		public IInitStateDigital InitStateAsIInitStateDigital()
		{
			return this.InitState<IInitStateDigital>().Value;
		}

		// Token: 0x0601F902 RID: 129282 RVA: 0x00465374 File Offset: 0x00463574
		public IInitStateMagneticStorm InitStateAsIInitStateMagneticStorm()
		{
			return this.InitState<IInitStateMagneticStorm>().Value;
		}

		// Token: 0x0601F903 RID: 129283 RVA: 0x00465390 File Offset: 0x00463590
		public IInitStateStandby InitStateAsIInitStateStandby()
		{
			return this.InitState<IInitStateStandby>().Value;
		}

		// Token: 0x0601F904 RID: 129284 RVA: 0x004653AC File Offset: 0x004635AC
		public IInitStateWuYinQu InitStateAsIInitStateWuYinQu()
		{
			return this.InitState<IInitStateWuYinQu>().Value;
		}

		// Token: 0x17008FDD RID: 36829
		// (get) Token: 0x0601F905 RID: 129285 RVA: 0x004653C8 File Offset: 0x004635C8
		public int CenterPoint
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F906 RID: 129286 RVA: 0x00465408 File Offset: 0x00463608
		public TBlackBoard InitBlackBoardType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TBlackBoard.NONE;
			}
			return (TBlackBoard)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008FDE RID: 36830
		// (get) Token: 0x0601F907 RID: 129287 RVA: 0x00465448 File Offset: 0x00463648
		public int InitBlackBoardTypeLength
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

		// Token: 0x0601F908 RID: 129288 RVA: 0x00465474 File Offset: 0x00463674
		public Span<TBlackBoard> GetInitBlackBoardTypeBytes()
		{
			return this.__p.__vector_as_span<TBlackBoard>(16, 1);
		}

		// Token: 0x0601F909 RID: 129289 RVA: 0x00465484 File Offset: 0x00463684
		public TBlackBoard[] GetInitBlackBoardTypeArray()
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TBlackBoard[] array = new TBlackBoard[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TBlackBoard)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601F90A RID: 129290 RVA: 0x004654F0 File Offset: 0x004636F0
		public TTable? InitBlackBoard<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008FDF RID: 36831
		// (get) Token: 0x0601F90B RID: 129291 RVA: 0x00465538 File Offset: 0x00463738
		public int InitBlackBoardLength
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

		// Token: 0x17008FE0 RID: 36832
		// (get) Token: 0x0601F90C RID: 129292 RVA: 0x00465564 File Offset: 0x00463764
		public string WeaponId
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

		// Token: 0x0601F90D RID: 129293 RVA: 0x0046559C File Offset: 0x0046379C
		public Span<byte> GetWeaponIdBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601F90E RID: 129294 RVA: 0x004655AC File Offset: 0x004637AC
		public byte[] GetWeaponIdArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x17008FE1 RID: 36833
		// (get) Token: 0x0601F90F RID: 129295 RVA: 0x004655BC File Offset: 0x004637BC
		public int AiTeamLevelId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F910 RID: 129296 RVA: 0x004655FC File Offset: 0x004637FC
		public IStateRepPerfItem? StateRepPerfList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IStateRepPerfItem?(default(IStateRepPerfItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008FE2 RID: 36834
		// (get) Token: 0x0601F911 RID: 129297 RVA: 0x00465660 File Offset: 0x00463860
		public int StateRepPerfListLength
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

		// Token: 0x17008FE3 RID: 36835
		// (get) Token: 0x0601F912 RID: 129298 RVA: 0x0046568C File Offset: 0x0046388C
		public IAiAlertSystemConfig? AlertSystemConfig
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new IAiAlertSystemConfig?(default(IAiAlertSystemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008FE4 RID: 36836
		// (get) Token: 0x0601F913 RID: 129299 RVA: 0x004656EC File Offset: 0x004638EC
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

		// Token: 0x0601F914 RID: 129300 RVA: 0x0046572C File Offset: 0x0046392C
		public static Offset<IAiComponent> CreateIAiComponent(FlatBufferBuilder builder, bool Disabled = false, int AiId = 0, Offset<IPatrol> PatrolOffset = default(Offset<IPatrol>), TInitState InitState_type = TInitState.NONE, int InitStateOffset = 0, int CenterPoint = 0, VectorOffset InitBlackBoard_typeOffset = default(VectorOffset), VectorOffset InitBlackBoardOffset = default(VectorOffset), StringOffset WeaponIdOffset = default(StringOffset), int AiTeamLevelId = 0, VectorOffset StateRepPerfListOffset = default(VectorOffset), Offset<IAiAlertSystemConfig> AlertSystemConfigOffset = default(Offset<IAiAlertSystemConfig>), byte NullMask = 0)
		{
			builder.StartTable(13);
			IAiComponent.AddAlertSystemConfig(builder, AlertSystemConfigOffset);
			IAiComponent.AddStateRepPerfList(builder, StateRepPerfListOffset);
			IAiComponent.AddAiTeamLevelId(builder, AiTeamLevelId);
			IAiComponent.AddWeaponId(builder, WeaponIdOffset);
			IAiComponent.AddInitBlackBoard(builder, InitBlackBoardOffset);
			IAiComponent.AddInitBlackBoardType(builder, InitBlackBoard_typeOffset);
			IAiComponent.AddCenterPoint(builder, CenterPoint);
			IAiComponent.AddInitState(builder, InitStateOffset);
			IAiComponent.AddPatrol(builder, PatrolOffset);
			IAiComponent.AddAiId(builder, AiId);
			IAiComponent.AddNullMask(builder, NullMask);
			IAiComponent.AddInitStateType(builder, InitState_type);
			IAiComponent.AddDisabled(builder, Disabled);
			return IAiComponent.EndIAiComponent(builder);
		}

		// Token: 0x0601F915 RID: 129301 RVA: 0x004657AC File Offset: 0x004639AC
		public static void StartIAiComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0601F916 RID: 129302 RVA: 0x004657B6 File Offset: 0x004639B6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601F917 RID: 129303 RVA: 0x004657C1 File Offset: 0x004639C1
		public static void AddAiId(FlatBufferBuilder builder, int aiId)
		{
			builder.AddInt(1, aiId, 0);
		}

		// Token: 0x0601F918 RID: 129304 RVA: 0x004657CC File Offset: 0x004639CC
		public static void AddPatrol(FlatBufferBuilder builder, Offset<IPatrol> patrolOffset)
		{
			builder.AddOffset(2, patrolOffset.Value, 0);
		}

		// Token: 0x0601F919 RID: 129305 RVA: 0x004657DC File Offset: 0x004639DC
		public static void AddInitStateType(FlatBufferBuilder builder, TInitState initStateType)
		{
			builder.AddByte(3, (byte)initStateType, 0);
		}

		// Token: 0x0601F91A RID: 129306 RVA: 0x004657E7 File Offset: 0x004639E7
		public static void AddInitState(FlatBufferBuilder builder, int initStateOffset)
		{
			builder.AddOffset(4, initStateOffset, 0);
		}

		// Token: 0x0601F91B RID: 129307 RVA: 0x004657F2 File Offset: 0x004639F2
		public static void AddCenterPoint(FlatBufferBuilder builder, int centerPoint)
		{
			builder.AddInt(5, centerPoint, 0);
		}

		// Token: 0x0601F91C RID: 129308 RVA: 0x004657FD File Offset: 0x004639FD
		public static void AddInitBlackBoardType(FlatBufferBuilder builder, VectorOffset initBlackBoardTypeOffset)
		{
			builder.AddOffset(6, initBlackBoardTypeOffset.Value, 0);
		}

		// Token: 0x0601F91D RID: 129309 RVA: 0x00465810 File Offset: 0x00463A10
		public static VectorOffset CreateInitBlackBoardTypeVector(FlatBufferBuilder builder, TBlackBoard[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F91E RID: 129310 RVA: 0x00465847 File Offset: 0x00463A47
		public static VectorOffset CreateInitBlackBoardTypeVectorBlock(FlatBufferBuilder builder, TBlackBoard[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBlackBoard>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F91F RID: 129311 RVA: 0x00465861 File Offset: 0x00463A61
		public static VectorOffset CreateInitBlackBoardTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBlackBoard> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBlackBoard>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F920 RID: 129312 RVA: 0x0046587F File Offset: 0x00463A7F
		public static VectorOffset CreateInitBlackBoardTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBlackBoard>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F921 RID: 129313 RVA: 0x00465898 File Offset: 0x00463A98
		public static void StartInitBlackBoardTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601F922 RID: 129314 RVA: 0x004658A3 File Offset: 0x00463AA3
		public static void AddInitBlackBoard(FlatBufferBuilder builder, VectorOffset initBlackBoardOffset)
		{
			builder.AddOffset(7, initBlackBoardOffset.Value, 0);
		}

		// Token: 0x0601F923 RID: 129315 RVA: 0x004658B4 File Offset: 0x00463AB4
		public static VectorOffset CreateInitBlackBoardVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F924 RID: 129316 RVA: 0x004658EB File Offset: 0x00463AEB
		public static VectorOffset CreateInitBlackBoardVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F925 RID: 129317 RVA: 0x00465905 File Offset: 0x00463B05
		public static VectorOffset CreateInitBlackBoardVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F926 RID: 129318 RVA: 0x00465923 File Offset: 0x00463B23
		public static VectorOffset CreateInitBlackBoardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F927 RID: 129319 RVA: 0x0046593C File Offset: 0x00463B3C
		public static void StartInitBlackBoardVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F928 RID: 129320 RVA: 0x00465947 File Offset: 0x00463B47
		public static void AddWeaponId(FlatBufferBuilder builder, StringOffset weaponIdOffset)
		{
			builder.AddOffset(8, weaponIdOffset.Value, 0);
		}

		// Token: 0x0601F929 RID: 129321 RVA: 0x00465957 File Offset: 0x00463B57
		public static void AddAiTeamLevelId(FlatBufferBuilder builder, int aiTeamLevelId)
		{
			builder.AddInt(9, aiTeamLevelId, 0);
		}

		// Token: 0x0601F92A RID: 129322 RVA: 0x00465963 File Offset: 0x00463B63
		public static void AddStateRepPerfList(FlatBufferBuilder builder, VectorOffset stateRepPerfListOffset)
		{
			builder.AddOffset(10, stateRepPerfListOffset.Value, 0);
		}

		// Token: 0x0601F92B RID: 129323 RVA: 0x00465974 File Offset: 0x00463B74
		public static VectorOffset CreateStateRepPerfListVector(FlatBufferBuilder builder, Offset<IStateRepPerfItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F92C RID: 129324 RVA: 0x004659B4 File Offset: 0x00463BB4
		public static VectorOffset CreateStateRepPerfListVectorBlock(FlatBufferBuilder builder, Offset<IStateRepPerfItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateRepPerfItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F92D RID: 129325 RVA: 0x004659CE File Offset: 0x00463BCE
		public static VectorOffset CreateStateRepPerfListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateRepPerfItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateRepPerfItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F92E RID: 129326 RVA: 0x004659EC File Offset: 0x00463BEC
		public static VectorOffset CreateStateRepPerfListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateRepPerfItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F92F RID: 129327 RVA: 0x00465A05 File Offset: 0x00463C05
		public static void StartStateRepPerfListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F930 RID: 129328 RVA: 0x00465A10 File Offset: 0x00463C10
		public static void AddAlertSystemConfig(FlatBufferBuilder builder, Offset<IAiAlertSystemConfig> alertSystemConfigOffset)
		{
			builder.AddOffset(11, alertSystemConfigOffset.Value, 0);
		}

		// Token: 0x0601F931 RID: 129329 RVA: 0x00465A21 File Offset: 0x00463C21
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0601F932 RID: 129330 RVA: 0x00465A2D File Offset: 0x00463C2D
		public static Offset<IAiComponent> EndIAiComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAiComponent>(builder.EndTable());
		}

		// Token: 0x0601F933 RID: 129331 RVA: 0x00465A3C File Offset: 0x00463C3C
		public IAiComponentT UnPack()
		{
			IAiComponentT aiComponentT = new IAiComponentT();
			this.UnPackTo(aiComponentT);
			return aiComponentT;
		}

		// Token: 0x0601F934 RID: 129332 RVA: 0x00465A58 File Offset: 0x00463C58
		public void UnPackTo(IAiComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AiId = this.AiId;
			_o.Patrol = ((this.Patrol != null) ? this.Patrol.Value.UnPack() : null);
			_o.InitState = new TInitStateUnion();
			_o.InitState.Type = this.InitStateType;
			switch (this.InitStateType)
			{
			case TInitState.IInitStateBarrierLock:
				_o.InitState.Value = ((this.InitState<IInitStateBarrierLock>() != null) ? this.InitState<IInitStateBarrierLock>().Value.UnPack() : null);
				break;
			case TInitState.IInitStateBirth:
				_o.InitState.Value = ((this.InitState<IInitStateBirth>() != null) ? this.InitState<IInitStateBirth>().Value.UnPack() : null);
				break;
			case TInitState.IInitStateDigital:
				_o.InitState.Value = ((this.InitState<IInitStateDigital>() != null) ? this.InitState<IInitStateDigital>().Value.UnPack() : null);
				break;
			case TInitState.IInitStateMagneticStorm:
				_o.InitState.Value = ((this.InitState<IInitStateMagneticStorm>() != null) ? this.InitState<IInitStateMagneticStorm>().Value.UnPack() : null);
				break;
			case TInitState.IInitStateStandby:
				_o.InitState.Value = ((this.InitState<IInitStateStandby>() != null) ? this.InitState<IInitStateStandby>().Value.UnPack() : null);
				break;
			case TInitState.IInitStateWuYinQu:
				_o.InitState.Value = ((this.InitState<IInitStateWuYinQu>() != null) ? this.InitState<IInitStateWuYinQu>().Value.UnPack() : null);
				break;
			}
			_o.CenterPoint = this.CenterPoint;
			_o.InitBlackBoard = new List<TBlackBoardUnion>();
			for (int i = 0; i < this.InitBlackBoardLength; i++)
			{
				TBlackBoardUnion tblackBoardUnion = new TBlackBoardUnion();
				tblackBoardUnion.Type = this.InitBlackBoardType(i);
				switch (this.InitBlackBoardType(i))
				{
				case TBlackBoard.IBlackBoardBoolean:
					tblackBoardUnion.Value = ((this.InitBlackBoard<IBlackBoardBoolean>(i) != null) ? this.InitBlackBoard<IBlackBoardBoolean>(i).Value.UnPack() : null);
					break;
				case TBlackBoard.IBlackBoardEntityId:
					tblackBoardUnion.Value = ((this.InitBlackBoard<IBlackBoardEntityId>(i) != null) ? this.InitBlackBoard<IBlackBoardEntityId>(i).Value.UnPack() : null);
					break;
				case TBlackBoard.IBlackBoardEntityPos:
					tblackBoardUnion.Value = ((this.InitBlackBoard<IBlackBoardEntityPos>(i) != null) ? this.InitBlackBoard<IBlackBoardEntityPos>(i).Value.UnPack() : null);
					break;
				case TBlackBoard.IBlackBoardFloat:
					tblackBoardUnion.Value = ((this.InitBlackBoard<IBlackBoardFloat>(i) != null) ? this.InitBlackBoard<IBlackBoardFloat>(i).Value.UnPack() : null);
					break;
				case TBlackBoard.IBlackBoardInt:
					tblackBoardUnion.Value = ((this.InitBlackBoard<IBlackBoardInt>(i) != null) ? this.InitBlackBoard<IBlackBoardInt>(i).Value.UnPack() : null);
					break;
				case TBlackBoard.IBlackBoardString:
					tblackBoardUnion.Value = ((this.InitBlackBoard<IBlackBoardString>(i) != null) ? this.InitBlackBoard<IBlackBoardString>(i).Value.UnPack() : null);
					break;
				case TBlackBoard.IBlackBoardVector:
					tblackBoardUnion.Value = ((this.InitBlackBoard<IBlackBoardVector>(i) != null) ? this.InitBlackBoard<IBlackBoardVector>(i).Value.UnPack() : null);
					break;
				}
				_o.InitBlackBoard.Add(tblackBoardUnion);
			}
			_o.WeaponId = this.WeaponId;
			_o.AiTeamLevelId = this.AiTeamLevelId;
			_o.StateRepPerfList = new List<IStateRepPerfItemT>();
			for (int j = 0; j < this.StateRepPerfListLength; j++)
			{
				_o.StateRepPerfList.Add((this.StateRepPerfList(j) != null) ? this.StateRepPerfList(j).Value.UnPack() : null);
			}
			_o.AlertSystemConfig = ((this.AlertSystemConfig != null) ? this.AlertSystemConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F935 RID: 129333 RVA: 0x00465F24 File Offset: 0x00464124
		public static Offset<IAiComponent> Pack(FlatBufferBuilder builder, IAiComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiComponent>);
			}
			Offset<IPatrol> patrolOffset = (_o.Patrol == null) ? default(Offset<IPatrol>) : IPatrol.Pack(builder, _o.Patrol);
			TInitState initState_type = (_o.InitState == null) ? TInitState.NONE : _o.InitState.Type;
			int initStateOffset = (_o.InitState == null) ? 0 : TInitStateUnion.Pack(builder, _o.InitState);
			VectorOffset initBlackBoard_typeOffset = default(VectorOffset);
			if (_o.InitBlackBoard != null)
			{
				TBlackBoard[] array = new TBlackBoard[_o.InitBlackBoard.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.InitBlackBoard[i].Type;
				}
				initBlackBoard_typeOffset = IAiComponent.CreateInitBlackBoardTypeVector(builder, array);
			}
			VectorOffset initBlackBoardOffset = default(VectorOffset);
			if (_o.InitBlackBoard != null)
			{
				int[] array2 = new int[_o.InitBlackBoard.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TBlackBoardUnion.Pack(builder, _o.InitBlackBoard[j]);
				}
				initBlackBoardOffset = IAiComponent.CreateInitBlackBoardVector(builder, array2);
			}
			StringOffset weaponIdOffset = (_o.WeaponId == null) ? default(StringOffset) : builder.CreateString(_o.WeaponId);
			VectorOffset stateRepPerfListOffset = default(VectorOffset);
			if (_o.StateRepPerfList != null)
			{
				Offset<IStateRepPerfItem>[] array3 = new Offset<IStateRepPerfItem>[_o.StateRepPerfList.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IStateRepPerfItem.Pack(builder, _o.StateRepPerfList[k]);
				}
				stateRepPerfListOffset = IAiComponent.CreateStateRepPerfListVector(builder, array3);
			}
			Offset<IAiAlertSystemConfig> alertSystemConfigOffset = (_o.AlertSystemConfig == null) ? default(Offset<IAiAlertSystemConfig>) : IAiAlertSystemConfig.Pack(builder, _o.AlertSystemConfig);
			return IAiComponent.CreateIAiComponent(builder, _o.Disabled, _o.AiId, patrolOffset, initState_type, initStateOffset, _o.CenterPoint, initBlackBoard_typeOffset, initBlackBoardOffset, weaponIdOffset, _o.AiTeamLevelId, stateRepPerfListOffset, alertSystemConfigOffset, _o.NullMask);
		}

		// Token: 0x0400DC28 RID: 56360
		private Table __p;
	}
}
