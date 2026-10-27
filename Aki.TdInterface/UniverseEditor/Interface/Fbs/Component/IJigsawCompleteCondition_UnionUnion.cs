using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A4 RID: 21668
	public class IJigsawCompleteCondition_UnionUnion
	{
		// Token: 0x17009F88 RID: 40840
		// (get) Token: 0x06023A98 RID: 146072 RVA: 0x004EE159 File Offset: 0x004EC359
		// (set) Token: 0x06023A99 RID: 146073 RVA: 0x004EE161 File Offset: 0x004EC361
		public IJigsawCompleteCondition_Union Type { get; set; }

		// Token: 0x17009F89 RID: 40841
		// (get) Token: 0x06023A9A RID: 146074 RVA: 0x004EE16A File Offset: 0x004EC36A
		// (set) Token: 0x06023A9B RID: 146075 RVA: 0x004EE172 File Offset: 0x004EC372
		public object Value { get; set; }

		// Token: 0x06023A9C RID: 146076 RVA: 0x004EE17B File Offset: 0x004EC37B
		public IJigsawCompleteCondition_UnionUnion()
		{
			this.Type = IJigsawCompleteCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023A9D RID: 146077 RVA: 0x004EE191 File Offset: 0x004EC391
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023A9E RID: 146078 RVA: 0x004EE1A3 File Offset: 0x004EC3A3
		public IJigsawCompleteConditionT AsIJigsawCompleteCondition()
		{
			return this.As<IJigsawCompleteConditionT>();
		}

		// Token: 0x06023A9F RID: 146079 RVA: 0x004EE1AB File Offset: 0x004EC3AB
		public static IJigsawCompleteCondition_UnionUnion FromIJigsawCompleteCondition(IJigsawCompleteConditionT _ijigsawcompletecondition)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IJigsawCompleteCondition,
				Value = _ijigsawcompletecondition
			};
		}

		// Token: 0x06023AA0 RID: 146080 RVA: 0x004EE1C0 File Offset: 0x004EC3C0
		public IActivateAllCorrectPieceT AsIActivateAllCorrectPiece()
		{
			return this.As<IActivateAllCorrectPieceT>();
		}

		// Token: 0x06023AA1 RID: 146081 RVA: 0x004EE1C8 File Offset: 0x004EC3C8
		public static IJigsawCompleteCondition_UnionUnion FromIActivateAllCorrectPiece(IActivateAllCorrectPieceT _iactivateallcorrectpiece)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IActivateAllCorrectPiece,
				Value = _iactivateallcorrectpiece
			};
		}

		// Token: 0x06023AA2 RID: 146082 RVA: 0x004EE1DD File Offset: 0x004EC3DD
		public IPutInTheSpecifiedPieceT AsIPutInTheSpecifiedPiece()
		{
			return this.As<IPutInTheSpecifiedPieceT>();
		}

		// Token: 0x06023AA3 RID: 146083 RVA: 0x004EE1E5 File Offset: 0x004EC3E5
		public static IJigsawCompleteCondition_UnionUnion FromIPutInTheSpecifiedPiece(IPutInTheSpecifiedPieceT _iputinthespecifiedpiece)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IPutInTheSpecifiedPiece,
				Value = _iputinthespecifiedpiece
			};
		}

		// Token: 0x06023AA4 RID: 146084 RVA: 0x004EE1FA File Offset: 0x004EC3FA
		public IActiveRenjuPieceT AsIActiveRenjuPiece()
		{
			return this.As<IActiveRenjuPieceT>();
		}

		// Token: 0x06023AA5 RID: 146085 RVA: 0x004EE202 File Offset: 0x004EC402
		public static IJigsawCompleteCondition_UnionUnion FromIActiveRenjuPiece(IActiveRenjuPieceT _iactiverenjupiece)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IActiveRenjuPiece,
				Value = _iactiverenjupiece
			};
		}

		// Token: 0x06023AA6 RID: 146086 RVA: 0x004EE217 File Offset: 0x004EC417
		public IActivateSpecifiedPieceT AsIActivateSpecifiedPiece()
		{
			return this.As<IActivateSpecifiedPieceT>();
		}

		// Token: 0x06023AA7 RID: 146087 RVA: 0x004EE21F File Offset: 0x004EC41F
		public static IJigsawCompleteCondition_UnionUnion FromIActivateSpecifiedPiece(IActivateSpecifiedPieceT _iactivatespecifiedpiece)
		{
			return new IJigsawCompleteCondition_UnionUnion
			{
				Type = IJigsawCompleteCondition_Union.IActivateSpecifiedPiece,
				Value = _iactivatespecifiedpiece
			};
		}

		// Token: 0x06023AA8 RID: 146088 RVA: 0x004EE234 File Offset: 0x004EC434
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
