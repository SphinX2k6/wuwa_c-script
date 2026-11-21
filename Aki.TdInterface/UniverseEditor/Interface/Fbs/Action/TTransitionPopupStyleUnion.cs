using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008028 RID: 32808
	public class TTransitionPopupStyleUnion
	{
		// Token: 0x1700F33D RID: 62269
		// (get) Token: 0x0603B05F RID: 241759 RVA: 0x007ECADE File Offset: 0x007EACDE
		// (set) Token: 0x0603B060 RID: 241760 RVA: 0x007ECAE6 File Offset: 0x007EACE6
		public TTransitionPopupStyle Type { get; set; }

		// Token: 0x1700F33E RID: 62270
		// (get) Token: 0x0603B061 RID: 241761 RVA: 0x007ECAEF File Offset: 0x007EACEF
		// (set) Token: 0x0603B062 RID: 241762 RVA: 0x007ECAF7 File Offset: 0x007EACF7
		public object Value { get; set; }

		// Token: 0x0603B063 RID: 241763 RVA: 0x007ECB00 File Offset: 0x007EAD00
		public TTransitionPopupStyleUnion()
		{
			this.Type = TTransitionPopupStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0603B064 RID: 241764 RVA: 0x007ECB16 File Offset: 0x007EAD16
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B065 RID: 241765 RVA: 0x007ECB28 File Offset: 0x007EAD28
		public ITransitionPopupArtTextT AsITransitionPopupArtText()
		{
			return this.As<ITransitionPopupArtTextT>();
		}

		// Token: 0x0603B066 RID: 241766 RVA: 0x007ECB30 File Offset: 0x007EAD30
		public static TTransitionPopupStyleUnion FromITransitionPopupArtText(ITransitionPopupArtTextT _itransitionpopuparttext)
		{
			return new TTransitionPopupStyleUnion
			{
				Type = TTransitionPopupStyle.ITransitionPopupArtText,
				Value = _itransitionpopuparttext
			};
		}

		// Token: 0x0603B067 RID: 241767 RVA: 0x007ECB45 File Offset: 0x007EAD45
		public ITransitionPopupLeftBottomTransitionT AsITransitionPopupLeftBottomTransition()
		{
			return this.As<ITransitionPopupLeftBottomTransitionT>();
		}

		// Token: 0x0603B068 RID: 241768 RVA: 0x007ECB4D File Offset: 0x007EAD4D
		public static TTransitionPopupStyleUnion FromITransitionPopupLeftBottomTransition(ITransitionPopupLeftBottomTransitionT _itransitionpopupleftbottomtransition)
		{
			return new TTransitionPopupStyleUnion
			{
				Type = TTransitionPopupStyle.ITransitionPopupLeftBottomTransition,
				Value = _itransitionpopupleftbottomtransition
			};
		}

		// Token: 0x0603B069 RID: 241769 RVA: 0x007ECB62 File Offset: 0x007EAD62
		public ITransitionPopupLeftTopTipT AsITransitionPopupLeftTopTip()
		{
			return this.As<ITransitionPopupLeftTopTipT>();
		}

		// Token: 0x0603B06A RID: 241770 RVA: 0x007ECB6A File Offset: 0x007EAD6A
		public static TTransitionPopupStyleUnion FromITransitionPopupLeftTopTip(ITransitionPopupLeftTopTipT _itransitionpopuplefttoptip)
		{
			return new TTransitionPopupStyleUnion
			{
				Type = TTransitionPopupStyle.ITransitionPopupLeftTopTip,
				Value = _itransitionpopuplefttoptip
			};
		}

		// Token: 0x0603B06B RID: 241771 RVA: 0x007ECB80 File Offset: 0x007EAD80
		public static int Pack(FlatBufferBuilder builder, TTransitionPopupStyleUnion _o)
		{
			switch (_o.Type)
			{
			case TTransitionPopupStyle.ITransitionPopupArtText:
				return ITransitionPopupArtText.Pack(builder, _o.AsITransitionPopupArtText()).Value;
			case TTransitionPopupStyle.ITransitionPopupLeftBottomTransition:
				return ITransitionPopupLeftBottomTransition.Pack(builder, _o.AsITransitionPopupLeftBottomTransition()).Value;
			case TTransitionPopupStyle.ITransitionPopupLeftTopTip:
				return ITransitionPopupLeftTopTip.Pack(builder, _o.AsITransitionPopupLeftTopTip()).Value;
			default:
				return 0;
			}
		}
	}
}
