using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDC RID: 28124
	public struct IFadeBackgroundFadeInEffect : IFlatbufferObject
	{
		// Token: 0x1700CE22 RID: 52770
		// (get) Token: 0x060308B9 RID: 198841 RVA: 0x00697A7B File Offset: 0x00695C7B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060308BA RID: 198842 RVA: 0x00697A88 File Offset: 0x00695C88
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060308BB RID: 198843 RVA: 0x00697A90 File Offset: 0x00695C90
		public static IFadeBackgroundFadeInEffect GetRootAsIFadeBackgroundFadeInEffect(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeInEffect.GetRootAsIFadeBackgroundFadeInEffect(_bb, default(IFadeBackgroundFadeInEffect));
		}

		// Token: 0x060308BC RID: 198844 RVA: 0x00697AAC File Offset: 0x00695CAC
		public static IFadeBackgroundFadeInEffect GetRootAsIFadeBackgroundFadeInEffect(ByteBuffer _bb, IFadeBackgroundFadeInEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060308BD RID: 198845 RVA: 0x00697AC9 File Offset: 0x00695CC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060308BE RID: 198846 RVA: 0x00697AD8 File Offset: 0x00695CD8
		public IFadeBackgroundFadeInEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE23 RID: 52771
		// (get) Token: 0x060308BF RID: 198847 RVA: 0x00697AE8 File Offset: 0x00695CE8
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

		// Token: 0x060308C0 RID: 198848 RVA: 0x00697B24 File Offset: 0x00695D24
		public TTable? FadeInEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060308C1 RID: 198849 RVA: 0x00697B68 File Offset: 0x00695D68
		public IFadeBackgroundFadeInEffectBlack FadeInEffectAsIFadeBackgroundFadeInEffectBlack()
		{
			return this.FadeInEffect<IFadeBackgroundFadeInEffectBlack>().Value;
		}

		// Token: 0x060308C2 RID: 198850 RVA: 0x00697B84 File Offset: 0x00695D84
		public IFadeBackgroundFadeInEffectScreenEffect FadeInEffectAsIFadeBackgroundFadeInEffectScreenEffect()
		{
			return this.FadeInEffect<IFadeBackgroundFadeInEffectScreenEffect>().Value;
		}

		// Token: 0x060308C3 RID: 198851 RVA: 0x00697B9F File Offset: 0x00695D9F
		public static Offset<IFadeBackgroundFadeInEffect> CreateIFadeBackgroundFadeInEffect(FlatBufferBuilder builder, TFadeBackgroundFadeInEffect FadeInEffect_type = TFadeBackgroundFadeInEffect.NONE, int FadeInEffectOffset = 0)
		{
			builder.StartTable(2);
			IFadeBackgroundFadeInEffect.AddFadeInEffect(builder, FadeInEffectOffset);
			IFadeBackgroundFadeInEffect.AddFadeInEffectType(builder, FadeInEffect_type);
			return IFadeBackgroundFadeInEffect.EndIFadeBackgroundFadeInEffect(builder);
		}

		// Token: 0x060308C4 RID: 198852 RVA: 0x00697BBC File Offset: 0x00695DBC
		public static void StartIFadeBackgroundFadeInEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060308C5 RID: 198853 RVA: 0x00697BC5 File Offset: 0x00695DC5
		public static void AddFadeInEffectType(FlatBufferBuilder builder, TFadeBackgroundFadeInEffect fadeInEffectType)
		{
			builder.AddByte(0, (byte)fadeInEffectType, 0);
		}

		// Token: 0x060308C6 RID: 198854 RVA: 0x00697BD0 File Offset: 0x00695DD0
		public static void AddFadeInEffect(FlatBufferBuilder builder, int fadeInEffectOffset)
		{
			builder.AddOffset(1, fadeInEffectOffset, 0);
		}

		// Token: 0x060308C7 RID: 198855 RVA: 0x00697BDB File Offset: 0x00695DDB
		public static Offset<IFadeBackgroundFadeInEffect> EndIFadeBackgroundFadeInEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeInEffect>(builder.EndTable());
		}

		// Token: 0x060308C8 RID: 198856 RVA: 0x00697BE8 File Offset: 0x00695DE8
		public IFadeBackgroundFadeInEffectT UnPack()
		{
			IFadeBackgroundFadeInEffectT fadeBackgroundFadeInEffectT = new IFadeBackgroundFadeInEffectT();
			this.UnPackTo(fadeBackgroundFadeInEffectT);
			return fadeBackgroundFadeInEffectT;
		}

		// Token: 0x060308C9 RID: 198857 RVA: 0x00697C04 File Offset: 0x00695E04
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

		// Token: 0x060308CA RID: 198858 RVA: 0x00697CA8 File Offset: 0x00695EA8
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

		// Token: 0x04011C80 RID: 72832
		private Table __p;
	}
}
