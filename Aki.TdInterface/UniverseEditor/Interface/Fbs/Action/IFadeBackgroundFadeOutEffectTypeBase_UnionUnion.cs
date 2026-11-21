using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF8 RID: 28152
	public class IFadeBackgroundFadeOutEffectTypeBase_UnionUnion
	{
		// Token: 0x1700CE50 RID: 52816
		// (get) Token: 0x0603098B RID: 199051 RVA: 0x00699099 File Offset: 0x00697299
		// (set) Token: 0x0603098C RID: 199052 RVA: 0x006990A1 File Offset: 0x006972A1
		public IFadeBackgroundFadeOutEffectTypeBase_Union Type { get; set; }

		// Token: 0x1700CE51 RID: 52817
		// (get) Token: 0x0603098D RID: 199053 RVA: 0x006990AA File Offset: 0x006972AA
		// (set) Token: 0x0603098E RID: 199054 RVA: 0x006990B2 File Offset: 0x006972B2
		public object Value { get; set; }

		// Token: 0x0603098F RID: 199055 RVA: 0x006990BB File Offset: 0x006972BB
		public IFadeBackgroundFadeOutEffectTypeBase_UnionUnion()
		{
			this.Type = IFadeBackgroundFadeOutEffectTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030990 RID: 199056 RVA: 0x006990D1 File Offset: 0x006972D1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030991 RID: 199057 RVA: 0x006990E3 File Offset: 0x006972E3
		public IFadeBackgroundFadeOutEffectTypeBaseT AsIFadeBackgroundFadeOutEffectTypeBase()
		{
			return this.As<IFadeBackgroundFadeOutEffectTypeBaseT>();
		}

		// Token: 0x06030992 RID: 199058 RVA: 0x006990EB File Offset: 0x006972EB
		public static IFadeBackgroundFadeOutEffectTypeBase_UnionUnion FromIFadeBackgroundFadeOutEffectTypeBase(IFadeBackgroundFadeOutEffectTypeBaseT _ifadebackgroundfadeouteffecttypebase)
		{
			return new IFadeBackgroundFadeOutEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeOutEffectTypeBase_Union.IFadeBackgroundFadeOutEffectTypeBase,
				Value = _ifadebackgroundfadeouteffecttypebase
			};
		}

		// Token: 0x06030993 RID: 199059 RVA: 0x00699100 File Offset: 0x00697300
		public IFadeBackgroundFadeOutEffectBlackT AsIFadeBackgroundFadeOutEffectBlack()
		{
			return this.As<IFadeBackgroundFadeOutEffectBlackT>();
		}

		// Token: 0x06030994 RID: 199060 RVA: 0x00699108 File Offset: 0x00697308
		public static IFadeBackgroundFadeOutEffectTypeBase_UnionUnion FromIFadeBackgroundFadeOutEffectBlack(IFadeBackgroundFadeOutEffectBlackT _ifadebackgroundfadeouteffectblack)
		{
			return new IFadeBackgroundFadeOutEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeOutEffectTypeBase_Union.IFadeBackgroundFadeOutEffectBlack,
				Value = _ifadebackgroundfadeouteffectblack
			};
		}

		// Token: 0x06030995 RID: 199061 RVA: 0x0069911D File Offset: 0x0069731D
		public IFadeBackgroundFadeOutEffectScreenEffectT AsIFadeBackgroundFadeOutEffectScreenEffect()
		{
			return this.As<IFadeBackgroundFadeOutEffectScreenEffectT>();
		}

		// Token: 0x06030996 RID: 199062 RVA: 0x00699125 File Offset: 0x00697325
		public static IFadeBackgroundFadeOutEffectTypeBase_UnionUnion FromIFadeBackgroundFadeOutEffectScreenEffect(IFadeBackgroundFadeOutEffectScreenEffectT _ifadebackgroundfadeouteffectscreeneffect)
		{
			return new IFadeBackgroundFadeOutEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeOutEffectTypeBase_Union.IFadeBackgroundFadeOutEffectScreenEffect,
				Value = _ifadebackgroundfadeouteffectscreeneffect
			};
		}

		// Token: 0x06030997 RID: 199063 RVA: 0x0069913C File Offset: 0x0069733C
		public static int Pack(FlatBufferBuilder builder, IFadeBackgroundFadeOutEffectTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFadeBackgroundFadeOutEffectTypeBase_Union.IFadeBackgroundFadeOutEffectTypeBase:
				return IFadeBackgroundFadeOutEffectTypeBase.Pack(builder, _o.AsIFadeBackgroundFadeOutEffectTypeBase()).Value;
			case IFadeBackgroundFadeOutEffectTypeBase_Union.IFadeBackgroundFadeOutEffectBlack:
				return IFadeBackgroundFadeOutEffectBlack.Pack(builder, _o.AsIFadeBackgroundFadeOutEffectBlack()).Value;
			case IFadeBackgroundFadeOutEffectTypeBase_Union.IFadeBackgroundFadeOutEffectScreenEffect:
				return IFadeBackgroundFadeOutEffectScreenEffect.Pack(builder, _o.AsIFadeBackgroundFadeOutEffectScreenEffect()).Value;
			default:
				return 0;
			}
		}
	}
}
