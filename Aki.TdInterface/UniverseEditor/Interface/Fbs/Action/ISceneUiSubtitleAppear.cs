using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076CF RID: 30415
	public struct ISceneUiSubtitleAppear : IFlatbufferObject
	{
		// Token: 0x1700DF10 RID: 57104
		// (get) Token: 0x060355A1 RID: 218529 RVA: 0x00727E6A File Offset: 0x0072606A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060355A2 RID: 218530 RVA: 0x00727E77 File Offset: 0x00726077
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060355A3 RID: 218531 RVA: 0x00727E80 File Offset: 0x00726080
		public static ISceneUiSubtitleAppear GetRootAsISceneUiSubtitleAppear(ByteBuffer _bb)
		{
			return ISceneUiSubtitleAppear.GetRootAsISceneUiSubtitleAppear(_bb, default(ISceneUiSubtitleAppear));
		}

		// Token: 0x060355A4 RID: 218532 RVA: 0x00727E9C File Offset: 0x0072609C
		public static ISceneUiSubtitleAppear GetRootAsISceneUiSubtitleAppear(ByteBuffer _bb, ISceneUiSubtitleAppear obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060355A5 RID: 218533 RVA: 0x00727EB9 File Offset: 0x007260B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060355A6 RID: 218534 RVA: 0x00727EC8 File Offset: 0x007260C8
		public ISceneUiSubtitleAppear __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF11 RID: 57105
		// (get) Token: 0x060355A7 RID: 218535 RVA: 0x00727ED8 File Offset: 0x007260D8
		public TSceneUiSubtitlePosition PositionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSceneUiSubtitlePosition.NONE;
				}
				return (TSceneUiSubtitlePosition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060355A8 RID: 218536 RVA: 0x00727F14 File Offset: 0x00726114
		public TTable? Position<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060355A9 RID: 218537 RVA: 0x00727F58 File Offset: 0x00726158
		public ISceneUiSubtitlePosition PositionAsISceneUiSubtitlePosition()
		{
			return this.Position<ISceneUiSubtitlePosition>().Value;
		}

		// Token: 0x060355AA RID: 218538 RVA: 0x00727F74 File Offset: 0x00726174
		public ISceneUiSubtitlePositionEntity PositionAsISceneUiSubtitlePositionEntity()
		{
			return this.Position<ISceneUiSubtitlePositionEntity>().Value;
		}

		// Token: 0x1700DF12 RID: 57106
		// (get) Token: 0x060355AB RID: 218539 RVA: 0x00727F90 File Offset: 0x00726190
		public bool LockFacingCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF13 RID: 57107
		// (get) Token: 0x060355AC RID: 218540 RVA: 0x00727FD0 File Offset: 0x007261D0
		public bool IsOccluded
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF14 RID: 57108
		// (get) Token: 0x060355AD RID: 218541 RVA: 0x00728010 File Offset: 0x00726210
		public ISceneUiSubtitleLocalizationConfig? LocalizationConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ISceneUiSubtitleLocalizationConfig?(default(ISceneUiSubtitleLocalizationConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DF15 RID: 57109
		// (get) Token: 0x060355AE RID: 218542 RVA: 0x00728070 File Offset: 0x00726270
		public ESceneUiSubtitleStyleType Type
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return ESceneUiSubtitleStyleType.SceneUiSubtitleScatter;
				}
				return (ESceneUiSubtitleStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF16 RID: 57110
		// (get) Token: 0x060355AF RID: 218543 RVA: 0x007280B0 File Offset: 0x007262B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060355B0 RID: 218544 RVA: 0x007280F0 File Offset: 0x007262F0
		public static Offset<ISceneUiSubtitleAppear> CreateISceneUiSubtitleAppear(FlatBufferBuilder builder, TSceneUiSubtitlePosition Position_type = TSceneUiSubtitlePosition.NONE, int PositionOffset = 0, bool LockFacingCamera = false, bool IsOccluded = false, Offset<ISceneUiSubtitleLocalizationConfig> LocalizationConfigOffset = default(Offset<ISceneUiSubtitleLocalizationConfig>), ESceneUiSubtitleStyleType Type = ESceneUiSubtitleStyleType.SceneUiSubtitleScatter, byte NullMask = 0)
		{
			builder.StartTable(7);
			ISceneUiSubtitleAppear.AddLocalizationConfig(builder, LocalizationConfigOffset);
			ISceneUiSubtitleAppear.AddPosition(builder, PositionOffset);
			ISceneUiSubtitleAppear.AddNullMask(builder, NullMask);
			ISceneUiSubtitleAppear.AddType(builder, Type);
			ISceneUiSubtitleAppear.AddIsOccluded(builder, IsOccluded);
			ISceneUiSubtitleAppear.AddLockFacingCamera(builder, LockFacingCamera);
			ISceneUiSubtitleAppear.AddPositionType(builder, Position_type);
			return ISceneUiSubtitleAppear.EndISceneUiSubtitleAppear(builder);
		}

		// Token: 0x060355B1 RID: 218545 RVA: 0x0072813F File Offset: 0x0072633F
		public static void StartISceneUiSubtitleAppear(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060355B2 RID: 218546 RVA: 0x00728148 File Offset: 0x00726348
		public static void AddPositionType(FlatBufferBuilder builder, TSceneUiSubtitlePosition positionType)
		{
			builder.AddByte(0, (byte)positionType, 0);
		}

		// Token: 0x060355B3 RID: 218547 RVA: 0x00728153 File Offset: 0x00726353
		public static void AddPosition(FlatBufferBuilder builder, int positionOffset)
		{
			builder.AddOffset(1, positionOffset, 0);
		}

		// Token: 0x060355B4 RID: 218548 RVA: 0x0072815E File Offset: 0x0072635E
		public static void AddLockFacingCamera(FlatBufferBuilder builder, bool lockFacingCamera)
		{
			builder.AddBool(2, lockFacingCamera, false);
		}

		// Token: 0x060355B5 RID: 218549 RVA: 0x00728169 File Offset: 0x00726369
		public static void AddIsOccluded(FlatBufferBuilder builder, bool isOccluded)
		{
			builder.AddBool(3, isOccluded, false);
		}

		// Token: 0x060355B6 RID: 218550 RVA: 0x00728174 File Offset: 0x00726374
		public static void AddLocalizationConfig(FlatBufferBuilder builder, Offset<ISceneUiSubtitleLocalizationConfig> localizationConfigOffset)
		{
			builder.AddOffset(4, localizationConfigOffset.Value, 0);
		}

		// Token: 0x060355B7 RID: 218551 RVA: 0x00728184 File Offset: 0x00726384
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitleStyleType type)
		{
			builder.AddByte(5, (byte)type, 0);
		}

		// Token: 0x060355B8 RID: 218552 RVA: 0x0072818F File Offset: 0x0072638F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060355B9 RID: 218553 RVA: 0x0072819A File Offset: 0x0072639A
		public static Offset<ISceneUiSubtitleAppear> EndISceneUiSubtitleAppear(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleAppear>(builder.EndTable());
		}

		// Token: 0x060355BA RID: 218554 RVA: 0x007281A8 File Offset: 0x007263A8
		public ISceneUiSubtitleAppearT UnPack()
		{
			ISceneUiSubtitleAppearT sceneUiSubtitleAppearT = new ISceneUiSubtitleAppearT();
			this.UnPackTo(sceneUiSubtitleAppearT);
			return sceneUiSubtitleAppearT;
		}

		// Token: 0x060355BB RID: 218555 RVA: 0x007281C4 File Offset: 0x007263C4
		public void UnPackTo(ISceneUiSubtitleAppearT _o)
		{
			_o.Position = new TSceneUiSubtitlePositionUnion();
			_o.Position.Type = this.PositionType;
			TSceneUiSubtitlePosition positionType = this.PositionType;
			if (positionType != TSceneUiSubtitlePosition.ISceneUiSubtitlePosition)
			{
				if (positionType == TSceneUiSubtitlePosition.ISceneUiSubtitlePositionEntity)
				{
					_o.Position.Value = ((this.Position<ISceneUiSubtitlePositionEntity>() != null) ? this.Position<ISceneUiSubtitlePositionEntity>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Position.Value = ((this.Position<ISceneUiSubtitlePosition>() != null) ? this.Position<ISceneUiSubtitlePosition>().Value.UnPack() : null);
			}
			_o.LockFacingCamera = this.LockFacingCamera;
			_o.IsOccluded = this.IsOccluded;
			_o.LocalizationConfig = ((this.LocalizationConfig != null) ? this.LocalizationConfig.Value.UnPack() : null);
			_o.Type = this.Type;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060355BC RID: 218556 RVA: 0x007282CC File Offset: 0x007264CC
		public static Offset<ISceneUiSubtitleAppear> Pack(FlatBufferBuilder builder, ISceneUiSubtitleAppearT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleAppear>);
			}
			TSceneUiSubtitlePosition position_type = (_o.Position == null) ? TSceneUiSubtitlePosition.NONE : _o.Position.Type;
			int positionOffset = (_o.Position == null) ? 0 : TSceneUiSubtitlePositionUnion.Pack(builder, _o.Position);
			Offset<ISceneUiSubtitleLocalizationConfig> localizationConfigOffset = (_o.LocalizationConfig == null) ? default(Offset<ISceneUiSubtitleLocalizationConfig>) : ISceneUiSubtitleLocalizationConfig.Pack(builder, _o.LocalizationConfig);
			return ISceneUiSubtitleAppear.CreateISceneUiSubtitleAppear(builder, position_type, positionOffset, _o.LockFacingCamera, _o.IsOccluded, localizationConfigOffset, _o.Type, _o.NullMask);
		}

		// Token: 0x040128C7 RID: 75975
		private Table __p;
	}
}
