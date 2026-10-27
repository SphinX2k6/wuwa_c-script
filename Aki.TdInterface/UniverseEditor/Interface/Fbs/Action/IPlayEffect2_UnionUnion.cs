using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CEB RID: 27883
	public class IPlayEffect2_UnionUnion
	{
		// Token: 0x1700CFAF RID: 53167
		// (get) Token: 0x060312A7 RID: 201383 RVA: 0x006ABCD9 File Offset: 0x006A9ED9
		// (set) Token: 0x060312A8 RID: 201384 RVA: 0x006ABCE1 File Offset: 0x006A9EE1
		public IPlayEffect2_Union Type { get; set; }

		// Token: 0x1700CFB0 RID: 53168
		// (get) Token: 0x060312A9 RID: 201385 RVA: 0x006ABCEA File Offset: 0x006A9EEA
		// (set) Token: 0x060312AA RID: 201386 RVA: 0x006ABCF2 File Offset: 0x006A9EF2
		public object Value { get; set; }

		// Token: 0x060312AB RID: 201387 RVA: 0x006ABCFB File Offset: 0x006A9EFB
		public IPlayEffect2_UnionUnion()
		{
			this.Type = IPlayEffect2_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060312AC RID: 201388 RVA: 0x006ABD11 File Offset: 0x006A9F11
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060312AD RID: 201389 RVA: 0x006ABD23 File Offset: 0x006A9F23
		public IPlayEffect2T AsIPlayEffect2()
		{
			return this.As<IPlayEffect2T>();
		}

		// Token: 0x060312AE RID: 201390 RVA: 0x006ABD2B File Offset: 0x006A9F2B
		public static IPlayEffect2_UnionUnion FromIPlayEffect2(IPlayEffect2T _iplayeffect2)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayEffect2,
				Value = _iplayeffect2
			};
		}

		// Token: 0x060312AF RID: 201391 RVA: 0x006ABD40 File Offset: 0x006A9F40
		public IPlayCommonEffectT AsIPlayCommonEffect()
		{
			return this.As<IPlayCommonEffectT>();
		}

		// Token: 0x060312B0 RID: 201392 RVA: 0x006ABD48 File Offset: 0x006A9F48
		public static IPlayEffect2_UnionUnion FromIPlayCommonEffect(IPlayCommonEffectT _iplaycommoneffect)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayCommonEffect,
				Value = _iplaycommoneffect
			};
		}

		// Token: 0x060312B1 RID: 201393 RVA: 0x006ABD5D File Offset: 0x006A9F5D
		public IPlayScreenEffectT AsIPlayScreenEffect()
		{
			return this.As<IPlayScreenEffectT>();
		}

		// Token: 0x060312B2 RID: 201394 RVA: 0x006ABD65 File Offset: 0x006A9F65
		public static IPlayEffect2_UnionUnion FromIPlayScreenEffect(IPlayScreenEffectT _iplayscreeneffect)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayScreenEffect,
				Value = _iplayscreeneffect
			};
		}

		// Token: 0x060312B3 RID: 201395 RVA: 0x006ABD7A File Offset: 0x006A9F7A
		public ISwitchEffectStateT AsISwitchEffectState()
		{
			return this.As<ISwitchEffectStateT>();
		}

		// Token: 0x060312B4 RID: 201396 RVA: 0x006ABD82 File Offset: 0x006A9F82
		public static IPlayEffect2_UnionUnion FromISwitchEffectState(ISwitchEffectStateT _iswitcheffectstate)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.ISwitchEffectState,
				Value = _iswitcheffectstate
			};
		}

		// Token: 0x060312B5 RID: 201397 RVA: 0x006ABD97 File Offset: 0x006A9F97
		public IPlayDissolveEffectT AsIPlayDissolveEffect()
		{
			return this.As<IPlayDissolveEffectT>();
		}

		// Token: 0x060312B6 RID: 201398 RVA: 0x006ABD9F File Offset: 0x006A9F9F
		public static IPlayEffect2_UnionUnion FromIPlayDissolveEffect(IPlayDissolveEffectT _iplaydissolveeffect)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayDissolveEffect,
				Value = _iplaydissolveeffect
			};
		}

		// Token: 0x060312B7 RID: 201399 RVA: 0x006ABDB4 File Offset: 0x006A9FB4
		public IPlayMpcEffectT AsIPlayMpcEffect()
		{
			return this.As<IPlayMpcEffectT>();
		}

		// Token: 0x060312B8 RID: 201400 RVA: 0x006ABDBC File Offset: 0x006A9FBC
		public static IPlayEffect2_UnionUnion FromIPlayMpcEffect(IPlayMpcEffectT _iplaympceffect)
		{
			return new IPlayEffect2_UnionUnion
			{
				Type = IPlayEffect2_Union.IPlayMpcEffect,
				Value = _iplaympceffect
			};
		}

		// Token: 0x060312B9 RID: 201401 RVA: 0x006ABDD4 File Offset: 0x006A9FD4
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
