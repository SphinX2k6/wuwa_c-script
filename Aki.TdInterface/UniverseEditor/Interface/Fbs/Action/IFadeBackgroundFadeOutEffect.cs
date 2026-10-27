using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676B RID: 26475
	public struct IFadeBackgroundFadeOutEffect : IFlatbufferObject
	{
		// Token: 0x1700C484 RID: 50308
		// (get) Token: 0x0602E0E3 RID: 188643 RVA: 0x0064AEEC File Offset: 0x006490EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E0E4 RID: 188644 RVA: 0x0064AEF9 File Offset: 0x006490F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E0E5 RID: 188645 RVA: 0x0064AF00 File Offset: 0x00649100
		public static IFadeBackgroundFadeOutEffect GetRootAsIFadeBackgroundFadeOutEffect(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeOutEffect.GetRootAsIFadeBackgroundFadeOutEffect(_bb, default(IFadeBackgroundFadeOutEffect));
		}

		// Token: 0x0602E0E6 RID: 188646 RVA: 0x0064AF1C File Offset: 0x0064911C
		public static IFadeBackgroundFadeOutEffect GetRootAsIFadeBackgroundFadeOutEffect(ByteBuffer _bb, IFadeBackgroundFadeOutEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E0E7 RID: 188647 RVA: 0x0064AF39 File Offset: 0x00649139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E0E8 RID: 188648 RVA: 0x0064AF48 File Offset: 0x00649148
		public IFadeBackgroundFadeOutEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C485 RID: 50309
		// (get) Token: 0x0602E0E9 RID: 188649 RVA: 0x0064AF58 File Offset: 0x00649158
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

		// Token: 0x0602E0EA RID: 188650 RVA: 0x0064AF94 File Offset: 0x00649194
		public TTable? FadeOutEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E0EB RID: 188651 RVA: 0x0064AFD8 File Offset: 0x006491D8
		public IFadeBackgroundFadeOutEffectBlack FadeOutEffectAsIFadeBackgroundFadeOutEffectBlack()
		{
			return this.FadeOutEffect<IFadeBackgroundFadeOutEffectBlack>().Value;
		}

		// Token: 0x0602E0EC RID: 188652 RVA: 0x0064AFF4 File Offset: 0x006491F4
		public IFadeBackgroundFadeOutEffectScreenEffect FadeOutEffectAsIFadeBackgroundFadeOutEffectScreenEffect()
		{
			return this.FadeOutEffect<IFadeBackgroundFadeOutEffectScreenEffect>().Value;
		}

		// Token: 0x0602E0ED RID: 188653 RVA: 0x0064B00F File Offset: 0x0064920F
		public static Offset<IFadeBackgroundFadeOutEffect> CreateIFadeBackgroundFadeOutEffect(FlatBufferBuilder builder, TFadeBackgroundFadeOutEffect FadeOutEffect_type = TFadeBackgroundFadeOutEffect.NONE, int FadeOutEffectOffset = 0)
		{
			builder.StartTable(2);
			IFadeBackgroundFadeOutEffect.AddFadeOutEffect(builder, FadeOutEffectOffset);
			IFadeBackgroundFadeOutEffect.AddFadeOutEffectType(builder, FadeOutEffect_type);
			return IFadeBackgroundFadeOutEffect.EndIFadeBackgroundFadeOutEffect(builder);
		}

		// Token: 0x0602E0EE RID: 188654 RVA: 0x0064B02C File Offset: 0x0064922C
		public static void StartIFadeBackgroundFadeOutEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E0EF RID: 188655 RVA: 0x0064B035 File Offset: 0x00649235
		public static void AddFadeOutEffectType(FlatBufferBuilder builder, TFadeBackgroundFadeOutEffect fadeOutEffectType)
		{
			builder.AddByte(0, (byte)fadeOutEffectType, 0);
		}

		// Token: 0x0602E0F0 RID: 188656 RVA: 0x0064B040 File Offset: 0x00649240
		public static void AddFadeOutEffect(FlatBufferBuilder builder, int fadeOutEffectOffset)
		{
			builder.AddOffset(1, fadeOutEffectOffset, 0);
		}

		// Token: 0x0602E0F1 RID: 188657 RVA: 0x0064B04B File Offset: 0x0064924B
		public static Offset<IFadeBackgroundFadeOutEffect> EndIFadeBackgroundFadeOutEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeOutEffect>(builder.EndTable());
		}

		// Token: 0x0602E0F2 RID: 188658 RVA: 0x0064B058 File Offset: 0x00649258
		public IFadeBackgroundFadeOutEffectT UnPack()
		{
			IFadeBackgroundFadeOutEffectT fadeBackgroundFadeOutEffectT = new IFadeBackgroundFadeOutEffectT();
			this.UnPackTo(fadeBackgroundFadeOutEffectT);
			return fadeBackgroundFadeOutEffectT;
		}

		// Token: 0x0602E0F3 RID: 188659 RVA: 0x0064B074 File Offset: 0x00649274
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

		// Token: 0x0602E0F4 RID: 188660 RVA: 0x0064B118 File Offset: 0x00649318
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

		// Token: 0x04010E62 RID: 69218
		private Table __p;
	}
}
