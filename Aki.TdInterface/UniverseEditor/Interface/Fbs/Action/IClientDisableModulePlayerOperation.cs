using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006391 RID: 25489
	public struct IClientDisableModulePlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700BE09 RID: 48649
		// (get) Token: 0x0602C170 RID: 180592 RVA: 0x0060E274 File Offset: 0x0060C474
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C171 RID: 180593 RVA: 0x0060E281 File Offset: 0x0060C481
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C172 RID: 180594 RVA: 0x0060E288 File Offset: 0x0060C488
		public static IClientDisableModulePlayerOperation GetRootAsIClientDisableModulePlayerOperation(ByteBuffer _bb)
		{
			return IClientDisableModulePlayerOperation.GetRootAsIClientDisableModulePlayerOperation(_bb, default(IClientDisableModulePlayerOperation));
		}

		// Token: 0x0602C173 RID: 180595 RVA: 0x0060E2A4 File Offset: 0x0060C4A4
		public static IClientDisableModulePlayerOperation GetRootAsIClientDisableModulePlayerOperation(ByteBuffer _bb, IClientDisableModulePlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C174 RID: 180596 RVA: 0x0060E2C1 File Offset: 0x0060C4C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C175 RID: 180597 RVA: 0x0060E2D0 File Offset: 0x0060C4D0
		public IClientDisableModulePlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE0A RID: 48650
		// (get) Token: 0x0602C176 RID: 180598 RVA: 0x0060E2E0 File Offset: 0x0060C4E0
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

		// Token: 0x1700BE0B RID: 48651
		// (get) Token: 0x0602C177 RID: 180599 RVA: 0x0060E31C File Offset: 0x0060C51C
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

		// Token: 0x0602C178 RID: 180600 RVA: 0x0060E358 File Offset: 0x0060C558
		public TTable? MoveOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C179 RID: 180601 RVA: 0x0060E39C File Offset: 0x0060C59C
		public IDisableMoveOperation MoveOptionAsIDisableMoveOperation()
		{
			return this.MoveOption<IDisableMoveOperation>().Value;
		}

		// Token: 0x0602C17A RID: 180602 RVA: 0x0060E3B8 File Offset: 0x0060C5B8
		public IEnableMoveOperation MoveOptionAsIEnableMoveOperation()
		{
			return this.MoveOption<IEnableMoveOperation>().Value;
		}

		// Token: 0x1700BE0C RID: 48652
		// (get) Token: 0x0602C17B RID: 180603 RVA: 0x0060E3D4 File Offset: 0x0060C5D4
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

		// Token: 0x0602C17C RID: 180604 RVA: 0x0060E414 File Offset: 0x0060C614
		public TTable? SkillOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C17D RID: 180605 RVA: 0x0060E45C File Offset: 0x0060C65C
		public IDisableSectionalSkillOperation SkillOptionAsIDisableSectionalSkillOperation()
		{
			return this.SkillOption<IDisableSectionalSkillOperation>().Value;
		}

		// Token: 0x0602C17E RID: 180606 RVA: 0x0060E478 File Offset: 0x0060C678
		public IDisableSkillOperation SkillOptionAsIDisableSkillOperation()
		{
			return this.SkillOption<IDisableSkillOperation>().Value;
		}

		// Token: 0x0602C17F RID: 180607 RVA: 0x0060E494 File Offset: 0x0060C694
		public IEnableSkillOperation SkillOptionAsIEnableSkillOperation()
		{
			return this.SkillOption<IEnableSkillOperation>().Value;
		}

		// Token: 0x1700BE0D RID: 48653
		// (get) Token: 0x0602C180 RID: 180608 RVA: 0x0060E4B0 File Offset: 0x0060C6B0
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

		// Token: 0x0602C181 RID: 180609 RVA: 0x0060E4F0 File Offset: 0x0060C6F0
		public TTable? CameraOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C182 RID: 180610 RVA: 0x0060E538 File Offset: 0x0060C738
		public IDisableCameraOperation CameraOptionAsIDisableCameraOperation()
		{
			return this.CameraOption<IDisableCameraOperation>().Value;
		}

		// Token: 0x0602C183 RID: 180611 RVA: 0x0060E554 File Offset: 0x0060C754
		public IEnableCameraOperation CameraOptionAsIEnableCameraOperation()
		{
			return this.CameraOption<IEnableCameraOperation>().Value;
		}

		// Token: 0x0602C184 RID: 180612 RVA: 0x0060E570 File Offset: 0x0060C770
		public IEnableSectionalCameraOperation CameraOptionAsIEnableSectionalCameraOperation()
		{
			return this.CameraOption<IEnableSectionalCameraOperation>().Value;
		}

		// Token: 0x1700BE0E RID: 48654
		// (get) Token: 0x0602C185 RID: 180613 RVA: 0x0060E58C File Offset: 0x0060C78C
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

		// Token: 0x0602C186 RID: 180614 RVA: 0x0060E5CC File Offset: 0x0060C7CC
		public TTable? UiOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C187 RID: 180615 RVA: 0x0060E614 File Offset: 0x0060C814
		public IDisableUiOperation UiOptionAsIDisableUiOperation()
		{
			return this.UiOption<IDisableUiOperation>().Value;
		}

		// Token: 0x0602C188 RID: 180616 RVA: 0x0060E630 File Offset: 0x0060C830
		public IEnableSectionalUi UiOptionAsIEnableSectionalUi()
		{
			return this.UiOption<IEnableSectionalUi>().Value;
		}

		// Token: 0x0602C189 RID: 180617 RVA: 0x0060E64C File Offset: 0x0060C84C
		public IEnableUiOperation UiOptionAsIEnableUiOperation()
		{
			return this.UiOption<IEnableUiOperation>().Value;
		}

		// Token: 0x1700BE0F RID: 48655
		// (get) Token: 0x0602C18A RID: 180618 RVA: 0x0060E668 File Offset: 0x0060C868
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

		// Token: 0x0602C18B RID: 180619 RVA: 0x0060E6A8 File Offset: 0x0060C8A8
		public TTable? SceneInteractionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C18C RID: 180620 RVA: 0x0060E6F0 File Offset: 0x0060C8F0
		public IDisableSceneInteractionOperation SceneInteractionOptionAsIDisableSceneInteractionOperation()
		{
			return this.SceneInteractionOption<IDisableSceneInteractionOperation>().Value;
		}

		// Token: 0x0602C18D RID: 180621 RVA: 0x0060E70C File Offset: 0x0060C90C
		public IEnableSceneInteractionOperation SceneInteractionOptionAsIEnableSceneInteractionOperation()
		{
			return this.SceneInteractionOption<IEnableSceneInteractionOperation>().Value;
		}

		// Token: 0x0602C18E RID: 180622 RVA: 0x0060E728 File Offset: 0x0060C928
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

		// Token: 0x0602C18F RID: 180623 RVA: 0x0060E798 File Offset: 0x0060C998
		public static void StartIClientDisableModulePlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602C190 RID: 180624 RVA: 0x0060E7A2 File Offset: 0x0060C9A2
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C191 RID: 180625 RVA: 0x0060E7AD File Offset: 0x0060C9AD
		public static void AddMoveOptionType(FlatBufferBuilder builder, TMoveOperation moveOptionType)
		{
			builder.AddByte(1, (byte)moveOptionType, 0);
		}

		// Token: 0x0602C192 RID: 180626 RVA: 0x0060E7B8 File Offset: 0x0060C9B8
		public static void AddMoveOption(FlatBufferBuilder builder, int moveOptionOffset)
		{
			builder.AddOffset(2, moveOptionOffset, 0);
		}

		// Token: 0x0602C193 RID: 180627 RVA: 0x0060E7C3 File Offset: 0x0060C9C3
		public static void AddSkillOptionType(FlatBufferBuilder builder, TSkillOperation skillOptionType)
		{
			builder.AddByte(3, (byte)skillOptionType, 0);
		}

		// Token: 0x0602C194 RID: 180628 RVA: 0x0060E7CE File Offset: 0x0060C9CE
		public static void AddSkillOption(FlatBufferBuilder builder, int skillOptionOffset)
		{
			builder.AddOffset(4, skillOptionOffset, 0);
		}

		// Token: 0x0602C195 RID: 180629 RVA: 0x0060E7D9 File Offset: 0x0060C9D9
		public static void AddCameraOptionType(FlatBufferBuilder builder, TCameraOperation cameraOptionType)
		{
			builder.AddByte(5, (byte)cameraOptionType, 0);
		}

		// Token: 0x0602C196 RID: 180630 RVA: 0x0060E7E4 File Offset: 0x0060C9E4
		public static void AddCameraOption(FlatBufferBuilder builder, int cameraOptionOffset)
		{
			builder.AddOffset(6, cameraOptionOffset, 0);
		}

		// Token: 0x0602C197 RID: 180631 RVA: 0x0060E7EF File Offset: 0x0060C9EF
		public static void AddUiOptionType(FlatBufferBuilder builder, TUiOperation uiOptionType)
		{
			builder.AddByte(7, (byte)uiOptionType, 0);
		}

		// Token: 0x0602C198 RID: 180632 RVA: 0x0060E7FA File Offset: 0x0060C9FA
		public static void AddUiOption(FlatBufferBuilder builder, int uiOptionOffset)
		{
			builder.AddOffset(8, uiOptionOffset, 0);
		}

		// Token: 0x0602C199 RID: 180633 RVA: 0x0060E805 File Offset: 0x0060CA05
		public static void AddSceneInteractionOptionType(FlatBufferBuilder builder, TSceneInteractionOperation sceneInteractionOptionType)
		{
			builder.AddByte(9, (byte)sceneInteractionOptionType, 0);
		}

		// Token: 0x0602C19A RID: 180634 RVA: 0x0060E811 File Offset: 0x0060CA11
		public static void AddSceneInteractionOption(FlatBufferBuilder builder, int sceneInteractionOptionOffset)
		{
			builder.AddOffset(10, sceneInteractionOptionOffset, 0);
		}

		// Token: 0x0602C19B RID: 180635 RVA: 0x0060E81D File Offset: 0x0060CA1D
		public static Offset<IClientDisableModulePlayerOperation> EndIClientDisableModulePlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IClientDisableModulePlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602C19C RID: 180636 RVA: 0x0060E82C File Offset: 0x0060CA2C
		public IClientDisableModulePlayerOperationT UnPack()
		{
			IClientDisableModulePlayerOperationT clientDisableModulePlayerOperationT = new IClientDisableModulePlayerOperationT();
			this.UnPackTo(clientDisableModulePlayerOperationT);
			return clientDisableModulePlayerOperationT;
		}

		// Token: 0x0602C19D RID: 180637 RVA: 0x0060E848 File Offset: 0x0060CA48
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

		// Token: 0x0602C19E RID: 180638 RVA: 0x0060EC4C File Offset: 0x0060CE4C
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

		// Token: 0x0401095D RID: 67933
		private Table __p;
	}
}
