using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064C5 RID: 25797
	public class TGiantResponseFunctionUnion
	{
		// Token: 0x1700BE3E RID: 48702
		// (get) Token: 0x0602BDB4 RID: 179636 RVA: 0x005F6D2E File Offset: 0x005F4F2E
		// (set) Token: 0x0602BDB5 RID: 179637 RVA: 0x005F6D36 File Offset: 0x005F4F36
		public TGiantResponseFunction Type { get; set; }

		// Token: 0x1700BE3F RID: 48703
		// (get) Token: 0x0602BDB6 RID: 179638 RVA: 0x005F6D3F File Offset: 0x005F4F3F
		// (set) Token: 0x0602BDB7 RID: 179639 RVA: 0x005F6D47 File Offset: 0x005F4F47
		public object Value { get; set; }

		// Token: 0x0602BDB8 RID: 179640 RVA: 0x005F6D50 File Offset: 0x005F4F50
		public TGiantResponseFunctionUnion()
		{
			this.Type = TGiantResponseFunction.NONE;
			this.Value = null;
		}

		// Token: 0x0602BDB9 RID: 179641 RVA: 0x005F6D66 File Offset: 0x005F4F66
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BDBA RID: 179642 RVA: 0x005F6D78 File Offset: 0x005F4F78
		public IGiantResponsePlayAnimationT AsIGiantResponsePlayAnimation()
		{
			return this.As<IGiantResponsePlayAnimationT>();
		}

		// Token: 0x0602BDBB RID: 179643 RVA: 0x005F6D80 File Offset: 0x005F4F80
		public static TGiantResponseFunctionUnion FromIGiantResponsePlayAnimation(IGiantResponsePlayAnimationT _igiantresponseplayanimation)
		{
			return new TGiantResponseFunctionUnion
			{
				Type = TGiantResponseFunction.IGiantResponsePlayAnimation,
				Value = _igiantresponseplayanimation
			};
		}

		// Token: 0x0602BDBC RID: 179644 RVA: 0x005F6D95 File Offset: 0x005F4F95
		public IGiantResponsePlayFlowT AsIGiantResponsePlayFlow()
		{
			return this.As<IGiantResponsePlayFlowT>();
		}

		// Token: 0x0602BDBD RID: 179645 RVA: 0x005F6D9D File Offset: 0x005F4F9D
		public static TGiantResponseFunctionUnion FromIGiantResponsePlayFlow(IGiantResponsePlayFlowT _igiantresponseplayflow)
		{
			return new TGiantResponseFunctionUnion
			{
				Type = TGiantResponseFunction.IGiantResponsePlayFlow,
				Value = _igiantresponseplayflow
			};
		}

		// Token: 0x0602BDBE RID: 179646 RVA: 0x005F6DB4 File Offset: 0x005F4FB4
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
