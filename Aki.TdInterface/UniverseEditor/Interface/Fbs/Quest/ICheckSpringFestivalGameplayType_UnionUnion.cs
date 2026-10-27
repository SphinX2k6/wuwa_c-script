using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D6B RID: 15723
	public class ICheckSpringFestivalGameplayType_UnionUnion
	{
		// Token: 0x17006BE4 RID: 27620
		// (get) Token: 0x06015C17 RID: 89111 RVA: 0x003232DD File Offset: 0x003214DD
		// (set) Token: 0x06015C18 RID: 89112 RVA: 0x003232E5 File Offset: 0x003214E5
		public ICheckSpringFestivalGameplayType_Union Type { get; set; }

		// Token: 0x17006BE5 RID: 27621
		// (get) Token: 0x06015C19 RID: 89113 RVA: 0x003232EE File Offset: 0x003214EE
		// (set) Token: 0x06015C1A RID: 89114 RVA: 0x003232F6 File Offset: 0x003214F6
		public object Value { get; set; }

		// Token: 0x06015C1B RID: 89115 RVA: 0x003232FF File Offset: 0x003214FF
		public ICheckSpringFestivalGameplayType_UnionUnion()
		{
			this.Type = ICheckSpringFestivalGameplayType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015C1C RID: 89116 RVA: 0x00323315 File Offset: 0x00321515
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015C1D RID: 89117 RVA: 0x00323327 File Offset: 0x00321527
		public ICheckSpringFestivalGameplayTypeT AsICheckSpringFestivalGameplayType()
		{
			return this.As<ICheckSpringFestivalGameplayTypeT>();
		}

		// Token: 0x06015C1E RID: 89118 RVA: 0x0032332F File Offset: 0x0032152F
		public static ICheckSpringFestivalGameplayType_UnionUnion FromICheckSpringFestivalGameplayType(ICheckSpringFestivalGameplayTypeT _icheckspringfestivalgameplaytype)
		{
			return new ICheckSpringFestivalGameplayType_UnionUnion
			{
				Type = ICheckSpringFestivalGameplayType_Union.ICheckSpringFestivalGameplayType,
				Value = _icheckspringfestivalgameplaytype
			};
		}

		// Token: 0x06015C1F RID: 89119 RVA: 0x00323344 File Offset: 0x00321544
		public ICheckSpringFestivalMixDrinksCompletedT AsICheckSpringFestivalMixDrinksCompleted()
		{
			return this.As<ICheckSpringFestivalMixDrinksCompletedT>();
		}

		// Token: 0x06015C20 RID: 89120 RVA: 0x0032334C File Offset: 0x0032154C
		public static ICheckSpringFestivalGameplayType_UnionUnion FromICheckSpringFestivalMixDrinksCompleted(ICheckSpringFestivalMixDrinksCompletedT _icheckspringfestivalmixdrinkscompleted)
		{
			return new ICheckSpringFestivalGameplayType_UnionUnion
			{
				Type = ICheckSpringFestivalGameplayType_Union.ICheckSpringFestivalMixDrinksCompleted,
				Value = _icheckspringfestivalmixdrinkscompleted
			};
		}

		// Token: 0x06015C21 RID: 89121 RVA: 0x00323361 File Offset: 0x00321561
		public ICheckSpringFestivalGuessJokerCompletedT AsICheckSpringFestivalGuessJokerCompleted()
		{
			return this.As<ICheckSpringFestivalGuessJokerCompletedT>();
		}

		// Token: 0x06015C22 RID: 89122 RVA: 0x00323369 File Offset: 0x00321569
		public static ICheckSpringFestivalGameplayType_UnionUnion FromICheckSpringFestivalGuessJokerCompleted(ICheckSpringFestivalGuessJokerCompletedT _icheckspringfestivalguessjokercompleted)
		{
			return new ICheckSpringFestivalGameplayType_UnionUnion
			{
				Type = ICheckSpringFestivalGameplayType_Union.ICheckSpringFestivalGuessJokerCompleted,
				Value = _icheckspringfestivalguessjokercompleted
			};
		}

		// Token: 0x06015C23 RID: 89123 RVA: 0x00323380 File Offset: 0x00321580
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
