using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047B1 RID: 18353
	public class TAngularConstraintMotionUnion
	{
		// Token: 0x17007FD8 RID: 32728
		// (get) Token: 0x0601B05E RID: 110686 RVA: 0x003D4364 File Offset: 0x003D2564
		// (set) Token: 0x0601B05F RID: 110687 RVA: 0x003D436C File Offset: 0x003D256C
		public TAngularConstraintMotion Type { get; set; }

		// Token: 0x17007FD9 RID: 32729
		// (get) Token: 0x0601B060 RID: 110688 RVA: 0x003D4375 File Offset: 0x003D2575
		// (set) Token: 0x0601B061 RID: 110689 RVA: 0x003D437D File Offset: 0x003D257D
		public object Value { get; set; }

		// Token: 0x0601B062 RID: 110690 RVA: 0x003D4386 File Offset: 0x003D2586
		public TAngularConstraintMotionUnion()
		{
			this.Type = TAngularConstraintMotion.NONE;
			this.Value = null;
		}

		// Token: 0x0601B063 RID: 110691 RVA: 0x003D439C File Offset: 0x003D259C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B064 RID: 110692 RVA: 0x003D43AE File Offset: 0x003D25AE
		public IAcmFreeT AsIAcmFree()
		{
			return this.As<IAcmFreeT>();
		}

		// Token: 0x0601B065 RID: 110693 RVA: 0x003D43B6 File Offset: 0x003D25B6
		public static TAngularConstraintMotionUnion FromIAcmFree(IAcmFreeT _iacmfree)
		{
			return new TAngularConstraintMotionUnion
			{
				Type = TAngularConstraintMotion.IAcmFree,
				Value = _iacmfree
			};
		}

		// Token: 0x0601B066 RID: 110694 RVA: 0x003D43CB File Offset: 0x003D25CB
		public IAcmLimitedT AsIAcmLimited()
		{
			return this.As<IAcmLimitedT>();
		}

		// Token: 0x0601B067 RID: 110695 RVA: 0x003D43D3 File Offset: 0x003D25D3
		public static TAngularConstraintMotionUnion FromIAcmLimited(IAcmLimitedT _iacmlimited)
		{
			return new TAngularConstraintMotionUnion
			{
				Type = TAngularConstraintMotion.IAcmLimited,
				Value = _iacmlimited
			};
		}

		// Token: 0x0601B068 RID: 110696 RVA: 0x003D43E8 File Offset: 0x003D25E8
		public IAcmLockedT AsIAcmLocked()
		{
			return this.As<IAcmLockedT>();
		}

		// Token: 0x0601B069 RID: 110697 RVA: 0x003D43F0 File Offset: 0x003D25F0
		public static TAngularConstraintMotionUnion FromIAcmLocked(IAcmLockedT _iacmlocked)
		{
			return new TAngularConstraintMotionUnion
			{
				Type = TAngularConstraintMotion.IAcmLocked,
				Value = _iacmlocked
			};
		}

		// Token: 0x0601B06A RID: 110698 RVA: 0x003D4408 File Offset: 0x003D2608
		public static int Pack(FlatBufferBuilder builder, TAngularConstraintMotionUnion _o)
		{
			switch (_o.Type)
			{
			case TAngularConstraintMotion.IAcmFree:
				return IAcmFree.Pack(builder, _o.AsIAcmFree()).Value;
			case TAngularConstraintMotion.IAcmLimited:
				return IAcmLimited.Pack(builder, _o.AsIAcmLimited()).Value;
			case TAngularConstraintMotion.IAcmLocked:
				return IAcmLocked.Pack(builder, _o.AsIAcmLocked()).Value;
			default:
				return 0;
			}
		}
	}
}
