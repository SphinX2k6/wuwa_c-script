using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C53 RID: 27731
	public struct IDisableModulePlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700CB46 RID: 52038
		// (get) Token: 0x0602FBCF RID: 195535 RVA: 0x0068040A File Offset: 0x0067E60A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FBD0 RID: 195536 RVA: 0x00680417 File Offset: 0x0067E617
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FBD1 RID: 195537 RVA: 0x00680420 File Offset: 0x0067E620
		public static IDisableModulePlayerOperation GetRootAsIDisableModulePlayerOperation(ByteBuffer _bb)
		{
			return IDisableModulePlayerOperation.GetRootAsIDisableModulePlayerOperation(_bb, default(IDisableModulePlayerOperation));
		}

		// Token: 0x0602FBD2 RID: 195538 RVA: 0x0068043C File Offset: 0x0067E63C
		public static IDisableModulePlayerOperation GetRootAsIDisableModulePlayerOperation(ByteBuffer _bb, IDisableModulePlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FBD3 RID: 195539 RVA: 0x00680459 File Offset: 0x0067E659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FBD4 RID: 195540 RVA: 0x00680468 File Offset: 0x0067E668
		public IDisableModulePlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB47 RID: 52039
		// (get) Token: 0x0602FBD5 RID: 195541 RVA: 0x00680478 File Offset: 0x0067E678
		public EPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerOperationType.EnableAll;
				}
				return (EPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB48 RID: 52040
		// (get) Token: 0x0602FBD6 RID: 195542 RVA: 0x006804B4 File Offset: 0x0067E6B4
		public TMoveOperation MoveOptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TMoveOperation.NONE;
				}
				return (TMoveOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBD7 RID: 195543 RVA: 0x006804F0 File Offset: 0x0067E6F0
		public TTable? MoveOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FBD8 RID: 195544 RVA: 0x00680534 File Offset: 0x0067E734
		public IDisableMoveOperation MoveOptionAsIDisableMoveOperation()
		{
			return this.MoveOption<IDisableMoveOperation>().Value;
		}

		// Token: 0x0602FBD9 RID: 195545 RVA: 0x00680550 File Offset: 0x0067E750
		public IEnableMoveOperation MoveOptionAsIEnableMoveOperation()
		{
			return this.MoveOption<IEnableMoveOperation>().Value;
		}

		// Token: 0x1700CB49 RID: 52041
		// (get) Token: 0x0602FBDA RID: 195546 RVA: 0x0068056C File Offset: 0x0067E76C
		public TSkillOperation SkillOptionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TSkillOperation.NONE;
				}
				return (TSkillOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBDB RID: 195547 RVA: 0x006805AC File Offset: 0x0067E7AC
		public TTable? SkillOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FBDC RID: 195548 RVA: 0x006805F4 File Offset: 0x0067E7F4
		public IDisableSectionalSkillOperation SkillOptionAsIDisableSectionalSkillOperation()
		{
			return this.SkillOption<IDisableSectionalSkillOperation>().Value;
		}

		// Token: 0x0602FBDD RID: 195549 RVA: 0x00680610 File Offset: 0x0067E810
		public IDisableSkillOperation SkillOptionAsIDisableSkillOperation()
		{
			return this.SkillOption<IDisableSkillOperation>().Value;
		}

		// Token: 0x0602FBDE RID: 195550 RVA: 0x0068062C File Offset: 0x0067E82C
		public IEnableSkillOperation SkillOptionAsIEnableSkillOperation()
		{
			return this.SkillOption<IEnableSkillOperation>().Value;
		}

		// Token: 0x1700CB4A RID: 52042
		// (get) Token: 0x0602FBDF RID: 195551 RVA: 0x00680648 File Offset: 0x0067E848
		public TCameraOperation CameraOptionType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TCameraOperation.NONE;
				}
				return (TCameraOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBE0 RID: 195552 RVA: 0x00680688 File Offset: 0x0067E888
		public TTable? CameraOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FBE1 RID: 195553 RVA: 0x006806D0 File Offset: 0x0067E8D0
		public IDisableCameraOperation CameraOptionAsIDisableCameraOperation()
		{
			return this.CameraOption<IDisableCameraOperation>().Value;
		}

		// Token: 0x0602FBE2 RID: 195554 RVA: 0x006806EC File Offset: 0x0067E8EC
		public IEnableCameraOperation CameraOptionAsIEnableCameraOperation()
		{
			return this.CameraOption<IEnableCameraOperation>().Value;
		}

		// Token: 0x0602FBE3 RID: 195555 RVA: 0x00680708 File Offset: 0x0067E908
		public IEnableSectionalCameraOperation CameraOptionAsIEnableSectionalCameraOperation()
		{
			return this.CameraOption<IEnableSectionalCameraOperation>().Value;
		}

		// Token: 0x1700CB4B RID: 52043
		// (get) Token: 0x0602FBE4 RID: 195556 RVA: 0x00680724 File Offset: 0x0067E924
		public TUiOperation UiOptionType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return TUiOperation.NONE;
				}
				return (TUiOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBE5 RID: 195557 RVA: 0x00680764 File Offset: 0x0067E964
		public TTable? UiOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FBE6 RID: 195558 RVA: 0x006807AC File Offset: 0x0067E9AC
		public IDisableUiOperation UiOptionAsIDisableUiOperation()
		{
			return this.UiOption<IDisableUiOperation>().Value;
		}

		// Token: 0x0602FBE7 RID: 195559 RVA: 0x006807C8 File Offset: 0x0067E9C8
		public IEnableSectionalUi UiOptionAsIEnableSectionalUi()
		{
			return this.UiOption<IEnableSectionalUi>().Value;
		}

		// Token: 0x0602FBE8 RID: 195560 RVA: 0x006807E4 File Offset: 0x0067E9E4
		public IEnableUiOperation UiOptionAsIEnableUiOperation()
		{
			return this.UiOption<IEnableUiOperation>().Value;
		}

		// Token: 0x1700CB4C RID: 52044
		// (get) Token: 0x0602FBE9 RID: 195561 RVA: 0x00680800 File Offset: 0x0067EA00
		public TSceneInteractionOperation SceneInteractionOptionType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return TSceneInteractionOperation.NONE;
				}
				return (TSceneInteractionOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBEA RID: 195562 RVA: 0x00680840 File Offset: 0x0067EA40
		public TTable? SceneInteractionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FBEB RID: 195563 RVA: 0x00680888 File Offset: 0x0067EA88
		public IDisableSceneInteractionOperation SceneInteractionOptionAsIDisableSceneInteractionOperation()
		{
			return this.SceneInteractionOption<IDisableSceneInteractionOperation>().Value;
		}

		// Token: 0x0602FBEC RID: 195564 RVA: 0x006808A4 File Offset: 0x0067EAA4
		public IEnableSceneInteractionOperation SceneInteractionOptionAsIEnableSceneInteractionOperation()
		{
			return this.SceneInteractionOption<IEnableSceneInteractionOperation>().Value;
		}

		// Token: 0x1700CB4D RID: 52045
		// (get) Token: 0x0602FBED RID: 195565 RVA: 0x006808C0 File Offset: 0x0067EAC0
		public TPlayerAiControl PlayerAiOptionType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return TPlayerAiControl.NONE;
				}
				return (TPlayerAiControl)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBEE RID: 195566 RVA: 0x00680900 File Offset: 0x0067EB00
		public TTable? PlayerAiOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FBEF RID: 195567 RVA: 0x00680948 File Offset: 0x0067EB48
		public IDisablePlayerAiControl PlayerAiOptionAsIDisablePlayerAiControl()
		{
			return this.PlayerAiOption<IDisablePlayerAiControl>().Value;
		}

		// Token: 0x0602FBF0 RID: 195568 RVA: 0x00680964 File Offset: 0x0067EB64
		public IEnablePlayerAiControl PlayerAiOptionAsIEnablePlayerAiControl()
		{
			return this.PlayerAiOption<IEnablePlayerAiControl>().Value;
		}

		// Token: 0x0602FBF1 RID: 195569 RVA: 0x00680980 File Offset: 0x0067EB80
		public static Offset<IDisableModulePlayerOperation> CreateIDisableModulePlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll, TMoveOperation MoveOption_type = TMoveOperation.NONE, int MoveOptionOffset = 0, TSkillOperation SkillOption_type = TSkillOperation.NONE, int SkillOptionOffset = 0, TCameraOperation CameraOption_type = TCameraOperation.NONE, int CameraOptionOffset = 0, TUiOperation UiOption_type = TUiOperation.NONE, int UiOptionOffset = 0, TSceneInteractionOperation SceneInteractionOption_type = TSceneInteractionOperation.NONE, int SceneInteractionOptionOffset = 0, TPlayerAiControl PlayerAiOption_type = TPlayerAiControl.NONE, int PlayerAiOptionOffset = 0)
		{
			builder.StartTable(13);
			IDisableModulePlayerOperation.AddPlayerAiOption(builder, PlayerAiOptionOffset);
			IDisableModulePlayerOperation.AddSceneInteractionOption(builder, SceneInteractionOptionOffset);
			IDisableModulePlayerOperation.AddUiOption(builder, UiOptionOffset);
			IDisableModulePlayerOperation.AddCameraOption(builder, CameraOptionOffset);
			IDisableModulePlayerOperation.AddSkillOption(builder, SkillOptionOffset);
			IDisableModulePlayerOperation.AddMoveOption(builder, MoveOptionOffset);
			IDisableModulePlayerOperation.AddPlayerAiOptionType(builder, PlayerAiOption_type);
			IDisableModulePlayerOperation.AddSceneInteractionOptionType(builder, SceneInteractionOption_type);
			IDisableModulePlayerOperation.AddUiOptionType(builder, UiOption_type);
			IDisableModulePlayerOperation.AddCameraOptionType(builder, CameraOption_type);
			IDisableModulePlayerOperation.AddSkillOptionType(builder, SkillOption_type);
			IDisableModulePlayerOperation.AddMoveOptionType(builder, MoveOption_type);
			IDisableModulePlayerOperation.AddType(builder, Type);
			return IDisableModulePlayerOperation.EndIDisableModulePlayerOperation(builder);
		}

		// Token: 0x0602FBF2 RID: 195570 RVA: 0x00680A00 File Offset: 0x0067EC00
		public static void StartIDisableModulePlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0602FBF3 RID: 195571 RVA: 0x00680A0A File Offset: 0x0067EC0A
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FBF4 RID: 195572 RVA: 0x00680A15 File Offset: 0x0067EC15
		public static void AddMoveOptionType(FlatBufferBuilder builder, TMoveOperation moveOptionType)
		{
			builder.AddByte(1, (byte)moveOptionType, 0);
		}

		// Token: 0x0602FBF5 RID: 195573 RVA: 0x00680A20 File Offset: 0x0067EC20
		public static void AddMoveOption(FlatBufferBuilder builder, int moveOptionOffset)
		{
			builder.AddOffset(2, moveOptionOffset, 0);
		}

		// Token: 0x0602FBF6 RID: 195574 RVA: 0x00680A2B File Offset: 0x0067EC2B
		public static void AddSkillOptionType(FlatBufferBuilder builder, TSkillOperation skillOptionType)
		{
			builder.AddByte(3, (byte)skillOptionType, 0);
		}

		// Token: 0x0602FBF7 RID: 195575 RVA: 0x00680A36 File Offset: 0x0067EC36
		public static void AddSkillOption(FlatBufferBuilder builder, int skillOptionOffset)
		{
			builder.AddOffset(4, skillOptionOffset, 0);
		}

		// Token: 0x0602FBF8 RID: 195576 RVA: 0x00680A41 File Offset: 0x0067EC41
		public static void AddCameraOptionType(FlatBufferBuilder builder, TCameraOperation cameraOptionType)
		{
			builder.AddByte(5, (byte)cameraOptionType, 0);
		}

		// Token: 0x0602FBF9 RID: 195577 RVA: 0x00680A4C File Offset: 0x0067EC4C
		public static void AddCameraOption(FlatBufferBuilder builder, int cameraOptionOffset)
		{
			builder.AddOffset(6, cameraOptionOffset, 0);
		}

		// Token: 0x0602FBFA RID: 195578 RVA: 0x00680A57 File Offset: 0x0067EC57
		public static void AddUiOptionType(FlatBufferBuilder builder, TUiOperation uiOptionType)
		{
			builder.AddByte(7, (byte)uiOptionType, 0);
		}

		// Token: 0x0602FBFB RID: 195579 RVA: 0x00680A62 File Offset: 0x0067EC62
		public static void AddUiOption(FlatBufferBuilder builder, int uiOptionOffset)
		{
			builder.AddOffset(8, uiOptionOffset, 0);
		}

		// Token: 0x0602FBFC RID: 195580 RVA: 0x00680A6D File Offset: 0x0067EC6D
		public static void AddSceneInteractionOptionType(FlatBufferBuilder builder, TSceneInteractionOperation sceneInteractionOptionType)
		{
			builder.AddByte(9, (byte)sceneInteractionOptionType, 0);
		}

		// Token: 0x0602FBFD RID: 195581 RVA: 0x00680A79 File Offset: 0x0067EC79
		public static void AddSceneInteractionOption(FlatBufferBuilder builder, int sceneInteractionOptionOffset)
		{
			builder.AddOffset(10, sceneInteractionOptionOffset, 0);
		}

		// Token: 0x0602FBFE RID: 195582 RVA: 0x00680A85 File Offset: 0x0067EC85
		public static void AddPlayerAiOptionType(FlatBufferBuilder builder, TPlayerAiControl playerAiOptionType)
		{
			builder.AddByte(11, (byte)playerAiOptionType, 0);
		}

		// Token: 0x0602FBFF RID: 195583 RVA: 0x00680A91 File Offset: 0x0067EC91
		public static void AddPlayerAiOption(FlatBufferBuilder builder, int playerAiOptionOffset)
		{
			builder.AddOffset(12, playerAiOptionOffset, 0);
		}

		// Token: 0x0602FC00 RID: 195584 RVA: 0x00680A9D File Offset: 0x0067EC9D
		public static Offset<IDisableModulePlayerOperation> EndIDisableModulePlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableModulePlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602FC01 RID: 195585 RVA: 0x00680AAC File Offset: 0x0067ECAC
		public IDisableModulePlayerOperationT UnPack()
		{
			IDisableModulePlayerOperationT disableModulePlayerOperationT = new IDisableModulePlayerOperationT();
			this.UnPackTo(disableModulePlayerOperationT);
			return disableModulePlayerOperationT;
		}

		// Token: 0x0602FC02 RID: 195586 RVA: 0x00680AC8 File Offset: 0x0067ECC8
		public void UnPackTo(IDisableModulePlayerOperationT _o)
		{
			_o.Type = this.Type;
			_o.MoveOption = new TMoveOperationUnion();
			_o.MoveOption.Type = this.MoveOptionType;
			TMoveOperation moveOptionType = this.MoveOptionType;
			if (moveOptionType != TMoveOperation.IDisableMoveOperation)
			{
				if (moveOptionType == TMoveOperation.IEnableMoveOperation)
				{
					_o.MoveOption.Value = ((this.MoveOption<IEnableMoveOperation>() != null) ? this.MoveOption<IEnableMoveOperation>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.MoveOption.Value = ((this.MoveOption<IDisableMoveOperation>() != null) ? this.MoveOption<IDisableMoveOperation>().Value.UnPack() : null);
			}
			_o.SkillOption = new TSkillOperationUnion();
			_o.SkillOption.Type = this.SkillOptionType;
			switch (this.SkillOptionType)
			{
			case TSkillOperation.IDisableSectionalSkillOperation:
				_o.SkillOption.Value = ((this.SkillOption<IDisableSectionalSkillOperation>() != null) ? this.SkillOption<IDisableSectionalSkillOperation>().Value.UnPack() : null);
				break;
			case TSkillOperation.IDisableSkillOperation:
				_o.SkillOption.Value = ((this.SkillOption<IDisableSkillOperation>() != null) ? this.SkillOption<IDisableSkillOperation>().Value.UnPack() : null);
				break;
			case TSkillOperation.IEnableSkillOperation:
				_o.SkillOption.Value = ((this.SkillOption<IEnableSkillOperation>() != null) ? this.SkillOption<IEnableSkillOperation>().Value.UnPack() : null);
				break;
			}
			_o.CameraOption = new TCameraOperationUnion();
			_o.CameraOption.Type = this.CameraOptionType;
			switch (this.CameraOptionType)
			{
			case TCameraOperation.IDisableCameraOperation:
				_o.CameraOption.Value = ((this.CameraOption<IDisableCameraOperation>() != null) ? this.CameraOption<IDisableCameraOperation>().Value.UnPack() : null);
				break;
			case TCameraOperation.IEnableCameraOperation:
				_o.CameraOption.Value = ((this.CameraOption<IEnableCameraOperation>() != null) ? this.CameraOption<IEnableCameraOperation>().Value.UnPack() : null);
				break;
			case TCameraOperation.IEnableSectionalCameraOperation:
				_o.CameraOption.Value = ((this.CameraOption<IEnableSectionalCameraOperation>() != null) ? this.CameraOption<IEnableSectionalCameraOperation>().Value.UnPack() : null);
				break;
			}
			_o.UiOption = new TUiOperationUnion();
			_o.UiOption.Type = this.UiOptionType;
			switch (this.UiOptionType)
			{
			case TUiOperation.IDisableUiOperation:
				_o.UiOption.Value = ((this.UiOption<IDisableUiOperation>() != null) ? this.UiOption<IDisableUiOperation>().Value.UnPack() : null);
				break;
			case TUiOperation.IEnableSectionalUi:
				_o.UiOption.Value = ((this.UiOption<IEnableSectionalUi>() != null) ? this.UiOption<IEnableSectionalUi>().Value.UnPack() : null);
				break;
			case TUiOperation.IEnableUiOperation:
				_o.UiOption.Value = ((this.UiOption<IEnableUiOperation>() != null) ? this.UiOption<IEnableUiOperation>().Value.UnPack() : null);
				break;
			}
			_o.SceneInteractionOption = new TSceneInteractionOperationUnion();
			_o.SceneInteractionOption.Type = this.SceneInteractionOptionType;
			TSceneInteractionOperation sceneInteractionOptionType = this.SceneInteractionOptionType;
			if (sceneInteractionOptionType != TSceneInteractionOperation.IDisableSceneInteractionOperation)
			{
				if (sceneInteractionOptionType == TSceneInteractionOperation.IEnableSceneInteractionOperation)
				{
					_o.SceneInteractionOption.Value = ((this.SceneInteractionOption<IEnableSceneInteractionOperation>() != null) ? this.SceneInteractionOption<IEnableSceneInteractionOperation>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SceneInteractionOption.Value = ((this.SceneInteractionOption<IDisableSceneInteractionOperation>() != null) ? this.SceneInteractionOption<IDisableSceneInteractionOperation>().Value.UnPack() : null);
			}
			_o.PlayerAiOption = new TPlayerAiControlUnion();
			_o.PlayerAiOption.Type = this.PlayerAiOptionType;
			TPlayerAiControl playerAiOptionType = this.PlayerAiOptionType;
			if (playerAiOptionType == TPlayerAiControl.IDisablePlayerAiControl)
			{
				_o.PlayerAiOption.Value = ((this.PlayerAiOption<IDisablePlayerAiControl>() != null) ? this.PlayerAiOption<IDisablePlayerAiControl>().Value.UnPack() : null);
				return;
			}
			if (playerAiOptionType != TPlayerAiControl.IEnablePlayerAiControl)
			{
				return;
			}
			_o.PlayerAiOption.Value = ((this.PlayerAiOption<IEnablePlayerAiControl>() != null) ? this.PlayerAiOption<IEnablePlayerAiControl>().Value.UnPack() : null);
		}

		// Token: 0x0602FC03 RID: 195587 RVA: 0x00680F6C File Offset: 0x0067F16C
		public static Offset<IDisableModulePlayerOperation> Pack(FlatBufferBuilder builder, IDisableModulePlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableModulePlayerOperation>);
			}
			TMoveOperation moveOption_type = (_o.MoveOption == null) ? TMoveOperation.NONE : _o.MoveOption.Type;
			int moveOptionOffset = (_o.MoveOption == null) ? 0 : TMoveOperationUnion.Pack(builder, _o.MoveOption);
			TSkillOperation skillOption_type = (_o.SkillOption == null) ? TSkillOperation.NONE : _o.SkillOption.Type;
			int skillOptionOffset = (_o.SkillOption == null) ? 0 : TSkillOperationUnion.Pack(builder, _o.SkillOption);
			TCameraOperation cameraOption_type = (_o.CameraOption == null) ? TCameraOperation.NONE : _o.CameraOption.Type;
			int cameraOptionOffset = (_o.CameraOption == null) ? 0 : TCameraOperationUnion.Pack(builder, _o.CameraOption);
			TUiOperation uiOption_type = (_o.UiOption == null) ? TUiOperation.NONE : _o.UiOption.Type;
			int uiOptionOffset = (_o.UiOption == null) ? 0 : TUiOperationUnion.Pack(builder, _o.UiOption);
			TSceneInteractionOperation sceneInteractionOption_type = (_o.SceneInteractionOption == null) ? TSceneInteractionOperation.NONE : _o.SceneInteractionOption.Type;
			int sceneInteractionOptionOffset = (_o.SceneInteractionOption == null) ? 0 : TSceneInteractionOperationUnion.Pack(builder, _o.SceneInteractionOption);
			TPlayerAiControl playerAiOption_type = (_o.PlayerAiOption == null) ? TPlayerAiControl.NONE : _o.PlayerAiOption.Type;
			int playerAiOptionOffset = (_o.PlayerAiOption == null) ? 0 : TPlayerAiControlUnion.Pack(builder, _o.PlayerAiOption);
			return IDisableModulePlayerOperation.CreateIDisableModulePlayerOperation(builder, _o.Type, moveOption_type, moveOptionOffset, skillOption_type, skillOptionOffset, cameraOption_type, cameraOptionOffset, uiOption_type, uiOptionOffset, sceneInteractionOption_type, sceneInteractionOptionOffset, playerAiOption_type, playerAiOptionOffset);
		}

		// Token: 0x04011A6D RID: 72301
		private Table __p;
	}
}
