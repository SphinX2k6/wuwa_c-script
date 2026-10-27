using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682F RID: 26671
	public class IFlowTemplateTransitionEffect_UnionUnion
	{
		// Token: 0x1700C61A RID: 50714
		// (get) Token: 0x0602E7E7 RID: 190439 RVA: 0x006584CD File Offset: 0x006566CD
		// (set) Token: 0x0602E7E8 RID: 190440 RVA: 0x006584D5 File Offset: 0x006566D5
		public IFlowTemplateTransitionEffect_Union Type { get; set; }

		// Token: 0x1700C61B RID: 50715
		// (get) Token: 0x0602E7E9 RID: 190441 RVA: 0x006584DE File Offset: 0x006566DE
		// (set) Token: 0x0602E7EA RID: 190442 RVA: 0x006584E6 File Offset: 0x006566E6
		public object Value { get; set; }

		// Token: 0x0602E7EB RID: 190443 RVA: 0x006584EF File Offset: 0x006566EF
		public IFlowTemplateTransitionEffect_UnionUnion()
		{
			this.Type = IFlowTemplateTransitionEffect_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E7EC RID: 190444 RVA: 0x00658505 File Offset: 0x00656705
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E7ED RID: 190445 RVA: 0x00658517 File Offset: 0x00656717
		public IFlowTemplateTransitionEffectT AsIFlowTemplateTransitionEffect()
		{
			return this.As<IFlowTemplateTransitionEffectT>();
		}

		// Token: 0x0602E7EE RID: 190446 RVA: 0x0065851F File Offset: 0x0065671F
		public static IFlowTemplateTransitionEffect_UnionUnion FromIFlowTemplateTransitionEffect(IFlowTemplateTransitionEffectT _iflowtemplatetransitioneffect)
		{
			return new IFlowTemplateTransitionEffect_UnionUnion
			{
				Type = IFlowTemplateTransitionEffect_Union.IFlowTemplateTransitionEffect,
				Value = _iflowtemplatetransitioneffect
			};
		}

		// Token: 0x0602E7EF RID: 190447 RVA: 0x00658534 File Offset: 0x00656734
		public IFlowTemplateBlurTransitionEffectT AsIFlowTemplateBlurTransitionEffect()
		{
			return this.As<IFlowTemplateBlurTransitionEffectT>();
		}

		// Token: 0x0602E7F0 RID: 190448 RVA: 0x0065853C File Offset: 0x0065673C
		public static IFlowTemplateTransitionEffect_UnionUnion FromIFlowTemplateBlurTransitionEffect(IFlowTemplateBlurTransitionEffectT _iflowtemplateblurtransitioneffect)
		{
			return new IFlowTemplateTransitionEffect_UnionUnion
			{
				Type = IFlowTemplateTransitionEffect_Union.IFlowTemplateBlurTransitionEffect,
				Value = _iflowtemplateblurtransitioneffect
			};
		}

		// Token: 0x0602E7F1 RID: 190449 RVA: 0x00658554 File Offset: 0x00656754
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
