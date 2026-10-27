using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006778 RID: 26488
	public class IFadeBackgroundFadeOutEffectTypeBase_UnionUnion
	{
		// Token: 0x1700C49A RID: 50330
		// (get) Token: 0x0602E145 RID: 188741 RVA: 0x0064B955 File Offset: 0x00649B55
		// (set) Token: 0x0602E146 RID: 188742 RVA: 0x0064B95D File Offset: 0x00649B5D
		public IFadeBackgroundFadeOutEffectTypeBase_Union Type { get; set; }

		// Token: 0x1700C49B RID: 50331
		// (get) Token: 0x0602E147 RID: 188743 RVA: 0x0064B966 File Offset: 0x00649B66
		// (set) Token: 0x0602E148 RID: 188744 RVA: 0x0064B96E File Offset: 0x00649B6E
		public object Value { get; set; }

		// Token: 0x0602E149 RID: 188745 RVA: 0x0064B977 File Offset: 0x00649B77
		public IFadeBackgroundFadeOutEffectTypeBase_UnionUnion()
		{
			this.Type = IFadeBackgroundFadeOutEffectTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E14A RID: 188746 RVA: 0x0064B98D File Offset: 0x00649B8D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E14B RID: 188747 RVA: 0x0064B99F File Offset: 0x00649B9F
		public IFadeBackgroundFadeOutEffectTypeBaseT AsIFadeBackgroundFadeOutEffectTypeBase()
		{
			return this.As<IFadeBackgroundFadeOutEffectTypeBaseT>();
		}

		// Token: 0x0602E14C RID: 188748 RVA: 0x0064B9A7 File Offset: 0x00649BA7
		public static IFadeBackgroundFadeOutEffectTypeBase_UnionUnion FromIFadeBackgroundFadeOutEffectTypeBase(IFadeBackgroundFadeOutEffectTypeBaseT _ifadebackgroundfadeouteffecttypebase)
		{
			return new IFadeBackgroundFadeOutEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeOutEffectTypeBase_Union.IFadeBackgroundFadeOutEffectTypeBase,
				Value = _ifadebackgroundfadeouteffecttypebase
			};
		}

		// Token: 0x0602E14D RID: 188749 RVA: 0x0064B9BC File Offset: 0x00649BBC
		public IFadeBackgroundFadeOutEffectBlackT AsIFadeBackgroundFadeOutEffectBlack()
		{
			return this.As<IFadeBackgroundFadeOutEffectBlackT>();
		}

		// Token: 0x0602E14E RID: 188750 RVA: 0x0064B9C4 File Offset: 0x00649BC4
		public static IFadeBackgroundFadeOutEffectTypeBase_UnionUnion FromIFadeBackgroundFadeOutEffectBlack(IFadeBackgroundFadeOutEffectBlackT _ifadebackgroundfadeouteffectblack)
		{
			return new IFadeBackgroundFadeOutEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeOutEffectTypeBase_Union.IFadeBackgroundFadeOutEffectBlack,
				Value = _ifadebackgroundfadeouteffectblack
			};
		}

		// Token: 0x0602E14F RID: 188751 RVA: 0x0064B9D9 File Offset: 0x00649BD9
		public IFadeBackgroundFadeOutEffectScreenEffectT AsIFadeBackgroundFadeOutEffectScreenEffect()
		{
			return this.As<IFadeBackgroundFadeOutEffectScreenEffectT>();
		}

		// Token: 0x0602E150 RID: 188752 RVA: 0x0064B9E1 File Offset: 0x00649BE1
		public static IFadeBackgroundFadeOutEffectTypeBase_UnionUnion FromIFadeBackgroundFadeOutEffectScreenEffect(IFadeBackgroundFadeOutEffectScreenEffectT _ifadebackgroundfadeouteffectscreeneffect)
		{
			return new IFadeBackgroundFadeOutEffectTypeBase_UnionUnion
			{
				Type = IFadeBackgroundFadeOutEffectTypeBase_Union.IFadeBackgroundFadeOutEffectScreenEffect,
				Value = _ifadebackgroundfadeouteffectscreeneffect
			};
		}

		// Token: 0x0602E151 RID: 188753 RVA: 0x0064B9F8 File Offset: 0x00649BF8
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
