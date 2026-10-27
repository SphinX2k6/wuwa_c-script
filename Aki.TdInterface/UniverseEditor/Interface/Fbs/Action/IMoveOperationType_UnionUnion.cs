using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B52 RID: 27474
	public class IMoveOperationType_UnionUnion
	{
		// Token: 0x1700CC1F RID: 52255
		// (get) Token: 0x0603038B RID: 197515 RVA: 0x0068D6F1 File Offset: 0x0068B8F1
		// (set) Token: 0x0603038C RID: 197516 RVA: 0x0068D6F9 File Offset: 0x0068B8F9
		public IMoveOperationType_Union Type { get; set; }

		// Token: 0x1700CC20 RID: 52256
		// (get) Token: 0x0603038D RID: 197517 RVA: 0x0068D702 File Offset: 0x0068B902
		// (set) Token: 0x0603038E RID: 197518 RVA: 0x0068D70A File Offset: 0x0068B90A
		public object Value { get; set; }

		// Token: 0x0603038F RID: 197519 RVA: 0x0068D713 File Offset: 0x0068B913
		public IMoveOperationType_UnionUnion()
		{
			this.Type = IMoveOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030390 RID: 197520 RVA: 0x0068D729 File Offset: 0x0068B929
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030391 RID: 197521 RVA: 0x0068D73B File Offset: 0x0068B93B
		public IMoveOperationTypeT AsIMoveOperationType()
		{
			return this.As<IMoveOperationTypeT>();
		}

		// Token: 0x06030392 RID: 197522 RVA: 0x0068D743 File Offset: 0x0068B943
		public static IMoveOperationType_UnionUnion FromIMoveOperationType(IMoveOperationTypeT _imoveoperationtype)
		{
			return new IMoveOperationType_UnionUnion
			{
				Type = IMoveOperationType_Union.IMoveOperationType,
				Value = _imoveoperationtype
			};
		}

		// Token: 0x06030393 RID: 197523 RVA: 0x0068D758 File Offset: 0x0068B958
		public IEnableMoveOperationT AsIEnableMoveOperation()
		{
			return this.As<IEnableMoveOperationT>();
		}

		// Token: 0x06030394 RID: 197524 RVA: 0x0068D760 File Offset: 0x0068B960
		public static IMoveOperationType_UnionUnion FromIEnableMoveOperation(IEnableMoveOperationT _ienablemoveoperation)
		{
			return new IMoveOperationType_UnionUnion
			{
				Type = IMoveOperationType_Union.IEnableMoveOperation,
				Value = _ienablemoveoperation
			};
		}

		// Token: 0x06030395 RID: 197525 RVA: 0x0068D775 File Offset: 0x0068B975
		public IDisableMoveOperationT AsIDisableMoveOperation()
		{
			return this.As<IDisableMoveOperationT>();
		}

		// Token: 0x06030396 RID: 197526 RVA: 0x0068D77D File Offset: 0x0068B97D
		public static IMoveOperationType_UnionUnion FromIDisableMoveOperation(IDisableMoveOperationT _idisablemoveoperation)
		{
			return new IMoveOperationType_UnionUnion
			{
				Type = IMoveOperationType_Union.IDisableMoveOperation,
				Value = _idisablemoveoperation
			};
		}

		// Token: 0x06030397 RID: 197527 RVA: 0x0068D794 File Offset: 0x0068B994
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
