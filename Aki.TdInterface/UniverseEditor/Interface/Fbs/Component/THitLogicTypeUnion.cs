using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C34 RID: 23604
	public class THitLogicTypeUnion
	{
		// Token: 0x1700B200 RID: 45568
		// (get) Token: 0x06028781 RID: 165761 RVA: 0x0059179E File Offset: 0x0058F99E
		// (set) Token: 0x06028782 RID: 165762 RVA: 0x005917A6 File Offset: 0x0058F9A6
		public THitLogicType Type { get; set; }

		// Token: 0x1700B201 RID: 45569
		// (get) Token: 0x06028783 RID: 165763 RVA: 0x005917AF File Offset: 0x0058F9AF
		// (set) Token: 0x06028784 RID: 165764 RVA: 0x005917B7 File Offset: 0x0058F9B7
		public object Value { get; set; }

		// Token: 0x06028785 RID: 165765 RVA: 0x005917C0 File Offset: 0x0058F9C0
		public THitLogicTypeUnion()
		{
			this.Type = THitLogicType.NONE;
			this.Value = null;
		}

		// Token: 0x06028786 RID: 165766 RVA: 0x005917D6 File Offset: 0x0058F9D6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028787 RID: 165767 RVA: 0x005917E8 File Offset: 0x0058F9E8
		public IHitLogicActionByHitTypeT AsIHitLogicActionByHitType()
		{
			return this.As<IHitLogicActionByHitTypeT>();
		}

		// Token: 0x06028788 RID: 165768 RVA: 0x005917F0 File Offset: 0x0058F9F0
		public static THitLogicTypeUnion FromIHitLogicActionByHitType(IHitLogicActionByHitTypeT _ihitlogicactionbyhittype)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicActionByHitType,
				Value = _ihitlogicactionbyhittype
			};
		}

		// Token: 0x06028789 RID: 165769 RVA: 0x00591805 File Offset: 0x0058FA05
		public IHitLogicChangeByPartHitT AsIHitLogicChangeByPartHit()
		{
			return this.As<IHitLogicChangeByPartHitT>();
		}

		// Token: 0x0602878A RID: 165770 RVA: 0x0059180D File Offset: 0x0058FA0D
		public static THitLogicTypeUnion FromIHitLogicChangeByPartHit(IHitLogicChangeByPartHitT _ihitlogicchangebyparthit)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeByPartHit,
				Value = _ihitlogicchangebyparthit
			};
		}

		// Token: 0x0602878B RID: 165771 RVA: 0x00591822 File Offset: 0x0058FA22
		public IHitLogicChangeCountDownStateT AsIHitLogicChangeCountDownState()
		{
			return this.As<IHitLogicChangeCountDownStateT>();
		}

		// Token: 0x0602878C RID: 165772 RVA: 0x0059182A File Offset: 0x0058FA2A
		public static THitLogicTypeUnion FromIHitLogicChangeCountDownState(IHitLogicChangeCountDownStateT _ihitlogicchangecountdownstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeCountDownState,
				Value = _ihitlogicchangecountdownstate
			};
		}

		// Token: 0x0602878D RID: 165773 RVA: 0x0059183F File Offset: 0x0058FA3F
		public IHitLogicChangeLockStateT AsIHitLogicChangeLockState()
		{
			return this.As<IHitLogicChangeLockStateT>();
		}

		// Token: 0x0602878E RID: 165774 RVA: 0x00591847 File Offset: 0x0058FA47
		public static THitLogicTypeUnion FromIHitLogicChangeLockState(IHitLogicChangeLockStateT _ihitlogicchangelockstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeLockState,
				Value = _ihitlogicchangelockstate
			};
		}

		// Token: 0x0602878F RID: 165775 RVA: 0x0059185C File Offset: 0x0058FA5C
		public IHitLogicChangeNextAndLockTargetStateT AsIHitLogicChangeNextAndLockTargetState()
		{
			return this.As<IHitLogicChangeNextAndLockTargetStateT>();
		}

		// Token: 0x06028790 RID: 165776 RVA: 0x00591864 File Offset: 0x0058FA64
		public static THitLogicTypeUnion FromIHitLogicChangeNextAndLockTargetState(IHitLogicChangeNextAndLockTargetStateT _ihitlogicchangenextandlocktargetstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeNextAndLockTargetState,
				Value = _ihitlogicchangenextandlocktargetstate
			};
		}

		// Token: 0x06028791 RID: 165777 RVA: 0x00591879 File Offset: 0x0058FA79
		public IHitLogicChangeNextStateT AsIHitLogicChangeNextState()
		{
			return this.As<IHitLogicChangeNextStateT>();
		}

		// Token: 0x06028792 RID: 165778 RVA: 0x00591881 File Offset: 0x0058FA81
		public static THitLogicTypeUnion FromIHitLogicChangeNextState(IHitLogicChangeNextStateT _ihitlogicchangenextstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeNextState,
				Value = _ihitlogicchangenextstate
			};
		}

		// Token: 0x06028793 RID: 165779 RVA: 0x00591896 File Offset: 0x0058FA96
		public IHitLogicChangeTargetStateT AsIHitLogicChangeTargetState()
		{
			return this.As<IHitLogicChangeTargetStateT>();
		}

		// Token: 0x06028794 RID: 165780 RVA: 0x0059189E File Offset: 0x0058FA9E
		public static THitLogicTypeUnion FromIHitLogicChangeTargetState(IHitLogicChangeTargetStateT _ihitlogicchangetargetstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeTargetState,
				Value = _ihitlogicchangetargetstate
			};
		}

		// Token: 0x06028795 RID: 165781 RVA: 0x005918B4 File Offset: 0x0058FAB4
		public static int Pack(FlatBufferBuilder builder, THitLogicTypeUnion _o)
		{
			switch (_o.Type)
			{
			case THitLogicType.IHitLogicActionByHitType:
				return IHitLogicActionByHitType.Pack(builder, _o.AsIHitLogicActionByHitType()).Value;
			case THitLogicType.IHitLogicChangeByPartHit:
				return IHitLogicChangeByPartHit.Pack(builder, _o.AsIHitLogicChangeByPartHit()).Value;
			case THitLogicType.IHitLogicChangeCountDownState:
				return IHitLogicChangeCountDownState.Pack(builder, _o.AsIHitLogicChangeCountDownState()).Value;
			case THitLogicType.IHitLogicChangeLockState:
				return IHitLogicChangeLockState.Pack(builder, _o.AsIHitLogicChangeLockState()).Value;
			case THitLogicType.IHitLogicChangeNextAndLockTargetState:
				return IHitLogicChangeNextAndLockTargetState.Pack(builder, _o.AsIHitLogicChangeNextAndLockTargetState()).Value;
			case THitLogicType.IHitLogicChangeNextState:
				return IHitLogicChangeNextState.Pack(builder, _o.AsIHitLogicChangeNextState()).Value;
			case THitLogicType.IHitLogicChangeTargetState:
				return IHitLogicChangeTargetState.Pack(builder, _o.AsIHitLogicChangeTargetState()).Value;
			default:
				return 0;
			}
		}
	}
}
