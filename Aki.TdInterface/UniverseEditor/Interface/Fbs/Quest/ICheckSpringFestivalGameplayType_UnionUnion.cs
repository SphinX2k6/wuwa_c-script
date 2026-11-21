using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004182 RID: 16770
	public class ICheckSpringFestivalGameplayType_UnionUnion
	{
		// Token: 0x1700719E RID: 29086
		// (get) Token: 0x0601714F RID: 94543 RVA: 0x0034A555 File Offset: 0x00348755
		// (set) Token: 0x06017150 RID: 94544 RVA: 0x0034A55D File Offset: 0x0034875D
		public ICheckSpringFestivalGameplayType_Union Type { get; set; }

		// Token: 0x1700719F RID: 29087
		// (get) Token: 0x06017151 RID: 94545 RVA: 0x0034A566 File Offset: 0x00348766
		// (set) Token: 0x06017152 RID: 94546 RVA: 0x0034A56E File Offset: 0x0034876E
		public object Value { get; set; }

		// Token: 0x06017153 RID: 94547 RVA: 0x0034A577 File Offset: 0x00348777
		public ICheckSpringFestivalGameplayType_UnionUnion()
		{
			this.Type = ICheckSpringFestivalGameplayType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017154 RID: 94548 RVA: 0x0034A58D File Offset: 0x0034878D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017155 RID: 94549 RVA: 0x0034A59F File Offset: 0x0034879F
		public ICheckSpringFestivalGameplayTypeT AsICheckSpringFestivalGameplayType()
		{
			return this.As<ICheckSpringFestivalGameplayTypeT>();
		}

		// Token: 0x06017156 RID: 94550 RVA: 0x0034A5A7 File Offset: 0x003487A7
		public static ICheckSpringFestivalGameplayType_UnionUnion FromICheckSpringFestivalGameplayType(ICheckSpringFestivalGameplayTypeT _icheckspringfestivalgameplaytype)
		{
			return new ICheckSpringFestivalGameplayType_UnionUnion
			{
				Type = ICheckSpringFestivalGameplayType_Union.ICheckSpringFestivalGameplayType,
				Value = _icheckspringfestivalgameplaytype
			};
		}

		// Token: 0x06017157 RID: 94551 RVA: 0x0034A5BC File Offset: 0x003487BC
		public ICheckSpringFestivalMixDrinksCompletedT AsICheckSpringFestivalMixDrinksCompleted()
		{
			return this.As<ICheckSpringFestivalMixDrinksCompletedT>();
		}

		// Token: 0x06017158 RID: 94552 RVA: 0x0034A5C4 File Offset: 0x003487C4
		public static ICheckSpringFestivalGameplayType_UnionUnion FromICheckSpringFestivalMixDrinksCompleted(ICheckSpringFestivalMixDrinksCompletedT _icheckspringfestivalmixdrinkscompleted)
		{
			return new ICheckSpringFestivalGameplayType_UnionUnion
			{
				Type = ICheckSpringFestivalGameplayType_Union.ICheckSpringFestivalMixDrinksCompleted,
				Value = _icheckspringfestivalmixdrinkscompleted
			};
		}

		// Token: 0x06017159 RID: 94553 RVA: 0x0034A5D9 File Offset: 0x003487D9
		public ICheckSpringFestivalGuessJokerCompletedT AsICheckSpringFestivalGuessJokerCompleted()
		{
			return this.As<ICheckSpringFestivalGuessJokerCompletedT>();
		}

		// Token: 0x0601715A RID: 94554 RVA: 0x0034A5E1 File Offset: 0x003487E1
		public static ICheckSpringFestivalGameplayType_UnionUnion FromICheckSpringFestivalGuessJokerCompleted(ICheckSpringFestivalGuessJokerCompletedT _icheckspringfestivalguessjokercompleted)
		{
			return new ICheckSpringFestivalGameplayType_UnionUnion
			{
				Type = ICheckSpringFestivalGameplayType_Union.ICheckSpringFestivalGuessJokerCompleted,
				Value = _icheckspringfestivalguessjokercompleted
			};
		}

		// Token: 0x0601715B RID: 94555 RVA: 0x0034A5F8 File Offset: 0x003487F8
		public static int Pack(FlatBufferBuilder builder, ICheckSpringFestivalGameplayType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckSpringFestivalGameplayType_Union.ICheckSpringFestivalGameplayType:
				return ICheckSpringFestivalGameplayType.Pack(builder, _o.AsICheckSpringFestivalGameplayType()).Value;
			case ICheckSpringFestivalGameplayType_Union.ICheckSpringFestivalMixDrinksCompleted:
				return ICheckSpringFestivalMixDrinksCompleted.Pack(builder, _o.AsICheckSpringFestivalMixDrinksCompleted()).Value;
			case ICheckSpringFestivalGameplayType_Union.ICheckSpringFestivalGuessJokerCompleted:
				return ICheckSpringFestivalGuessJokerCompleted.Pack(builder, _o.AsICheckSpringFestivalGuessJokerCompleted()).Value;
			default:
				return 0;
			}
		}
	}
}
