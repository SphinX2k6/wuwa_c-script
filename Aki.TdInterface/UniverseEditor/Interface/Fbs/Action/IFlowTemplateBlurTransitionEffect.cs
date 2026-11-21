using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA8 RID: 28328
	public struct IFlowTemplateBlurTransitionEffect : IFlatbufferObject
	{
		// Token: 0x1700CFC8 RID: 53192
		// (get) Token: 0x0603100A RID: 200714 RVA: 0x006A5811 File Offset: 0x006A3A11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603100B RID: 200715 RVA: 0x006A581E File Offset: 0x006A3A1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603100C RID: 200716 RVA: 0x006A5828 File Offset: 0x006A3A28
		public static IFlowTemplateBlurTransitionEffect GetRootAsIFlowTemplateBlurTransitionEffect(ByteBuffer _bb)
		{
			return IFlowTemplateBlurTransitionEffect.GetRootAsIFlowTemplateBlurTransitionEffect(_bb, default(IFlowTemplateBlurTransitionEffect));
		}

		// Token: 0x0603100D RID: 200717 RVA: 0x006A5844 File Offset: 0x006A3A44
		public static IFlowTemplateBlurTransitionEffect GetRootAsIFlowTemplateBlurTransitionEffect(ByteBuffer _bb, IFlowTemplateBlurTransitionEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603100E RID: 200718 RVA: 0x006A5861 File Offset: 0x006A3A61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603100F RID: 200719 RVA: 0x006A5870 File Offset: 0x006A3A70
		public IFlowTemplateBlurTransitionEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFC9 RID: 53193
		// (get) Token: 0x06031010 RID: 200720 RVA: 0x006A5880 File Offset: 0x006A3A80
		public EFlowTemplateTransitionEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFlowTemplateTransitionEffectType.Blur;
				}
				return (EFlowTemplateTransitionEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CFCA RID: 53194
		// (get) Token: 0x06031011 RID: 200721 RVA: 0x006A58BC File Offset: 0x006A3ABC
		public float Aperture
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CFCB RID: 53195
		// (get) Token: 0x06031012 RID: 200722 RVA: 0x006A58FC File Offset: 0x006A3AFC
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CFCC RID: 53196
		// (get) Token: 0x06031013 RID: 200723 RVA: 0x006A593C File Offset: 0x006A3B3C
		public float FadeOutTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031014 RID: 200724 RVA: 0x006A597D File Offset: 0x006A3B7D
		public static Offset<IFlowTemplateBlurTransitionEffect> CreateIFlowTemplateBlurTransitionEffect(FlatBufferBuilder builder, EFlowTemplateTransitionEffectType Type = EFlowTemplateTransitionEffectType.Blur, float Aperture = 0f, float FadeInTime = 0f, float FadeOutTime = 0f)
		{
			builder.StartTable(4);
			IFlowTemplateBlurTransitionEffect.AddFadeOutTime(builder, FadeOutTime);
			IFlowTemplateBlurTransitionEffect.AddFadeInTime(builder, FadeInTime);
			IFlowTemplateBlurTransitionEffect.AddAperture(builder, Aperture);
			IFlowTemplateBlurTransitionEffect.AddType(builder, Type);
			return IFlowTemplateBlurTransitionEffect.EndIFlowTemplateBlurTransitionEffect(builder);
		}

		// Token: 0x06031015 RID: 200725 RVA: 0x006A59A9 File Offset: 0x006A3BA9
		public static void StartIFlowTemplateBlurTransitionEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031016 RID: 200726 RVA: 0x006A59B2 File Offset: 0x006A3BB2
		public static void AddType(FlatBufferBuilder builder, EFlowTemplateTransitionEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031017 RID: 200727 RVA: 0x006A59BD File Offset: 0x006A3BBD
		public static void AddAperture(FlatBufferBuilder builder, float aperture)
		{
			builder.AddFloat(1, aperture, 0.0);
		}

		// Token: 0x06031018 RID: 200728 RVA: 0x006A59D0 File Offset: 0x006A3BD0
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x06031019 RID: 200729 RVA: 0x006A59E3 File Offset: 0x006A3BE3
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(3, fadeOutTime, 0.0);
		}

		// Token: 0x0603101A RID: 200730 RVA: 0x006A59F6 File Offset: 0x006A3BF6
		public static Offset<IFlowTemplateBlurTransitionEffect> EndIFlowTemplateBlurTransitionEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateBlurTransitionEffect>(builder.EndTable());
		}

		// Token: 0x0603101B RID: 200731 RVA: 0x006A5A04 File Offset: 0x006A3C04
		public IFlowTemplateBlurTransitionEffectT UnPack()
		{
			IFlowTemplateBlurTransitionEffectT flowTemplateBlurTransitionEffectT = new IFlowTemplateBlurTransitionEffectT();
			this.UnPackTo(flowTemplateBlurTransitionEffectT);
			return flowTemplateBlurTransitionEffectT;
		}

		// Token: 0x0603101C RID: 200732 RVA: 0x006A5A1F File Offset: 0x006A3C1F
		public void UnPackTo(IFlowTemplateBlurTransitionEffectT _o)
		{
			_o.Type = this.Type;
			_o.Aperture = this.Aperture;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
		}

		// Token: 0x0603101D RID: 200733 RVA: 0x006A5A54 File Offset: 0x006A3C54
		public static Offset<IFlowTemplateBlurTransitionEffect> Pack(FlatBufferBuilder builder, IFlowTemplateBlurTransitionEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTemplateBlurTransitionEffect>);
			}
			return IFlowTemplateBlurTransitionEffect.CreateIFlowTemplateBlurTransitionEffect(builder, _o.Type, _o.Aperture, _o.FadeInTime, _o.FadeOutTime);
		}

		// Token: 0x04011D9A RID: 73114
		private Table __p;
	}
}
