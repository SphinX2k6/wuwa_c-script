using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007763 RID: 30563
	public class TPromptStyleUnion
	{
		// Token: 0x1700E685 RID: 59013
		// (get) Token: 0x06037838 RID: 227384 RVA: 0x007836F0 File Offset: 0x007818F0
		// (set) Token: 0x06037839 RID: 227385 RVA: 0x007836F8 File Offset: 0x007818F8
		public TPromptStyle Type { get; set; }

		// Token: 0x1700E686 RID: 59014
		// (get) Token: 0x0603783A RID: 227386 RVA: 0x00783701 File Offset: 0x00781901
		// (set) Token: 0x0603783B RID: 227387 RVA: 0x00783709 File Offset: 0x00781909
		public object Value { get; set; }

		// Token: 0x0603783C RID: 227388 RVA: 0x00783712 File Offset: 0x00781912
		public TPromptStyleUnion()
		{
			this.Type = TPromptStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0603783D RID: 227389 RVA: 0x00783728 File Offset: 0x00781928
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603783E RID: 227390 RVA: 0x0078373A File Offset: 0x0078193A
		public IPromptStyleBattleT AsIPromptStyleBattle()
		{
			return this.As<IPromptStyleBattleT>();
		}

		// Token: 0x0603783F RID: 227391 RVA: 0x00783742 File Offset: 0x00781942
		public static TPromptStyleUnion FromIPromptStyleBattle(IPromptStyleBattleT _ipromptstylebattle)
		{
			return new TPromptStyleUnion
			{
				Type = TPromptStyle.IPromptStyleBattle,
				Value = _ipromptstylebattle
			};
		}

		// Token: 0x06037840 RID: 227392 RVA: 0x00783757 File Offset: 0x00781957
		public IPromptStyleBattle2T AsIPromptStyleBattle2()
		{
			return this.As<IPromptStyleBattle2T>();
		}

		// Token: 0x06037841 RID: 227393 RVA: 0x0078375F File Offset: 0x0078195F
		public static TPromptStyleUnion FromIPromptStyleBattle2(IPromptStyleBattle2T _ipromptstylebattle2)
		{
			return new TPromptStyleUnion
			{
				Type = TPromptStyle.IPromptStyleBattle2,
				Value = _ipromptstylebattle2
			};
		}

		// Token: 0x06037842 RID: 227394 RVA: 0x00783774 File Offset: 0x00781974
		public IPromptStyleDefaultT AsIPromptStyleDefault()
		{
			return this.As<IPromptStyleDefaultT>();
		}

		// Token: 0x06037843 RID: 227395 RVA: 0x0078377C File Offset: 0x0078197C
		public static TPromptStyleUnion FromIPromptStyleDefault(IPromptStyleDefaultT _ipromptstyledefault)
		{
			return new TPromptStyleUnion
			{
				Type = TPromptStyle.IPromptStyleDefault,
				Value = _ipromptstyledefault
			};
		}

		// Token: 0x06037844 RID: 227396 RVA: 0x00783791 File Offset: 0x00781991
		public IPromptStylePhotoT AsIPromptStylePhoto()
		{
			return this.As<IPromptStylePhotoT>();
		}

		// Token: 0x06037845 RID: 227397 RVA: 0x00783799 File Offset: 0x00781999
		public static TPromptStyleUnion FromIPromptStylePhoto(IPromptStylePhotoT _ipromptstylephoto)
		{
			return new TPromptStyleUnion
			{
				Type = TPromptStyle.IPromptStylePhoto,
				Value = _ipromptstylephoto
			};
		}

		// Token: 0x06037846 RID: 227398 RVA: 0x007837B0 File Offset: 0x007819B0
		public static int Pack(FlatBufferBuilder builder, TPromptStyleUnion _o)
		{
			switch (_o.Type)
			{
			case TPromptStyle.IPromptStyleBattle:
				return IPromptStyleBattle.Pack(builder, _o.AsIPromptStyleBattle()).Value;
			case TPromptStyle.IPromptStyleBattle2:
				return IPromptStyleBattle2.Pack(builder, _o.AsIPromptStyleBattle2()).Value;
			case TPromptStyle.IPromptStyleDefault:
				return IPromptStyleDefault.Pack(builder, _o.AsIPromptStyleDefault()).Value;
			case TPromptStyle.IPromptStylePhoto:
				return IPromptStylePhoto.Pack(builder, _o.AsIPromptStylePhoto()).Value;
			default:
				return 0;
			}
		}
	}
}
