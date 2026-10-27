using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006822 RID: 26658
	public struct IFlowTemplateBlurTransitionEffect : IFlatbufferObject
	{
		// Token: 0x1700C604 RID: 50692
		// (get) Token: 0x0602E782 RID: 190338 RVA: 0x006578D2 File Offset: 0x00655AD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E783 RID: 190339 RVA: 0x006578DF File Offset: 0x00655ADF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E784 RID: 190340 RVA: 0x006578E8 File Offset: 0x00655AE8
		public static IFlowTemplateBlurTransitionEffect GetRootAsIFlowTemplateBlurTransitionEffect(ByteBuffer _bb)
		{
			return IFlowTemplateBlurTransitionEffect.GetRootAsIFlowTemplateBlurTransitionEffect(_bb, default(IFlowTemplateBlurTransitionEffect));
		}

		// Token: 0x0602E785 RID: 190341 RVA: 0x00657904 File Offset: 0x00655B04
		public static IFlowTemplateBlurTransitionEffect GetRootAsIFlowTemplateBlurTransitionEffect(ByteBuffer _bb, IFlowTemplateBlurTransitionEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E786 RID: 190342 RVA: 0x00657921 File Offset: 0x00655B21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E787 RID: 190343 RVA: 0x00657930 File Offset: 0x00655B30
		public IFlowTemplateBlurTransitionEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C605 RID: 50693
		// (get) Token: 0x0602E788 RID: 190344 RVA: 0x00657940 File Offset: 0x00655B40
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

		// Token: 0x1700C606 RID: 50694
		// (get) Token: 0x0602E789 RID: 190345 RVA: 0x0065797C File Offset: 0x00655B7C
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

		// Token: 0x1700C607 RID: 50695
		// (get) Token: 0x0602E78A RID: 190346 RVA: 0x006579BC File Offset: 0x00655BBC
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

		// Token: 0x1700C608 RID: 50696
		// (get) Token: 0x0602E78B RID: 190347 RVA: 0x006579FC File Offset: 0x00655BFC
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

		// Token: 0x0602E78C RID: 190348 RVA: 0x00657A3D File Offset: 0x00655C3D
		public static Offset<IFlowTemplateBlurTransitionEffect> CreateIFlowTemplateBlurTransitionEffect(FlatBufferBuilder builder, EFlowTemplateTransitionEffectType Type = EFlowTemplateTransitionEffectType.Blur, float Aperture = 0f, float FadeInTime = 0f, float FadeOutTime = 0f)
		{
			builder.StartTable(4);
			IFlowTemplateBlurTransitionEffect.AddFadeOutTime(builder, FadeOutTime);
			IFlowTemplateBlurTransitionEffect.AddFadeInTime(builder, FadeInTime);
			IFlowTemplateBlurTransitionEffect.AddAperture(builder, Aperture);
			IFlowTemplateBlurTransitionEffect.AddType(builder, Type);
			return IFlowTemplateBlurTransitionEffect.EndIFlowTemplateBlurTransitionEffect(builder);
		}

		// Token: 0x0602E78D RID: 190349 RVA: 0x00657A69 File Offset: 0x00655C69
		public static void StartIFlowTemplateBlurTransitionEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E78E RID: 190350 RVA: 0x00657A72 File Offset: 0x00655C72
		public static void AddType(FlatBufferBuilder builder, EFlowTemplateTransitionEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E78F RID: 190351 RVA: 0x00657A7D File Offset: 0x00655C7D
		public static void AddAperture(FlatBufferBuilder builder, float aperture)
		{
			builder.AddFloat(1, aperture, 0.0);
		}

		// Token: 0x0602E790 RID: 190352 RVA: 0x00657A90 File Offset: 0x00655C90
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602E791 RID: 190353 RVA: 0x00657AA3 File Offset: 0x00655CA3
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(3, fadeOutTime, 0.0);
		}

		// Token: 0x0602E792 RID: 190354 RVA: 0x00657AB6 File Offset: 0x00655CB6
		public static Offset<IFlowTemplateBlurTransitionEffect> EndIFlowTemplateBlurTransitionEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateBlurTransitionEffect>(builder.EndTable());
		}

		// Token: 0x0602E793 RID: 190355 RVA: 0x00657AC4 File Offset: 0x00655CC4
		public IFlowTemplateBlurTransitionEffectT UnPack()
		{
			IFlowTemplateBlurTransitionEffectT flowTemplateBlurTransitionEffectT = new IFlowTemplateBlurTransitionEffectT();
			this.UnPackTo(flowTemplateBlurTransitionEffectT);
			return flowTemplateBlurTransitionEffectT;
		}

		// Token: 0x0602E794 RID: 190356 RVA: 0x00657ADF File Offset: 0x00655CDF
		public void UnPackTo(IFlowTemplateBlurTransitionEffectT _o)
		{
			_o.Type = this.Type;
			_o.Aperture = this.Aperture;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
		}

		// Token: 0x0602E795 RID: 190357 RVA: 0x00657B14 File Offset: 0x00655D14
		public static Offset<IFlowTemplateBlurTransitionEffect> Pack(FlatBufferBuilder builder, IFlowTemplateBlurTransitionEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTemplateBlurTransitionEffect>);
			}
			return IFlowTemplateBlurTransitionEffect.CreateIFlowTemplateBlurTransitionEffect(builder, _o.Type, _o.Aperture, _o.FadeInTime, _o.FadeOutTime);
		}

		// Token: 0x04010F60 RID: 69472
		private Table __p;
	}
}
