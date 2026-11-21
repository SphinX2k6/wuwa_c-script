using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200795D RID: 31069
	public class ISplineMoveMontageType_UnionUnion
	{
		// Token: 0x1700E3D4 RID: 58324
		// (get) Token: 0x06036B60 RID: 224096 RVA: 0x00751E61 File Offset: 0x00750061
		// (set) Token: 0x06036B61 RID: 224097 RVA: 0x00751E69 File Offset: 0x00750069
		public ISplineMoveMontageType_Union Type { get; set; }

		// Token: 0x1700E3D5 RID: 58325
		// (get) Token: 0x06036B62 RID: 224098 RVA: 0x00751E72 File Offset: 0x00750072
		// (set) Token: 0x06036B63 RID: 224099 RVA: 0x00751E7A File Offset: 0x0075007A
		public object Value { get; set; }

		// Token: 0x06036B64 RID: 224100 RVA: 0x00751E83 File Offset: 0x00750083
		public ISplineMoveMontageType_UnionUnion()
		{
			this.Type = ISplineMoveMontageType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036B65 RID: 224101 RVA: 0x00751E99 File Offset: 0x00750099
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036B66 RID: 224102 RVA: 0x00751EAB File Offset: 0x007500AB
		public ISplineMoveMontageTypeT AsISplineMoveMontageType()
		{
			return this.As<ISplineMoveMontageTypeT>();
		}

		// Token: 0x06036B67 RID: 224103 RVA: 0x00751EB3 File Offset: 0x007500B3
		public static ISplineMoveMontageType_UnionUnion FromISplineMoveMontageType(ISplineMoveMontageTypeT _isplinemovemontagetype)
		{
			return new ISplineMoveMontageType_UnionUnion
			{
				Type = ISplineMoveMontageType_Union.ISplineMoveMontageType,
				Value = _isplinemovemontagetype
			};
		}

		// Token: 0x06036B68 RID: 224104 RVA: 0x00751EC8 File Offset: 0x007500C8
		public IThreeStageSplineMoveMontageT AsIThreeStageSplineMoveMontage()
		{
			return this.As<IThreeStageSplineMoveMontageT>();
		}

		// Token: 0x06036B69 RID: 224105 RVA: 0x00751ED0 File Offset: 0x007500D0
		public static ISplineMoveMontageType_UnionUnion FromIThreeStageSplineMoveMontage(IThreeStageSplineMoveMontageT _ithreestagesplinemovemontage)
		{
			return new ISplineMoveMontageType_UnionUnion
			{
				Type = ISplineMoveMontageType_Union.IThreeStageSplineMoveMontage,
				Value = _ithreestagesplinemovemontage
			};
		}

		// Token: 0x06036B6A RID: 224106 RVA: 0x00751EE8 File Offset: 0x007500E8
		public static int Pack(FlatBufferBuilder builder, ISplineMoveMontageType_UnionUnion _o)
		{
			ISplineMoveMontageType_Union type = _o.Type;
			if (type == ISplineMoveMontageType_Union.ISplineMoveMontageType)
			{
				return ISplineMoveMontageType.Pack(builder, _o.AsISplineMoveMontageType()).Value;
			}
			if (type != ISplineMoveMontageType_Union.IThreeStageSplineMoveMontage)
			{
				return 0;
			}
			return IThreeStageSplineMoveMontage.Pack(builder, _o.AsIThreeStageSplineMoveMontage()).Value;
		}
	}
}
