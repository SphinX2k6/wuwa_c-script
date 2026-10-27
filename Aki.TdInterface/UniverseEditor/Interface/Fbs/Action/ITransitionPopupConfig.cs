using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007445 RID: 29765
	public struct ITransitionPopupConfig : IFlatbufferObject
	{
		// Token: 0x1700E1F8 RID: 57848
		// (get) Token: 0x06036120 RID: 221472 RVA: 0x0075A95E File Offset: 0x00758B5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036121 RID: 221473 RVA: 0x0075A96B File Offset: 0x00758B6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036122 RID: 221474 RVA: 0x0075A974 File Offset: 0x00758B74
		public static ITransitionPopupConfig GetRootAsITransitionPopupConfig(ByteBuffer _bb)
		{
			return ITransitionPopupConfig.GetRootAsITransitionPopupConfig(_bb, default(ITransitionPopupConfig));
		}

		// Token: 0x06036123 RID: 221475 RVA: 0x0075A990 File Offset: 0x00758B90
		public static ITransitionPopupConfig GetRootAsITransitionPopupConfig(ByteBuffer _bb, ITransitionPopupConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036124 RID: 221476 RVA: 0x0075A9AD File Offset: 0x00758BAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036125 RID: 221477 RVA: 0x0075A9BC File Offset: 0x00758BBC
		public ITransitionPopupConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1F9 RID: 57849
		// (get) Token: 0x06036126 RID: 221478 RVA: 0x0075A9CC File Offset: 0x00758BCC
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1FA RID: 57850
		// (get) Token: 0x06036127 RID: 221479 RVA: 0x0075AA0C File Offset: 0x00758C0C
		public TTransitionPopupStyle PopupStyleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTransitionPopupStyle.NONE;
				}
				return (TTransitionPopupStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036128 RID: 221480 RVA: 0x0075AA48 File Offset: 0x00758C48
		public TTable? PopupStyle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036129 RID: 221481 RVA: 0x0075AA8C File Offset: 0x00758C8C
		public ITransitionPopupArtText PopupStyleAsITransitionPopupArtText()
		{
			return this.PopupStyle<ITransitionPopupArtText>().Value;
		}

		// Token: 0x0603612A RID: 221482 RVA: 0x0075AAA8 File Offset: 0x00758CA8
		public ITransitionPopupLeftBottomTransition PopupStyleAsITransitionPopupLeftBottomTransition()
		{
			return this.PopupStyle<ITransitionPopupLeftBottomTransition>().Value;
		}

		// Token: 0x0603612B RID: 221483 RVA: 0x0075AAC4 File Offset: 0x00758CC4
		public ITransitionPopupLeftTopTip PopupStyleAsITransitionPopupLeftTopTip()
		{
			return this.PopupStyle<ITransitionPopupLeftTopTip>().Value;
		}

		// Token: 0x1700E1FB RID: 57851
		// (get) Token: 0x0603612C RID: 221484 RVA: 0x0075AAE0 File Offset: 0x00758CE0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603612D RID: 221485 RVA: 0x0075AB1D File Offset: 0x00758D1D
		public static Offset<ITransitionPopupConfig> CreateITransitionPopupConfig(FlatBufferBuilder builder, float Duration = 0f, TTransitionPopupStyle PopupStyle_type = TTransitionPopupStyle.NONE, int PopupStyleOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITransitionPopupConfig.AddPopupStyle(builder, PopupStyleOffset);
			ITransitionPopupConfig.AddDuration(builder, Duration);
			ITransitionPopupConfig.AddNullMask(builder, NullMask);
			ITransitionPopupConfig.AddPopupStyleType(builder, PopupStyle_type);
			return ITransitionPopupConfig.EndITransitionPopupConfig(builder);
		}

		// Token: 0x0603612E RID: 221486 RVA: 0x0075AB49 File Offset: 0x00758D49
		public static void StartITransitionPopupConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603612F RID: 221487 RVA: 0x0075AB52 File Offset: 0x00758D52
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(0, duration, 0.0);
		}

		// Token: 0x06036130 RID: 221488 RVA: 0x0075AB65 File Offset: 0x00758D65
		public static void AddPopupStyleType(FlatBufferBuilder builder, TTransitionPopupStyle popupStyleType)
		{
			builder.AddByte(1, (byte)popupStyleType, 0);
		}

		// Token: 0x06036131 RID: 221489 RVA: 0x0075AB70 File Offset: 0x00758D70
		public static void AddPopupStyle(FlatBufferBuilder builder, int popupStyleOffset)
		{
			builder.AddOffset(2, popupStyleOffset, 0);
		}

		// Token: 0x06036132 RID: 221490 RVA: 0x0075AB7B File Offset: 0x00758D7B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036133 RID: 221491 RVA: 0x0075AB86 File Offset: 0x00758D86
		public static Offset<ITransitionPopupConfig> EndITransitionPopupConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupConfig>(builder.EndTable());
		}

		// Token: 0x06036134 RID: 221492 RVA: 0x0075AB94 File Offset: 0x00758D94
		public ITransitionPopupConfigT UnPack()
		{
			ITransitionPopupConfigT transitionPopupConfigT = new ITransitionPopupConfigT();
			this.UnPackTo(transitionPopupConfigT);
			return transitionPopupConfigT;
		}

		// Token: 0x06036135 RID: 221493 RVA: 0x0075ABB0 File Offset: 0x00758DB0
		public void UnPackTo(ITransitionPopupConfigT _o)
		{
			_o.Duration = this.Duration;
			_o.PopupStyle = new TTransitionPopupStyleUnion();
			_o.PopupStyle.Type = this.PopupStyleType;
			switch (this.PopupStyleType)
			{
			case TTransitionPopupStyle.ITransitionPopupArtText:
				_o.PopupStyle.Value = ((this.PopupStyle<ITransitionPopupArtText>() != null) ? this.PopupStyle<ITransitionPopupArtText>().Value.UnPack() : null);
				break;
			case TTransitionPopupStyle.ITransitionPopupLeftBottomTransition:
				_o.PopupStyle.Value = ((this.PopupStyle<ITransitionPopupLeftBottomTransition>() != null) ? this.PopupStyle<ITransitionPopupLeftBottomTransition>().Value.UnPack() : null);
				break;
			case TTransitionPopupStyle.ITransitionPopupLeftTopTip:
				_o.PopupStyle.Value = ((this.PopupStyle<ITransitionPopupLeftTopTip>() != null) ? this.PopupStyle<ITransitionPopupLeftTopTip>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036136 RID: 221494 RVA: 0x0075ACB8 File Offset: 0x00758EB8
		public static Offset<ITransitionPopupConfig> Pack(FlatBufferBuilder builder, ITransitionPopupConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupConfig>);
			}
			TTransitionPopupStyle popupStyle_type = (_o.PopupStyle == null) ? TTransitionPopupStyle.NONE : _o.PopupStyle.Type;
			int popupStyleOffset = (_o.PopupStyle == null) ? 0 : TTransitionPopupStyleUnion.Pack(builder, _o.PopupStyle);
			return ITransitionPopupConfig.CreateITransitionPopupConfig(builder, _o.Duration, popupStyle_type, popupStyleOffset, _o.NullMask);
		}

		// Token: 0x040122C6 RID: 74438
		private Table __p;
	}
}
