using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677A RID: 26490
	public struct IFadeBackgroundImage : IFlatbufferObject
	{
		// Token: 0x1700C49C RID: 50332
		// (get) Token: 0x0602E153 RID: 188755 RVA: 0x0064BAA0 File Offset: 0x00649CA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E154 RID: 188756 RVA: 0x0064BAAD File Offset: 0x00649CAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E155 RID: 188757 RVA: 0x0064BAB4 File Offset: 0x00649CB4
		public static IFadeBackgroundImage GetRootAsIFadeBackgroundImage(ByteBuffer _bb)
		{
			return IFadeBackgroundImage.GetRootAsIFadeBackgroundImage(_bb, default(IFadeBackgroundImage));
		}

		// Token: 0x0602E156 RID: 188758 RVA: 0x0064BAD0 File Offset: 0x00649CD0
		public static IFadeBackgroundImage GetRootAsIFadeBackgroundImage(ByteBuffer _bb, IFadeBackgroundImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E157 RID: 188759 RVA: 0x0064BAED File Offset: 0x00649CED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E158 RID: 188760 RVA: 0x0064BAFC File Offset: 0x00649CFC
		public IFadeBackgroundImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C49D RID: 50333
		// (get) Token: 0x0602E159 RID: 188761 RVA: 0x0064BB0C File Offset: 0x00649D0C
		public EFadeBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundType.Spine;
				}
				return (EFadeBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C49E RID: 50334
		// (get) Token: 0x0602E15A RID: 188762 RVA: 0x0064BB48 File Offset: 0x00649D48
		public string BackgroundImage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E15B RID: 188763 RVA: 0x0064BB7F File Offset: 0x00649D7F
		public Span<byte> GetBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E15C RID: 188764 RVA: 0x0064BB8E File Offset: 0x00649D8E
		public byte[] GetBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C49F RID: 50335
		// (get) Token: 0x0602E15D RID: 188765 RVA: 0x0064BB9C File Offset: 0x00649D9C
		public IFadeBackgroundFadeInEffect? FadeInEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFadeBackgroundFadeInEffect?(default(IFadeBackgroundFadeInEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C4A0 RID: 50336
		// (get) Token: 0x0602E15E RID: 188766 RVA: 0x0064BBFC File Offset: 0x00649DFC
		public IFadeBackgroundFadeOutEffect? FadeOutEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFadeBackgroundFadeOutEffect?(default(IFadeBackgroundFadeOutEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E15F RID: 188767 RVA: 0x0064BC5A File Offset: 0x00649E5A
		public static Offset<IFadeBackgroundImage> CreateIFadeBackgroundImage(FlatBufferBuilder builder, EFadeBackgroundType Type = EFadeBackgroundType.Spine, StringOffset BackgroundImageOffset = default(StringOffset), Offset<IFadeBackgroundFadeInEffect> FadeInEffectOffset = default(Offset<IFadeBackgroundFadeInEffect>), Offset<IFadeBackgroundFadeOutEffect> FadeOutEffectOffset = default(Offset<IFadeBackgroundFadeOutEffect>))
		{
			builder.StartTable(4);
			IFadeBackgroundImage.AddFadeOutEffect(builder, FadeOutEffectOffset);
			IFadeBackgroundImage.AddFadeInEffect(builder, FadeInEffectOffset);
			IFadeBackgroundImage.AddBackgroundImage(builder, BackgroundImageOffset);
			IFadeBackgroundImage.AddType(builder, Type);
			return IFadeBackgroundImage.EndIFadeBackgroundImage(builder);
		}

		// Token: 0x0602E160 RID: 188768 RVA: 0x0064BC86 File Offset: 0x00649E86
		public static void StartIFadeBackgroundImage(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E161 RID: 188769 RVA: 0x0064BC8F File Offset: 0x00649E8F
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E162 RID: 188770 RVA: 0x0064BC9A File Offset: 0x00649E9A
		public static void AddBackgroundImage(FlatBufferBuilder builder, StringOffset backgroundImageOffset)
		{
			builder.AddOffset(1, backgroundImageOffset.Value, 0);
		}

		// Token: 0x0602E163 RID: 188771 RVA: 0x0064BCAA File Offset: 0x00649EAA
		public static void AddFadeInEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset)
		{
			builder.AddOffset(2, fadeInEffectOffset.Value, 0);
		}

		// Token: 0x0602E164 RID: 188772 RVA: 0x0064BCBA File Offset: 0x00649EBA
		public static void AddFadeOutEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset)
		{
			builder.AddOffset(3, fadeOutEffectOffset.Value, 0);
		}

		// Token: 0x0602E165 RID: 188773 RVA: 0x0064BCCA File Offset: 0x00649ECA
		public static Offset<IFadeBackgroundImage> EndIFadeBackgroundImage(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundImage>(builder.EndTable());
		}

		// Token: 0x0602E166 RID: 188774 RVA: 0x0064BCD8 File Offset: 0x00649ED8
		public IFadeBackgroundImageT UnPack()
		{
			IFadeBackgroundImageT fadeBackgroundImageT = new IFadeBackgroundImageT();
			this.UnPackTo(fadeBackgroundImageT);
			return fadeBackgroundImageT;
		}

		// Token: 0x0602E167 RID: 188775 RVA: 0x0064BCF4 File Offset: 0x00649EF4
		public void UnPackTo(IFadeBackgroundImageT _o)
		{
			_o.Type = this.Type;
			_o.BackgroundImage = this.BackgroundImage;
			_o.FadeInEffect = ((this.FadeInEffect != null) ? this.FadeInEffect.Value.UnPack() : null);
			_o.FadeOutEffect = ((this.FadeOutEffect != null) ? this.FadeOutEffect.Value.UnPack() : null);
		}

		// Token: 0x0602E168 RID: 188776 RVA: 0x0064BD78 File Offset: 0x00649F78
		public static Offset<IFadeBackgroundImage> Pack(FlatBufferBuilder builder, IFadeBackgroundImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundImage>);
			}
			StringOffset backgroundImageOffset = (_o.BackgroundImage == null) ? default(StringOffset) : builder.CreateString(_o.BackgroundImage);
			Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset = (_o.FadeInEffect == null) ? default(Offset<IFadeBackgroundFadeInEffect>) : IFadeBackgroundFadeInEffect.Pack(builder, _o.FadeInEffect);
			Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset = (_o.FadeOutEffect == null) ? default(Offset<IFadeBackgroundFadeOutEffect>) : IFadeBackgroundFadeOutEffect.Pack(builder, _o.FadeOutEffect);
			return IFadeBackgroundImage.CreateIFadeBackgroundImage(builder, _o.Type, backgroundImageOffset, fadeInEffectOffset, fadeOutEffectOffset);
		}

		// Token: 0x04010E76 RID: 69238
		private Table __p;
	}
}
