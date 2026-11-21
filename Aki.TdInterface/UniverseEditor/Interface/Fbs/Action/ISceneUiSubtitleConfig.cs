using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D2 RID: 30418
	public struct ISceneUiSubtitleConfig : IFlatbufferObject
	{
		// Token: 0x1700DF1D RID: 57117
		// (get) Token: 0x060355CB RID: 218571 RVA: 0x007284B1 File Offset: 0x007266B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060355CC RID: 218572 RVA: 0x007284BE File Offset: 0x007266BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060355CD RID: 218573 RVA: 0x007284C8 File Offset: 0x007266C8
		public static ISceneUiSubtitleConfig GetRootAsISceneUiSubtitleConfig(ByteBuffer _bb)
		{
			return ISceneUiSubtitleConfig.GetRootAsISceneUiSubtitleConfig(_bb, default(ISceneUiSubtitleConfig));
		}

		// Token: 0x060355CE RID: 218574 RVA: 0x007284E4 File Offset: 0x007266E4
		public static ISceneUiSubtitleConfig GetRootAsISceneUiSubtitleConfig(ByteBuffer _bb, ISceneUiSubtitleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060355CF RID: 218575 RVA: 0x00728501 File Offset: 0x00726701
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060355D0 RID: 218576 RVA: 0x00728510 File Offset: 0x00726710
		public ISceneUiSubtitleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF1E RID: 57118
		// (get) Token: 0x060355D1 RID: 218577 RVA: 0x00728520 File Offset: 0x00726720
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

		// Token: 0x060355D2 RID: 218578 RVA: 0x0072855C File Offset: 0x0072675C
		public TTable? Position<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060355D3 RID: 218579 RVA: 0x007285A0 File Offset: 0x007267A0
		public ISceneUiSubtitlePosition PositionAsISceneUiSubtitlePosition()
		{
			return this.Position<ISceneUiSubtitlePosition>().Value;
		}

		// Token: 0x060355D4 RID: 218580 RVA: 0x007285BC File Offset: 0x007267BC
		public ISceneUiSubtitlePositionEntity PositionAsISceneUiSubtitlePositionEntity()
		{
			return this.Position<ISceneUiSubtitlePositionEntity>().Value;
		}

		// Token: 0x1700DF1F RID: 57119
		// (get) Token: 0x060355D5 RID: 218581 RVA: 0x007285D8 File Offset: 0x007267D8
		public bool LockFacingCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF20 RID: 57120
		// (get) Token: 0x060355D6 RID: 218582 RVA: 0x00728618 File Offset: 0x00726818
		public bool IsOccluded
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF21 RID: 57121
		// (get) Token: 0x060355D7 RID: 218583 RVA: 0x00728658 File Offset: 0x00726858
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

		// Token: 0x1700DF22 RID: 57122
		// (get) Token: 0x060355D8 RID: 218584 RVA: 0x007286B8 File Offset: 0x007268B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060355D9 RID: 218585 RVA: 0x007286F5 File Offset: 0x007268F5
		public static Offset<ISceneUiSubtitleConfig> CreateISceneUiSubtitleConfig(FlatBufferBuilder builder, TSceneUiSubtitlePosition Position_type = TSceneUiSubtitlePosition.NONE, int PositionOffset = 0, bool LockFacingCamera = false, bool IsOccluded = false, Offset<ISceneUiSubtitleLocalizationConfig> LocalizationConfigOffset = default(Offset<ISceneUiSubtitleLocalizationConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			ISceneUiSubtitleConfig.AddLocalizationConfig(builder, LocalizationConfigOffset);
			ISceneUiSubtitleConfig.AddPosition(builder, PositionOffset);
			ISceneUiSubtitleConfig.AddNullMask(builder, NullMask);
			ISceneUiSubtitleConfig.AddIsOccluded(builder, IsOccluded);
			ISceneUiSubtitleConfig.AddLockFacingCamera(builder, LockFacingCamera);
			ISceneUiSubtitleConfig.AddPositionType(builder, Position_type);
			return ISceneUiSubtitleConfig.EndISceneUiSubtitleConfig(builder);
		}

		// Token: 0x060355DA RID: 218586 RVA: 0x00728731 File Offset: 0x00726931
		public static void StartISceneUiSubtitleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060355DB RID: 218587 RVA: 0x0072873A File Offset: 0x0072693A
		public static void AddPositionType(FlatBufferBuilder builder, TSceneUiSubtitlePosition positionType)
		{
			builder.AddByte(0, (byte)positionType, 0);
		}

		// Token: 0x060355DC RID: 218588 RVA: 0x00728745 File Offset: 0x00726945
		public static void AddPosition(FlatBufferBuilder builder, int positionOffset)
		{
			builder.AddOffset(1, positionOffset, 0);
		}

		// Token: 0x060355DD RID: 218589 RVA: 0x00728750 File Offset: 0x00726950
		public static void AddLockFacingCamera(FlatBufferBuilder builder, bool lockFacingCamera)
		{
			builder.AddBool(2, lockFacingCamera, false);
		}

		// Token: 0x060355DE RID: 218590 RVA: 0x0072875B File Offset: 0x0072695B
		public static void AddIsOccluded(FlatBufferBuilder builder, bool isOccluded)
		{
			builder.AddBool(3, isOccluded, false);
		}

		// Token: 0x060355DF RID: 218591 RVA: 0x00728766 File Offset: 0x00726966
		public static void AddLocalizationConfig(FlatBufferBuilder builder, Offset<ISceneUiSubtitleLocalizationConfig> localizationConfigOffset)
		{
			builder.AddOffset(4, localizationConfigOffset.Value, 0);
		}

		// Token: 0x060355E0 RID: 218592 RVA: 0x00728776 File Offset: 0x00726976
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060355E1 RID: 218593 RVA: 0x00728781 File Offset: 0x00726981
		public static Offset<ISceneUiSubtitleConfig> EndISceneUiSubtitleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleConfig>(builder.EndTable());
		}

		// Token: 0x060355E2 RID: 218594 RVA: 0x00728790 File Offset: 0x00726990
		public ISceneUiSubtitleConfigT UnPack()
		{
			ISceneUiSubtitleConfigT sceneUiSubtitleConfigT = new ISceneUiSubtitleConfigT();
			this.UnPackTo(sceneUiSubtitleConfigT);
			return sceneUiSubtitleConfigT;
		}

		// Token: 0x060355E3 RID: 218595 RVA: 0x007287AC File Offset: 0x007269AC
		public void UnPackTo(ISceneUiSubtitleConfigT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060355E4 RID: 218596 RVA: 0x007288A8 File Offset: 0x00726AA8
		public static Offset<ISceneUiSubtitleConfig> Pack(FlatBufferBuilder builder, ISceneUiSubtitleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleConfig>);
			}
			TSceneUiSubtitlePosition position_type = (_o.Position == null) ? TSceneUiSubtitlePosition.NONE : _o.Position.Type;
			int positionOffset = (_o.Position == null) ? 0 : TSceneUiSubtitlePositionUnion.Pack(builder, _o.Position);
			Offset<ISceneUiSubtitleLocalizationConfig> localizationConfigOffset = (_o.LocalizationConfig == null) ? default(Offset<ISceneUiSubtitleLocalizationConfig>) : ISceneUiSubtitleLocalizationConfig.Pack(builder, _o.LocalizationConfig);
			return ISceneUiSubtitleConfig.CreateISceneUiSubtitleConfig(builder, position_type, positionOffset, _o.LockFacingCamera, _o.IsOccluded, localizationConfigOffset, _o.NullMask);
		}

		// Token: 0x040128CE RID: 75982
		private Table __p;
	}
}
