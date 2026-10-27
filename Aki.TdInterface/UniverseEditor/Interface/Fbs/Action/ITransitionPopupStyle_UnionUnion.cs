using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007452 RID: 29778
	public class ITransitionPopupStyle_UnionUnion
	{
		// Token: 0x1700E210 RID: 57872
		// (get) Token: 0x0603618D RID: 221581 RVA: 0x0075B535 File Offset: 0x00759735
		// (set) Token: 0x0603618E RID: 221582 RVA: 0x0075B53D File Offset: 0x0075973D
		public ITransitionPopupStyle_Union Type { get; set; }

		// Token: 0x1700E211 RID: 57873
		// (get) Token: 0x0603618F RID: 221583 RVA: 0x0075B546 File Offset: 0x00759746
		// (set) Token: 0x06036190 RID: 221584 RVA: 0x0075B54E File Offset: 0x0075974E
		public object Value { get; set; }

		// Token: 0x06036191 RID: 221585 RVA: 0x0075B557 File Offset: 0x00759757
		public ITransitionPopupStyle_UnionUnion()
		{
			this.Type = ITransitionPopupStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036192 RID: 221586 RVA: 0x0075B56D File Offset: 0x0075976D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036193 RID: 221587 RVA: 0x0075B57F File Offset: 0x0075977F
		public ITransitionPopupStyleT AsITransitionPopupStyle()
		{
			return this.As<ITransitionPopupStyleT>();
		}

		// Token: 0x06036194 RID: 221588 RVA: 0x0075B587 File Offset: 0x00759787
		public static ITransitionPopupStyle_UnionUnion FromITransitionPopupStyle(ITransitionPopupStyleT _itransitionpopupstyle)
		{
			return new ITransitionPopupStyle_UnionUnion
			{
				Type = ITransitionPopupStyle_Union.ITransitionPopupStyle,
				Value = _itransitionpopupstyle
			};
		}

		// Token: 0x06036195 RID: 221589 RVA: 0x0075B59C File Offset: 0x0075979C
		public ITransitionPopupLeftTopTipT AsITransitionPopupLeftTopTip()
		{
			return this.As<ITransitionPopupLeftTopTipT>();
		}

		// Token: 0x06036196 RID: 221590 RVA: 0x0075B5A4 File Offset: 0x007597A4
		public static ITransitionPopupStyle_UnionUnion FromITransitionPopupLeftTopTip(ITransitionPopupLeftTopTipT _itransitionpopuplefttoptip)
		{
			return new ITransitionPopupStyle_UnionUnion
			{
				Type = ITransitionPopupStyle_Union.ITransitionPopupLeftTopTip,
				Value = _itransitionpopuplefttoptip
			};
		}

		// Token: 0x06036197 RID: 221591 RVA: 0x0075B5B9 File Offset: 0x007597B9
		public ITransitionPopupLeftBottomTransitionT AsITransitionPopupLeftBottomTransition()
		{
			return this.As<ITransitionPopupLeftBottomTransitionT>();
		}

		// Token: 0x06036198 RID: 221592 RVA: 0x0075B5C1 File Offset: 0x007597C1
		public static ITransitionPopupStyle_UnionUnion FromITransitionPopupLeftBottomTransition(ITransitionPopupLeftBottomTransitionT _itransitionpopupleftbottomtransition)
		{
			return new ITransitionPopupStyle_UnionUnion
			{
				Type = ITransitionPopupStyle_Union.ITransitionPopupLeftBottomTransition,
				Value = _itransitionpopupleftbottomtransition
			};
		}

		// Token: 0x06036199 RID: 221593 RVA: 0x0075B5D6 File Offset: 0x007597D6
		public ITransitionPopupArtTextT AsITransitionPopupArtText()
		{
			return this.As<ITransitionPopupArtTextT>();
		}

		// Token: 0x0603619A RID: 221594 RVA: 0x0075B5DE File Offset: 0x007597DE
		public static ITransitionPopupStyle_UnionUnion FromITransitionPopupArtText(ITransitionPopupArtTextT _itransitionpopuparttext)
		{
			return new ITransitionPopupStyle_UnionUnion
			{
				Type = ITransitionPopupStyle_Union.ITransitionPopupArtText,
				Value = _itransitionpopuparttext
			};
		}

		// Token: 0x0603619B RID: 221595 RVA: 0x0075B5F4 File Offset: 0x007597F4
		public static int Pack(FlatBufferBuilder builder, ITransitionPopupStyle_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITransitionPopupStyle_Union.ITransitionPopupStyle:
				return ITransitionPopupStyle.Pack(builder, _o.AsITransitionPopupStyle()).Value;
			case ITransitionPopupStyle_Union.ITransitionPopupLeftTopTip:
				return ITransitionPopupLeftTopTip.Pack(builder, _o.AsITransitionPopupLeftTopTip()).Value;
			case ITransitionPopupStyle_Union.ITransitionPopupLeftBottomTransition:
				return ITransitionPopupLeftBottomTransition.Pack(builder, _o.AsITransitionPopupLeftBottomTransition()).Value;
			case ITransitionPopupStyle_Union.ITransitionPopupArtText:
				return ITransitionPopupArtText.Pack(builder, _o.AsITransitionPopupArtText()).Value;
			default:
				return 0;
			}
		}
	}
}
