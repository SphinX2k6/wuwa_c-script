using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CE9 RID: 19689
	public class ITargetBuffContainer_UnionUnion
	{
		// Token: 0x17008EE2 RID: 36578
		// (get) Token: 0x0601F3F4 RID: 127988 RVA: 0x0045C615 File Offset: 0x0045A815
		// (set) Token: 0x0601F3F5 RID: 127989 RVA: 0x0045C61D File Offset: 0x0045A81D
		public ITargetBuffContainer_Union Type { get; set; }

		// Token: 0x17008EE3 RID: 36579
		// (get) Token: 0x0601F3F6 RID: 127990 RVA: 0x0045C626 File Offset: 0x0045A826
		// (set) Token: 0x0601F3F7 RID: 127991 RVA: 0x0045C62E File Offset: 0x0045A82E
		public object Value { get; set; }

		// Token: 0x0601F3F8 RID: 127992 RVA: 0x0045C637 File Offset: 0x0045A837
		public ITargetBuffContainer_UnionUnion()
		{
			this.Type = ITargetBuffContainer_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F3F9 RID: 127993 RVA: 0x0045C64D File Offset: 0x0045A84D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F3FA RID: 127994 RVA: 0x0045C65F File Offset: 0x0045A85F
		public ITargetBuffContainerT AsITargetBuffContainer()
		{
			return this.As<ITargetBuffContainerT>();
		}

		// Token: 0x0601F3FB RID: 127995 RVA: 0x0045C667 File Offset: 0x0045A867
		public static ITargetBuffContainer_UnionUnion FromITargetBuffContainer(ITargetBuffContainerT _itargetbuffcontainer)
		{
			return new ITargetBuffContainer_UnionUnion
			{
				Type = ITargetBuffContainer_Union.ITargetBuffContainer,
				Value = _itargetbuffcontainer
			};
		}

		// Token: 0x0601F3FC RID: 127996 RVA: 0x0045C67C File Offset: 0x0045A87C
		public IMonsterBuffContainerT AsIMonsterBuffContainer()
		{
			return this.As<IMonsterBuffContainerT>();
		}

		// Token: 0x0601F3FD RID: 127997 RVA: 0x0045C684 File Offset: 0x0045A884
		public static ITargetBuffContainer_UnionUnion FromIMonsterBuffContainer(IMonsterBuffContainerT _imonsterbuffcontainer)
		{
			return new ITargetBuffContainer_UnionUnion
			{
				Type = ITargetBuffContainer_Union.IMonsterBuffContainer,
				Value = _imonsterbuffcontainer
			};
		}

		// Token: 0x0601F3FE RID: 127998 RVA: 0x0045C69C File Offset: 0x0045A89C
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
