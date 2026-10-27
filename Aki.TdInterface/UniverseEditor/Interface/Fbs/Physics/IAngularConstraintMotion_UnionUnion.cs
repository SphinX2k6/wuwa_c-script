using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x02004349 RID: 17225
	public class IAngularConstraintMotion_UnionUnion
	{
		// Token: 0x17007998 RID: 31128
		// (get) Token: 0x06019893 RID: 104595 RVA: 0x003A7E69 File Offset: 0x003A6069
		// (set) Token: 0x06019894 RID: 104596 RVA: 0x003A7E71 File Offset: 0x003A6071
		public IAngularConstraintMotion_Union Type { get; set; }

		// Token: 0x17007999 RID: 31129
		// (get) Token: 0x06019895 RID: 104597 RVA: 0x003A7E7A File Offset: 0x003A607A
		// (set) Token: 0x06019896 RID: 104598 RVA: 0x003A7E82 File Offset: 0x003A6082
		public object Value { get; set; }

		// Token: 0x06019897 RID: 104599 RVA: 0x003A7E8B File Offset: 0x003A608B
		public IAngularConstraintMotion_UnionUnion()
		{
			this.Type = IAngularConstraintMotion_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019898 RID: 104600 RVA: 0x003A7EA1 File Offset: 0x003A60A1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019899 RID: 104601 RVA: 0x003A7EB3 File Offset: 0x003A60B3
		public IAngularConstraintMotionT AsIAngularConstraintMotion()
		{
			return this.As<IAngularConstraintMotionT>();
		}

		// Token: 0x0601989A RID: 104602 RVA: 0x003A7EBB File Offset: 0x003A60BB
		public static IAngularConstraintMotion_UnionUnion FromIAngularConstraintMotion(IAngularConstraintMotionT _iangularconstraintmotion)
		{
			return new IAngularConstraintMotion_UnionUnion
			{
				Type = IAngularConstraintMotion_Union.IAngularConstraintMotion,
				Value = _iangularconstraintmotion
			};
		}

		// Token: 0x0601989B RID: 104603 RVA: 0x003A7ED0 File Offset: 0x003A60D0
		public IAcmFreeT AsIAcmFree()
		{
			return this.As<IAcmFreeT>();
		}

		// Token: 0x0601989C RID: 104604 RVA: 0x003A7ED8 File Offset: 0x003A60D8
		public static IAngularConstraintMotion_UnionUnion FromIAcmFree(IAcmFreeT _iacmfree)
		{
			return new IAngularConstraintMotion_UnionUnion
			{
				Type = IAngularConstraintMotion_Union.IAcmFree,
				Value = _iacmfree
			};
		}

		// Token: 0x0601989D RID: 104605 RVA: 0x003A7EED File Offset: 0x003A60ED
		public IAcmLimitedT AsIAcmLimited()
		{
			return this.As<IAcmLimitedT>();
		}

		// Token: 0x0601989E RID: 104606 RVA: 0x003A7EF5 File Offset: 0x003A60F5
		public static IAngularConstraintMotion_UnionUnion FromIAcmLimited(IAcmLimitedT _iacmlimited)
		{
			return new IAngularConstraintMotion_UnionUnion
			{
				Type = IAngularConstraintMotion_Union.IAcmLimited,
				Value = _iacmlimited
			};
		}

		// Token: 0x0601989F RID: 104607 RVA: 0x003A7F0A File Offset: 0x003A610A
		public IAcmLockedT AsIAcmLocked()
		{
			return this.As<IAcmLockedT>();
		}

		// Token: 0x060198A0 RID: 104608 RVA: 0x003A7F12 File Offset: 0x003A6112
		public static IAngularConstraintMotion_UnionUnion FromIAcmLocked(IAcmLockedT _iacmlocked)
		{
			return new IAngularConstraintMotion_UnionUnion
			{
				Type = IAngularConstraintMotion_Union.IAcmLocked,
				Value = _iacmlocked
			};
		}

		// Token: 0x060198A1 RID: 104609 RVA: 0x003A7F28 File Offset: 0x003A6128
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
