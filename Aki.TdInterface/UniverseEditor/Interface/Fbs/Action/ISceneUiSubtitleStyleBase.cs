using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F0 RID: 30448
	public struct ISceneUiSubtitleStyleBase : IFlatbufferObject
	{
		// Token: 0x1700DF55 RID: 57173
		// (get) Token: 0x060356C3 RID: 218819 RVA: 0x0072A2AD File Offset: 0x007284AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060356C4 RID: 218820 RVA: 0x0072A2BA File Offset: 0x007284BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060356C5 RID: 218821 RVA: 0x0072A2C4 File Offset: 0x007284C4
		public static ISceneUiSubtitleStyleBase GetRootAsISceneUiSubtitleStyleBase(ByteBuffer _bb)
		{
			return ISceneUiSubtitleStyleBase.GetRootAsISceneUiSubtitleStyleBase(_bb, default(ISceneUiSubtitleStyleBase));
		}

		// Token: 0x060356C6 RID: 218822 RVA: 0x0072A2E0 File Offset: 0x007284E0
		public static ISceneUiSubtitleStyleBase GetRootAsISceneUiSubtitleStyleBase(ByteBuffer _bb, ISceneUiSubtitleStyleBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060356C7 RID: 218823 RVA: 0x0072A2FD File Offset: 0x007284FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060356C8 RID: 218824 RVA: 0x0072A30C File Offset: 0x0072850C
		public ISceneUiSubtitleStyleBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF56 RID: 57174
		// (get) Token: 0x060356C9 RID: 218825 RVA: 0x0072A31C File Offset: 0x0072851C
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

		// Token: 0x060356CA RID: 218826 RVA: 0x0072A358 File Offset: 0x00728558
		public TTable? Position<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060356CB RID: 218827 RVA: 0x0072A39C File Offset: 0x0072859C
		public ISceneUiSubtitlePosition PositionAsISceneUiSubtitlePosition()
		{
			return this.Position<ISceneUiSubtitlePosition>().Value;
		}

		// Token: 0x060356CC RID: 218828 RVA: 0x0072A3B8 File Offset: 0x007285B8
		public ISceneUiSubtitlePositionEntity PositionAsISceneUiSubtitlePositionEntity()
		{
			return this.Position<ISceneUiSubtitlePositionEntity>().Value;
		}

		// Token: 0x1700DF57 RID: 57175
		// (get) Token: 0x060356CD RID: 218829 RVA: 0x0072A3D4 File Offset: 0x007285D4
		public bool LockFacingCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF58 RID: 57176
		// (get) Token: 0x060356CE RID: 218830 RVA: 0x0072A414 File Offset: 0x00728614
		public bool IsOccluded
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF59 RID: 57177
		// (get) Token: 0x060356CF RID: 218831 RVA: 0x0072A454 File Offset: 0x00728654
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

		// Token: 0x1700DF5A RID: 57178
		// (get) Token: 0x060356D0 RID: 218832 RVA: 0x0072A4B4 File Offset: 0x007286B4
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

		// Token: 0x1700DF5B RID: 57179
		// (get) Token: 0x060356D1 RID: 218833 RVA: 0x0072A4F4 File Offset: 0x007286F4
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

		// Token: 0x060356D2 RID: 218834 RVA: 0x0072A534 File Offset: 0x00728734
		public static Offset<ISceneUiSubtitleStyleBase> CreateISceneUiSubtitleStyleBase(FlatBufferBuilder builder, TSceneUiSubtitlePosition Position_type = TSceneUiSubtitlePosition.NONE, int PositionOffset = 0, bool LockFacingCamera = false, bool IsOccluded = false, Offset<ISceneUiSubtitleLocalizationConfig> LocalizationConfigOffset = default(Offset<ISceneUiSubtitleLocalizationConfig>), ESceneUiSubtitleStyleType Type = ESceneUiSubtitleStyleType.SceneUiSubtitleScatter, byte NullMask = 0)
		{
			builder.StartTable(7);
			ISceneUiSubtitleStyleBase.AddLocalizationConfig(builder, LocalizationConfigOffset);
			ISceneUiSubtitleStyleBase.AddPosition(builder, PositionOffset);
			ISceneUiSubtitleStyleBase.AddNullMask(builder, NullMask);
			ISceneUiSubtitleStyleBase.AddType(builder, Type);
			ISceneUiSubtitleStyleBase.AddIsOccluded(builder, IsOccluded);
			ISceneUiSubtitleStyleBase.AddLockFacingCamera(builder, LockFacingCamera);
			ISceneUiSubtitleStyleBase.AddPositionType(builder, Position_type);
			return ISceneUiSubtitleStyleBase.EndISceneUiSubtitleStyleBase(builder);
		}

		// Token: 0x060356D3 RID: 218835 RVA: 0x0072A583 File Offset: 0x00728783
		public static void StartISceneUiSubtitleStyleBase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060356D4 RID: 218836 RVA: 0x0072A58C File Offset: 0x0072878C
		public static void AddPositionType(FlatBufferBuilder builder, TSceneUiSubtitlePosition positionType)
		{
			builder.AddByte(0, (byte)positionType, 0);
		}

		// Token: 0x060356D5 RID: 218837 RVA: 0x0072A597 File Offset: 0x00728797
		public static void AddPosition(FlatBufferBuilder builder, int positionOffset)
		{
			builder.AddOffset(1, positionOffset, 0);
		}

		// Token: 0x060356D6 RID: 218838 RVA: 0x0072A5A2 File Offset: 0x007287A2
		public static void AddLockFacingCamera(FlatBufferBuilder builder, bool lockFacingCamera)
		{
			builder.AddBool(2, lockFacingCamera, false);
		}

		// Token: 0x060356D7 RID: 218839 RVA: 0x0072A5AD File Offset: 0x007287AD
		public static void AddIsOccluded(FlatBufferBuilder builder, bool isOccluded)
		{
			builder.AddBool(3, isOccluded, false);
		}

		// Token: 0x060356D8 RID: 218840 RVA: 0x0072A5B8 File Offset: 0x007287B8
		public static void AddLocalizationConfig(FlatBufferBuilder builder, Offset<ISceneUiSubtitleLocalizationConfig> localizationConfigOffset)
		{
			builder.AddOffset(4, localizationConfigOffset.Value, 0);
		}

		// Token: 0x060356D9 RID: 218841 RVA: 0x0072A5C8 File Offset: 0x007287C8
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitleStyleType type)
		{
			builder.AddByte(5, (byte)type, 0);
		}

		// Token: 0x060356DA RID: 218842 RVA: 0x0072A5D3 File Offset: 0x007287D3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060356DB RID: 218843 RVA: 0x0072A5DE File Offset: 0x007287DE
		public static Offset<ISceneUiSubtitleStyleBase> EndISceneUiSubtitleStyleBase(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleStyleBase>(builder.EndTable());
		}

		// Token: 0x060356DC RID: 218844 RVA: 0x0072A5EC File Offset: 0x007287EC
		public ISceneUiSubtitleStyleBaseT UnPack()
		{
			ISceneUiSubtitleStyleBaseT sceneUiSubtitleStyleBaseT = new ISceneUiSubtitleStyleBaseT();
			this.UnPackTo(sceneUiSubtitleStyleBaseT);
			return sceneUiSubtitleStyleBaseT;
		}

		// Token: 0x060356DD RID: 218845 RVA: 0x0072A608 File Offset: 0x00728808
		public void UnPackTo(ISceneUiSubtitleStyleBaseT _o)
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

		// Token: 0x060356DE RID: 218846 RVA: 0x0072A710 File Offset: 0x00728910
		public static Offset<ISceneUiSubtitleStyleBase> Pack(FlatBufferBuilder builder, ISceneUiSubtitleStyleBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleStyleBase>);
			}
			TSceneUiSubtitlePosition position_type = (_o.Position == null) ? TSceneUiSubtitlePosition.NONE : _o.Position.Type;
			int positionOffset = (_o.Position == null) ? 0 : TSceneUiSubtitlePositionUnion.Pack(builder, _o.Position);
			Offset<ISceneUiSubtitleLocalizationConfig> localizationConfigOffset = (_o.LocalizationConfig == null) ? default(Offset<ISceneUiSubtitleLocalizationConfig>) : ISceneUiSubtitleLocalizationConfig.Pack(builder, _o.LocalizationConfig);
			return ISceneUiSubtitleStyleBase.CreateISceneUiSubtitleStyleBase(builder, position_type, positionOffset, _o.LockFacingCamera, _o.IsOccluded, localizationConfigOffset, _o.Type, _o.NullMask);
		}

		// Token: 0x040128FA RID: 76026
		private Table __p;
	}
}
