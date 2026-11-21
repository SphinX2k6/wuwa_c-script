using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004717 RID: 18199
	public class TCheckSpringFestivalGameplayTypeUnion
	{
		// Token: 0x17007F62 RID: 32610
		// (get) Token: 0x0601AC69 RID: 109673 RVA: 0x003CD8AC File Offset: 0x003CBAAC
		// (set) Token: 0x0601AC6A RID: 109674 RVA: 0x003CD8B4 File Offset: 0x003CBAB4
		public TCheckSpringFestivalGameplayType Type { get; set; }

		// Token: 0x17007F63 RID: 32611
		// (get) Token: 0x0601AC6B RID: 109675 RVA: 0x003CD8BD File Offset: 0x003CBABD
		// (set) Token: 0x0601AC6C RID: 109676 RVA: 0x003CD8C5 File Offset: 0x003CBAC5
		public object Value { get; set; }

		// Token: 0x0601AC6D RID: 109677 RVA: 0x003CD8CE File Offset: 0x003CBACE
		public TCheckSpringFestivalGameplayTypeUnion()
		{
			this.Type = TCheckSpringFestivalGameplayType.NONE;
			this.Value = null;
		}

		// Token: 0x0601AC6E RID: 109678 RVA: 0x003CD8E4 File Offset: 0x003CBAE4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AC6F RID: 109679 RVA: 0x003CD8F6 File Offset: 0x003CBAF6
		public ICheckSpringFestivalGuessJokerCompletedT AsICheckSpringFestivalGuessJokerCompleted()
		{
			return this.As<ICheckSpringFestivalGuessJokerCompletedT>();
		}

		// Token: 0x0601AC70 RID: 109680 RVA: 0x003CD8FE File Offset: 0x003CBAFE
		public static TCheckSpringFestivalGameplayTypeUnion FromICheckSpringFestivalGuessJokerCompleted(ICheckSpringFestivalGuessJokerCompletedT _icheckspringfestivalguessjokercompleted)
		{
			return new TCheckSpringFestivalGameplayTypeUnion
			{
				Type = TCheckSpringFestivalGameplayType.ICheckSpringFestivalGuessJokerCompleted,
				Value = _icheckspringfestivalguessjokercompleted
			};
		}

		// Token: 0x0601AC71 RID: 109681 RVA: 0x003CD913 File Offset: 0x003CBB13
		public ICheckSpringFestivalMixDrinksCompletedT AsICheckSpringFestivalMixDrinksCompleted()
		{
			return this.As<ICheckSpringFestivalMixDrinksCompletedT>();
		}

		// Token: 0x0601AC72 RID: 109682 RVA: 0x003CD91B File Offset: 0x003CBB1B
		public static TCheckSpringFestivalGameplayTypeUnion FromICheckSpringFestivalMixDrinksCompleted(ICheckSpringFestivalMixDrinksCompletedT _icheckspringfestivalmixdrinkscompleted)
		{
			return new TCheckSpringFestivalGameplayTypeUnion
			{
				Type = TCheckSpringFestivalGameplayType.ICheckSpringFestivalMixDrinksCompleted,
				Value = _icheckspringfestivalmixdrinkscompleted
			};
		}

		// Token: 0x0601AC73 RID: 109683 RVA: 0x003CD930 File Offset: 0x003CBB30
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
