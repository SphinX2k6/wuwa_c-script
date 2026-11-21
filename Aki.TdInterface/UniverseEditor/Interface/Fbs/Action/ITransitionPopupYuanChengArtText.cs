using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C47 RID: 31815
	public struct ITransitionPopupYuanChengArtText : IFlatbufferObject
	{
		// Token: 0x1700EE2F RID: 60975
		// (get) Token: 0x06039586 RID: 234886 RVA: 0x007BE3EE File Offset: 0x007BC5EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039587 RID: 234887 RVA: 0x007BE3FB File Offset: 0x007BC5FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039588 RID: 234888 RVA: 0x007BE404 File Offset: 0x007BC604
		public static ITransitionPopupYuanChengArtText GetRootAsITransitionPopupYuanChengArtText(ByteBuffer _bb)
		{
			return ITransitionPopupYuanChengArtText.GetRootAsITransitionPopupYuanChengArtText(_bb, default(ITransitionPopupYuanChengArtText));
		}

		// Token: 0x06039589 RID: 234889 RVA: 0x007BE420 File Offset: 0x007BC620
		public static ITransitionPopupYuanChengArtText GetRootAsITransitionPopupYuanChengArtText(ByteBuffer _bb, ITransitionPopupYuanChengArtText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603958A RID: 234890 RVA: 0x007BE43D File Offset: 0x007BC63D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603958B RID: 234891 RVA: 0x007BE44C File Offset: 0x007BC64C
		public ITransitionPopupYuanChengArtText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE30 RID: 60976
		// (get) Token: 0x0603958C RID: 234892 RVA: 0x007BE45C File Offset: 0x007BC65C
		public ETransitionPopupArtTextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETransitionPopupArtTextType.YuanCheng;
				}
				return (ETransitionPopupArtTextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EE31 RID: 60977
		// (get) Token: 0x0603958D RID: 234893 RVA: 0x007BE498 File Offset: 0x007BC698
		public IVector2? Position
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700EE32 RID: 60978
		// (get) Token: 0x0603958E RID: 234894 RVA: 0x007BE4F8 File Offset: 0x007BC6F8
		public string Texture
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603958F RID: 234895 RVA: 0x007BE52F File Offset: 0x007BC72F
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06039590 RID: 234896 RVA: 0x007BE53E File Offset: 0x007BC73E
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700EE33 RID: 60979
		// (get) Token: 0x06039591 RID: 234897 RVA: 0x007BE54C File Offset: 0x007BC74C
		public string SubtitleText
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039592 RID: 234898 RVA: 0x007BE584 File Offset: 0x007BC784
		public Span<byte> GetSubtitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06039593 RID: 234899 RVA: 0x007BE594 File Offset: 0x007BC794
		public byte[] GetSubtitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06039594 RID: 234900 RVA: 0x007BE5A3 File Offset: 0x007BC7A3
		public static Offset<ITransitionPopupYuanChengArtText> CreateITransitionPopupYuanChengArtText(FlatBufferBuilder builder, ETransitionPopupArtTextType Type = ETransitionPopupArtTextType.YuanCheng, Offset<IVector2> PositionOffset = default(Offset<IVector2>), StringOffset TextureOffset = default(StringOffset), StringOffset SubtitleTextOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ITransitionPopupYuanChengArtText.AddSubtitleText(builder, SubtitleTextOffset);
			ITransitionPopupYuanChengArtText.AddTexture(builder, TextureOffset);
			ITransitionPopupYuanChengArtText.AddPosition(builder, PositionOffset);
			ITransitionPopupYuanChengArtText.AddType(builder, Type);
			return ITransitionPopupYuanChengArtText.EndITransitionPopupYuanChengArtText(builder);
		}

		// Token: 0x06039595 RID: 234901 RVA: 0x007BE5CF File Offset: 0x007BC7CF
		public static void StartITransitionPopupYuanChengArtText(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06039596 RID: 234902 RVA: 0x007BE5D8 File Offset: 0x007BC7D8
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupArtTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039597 RID: 234903 RVA: 0x007BE5E3 File Offset: 0x007BC7E3
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVector2> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06039598 RID: 234904 RVA: 0x007BE5F3 File Offset: 0x007BC7F3
		public static void AddTexture(FlatBufferBuilder builder, StringOffset textureOffset)
		{
			builder.AddOffset(2, textureOffset.Value, 0);
		}

		// Token: 0x06039599 RID: 234905 RVA: 0x007BE603 File Offset: 0x007BC803
		public static void AddSubtitleText(FlatBufferBuilder builder, StringOffset subtitleTextOffset)
		{
			builder.AddOffset(3, subtitleTextOffset.Value, 0);
		}

		// Token: 0x0603959A RID: 234906 RVA: 0x007BE613 File Offset: 0x007BC813
		public static Offset<ITransitionPopupYuanChengArtText> EndITransitionPopupYuanChengArtText(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupYuanChengArtText>(builder.EndTable());
		}

		// Token: 0x0603959B RID: 234907 RVA: 0x007BE620 File Offset: 0x007BC820
		public ITransitionPopupYuanChengArtTextT UnPack()
		{
			ITransitionPopupYuanChengArtTextT transitionPopupYuanChengArtTextT = new ITransitionPopupYuanChengArtTextT();
			this.UnPackTo(transitionPopupYuanChengArtTextT);
			return transitionPopupYuanChengArtTextT;
		}

		// Token: 0x0603959C RID: 234908 RVA: 0x007BE63C File Offset: 0x007BC83C
		public void UnPackTo(ITransitionPopupYuanChengArtTextT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Texture = this.Texture;
			_o.SubtitleText = this.SubtitleText;
		}

		// Token: 0x0603959D RID: 234909 RVA: 0x007BE69C File Offset: 0x007BC89C
		public static Offset<ITransitionPopupYuanChengArtText> Pack(FlatBufferBuilder builder, ITransitionPopupYuanChengArtTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupYuanChengArtText>);
			}
			Offset<IVector2> positionOffset = (_o.Position == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Position);
			StringOffset textureOffset = (_o.Texture == null) ? default(StringOffset) : builder.CreateString(_o.Texture);
			StringOffset subtitleTextOffset = (_o.SubtitleText == null) ? default(StringOffset) : builder.CreateString(_o.SubtitleText);
			return ITransitionPopupYuanChengArtText.CreateITransitionPopupYuanChengArtText(builder, _o.Type, positionOffset, textureOffset, subtitleTextOffset);
		}

		// Token: 0x04013303 RID: 78595
		private Table __p;
	}
}
