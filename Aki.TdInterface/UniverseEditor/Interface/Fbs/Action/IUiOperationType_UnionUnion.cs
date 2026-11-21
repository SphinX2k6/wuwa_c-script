using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C9F RID: 31903
	public class IUiOperationType_UnionUnion
	{
		// Token: 0x1700EEDA RID: 61146
		// (get) Token: 0x060398C7 RID: 235719 RVA: 0x007C4569 File Offset: 0x007C2769
		// (set) Token: 0x060398C8 RID: 235720 RVA: 0x007C4571 File Offset: 0x007C2771
		public IUiOperationType_Union Type { get; set; }

		// Token: 0x1700EEDB RID: 61147
		// (get) Token: 0x060398C9 RID: 235721 RVA: 0x007C457A File Offset: 0x007C277A
		// (set) Token: 0x060398CA RID: 235722 RVA: 0x007C4582 File Offset: 0x007C2782
		public object Value { get; set; }

		// Token: 0x060398CB RID: 235723 RVA: 0x007C458B File Offset: 0x007C278B
		public IUiOperationType_UnionUnion()
		{
			this.Type = IUiOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060398CC RID: 235724 RVA: 0x007C45A1 File Offset: 0x007C27A1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060398CD RID: 235725 RVA: 0x007C45B3 File Offset: 0x007C27B3
		public IUiOperationTypeT AsIUiOperationType()
		{
			return this.As<IUiOperationTypeT>();
		}

		// Token: 0x060398CE RID: 235726 RVA: 0x007C45BB File Offset: 0x007C27BB
		public static IUiOperationType_UnionUnion FromIUiOperationType(IUiOperationTypeT _iuioperationtype)
		{
			return new IUiOperationType_UnionUnion
			{
				Type = IUiOperationType_Union.IUiOperationType,
				Value = _iuioperationtype
			};
		}

		// Token: 0x060398CF RID: 235727 RVA: 0x007C45D0 File Offset: 0x007C27D0
		public IEnableUiOperationT AsIEnableUiOperation()
		{
			return this.As<IEnableUiOperationT>();
		}

		// Token: 0x060398D0 RID: 235728 RVA: 0x007C45D8 File Offset: 0x007C27D8
		public static IUiOperationType_UnionUnion FromIEnableUiOperation(IEnableUiOperationT _ienableuioperation)
		{
			return new IUiOperationType_UnionUnion
			{
				Type = IUiOperationType_Union.IEnableUiOperation,
				Value = _ienableuioperation
			};
		}

		// Token: 0x060398D1 RID: 235729 RVA: 0x007C45ED File Offset: 0x007C27ED
		public IDisableUiOperationT AsIDisableUiOperation()
		{
			return this.As<IDisableUiOperationT>();
		}

		// Token: 0x060398D2 RID: 235730 RVA: 0x007C45F5 File Offset: 0x007C27F5
		public static IUiOperationType_UnionUnion FromIDisableUiOperation(IDisableUiOperationT _idisableuioperation)
		{
			return new IUiOperationType_UnionUnion
			{
				Type = IUiOperationType_Union.IDisableUiOperation,
				Value = _idisableuioperation
			};
		}

		// Token: 0x060398D3 RID: 235731 RVA: 0x007C460A File Offset: 0x007C280A
		public IEnableSectionalUiT AsIEnableSectionalUi()
		{
			return this.As<IEnableSectionalUiT>();
		}

		// Token: 0x060398D4 RID: 235732 RVA: 0x007C4612 File Offset: 0x007C2812
		public static IUiOperationType_UnionUnion FromIEnableSectionalUi(IEnableSectionalUiT _ienablesectionalui)
		{
			return new IUiOperationType_UnionUnion
			{
				Type = IUiOperationType_Union.IEnableSectionalUi,
				Value = _ienablesectionalui
			};
		}

		// Token: 0x060398D5 RID: 235733 RVA: 0x007C4628 File Offset: 0x007C2828
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
