using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A9 RID: 29865
	public class IUiOperationType_UnionUnion
	{
		// Token: 0x1700E2B6 RID: 58038
		// (get) Token: 0x060364BE RID: 222398 RVA: 0x007614DD File Offset: 0x0075F6DD
		// (set) Token: 0x060364BF RID: 222399 RVA: 0x007614E5 File Offset: 0x0075F6E5
		public IUiOperationType_Union Type { get; set; }

		// Token: 0x1700E2B7 RID: 58039
		// (get) Token: 0x060364C0 RID: 222400 RVA: 0x007614EE File Offset: 0x0075F6EE
		// (set) Token: 0x060364C1 RID: 222401 RVA: 0x007614F6 File Offset: 0x0075F6F6
		public object Value { get; set; }

		// Token: 0x060364C2 RID: 222402 RVA: 0x007614FF File Offset: 0x0075F6FF
		public IUiOperationType_UnionUnion()
		{
			this.Type = IUiOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060364C3 RID: 222403 RVA: 0x00761515 File Offset: 0x0075F715
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060364C4 RID: 222404 RVA: 0x00761527 File Offset: 0x0075F727
		public IUiOperationTypeT AsIUiOperationType()
		{
			return this.As<IUiOperationTypeT>();
		}

		// Token: 0x060364C5 RID: 222405 RVA: 0x0076152F File Offset: 0x0075F72F
		public static IUiOperationType_UnionUnion FromIUiOperationType(IUiOperationTypeT _iuioperationtype)
		{
			return new IUiOperationType_UnionUnion
			{
				Type = IUiOperationType_Union.IUiOperationType,
				Value = _iuioperationtype
			};
		}

		// Token: 0x060364C6 RID: 222406 RVA: 0x00761544 File Offset: 0x0075F744
		public IEnableUiOperationT AsIEnableUiOperation()
		{
			return this.As<IEnableUiOperationT>();
		}

		// Token: 0x060364C7 RID: 222407 RVA: 0x0076154C File Offset: 0x0075F74C
		public static IUiOperationType_UnionUnion FromIEnableUiOperation(IEnableUiOperationT _ienableuioperation)
		{
			return new IUiOperationType_UnionUnion
			{
				Type = IUiOperationType_Union.IEnableUiOperation,
				Value = _ienableuioperation
			};
		}

		// Token: 0x060364C8 RID: 222408 RVA: 0x00761561 File Offset: 0x0075F761
		public IDisableUiOperationT AsIDisableUiOperation()
		{
			return this.As<IDisableUiOperationT>();
		}

		// Token: 0x060364C9 RID: 222409 RVA: 0x00761569 File Offset: 0x0075F769
		public static IUiOperationType_UnionUnion FromIDisableUiOperation(IDisableUiOperationT _idisableuioperation)
		{
			return new IUiOperationType_UnionUnion
			{
				Type = IUiOperationType_Union.IDisableUiOperation,
				Value = _idisableuioperation
			};
		}

		// Token: 0x060364CA RID: 222410 RVA: 0x0076157E File Offset: 0x0075F77E
		public IEnableSectionalUiT AsIEnableSectionalUi()
		{
			return this.As<IEnableSectionalUiT>();
		}

		// Token: 0x060364CB RID: 222411 RVA: 0x00761586 File Offset: 0x0075F786
		public static IUiOperationType_UnionUnion FromIEnableSectionalUi(IEnableSectionalUiT _ienablesectionalui)
		{
			return new IUiOperationType_UnionUnion
			{
				Type = IUiOperationType_Union.IEnableSectionalUi,
				Value = _ienablesectionalui
			};
		}

		// Token: 0x060364CC RID: 222412 RVA: 0x0076159C File Offset: 0x0075F79C
		public static int Pack(FlatBufferBuilder builder, IUiOperationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IUiOperationType_Union.IUiOperationType:
				return IUiOperationType.Pack(builder, _o.AsIUiOperationType()).Value;
			case IUiOperationType_Union.IEnableUiOperation:
				return IEnableUiOperation.Pack(builder, _o.AsIEnableUiOperation()).Value;
			case IUiOperationType_Union.IDisableUiOperation:
				return IDisableUiOperation.Pack(builder, _o.AsIDisableUiOperation()).Value;
			case IUiOperationType_Union.IEnableSectionalUi:
				return IEnableSectionalUi.Pack(builder, _o.AsIEnableSectionalUi()).Value;
			default:
				return 0;
			}
		}
	}
}
