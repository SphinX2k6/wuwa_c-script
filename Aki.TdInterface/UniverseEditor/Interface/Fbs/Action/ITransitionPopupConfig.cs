using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C38 RID: 31800
	public struct ITransitionPopupConfig : IFlatbufferObject
	{
		// Token: 0x1700EE15 RID: 60949
		// (get) Token: 0x06039509 RID: 234761 RVA: 0x007BD68A File Offset: 0x007BB88A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603950A RID: 234762 RVA: 0x007BD697 File Offset: 0x007BB897
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603950B RID: 234763 RVA: 0x007BD6A0 File Offset: 0x007BB8A0
		public static ITransitionPopupConfig GetRootAsITransitionPopupConfig(ByteBuffer _bb)
		{
			return ITransitionPopupConfig.GetRootAsITransitionPopupConfig(_bb, default(ITransitionPopupConfig));
		}

		// Token: 0x0603950C RID: 234764 RVA: 0x007BD6BC File Offset: 0x007BB8BC
		public static ITransitionPopupConfig GetRootAsITransitionPopupConfig(ByteBuffer _bb, ITransitionPopupConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603950D RID: 234765 RVA: 0x007BD6D9 File Offset: 0x007BB8D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603950E RID: 234766 RVA: 0x007BD6E8 File Offset: 0x007BB8E8
		public ITransitionPopupConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE16 RID: 60950
		// (get) Token: 0x0603950F RID: 234767 RVA: 0x007BD6F8 File Offset: 0x007BB8F8
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

		// Token: 0x1700EE17 RID: 60951
		// (get) Token: 0x06039510 RID: 234768 RVA: 0x007BD738 File Offset: 0x007BB938
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

		// Token: 0x06039511 RID: 234769 RVA: 0x007BD774 File Offset: 0x007BB974
		public TTable? PopupStyle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039512 RID: 234770 RVA: 0x007BD7B8 File Offset: 0x007BB9B8
		public ITransitionPopupArtText PopupStyleAsITransitionPopupArtText()
		{
			return this.PopupStyle<ITransitionPopupArtText>().Value;
		}

		// Token: 0x06039513 RID: 234771 RVA: 0x007BD7D4 File Offset: 0x007BB9D4
		public ITransitionPopupLeftBottomTransition PopupStyleAsITransitionPopupLeftBottomTransition()
		{
			return this.PopupStyle<ITransitionPopupLeftBottomTransition>().Value;
		}

		// Token: 0x06039514 RID: 234772 RVA: 0x007BD7F0 File Offset: 0x007BB9F0
		public ITransitionPopupLeftTopTip PopupStyleAsITransitionPopupLeftTopTip()
		{
			return this.PopupStyle<ITransitionPopupLeftTopTip>().Value;
		}

		// Token: 0x1700EE18 RID: 60952
		// (get) Token: 0x06039515 RID: 234773 RVA: 0x007BD80C File Offset: 0x007BBA0C
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

		// Token: 0x06039516 RID: 234774 RVA: 0x007BD849 File Offset: 0x007BBA49
		public static Offset<ITransitionPopupConfig> CreateITransitionPopupConfig(FlatBufferBuilder builder, float Duration = 0f, TTransitionPopupStyle PopupStyle_type = TTransitionPopupStyle.NONE, int PopupStyleOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITransitionPopupConfig.AddPopupStyle(builder, PopupStyleOffset);
			ITransitionPopupConfig.AddDuration(builder, Duration);
			ITransitionPopupConfig.AddNullMask(builder, NullMask);
			ITransitionPopupConfig.AddPopupStyleType(builder, PopupStyle_type);
			return ITransitionPopupConfig.EndITransitionPopupConfig(builder);
		}

		// Token: 0x06039517 RID: 234775 RVA: 0x007BD875 File Offset: 0x007BBA75
		public static void StartITransitionPopupConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06039518 RID: 234776 RVA: 0x007BD87E File Offset: 0x007BBA7E
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(0, duration, 0.0);
		}

		// Token: 0x06039519 RID: 234777 RVA: 0x007BD891 File Offset: 0x007BBA91
		public static void AddPopupStyleType(FlatBufferBuilder builder, TTransitionPopupStyle popupStyleType)
		{
			builder.AddByte(1, (byte)popupStyleType, 0);
		}

		// Token: 0x0603951A RID: 234778 RVA: 0x007BD89C File Offset: 0x007BBA9C
		public static void AddPopupStyle(FlatBufferBuilder builder, int popupStyleOffset)
		{
			builder.AddOffset(2, popupStyleOffset, 0);
		}

		// Token: 0x0603951B RID: 234779 RVA: 0x007BD8A7 File Offset: 0x007BBAA7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603951C RID: 234780 RVA: 0x007BD8B2 File Offset: 0x007BBAB2
		public static Offset<ITransitionPopupConfig> EndITransitionPopupConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupConfig>(builder.EndTable());
		}

		// Token: 0x0603951D RID: 234781 RVA: 0x007BD8C0 File Offset: 0x007BBAC0
		public ITransitionPopupConfigT UnPack()
		{
			ITransitionPopupConfigT transitionPopupConfigT = new ITransitionPopupConfigT();
			this.UnPackTo(transitionPopupConfigT);
			return transitionPopupConfigT;
		}

		// Token: 0x0603951E RID: 234782 RVA: 0x007BD8DC File Offset: 0x007BBADC
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

		// Token: 0x0603951F RID: 234783 RVA: 0x007BD9E4 File Offset: 0x007BBBE4
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

		// Token: 0x040132ED RID: 78573
		private Table __p;
	}
}
