using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065E8 RID: 26088
	public struct IDisableModulePlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700C1B0 RID: 49584
		// (get) Token: 0x0602D42A RID: 185386 RVA: 0x00633DA6 File Offset: 0x00631FA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D42B RID: 185387 RVA: 0x00633DB3 File Offset: 0x00631FB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D42C RID: 185388 RVA: 0x00633DBC File Offset: 0x00631FBC
		public static IDisableModulePlayerOperation GetRootAsIDisableModulePlayerOperation(ByteBuffer _bb)
		{
			return IDisableModulePlayerOperation.GetRootAsIDisableModulePlayerOperation(_bb, default(IDisableModulePlayerOperation));
		}

		// Token: 0x0602D42D RID: 185389 RVA: 0x00633DD8 File Offset: 0x00631FD8
		public static IDisableModulePlayerOperation GetRootAsIDisableModulePlayerOperation(ByteBuffer _bb, IDisableModulePlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D42E RID: 185390 RVA: 0x00633DF5 File Offset: 0x00631FF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D42F RID: 185391 RVA: 0x00633E04 File Offset: 0x00632004
		public IDisableModulePlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1B1 RID: 49585
		// (get) Token: 0x0602D430 RID: 185392 RVA: 0x00633E14 File Offset: 0x00632014
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

		// Token: 0x1700C1B2 RID: 49586
		// (get) Token: 0x0602D431 RID: 185393 RVA: 0x00633E50 File Offset: 0x00632050
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

		// Token: 0x0602D432 RID: 185394 RVA: 0x00633E8C File Offset: 0x0063208C
		public TTable? MoveOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D433 RID: 185395 RVA: 0x00633ED0 File Offset: 0x006320D0
		public IDisableMoveOperation MoveOptionAsIDisableMoveOperation()
		{
			return this.MoveOption<IDisableMoveOperation>().Value;
		}

		// Token: 0x0602D434 RID: 185396 RVA: 0x00633EEC File Offset: 0x006320EC
		public IEnableMoveOperation MoveOptionAsIEnableMoveOperation()
		{
			return this.MoveOption<IEnableMoveOperation>().Value;
		}

		// Token: 0x1700C1B3 RID: 49587
		// (get) Token: 0x0602D435 RID: 185397 RVA: 0x00633F08 File Offset: 0x00632108
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

		// Token: 0x0602D436 RID: 185398 RVA: 0x00633F48 File Offset: 0x00632148
		public TTable? SkillOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D437 RID: 185399 RVA: 0x00633F90 File Offset: 0x00632190
		public IDisableSectionalSkillOperation SkillOptionAsIDisableSectionalSkillOperation()
		{
			return this.SkillOption<IDisableSectionalSkillOperation>().Value;
		}

		// Token: 0x0602D438 RID: 185400 RVA: 0x00633FAC File Offset: 0x006321AC
		public IDisableSkillOperation SkillOptionAsIDisableSkillOperation()
		{
			return this.SkillOption<IDisableSkillOperation>().Value;
		}

		// Token: 0x0602D439 RID: 185401 RVA: 0x00633FC8 File Offset: 0x006321C8
		public IEnableSkillOperation SkillOptionAsIEnableSkillOperation()
		{
			return this.SkillOption<IEnableSkillOperation>().Value;
		}

		// Token: 0x1700C1B4 RID: 49588
		// (get) Token: 0x0602D43A RID: 185402 RVA: 0x00633FE4 File Offset: 0x006321E4
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

		// Token: 0x0602D43B RID: 185403 RVA: 0x00634024 File Offset: 0x00632224
		public TTable? CameraOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D43C RID: 185404 RVA: 0x0063406C File Offset: 0x0063226C
		public IDisableCameraOperation CameraOptionAsIDisableCameraOperation()
		{
			return this.CameraOption<IDisableCameraOperation>().Value;
		}

		// Token: 0x0602D43D RID: 185405 RVA: 0x00634088 File Offset: 0x00632288
		public IEnableCameraOperation CameraOptionAsIEnableCameraOperation()
		{
			return this.CameraOption<IEnableCameraOperation>().Value;
		}

		// Token: 0x0602D43E RID: 185406 RVA: 0x006340A4 File Offset: 0x006322A4
		public IEnableSectionalCameraOperation CameraOptionAsIEnableSectionalCameraOperation()
		{
			return this.CameraOption<IEnableSectionalCameraOperation>().Value;
		}

		// Token: 0x1700C1B5 RID: 49589
		// (get) Token: 0x0602D43F RID: 185407 RVA: 0x006340C0 File Offset: 0x006322C0
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

		// Token: 0x0602D440 RID: 185408 RVA: 0x00634100 File Offset: 0x00632300
		public TTable? UiOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D441 RID: 185409 RVA: 0x00634148 File Offset: 0x00632348
		public IDisableUiOperation UiOptionAsIDisableUiOperation()
		{
			return this.UiOption<IDisableUiOperation>().Value;
		}

		// Token: 0x0602D442 RID: 185410 RVA: 0x00634164 File Offset: 0x00632364
		public IEnableSectionalUi UiOptionAsIEnableSectionalUi()
		{
			return this.UiOption<IEnableSectionalUi>().Value;
		}

		// Token: 0x0602D443 RID: 185411 RVA: 0x00634180 File Offset: 0x00632380
		public IEnableUiOperation UiOptionAsIEnableUiOperation()
		{
			return this.UiOption<IEnableUiOperation>().Value;
		}

		// Token: 0x1700C1B6 RID: 49590
		// (get) Token: 0x0602D444 RID: 185412 RVA: 0x0063419C File Offset: 0x0063239C
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

		// Token: 0x0602D445 RID: 185413 RVA: 0x006341DC File Offset: 0x006323DC
		public TTable? SceneInteractionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D446 RID: 185414 RVA: 0x00634224 File Offset: 0x00632424
		public IDisableSceneInteractionOperation SceneInteractionOptionAsIDisableSceneInteractionOperation()
		{
			return this.SceneInteractionOption<IDisableSceneInteractionOperation>().Value;
		}

		// Token: 0x0602D447 RID: 185415 RVA: 0x00634240 File Offset: 0x00632440
		public IEnableSceneInteractionOperation SceneInteractionOptionAsIEnableSceneInteractionOperation()
		{
			return this.SceneInteractionOption<IEnableSceneInteractionOperation>().Value;
		}

		// Token: 0x0602D448 RID: 185416 RVA: 0x0063425C File Offset: 0x0063245C
		public static Offset<IDisableModulePlayerOperation> CreateIDisableModulePlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll, TMoveOperation MoveOption_type = TMoveOperation.NONE, int MoveOptionOffset = 0, TSkillOperation SkillOption_type = TSkillOperation.NONE, int SkillOptionOffset = 0, TCameraOperation CameraOption_type = TCameraOperation.NONE, int CameraOptionOffset = 0, TUiOperation UiOption_type = TUiOperation.NONE, int UiOptionOffset = 0, TSceneInteractionOperation SceneInteractionOption_type = TSceneInteractionOperation.NONE, int SceneInteractionOptionOffset = 0)
		{
			builder.StartTable(11);
			IDisableModulePlayerOperation.AddSceneInteractionOption(builder, SceneInteractionOptionOffset);
			IDisableModulePlayerOperation.AddUiOption(builder, UiOptionOffset);
			IDisableModulePlayerOperation.AddCameraOption(builder, CameraOptionOffset);
			IDisableModulePlayerOperation.AddSkillOption(builder, SkillOptionOffset);
			IDisableModulePlayerOperation.AddMoveOption(builder, MoveOptionOffset);
			IDisableModulePlayerOperation.AddSceneInteractionOptionType(builder, SceneInteractionOption_type);
			IDisableModulePlayerOperation.AddUiOptionType(builder, UiOption_type);
			IDisableModulePlayerOperation.AddCameraOptionType(builder, CameraOption_type);
			IDisableModulePlayerOperation.AddSkillOptionType(builder, SkillOption_type);
			IDisableModulePlayerOperation.AddMoveOptionType(builder, MoveOption_type);
			IDisableModulePlayerOperation.AddType(builder, Type);
			return IDisableModulePlayerOperation.EndIDisableModulePlayerOperation(builder);
		}

		// Token: 0x0602D449 RID: 185417 RVA: 0x006342CC File Offset: 0x006324CC
		public static void StartIDisableModulePlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602D44A RID: 185418 RVA: 0x006342D6 File Offset: 0x006324D6
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D44B RID: 185419 RVA: 0x006342E1 File Offset: 0x006324E1
		public static void AddMoveOptionType(FlatBufferBuilder builder, TMoveOperation moveOptionType)
		{
			builder.AddByte(1, (byte)moveOptionType, 0);
		}

		// Token: 0x0602D44C RID: 185420 RVA: 0x006342EC File Offset: 0x006324EC
		public static void AddMoveOption(FlatBufferBuilder builder, int moveOptionOffset)
		{
			builder.AddOffset(2, moveOptionOffset, 0);
		}

		// Token: 0x0602D44D RID: 185421 RVA: 0x006342F7 File Offset: 0x006324F7
		public static void AddSkillOptionType(FlatBufferBuilder builder, TSkillOperation skillOptionType)
		{
			builder.AddByte(3, (byte)skillOptionType, 0);
		}

		// Token: 0x0602D44E RID: 185422 RVA: 0x00634302 File Offset: 0x00632502
		public static void AddSkillOption(FlatBufferBuilder builder, int skillOptionOffset)
		{
			builder.AddOffset(4, skillOptionOffset, 0);
		}

		// Token: 0x0602D44F RID: 185423 RVA: 0x0063430D File Offset: 0x0063250D
		public static void AddCameraOptionType(FlatBufferBuilder builder, TCameraOperation cameraOptionType)
		{
			builder.AddByte(5, (byte)cameraOptionType, 0);
		}

		// Token: 0x0602D450 RID: 185424 RVA: 0x00634318 File Offset: 0x00632518
		public static void AddCameraOption(FlatBufferBuilder builder, int cameraOptionOffset)
		{
			builder.AddOffset(6, cameraOptionOffset, 0);
		}

		// Token: 0x0602D451 RID: 185425 RVA: 0x00634323 File Offset: 0x00632523
		public static void AddUiOptionType(FlatBufferBuilder builder, TUiOperation uiOptionType)
		{
			builder.AddByte(7, (byte)uiOptionType, 0);
		}

		// Token: 0x0602D452 RID: 185426 RVA: 0x0063432E File Offset: 0x0063252E
		public static void AddUiOption(FlatBufferBuilder builder, int uiOptionOffset)
		{
			builder.AddOffset(8, uiOptionOffset, 0);
		}

		// Token: 0x0602D453 RID: 185427 RVA: 0x00634339 File Offset: 0x00632539
		public static void AddSceneInteractionOptionType(FlatBufferBuilder builder, TSceneInteractionOperation sceneInteractionOptionType)
		{
			builder.AddByte(9, (byte)sceneInteractionOptionType, 0);
		}

		// Token: 0x0602D454 RID: 185428 RVA: 0x00634345 File Offset: 0x00632545
		public static void AddSceneInteractionOption(FlatBufferBuilder builder, int sceneInteractionOptionOffset)
		{
			builder.AddOffset(10, sceneInteractionOptionOffset, 0);
		}

		// Token: 0x0602D455 RID: 185429 RVA: 0x00634351 File Offset: 0x00632551
		public static Offset<IDisableModulePlayerOperation> EndIDisableModulePlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableModulePlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602D456 RID: 185430 RVA: 0x00634360 File Offset: 0x00632560
		public IDisableModulePlayerOperationT UnPack()
		{
			IDisableModulePlayerOperationT disableModulePlayerOperationT = new IDisableModulePlayerOperationT();
			this.UnPackTo(disableModulePlayerOperationT);
			return disableModulePlayerOperationT;
		}

		// Token: 0x0602D457 RID: 185431 RVA: 0x0063437C File Offset: 0x0063257C
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

		// Token: 0x0602D458 RID: 185432 RVA: 0x00634780 File Offset: 0x00632980
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
			return IDisableModulePlayerOperation.CreateIDisableModulePlayerOperation(builder, _o.Type, moveOption_type, moveOptionOffset, skillOption_type, skillOptionOffset, cameraOption_type, cameraOptionOffset, uiOption_type, uiOptionOffset, sceneInteractionOption_type, sceneInteractionOptionOffset);
		}

		// Token: 0x04010C57 RID: 68695
		private Table __p;
	}
}
