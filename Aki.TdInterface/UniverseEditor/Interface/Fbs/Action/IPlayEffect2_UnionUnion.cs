using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007460 RID: 29792
	public class IPlayEffect2_UnionUnion
	{
		// Token: 0x1700DAEE RID: 56046
		// (get) Token: 0x0603427B RID: 213627 RVA: 0x00706F49 File Offset: 0x00705149
		// (set) Token: 0x0603427C RID: 213628 RVA: 0x00706F51 File Offset: 0x00705151
		public IPlayEffect2_Union Type { get; set; }

		// Token: 0x1700DAEF RID: 56047
		// (get) Token: 0x0603427D RID: 213629 RVA: 0x00706F5A File Offset: 0x0070515A
		// (set) Token: 0x0603427E RID: 213630 RVA: 0x00706F62 File Offset: 0x00705162
		public object Value { get; set; }

		// Token: 0x0603427F RID: 213631 RVA: 0x00706F6B File Offset: 0x0070516B
		public IPlayEffect2_UnionUnion()
		{
			this.Type = IPlayEffect2_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034280 RID: 213632 RVA: 0x00706F81 File Offset: 0x00705181
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06034281 RID: 213633 RVA: 0x00706F93 File Offset: 0x00705193
		public IPlayEffect2T AsIPlayEffect2()
		{
			return this.As<IPlayEffect2T>();
		}

		// Token: 0x06034282 RID: 213634 RVA: 0x00706F9B File Offset: 0x0070519B
		public static IPlayEffect2_UnionUnion FromIPlayEffect2(IPlayEffect2T _iplayeffect2)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayEffect2,
				Value = _iplayeffect2
			};
		}

		// Token: 0x06034283 RID: 213635 RVA: 0x00706FB0 File Offset: 0x007051B0
		public IPlayCommonEffectT AsIPlayCommonEffect()
		{
			return this.As<IPlayCommonEffectT>();
		}

		// Token: 0x06034284 RID: 213636 RVA: 0x00706FB8 File Offset: 0x007051B8
		public static IPlayEffect2_UnionUnion FromIPlayCommonEffect(IPlayCommonEffectT _iplaycommoneffect)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayCommonEffect,
				Value = _iplaycommoneffect
			};
		}

		// Token: 0x06034285 RID: 213637 RVA: 0x00706FCD File Offset: 0x007051CD
		public IPlayScreenEffectT AsIPlayScreenEffect()
		{
			return this.As<IPlayScreenEffectT>();
		}

		// Token: 0x06034286 RID: 213638 RVA: 0x00706FD5 File Offset: 0x007051D5
		public static IPlayEffect2_UnionUnion FromIPlayScreenEffect(IPlayScreenEffectT _iplayscreeneffect)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayScreenEffect,
				Value = _iplayscreeneffect
			};
		}

		// Token: 0x06034287 RID: 213639 RVA: 0x00706FEA File Offset: 0x007051EA
		public ISwitchEffectStateT AsISwitchEffectState()
		{
			return this.As<ISwitchEffectStateT>();
		}

		// Token: 0x06034288 RID: 213640 RVA: 0x00706FF2 File Offset: 0x007051F2
		public static IPlayEffect2_UnionUnion FromISwitchEffectState(ISwitchEffectStateT _iswitcheffectstate)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.ISwitchEffectState,
				Value = _iswitcheffectstate
			};
		}

		// Token: 0x06034289 RID: 213641 RVA: 0x00707007 File Offset: 0x00705207
		public IPlayDissolveEffectT AsIPlayDissolveEffect()
		{
			return this.As<IPlayDissolveEffectT>();
		}

		// Token: 0x0603428A RID: 213642 RVA: 0x0070700F File Offset: 0x0070520F
		public static IPlayEffect2_UnionUnion FromIPlayDissolveEffect(IPlayDissolveEffectT _iplaydissolveeffect)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayDissolveEffect,
				Value = _iplaydissolveeffect
			};
		}

		// Token: 0x0603428B RID: 213643 RVA: 0x00707024 File Offset: 0x00705224
		public IPlayMpcEffectT AsIPlayMpcEffect()
		{
			return this.As<IPlayMpcEffectT>();
		}

		// Token: 0x0603428C RID: 213644 RVA: 0x0070702C File Offset: 0x0070522C
		public static IPlayEffect2_UnionUnion FromIPlayMpcEffect(IPlayMpcEffectT _iplaympceffect)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayMpcEffect,
				Value = _iplaympceffect
			};
		}

		// Token: 0x0603428D RID: 213645 RVA: 0x00707044 File Offset: 0x00705244
		public static int Pack(FlatBufferBuilder builder, IPlayEffect2_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPlayEffect2_Union.IPlayEffect2:
				return IPlayEffect2.Pack(builder, _o.AsIPlayEffect2()).Value;
			case IPlayEffect2_Union.IPlayCommonEffect:
				return IPlayCommonEffect.Pack(builder, _o.AsIPlayCommonEffect()).Value;
			case IPlayEffect2_Union.IPlayScreenEffect:
				return IPlayScreenEffect.Pack(builder, _o.AsIPlayScreenEffect()).Value;
			case IPlayEffect2_Union.ISwitchEffectState:
				return ISwitchEffectState.Pack(builder, _o.AsISwitchEffectState()).Value;
			case IPlayEffect2_Union.IPlayDissolveEffect:
				return IPlayDissolveEffect.Pack(builder, _o.AsIPlayDissolveEffect()).Value;
			case IPlayEffect2_Union.IPlayMpcEffect:
				return IPlayMpcEffect.Pack(builder, _o.AsIPlayMpcEffect()).Value;
			default:
				return 0;
			}
		}
	}
}
