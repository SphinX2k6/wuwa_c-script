using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007298 RID: 29336
	public class IMoveOperationType_UnionUnion
	{
		// Token: 0x1700D704 RID: 55044
		// (get) Token: 0x060331E2 RID: 209378 RVA: 0x006E5CAD File Offset: 0x006E3EAD
		// (set) Token: 0x060331E3 RID: 209379 RVA: 0x006E5CB5 File Offset: 0x006E3EB5
		public IMoveOperationType_Union Type { get; set; }

		// Token: 0x1700D705 RID: 55045
		// (get) Token: 0x060331E4 RID: 209380 RVA: 0x006E5CBE File Offset: 0x006E3EBE
		// (set) Token: 0x060331E5 RID: 209381 RVA: 0x006E5CC6 File Offset: 0x006E3EC6
		public object Value { get; set; }

		// Token: 0x060331E6 RID: 209382 RVA: 0x006E5CCF File Offset: 0x006E3ECF
		public IMoveOperationType_UnionUnion()
		{
			this.Type = IMoveOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060331E7 RID: 209383 RVA: 0x006E5CE5 File Offset: 0x006E3EE5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060331E8 RID: 209384 RVA: 0x006E5CF7 File Offset: 0x006E3EF7
		public IMoveOperationTypeT AsIMoveOperationType()
		{
			return this.As<IMoveOperationTypeT>();
		}

		// Token: 0x060331E9 RID: 209385 RVA: 0x006E5CFF File Offset: 0x006E3EFF
		public static IMoveOperationType_UnionUnion FromIMoveOperationType(IMoveOperationTypeT _imoveoperationtype)
		{
			return new IMoveOperationType_UnionUnion
			{
				Type = IMoveOperationType_Union.IMoveOperationType,
				Value = _imoveoperationtype
			};
		}

		// Token: 0x060331EA RID: 209386 RVA: 0x006E5D14 File Offset: 0x006E3F14
		public IEnableMoveOperationT AsIEnableMoveOperation()
		{
			return this.As<IEnableMoveOperationT>();
		}

		// Token: 0x060331EB RID: 209387 RVA: 0x006E5D1C File Offset: 0x006E3F1C
		public static IMoveOperationType_UnionUnion FromIEnableMoveOperation(IEnableMoveOperationT _ienablemoveoperation)
		{
			return new IMoveOperationType_UnionUnion
			{
				Type = IMoveOperationType_Union.IEnableMoveOperation,
				Value = _ienablemoveoperation
			};
		}

		// Token: 0x060331EC RID: 209388 RVA: 0x006E5D31 File Offset: 0x006E3F31
		public IDisableMoveOperationT AsIDisableMoveOperation()
		{
			return this.As<IDisableMoveOperationT>();
		}

		// Token: 0x060331ED RID: 209389 RVA: 0x006E5D39 File Offset: 0x006E3F39
		public static IMoveOperationType_UnionUnion FromIDisableMoveOperation(IDisableMoveOperationT _idisablemoveoperation)
		{
			return new IMoveOperationType_UnionUnion
			{
				Type = IMoveOperationType_Union.IDisableMoveOperation,
				Value = _idisablemoveoperation
			};
		}

		// Token: 0x060331EE RID: 209390 RVA: 0x006E5D50 File Offset: 0x006E3F50
		public static int Pack(FlatBufferBuilder builder, IMoveOperationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMoveOperationType_Union.IMoveOperationType:
				return IMoveOperationType.Pack(builder, _o.AsIMoveOperationType()).Value;
			case IMoveOperationType_Union.IEnableMoveOperation:
				return IEnableMoveOperation.Pack(builder, _o.AsIEnableMoveOperation()).Value;
			case IMoveOperationType_Union.IDisableMoveOperation:
				return IDisableMoveOperation.Pack(builder, _o.AsIDisableMoveOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
