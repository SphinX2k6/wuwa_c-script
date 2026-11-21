using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A02 RID: 27138
	public struct IClientDisableModulePlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700C78D RID: 51085
		// (get) Token: 0x0602E8D2 RID: 190674 RVA: 0x006592AC File Offset: 0x006574AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E8D3 RID: 190675 RVA: 0x006592B9 File Offset: 0x006574B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E8D4 RID: 190676 RVA: 0x006592C0 File Offset: 0x006574C0
		public static IClientDisableModulePlayerOperation GetRootAsIClientDisableModulePlayerOperation(ByteBuffer _bb)
		{
			return IClientDisableModulePlayerOperation.GetRootAsIClientDisableModulePlayerOperation(_bb, default(IClientDisableModulePlayerOperation));
		}

		// Token: 0x0602E8D5 RID: 190677 RVA: 0x006592DC File Offset: 0x006574DC
		public static IClientDisableModulePlayerOperation GetRootAsIClientDisableModulePlayerOperation(ByteBuffer _bb, IClientDisableModulePlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E8D6 RID: 190678 RVA: 0x006592F9 File Offset: 0x006574F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E8D7 RID: 190679 RVA: 0x00659308 File Offset: 0x00657508
		public IClientDisableModulePlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C78E RID: 51086
		// (get) Token: 0x0602E8D8 RID: 190680 RVA: 0x00659318 File Offset: 0x00657518
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

		// Token: 0x1700C78F RID: 51087
		// (get) Token: 0x0602E8D9 RID: 190681 RVA: 0x00659354 File Offset: 0x00657554
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

		// Token: 0x0602E8DA RID: 190682 RVA: 0x00659390 File Offset: 0x00657590
		public TTable? MoveOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E8DB RID: 190683 RVA: 0x006593D4 File Offset: 0x006575D4
		public IDisableMoveOperation MoveOptionAsIDisableMoveOperation()
		{
			return this.MoveOption<IDisableMoveOperation>().Value;
		}

		// Token: 0x0602E8DC RID: 190684 RVA: 0x006593F0 File Offset: 0x006575F0
		public IEnableMoveOperation MoveOptionAsIEnableMoveOperation()
		{
			return this.MoveOption<IEnableMoveOperation>().Value;
		}

		// Token: 0x1700C790 RID: 51088
		// (get) Token: 0x0602E8DD RID: 190685 RVA: 0x0065940C File Offset: 0x0065760C
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

		// Token: 0x0602E8DE RID: 190686 RVA: 0x0065944C File Offset: 0x0065764C
		public TTable? SkillOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E8DF RID: 190687 RVA: 0x00659494 File Offset: 0x00657694
		public IDisableSectionalSkillOperation SkillOptionAsIDisableSectionalSkillOperation()
		{
			return this.SkillOption<IDisableSectionalSkillOperation>().Value;
		}

		// Token: 0x0602E8E0 RID: 190688 RVA: 0x006594B0 File Offset: 0x006576B0
		public IDisableSkillOperation SkillOptionAsIDisableSkillOperation()
		{
			return this.SkillOption<IDisableSkillOperation>().Value;
		}

		// Token: 0x0602E8E1 RID: 190689 RVA: 0x006594CC File Offset: 0x006576CC
		public IEnableSkillOperation SkillOptionAsIEnableSkillOperation()
		{
			return this.SkillOption<IEnableSkillOperation>().Value;
		}

		// Token: 0x1700C791 RID: 51089
		// (get) Token: 0x0602E8E2 RID: 190690 RVA: 0x006594E8 File Offset: 0x006576E8
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

		// Token: 0x0602E8E3 RID: 190691 RVA: 0x00659528 File Offset: 0x00657728
		public TTable? CameraOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E8E4 RID: 190692 RVA: 0x00659570 File Offset: 0x00657770
		public IDisableCameraOperation CameraOptionAsIDisableCameraOperation()
		{
			return this.CameraOption<IDisableCameraOperation>().Value;
		}

		// Token: 0x0602E8E5 RID: 190693 RVA: 0x0065958C File Offset: 0x0065778C
		public IEnableCameraOperation CameraOptionAsIEnableCameraOperation()
		{
			return this.CameraOption<IEnableCameraOperation>().Value;
		}

		// Token: 0x0602E8E6 RID: 190694 RVA: 0x006595A8 File Offset: 0x006577A8
		public IEnableSectionalCameraOperation CameraOptionAsIEnableSectionalCameraOperation()
		{
			return this.CameraOption<IEnableSectionalCameraOperation>().Value;
		}

		// Token: 0x1700C792 RID: 51090
		// (get) Token: 0x0602E8E7 RID: 190695 RVA: 0x006595C4 File Offset: 0x006577C4
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

		// Token: 0x0602E8E8 RID: 190696 RVA: 0x00659604 File Offset: 0x00657804
		public TTable? UiOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E8E9 RID: 190697 RVA: 0x0065964C File Offset: 0x0065784C
		public IDisableUiOperation UiOptionAsIDisableUiOperation()
		{
			return this.UiOption<IDisableUiOperation>().Value;
		}

		// Token: 0x0602E8EA RID: 190698 RVA: 0x00659668 File Offset: 0x00657868
		public IEnableSectionalUi UiOptionAsIEnableSectionalUi()
		{
			return this.UiOption<IEnableSectionalUi>().Value;
		}

		// Token: 0x0602E8EB RID: 190699 RVA: 0x00659684 File Offset: 0x00657884
		public IEnableUiOperation UiOptionAsIEnableUiOperation()
		{
			return this.UiOption<IEnableUiOperation>().Value;
		}

		// Token: 0x1700C793 RID: 51091
		// (get) Token: 0x0602E8EC RID: 190700 RVA: 0x006596A0 File Offset: 0x006578A0
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

		// Token: 0x0602E8ED RID: 190701 RVA: 0x006596E0 File Offset: 0x006578E0
		public TTable? SceneInteractionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E8EE RID: 190702 RVA: 0x00659728 File Offset: 0x00657928
		public IDisableSceneInteractionOperation SceneInteractionOptionAsIDisableSceneInteractionOperation()
		{
			return this.SceneInteractionOption<IDisableSceneInteractionOperation>().Value;
		}

		// Token: 0x0602E8EF RID: 190703 RVA: 0x00659744 File Offset: 0x00657944
		public IEnableSceneInteractionOperation SceneInteractionOptionAsIEnableSceneInteractionOperation()
		{
			return this.SceneInteractionOption<IEnableSceneInteractionOperation>().Value;
		}

		// Token: 0x0602E8F0 RID: 190704 RVA: 0x00659760 File Offset: 0x00657960
		public static Offset<IClientDisableModulePlayerOperation> CreateIClientDisableModulePlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll, TMoveOperation MoveOption_type = TMoveOperation.NONE, int MoveOptionOffset = 0, TSkillOperation SkillOption_type = TSkillOperation.NONE, int SkillOptionOffset = 0, TCameraOperation CameraOption_type = TCameraOperation.NONE, int CameraOptionOffset = 0, TUiOperation UiOption_type = TUiOperation.NONE, int UiOptionOffset = 0, TSceneInteractionOperation SceneInteractionOption_type = TSceneInteractionOperation.NONE, int SceneInteractionOptionOffset = 0)
		{
			builder.StartTable(11);
			IClientDisableModulePlayerOperation.AddSceneInteractionOption(builder, SceneInteractionOptionOffset);
			IClientDisableModulePlayerOperation.AddUiOption(builder, UiOptionOffset);
			IClientDisableModulePlayerOperation.AddCameraOption(builder, CameraOptionOffset);
			IClientDisableModulePlayerOperation.AddSkillOption(builder, SkillOptionOffset);
			IClientDisableModulePlayerOperation.AddMoveOption(builder, MoveOptionOffset);
			IClientDisableModulePlayerOperation.AddSceneInteractionOptionType(builder, SceneInteractionOption_type);
			IClientDisableModulePlayerOperation.AddUiOptionType(builder, UiOption_type);
			IClientDisableModulePlayerOperation.AddCameraOptionType(builder, CameraOption_type);
			IClientDisableModulePlayerOperation.AddSkillOptionType(builder, SkillOption_type);
			IClientDisableModulePlayerOperation.AddMoveOptionType(builder, MoveOption_type);
			IClientDisableModulePlayerOperation.AddType(builder, Type);
			return IClientDisableModulePlayerOperation.EndIClientDisableModulePlayerOperation(builder);
		}

		// Token: 0x0602E8F1 RID: 190705 RVA: 0x006597D0 File Offset: 0x006579D0
		public static void StartIClientDisableModulePlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602E8F2 RID: 190706 RVA: 0x006597DA File Offset: 0x006579DA
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E8F3 RID: 190707 RVA: 0x006597E5 File Offset: 0x006579E5
		public static void AddMoveOptionType(FlatBufferBuilder builder, TMoveOperation moveOptionType)
		{
			builder.AddByte(1, (byte)moveOptionType, 0);
		}

		// Token: 0x0602E8F4 RID: 190708 RVA: 0x006597F0 File Offset: 0x006579F0
		public static void AddMoveOption(FlatBufferBuilder builder, int moveOptionOffset)
		{
			builder.AddOffset(2, moveOptionOffset, 0);
		}

		// Token: 0x0602E8F5 RID: 190709 RVA: 0x006597FB File Offset: 0x006579FB
		public static void AddSkillOptionType(FlatBufferBuilder builder, TSkillOperation skillOptionType)
		{
			builder.AddByte(3, (byte)skillOptionType, 0);
		}

		// Token: 0x0602E8F6 RID: 190710 RVA: 0x00659806 File Offset: 0x00657A06
		public static void AddSkillOption(FlatBufferBuilder builder, int skillOptionOffset)
		{
			builder.AddOffset(4, skillOptionOffset, 0);
		}

		// Token: 0x0602E8F7 RID: 190711 RVA: 0x00659811 File Offset: 0x00657A11
		public static void AddCameraOptionType(FlatBufferBuilder builder, TCameraOperation cameraOptionType)
		{
			builder.AddByte(5, (byte)cameraOptionType, 0);
		}

		// Token: 0x0602E8F8 RID: 190712 RVA: 0x0065981C File Offset: 0x00657A1C
		public static void AddCameraOption(FlatBufferBuilder builder, int cameraOptionOffset)
		{
			builder.AddOffset(6, cameraOptionOffset, 0);
		}

		// Token: 0x0602E8F9 RID: 190713 RVA: 0x00659827 File Offset: 0x00657A27
		public static void AddUiOptionType(FlatBufferBuilder builder, TUiOperation uiOptionType)
		{
			builder.AddByte(7, (byte)uiOptionType, 0);
		}

		// Token: 0x0602E8FA RID: 190714 RVA: 0x00659832 File Offset: 0x00657A32
		public static void AddUiOption(FlatBufferBuilder builder, int uiOptionOffset)
		{
			builder.AddOffset(8, uiOptionOffset, 0);
		}

		// Token: 0x0602E8FB RID: 190715 RVA: 0x0065983D File Offset: 0x00657A3D
		public static void AddSceneInteractionOptionType(FlatBufferBuilder builder, TSceneInteractionOperation sceneInteractionOptionType)
		{
			builder.AddByte(9, (byte)sceneInteractionOptionType, 0);
		}

		// Token: 0x0602E8FC RID: 190716 RVA: 0x00659849 File Offset: 0x00657A49
		public static void AddSceneInteractionOption(FlatBufferBuilder builder, int sceneInteractionOptionOffset)
		{
			builder.AddOffset(10, sceneInteractionOptionOffset, 0);
		}

		// Token: 0x0602E8FD RID: 190717 RVA: 0x00659855 File Offset: 0x00657A55
		public static Offset<IClientDisableModulePlayerOperation> EndIClientDisableModulePlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IClientDisableModulePlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602E8FE RID: 190718 RVA: 0x00659864 File Offset: 0x00657A64
		public IClientDisableModulePlayerOperationT UnPack()
		{
			IClientDisableModulePlayerOperationT clientDisableModulePlayerOperationT = new IClientDisableModulePlayerOperationT();
			this.UnPackTo(clientDisableModulePlayerOperationT);
			return clientDisableModulePlayerOperationT;
		}

		// Token: 0x0602E8FF RID: 190719 RVA: 0x00659880 File Offset: 0x00657A80
		public void UnPackTo(IClientDisableModulePlayerOperationT _o)
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
			if (sceneInteractionOptionType == TSceneInteractionOperation.IDisableSceneInteractionOperation)
			{
				_o.SceneInteractionOption.Value = ((this.SceneInteractionOption<IDisableSceneInteractionOperation>() != null) ? this.SceneInteractionOption<IDisableSceneInteractionOperation>().Value.UnPack() : null);
				return;
			}
			if (sceneInteractionOptionType != TSceneInteractionOperation.IEnableSceneInteractionOperation)
			{
				return;
			}
			_o.SceneInteractionOption.Value = ((this.SceneInteractionOption<IEnableSceneInteractionOperation>() != null) ? this.SceneInteractionOption<IEnableSceneInteractionOperation>().Value.UnPack() : null);
		}

		// Token: 0x0602E900 RID: 190720 RVA: 0x00659C84 File Offset: 0x00657E84
		public static Offset<IClientDisableModulePlayerOperation> Pack(FlatBufferBuilder builder, IClientDisableModulePlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientDisableModulePlayerOperation>);
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
			return IClientDisableModulePlayerOperation.CreateIClientDisableModulePlayerOperation(builder, _o.Type, moveOption_type, moveOptionOffset, skillOption_type, skillOptionOffset, cameraOption_type, cameraOptionOffset, uiOption_type, uiOptionOffset, sceneInteractionOption_type, sceneInteractionOptionOffset);
		}

		// Token: 0x04011770 RID: 71536
		private Table __p;
	}
}
