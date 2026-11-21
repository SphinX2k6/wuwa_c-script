using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C2F RID: 31791
	public struct ITransitionPopupArtText : IFlatbufferObject
	{
		// Token: 0x1700EE0B RID: 60939
		// (get) Token: 0x060394D5 RID: 234709 RVA: 0x007BD18C File Offset: 0x007BB38C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060394D6 RID: 234710 RVA: 0x007BD199 File Offset: 0x007BB399
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060394D7 RID: 234711 RVA: 0x007BD1A0 File Offset: 0x007BB3A0
		public static ITransitionPopupArtText GetRootAsITransitionPopupArtText(ByteBuffer _bb)
		{
			return ITransitionPopupArtText.GetRootAsITransitionPopupArtText(_bb, default(ITransitionPopupArtText));
		}

		// Token: 0x060394D8 RID: 234712 RVA: 0x007BD1BC File Offset: 0x007BB3BC
		public static ITransitionPopupArtText GetRootAsITransitionPopupArtText(ByteBuffer _bb, ITransitionPopupArtText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060394D9 RID: 234713 RVA: 0x007BD1D9 File Offset: 0x007BB3D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060394DA RID: 234714 RVA: 0x007BD1E8 File Offset: 0x007BB3E8
		public ITransitionPopupArtText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE0C RID: 60940
		// (get) Token: 0x060394DB RID: 234715 RVA: 0x007BD1F8 File Offset: 0x007BB3F8
		public ETransitionPopupStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETransitionPopupStyleType.LeftTopTip;
				}
				return (ETransitionPopupStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EE0D RID: 60941
		// (get) Token: 0x060394DC RID: 234716 RVA: 0x007BD234 File Offset: 0x007BB434
		public ITransitionPopupYuanChengArtText? ArtTextType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITransitionPopupYuanChengArtText?(default(ITransitionPopupYuanChengArtText).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060394DD RID: 234717 RVA: 0x007BD291 File Offset: 0x007BB491
		public static Offset<ITransitionPopupArtText> CreateITransitionPopupArtText(FlatBufferBuilder builder, ETransitionPopupStyleType Type = ETransitionPopupStyleType.LeftTopTip, Offset<ITransitionPopupYuanChengArtText> ArtTextTypeOffset = default(Offset<ITransitionPopupYuanChengArtText>))
		{
			builder.StartTable(2);
			ITransitionPopupArtText.AddArtTextType(builder, ArtTextTypeOffset);
			ITransitionPopupArtText.AddType(builder, Type);
			return ITransitionPopupArtText.EndITransitionPopupArtText(builder);
		}

		// Token: 0x060394DE RID: 234718 RVA: 0x007BD2AE File Offset: 0x007BB4AE
		public static void StartITransitionPopupArtText(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060394DF RID: 234719 RVA: 0x007BD2B7 File Offset: 0x007BB4B7
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060394E0 RID: 234720 RVA: 0x007BD2C2 File Offset: 0x007BB4C2
		public static void AddArtTextType(FlatBufferBuilder builder, Offset<ITransitionPopupYuanChengArtText> artTextTypeOffset)
		{
			builder.AddOffset(1, artTextTypeOffset.Value, 0);
		}

		// Token: 0x060394E1 RID: 234721 RVA: 0x007BD2D2 File Offset: 0x007BB4D2
		public static Offset<ITransitionPopupArtText> EndITransitionPopupArtText(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupArtText>(builder.EndTable());
		}

		// Token: 0x060394E2 RID: 234722 RVA: 0x007BD2E0 File Offset: 0x007BB4E0
		public ITransitionPopupArtTextT UnPack()
		{
			ITransitionPopupArtTextT transitionPopupArtTextT = new ITransitionPopupArtTextT();
			this.UnPackTo(transitionPopupArtTextT);
			return transitionPopupArtTextT;
		}

		// Token: 0x060394E3 RID: 234723 RVA: 0x007BD2FC File Offset: 0x007BB4FC
		public void UnPackTo(ITransitionPopupArtTextT _o)
		{
			_o.Type = this.Type;
			_o.ArtTextType = ((this.ArtTextType != null) ? this.ArtTextType.Value.UnPack() : null);
		}

		// Token: 0x060394E4 RID: 234724 RVA: 0x007BD344 File Offset: 0x007BB544
		public static Offset<ITransitionPopupArtText> Pack(FlatBufferBuilder builder, ITransitionPopupArtTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupArtText>);
			}
			Offset<ITransitionPopupYuanChengArtText> artTextTypeOffset = (_o.ArtTextType == null) ? default(Offset<ITransitionPopupYuanChengArtText>) : ITransitionPopupYuanChengArtText.Pack(builder, _o.ArtTextType);
			return ITransitionPopupArtText.CreateITransitionPopupArtText(builder, _o.Type, artTextTypeOffset);
		}

		// Token: 0x040132E2 RID: 78562
		private Table __p;
	}
}
