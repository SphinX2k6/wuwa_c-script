using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047AB RID: 18347
	public class IAngularConstraintMotion_UnionUnion
	{
		// Token: 0x17007FCD RID: 32717
		// (get) Token: 0x0601B021 RID: 110625 RVA: 0x003D3891 File Offset: 0x003D1A91
		// (set) Token: 0x0601B022 RID: 110626 RVA: 0x003D3899 File Offset: 0x003D1A99
		public IAngularConstraintMotion_Union Type { get; set; }

		// Token: 0x17007FCE RID: 32718
		// (get) Token: 0x0601B023 RID: 110627 RVA: 0x003D38A2 File Offset: 0x003D1AA2
		// (set) Token: 0x0601B024 RID: 110628 RVA: 0x003D38AA File Offset: 0x003D1AAA
		public object Value { get; set; }

		// Token: 0x0601B025 RID: 110629 RVA: 0x003D38B3 File Offset: 0x003D1AB3
		public IAngularConstraintMotion_UnionUnion()
		{
			this.Type = IAngularConstraintMotion_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B026 RID: 110630 RVA: 0x003D38C9 File Offset: 0x003D1AC9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B027 RID: 110631 RVA: 0x003D38DB File Offset: 0x003D1ADB
		public IAngularConstraintMotionT AsIAngularConstraintMotion()
		{
			return this.As<IAngularConstraintMotionT>();
		}

		// Token: 0x0601B028 RID: 110632 RVA: 0x003D38E3 File Offset: 0x003D1AE3
		public static IAngularConstraintMotion_UnionUnion FromIAngularConstraintMotion(IAngularConstraintMotionT _iangularconstraintmotion)
		{
			return new IAngularConstraintMotion_UnionUnion
			{
				Type = IAngularConstraintMotion_Union.IAngularConstraintMotion,
				Value = _iangularconstraintmotion
			};
		}

		// Token: 0x0601B029 RID: 110633 RVA: 0x003D38F8 File Offset: 0x003D1AF8
		public IAcmFreeT AsIAcmFree()
		{
			return this.As<IAcmFreeT>();
		}

		// Token: 0x0601B02A RID: 110634 RVA: 0x003D3900 File Offset: 0x003D1B00
		public static IAngularConstraintMotion_UnionUnion FromIAcmFree(IAcmFreeT _iacmfree)
		{
			return new IAngularConstraintMotion_UnionUnion
			{
				Type = IAngularConstraintMotion_Union.IAcmFree,
				Value = _iacmfree
			};
		}

		// Token: 0x0601B02B RID: 110635 RVA: 0x003D3915 File Offset: 0x003D1B15
		public IAcmLimitedT AsIAcmLimited()
		{
			return this.As<IAcmLimitedT>();
		}

		// Token: 0x0601B02C RID: 110636 RVA: 0x003D391D File Offset: 0x003D1B1D
		public static IAngularConstraintMotion_UnionUnion FromIAcmLimited(IAcmLimitedT _iacmlimited)
		{
			return new IAngularConstraintMotion_UnionUnion
			{
				Type = IAngularConstraintMotion_Union.IAcmLimited,
				Value = _iacmlimited
			};
		}

		// Token: 0x0601B02D RID: 110637 RVA: 0x003D3932 File Offset: 0x003D1B32
		public IAcmLockedT AsIAcmLocked()
		{
			return this.As<IAcmLockedT>();
		}

		// Token: 0x0601B02E RID: 110638 RVA: 0x003D393A File Offset: 0x003D1B3A
		public static IAngularConstraintMotion_UnionUnion FromIAcmLocked(IAcmLockedT _iacmlocked)
		{
			return new IAngularConstraintMotion_UnionUnion
			{
				Type = IAngularConstraintMotion_Union.IAcmLocked,
				Value = _iacmlocked
			};
		}

		// Token: 0x0601B02F RID: 110639 RVA: 0x003D3950 File Offset: 0x003D1B50
		public static int Pack(FlatBufferBuilder builder, IAngularConstraintMotion_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAngularConstraintMotion_Union.IAngularConstraintMotion:
				return IAngularConstraintMotion.Pack(builder, _o.AsIAngularConstraintMotion()).Value;
			case IAngularConstraintMotion_Union.IAcmFree:
				return IAcmFree.Pack(builder, _o.AsIAcmFree()).Value;
			case IAngularConstraintMotion_Union.IAcmLimited:
				return IAcmLimited.Pack(builder, _o.AsIAcmLimited()).Value;
			case IAngularConstraintMotion_Union.IAcmLocked:
				return IAcmLocked.Pack(builder, _o.AsIAcmLocked()).Value;
			default:
				return 0;
			}
		}
	}
}
