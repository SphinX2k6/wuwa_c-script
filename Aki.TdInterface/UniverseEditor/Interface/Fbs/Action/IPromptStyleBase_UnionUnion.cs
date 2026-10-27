using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC9 RID: 28105
	public class IPromptStyleBase_UnionUnion
	{
		// Token: 0x1700D18F RID: 53647
		// (get) Token: 0x06031A4B RID: 203339 RVA: 0x006B9B51 File Offset: 0x006B7D51
		// (set) Token: 0x06031A4C RID: 203340 RVA: 0x006B9B59 File Offset: 0x006B7D59
		public IPromptStyleBase_Union Type { get; set; }

		// Token: 0x1700D190 RID: 53648
		// (get) Token: 0x06031A4D RID: 203341 RVA: 0x006B9B62 File Offset: 0x006B7D62
		// (set) Token: 0x06031A4E RID: 203342 RVA: 0x006B9B6A File Offset: 0x006B7D6A
		public object Value { get; set; }

		// Token: 0x06031A4F RID: 203343 RVA: 0x006B9B73 File Offset: 0x006B7D73
		public IPromptStyleBase_UnionUnion()
		{
			this.Type = IPromptStyleBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031A50 RID: 203344 RVA: 0x006B9B89 File Offset: 0x006B7D89
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031A51 RID: 203345 RVA: 0x006B9B9B File Offset: 0x006B7D9B
		public IPromptStyleBaseT AsIPromptStyleBase()
		{
			return this.As<IPromptStyleBaseT>();
		}

		// Token: 0x06031A52 RID: 203346 RVA: 0x006B9BA3 File Offset: 0x006B7DA3
		public static IPromptStyleBase_UnionUnion FromIPromptStyleBase(IPromptStyleBaseT _ipromptstylebase)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStyleBase,
				Value = _ipromptstylebase
			};
		}

		// Token: 0x06031A53 RID: 203347 RVA: 0x006B9BB8 File Offset: 0x006B7DB8
		public IPromptStyleDefaultT AsIPromptStyleDefault()
		{
			return this.As<IPromptStyleDefaultT>();
		}

		// Token: 0x06031A54 RID: 203348 RVA: 0x006B9BC0 File Offset: 0x006B7DC0
		public static IPromptStyleBase_UnionUnion FromIPromptStyleDefault(IPromptStyleDefaultT _ipromptstyledefault)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStyleDefault,
				Value = _ipromptstyledefault
			};
		}

		// Token: 0x06031A55 RID: 203349 RVA: 0x006B9BD5 File Offset: 0x006B7DD5
		public IPromptStylePhotoT AsIPromptStylePhoto()
		{
			return this.As<IPromptStylePhotoT>();
		}

		// Token: 0x06031A56 RID: 203350 RVA: 0x006B9BDD File Offset: 0x006B7DDD
		public static IPromptStyleBase_UnionUnion FromIPromptStylePhoto(IPromptStylePhotoT _ipromptstylephoto)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStylePhoto,
				Value = _ipromptstylephoto
			};
		}

		// Token: 0x06031A57 RID: 203351 RVA: 0x006B9BF2 File Offset: 0x006B7DF2
		public IPromptStyleBattleT AsIPromptStyleBattle()
		{
			return this.As<IPromptStyleBattleT>();
		}

		// Token: 0x06031A58 RID: 203352 RVA: 0x006B9BFA File Offset: 0x006B7DFA
		public static IPromptStyleBase_UnionUnion FromIPromptStyleBattle(IPromptStyleBattleT _ipromptstylebattle)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStyleBattle,
				Value = _ipromptstylebattle
			};
		}

		// Token: 0x06031A59 RID: 203353 RVA: 0x006B9C0F File Offset: 0x006B7E0F
		public IPromptStyleBattle2T AsIPromptStyleBattle2()
		{
			return this.As<IPromptStyleBattle2T>();
		}

		// Token: 0x06031A5A RID: 203354 RVA: 0x006B9C17 File Offset: 0x006B7E17
		public static IPromptStyleBase_UnionUnion FromIPromptStyleBattle2(IPromptStyleBattle2T _ipromptstylebattle2)
		{
			return new IPromptStyleBase_UnionUnion
			{
				Type = IPromptStyleBase_Union.IPromptStyleBattle2,
				Value = _ipromptstylebattle2
			};
		}

		// Token: 0x06031A5B RID: 203355 RVA: 0x006B9C2C File Offset: 0x006B7E2C
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
