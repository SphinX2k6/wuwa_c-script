using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200434F RID: 17231
	public class TAngularConstraintMotionUnion
	{
		// Token: 0x170079A3 RID: 31139
		// (get) Token: 0x060198D0 RID: 104656 RVA: 0x003A893C File Offset: 0x003A6B3C
		// (set) Token: 0x060198D1 RID: 104657 RVA: 0x003A8944 File Offset: 0x003A6B44
		public TAngularConstraintMotion Type { get; set; }

		// Token: 0x170079A4 RID: 31140
		// (get) Token: 0x060198D2 RID: 104658 RVA: 0x003A894D File Offset: 0x003A6B4D
		// (set) Token: 0x060198D3 RID: 104659 RVA: 0x003A8955 File Offset: 0x003A6B55
		public object Value { get; set; }

		// Token: 0x060198D4 RID: 104660 RVA: 0x003A895E File Offset: 0x003A6B5E
		public TAngularConstraintMotionUnion()
		{
			this.Type = TAngularConstraintMotion.NONE;
			this.Value = null;
		}

		// Token: 0x060198D5 RID: 104661 RVA: 0x003A8974 File Offset: 0x003A6B74
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060198D6 RID: 104662 RVA: 0x003A8986 File Offset: 0x003A6B86
		public IAcmFreeT AsIAcmFree()
		{
			return this.As<IAcmFreeT>();
		}

		// Token: 0x060198D7 RID: 104663 RVA: 0x003A898E File Offset: 0x003A6B8E
		public static TAngularConstraintMotionUnion FromIAcmFree(IAcmFreeT _iacmfree)
		{
			return new TAngularConstraintMotionUnion
			{
				Type = TAngularConstraintMotion.IAcmFree,
				Value = _iacmfree
			};
		}

		// Token: 0x060198D8 RID: 104664 RVA: 0x003A89A3 File Offset: 0x003A6BA3
		public IAcmLimitedT AsIAcmLimited()
		{
			return this.As<IAcmLimitedT>();
		}

		// Token: 0x060198D9 RID: 104665 RVA: 0x003A89AB File Offset: 0x003A6BAB
		public static TAngularConstraintMotionUnion FromIAcmLimited(IAcmLimitedT _iacmlimited)
		{
			return new TAngularConstraintMotionUnion
			{
				Type = TAngularConstraintMotion.IAcmLimited,
				Value = _iacmlimited
			};
		}

		// Token: 0x060198DA RID: 104666 RVA: 0x003A89C0 File Offset: 0x003A6BC0
		public IAcmLockedT AsIAcmLocked()
		{
			return this.As<IAcmLockedT>();
		}

		// Token: 0x060198DB RID: 104667 RVA: 0x003A89C8 File Offset: 0x003A6BC8
		public static TAngularConstraintMotionUnion FromIAcmLocked(IAcmLockedT _iacmlocked)
		{
			return new TAngularConstraintMotionUnion
			{
				Type = TAngularConstraintMotion.IAcmLocked,
				Value = _iacmlocked
			};
		}

		// Token: 0x060198DC RID: 104668 RVA: 0x003A89E0 File Offset: 0x003A6BE0
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
