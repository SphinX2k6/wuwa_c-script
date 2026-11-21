using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006277 RID: 25207
	public class TJigsawCompleteConditionUnion
	{
		// Token: 0x1700BB66 RID: 47974
		// (get) Token: 0x0602AE43 RID: 175683 RVA: 0x005DAB8A File Offset: 0x005D8D8A
		// (set) Token: 0x0602AE44 RID: 175684 RVA: 0x005DAB92 File Offset: 0x005D8D92
		public TJigsawCompleteCondition Type { get; set; }

		// Token: 0x1700BB67 RID: 47975
		// (get) Token: 0x0602AE45 RID: 175685 RVA: 0x005DAB9B File Offset: 0x005D8D9B
		// (set) Token: 0x0602AE46 RID: 175686 RVA: 0x005DABA3 File Offset: 0x005D8DA3
		public object Value { get; set; }

		// Token: 0x0602AE47 RID: 175687 RVA: 0x005DABAC File Offset: 0x005D8DAC
		public TJigsawCompleteConditionUnion()
		{
			this.Type = TJigsawCompleteCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE48 RID: 175688 RVA: 0x005DABC2 File Offset: 0x005D8DC2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE49 RID: 175689 RVA: 0x005DABD4 File Offset: 0x005D8DD4
		public IActivateAllCorrectPieceT AsIActivateAllCorrectPiece()
		{
			return this.As<IActivateAllCorrectPieceT>();
		}

		// Token: 0x0602AE4A RID: 175690 RVA: 0x005DABDC File Offset: 0x005D8DDC
		public static TJigsawCompleteConditionUnion FromIActivateAllCorrectPiece(IActivateAllCorrectPieceT _iactivateallcorrectpiece)
		{
			return new TJigsawCompleteConditionUnion
			{
				Type = TJigsawCompleteCondition.IActivateAllCorrectPiece,
				Value = _iactivateallcorrectpiece
			};
		}

		// Token: 0x0602AE4B RID: 175691 RVA: 0x005DABF1 File Offset: 0x005D8DF1
		public IActivateSpecifiedPieceT AsIActivateSpecifiedPiece()
		{
			return this.As<IActivateSpecifiedPieceT>();
		}

		// Token: 0x0602AE4C RID: 175692 RVA: 0x005DABF9 File Offset: 0x005D8DF9
		public static TJigsawCompleteConditionUnion FromIActivateSpecifiedPiece(IActivateSpecifiedPieceT _iactivatespecifiedpiece)
		{
			return new TJigsawCompleteConditionUnion
			{
				Type = TJigsawCompleteCondition.IActivateSpecifiedPiece,
				Value = _iactivatespecifiedpiece
			};
		}

		// Token: 0x0602AE4D RID: 175693 RVA: 0x005DAC0E File Offset: 0x005D8E0E
		public IActiveRenjuPieceT AsIActiveRenjuPiece()
		{
			return this.As<IActiveRenjuPieceT>();
		}

		// Token: 0x0602AE4E RID: 175694 RVA: 0x005DAC16 File Offset: 0x005D8E16
		public static TJigsawCompleteConditionUnion FromIActiveRenjuPiece(IActiveRenjuPieceT _iactiverenjupiece)
		{
			return new TJigsawCompleteConditionUnion
			{
				Type = TJigsawCompleteCondition.IActiveRenjuPiece,
				Value = _iactiverenjupiece
			};
		}

		// Token: 0x0602AE4F RID: 175695 RVA: 0x005DAC2B File Offset: 0x005D8E2B
		public IPutInTheSpecifiedPieceT AsIPutInTheSpecifiedPiece()
		{
			return this.As<IPutInTheSpecifiedPieceT>();
		}

		// Token: 0x0602AE50 RID: 175696 RVA: 0x005DAC33 File Offset: 0x005D8E33
		public static TJigsawCompleteConditionUnion FromIPutInTheSpecifiedPiece(IPutInTheSpecifiedPieceT _iputinthespecifiedpiece)
		{
			return new TJigsawCompleteConditionUnion
			{
				Type = TJigsawCompleteCondition.IPutInTheSpecifiedPiece,
				Value = _iputinthespecifiedpiece
			};
		}

		// Token: 0x0602AE51 RID: 175697 RVA: 0x005DAC48 File Offset: 0x005D8E48
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
