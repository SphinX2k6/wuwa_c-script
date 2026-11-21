using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F8F RID: 32655
	public class TPromptStyleUnion
	{
		// Token: 0x1700F2D7 RID: 62167
		// (get) Token: 0x0603AD81 RID: 241025 RVA: 0x007E87C0 File Offset: 0x007E69C0
		// (set) Token: 0x0603AD82 RID: 241026 RVA: 0x007E87C8 File Offset: 0x007E69C8
		public TPromptStyle Type { get; set; }

		// Token: 0x1700F2D8 RID: 62168
		// (get) Token: 0x0603AD83 RID: 241027 RVA: 0x007E87D1 File Offset: 0x007E69D1
		// (set) Token: 0x0603AD84 RID: 241028 RVA: 0x007E87D9 File Offset: 0x007E69D9
		public object Value { get; set; }

		// Token: 0x0603AD85 RID: 241029 RVA: 0x007E87E2 File Offset: 0x007E69E2
		public TPromptStyleUnion()
		{
			this.Type = TPromptStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD86 RID: 241030 RVA: 0x007E87F8 File Offset: 0x007E69F8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD87 RID: 241031 RVA: 0x007E880A File Offset: 0x007E6A0A
		public IPromptStyleBattleT AsIPromptStyleBattle()
		{
			return this.As<IPromptStyleBattleT>();
		}

		// Token: 0x0603AD88 RID: 241032 RVA: 0x007E8812 File Offset: 0x007E6A12
		public static TPromptStyleUnion FromIPromptStyleBattle(IPromptStyleBattleT _ipromptstylebattle)
		{
			return new TPromptStyleUnion
			{
				Type = TPromptStyle.IPromptStyleBattle,
				Value = _ipromptstylebattle
			};
		}

		// Token: 0x0603AD89 RID: 241033 RVA: 0x007E8827 File Offset: 0x007E6A27
		public IPromptStyleBattle2T AsIPromptStyleBattle2()
		{
			return this.As<IPromptStyleBattle2T>();
		}

		// Token: 0x0603AD8A RID: 241034 RVA: 0x007E882F File Offset: 0x007E6A2F
		public static TPromptStyleUnion FromIPromptStyleBattle2(IPromptStyleBattle2T _ipromptstylebattle2)
		{
			return new TPromptStyleUnion
			{
				Type = TPromptStyle.IPromptStyleBattle2,
				Value = _ipromptstylebattle2
			};
		}

		// Token: 0x0603AD8B RID: 241035 RVA: 0x007E8844 File Offset: 0x007E6A44
		public IPromptStyleDefaultT AsIPromptStyleDefault()
		{
			return this.As<IPromptStyleDefaultT>();
		}

		// Token: 0x0603AD8C RID: 241036 RVA: 0x007E884C File Offset: 0x007E6A4C
		public static TPromptStyleUnion FromIPromptStyleDefault(IPromptStyleDefaultT _ipromptstyledefault)
		{
			return new TPromptStyleUnion
			{
				Type = TPromptStyle.IPromptStyleDefault,
				Value = _ipromptstyledefault
			};
		}

		// Token: 0x0603AD8D RID: 241037 RVA: 0x007E8861 File Offset: 0x007E6A61
		public IPromptStylePhotoT AsIPromptStylePhoto()
		{
			return this.As<IPromptStylePhotoT>();
		}

		// Token: 0x0603AD8E RID: 241038 RVA: 0x007E8869 File Offset: 0x007E6A69
		public static TPromptStyleUnion FromIPromptStylePhoto(IPromptStylePhotoT _ipromptstylephoto)
		{
			return new TPromptStyleUnion
			{
				Type = TPromptStyle.IPromptStylePhoto,
				Value = _ipromptstylephoto
			};
		}

		// Token: 0x0603AD8F RID: 241039 RVA: 0x007E8880 File Offset: 0x007E6A80
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
