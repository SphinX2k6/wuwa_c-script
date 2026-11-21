using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C45 RID: 31813
	public class ITransitionPopupStyle_UnionUnion
	{
		// Token: 0x1700EE2D RID: 60973
		// (get) Token: 0x06039576 RID: 234870 RVA: 0x007BE261 File Offset: 0x007BC461
		// (set) Token: 0x06039577 RID: 234871 RVA: 0x007BE269 File Offset: 0x007BC469
		public ITransitionPopupStyle_Union Type { get; set; }

		// Token: 0x1700EE2E RID: 60974
		// (get) Token: 0x06039578 RID: 234872 RVA: 0x007BE272 File Offset: 0x007BC472
		// (set) Token: 0x06039579 RID: 234873 RVA: 0x007BE27A File Offset: 0x007BC47A
		public object Value { get; set; }

		// Token: 0x0603957A RID: 234874 RVA: 0x007BE283 File Offset: 0x007BC483
		public ITransitionPopupStyle_UnionUnion()
		{
			this.Type = ITransitionPopupStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603957B RID: 234875 RVA: 0x007BE299 File Offset: 0x007BC499
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603957C RID: 234876 RVA: 0x007BE2AB File Offset: 0x007BC4AB
		public ITransitionPopupStyleT AsITransitionPopupStyle()
		{
			return this.As<ITransitionPopupStyleT>();
		}

		// Token: 0x0603957D RID: 234877 RVA: 0x007BE2B3 File Offset: 0x007BC4B3
		public static ITransitionPopupStyle_UnionUnion FromITransitionPopupStyle(ITransitionPopupStyleT _itransitionpopupstyle)
		{
			return new ITransitionPopupStyle_UnionUnion
			{
				Type = ITransitionPopupStyle_Union.ITransitionPopupStyle,
				Value = _itransitionpopupstyle
			};
		}

		// Token: 0x0603957E RID: 234878 RVA: 0x007BE2C8 File Offset: 0x007BC4C8
		public ITransitionPopupLeftTopTipT AsITransitionPopupLeftTopTip()
		{
			return this.As<ITransitionPopupLeftTopTipT>();
		}

		// Token: 0x0603957F RID: 234879 RVA: 0x007BE2D0 File Offset: 0x007BC4D0
		public static ITransitionPopupStyle_UnionUnion FromITransitionPopupLeftTopTip(ITransitionPopupLeftTopTipT _itransitionpopuplefttoptip)
		{
			return new ITransitionPopupStyle_UnionUnion
			{
				Type = ITransitionPopupStyle_Union.ITransitionPopupLeftTopTip,
				Value = _itransitionpopuplefttoptip
			};
		}

		// Token: 0x06039580 RID: 234880 RVA: 0x007BE2E5 File Offset: 0x007BC4E5
		public ITransitionPopupLeftBottomTransitionT AsITransitionPopupLeftBottomTransition()
		{
			return this.As<ITransitionPopupLeftBottomTransitionT>();
		}

		// Token: 0x06039581 RID: 234881 RVA: 0x007BE2ED File Offset: 0x007BC4ED
		public static ITransitionPopupStyle_UnionUnion FromITransitionPopupLeftBottomTransition(ITransitionPopupLeftBottomTransitionT _itransitionpopupleftbottomtransition)
		{
			return new ITransitionPopupStyle_UnionUnion
			{
				Type = ITransitionPopupStyle_Union.ITransitionPopupLeftBottomTransition,
				Value = _itransitionpopupleftbottomtransition
			};
		}

		// Token: 0x06039582 RID: 234882 RVA: 0x007BE302 File Offset: 0x007BC502
		public ITransitionPopupArtTextT AsITransitionPopupArtText()
		{
			return this.As<ITransitionPopupArtTextT>();
		}

		// Token: 0x06039583 RID: 234883 RVA: 0x007BE30A File Offset: 0x007BC50A
		public static ITransitionPopupStyle_UnionUnion FromITransitionPopupArtText(ITransitionPopupArtTextT _itransitionpopuparttext)
		{
			return new ITransitionPopupStyle_UnionUnion
			{
				Type = ITransitionPopupStyle_Union.ITransitionPopupArtText,
				Value = _itransitionpopuparttext
			};
		}

		// Token: 0x06039584 RID: 234884 RVA: 0x007BE320 File Offset: 0x007BC520
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
