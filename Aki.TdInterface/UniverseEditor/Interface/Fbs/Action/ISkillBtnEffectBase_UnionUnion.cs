using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078FA RID: 30970
	public class ISkillBtnEffectBase_UnionUnion
	{
		// Token: 0x1700E33C RID: 58172
		// (get) Token: 0x06036889 RID: 223369 RVA: 0x0074CE61 File Offset: 0x0074B061
		// (set) Token: 0x0603688A RID: 223370 RVA: 0x0074CE69 File Offset: 0x0074B069
		public ISkillBtnEffectBase_Union Type { get; set; }

		// Token: 0x1700E33D RID: 58173
		// (get) Token: 0x0603688B RID: 223371 RVA: 0x0074CE72 File Offset: 0x0074B072
		// (set) Token: 0x0603688C RID: 223372 RVA: 0x0074CE7A File Offset: 0x0074B07A
		public object Value { get; set; }

		// Token: 0x0603688D RID: 223373 RVA: 0x0074CE83 File Offset: 0x0074B083
		public ISkillBtnEffectBase_UnionUnion()
		{
			this.Type = ISkillBtnEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603688E RID: 223374 RVA: 0x0074CE99 File Offset: 0x0074B099
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603688F RID: 223375 RVA: 0x0074CEAB File Offset: 0x0074B0AB
		public ISkillBtnEffectBaseT AsISkillBtnEffectBase()
		{
			return this.As<ISkillBtnEffectBaseT>();
		}

		// Token: 0x06036890 RID: 223376 RVA: 0x0074CEB3 File Offset: 0x0074B0B3
		public static ISkillBtnEffectBase_UnionUnion FromISkillBtnEffectBase(ISkillBtnEffectBaseT _iskillbtneffectbase)
		{
			return new ISkillBtnEffectBase_UnionUnion
			{
				Type = ISkillBtnEffectBase_Union.ISkillBtnEffectBase,
				Value = _iskillbtneffectbase
			};
		}

		// Token: 0x06036891 RID: 223377 RVA: 0x0074CEC8 File Offset: 0x0074B0C8
		public IMusicBattleBtnEffectT AsIMusicBattleBtnEffect()
		{
			return this.As<IMusicBattleBtnEffectT>();
		}

		// Token: 0x06036892 RID: 223378 RVA: 0x0074CED0 File Offset: 0x0074B0D0
		public static ISkillBtnEffectBase_UnionUnion FromIMusicBattleBtnEffect(IMusicBattleBtnEffectT _imusicbattlebtneffect)
		{
			return new ISkillBtnEffectBase_UnionUnion
			{
				Type = ISkillBtnEffectBase_Union.IMusicBattleBtnEffect,
				Value = _imusicbattlebtneffect
			};
		}

		// Token: 0x06036893 RID: 223379 RVA: 0x0074CEE8 File Offset: 0x0074B0E8
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
