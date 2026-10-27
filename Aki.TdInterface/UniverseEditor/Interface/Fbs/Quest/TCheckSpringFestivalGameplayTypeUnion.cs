using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BB RID: 17083
	public class TCheckSpringFestivalGameplayTypeUnion
	{
		// Token: 0x17007931 RID: 31025
		// (get) Token: 0x060194FD RID: 103677 RVA: 0x003A21D4 File Offset: 0x003A03D4
		// (set) Token: 0x060194FE RID: 103678 RVA: 0x003A21DC File Offset: 0x003A03DC
		public TCheckSpringFestivalGameplayType Type { get; set; }

		// Token: 0x17007932 RID: 31026
		// (get) Token: 0x060194FF RID: 103679 RVA: 0x003A21E5 File Offset: 0x003A03E5
		// (set) Token: 0x06019500 RID: 103680 RVA: 0x003A21ED File Offset: 0x003A03ED
		public object Value { get; set; }

		// Token: 0x06019501 RID: 103681 RVA: 0x003A21F6 File Offset: 0x003A03F6
		public TCheckSpringFestivalGameplayTypeUnion()
		{
			this.Type = TCheckSpringFestivalGameplayType.NONE;
			this.Value = null;
		}

		// Token: 0x06019502 RID: 103682 RVA: 0x003A220C File Offset: 0x003A040C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019503 RID: 103683 RVA: 0x003A221E File Offset: 0x003A041E
		public ICheckSpringFestivalGuessJokerCompletedT AsICheckSpringFestivalGuessJokerCompleted()
		{
			return this.As<ICheckSpringFestivalGuessJokerCompletedT>();
		}

		// Token: 0x06019504 RID: 103684 RVA: 0x003A2226 File Offset: 0x003A0426
		public static TCheckSpringFestivalGameplayTypeUnion FromICheckSpringFestivalGuessJokerCompleted(ICheckSpringFestivalGuessJokerCompletedT _icheckspringfestivalguessjokercompleted)
		{
			return new TCheckSpringFestivalGameplayTypeUnion
			{
				Type = TCheckSpringFestivalGameplayType.ICheckSpringFestivalGuessJokerCompleted,
				Value = _icheckspringfestivalguessjokercompleted
			};
		}

		// Token: 0x06019505 RID: 103685 RVA: 0x003A223B File Offset: 0x003A043B
		public ICheckSpringFestivalMixDrinksCompletedT AsICheckSpringFestivalMixDrinksCompleted()
		{
			return this.As<ICheckSpringFestivalMixDrinksCompletedT>();
		}

		// Token: 0x06019506 RID: 103686 RVA: 0x003A2243 File Offset: 0x003A0443
		public static TCheckSpringFestivalGameplayTypeUnion FromICheckSpringFestivalMixDrinksCompleted(ICheckSpringFestivalMixDrinksCompletedT _icheckspringfestivalmixdrinkscompleted)
		{
			return new TCheckSpringFestivalGameplayTypeUnion
			{
				Type = TCheckSpringFestivalGameplayType.ICheckSpringFestivalMixDrinksCompleted,
				Value = _icheckspringfestivalmixdrinkscompleted
			};
		}

		// Token: 0x06019507 RID: 103687 RVA: 0x003A2258 File Offset: 0x003A0458
		public static int Pack(FlatBufferBuilder builder, TCheckSpringFestivalGameplayTypeUnion _o)
		{
			TCheckSpringFestivalGameplayType type = _o.Type;
			if (type == TCheckSpringFestivalGameplayType.ICheckSpringFestivalGuessJokerCompleted)
			{
				return ICheckSpringFestivalGuessJokerCompleted.Pack(builder, _o.AsICheckSpringFestivalGuessJokerCompleted()).Value;
			}
			if (type != TCheckSpringFestivalGameplayType.ICheckSpringFestivalMixDrinksCompleted)
			{
				return 0;
			}
			return ICheckSpringFestivalMixDrinksCompleted.Pack(builder, _o.AsICheckSpringFestivalMixDrinksCompleted()).Value;
		}
	}
}
