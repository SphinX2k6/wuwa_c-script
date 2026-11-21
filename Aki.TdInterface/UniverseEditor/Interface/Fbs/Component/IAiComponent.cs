using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005388 RID: 21384
	public struct IAiComponent : IFlatbufferObject
	{
		// Token: 0x17009711 RID: 38673
		// (get) Token: 0x0602153F RID: 136511 RVA: 0x00499168 File Offset: 0x00497368
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021540 RID: 136512 RVA: 0x00499175 File Offset: 0x00497375
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021541 RID: 136513 RVA: 0x0049917C File Offset: 0x0049737C
		public static IAiComponent GetRootAsIAiComponent(ByteBuffer _bb)
		{
			return IAiComponent.GetRootAsIAiComponent(_bb, default(IAiComponent));
		}

		// Token: 0x06021542 RID: 136514 RVA: 0x00499198 File Offset: 0x00497398
		public static IAiComponent GetRootAsIAiComponent(ByteBuffer _bb, IAiComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021543 RID: 136515 RVA: 0x004991B5 File Offset: 0x004973B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021544 RID: 136516 RVA: 0x004991C4 File Offset: 0x004973C4
		public IAiComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009712 RID: 38674
		// (get) Token: 0x06021545 RID: 136517 RVA: 0x004991D4 File Offset: 0x004973D4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009713 RID: 38675
		// (get) Token: 0x06021546 RID: 136518 RVA: 0x00499214 File Offset: 0x00497414
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

		// Token: 0x17009714 RID: 38676
		// (get) Token: 0x06021547 RID: 136519 RVA: 0x00499250 File Offset: 0x00497450
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

		// Token: 0x17009715 RID: 38677
		// (get) Token: 0x06021548 RID: 136520 RVA: 0x004992B0 File Offset: 0x004974B0
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

		// Token: 0x06021549 RID: 136521 RVA: 0x004992F0 File Offset: 0x004974F0
		public TTable? InitState<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602154A RID: 136522 RVA: 0x00499338 File Offset: 0x00497538
		public IInitStateBarrierLock InitStateAsIInitStateBarrierLock()
		{
			return this.InitState<IInitStateBarrierLock>().Value;
		}

		// Token: 0x0602154B RID: 136523 RVA: 0x00499354 File Offset: 0x00497554
		public IInitStateBirth InitStateAsIInitStateBirth()
		{
			return this.InitState<IInitStateBirth>().Value;
		}

		// Token: 0x0602154C RID: 136524 RVA: 0x00499370 File Offset: 0x00497570
		public IInitStateDigital InitStateAsIInitStateDigital()
		{
			return this.InitState<IInitStateDigital>().Value;
		}

		// Token: 0x0602154D RID: 136525 RVA: 0x0049938C File Offset: 0x0049758C
		public IInitStateMagneticStorm InitStateAsIInitStateMagneticStorm()
		{
			return this.InitState<IInitStateMagneticStorm>().Value;
		}

		// Token: 0x0602154E RID: 136526 RVA: 0x004993A8 File Offset: 0x004975A8
		public IInitStateStandby InitStateAsIInitStateStandby()
		{
			return this.InitState<IInitStateStandby>().Value;
		}

		// Token: 0x0602154F RID: 136527 RVA: 0x004993C4 File Offset: 0x004975C4
		public IInitStateWuYinQu InitStateAsIInitStateWuYinQu()
		{
			return this.InitState<IInitStateWuYinQu>().Value;
		}

		// Token: 0x17009716 RID: 38678
		// (get) Token: 0x06021550 RID: 136528 RVA: 0x004993E0 File Offset: 0x004975E0
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

		// Token: 0x06021551 RID: 136529 RVA: 0x00499420 File Offset: 0x00497620
		public TBlackBoard InitBlackBoardType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TBlackBoard.NONE;
			}
			return (TBlackBoard)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009717 RID: 38679
		// (get) Token: 0x06021552 RID: 136530 RVA: 0x00499460 File Offset: 0x00497660
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

		// Token: 0x06021553 RID: 136531 RVA: 0x0049948C File Offset: 0x0049768C
		public Span<TBlackBoard> GetInitBlackBoardTypeBytes()
		{
			return this.__p.__vector_as_span<TBlackBoard>(16, 1);
		}

		// Token: 0x06021554 RID: 136532 RVA: 0x0049949C File Offset: 0x0049769C
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

		// Token: 0x06021555 RID: 136533 RVA: 0x00499508 File Offset: 0x00497708
		public TTable? InitBlackBoard<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17009718 RID: 38680
		// (get) Token: 0x06021556 RID: 136534 RVA: 0x00499550 File Offset: 0x00497750
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

		// Token: 0x17009719 RID: 38681
		// (get) Token: 0x06021557 RID: 136535 RVA: 0x0049957C File Offset: 0x0049777C
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

		// Token: 0x06021558 RID: 136536 RVA: 0x004995B4 File Offset: 0x004977B4
		public Span<byte> GetWeaponIdBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06021559 RID: 136537 RVA: 0x004995C4 File Offset: 0x004977C4
		public byte[] GetWeaponIdArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x1700971A RID: 38682
		// (get) Token: 0x0602155A RID: 136538 RVA: 0x004995D4 File Offset: 0x004977D4
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

		// Token: 0x0602155B RID: 136539 RVA: 0x00499614 File Offset: 0x00497814
		public IStateRepPerfItem? StateRepPerfList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IStateRepPerfItem?(default(IStateRepPerfItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700971B RID: 38683
		// (get) Token: 0x0602155C RID: 136540 RVA: 0x00499678 File Offset: 0x00497878
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

		// Token: 0x1700971C RID: 38684
		// (get) Token: 0x0602155D RID: 136541 RVA: 0x004996A4 File Offset: 0x004978A4
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

		// Token: 0x1700971D RID: 38685
		// (get) Token: 0x0602155E RID: 136542 RVA: 0x00499704 File Offset: 0x00497904
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

		// Token: 0x0602155F RID: 136543 RVA: 0x00499744 File Offset: 0x00497944
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

		// Token: 0x06021560 RID: 136544 RVA: 0x004997C4 File Offset: 0x004979C4
		public static void StartIAiComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06021561 RID: 136545 RVA: 0x004997CE File Offset: 0x004979CE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021562 RID: 136546 RVA: 0x004997D9 File Offset: 0x004979D9
		public static void AddAiId(FlatBufferBuilder builder, int aiId)
		{
			builder.AddInt(1, aiId, 0);
		}

		// Token: 0x06021563 RID: 136547 RVA: 0x004997E4 File Offset: 0x004979E4
		public static void AddPatrol(FlatBufferBuilder builder, Offset<IPatrol> patrolOffset)
		{
			builder.AddOffset(2, patrolOffset.Value, 0);
		}

		// Token: 0x06021564 RID: 136548 RVA: 0x004997F4 File Offset: 0x004979F4
		public static void AddInitStateType(FlatBufferBuilder builder, TInitState initStateType)
		{
			builder.AddByte(3, (byte)initStateType, 0);
		}

		// Token: 0x06021565 RID: 136549 RVA: 0x004997FF File Offset: 0x004979FF
		public static void AddInitState(FlatBufferBuilder builder, int initStateOffset)
		{
			builder.AddOffset(4, initStateOffset, 0);
		}

		// Token: 0x06021566 RID: 136550 RVA: 0x0049980A File Offset: 0x00497A0A
		public static void AddCenterPoint(FlatBufferBuilder builder, int centerPoint)
		{
			builder.AddInt(5, centerPoint, 0);
		}

		// Token: 0x06021567 RID: 136551 RVA: 0x00499815 File Offset: 0x00497A15
		public static void AddInitBlackBoardType(FlatBufferBuilder builder, VectorOffset initBlackBoardTypeOffset)
		{
			builder.AddOffset(6, initBlackBoardTypeOffset.Value, 0);
		}

		// Token: 0x06021568 RID: 136552 RVA: 0x00499828 File Offset: 0x00497A28
		public static VectorOffset CreateInitBlackBoardTypeVector(FlatBufferBuilder builder, TBlackBoard[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021569 RID: 136553 RVA: 0x0049985F File Offset: 0x00497A5F
		public static VectorOffset CreateInitBlackBoardTypeVectorBlock(FlatBufferBuilder builder, TBlackBoard[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBlackBoard>(data);
			return builder.EndVector();
		}

		// Token: 0x0602156A RID: 136554 RVA: 0x00499879 File Offset: 0x00497A79
		public static VectorOffset CreateInitBlackBoardTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBlackBoard> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBlackBoard>(data);
			return builder.EndVector();
		}

		// Token: 0x0602156B RID: 136555 RVA: 0x00499897 File Offset: 0x00497A97
		public static VectorOffset CreateInitBlackBoardTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBlackBoard>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602156C RID: 136556 RVA: 0x004998B0 File Offset: 0x00497AB0
		public static void StartInitBlackBoardTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602156D RID: 136557 RVA: 0x004998BB File Offset: 0x00497ABB
		public static void AddInitBlackBoard(FlatBufferBuilder builder, VectorOffset initBlackBoardOffset)
		{
			builder.AddOffset(7, initBlackBoardOffset.Value, 0);
		}

		// Token: 0x0602156E RID: 136558 RVA: 0x004998CC File Offset: 0x00497ACC
		public static VectorOffset CreateInitBlackBoardVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602156F RID: 136559 RVA: 0x00499903 File Offset: 0x00497B03
		public static VectorOffset CreateInitBlackBoardVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021570 RID: 136560 RVA: 0x0049991D File Offset: 0x00497B1D
		public static VectorOffset CreateInitBlackBoardVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021571 RID: 136561 RVA: 0x0049993B File Offset: 0x00497B3B
		public static VectorOffset CreateInitBlackBoardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021572 RID: 136562 RVA: 0x00499954 File Offset: 0x00497B54
		public static void StartInitBlackBoardVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021573 RID: 136563 RVA: 0x0049995F File Offset: 0x00497B5F
		public static void AddWeaponId(FlatBufferBuilder builder, StringOffset weaponIdOffset)
		{
			builder.AddOffset(8, weaponIdOffset.Value, 0);
		}

		// Token: 0x06021574 RID: 136564 RVA: 0x0049996F File Offset: 0x00497B6F
		public static void AddAiTeamLevelId(FlatBufferBuilder builder, int aiTeamLevelId)
		{
			builder.AddInt(9, aiTeamLevelId, 0);
		}

		// Token: 0x06021575 RID: 136565 RVA: 0x0049997B File Offset: 0x00497B7B
		public static void AddStateRepPerfList(FlatBufferBuilder builder, VectorOffset stateRepPerfListOffset)
		{
			builder.AddOffset(10, stateRepPerfListOffset.Value, 0);
		}

		// Token: 0x06021576 RID: 136566 RVA: 0x0049998C File Offset: 0x00497B8C
		public static VectorOffset CreateStateRepPerfListVector(FlatBufferBuilder builder, Offset<IStateRepPerfItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021577 RID: 136567 RVA: 0x004999CC File Offset: 0x00497BCC
		public static VectorOffset CreateStateRepPerfListVectorBlock(FlatBufferBuilder builder, Offset<IStateRepPerfItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateRepPerfItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021578 RID: 136568 RVA: 0x004999E6 File Offset: 0x00497BE6
		public static VectorOffset CreateStateRepPerfListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateRepPerfItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateRepPerfItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021579 RID: 136569 RVA: 0x00499A04 File Offset: 0x00497C04
		public static VectorOffset CreateStateRepPerfListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateRepPerfItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602157A RID: 136570 RVA: 0x00499A1D File Offset: 0x00497C1D
		public static void StartStateRepPerfListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602157B RID: 136571 RVA: 0x00499A28 File Offset: 0x00497C28
		public static void AddAlertSystemConfig(FlatBufferBuilder builder, Offset<IAiAlertSystemConfig> alertSystemConfigOffset)
		{
			builder.AddOffset(11, alertSystemConfigOffset.Value, 0);
		}

		// Token: 0x0602157C RID: 136572 RVA: 0x00499A39 File Offset: 0x00497C39
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0602157D RID: 136573 RVA: 0x00499A45 File Offset: 0x00497C45
		public static Offset<IAiComponent> EndIAiComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAiComponent>(builder.EndTable());
		}

		// Token: 0x0602157E RID: 136574 RVA: 0x00499A54 File Offset: 0x00497C54
		public IAiComponentT UnPack()
		{
			IAiComponentT aiComponentT = new IAiComponentT();
			this.UnPackTo(aiComponentT);
			return aiComponentT;
		}

		// Token: 0x0602157F RID: 136575 RVA: 0x00499A70 File Offset: 0x00497C70
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

		// Token: 0x06021580 RID: 136576 RVA: 0x00499F3C File Offset: 0x0049813C
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

		// Token: 0x0400E7A2 RID: 59298
		private Table __p;
	}
}
