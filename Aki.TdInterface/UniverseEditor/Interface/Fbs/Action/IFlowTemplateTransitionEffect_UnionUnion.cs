using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB5 RID: 28341
	public class IFlowTemplateTransitionEffect_UnionUnion
	{
		// Token: 0x1700CFDE RID: 53214
		// (get) Token: 0x0603106F RID: 200815 RVA: 0x006A640D File Offset: 0x006A460D
		// (set) Token: 0x06031070 RID: 200816 RVA: 0x006A6415 File Offset: 0x006A4615
		public IFlowTemplateTransitionEffect_Union Type { get; set; }

		// Token: 0x1700CFDF RID: 53215
		// (get) Token: 0x06031071 RID: 200817 RVA: 0x006A641E File Offset: 0x006A461E
		// (set) Token: 0x06031072 RID: 200818 RVA: 0x006A6426 File Offset: 0x006A4626
		public object Value { get; set; }

		// Token: 0x06031073 RID: 200819 RVA: 0x006A642F File Offset: 0x006A462F
		public IFlowTemplateTransitionEffect_UnionUnion()
		{
			this.Type = IFlowTemplateTransitionEffect_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031074 RID: 200820 RVA: 0x006A6445 File Offset: 0x006A4645
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031075 RID: 200821 RVA: 0x006A6457 File Offset: 0x006A4657
		public IFlowTemplateTransitionEffectT AsIFlowTemplateTransitionEffect()
		{
			return this.As<IFlowTemplateTransitionEffectT>();
		}

		// Token: 0x06031076 RID: 200822 RVA: 0x006A645F File Offset: 0x006A465F
		public static IFlowTemplateTransitionEffect_UnionUnion FromIFlowTemplateTransitionEffect(IFlowTemplateTransitionEffectT _iflowtemplatetransitioneffect)
		{
			return new IFlowTemplateTransitionEffect_UnionUnion
			{
				Type = IFlowTemplateTransitionEffect_Union.IFlowTemplateTransitionEffect,
				Value = _iflowtemplatetransitioneffect
			};
		}

		// Token: 0x06031077 RID: 200823 RVA: 0x006A6474 File Offset: 0x006A4674
		public IFlowTemplateBlurTransitionEffectT AsIFlowTemplateBlurTransitionEffect()
		{
			return this.As<IFlowTemplateBlurTransitionEffectT>();
		}

		// Token: 0x06031078 RID: 200824 RVA: 0x006A647C File Offset: 0x006A467C
		public static IFlowTemplateTransitionEffect_UnionUnion FromIFlowTemplateBlurTransitionEffect(IFlowTemplateBlurTransitionEffectT _iflowtemplateblurtransitioneffect)
		{
			return new IFlowTemplateTransitionEffect_UnionUnion
			{
				Type = IFlowTemplateTransitionEffect_Union.IFlowTemplateBlurTransitionEffect,
				Value = _iflowtemplateblurtransitioneffect
			};
		}

		// Token: 0x06031079 RID: 200825 RVA: 0x006A6494 File Offset: 0x006A4694
		public static int Pack(FlatBufferBuilder builder, IFlowTemplateTransitionEffect_UnionUnion _o)
		{
			IFlowTemplateTransitionEffect_Union type = _o.Type;
			if (type == IFlowTemplateTransitionEffect_Union.IFlowTemplateTransitionEffect)
			{
				return IFlowTemplateTransitionEffect.Pack(builder, _o.AsIFlowTemplateTransitionEffect()).Value;
			}
			if (type != IFlowTemplateTransitionEffect_Union.IFlowTemplateBlurTransitionEffect)
			{
				return 0;
			}
			return IFlowTemplateBlurTransitionEffect.Pack(builder, _o.AsIFlowTemplateBlurTransitionEffect()).Value;
		}
	}
}
