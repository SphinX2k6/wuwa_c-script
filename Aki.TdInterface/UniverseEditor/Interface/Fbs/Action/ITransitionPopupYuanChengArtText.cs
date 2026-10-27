using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007454 RID: 29780
	public struct ITransitionPopupYuanChengArtText : IFlatbufferObject
	{
		// Token: 0x1700E212 RID: 57874
		// (get) Token: 0x0603619D RID: 221597 RVA: 0x0075B6C2 File Offset: 0x007598C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603619E RID: 221598 RVA: 0x0075B6CF File Offset: 0x007598CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603619F RID: 221599 RVA: 0x0075B6D8 File Offset: 0x007598D8
		public static ITransitionPopupYuanChengArtText GetRootAsITransitionPopupYuanChengArtText(ByteBuffer _bb)
		{
			return ITransitionPopupYuanChengArtText.GetRootAsITransitionPopupYuanChengArtText(_bb, default(ITransitionPopupYuanChengArtText));
		}

		// Token: 0x060361A0 RID: 221600 RVA: 0x0075B6F4 File Offset: 0x007598F4
		public static ITransitionPopupYuanChengArtText GetRootAsITransitionPopupYuanChengArtText(ByteBuffer _bb, ITransitionPopupYuanChengArtText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060361A1 RID: 221601 RVA: 0x0075B711 File Offset: 0x00759911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060361A2 RID: 221602 RVA: 0x0075B720 File Offset: 0x00759920
		public ITransitionPopupYuanChengArtText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E213 RID: 57875
		// (get) Token: 0x060361A3 RID: 221603 RVA: 0x0075B730 File Offset: 0x00759930
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

		// Token: 0x1700E214 RID: 57876
		// (get) Token: 0x060361A4 RID: 221604 RVA: 0x0075B76C File Offset: 0x0075996C
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

		// Token: 0x1700E215 RID: 57877
		// (get) Token: 0x060361A5 RID: 221605 RVA: 0x0075B7CC File Offset: 0x007599CC
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

		// Token: 0x060361A6 RID: 221606 RVA: 0x0075B803 File Offset: 0x00759A03
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060361A7 RID: 221607 RVA: 0x0075B812 File Offset: 0x00759A12
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E216 RID: 57878
		// (get) Token: 0x060361A8 RID: 221608 RVA: 0x0075B820 File Offset: 0x00759A20
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

		// Token: 0x060361A9 RID: 221609 RVA: 0x0075B858 File Offset: 0x00759A58
		public Span<byte> GetSubtitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060361AA RID: 221610 RVA: 0x0075B868 File Offset: 0x00759A68
		public byte[] GetSubtitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060361AB RID: 221611 RVA: 0x0075B877 File Offset: 0x00759A77
		public static Offset<ITransitionPopupYuanChengArtText> CreateITransitionPopupYuanChengArtText(FlatBufferBuilder builder, ETransitionPopupArtTextType Type = ETransitionPopupArtTextType.YuanCheng, Offset<IVector2> PositionOffset = default(Offset<IVector2>), StringOffset TextureOffset = default(StringOffset), StringOffset SubtitleTextOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ITransitionPopupYuanChengArtText.AddSubtitleText(builder, SubtitleTextOffset);
			ITransitionPopupYuanChengArtText.AddTexture(builder, TextureOffset);
			ITransitionPopupYuanChengArtText.AddPosition(builder, PositionOffset);
			ITransitionPopupYuanChengArtText.AddType(builder, Type);
			return ITransitionPopupYuanChengArtText.EndITransitionPopupYuanChengArtText(builder);
		}

		// Token: 0x060361AC RID: 221612 RVA: 0x0075B8A3 File Offset: 0x00759AA3
		public static void StartITransitionPopupYuanChengArtText(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060361AD RID: 221613 RVA: 0x0075B8AC File Offset: 0x00759AAC
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupArtTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060361AE RID: 221614 RVA: 0x0075B8B7 File Offset: 0x00759AB7
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVector2> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x060361AF RID: 221615 RVA: 0x0075B8C7 File Offset: 0x00759AC7
		public static void AddTexture(FlatBufferBuilder builder, StringOffset textureOffset)
		{
			builder.AddOffset(2, textureOffset.Value, 0);
		}

		// Token: 0x060361B0 RID: 221616 RVA: 0x0075B8D7 File Offset: 0x00759AD7
		public static void AddSubtitleText(FlatBufferBuilder builder, StringOffset subtitleTextOffset)
		{
			builder.AddOffset(3, subtitleTextOffset.Value, 0);
		}

		// Token: 0x060361B1 RID: 221617 RVA: 0x0075B8E7 File Offset: 0x00759AE7
		public static Offset<ITransitionPopupYuanChengArtText> EndITransitionPopupYuanChengArtText(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupYuanChengArtText>(builder.EndTable());
		}

		// Token: 0x060361B2 RID: 221618 RVA: 0x0075B8F4 File Offset: 0x00759AF4
		public ITransitionPopupYuanChengArtTextT UnPack()
		{
			ITransitionPopupYuanChengArtTextT transitionPopupYuanChengArtTextT = new ITransitionPopupYuanChengArtTextT();
			this.UnPackTo(transitionPopupYuanChengArtTextT);
			return transitionPopupYuanChengArtTextT;
		}

		// Token: 0x060361B3 RID: 221619 RVA: 0x0075B910 File Offset: 0x00759B10
		public void UnPackTo(ITransitionPopupYuanChengArtTextT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Texture = this.Texture;
			_o.SubtitleText = this.SubtitleText;
		}

		// Token: 0x060361B4 RID: 221620 RVA: 0x0075B970 File Offset: 0x00759B70
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

		// Token: 0x040122DC RID: 74460
		private Table __p;
	}
}
