using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E88 RID: 28296
	public struct IResetFocusConfig : IFlatbufferObject
	{
		// Token: 0x1700D2B4 RID: 53940
		// (get) Token: 0x0603201B RID: 204827 RVA: 0x006C3979 File Offset: 0x006C1B79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603201C RID: 204828 RVA: 0x006C3986 File Offset: 0x006C1B86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603201D RID: 204829 RVA: 0x006C3990 File Offset: 0x006C1B90
		public static IResetFocusConfig GetRootAsIResetFocusConfig(ByteBuffer _bb)
		{
			return IResetFocusConfig.GetRootAsIResetFocusConfig(_bb, default(IResetFocusConfig));
		}

		// Token: 0x0603201E RID: 204830 RVA: 0x006C39AC File Offset: 0x006C1BAC
		public static IResetFocusConfig GetRootAsIResetFocusConfig(ByteBuffer _bb, IResetFocusConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603201F RID: 204831 RVA: 0x006C39C9 File Offset: 0x006C1BC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032020 RID: 204832 RVA: 0x006C39D8 File Offset: 0x006C1BD8
		public IResetFocusConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2B5 RID: 53941
		// (get) Token: 0x06032021 RID: 204833 RVA: 0x006C39E8 File Offset: 0x006C1BE8
		public float FadeInTime
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

		// Token: 0x1700D2B6 RID: 53942
		// (get) Token: 0x06032022 RID: 204834 RVA: 0x006C3A28 File Offset: 0x006C1C28
		public IBaseCurve? FadeInCurve
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBaseCurve?(default(IBaseCurve).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032023 RID: 204835 RVA: 0x006C3A85 File Offset: 0x006C1C85
		public static Offset<IResetFocusConfig> CreateIResetFocusConfig(FlatBufferBuilder builder, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>))
		{
			builder.StartTable(2);
			IResetFocusConfig.AddFadeInCurve(builder, FadeInCurveOffset);
			IResetFocusConfig.AddFadeInTime(builder, FadeInTime);
			return IResetFocusConfig.EndIResetFocusConfig(builder);
		}

		// Token: 0x06032024 RID: 204836 RVA: 0x006C3AA2 File Offset: 0x006C1CA2
		public static void StartIResetFocusConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032025 RID: 204837 RVA: 0x006C3AAB File Offset: 0x006C1CAB
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x06032026 RID: 204838 RVA: 0x006C3ABE File Offset: 0x006C1CBE
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(1, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x06032027 RID: 204839 RVA: 0x006C3ACE File Offset: 0x006C1CCE
		public static Offset<IResetFocusConfig> EndIResetFocusConfig(FlatBufferBuilder builder)
		{
			return new Offset<IResetFocusConfig>(builder.EndTable());
		}

		// Token: 0x06032028 RID: 204840 RVA: 0x006C3ADC File Offset: 0x006C1CDC
		public IResetFocusConfigT UnPack()
		{
			IResetFocusConfigT resetFocusConfigT = new IResetFocusConfigT();
			this.UnPackTo(resetFocusConfigT);
			return resetFocusConfigT;
		}

		// Token: 0x06032029 RID: 204841 RVA: 0x006C3AF8 File Offset: 0x006C1CF8
		public void UnPackTo(IResetFocusConfigT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.FadeInCurve = ((this.FadeInCurve != null) ? this.FadeInCurve.Value.UnPack() : null);
		}

		// Token: 0x0603202A RID: 204842 RVA: 0x006C3B40 File Offset: 0x006C1D40
		public static Offset<IResetFocusConfig> Pack(FlatBufferBuilder builder, IResetFocusConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetFocusConfig>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			return IResetFocusConfig.CreateIResetFocusConfig(builder, _o.FadeInTime, fadeInCurveOffset);
		}

		// Token: 0x04011875 RID: 71797
		private Table __p;
	}
}
