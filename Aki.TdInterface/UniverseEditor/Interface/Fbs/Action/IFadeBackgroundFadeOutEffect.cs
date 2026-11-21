using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEB RID: 28139
	public struct IFadeBackgroundFadeOutEffect : IFlatbufferObject
	{
		// Token: 0x1700CE3A RID: 52794
		// (get) Token: 0x06030929 RID: 198953 RVA: 0x00698630 File Offset: 0x00696830
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603092A RID: 198954 RVA: 0x0069863D File Offset: 0x0069683D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603092B RID: 198955 RVA: 0x00698644 File Offset: 0x00696844
		public static IFadeBackgroundFadeOutEffect GetRootAsIFadeBackgroundFadeOutEffect(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeOutEffect.GetRootAsIFadeBackgroundFadeOutEffect(_bb, default(IFadeBackgroundFadeOutEffect));
		}

		// Token: 0x0603092C RID: 198956 RVA: 0x00698660 File Offset: 0x00696860
		public static IFadeBackgroundFadeOutEffect GetRootAsIFadeBackgroundFadeOutEffect(ByteBuffer _bb, IFadeBackgroundFadeOutEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603092D RID: 198957 RVA: 0x0069867D File Offset: 0x0069687D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603092E RID: 198958 RVA: 0x0069868C File Offset: 0x0069688C
		public IFadeBackgroundFadeOutEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE3B RID: 52795
		// (get) Token: 0x0603092F RID: 198959 RVA: 0x0069869C File Offset: 0x0069689C
		public TFadeBackgroundFadeOutEffect FadeOutEffectType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TFadeBackgroundFadeOutEffect.NONE;
				}
				return (TFadeBackgroundFadeOutEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030930 RID: 198960 RVA: 0x006986D8 File Offset: 0x006968D8
		public TTable? FadeOutEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030931 RID: 198961 RVA: 0x0069871C File Offset: 0x0069691C
		public IFadeBackgroundFadeOutEffectBlack FadeOutEffectAsIFadeBackgroundFadeOutEffectBlack()
		{
			return this.FadeOutEffect<IFadeBackgroundFadeOutEffectBlack>().Value;
		}

		// Token: 0x06030932 RID: 198962 RVA: 0x00698738 File Offset: 0x00696938
		public IFadeBackgroundFadeOutEffectScreenEffect FadeOutEffectAsIFadeBackgroundFadeOutEffectScreenEffect()
		{
			return this.FadeOutEffect<IFadeBackgroundFadeOutEffectScreenEffect>().Value;
		}

		// Token: 0x06030933 RID: 198963 RVA: 0x00698753 File Offset: 0x00696953
		public static Offset<IFadeBackgroundFadeOutEffect> CreateIFadeBackgroundFadeOutEffect(FlatBufferBuilder builder, TFadeBackgroundFadeOutEffect FadeOutEffect_type = TFadeBackgroundFadeOutEffect.NONE, int FadeOutEffectOffset = 0)
		{
			builder.StartTable(2);
			IFadeBackgroundFadeOutEffect.AddFadeOutEffect(builder, FadeOutEffectOffset);
			IFadeBackgroundFadeOutEffect.AddFadeOutEffectType(builder, FadeOutEffect_type);
			return IFadeBackgroundFadeOutEffect.EndIFadeBackgroundFadeOutEffect(builder);
		}

		// Token: 0x06030934 RID: 198964 RVA: 0x00698770 File Offset: 0x00696970
		public static void StartIFadeBackgroundFadeOutEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030935 RID: 198965 RVA: 0x00698779 File Offset: 0x00696979
		public static void AddFadeOutEffectType(FlatBufferBuilder builder, TFadeBackgroundFadeOutEffect fadeOutEffectType)
		{
			builder.AddByte(0, (byte)fadeOutEffectType, 0);
		}

		// Token: 0x06030936 RID: 198966 RVA: 0x00698784 File Offset: 0x00696984
		public static void AddFadeOutEffect(FlatBufferBuilder builder, int fadeOutEffectOffset)
		{
			builder.AddOffset(1, fadeOutEffectOffset, 0);
		}

		// Token: 0x06030937 RID: 198967 RVA: 0x0069878F File Offset: 0x0069698F
		public static Offset<IFadeBackgroundFadeOutEffect> EndIFadeBackgroundFadeOutEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeOutEffect>(builder.EndTable());
		}

		// Token: 0x06030938 RID: 198968 RVA: 0x0069879C File Offset: 0x0069699C
		public IFadeBackgroundFadeOutEffectT UnPack()
		{
			IFadeBackgroundFadeOutEffectT fadeBackgroundFadeOutEffectT = new IFadeBackgroundFadeOutEffectT();
			this.UnPackTo(fadeBackgroundFadeOutEffectT);
			return fadeBackgroundFadeOutEffectT;
		}

		// Token: 0x06030939 RID: 198969 RVA: 0x006987B8 File Offset: 0x006969B8
		public void UnPackTo(IFadeBackgroundFadeOutEffectT _o)
		{
			_o.FadeOutEffect = new TFadeBackgroundFadeOutEffectUnion();
			_o.FadeOutEffect.Type = this.FadeOutEffectType;
			TFadeBackgroundFadeOutEffect fadeOutEffectType = this.FadeOutEffectType;
			if (fadeOutEffectType == TFadeBackgroundFadeOutEffect.IFadeBackgroundFadeOutEffectBlack)
			{
				_o.FadeOutEffect.Value = ((this.FadeOutEffect<IFadeBackgroundFadeOutEffectBlack>() != null) ? this.FadeOutEffect<IFadeBackgroundFadeOutEffectBlack>().Value.UnPack() : null);
				return;
			}
			if (fadeOutEffectType != TFadeBackgroundFadeOutEffect.IFadeBackgroundFadeOutEffectScreenEffect)
			{
				return;
			}
			_o.FadeOutEffect.Value = ((this.FadeOutEffect<IFadeBackgroundFadeOutEffectScreenEffect>() != null) ? this.FadeOutEffect<IFadeBackgroundFadeOutEffectScreenEffect>().Value.UnPack() : null);
		}

		// Token: 0x0603093A RID: 198970 RVA: 0x0069885C File Offset: 0x00696A5C
		public static Offset<IFadeBackgroundFadeOutEffect> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeOutEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeOutEffect>);
			}
			TFadeBackgroundFadeOutEffect fadeOutEffect_type = (_o.FadeOutEffect == null) ? TFadeBackgroundFadeOutEffect.NONE : _o.FadeOutEffect.Type;
			int fadeOutEffectOffset = (_o.FadeOutEffect == null) ? 0 : TFadeBackgroundFadeOutEffectUnion.Pack(builder, _o.FadeOutEffect);
			return IFadeBackgroundFadeOutEffect.CreateIFadeBackgroundFadeOutEffect(builder, fadeOutEffect_type, fadeOutEffectOffset);
		}

		// Token: 0x04011C94 RID: 72852
		private Table __p;
	}
}
