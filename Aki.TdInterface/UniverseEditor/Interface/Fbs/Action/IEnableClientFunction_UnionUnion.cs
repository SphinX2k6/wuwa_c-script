using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006658 RID: 26200
	public class IEnableClientFunction_UnionUnion
	{
		// Token: 0x1700C2A2 RID: 49826
		// (get) Token: 0x0602D819 RID: 186393 RVA: 0x0063B481 File Offset: 0x00639681
		// (set) Token: 0x0602D81A RID: 186394 RVA: 0x0063B489 File Offset: 0x00639689
		public IEnableClientFunction_Union Type { get; set; }

		// Token: 0x1700C2A3 RID: 49827
		// (get) Token: 0x0602D81B RID: 186395 RVA: 0x0063B492 File Offset: 0x00639692
		// (set) Token: 0x0602D81C RID: 186396 RVA: 0x0063B49A File Offset: 0x0063969A
		public object Value { get; set; }

		// Token: 0x0602D81D RID: 186397 RVA: 0x0063B4A3 File Offset: 0x006396A3
		public IEnableClientFunction_UnionUnion()
		{
			this.Type = IEnableClientFunction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D81E RID: 186398 RVA: 0x0063B4B9 File Offset: 0x006396B9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D81F RID: 186399 RVA: 0x0063B4CB File Offset: 0x006396CB
		public IEnableClientFunctionT AsIEnableClientFunction()
		{
			return this.As<IEnableClientFunctionT>();
		}

		// Token: 0x0602D820 RID: 186400 RVA: 0x0063B4D3 File Offset: 0x006396D3
		public static IEnableClientFunction_UnionUnion FromIEnableClientFunction(IEnableClientFunctionT _ienableclientfunction)
		{
			return new IEnableClientFunction_UnionUnion
			{
				Type = IEnableClientFunction_Union.IEnableClientFunction,
				Value = _ienableclientfunction
			};
		}

		// Token: 0x0602D821 RID: 186401 RVA: 0x0063B4E8 File Offset: 0x006396E8
		public IHealthBarDisplayClientFunctionT AsIHealthBarDisplayClientFunction()
		{
			return this.As<IHealthBarDisplayClientFunctionT>();
		}

		// Token: 0x0602D822 RID: 186402 RVA: 0x0063B4F0 File Offset: 0x006396F0
		public static IEnableClientFunction_UnionUnion FromIHealthBarDisplayClientFunction(IHealthBarDisplayClientFunctionT _ihealthbardisplayclientfunction)
		{
			return new IEnableClientFunction_UnionUnion
			{
				Type = IEnableClientFunction_Union.IHealthBarDisplayClientFunction,
				Value = _ihealthbardisplayclientfunction
			};
		}

		// Token: 0x0602D823 RID: 186403 RVA: 0x0063B508 File Offset: 0x00639708
		public static int Pack(FlatBufferBuilder builder, IEnableClientFunction_UnionUnion _o)
		{
			IEnableClientFunction_Union type = _o.Type;
			if (type == IEnableClientFunction_Union.IEnableClientFunction)
			{
				return IEnableClientFunction.Pack(builder, _o.AsIEnableClientFunction()).Value;
			}
			if (type != IEnableClientFunction_Union.IHealthBarDisplayClientFunction)
			{
				return 0;
			}
			return IHealthBarDisplayClientFunction.Pack(builder, _o.AsIHealthBarDisplayClientFunction()).Value;
		}
	}
}
