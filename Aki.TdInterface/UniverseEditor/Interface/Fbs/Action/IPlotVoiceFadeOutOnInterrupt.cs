using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074DA RID: 29914
	public struct IPlotVoiceFadeOutOnInterrupt : IFlatbufferObject
	{
		// Token: 0x1700DC11 RID: 56337
		// (get) Token: 0x060346F2 RID: 214770 RVA: 0x0070F5F8 File Offset: 0x0070D7F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060346F3 RID: 214771 RVA: 0x0070F605 File Offset: 0x0070D805
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060346F4 RID: 214772 RVA: 0x0070F60C File Offset: 0x0070D80C
		public static IPlotVoiceFadeOutOnInterrupt GetRootAsIPlotVoiceFadeOutOnInterrupt(ByteBuffer _bb)
		{
			return IPlotVoiceFadeOutOnInterrupt.GetRootAsIPlotVoiceFadeOutOnInterrupt(_bb, default(IPlotVoiceFadeOutOnInterrupt));
		}

		// Token: 0x060346F5 RID: 214773 RVA: 0x0070F628 File Offset: 0x0070D828
		public static IPlotVoiceFadeOutOnInterrupt GetRootAsIPlotVoiceFadeOutOnInterrupt(ByteBuffer _bb, IPlotVoiceFadeOutOnInterrupt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060346F6 RID: 214774 RVA: 0x0070F645 File Offset: 0x0070D845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060346F7 RID: 214775 RVA: 0x0070F654 File Offset: 0x0070D854
		public IPlotVoiceFadeOutOnInterrupt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC12 RID: 56338
		// (get) Token: 0x060346F8 RID: 214776 RVA: 0x0070F664 File Offset: 0x0070D864
		public float FadeDuration
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

		// Token: 0x1700DC13 RID: 56339
		// (get) Token: 0x060346F9 RID: 214777 RVA: 0x0070F6A4 File Offset: 0x0070D8A4
		public EAudioFadeCurveType FadeCurve
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAudioFadeCurveType.Log3;
				}
				return (EAudioFadeCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC14 RID: 56340
		// (get) Token: 0x060346FA RID: 214778 RVA: 0x0070F6E0 File Offset: 0x0070D8E0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060346FB RID: 214779 RVA: 0x0070F71C File Offset: 0x0070D91C
		public static Offset<IPlotVoiceFadeOutOnInterrupt> CreateIPlotVoiceFadeOutOnInterrupt(FlatBufferBuilder builder, float FadeDuration = 0f, EAudioFadeCurveType FadeCurve = EAudioFadeCurveType.Log3, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPlotVoiceFadeOutOnInterrupt.AddFadeDuration(builder, FadeDuration);
			IPlotVoiceFadeOutOnInterrupt.AddNullMask(builder, NullMask);
			IPlotVoiceFadeOutOnInterrupt.AddFadeCurve(builder, FadeCurve);
			return IPlotVoiceFadeOutOnInterrupt.EndIPlotVoiceFadeOutOnInterrupt(builder);
		}

		// Token: 0x060346FC RID: 214780 RVA: 0x0070F740 File Offset: 0x0070D940
		public static void StartIPlotVoiceFadeOutOnInterrupt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060346FD RID: 214781 RVA: 0x0070F749 File Offset: 0x0070D949
		public static void AddFadeDuration(FlatBufferBuilder builder, float fadeDuration)
		{
			builder.AddFloat(0, fadeDuration, 0.0);
		}

		// Token: 0x060346FE RID: 214782 RVA: 0x0070F75C File Offset: 0x0070D95C
		public static void AddFadeCurve(FlatBufferBuilder builder, EAudioFadeCurveType fadeCurve)
		{
			builder.AddByte(1, (byte)fadeCurve, 0);
		}

		// Token: 0x060346FF RID: 214783 RVA: 0x0070F767 File Offset: 0x0070D967
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06034700 RID: 214784 RVA: 0x0070F772 File Offset: 0x0070D972
		public static Offset<IPlotVoiceFadeOutOnInterrupt> EndIPlotVoiceFadeOutOnInterrupt(FlatBufferBuilder builder)
		{
			return new Offset<IPlotVoiceFadeOutOnInterrupt>(builder.EndTable());
		}

		// Token: 0x06034701 RID: 214785 RVA: 0x0070F780 File Offset: 0x0070D980
		public IPlotVoiceFadeOutOnInterruptT UnPack()
		{
			IPlotVoiceFadeOutOnInterruptT plotVoiceFadeOutOnInterruptT = new IPlotVoiceFadeOutOnInterruptT();
			this.UnPackTo(plotVoiceFadeOutOnInterruptT);
			return plotVoiceFadeOutOnInterruptT;
		}

		// Token: 0x06034702 RID: 214786 RVA: 0x0070F79B File Offset: 0x0070D99B
		public void UnPackTo(IPlotVoiceFadeOutOnInterruptT _o)
		{
			_o.FadeDuration = this.FadeDuration;
			_o.FadeCurve = this.FadeCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034703 RID: 214787 RVA: 0x0070F7C4 File Offset: 0x0070D9C4
		public static Offset<IPlotVoiceFadeOutOnInterrupt> Pack(FlatBufferBuilder builder, IPlotVoiceFadeOutOnInterruptT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotVoiceFadeOutOnInterrupt>);
			}
			return IPlotVoiceFadeOutOnInterrupt.CreateIPlotVoiceFadeOutOnInterrupt(builder, _o.FadeDuration, _o.FadeCurve, _o.NullMask);
		}

		// Token: 0x0401268F RID: 75407
		private Table __p;
	}
}
