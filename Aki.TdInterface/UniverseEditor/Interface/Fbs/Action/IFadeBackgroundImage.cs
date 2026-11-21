using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFA RID: 28154
	public struct IFadeBackgroundImage : IFlatbufferObject
	{
		// Token: 0x1700CE52 RID: 52818
		// (get) Token: 0x06030999 RID: 199065 RVA: 0x006991E4 File Offset: 0x006973E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603099A RID: 199066 RVA: 0x006991F1 File Offset: 0x006973F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603099B RID: 199067 RVA: 0x006991F8 File Offset: 0x006973F8
		public static IFadeBackgroundImage GetRootAsIFadeBackgroundImage(ByteBuffer _bb)
		{
			return IFadeBackgroundImage.GetRootAsIFadeBackgroundImage(_bb, default(IFadeBackgroundImage));
		}

		// Token: 0x0603099C RID: 199068 RVA: 0x00699214 File Offset: 0x00697414
		public static IFadeBackgroundImage GetRootAsIFadeBackgroundImage(ByteBuffer _bb, IFadeBackgroundImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603099D RID: 199069 RVA: 0x00699231 File Offset: 0x00697431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603099E RID: 199070 RVA: 0x00699240 File Offset: 0x00697440
		public IFadeBackgroundImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE53 RID: 52819
		// (get) Token: 0x0603099F RID: 199071 RVA: 0x00699250 File Offset: 0x00697450
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

		// Token: 0x1700CE54 RID: 52820
		// (get) Token: 0x060309A0 RID: 199072 RVA: 0x0069928C File Offset: 0x0069748C
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

		// Token: 0x060309A1 RID: 199073 RVA: 0x006992C3 File Offset: 0x006974C3
		public Span<byte> GetBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060309A2 RID: 199074 RVA: 0x006992D2 File Offset: 0x006974D2
		public byte[] GetBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CE55 RID: 52821
		// (get) Token: 0x060309A3 RID: 199075 RVA: 0x006992E0 File Offset: 0x006974E0
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

		// Token: 0x1700CE56 RID: 52822
		// (get) Token: 0x060309A4 RID: 199076 RVA: 0x00699340 File Offset: 0x00697540
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

		// Token: 0x060309A5 RID: 199077 RVA: 0x0069939E File Offset: 0x0069759E
		public static Offset<IFadeBackgroundImage> CreateIFadeBackgroundImage(FlatBufferBuilder builder, EFadeBackgroundType Type = EFadeBackgroundType.Spine, StringOffset BackgroundImageOffset = default(StringOffset), Offset<IFadeBackgroundFadeInEffect> FadeInEffectOffset = default(Offset<IFadeBackgroundFadeInEffect>), Offset<IFadeBackgroundFadeOutEffect> FadeOutEffectOffset = default(Offset<IFadeBackgroundFadeOutEffect>))
		{
			builder.StartTable(4);
			IFadeBackgroundImage.AddFadeOutEffect(builder, FadeOutEffectOffset);
			IFadeBackgroundImage.AddFadeInEffect(builder, FadeInEffectOffset);
			IFadeBackgroundImage.AddBackgroundImage(builder, BackgroundImageOffset);
			IFadeBackgroundImage.AddType(builder, Type);
			return IFadeBackgroundImage.EndIFadeBackgroundImage(builder);
		}

		// Token: 0x060309A6 RID: 199078 RVA: 0x006993CA File Offset: 0x006975CA
		public static void StartIFadeBackgroundImage(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060309A7 RID: 199079 RVA: 0x006993D3 File Offset: 0x006975D3
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060309A8 RID: 199080 RVA: 0x006993DE File Offset: 0x006975DE
		public static void AddBackgroundImage(FlatBufferBuilder builder, StringOffset backgroundImageOffset)
		{
			builder.AddOffset(1, backgroundImageOffset.Value, 0);
		}

		// Token: 0x060309A9 RID: 199081 RVA: 0x006993EE File Offset: 0x006975EE
		public static void AddFadeInEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset)
		{
			builder.AddOffset(2, fadeInEffectOffset.Value, 0);
		}

		// Token: 0x060309AA RID: 199082 RVA: 0x006993FE File Offset: 0x006975FE
		public static void AddFadeOutEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset)
		{
			builder.AddOffset(3, fadeOutEffectOffset.Value, 0);
		}

		// Token: 0x060309AB RID: 199083 RVA: 0x0069940E File Offset: 0x0069760E
		public static Offset<IFadeBackgroundImage> EndIFadeBackgroundImage(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundImage>(builder.EndTable());
		}

		// Token: 0x060309AC RID: 199084 RVA: 0x0069941C File Offset: 0x0069761C
		public IFadeBackgroundImageT UnPack()
		{
			IFadeBackgroundImageT fadeBackgroundImageT = new IFadeBackgroundImageT();
			this.UnPackTo(fadeBackgroundImageT);
			return fadeBackgroundImageT;
		}

		// Token: 0x060309AD RID: 199085 RVA: 0x00699438 File Offset: 0x00697638
		public void UnPackTo(IFadeBackgroundImageT _o)
		{
			_o.Type = this.Type;
			_o.BackgroundImage = this.BackgroundImage;
			_o.FadeInEffect = ((this.FadeInEffect != null) ? this.FadeInEffect.Value.UnPack() : null);
			_o.FadeOutEffect = ((this.FadeOutEffect != null) ? this.FadeOutEffect.Value.UnPack() : null);
		}

		// Token: 0x060309AE RID: 199086 RVA: 0x006994BC File Offset: 0x006976BC
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

		// Token: 0x04011CA8 RID: 72872
		private Table __p;
	}
}
