using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007077 RID: 28791
	public class ISetSpineAnimationType_UnionUnion
	{
		// Token: 0x1700D5F8 RID: 54776
		// (get) Token: 0x06032F98 RID: 208792 RVA: 0x006E03F9 File Offset: 0x006DE5F9
		// (set) Token: 0x06032F99 RID: 208793 RVA: 0x006E0401 File Offset: 0x006DE601
		public ISetSpineAnimationType_Union Type { get; set; }

		// Token: 0x1700D5F9 RID: 54777
		// (get) Token: 0x06032F9A RID: 208794 RVA: 0x006E040A File Offset: 0x006DE60A
		// (set) Token: 0x06032F9B RID: 208795 RVA: 0x006E0412 File Offset: 0x006DE612
		public object Value { get; set; }

		// Token: 0x06032F9C RID: 208796 RVA: 0x006E041B File Offset: 0x006DE61B
		public ISetSpineAnimationType_UnionUnion()
		{
			this.Type = ISetSpineAnimationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032F9D RID: 208797 RVA: 0x006E0431 File Offset: 0x006DE631
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032F9E RID: 208798 RVA: 0x006E0443 File Offset: 0x006DE643
		public ISetSpineAnimationTypeT AsISetSpineAnimationType()
		{
			return this.As<ISetSpineAnimationTypeT>();
		}

		// Token: 0x06032F9F RID: 208799 RVA: 0x006E044B File Offset: 0x006DE64B
		public static ISetSpineAnimationType_UnionUnion FromISetSpineAnimationType(ISetSpineAnimationTypeT _isetspineanimationtype)
		{
			return new ISetSpineAnimationType_UnionUnion
			{
				Type = ISetSpineAnimationType_Union.ISetSpineAnimationType,
				Value = _isetspineanimationtype
			};
		}

		// Token: 0x06032FA0 RID: 208800 RVA: 0x006E0460 File Offset: 0x006DE660
		public IPlaySpineAnimationT AsIPlaySpineAnimation()
		{
			return this.As<IPlaySpineAnimationT>();
		}

		// Token: 0x06032FA1 RID: 208801 RVA: 0x006E0468 File Offset: 0x006DE668
		public static ISetSpineAnimationType_UnionUnion FromIPlaySpineAnimation(IPlaySpineAnimationT _iplayspineanimation)
		{
			return new ISetSpineAnimationType_UnionUnion
			{
				Type = ISetSpineAnimationType_Union.IPlaySpineAnimation,
				Value = _iplayspineanimation
			};
		}

		// Token: 0x06032FA2 RID: 208802 RVA: 0x006E0480 File Offset: 0x006DE680
		public static int Pack(FlatBufferBuilder builder, ISetSpineAnimationType_UnionUnion _o)
		{
			ISetSpineAnimationType_Union type = _o.Type;
			if (type == ISetSpineAnimationType_Union.ISetSpineAnimationType)
			{
				return ISetSpineAnimationType.Pack(builder, _o.AsISetSpineAnimationType()).Value;
			}
			if (type != ISetSpineAnimationType_Union.IPlaySpineAnimation)
			{
				return 0;
			}
			return IPlaySpineAnimation.Pack(builder, _o.AsIPlaySpineAnimation()).Value;
		}
	}
}
