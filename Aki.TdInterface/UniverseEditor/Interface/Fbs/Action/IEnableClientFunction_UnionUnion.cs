using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC9 RID: 27849
	public class IEnableClientFunction_UnionUnion
	{
		// Token: 0x1700CC40 RID: 52288
		// (get) Token: 0x0602FFEA RID: 196586 RVA: 0x00687FE9 File Offset: 0x006861E9
		// (set) Token: 0x0602FFEB RID: 196587 RVA: 0x00687FF1 File Offset: 0x006861F1
		public IEnableClientFunction_Union Type { get; set; }

		// Token: 0x1700CC41 RID: 52289
		// (get) Token: 0x0602FFEC RID: 196588 RVA: 0x00687FFA File Offset: 0x006861FA
		// (set) Token: 0x0602FFED RID: 196589 RVA: 0x00688002 File Offset: 0x00686202
		public object Value { get; set; }

		// Token: 0x0602FFEE RID: 196590 RVA: 0x0068800B File Offset: 0x0068620B
		public IEnableClientFunction_UnionUnion()
		{
			this.Type = IEnableClientFunction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FFEF RID: 196591 RVA: 0x00688021 File Offset: 0x00686221
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FFF0 RID: 196592 RVA: 0x00688033 File Offset: 0x00686233
		public IEnableClientFunctionT AsIEnableClientFunction()
		{
			return this.As<IEnableClientFunctionT>();
		}

		// Token: 0x0602FFF1 RID: 196593 RVA: 0x0068803B File Offset: 0x0068623B
		public static IEnableClientFunction_UnionUnion FromIEnableClientFunction(IEnableClientFunctionT _ienableclientfunction)
		{
			return new IEnableClientFunction_UnionUnion
			{
				Type = IEnableClientFunction_Union.IEnableClientFunction,
				Value = _ienableclientfunction
			};
		}

		// Token: 0x0602FFF2 RID: 196594 RVA: 0x00688050 File Offset: 0x00686250
		public IHealthBarDisplayClientFunctionT AsIHealthBarDisplayClientFunction()
		{
			return this.As<IHealthBarDisplayClientFunctionT>();
		}

		// Token: 0x0602FFF3 RID: 196595 RVA: 0x00688058 File Offset: 0x00686258
		public static IEnableClientFunction_UnionUnion FromIHealthBarDisplayClientFunction(IHealthBarDisplayClientFunctionT _ihealthbardisplayclientfunction)
		{
			return new IEnableClientFunction_UnionUnion
			{
				Type = IEnableClientFunction_Union.IHealthBarDisplayClientFunction,
				Value = _ihealthbardisplayclientfunction
			};
		}

		// Token: 0x0602FFF4 RID: 196596 RVA: 0x00688070 File Offset: 0x00686270
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
