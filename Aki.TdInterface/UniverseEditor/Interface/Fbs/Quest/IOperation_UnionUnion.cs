using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F66 RID: 16230
	public class IOperation_UnionUnion
	{
		// Token: 0x170070D9 RID: 28889
		// (get) Token: 0x0601715A RID: 94554 RVA: 0x00353BC1 File Offset: 0x00351DC1
		// (set) Token: 0x0601715B RID: 94555 RVA: 0x00353BC9 File Offset: 0x00351DC9
		public IOperation_Union Type { get; set; }

		// Token: 0x170070DA RID: 28890
		// (get) Token: 0x0601715C RID: 94556 RVA: 0x00353BD2 File Offset: 0x00351DD2
		// (set) Token: 0x0601715D RID: 94557 RVA: 0x00353BDA File Offset: 0x00351DDA
		public object Value { get; set; }

		// Token: 0x0601715E RID: 94558 RVA: 0x00353BE3 File Offset: 0x00351DE3
		public IOperation_UnionUnion()
		{
			this.Type = IOperation_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601715F RID: 94559 RVA: 0x00353BF9 File Offset: 0x00351DF9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017160 RID: 94560 RVA: 0x00353C0B File Offset: 0x00351E0B
		public IOperationT AsIOperation()
		{
			return this.As<IOperationT>();
		}

		// Token: 0x06017161 RID: 94561 RVA: 0x00353C13 File Offset: 0x00351E13
		public static IOperation_UnionUnion FromIOperation(IOperationT _ioperation)
		{
			return new IOperation_UnionUnion
			{
				Type = IOperation_Union.IOperation,
				Value = _ioperation
			};
		}

		// Token: 0x06017162 RID: 94562 RVA: 0x00353C28 File Offset: 0x00351E28
		public IDisableHLODT AsIDisableHLOD()
		{
			return this.As<IDisableHLODT>();
		}

		// Token: 0x06017163 RID: 94563 RVA: 0x00353C30 File Offset: 0x00351E30
		public static IOperation_UnionUnion FromIDisableHLOD(IDisableHLODT _idisablehlod)
		{
			return new IOperation_UnionUnion
			{
				Type = IOperation_Union.IDisableHLOD,
				Value = _idisablehlod
			};
		}

		// Token: 0x06017164 RID: 94564 RVA: 0x00353C45 File Offset: 0x00351E45
		public IAssignLoadingBackgroundT AsIAssignLoadingBackground()
		{
			return this.As<IAssignLoadingBackgroundT>();
		}

		// Token: 0x06017165 RID: 94565 RVA: 0x00353C4D File Offset: 0x00351E4D
		public static IOperation_UnionUnion FromIAssignLoadingBackground(IAssignLoadingBackgroundT _iassignloadingbackground)
		{
			return new IOperation_UnionUnion
			{
				Type = IOperation_Union.IAssignLoadingBackground,
				Value = _iassignloadingbackground
			};
		}

		// Token: 0x06017166 RID: 94566 RVA: 0x00353C64 File Offset: 0x00351E64
		public static int Pack(FlatBufferBuilder builder, IOperation_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IOperation_Union.IOperation:
				return IOperation.Pack(builder, _o.AsIOperation()).Value;
			case IOperation_Union.IDisableHLOD:
				return IDisableHLOD.Pack(builder, _o.AsIDisableHLOD()).Value;
			case IOperation_Union.IAssignLoadingBackground:
				return IAssignLoadingBackground.Pack(builder, _o.AsIAssignLoadingBackground()).Value;
			default:
				return 0;
			}
		}
	}
}
