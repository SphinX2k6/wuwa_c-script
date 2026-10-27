using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077EA RID: 30698
	public class TTransitionPopupStyleUnion
	{
		// Token: 0x1700E6DF RID: 59103
		// (get) Token: 0x06037AC0 RID: 228032 RVA: 0x00787232 File Offset: 0x00785432
		// (set) Token: 0x06037AC1 RID: 228033 RVA: 0x0078723A File Offset: 0x0078543A
		public TTransitionPopupStyle Type { get; set; }

		// Token: 0x1700E6E0 RID: 59104
		// (get) Token: 0x06037AC2 RID: 228034 RVA: 0x00787243 File Offset: 0x00785443
		// (set) Token: 0x06037AC3 RID: 228035 RVA: 0x0078724B File Offset: 0x0078544B
		public object Value { get; set; }

		// Token: 0x06037AC4 RID: 228036 RVA: 0x00787254 File Offset: 0x00785454
		public TTransitionPopupStyleUnion()
		{
			this.Type = TTransitionPopupStyle.NONE;
			this.Value = null;
		}

		// Token: 0x06037AC5 RID: 228037 RVA: 0x0078726A File Offset: 0x0078546A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037AC6 RID: 228038 RVA: 0x0078727C File Offset: 0x0078547C
		public ITransitionPopupArtTextT AsITransitionPopupArtText()
		{
			return this.As<ITransitionPopupArtTextT>();
		}

		// Token: 0x06037AC7 RID: 228039 RVA: 0x00787284 File Offset: 0x00785484
		public static TTransitionPopupStyleUnion FromITransitionPopupArtText(ITransitionPopupArtTextT _itransitionpopuparttext)
		{
			return new TTransitionPopupStyleUnion
			{
				Type = TTransitionPopupStyle.ITransitionPopupArtText,
				Value = _itransitionpopuparttext
			};
		}

		// Token: 0x06037AC8 RID: 228040 RVA: 0x00787299 File Offset: 0x00785499
		public ITransitionPopupLeftBottomTransitionT AsITransitionPopupLeftBottomTransition()
		{
			return this.As<ITransitionPopupLeftBottomTransitionT>();
		}

		// Token: 0x06037AC9 RID: 228041 RVA: 0x007872A1 File Offset: 0x007854A1
		public static TTransitionPopupStyleUnion FromITransitionPopupLeftBottomTransition(ITransitionPopupLeftBottomTransitionT _itransitionpopupleftbottomtransition)
		{
			return new TTransitionPopupStyleUnion
			{
				Type = TTransitionPopupStyle.ITransitionPopupLeftBottomTransition,
				Value = _itransitionpopupleftbottomtransition
			};
		}

		// Token: 0x06037ACA RID: 228042 RVA: 0x007872B6 File Offset: 0x007854B6
		public ITransitionPopupLeftTopTipT AsITransitionPopupLeftTopTip()
		{
			return this.As<ITransitionPopupLeftTopTipT>();
		}

		// Token: 0x06037ACB RID: 228043 RVA: 0x007872BE File Offset: 0x007854BE
		public static TTransitionPopupStyleUnion FromITransitionPopupLeftTopTip(ITransitionPopupLeftTopTipT _itransitionpopuplefttoptip)
		{
			return new TTransitionPopupStyleUnion
			{
				Type = TTransitionPopupStyle.ITransitionPopupLeftTopTip,
				Value = _itransitionpopuplefttoptip
			};
		}

		// Token: 0x06037ACC RID: 228044 RVA: 0x007872D4 File Offset: 0x007854D4
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
