using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675C RID: 26460
	public struct IFadeBackgroundFadeInEffect : IFlatbufferObject
	{
		// Token: 0x1700C46C RID: 50284
		// (get) Token: 0x0602E073 RID: 188531 RVA: 0x0064A337 File Offset: 0x00648537
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E074 RID: 188532 RVA: 0x0064A344 File Offset: 0x00648544
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E075 RID: 188533 RVA: 0x0064A34C File Offset: 0x0064854C
		public static IFadeBackgroundFadeInEffect GetRootAsIFadeBackgroundFadeInEffect(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeInEffect.GetRootAsIFadeBackgroundFadeInEffect(_bb, default(IFadeBackgroundFadeInEffect));
		}

		// Token: 0x0602E076 RID: 188534 RVA: 0x0064A368 File Offset: 0x00648568
		public static IFadeBackgroundFadeInEffect GetRootAsIFadeBackgroundFadeInEffect(ByteBuffer _bb, IFadeBackgroundFadeInEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E077 RID: 188535 RVA: 0x0064A385 File Offset: 0x00648585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E078 RID: 188536 RVA: 0x0064A394 File Offset: 0x00648594
		public IFadeBackgroundFadeInEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C46D RID: 50285
		// (get) Token: 0x0602E079 RID: 188537 RVA: 0x0064A3A4 File Offset: 0x006485A4
		public TFadeBackgroundFadeInEffect FadeInEffectType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TFadeBackgroundFadeInEffect.NONE;
				}
				return (TFadeBackgroundFadeInEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E07A RID: 188538 RVA: 0x0064A3E0 File Offset: 0x006485E0
		public TTable? FadeInEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E07B RID: 188539 RVA: 0x0064A424 File Offset: 0x00648624
		public IFadeBackgroundFadeInEffectBlack FadeInEffectAsIFadeBackgroundFadeInEffectBlack()
		{
			return this.FadeInEffect<IFadeBackgroundFadeInEffectBlack>().Value;
		}

		// Token: 0x0602E07C RID: 188540 RVA: 0x0064A440 File Offset: 0x00648640
		public IFadeBackgroundFadeInEffectScreenEffect FadeInEffectAsIFadeBackgroundFadeInEffectScreenEffect()
		{
			return this.FadeInEffect<IFadeBackgroundFadeInEffectScreenEffect>().Value;
		}

		// Token: 0x0602E07D RID: 188541 RVA: 0x0064A45B File Offset: 0x0064865B
		public static Offset<IFadeBackgroundFadeInEffect> CreateIFadeBackgroundFadeInEffect(FlatBufferBuilder builder, TFadeBackgroundFadeInEffect FadeInEffect_type = TFadeBackgroundFadeInEffect.NONE, int FadeInEffectOffset = 0)
		{
			builder.StartTable(2);
			IFadeBackgroundFadeInEffect.AddFadeInEffect(builder, FadeInEffectOffset);
			IFadeBackgroundFadeInEffect.AddFadeInEffectType(builder, FadeInEffect_type);
			return IFadeBackgroundFadeInEffect.EndIFadeBackgroundFadeInEffect(builder);
		}

		// Token: 0x0602E07E RID: 188542 RVA: 0x0064A478 File Offset: 0x00648678
		public static void StartIFadeBackgroundFadeInEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E07F RID: 188543 RVA: 0x0064A481 File Offset: 0x00648681
		public static void AddFadeInEffectType(FlatBufferBuilder builder, TFadeBackgroundFadeInEffect fadeInEffectType)
		{
			builder.AddByte(0, (byte)fadeInEffectType, 0);
		}

		// Token: 0x0602E080 RID: 188544 RVA: 0x0064A48C File Offset: 0x0064868C
		public static void AddFadeInEffect(FlatBufferBuilder builder, int fadeInEffectOffset)
		{
			builder.AddOffset(1, fadeInEffectOffset, 0);
		}

		// Token: 0x0602E081 RID: 188545 RVA: 0x0064A497 File Offset: 0x00648697
		public static Offset<IFadeBackgroundFadeInEffect> EndIFadeBackgroundFadeInEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeInEffect>(builder.EndTable());
		}

		// Token: 0x0602E082 RID: 188546 RVA: 0x0064A4A4 File Offset: 0x006486A4
		public IFadeBackgroundFadeInEffectT UnPack()
		{
			IFadeBackgroundFadeInEffectT fadeBackgroundFadeInEffectT = new IFadeBackgroundFadeInEffectT();
			this.UnPackTo(fadeBackgroundFadeInEffectT);
			return fadeBackgroundFadeInEffectT;
		}

		// Token: 0x0602E083 RID: 188547 RVA: 0x0064A4C0 File Offset: 0x006486C0
		public void UnPackTo(IFadeBackgroundFadeInEffectT _o)
		{
			_o.FadeInEffect = new TFadeBackgroundFadeInEffectUnion();
			_o.FadeInEffect.Type = this.FadeInEffectType;
			TFadeBackgroundFadeInEffect fadeInEffectType = this.FadeInEffectType;
			if (fadeInEffectType == TFadeBackgroundFadeInEffect.IFadeBackgroundFadeInEffectBlack)
			{
				_o.FadeInEffect.Value = ((this.FadeInEffect<IFadeBackgroundFadeInEffectBlack>() != null) ? this.FadeInEffect<IFadeBackgroundFadeInEffectBlack>().Value.UnPack() : null);
				return;
			}
			if (fadeInEffectType != TFadeBackgroundFadeInEffect.IFadeBackgroundFadeInEffectScreenEffect)
			{
				return;
			}
			_o.FadeInEffect.Value = ((this.FadeInEffect<IFadeBackgroundFadeInEffectScreenEffect>() != null) ? this.FadeInEffect<IFadeBackgroundFadeInEffectScreenEffect>().Value.UnPack() : null);
		}

		// Token: 0x0602E084 RID: 188548 RVA: 0x0064A564 File Offset: 0x00648764
		public static Offset<IFadeBackgroundFadeInEffect> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeInEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeInEffect>);
			}
			TFadeBackgroundFadeInEffect fadeInEffect_type = (_o.FadeInEffect == null) ? TFadeBackgroundFadeInEffect.NONE : _o.FadeInEffect.Type;
			int fadeInEffectOffset = (_o.FadeInEffect == null) ? 0 : TFadeBackgroundFadeInEffectUnion.Pack(builder, _o.FadeInEffect);
			return IFadeBackgroundFadeInEffect.CreateIFadeBackgroundFadeInEffect(builder, fadeInEffect_type, fadeInEffectOffset);
		}

		// Token: 0x04010E4E RID: 69198
		private Table __p;
	}
}
