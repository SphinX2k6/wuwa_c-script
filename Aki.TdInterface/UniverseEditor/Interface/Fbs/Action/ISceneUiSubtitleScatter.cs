using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076ED RID: 30445
	public struct ISceneUiSubtitleScatter : IFlatbufferObject
	{
		// Token: 0x1700DF48 RID: 57160
		// (get) Token: 0x06035699 RID: 218777 RVA: 0x00729C66 File Offset: 0x00727E66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603569A RID: 218778 RVA: 0x00729C73 File Offset: 0x00727E73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603569B RID: 218779 RVA: 0x00729C7C File Offset: 0x00727E7C
		public static ISceneUiSubtitleScatter GetRootAsISceneUiSubtitleScatter(ByteBuffer _bb)
		{
			return ISceneUiSubtitleScatter.GetRootAsISceneUiSubtitleScatter(_bb, default(ISceneUiSubtitleScatter));
		}

		// Token: 0x0603569C RID: 218780 RVA: 0x00729C98 File Offset: 0x00727E98
		public static ISceneUiSubtitleScatter GetRootAsISceneUiSubtitleScatter(ByteBuffer _bb, ISceneUiSubtitleScatter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603569D RID: 218781 RVA: 0x00729CB5 File Offset: 0x00727EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603569E RID: 218782 RVA: 0x00729CC4 File Offset: 0x00727EC4
		public ISceneUiSubtitleScatter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF49 RID: 57161
		// (get) Token: 0x0603569F RID: 218783 RVA: 0x00729CD4 File Offset: 0x00727ED4
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

		// Token: 0x060356A0 RID: 218784 RVA: 0x00729D10 File Offset: 0x00727F10
		public TTable? Position<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060356A1 RID: 218785 RVA: 0x00729D54 File Offset: 0x00727F54
		public ISceneUiSubtitlePosition PositionAsISceneUiSubtitlePosition()
		{
			return this.Position<ISceneUiSubtitlePosition>().Value;
		}

		// Token: 0x060356A2 RID: 218786 RVA: 0x00729D70 File Offset: 0x00727F70
		public ISceneUiSubtitlePositionEntity PositionAsISceneUiSubtitlePositionEntity()
		{
			return this.Position<ISceneUiSubtitlePositionEntity>().Value;
		}

		// Token: 0x1700DF4A RID: 57162
		// (get) Token: 0x060356A3 RID: 218787 RVA: 0x00729D8C File Offset: 0x00727F8C
		public bool LockFacingCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF4B RID: 57163
		// (get) Token: 0x060356A4 RID: 218788 RVA: 0x00729DCC File Offset: 0x00727FCC
		public bool IsOccluded
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF4C RID: 57164
		// (get) Token: 0x060356A5 RID: 218789 RVA: 0x00729E0C File Offset: 0x0072800C
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

		// Token: 0x1700DF4D RID: 57165
		// (get) Token: 0x060356A6 RID: 218790 RVA: 0x00729E6C File Offset: 0x0072806C
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

		// Token: 0x1700DF4E RID: 57166
		// (get) Token: 0x060356A7 RID: 218791 RVA: 0x00729EAC File Offset: 0x007280AC
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

		// Token: 0x060356A8 RID: 218792 RVA: 0x00729EEC File Offset: 0x007280EC
		public static Offset<ISceneUiSubtitleScatter> CreateISceneUiSubtitleScatter(FlatBufferBuilder builder, TSceneUiSubtitlePosition Position_type = TSceneUiSubtitlePosition.NONE, int PositionOffset = 0, bool LockFacingCamera = false, bool IsOccluded = false, Offset<ISceneUiSubtitleLocalizationConfig> LocalizationConfigOffset = default(Offset<ISceneUiSubtitleLocalizationConfig>), ESceneUiSubtitleStyleType Type = ESceneUiSubtitleStyleType.SceneUiSubtitleScatter, byte NullMask = 0)
		{
			builder.StartTable(7);
			ISceneUiSubtitleScatter.AddLocalizationConfig(builder, LocalizationConfigOffset);
			ISceneUiSubtitleScatter.AddPosition(builder, PositionOffset);
			ISceneUiSubtitleScatter.AddNullMask(builder, NullMask);
			ISceneUiSubtitleScatter.AddType(builder, Type);
			ISceneUiSubtitleScatter.AddIsOccluded(builder, IsOccluded);
			ISceneUiSubtitleScatter.AddLockFacingCamera(builder, LockFacingCamera);
			ISceneUiSubtitleScatter.AddPositionType(builder, Position_type);
			return ISceneUiSubtitleScatter.EndISceneUiSubtitleScatter(builder);
		}

		// Token: 0x060356A9 RID: 218793 RVA: 0x00729F3B File Offset: 0x0072813B
		public static void StartISceneUiSubtitleScatter(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060356AA RID: 218794 RVA: 0x00729F44 File Offset: 0x00728144
		public static void AddPositionType(FlatBufferBuilder builder, TSceneUiSubtitlePosition positionType)
		{
			builder.AddByte(0, (byte)positionType, 0);
		}

		// Token: 0x060356AB RID: 218795 RVA: 0x00729F4F File Offset: 0x0072814F
		public static void AddPosition(FlatBufferBuilder builder, int positionOffset)
		{
			builder.AddOffset(1, positionOffset, 0);
		}

		// Token: 0x060356AC RID: 218796 RVA: 0x00729F5A File Offset: 0x0072815A
		public static void AddLockFacingCamera(FlatBufferBuilder builder, bool lockFacingCamera)
		{
			builder.AddBool(2, lockFacingCamera, false);
		}

		// Token: 0x060356AD RID: 218797 RVA: 0x00729F65 File Offset: 0x00728165
		public static void AddIsOccluded(FlatBufferBuilder builder, bool isOccluded)
		{
			builder.AddBool(3, isOccluded, false);
		}

		// Token: 0x060356AE RID: 218798 RVA: 0x00729F70 File Offset: 0x00728170
		public static void AddLocalizationConfig(FlatBufferBuilder builder, Offset<ISceneUiSubtitleLocalizationConfig> localizationConfigOffset)
		{
			builder.AddOffset(4, localizationConfigOffset.Value, 0);
		}

		// Token: 0x060356AF RID: 218799 RVA: 0x00729F80 File Offset: 0x00728180
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitleStyleType type)
		{
			builder.AddByte(5, (byte)type, 0);
		}

		// Token: 0x060356B0 RID: 218800 RVA: 0x00729F8B File Offset: 0x0072818B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060356B1 RID: 218801 RVA: 0x00729F96 File Offset: 0x00728196
		public static Offset<ISceneUiSubtitleScatter> EndISceneUiSubtitleScatter(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleScatter>(builder.EndTable());
		}

		// Token: 0x060356B2 RID: 218802 RVA: 0x00729FA4 File Offset: 0x007281A4
		public ISceneUiSubtitleScatterT UnPack()
		{
			ISceneUiSubtitleScatterT sceneUiSubtitleScatterT = new ISceneUiSubtitleScatterT();
			this.UnPackTo(sceneUiSubtitleScatterT);
			return sceneUiSubtitleScatterT;
		}

		// Token: 0x060356B3 RID: 218803 RVA: 0x00729FC0 File Offset: 0x007281C0
		public void UnPackTo(ISceneUiSubtitleScatterT _o)
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

		// Token: 0x060356B4 RID: 218804 RVA: 0x0072A0C8 File Offset: 0x007282C8
		public static Offset<ISceneUiSubtitleScatter> Pack(FlatBufferBuilder builder, ISceneUiSubtitleScatterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleScatter>);
			}
			TSceneUiSubtitlePosition position_type = (_o.Position == null) ? TSceneUiSubtitlePosition.NONE : _o.Position.Type;
			int positionOffset = (_o.Position == null) ? 0 : TSceneUiSubtitlePositionUnion.Pack(builder, _o.Position);
			Offset<ISceneUiSubtitleLocalizationConfig> localizationConfigOffset = (_o.LocalizationConfig == null) ? default(Offset<ISceneUiSubtitleLocalizationConfig>) : ISceneUiSubtitleLocalizationConfig.Pack(builder, _o.LocalizationConfig);
			return ISceneUiSubtitleScatter.CreateISceneUiSubtitleScatter(builder, position_type, positionOffset, _o.LockFacingCamera, _o.IsOccluded, localizationConfigOffset, _o.Type, _o.NullMask);
		}

		// Token: 0x040128F3 RID: 76019
		private Table __p;
	}
}
