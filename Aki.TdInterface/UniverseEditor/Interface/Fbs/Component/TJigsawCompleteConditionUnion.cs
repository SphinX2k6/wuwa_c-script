using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C52 RID: 23634
	public class TJigsawCompleteConditionUnion
	{
		// Token: 0x1700B214 RID: 45588
		// (get) Token: 0x06028835 RID: 165941 RVA: 0x00592972 File Offset: 0x00590B72
		// (set) Token: 0x06028836 RID: 165942 RVA: 0x0059297A File Offset: 0x00590B7A
		public TJigsawCompleteCondition Type { get; set; }

		// Token: 0x1700B215 RID: 45589
		// (get) Token: 0x06028837 RID: 165943 RVA: 0x00592983 File Offset: 0x00590B83
		// (set) Token: 0x06028838 RID: 165944 RVA: 0x0059298B File Offset: 0x00590B8B
		public object Value { get; set; }

		// Token: 0x06028839 RID: 165945 RVA: 0x00592994 File Offset: 0x00590B94
		public TJigsawCompleteConditionUnion()
		{
			this.Type = TJigsawCompleteCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602883A RID: 165946 RVA: 0x005929AA File Offset: 0x00590BAA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602883B RID: 165947 RVA: 0x005929BC File Offset: 0x00590BBC
		public IActivateAllCorrectPieceT AsIActivateAllCorrectPiece()
		{
			return this.As<IActivateAllCorrectPieceT>();
		}

		// Token: 0x0602883C RID: 165948 RVA: 0x005929C4 File Offset: 0x00590BC4
		public static TJigsawCompleteConditionUnion FromIActivateAllCorrectPiece(IActivateAllCorrectPieceT _iactivateallcorrectpiece)
		{
			return new TJigsawCompleteConditionUnion
			{
				Type = TJigsawCompleteCondition.IActivateAllCorrectPiece,
				Value = _iactivateallcorrectpiece
			};
		}

		// Token: 0x0602883D RID: 165949 RVA: 0x005929D9 File Offset: 0x00590BD9
		public IActivateSpecifiedPieceT AsIActivateSpecifiedPiece()
		{
			return this.As<IActivateSpecifiedPieceT>();
		}

		// Token: 0x0602883E RID: 165950 RVA: 0x005929E1 File Offset: 0x00590BE1
		public static TJigsawCompleteConditionUnion FromIActivateSpecifiedPiece(IActivateSpecifiedPieceT _iactivatespecifiedpiece)
		{
			return new TJigsawCompleteConditionUnion
			{
				Type = TJigsawCompleteCondition.IActivateSpecifiedPiece,
				Value = _iactivatespecifiedpiece
			};
		}

		// Token: 0x0602883F RID: 165951 RVA: 0x005929F6 File Offset: 0x00590BF6
		public IActiveRenjuPieceT AsIActiveRenjuPiece()
		{
			return this.As<IActiveRenjuPieceT>();
		}

		// Token: 0x06028840 RID: 165952 RVA: 0x005929FE File Offset: 0x00590BFE
		public static TJigsawCompleteConditionUnion FromIActiveRenjuPiece(IActiveRenjuPieceT _iactiverenjupiece)
		{
			return new TJigsawCompleteConditionUnion
			{
				Type = TJigsawCompleteCondition.IActiveRenjuPiece,
				Value = _iactiverenjupiece
			};
		}

		// Token: 0x06028841 RID: 165953 RVA: 0x00592A13 File Offset: 0x00590C13
		public IPutInTheSpecifiedPieceT AsIPutInTheSpecifiedPiece()
		{
			return this.As<IPutInTheSpecifiedPieceT>();
		}

		// Token: 0x06028842 RID: 165954 RVA: 0x00592A1B File Offset: 0x00590C1B
		public static TJigsawCompleteConditionUnion FromIPutInTheSpecifiedPiece(IPutInTheSpecifiedPieceT _iputinthespecifiedpiece)
		{
			return new TJigsawCompleteConditionUnion
			{
				Type = TJigsawCompleteCondition.IPutInTheSpecifiedPiece,
				Value = _iputinthespecifiedpiece
			};
		}

		// Token: 0x06028843 RID: 165955 RVA: 0x00592A30 File Offset: 0x00590C30
		public static int Pack(FlatBufferBuilder builder, TJigsawCompleteConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TJigsawCompleteCondition.IActivateAllCorrectPiece:
				return IActivateAllCorrectPiece.Pack(builder, _o.AsIActivateAllCorrectPiece()).Value;
			case TJigsawCompleteCondition.IActivateSpecifiedPiece:
				return IActivateSpecifiedPiece.Pack(builder, _o.AsIActivateSpecifiedPiece()).Value;
			case TJigsawCompleteCondition.IActiveRenjuPiece:
				return IActiveRenjuPiece.Pack(builder, _o.AsIActiveRenjuPiece()).Value;
			case TJigsawCompleteCondition.IPutInTheSpecifiedPiece:
				return IPutInTheSpecifiedPiece.Pack(builder, _o.AsIPutInTheSpecifiedPiece()).Value;
			default:
				return 0;
			}
		}
	}
}
