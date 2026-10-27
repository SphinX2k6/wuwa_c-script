using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007753 RID: 30547
	public class TPlayEffect2TypeUnion
	{
		// Token: 0x1700E67B RID: 59003
		// (get) Token: 0x060377DE RID: 227294 RVA: 0x00782DEA File Offset: 0x00780FEA
		// (set) Token: 0x060377DF RID: 227295 RVA: 0x00782DF2 File Offset: 0x00780FF2
		public TPlayEffect2Type Type { get; set; }

		// Token: 0x1700E67C RID: 59004
		// (get) Token: 0x060377E0 RID: 227296 RVA: 0x00782DFB File Offset: 0x00780FFB
		// (set) Token: 0x060377E1 RID: 227297 RVA: 0x00782E03 File Offset: 0x00781003
		public object Value { get; set; }

		// Token: 0x060377E2 RID: 227298 RVA: 0x00782E0C File Offset: 0x0078100C
		public TPlayEffect2TypeUnion()
		{
			this.Type = TPlayEffect2Type.NONE;
			this.Value = null;
		}

		// Token: 0x060377E3 RID: 227299 RVA: 0x00782E22 File Offset: 0x00781022
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060377E4 RID: 227300 RVA: 0x00782E34 File Offset: 0x00781034
		public IPlayCommonEffectT AsIPlayCommonEffect()
		{
			return this.As<IPlayCommonEffectT>();
		}

		// Token: 0x060377E5 RID: 227301 RVA: 0x00782E3C File Offset: 0x0078103C
		public static TPlayEffect2TypeUnion FromIPlayCommonEffect(IPlayCommonEffectT _iplaycommoneffect)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.IPlayCommonEffect,
				Value = _iplaycommoneffect
			};
		}

		// Token: 0x060377E6 RID: 227302 RVA: 0x00782E51 File Offset: 0x00781051
		public IPlayDissolveEffectT AsIPlayDissolveEffect()
		{
			return this.As<IPlayDissolveEffectT>();
		}

		// Token: 0x060377E7 RID: 227303 RVA: 0x00782E59 File Offset: 0x00781059
		public static TPlayEffect2TypeUnion FromIPlayDissolveEffect(IPlayDissolveEffectT _iplaydissolveeffect)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.IPlayDissolveEffect,
				Value = _iplaydissolveeffect
			};
		}

		// Token: 0x060377E8 RID: 227304 RVA: 0x00782E6E File Offset: 0x0078106E
		public IPlayMpcEffectT AsIPlayMpcEffect()
		{
			return this.As<IPlayMpcEffectT>();
		}

		// Token: 0x060377E9 RID: 227305 RVA: 0x00782E76 File Offset: 0x00781076
		public static TPlayEffect2TypeUnion FromIPlayMpcEffect(IPlayMpcEffectT _iplaympceffect)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.IPlayMpcEffect,
				Value = _iplaympceffect
			};
		}

		// Token: 0x060377EA RID: 227306 RVA: 0x00782E8B File Offset: 0x0078108B
		public IPlayScreenEffectT AsIPlayScreenEffect()
		{
			return this.As<IPlayScreenEffectT>();
		}

		// Token: 0x060377EB RID: 227307 RVA: 0x00782E93 File Offset: 0x00781093
		public static TPlayEffect2TypeUnion FromIPlayScreenEffect(IPlayScreenEffectT _iplayscreeneffect)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.IPlayScreenEffect,
				Value = _iplayscreeneffect
			};
		}

		// Token: 0x060377EC RID: 227308 RVA: 0x00782EA8 File Offset: 0x007810A8
		public ISwitchEffectStateT AsISwitchEffectState()
		{
			return this.As<ISwitchEffectStateT>();
		}

		// Token: 0x060377ED RID: 227309 RVA: 0x00782EB0 File Offset: 0x007810B0
		public static TPlayEffect2TypeUnion FromISwitchEffectState(ISwitchEffectStateT _iswitcheffectstate)
		{
			return new TPlayEffect2TypeUnion
			{
				Type = TPlayEffect2Type.ISwitchEffectState,
				Value = _iswitcheffectstate
			};
		}

		// Token: 0x060377EE RID: 227310 RVA: 0x00782EC8 File Offset: 0x007810C8
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
