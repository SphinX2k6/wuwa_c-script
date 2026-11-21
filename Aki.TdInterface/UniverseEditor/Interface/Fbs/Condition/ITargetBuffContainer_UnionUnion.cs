using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051E5 RID: 20965
	public class ITargetBuffContainer_UnionUnion
	{
		// Token: 0x1700961B RID: 38427
		// (get) Token: 0x06021039 RID: 135225 RVA: 0x00490565 File Offset: 0x0048E765
		// (set) Token: 0x0602103A RID: 135226 RVA: 0x0049056D File Offset: 0x0048E76D
		public ITargetBuffContainer_Union Type { get; set; }

		// Token: 0x1700961C RID: 38428
		// (get) Token: 0x0602103B RID: 135227 RVA: 0x00490576 File Offset: 0x0048E776
		// (set) Token: 0x0602103C RID: 135228 RVA: 0x0049057E File Offset: 0x0048E77E
		public object Value { get; set; }

		// Token: 0x0602103D RID: 135229 RVA: 0x00490587 File Offset: 0x0048E787
		public ITargetBuffContainer_UnionUnion()
		{
			this.Type = ITargetBuffContainer_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602103E RID: 135230 RVA: 0x0049059D File Offset: 0x0048E79D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602103F RID: 135231 RVA: 0x004905AF File Offset: 0x0048E7AF
		public ITargetBuffContainerT AsITargetBuffContainer()
		{
			return this.As<ITargetBuffContainerT>();
		}

		// Token: 0x06021040 RID: 135232 RVA: 0x004905B7 File Offset: 0x0048E7B7
		public static ITargetBuffContainer_UnionUnion FromITargetBuffContainer(ITargetBuffContainerT _itargetbuffcontainer)
		{
			return new ITargetBuffContainer_UnionUnion
			{
				Type = ITargetBuffContainer_Union.ITargetBuffContainer,
				Value = _itargetbuffcontainer
			};
		}

		// Token: 0x06021041 RID: 135233 RVA: 0x004905CC File Offset: 0x0048E7CC
		public IMonsterBuffContainerT AsIMonsterBuffContainer()
		{
			return this.As<IMonsterBuffContainerT>();
		}

		// Token: 0x06021042 RID: 135234 RVA: 0x004905D4 File Offset: 0x0048E7D4
		public static ITargetBuffContainer_UnionUnion FromIMonsterBuffContainer(IMonsterBuffContainerT _imonsterbuffcontainer)
		{
			return new ITargetBuffContainer_UnionUnion
			{
				Type = ITargetBuffContainer_Union.IMonsterBuffContainer,
				Value = _imonsterbuffcontainer
			};
		}

		// Token: 0x06021043 RID: 135235 RVA: 0x004905EC File Offset: 0x0048E7EC
		public static int Pack(FlatBufferBuilder builder, ITargetBuffContainer_UnionUnion _o)
		{
			ITargetBuffContainer_Union type = _o.Type;
			if (type == ITargetBuffContainer_Union.ITargetBuffContainer)
			{
				return ITargetBuffContainer.Pack(builder, _o.AsITargetBuffContainer()).Value;
			}
			if (type != ITargetBuffContainer_Union.IMonsterBuffContainer)
			{
				return 0;
			}
			return IMonsterBuffContainer.Pack(builder, _o.AsIMonsterBuffContainer()).Value;
		}
	}
}
