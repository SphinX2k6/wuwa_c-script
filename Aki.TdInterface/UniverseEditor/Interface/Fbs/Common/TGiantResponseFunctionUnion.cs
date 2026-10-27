using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E82 RID: 24194
	public class TGiantResponseFunctionUnion
	{
		// Token: 0x1700B4D3 RID: 46291
		// (get) Token: 0x0602970C RID: 169740 RVA: 0x005ADD8A File Offset: 0x005ABF8A
		// (set) Token: 0x0602970D RID: 169741 RVA: 0x005ADD92 File Offset: 0x005ABF92
		public TGiantResponseFunction Type { get; set; }

		// Token: 0x1700B4D4 RID: 46292
		// (get) Token: 0x0602970E RID: 169742 RVA: 0x005ADD9B File Offset: 0x005ABF9B
		// (set) Token: 0x0602970F RID: 169743 RVA: 0x005ADDA3 File Offset: 0x005ABFA3
		public object Value { get; set; }

		// Token: 0x06029710 RID: 169744 RVA: 0x005ADDAC File Offset: 0x005ABFAC
		public TGiantResponseFunctionUnion()
		{
			this.Type = TGiantResponseFunction.NONE;
			this.Value = null;
		}

		// Token: 0x06029711 RID: 169745 RVA: 0x005ADDC2 File Offset: 0x005ABFC2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029712 RID: 169746 RVA: 0x005ADDD4 File Offset: 0x005ABFD4
		public IGiantResponsePlayAnimationT AsIGiantResponsePlayAnimation()
		{
			return this.As<IGiantResponsePlayAnimationT>();
		}

		// Token: 0x06029713 RID: 169747 RVA: 0x005ADDDC File Offset: 0x005ABFDC
		public static TGiantResponseFunctionUnion FromIGiantResponsePlayAnimation(IGiantResponsePlayAnimationT _igiantresponseplayanimation)
		{
			return new TGiantResponseFunctionUnion
			{
				Type = TGiantResponseFunction.IGiantResponsePlayAnimation,
				Value = _igiantresponseplayanimation
			};
		}

		// Token: 0x06029714 RID: 169748 RVA: 0x005ADDF1 File Offset: 0x005ABFF1
		public IGiantResponsePlayFlowT AsIGiantResponsePlayFlow()
		{
			return this.As<IGiantResponsePlayFlowT>();
		}

		// Token: 0x06029715 RID: 169749 RVA: 0x005ADDF9 File Offset: 0x005ABFF9
		public static TGiantResponseFunctionUnion FromIGiantResponsePlayFlow(IGiantResponsePlayFlowT _igiantresponseplayflow)
		{
			return new TGiantResponseFunctionUnion
			{
				Type = TGiantResponseFunction.IGiantResponsePlayFlow,
				Value = _igiantresponseplayflow
			};
		}

		// Token: 0x06029716 RID: 169750 RVA: 0x005ADE10 File Offset: 0x005AC010
		public static int Pack(FlatBufferBuilder builder, TGiantResponseFunctionUnion _o)
		{
			TGiantResponseFunction type = _o.Type;
			if (type == TGiantResponseFunction.IGiantResponsePlayAnimation)
			{
				return IGiantResponsePlayAnimation.Pack(builder, _o.AsIGiantResponsePlayAnimation()).Value;
			}
			if (type != TGiantResponseFunction.IGiantResponsePlayFlow)
			{
				return 0;
			}
			return IGiantResponsePlayFlow.Pack(builder, _o.AsIGiantResponsePlayFlow()).Value;
		}
	}
}
