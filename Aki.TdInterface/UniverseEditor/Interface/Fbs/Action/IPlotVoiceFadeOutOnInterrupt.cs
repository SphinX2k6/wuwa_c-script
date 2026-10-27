using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5F RID: 27999
	public struct IPlotVoiceFadeOutOnInterrupt : IFlatbufferObject
	{
		// Token: 0x1700D0C9 RID: 53449
		// (get) Token: 0x060316F6 RID: 202486 RVA: 0x006B3F10 File Offset: 0x006B2110
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060316F7 RID: 202487 RVA: 0x006B3F1D File Offset: 0x006B211D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060316F8 RID: 202488 RVA: 0x006B3F24 File Offset: 0x006B2124
		public static IPlotVoiceFadeOutOnInterrupt GetRootAsIPlotVoiceFadeOutOnInterrupt(ByteBuffer _bb)
		{
			return IPlotVoiceFadeOutOnInterrupt.GetRootAsIPlotVoiceFadeOutOnInterrupt(_bb, default(IPlotVoiceFadeOutOnInterrupt));
		}

		// Token: 0x060316F9 RID: 202489 RVA: 0x006B3F40 File Offset: 0x006B2140
		public static IPlotVoiceFadeOutOnInterrupt GetRootAsIPlotVoiceFadeOutOnInterrupt(ByteBuffer _bb, IPlotVoiceFadeOutOnInterrupt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060316FA RID: 202490 RVA: 0x006B3F5D File Offset: 0x006B215D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060316FB RID: 202491 RVA: 0x006B3F6C File Offset: 0x006B216C
		public IPlotVoiceFadeOutOnInterrupt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0CA RID: 53450
		// (get) Token: 0x060316FC RID: 202492 RVA: 0x006B3F7C File Offset: 0x006B217C
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

		// Token: 0x1700D0CB RID: 53451
		// (get) Token: 0x060316FD RID: 202493 RVA: 0x006B3FBC File Offset: 0x006B21BC
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

		// Token: 0x1700D0CC RID: 53452
		// (get) Token: 0x060316FE RID: 202494 RVA: 0x006B3FF8 File Offset: 0x006B21F8
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

		// Token: 0x060316FF RID: 202495 RVA: 0x006B4034 File Offset: 0x006B2234
		public static Offset<IPlotVoiceFadeOutOnInterrupt> CreateIPlotVoiceFadeOutOnInterrupt(FlatBufferBuilder builder, float FadeDuration = 0f, EAudioFadeCurveType FadeCurve = EAudioFadeCurveType.Log3, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPlotVoiceFadeOutOnInterrupt.AddFadeDuration(builder, FadeDuration);
			IPlotVoiceFadeOutOnInterrupt.AddNullMask(builder, NullMask);
			IPlotVoiceFadeOutOnInterrupt.AddFadeCurve(builder, FadeCurve);
			return IPlotVoiceFadeOutOnInterrupt.EndIPlotVoiceFadeOutOnInterrupt(builder);
		}

		// Token: 0x06031700 RID: 202496 RVA: 0x006B4058 File Offset: 0x006B2258
		public static void StartIPlotVoiceFadeOutOnInterrupt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031701 RID: 202497 RVA: 0x006B4061 File Offset: 0x006B2261
		public static void AddFadeDuration(FlatBufferBuilder builder, float fadeDuration)
		{
			builder.AddFloat(0, fadeDuration, 0.0);
		}

		// Token: 0x06031702 RID: 202498 RVA: 0x006B4074 File Offset: 0x006B2274
		public static void AddFadeCurve(FlatBufferBuilder builder, EAudioFadeCurveType fadeCurve)
		{
			builder.AddByte(1, (byte)fadeCurve, 0);
		}

		// Token: 0x06031703 RID: 202499 RVA: 0x006B407F File Offset: 0x006B227F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06031704 RID: 202500 RVA: 0x006B408A File Offset: 0x006B228A
		public static Offset<IPlotVoiceFadeOutOnInterrupt> EndIPlotVoiceFadeOutOnInterrupt(FlatBufferBuilder builder)
		{
			return new Offset<IPlotVoiceFadeOutOnInterrupt>(builder.EndTable());
		}

		// Token: 0x06031705 RID: 202501 RVA: 0x006B4098 File Offset: 0x006B2298
		public IPlotVoiceFadeOutOnInterruptT UnPack()
		{
			IPlotVoiceFadeOutOnInterruptT plotVoiceFadeOutOnInterruptT = new IPlotVoiceFadeOutOnInterruptT();
			this.UnPackTo(plotVoiceFadeOutOnInterruptT);
			return plotVoiceFadeOutOnInterruptT;
		}

		// Token: 0x06031706 RID: 202502 RVA: 0x006B40B3 File Offset: 0x006B22B3
		public void UnPackTo(IPlotVoiceFadeOutOnInterruptT _o)
		{
			_o.FadeDuration = this.FadeDuration;
			_o.FadeCurve = this.FadeCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031707 RID: 202503 RVA: 0x006B40DC File Offset: 0x006B22DC
		public static Offset<IPlotVoiceFadeOutOnInterrupt> Pack(FlatBufferBuilder builder, IPlotVoiceFadeOutOnInterruptT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotVoiceFadeOutOnInterrupt>);
			}
			return IPlotVoiceFadeOutOnInterrupt.CreateIPlotVoiceFadeOutOnInterrupt(builder, _o.FadeDuration, _o.FadeCurve, _o.NullMask);
		}

		// Token: 0x04011713 RID: 71443
		private Table __p;
	}
}
