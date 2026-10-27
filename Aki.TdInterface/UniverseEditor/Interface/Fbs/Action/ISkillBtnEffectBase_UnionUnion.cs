using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712E RID: 28974
	public class ISkillBtnEffectBase_UnionUnion
	{
		// Token: 0x1700D759 RID: 55129
		// (get) Token: 0x060335E7 RID: 210407 RVA: 0x006EC855 File Offset: 0x006EAA55
		// (set) Token: 0x060335E8 RID: 210408 RVA: 0x006EC85D File Offset: 0x006EAA5D
		public ISkillBtnEffectBase_Union Type { get; set; }

		// Token: 0x1700D75A RID: 55130
		// (get) Token: 0x060335E9 RID: 210409 RVA: 0x006EC866 File Offset: 0x006EAA66
		// (set) Token: 0x060335EA RID: 210410 RVA: 0x006EC86E File Offset: 0x006EAA6E
		public object Value { get; set; }

		// Token: 0x060335EB RID: 210411 RVA: 0x006EC877 File Offset: 0x006EAA77
		public ISkillBtnEffectBase_UnionUnion()
		{
			this.Type = ISkillBtnEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060335EC RID: 210412 RVA: 0x006EC88D File Offset: 0x006EAA8D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060335ED RID: 210413 RVA: 0x006EC89F File Offset: 0x006EAA9F
		public ISkillBtnEffectBaseT AsISkillBtnEffectBase()
		{
			return this.As<ISkillBtnEffectBaseT>();
		}

		// Token: 0x060335EE RID: 210414 RVA: 0x006EC8A7 File Offset: 0x006EAAA7
		public static ISkillBtnEffectBase_UnionUnion FromISkillBtnEffectBase(ISkillBtnEffectBaseT _iskillbtneffectbase)
		{
			return new ISkillBtnEffectBase_UnionUnion
			{
				Type = ISkillBtnEffectBase_Union.ISkillBtnEffectBase,
				Value = _iskillbtneffectbase
			};
		}

		// Token: 0x060335EF RID: 210415 RVA: 0x006EC8BC File Offset: 0x006EAABC
		public IMusicBattleBtnEffectT AsIMusicBattleBtnEffect()
		{
			return this.As<IMusicBattleBtnEffectT>();
		}

		// Token: 0x060335F0 RID: 210416 RVA: 0x006EC8C4 File Offset: 0x006EAAC4
		public static ISkillBtnEffectBase_UnionUnion FromIMusicBattleBtnEffect(IMusicBattleBtnEffectT _imusicbattlebtneffect)
		{
			return new ISkillBtnEffectBase_UnionUnion
			{
				Type = ISkillBtnEffectBase_Union.IMusicBattleBtnEffect,
				Value = _imusicbattlebtneffect
			};
		}

		// Token: 0x060335F1 RID: 210417 RVA: 0x006EC8DC File Offset: 0x006EAADC
		public static int Pack(FlatBufferBuilder builder, ISkillBtnEffectBase_UnionUnion _o)
		{
			ISkillBtnEffectBase_Union type = _o.Type;
			if (type == ISkillBtnEffectBase_Union.ISkillBtnEffectBase)
			{
				return ISkillBtnEffectBase.Pack(builder, _o.AsISkillBtnEffectBase()).Value;
			}
			if (type != ISkillBtnEffectBase_Union.IMusicBattleBtnEffect)
			{
				return 0;
			}
			return IMusicBattleBtnEffect.Pack(builder, _o.AsIMusicBattleBtnEffect()).Value;
		}
	}
}
