using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007544 RID: 30020
	public class IPromptStyleBase_UnionUnion
	{
		// Token: 0x1700DCD7 RID: 56535
		// (get) Token: 0x06034A47 RID: 215623 RVA: 0x00715239 File Offset: 0x00713439
		// (set) Token: 0x06034A48 RID: 215624 RVA: 0x00715241 File Offset: 0x00713441
		public IPromptStyleBase_Union Type { get; set; }

		// Token: 0x1700DCD8 RID: 56536
		// (get) Token: 0x06034A49 RID: 215625 RVA: 0x0071524A File Offset: 0x0071344A
		// (set) Token: 0x06034A4A RID: 215626 RVA: 0x00715252 File Offset: 0x00713452
		public object Value { get; set; }

		// Token: 0x06034A4B RID: 215627 RVA: 0x0071525B File Offset: 0x0071345B
		public IPromptStyleBase_UnionUnion()
		{
			this.Type = IPromptStyleBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034A4C RID: 215628 RVA: 0x00715271 File Offset: 0x00713471
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06034A4D RID: 215629 RVA: 0x00715283 File Offset: 0x00713483
		public IPromptStyleBaseT AsIPromptStyleBase()
		{
			return this.As<IPromptStyleBaseT>();
		}

		// Token: 0x06034A4E RID: 215630 RVA: 0x0071528B File Offset: 0x0071348B
		public static IPromptStyleBase_UnionUnion FromIPromptStyleBase(IPromptStyleBaseT _ipromptstylebase)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStyleBase,
				Value = _ipromptstylebase
			};
		}

		// Token: 0x06034A4F RID: 215631 RVA: 0x007152A0 File Offset: 0x007134A0
		public IPromptStyleDefaultT AsIPromptStyleDefault()
		{
			return this.As<IPromptStyleDefaultT>();
		}

		// Token: 0x06034A50 RID: 215632 RVA: 0x007152A8 File Offset: 0x007134A8
		public static IPromptStyleBase_UnionUnion FromIPromptStyleDefault(IPromptStyleDefaultT _ipromptstyledefault)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStyleDefault,
				Value = _ipromptstyledefault
			};
		}

		// Token: 0x06034A51 RID: 215633 RVA: 0x007152BD File Offset: 0x007134BD
		public IPromptStylePhotoT AsIPromptStylePhoto()
		{
			return this.As<IPromptStylePhotoT>();
		}

		// Token: 0x06034A52 RID: 215634 RVA: 0x007152C5 File Offset: 0x007134C5
		public static IPromptStyleBase_UnionUnion FromIPromptStylePhoto(IPromptStylePhotoT _ipromptstylephoto)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStylePhoto,
				Value = _ipromptstylephoto
			};
		}

		// Token: 0x06034A53 RID: 215635 RVA: 0x007152DA File Offset: 0x007134DA
		public IPromptStyleBattleT AsIPromptStyleBattle()
		{
			return this.As<IPromptStyleBattleT>();
		}

		// Token: 0x06034A54 RID: 215636 RVA: 0x007152E2 File Offset: 0x007134E2
		public static IPromptStyleBase_UnionUnion FromIPromptStyleBattle(IPromptStyleBattleT _ipromptstylebattle)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStyleBattle,
				Value = _ipromptstylebattle
			};
		}

		// Token: 0x06034A55 RID: 215637 RVA: 0x007152F7 File Offset: 0x007134F7
		public IPromptStyleBattle2T AsIPromptStyleBattle2()
		{
			return this.As<IPromptStyleBattle2T>();
		}

		// Token: 0x06034A56 RID: 215638 RVA: 0x007152FF File Offset: 0x007134FF
		public static IPromptStyleBase_UnionUnion FromIPromptStyleBattle2(IPromptStyleBattle2T _ipromptstylebattle2)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStyleBattle2,
				Value = _ipromptstylebattle2
			};
		}

		// Token: 0x06034A57 RID: 215639 RVA: 0x00715314 File Offset: 0x00713514
		public static int Pack(FlatBufferBuilder builder, IPromptStyleBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPromptStyleBase_Union.IPromptStyleBase:
				return IPromptStyleBase.Pack(builder, _o.AsIPromptStyleBase()).Value;
			case IPromptStyleBase_Union.IPromptStyleDefault:
				return IPromptStyleDefault.Pack(builder, _o.AsIPromptStyleDefault()).Value;
			case IPromptStyleBase_Union.IPromptStylePhoto:
				return IPromptStylePhoto.Pack(builder, _o.AsIPromptStylePhoto()).Value;
			case IPromptStyleBase_Union.IPromptStyleBattle:
				return IPromptStyleBattle.Pack(builder, _o.AsIPromptStyleBattle()).Value;
			case IPromptStyleBase_Union.IPromptStyleBattle2:
				return IPromptStyleBattle2.Pack(builder, _o.AsIPromptStyleBattle2()).Value;
			default:
				return 0;
			}
		}
	}
}
