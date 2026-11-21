using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2A RID: 23082
	public class IJigsawCompleteCondition_UnionUnion
	{
		// Token: 0x1700A7C2 RID: 42946
		// (get) Token: 0x06025B50 RID: 154448 RVA: 0x0052B1CD File Offset: 0x005293CD
		// (set) Token: 0x06025B51 RID: 154449 RVA: 0x0052B1D5 File Offset: 0x005293D5
		public IJigsawCompleteCondition_Union Type { get; set; }

		// Token: 0x1700A7C3 RID: 42947
		// (get) Token: 0x06025B52 RID: 154450 RVA: 0x0052B1DE File Offset: 0x005293DE
		// (set) Token: 0x06025B53 RID: 154451 RVA: 0x0052B1E6 File Offset: 0x005293E6
		public object Value { get; set; }

		// Token: 0x06025B54 RID: 154452 RVA: 0x0052B1EF File Offset: 0x005293EF
		public IJigsawCompleteCondition_UnionUnion()
		{
			this.Type = IJigsawCompleteCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025B55 RID: 154453 RVA: 0x0052B205 File Offset: 0x00529405
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025B56 RID: 154454 RVA: 0x0052B217 File Offset: 0x00529417
		public IJigsawCompleteConditionT AsIJigsawCompleteCondition()
		{
			return this.As<IJigsawCompleteConditionT>();
		}

		// Token: 0x06025B57 RID: 154455 RVA: 0x0052B21F File Offset: 0x0052941F
		public static IJigsawCompleteCondition_UnionUnion FromIJigsawCompleteCondition(IJigsawCompleteConditionT _ijigsawcompletecondition)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IJigsawCompleteCondition,
				Value = _ijigsawcompletecondition
			};
		}

		// Token: 0x06025B58 RID: 154456 RVA: 0x0052B234 File Offset: 0x00529434
		public IActivateAllCorrectPieceT AsIActivateAllCorrectPiece()
		{
			return this.As<IActivateAllCorrectPieceT>();
		}

		// Token: 0x06025B59 RID: 154457 RVA: 0x0052B23C File Offset: 0x0052943C
		public static IJigsawCompleteCondition_UnionUnion FromIActivateAllCorrectPiece(IActivateAllCorrectPieceT _iactivateallcorrectpiece)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IActivateAllCorrectPiece,
				Value = _iactivateallcorrectpiece
			};
		}

		// Token: 0x06025B5A RID: 154458 RVA: 0x0052B251 File Offset: 0x00529451
		public IPutInTheSpecifiedPieceT AsIPutInTheSpecifiedPiece()
		{
			return this.As<IPutInTheSpecifiedPieceT>();
		}

		// Token: 0x06025B5B RID: 154459 RVA: 0x0052B259 File Offset: 0x00529459
		public static IJigsawCompleteCondition_UnionUnion FromIPutInTheSpecifiedPiece(IPutInTheSpecifiedPieceT _iputinthespecifiedpiece)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IPutInTheSpecifiedPiece,
				Value = _iputinthespecifiedpiece
			};
		}

		// Token: 0x06025B5C RID: 154460 RVA: 0x0052B26E File Offset: 0x0052946E
		public IActiveRenjuPieceT AsIActiveRenjuPiece()
		{
			return this.As<IActiveRenjuPieceT>();
		}

		// Token: 0x06025B5D RID: 154461 RVA: 0x0052B276 File Offset: 0x00529476
		public static IJigsawCompleteCondition_UnionUnion FromIActiveRenjuPiece(IActiveRenjuPieceT _iactiverenjupiece)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IActiveRenjuPiece,
				Value = _iactiverenjupiece
			};
		}

		// Token: 0x06025B5E RID: 154462 RVA: 0x0052B28B File Offset: 0x0052948B
		public IActivateSpecifiedPieceT AsIActivateSpecifiedPiece()
		{
			return this.As<IActivateSpecifiedPieceT>();
		}

		// Token: 0x06025B5F RID: 154463 RVA: 0x0052B293 File Offset: 0x00529493
		public static IJigsawCompleteCondition_UnionUnion FromIActivateSpecifiedPiece(IActivateSpecifiedPieceT _iactivatespecifiedpiece)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IActivateSpecifiedPiece,
				Value = _iactivatespecifiedpiece
			};
		}

		// Token: 0x06025B60 RID: 154464 RVA: 0x0052B2A8 File Offset: 0x005294A8
		public static int Pack(FlatBufferBuilder builder, IJigsawCompleteCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IJigsawCompleteCondition_Union.IJigsawCompleteCondition:
				return IJigsawCompleteCondition.Pack(builder, _o.AsIJigsawCompleteCondition()).Value;
			case IJigsawCompleteCondition_Union.IActivateAllCorrectPiece:
				return IActivateAllCorrectPiece.Pack(builder, _o.AsIActivateAllCorrectPiece()).Value;
			case IJigsawCompleteCondition_Union.IPutInTheSpecifiedPiece:
				return IPutInTheSpecifiedPiece.Pack(builder, _o.AsIPutInTheSpecifiedPiece()).Value;
			case IJigsawCompleteCondition_Union.IActiveRenjuPiece:
				return IActiveRenjuPiece.Pack(builder, _o.AsIActiveRenjuPiece()).Value;
			case IJigsawCompleteCondition_Union.IActivateSpecifiedPiece:
				return IActivateSpecifiedPiece.Pack(builder, _o.AsIActivateSpecifiedPiece()).Value;
			default:
				return 0;
			}
		}
	}
}
