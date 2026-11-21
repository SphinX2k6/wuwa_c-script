using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F7C RID: 32636
	public class TPlayEffect2TypeUnion
	{
		// Token: 0x1700F2CB RID: 62155
		// (get) Token: 0x0603AD1B RID: 240923 RVA: 0x007E7DBE File Offset: 0x007E5FBE
		// (set) Token: 0x0603AD1C RID: 240924 RVA: 0x007E7DC6 File Offset: 0x007E5FC6
		public TPlayEffect2Type Type { get; set; }

		// Token: 0x1700F2CC RID: 62156
		// (get) Token: 0x0603AD1D RID: 240925 RVA: 0x007E7DCF File Offset: 0x007E5FCF
		// (set) Token: 0x0603AD1E RID: 240926 RVA: 0x007E7DD7 File Offset: 0x007E5FD7
		public object Value { get; set; }

		// Token: 0x0603AD1F RID: 240927 RVA: 0x007E7DE0 File Offset: 0x007E5FE0
		public TPlayEffect2TypeUnion()
		{
			this.Type = TPlayEffect2Type.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD20 RID: 240928 RVA: 0x007E7DF6 File Offset: 0x007E5FF6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD21 RID: 240929 RVA: 0x007E7E08 File Offset: 0x007E6008
		public IPlayCommonEffectT AsIPlayCommonEffect()
		{
			return this.As<IPlayCommonEffectT>();
		}

		// Token: 0x0603AD22 RID: 240930 RVA: 0x007E7E10 File Offset: 0x007E6010
		public static TPlayEffect2TypeUnion FromIPlayCommonEffect(IPlayCommonEffectT _iplaycommoneffect)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.IPlayCommonEffect,
				Value = _iplaycommoneffect
			};
		}

		// Token: 0x0603AD23 RID: 240931 RVA: 0x007E7E25 File Offset: 0x007E6025
		public IPlayDissolveEffectT AsIPlayDissolveEffect()
		{
			return this.As<IPlayDissolveEffectT>();
		}

		// Token: 0x0603AD24 RID: 240932 RVA: 0x007E7E2D File Offset: 0x007E602D
		public static TPlayEffect2TypeUnion FromIPlayDissolveEffect(IPlayDissolveEffectT _iplaydissolveeffect)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.IPlayDissolveEffect,
				Value = _iplaydissolveeffect
			};
		}

		// Token: 0x0603AD25 RID: 240933 RVA: 0x007E7E42 File Offset: 0x007E6042
		public IPlayMpcEffectT AsIPlayMpcEffect()
		{
			return this.As<IPlayMpcEffectT>();
		}

		// Token: 0x0603AD26 RID: 240934 RVA: 0x007E7E4A File Offset: 0x007E604A
		public static TPlayEffect2TypeUnion FromIPlayMpcEffect(IPlayMpcEffectT _iplaympceffect)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.IPlayMpcEffect,
				Value = _iplaympceffect
			};
		}

		// Token: 0x0603AD27 RID: 240935 RVA: 0x007E7E5F File Offset: 0x007E605F
		public IPlayScreenEffectT AsIPlayScreenEffect()
		{
			return this.As<IPlayScreenEffectT>();
		}

		// Token: 0x0603AD28 RID: 240936 RVA: 0x007E7E67 File Offset: 0x007E6067
		public static TPlayEffect2TypeUnion FromIPlayScreenEffect(IPlayScreenEffectT _iplayscreeneffect)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.IPlayScreenEffect,
				Value = _iplayscreeneffect
			};
		}

		// Token: 0x0603AD29 RID: 240937 RVA: 0x007E7E7C File Offset: 0x007E607C
		public ISwitchEffectStateT AsISwitchEffectState()
		{
			return this.As<ISwitchEffectStateT>();
		}

		// Token: 0x0603AD2A RID: 240938 RVA: 0x007E7E84 File Offset: 0x007E6084
		public static TPlayEffect2TypeUnion FromISwitchEffectState(ISwitchEffectStateT _iswitcheffectstate)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.ISwitchEffectState,
				Value = _iswitcheffectstate
			};
		}

		// Token: 0x0603AD2B RID: 240939 RVA: 0x007E7E9C File Offset: 0x007E609C
		public static int Pack(FlatBufferBuilder builder, TPlayEffect2TypeUnion _o)
		{
			switch (_o.Type)
			{
			case TPlayEffect2Type.IPlayCommonEffect:
				return IPlayCommonEffect.Pack(builder, _o.AsIPlayCommonEffect()).Value;
			case TPlayEffect2Type.IPlayDissolveEffect:
				return IPlayDissolveEffect.Pack(builder, _o.AsIPlayDissolveEffect()).Value;
			case TPlayEffect2Type.IPlayMpcEffect:
				return IPlayMpcEffect.Pack(builder, _o.AsIPlayMpcEffect()).Value;
			case TPlayEffect2Type.IPlayScreenEffect:
				return IPlayScreenEffect.Pack(builder, _o.AsIPlayScreenEffect()).Value;
			case TPlayEffect2Type.ISwitchEffectState:
				return ISwitchEffectState.Pack(builder, _o.AsISwitchEffectState()).Value;
			default:
				return 0;
			}
		}
	}
}
