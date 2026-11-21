using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D5 RID: 30421
	public struct ISceneUiSubtitleLanguageOverride : IFlatbufferObject
	{
		// Token: 0x1700DF28 RID: 57128
		// (get) Token: 0x060355F1 RID: 218609 RVA: 0x00728A61 File Offset: 0x00726C61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060355F2 RID: 218610 RVA: 0x00728A6E File Offset: 0x00726C6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060355F3 RID: 218611 RVA: 0x00728A78 File Offset: 0x00726C78
		public static ISceneUiSubtitleLanguageOverride GetRootAsISceneUiSubtitleLanguageOverride(ByteBuffer _bb)
		{
			return ISceneUiSubtitleLanguageOverride.GetRootAsISceneUiSubtitleLanguageOverride(_bb, default(ISceneUiSubtitleLanguageOverride));
		}

		// Token: 0x060355F4 RID: 218612 RVA: 0x00728A94 File Offset: 0x00726C94
		public static ISceneUiSubtitleLanguageOverride GetRootAsISceneUiSubtitleLanguageOverride(ByteBuffer _bb, ISceneUiSubtitleLanguageOverride obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060355F5 RID: 218613 RVA: 0x00728AB1 File Offset: 0x00726CB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060355F6 RID: 218614 RVA: 0x00728AC0 File Offset: 0x00726CC0
		public ISceneUiSubtitleLanguageOverride __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF29 RID: 57129
		// (get) Token: 0x060355F7 RID: 218615 RVA: 0x00728AD0 File Offset: 0x00726CD0
		public string Language
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060355F8 RID: 218616 RVA: 0x00728B07 File Offset: 0x00726D07
		public Span<byte> GetLanguageBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060355F9 RID: 218617 RVA: 0x00728B16 File Offset: 0x00726D16
		public byte[] GetLanguageArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DF2A RID: 57130
		// (get) Token: 0x060355FA RID: 218618 RVA: 0x00728B24 File Offset: 0x00726D24
		public TSceneUiSubtitlePosition PositionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSceneUiSubtitlePosition.NONE;
				}
				return (TSceneUiSubtitlePosition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060355FB RID: 218619 RVA: 0x00728B60 File Offset: 0x00726D60
		public TTable? Position<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060355FC RID: 218620 RVA: 0x00728BA4 File Offset: 0x00726DA4
		public ISceneUiSubtitlePosition PositionAsISceneUiSubtitlePosition()
		{
			return this.Position<ISceneUiSubtitlePosition>().Value;
		}

		// Token: 0x060355FD RID: 218621 RVA: 0x00728BC0 File Offset: 0x00726DC0
		public ISceneUiSubtitlePositionEntity PositionAsISceneUiSubtitlePositionEntity()
		{
			return this.Position<ISceneUiSubtitlePositionEntity>().Value;
		}

		// Token: 0x1700DF2B RID: 57131
		// (get) Token: 0x060355FE RID: 218622 RVA: 0x00728BDC File Offset: 0x00726DDC
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF2C RID: 57132
		// (get) Token: 0x060355FF RID: 218623 RVA: 0x00728C20 File Offset: 0x00726E20
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035600 RID: 218624 RVA: 0x00728C5D File Offset: 0x00726E5D
		public static Offset<ISceneUiSubtitleLanguageOverride> CreateISceneUiSubtitleLanguageOverride(FlatBufferBuilder builder, StringOffset LanguageOffset = default(StringOffset), TSceneUiSubtitlePosition Position_type = TSceneUiSubtitlePosition.NONE, int PositionOffset = 0, float Scale = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISceneUiSubtitleLanguageOverride.AddScale(builder, Scale);
			ISceneUiSubtitleLanguageOverride.AddPosition(builder, PositionOffset);
			ISceneUiSubtitleLanguageOverride.AddLanguage(builder, LanguageOffset);
			ISceneUiSubtitleLanguageOverride.AddNullMask(builder, NullMask);
			ISceneUiSubtitleLanguageOverride.AddPositionType(builder, Position_type);
			return ISceneUiSubtitleLanguageOverride.EndISceneUiSubtitleLanguageOverride(builder);
		}

		// Token: 0x06035601 RID: 218625 RVA: 0x00728C91 File Offset: 0x00726E91
		public static void StartISceneUiSubtitleLanguageOverride(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06035602 RID: 218626 RVA: 0x00728C9A File Offset: 0x00726E9A
		public static void AddLanguage(FlatBufferBuilder builder, StringOffset languageOffset)
		{
			builder.AddOffset(0, languageOffset.Value, 0);
		}

		// Token: 0x06035603 RID: 218627 RVA: 0x00728CAA File Offset: 0x00726EAA
		public static void AddPositionType(FlatBufferBuilder builder, TSceneUiSubtitlePosition positionType)
		{
			builder.AddByte(1, (byte)positionType, 0);
		}

		// Token: 0x06035604 RID: 218628 RVA: 0x00728CB5 File Offset: 0x00726EB5
		public static void AddPosition(FlatBufferBuilder builder, int positionOffset)
		{
			builder.AddOffset(2, positionOffset, 0);
		}

		// Token: 0x06035605 RID: 218629 RVA: 0x00728CC0 File Offset: 0x00726EC0
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(3, scale, 0.0);
		}

		// Token: 0x06035606 RID: 218630 RVA: 0x00728CD3 File Offset: 0x00726ED3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06035607 RID: 218631 RVA: 0x00728CDE File Offset: 0x00726EDE
		public static Offset<ISceneUiSubtitleLanguageOverride> EndISceneUiSubtitleLanguageOverride(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleLanguageOverride>(builder.EndTable());
		}

		// Token: 0x06035608 RID: 218632 RVA: 0x00728CEC File Offset: 0x00726EEC
		public ISceneUiSubtitleLanguageOverrideT UnPack()
		{
			ISceneUiSubtitleLanguageOverrideT sceneUiSubtitleLanguageOverrideT = new ISceneUiSubtitleLanguageOverrideT();
			this.UnPackTo(sceneUiSubtitleLanguageOverrideT);
			return sceneUiSubtitleLanguageOverrideT;
		}

		// Token: 0x06035609 RID: 218633 RVA: 0x00728D08 File Offset: 0x00726F08
		public void UnPackTo(ISceneUiSubtitleLanguageOverrideT _o)
		{
			_o.Language = this.Language;
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
			_o.Scale = this.Scale;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603560A RID: 218634 RVA: 0x00728DD4 File Offset: 0x00726FD4
		public static Offset<ISceneUiSubtitleLanguageOverride> Pack(FlatBufferBuilder builder, ISceneUiSubtitleLanguageOverrideT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleLanguageOverride>);
			}
			StringOffset languageOffset = (_o.Language == null) ? default(StringOffset) : builder.CreateString(_o.Language);
			TSceneUiSubtitlePosition position_type = (_o.Position == null) ? TSceneUiSubtitlePosition.NONE : _o.Position.Type;
			int positionOffset = (_o.Position == null) ? 0 : TSceneUiSubtitlePositionUnion.Pack(builder, _o.Position);
			return ISceneUiSubtitleLanguageOverride.CreateISceneUiSubtitleLanguageOverride(builder, languageOffset, position_type, positionOffset, _o.Scale, _o.NullMask);
		}

		// Token: 0x040128D4 RID: 75988
		private Table __p;
	}
}
