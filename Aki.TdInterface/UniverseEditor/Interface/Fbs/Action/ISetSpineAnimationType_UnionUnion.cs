using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007843 RID: 30787
	public class ISetSpineAnimationType_UnionUnion
	{
		// Token: 0x1700E1DB RID: 57819
		// (get) Token: 0x06036239 RID: 221753 RVA: 0x007409AD File Offset: 0x0073EBAD
		// (set) Token: 0x0603623A RID: 221754 RVA: 0x007409B5 File Offset: 0x0073EBB5
		public ISetSpineAnimationType_Union Type { get; set; }

		// Token: 0x1700E1DC RID: 57820
		// (get) Token: 0x0603623B RID: 221755 RVA: 0x007409BE File Offset: 0x0073EBBE
		// (set) Token: 0x0603623C RID: 221756 RVA: 0x007409C6 File Offset: 0x0073EBC6
		public object Value { get; set; }

		// Token: 0x0603623D RID: 221757 RVA: 0x007409CF File Offset: 0x0073EBCF
		public ISetSpineAnimationType_UnionUnion()
		{
			this.Type = ISetSpineAnimationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603623E RID: 221758 RVA: 0x007409E5 File Offset: 0x0073EBE5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603623F RID: 221759 RVA: 0x007409F7 File Offset: 0x0073EBF7
		public ISetSpineAnimationTypeT AsISetSpineAnimationType()
		{
			return this.As<ISetSpineAnimationTypeT>();
		}

		// Token: 0x06036240 RID: 221760 RVA: 0x007409FF File Offset: 0x0073EBFF
		public static ISetSpineAnimationType_UnionUnion FromISetSpineAnimationType(ISetSpineAnimationTypeT _isetspineanimationtype)
		{
			return new ISetSpineAnimationType_UnionUnion
			{
				Type = ISetSpineAnimationType_Union.ISetSpineAnimationType,
				Value = _isetspineanimationtype
			};
		}

		// Token: 0x06036241 RID: 221761 RVA: 0x00740A14 File Offset: 0x0073EC14
		public IPlaySpineAnimationT AsIPlaySpineAnimation()
		{
			return this.As<IPlaySpineAnimationT>();
		}

		// Token: 0x06036242 RID: 221762 RVA: 0x00740A1C File Offset: 0x0073EC1C
		public static ISetSpineAnimationType_UnionUnion FromIPlaySpineAnimation(IPlaySpineAnimationT _iplayspineanimation)
		{
			return new ISetSpineAnimationType_UnionUnion
			{
				Type = ISetSpineAnimationType_Union.IPlaySpineAnimation,
				Value = _iplayspineanimation
			};
		}

		// Token: 0x06036243 RID: 221763 RVA: 0x00740A34 File Offset: 0x0073EC34
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
