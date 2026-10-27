using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A5 RID: 21413
	public class IHitLogicType_UnionUnion
	{
		// Token: 0x17009D50 RID: 40272
		// (get) Token: 0x0602311C RID: 143644 RVA: 0x004DAEB1 File Offset: 0x004D90B1
		// (set) Token: 0x0602311D RID: 143645 RVA: 0x004DAEB9 File Offset: 0x004D90B9
		public IHitLogicType_Union Type { get; set; }

		// Token: 0x17009D51 RID: 40273
		// (get) Token: 0x0602311E RID: 143646 RVA: 0x004DAEC2 File Offset: 0x004D90C2
		// (set) Token: 0x0602311F RID: 143647 RVA: 0x004DAECA File Offset: 0x004D90CA
		public object Value { get; set; }

		// Token: 0x06023120 RID: 143648 RVA: 0x004DAED3 File Offset: 0x004D90D3
		public IHitLogicType_UnionUnion()
		{
			this.Type = IHitLogicType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023121 RID: 143649 RVA: 0x004DAEE9 File Offset: 0x004D90E9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023122 RID: 143650 RVA: 0x004DAEFB File Offset: 0x004D90FB
		public IHitLogicTypeT AsIHitLogicType()
		{
			return this.As<IHitLogicTypeT>();
		}

		// Token: 0x06023123 RID: 143651 RVA: 0x004DAF03 File Offset: 0x004D9103
		public static IHitLogicType_UnionUnion FromIHitLogicType(IHitLogicTypeT _ihitlogictype)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicType,
				Value = _ihitlogictype
			};
		}

		// Token: 0x06023124 RID: 143652 RVA: 0x004DAF18 File Offset: 0x004D9118
		public IHitLogicChangeNextStateT AsIHitLogicChangeNextState()
		{
			return this.As<IHitLogicChangeNextStateT>();
		}

		// Token: 0x06023125 RID: 143653 RVA: 0x004DAF20 File Offset: 0x004D9120
		public static IHitLogicType_UnionUnion FromIHitLogicChangeNextState(IHitLogicChangeNextStateT _ihitlogicchangenextstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeNextState,
				Value = _ihitlogicchangenextstate
			};
		}

		// Token: 0x06023126 RID: 143654 RVA: 0x004DAF35 File Offset: 0x004D9135
		public IHitLogicChangeLockStateT AsIHitLogicChangeLockState()
		{
			return this.As<IHitLogicChangeLockStateT>();
		}

		// Token: 0x06023127 RID: 143655 RVA: 0x004DAF3D File Offset: 0x004D913D
		public static IHitLogicType_UnionUnion FromIHitLogicChangeLockState(IHitLogicChangeLockStateT _ihitlogicchangelockstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeLockState,
				Value = _ihitlogicchangelockstate
			};
		}

		// Token: 0x06023128 RID: 143656 RVA: 0x004DAF52 File Offset: 0x004D9152
		public IHitLogicChangeCountDownStateT AsIHitLogicChangeCountDownState()
		{
			return this.As<IHitLogicChangeCountDownStateT>();
		}

		// Token: 0x06023129 RID: 143657 RVA: 0x004DAF5A File Offset: 0x004D915A
		public static IHitLogicType_UnionUnion FromIHitLogicChangeCountDownState(IHitLogicChangeCountDownStateT _ihitlogicchangecountdownstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeCountDownState,
				Value = _ihitlogicchangecountdownstate
			};
		}

		// Token: 0x0602312A RID: 143658 RVA: 0x004DAF6F File Offset: 0x004D916F
		public IHitLogicChangeNextAndLockTargetStateT AsIHitLogicChangeNextAndLockTargetState()
		{
			return this.As<IHitLogicChangeNextAndLockTargetStateT>();
		}

		// Token: 0x0602312B RID: 143659 RVA: 0x004DAF77 File Offset: 0x004D9177
		public static IHitLogicType_UnionUnion FromIHitLogicChangeNextAndLockTargetState(IHitLogicChangeNextAndLockTargetStateT _ihitlogicchangenextandlocktargetstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeNextAndLockTargetState,
				Value = _ihitlogicchangenextandlocktargetstate
			};
		}

		// Token: 0x0602312C RID: 143660 RVA: 0x004DAF8C File Offset: 0x004D918C
		public IHitLogicChangeTargetStateT AsIHitLogicChangeTargetState()
		{
			return this.As<IHitLogicChangeTargetStateT>();
		}

		// Token: 0x0602312D RID: 143661 RVA: 0x004DAF94 File Offset: 0x004D9194
		public static IHitLogicType_UnionUnion FromIHitLogicChangeTargetState(IHitLogicChangeTargetStateT _ihitlogicchangetargetstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeTargetState,
				Value = _ihitlogicchangetargetstate
			};
		}

		// Token: 0x0602312E RID: 143662 RVA: 0x004DAFA9 File Offset: 0x004D91A9
		public IHitLogicChangeByPartHitT AsIHitLogicChangeByPartHit()
		{
			return this.As<IHitLogicChangeByPartHitT>();
		}

		// Token: 0x0602312F RID: 143663 RVA: 0x004DAFB1 File Offset: 0x004D91B1
		public static IHitLogicType_UnionUnion FromIHitLogicChangeByPartHit(IHitLogicChangeByPartHitT _ihitlogicchangebyparthit)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeByPartHit,
				Value = _ihitlogicchangebyparthit
			};
		}

		// Token: 0x06023130 RID: 143664 RVA: 0x004DAFC6 File Offset: 0x004D91C6
		public IHitLogicActionByHitTypeT AsIHitLogicActionByHitType()
		{
			return this.As<IHitLogicActionByHitTypeT>();
		}

		// Token: 0x06023131 RID: 143665 RVA: 0x004DAFCE File Offset: 0x004D91CE
		public static IHitLogicType_UnionUnion FromIHitLogicActionByHitType(IHitLogicActionByHitTypeT _ihitlogicactionbyhittype)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicActionByHitType,
				Value = _ihitlogicactionbyhittype
			};
		}

		// Token: 0x06023132 RID: 143666 RVA: 0x004DAFE4 File Offset: 0x004D91E4
		public static int Pack(FlatBufferBuilder builder, IHitLogicType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHitLogicType_Union.IHitLogicType:
				return IHitLogicType.Pack(builder, _o.AsIHitLogicType()).Value;
			case IHitLogicType_Union.IHitLogicChangeNextState:
				return IHitLogicChangeNextState.Pack(builder, _o.AsIHitLogicChangeNextState()).Value;
			case IHitLogicType_Union.IHitLogicChangeLockState:
				return IHitLogicChangeLockState.Pack(builder, _o.AsIHitLogicChangeLockState()).Value;
			case IHitLogicType_Union.IHitLogicChangeCountDownState:
				return IHitLogicChangeCountDownState.Pack(builder, _o.AsIHitLogicChangeCountDownState()).Value;
			case IHitLogicType_Union.IHitLogicChangeNextAndLockTargetState:
				return IHitLogicChangeNextAndLockTargetState.Pack(builder, _o.AsIHitLogicChangeNextAndLockTargetState()).Value;
			case IHitLogicType_Union.IHitLogicChangeTargetState:
				return IHitLogicChangeTargetState.Pack(builder, _o.AsIHitLogicChangeTargetState()).Value;
			case IHitLogicType_Union.IHitLogicChangeByPartHit:
				return IHitLogicChangeByPartHit.Pack(builder, _o.AsIHitLogicChangeByPartHit()).Value;
			case IHitLogicType_Union.IHitLogicActionByHitType:
				return IHitLogicActionByHitType.Pack(builder, _o.AsIHitLogicActionByHitType()).Value;
			default:
				return 0;
			}
		}
	}
}
