using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006259 RID: 25177
	public class THitLogicTypeUnion
	{
		// Token: 0x1700BB52 RID: 47954
		// (get) Token: 0x0602AD8F RID: 175503 RVA: 0x005D99B6 File Offset: 0x005D7BB6
		// (set) Token: 0x0602AD90 RID: 175504 RVA: 0x005D99BE File Offset: 0x005D7BBE
		public THitLogicType Type { get; set; }

		// Token: 0x1700BB53 RID: 47955
		// (get) Token: 0x0602AD91 RID: 175505 RVA: 0x005D99C7 File Offset: 0x005D7BC7
		// (set) Token: 0x0602AD92 RID: 175506 RVA: 0x005D99CF File Offset: 0x005D7BCF
		public object Value { get; set; }

		// Token: 0x0602AD93 RID: 175507 RVA: 0x005D99D8 File Offset: 0x005D7BD8
		public THitLogicTypeUnion()
		{
			this.Type = THitLogicType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD94 RID: 175508 RVA: 0x005D99EE File Offset: 0x005D7BEE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD95 RID: 175509 RVA: 0x005D9A00 File Offset: 0x005D7C00
		public IHitLogicActionByHitTypeT AsIHitLogicActionByHitType()
		{
			return this.As<IHitLogicActionByHitTypeT>();
		}

		// Token: 0x0602AD96 RID: 175510 RVA: 0x005D9A08 File Offset: 0x005D7C08
		public static THitLogicTypeUnion FromIHitLogicActionByHitType(IHitLogicActionByHitTypeT _ihitlogicactionbyhittype)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicActionByHitType,
				Value = _ihitlogicactionbyhittype
			};
		}

		// Token: 0x0602AD97 RID: 175511 RVA: 0x005D9A1D File Offset: 0x005D7C1D
		public IHitLogicChangeByPartHitT AsIHitLogicChangeByPartHit()
		{
			return this.As<IHitLogicChangeByPartHitT>();
		}

		// Token: 0x0602AD98 RID: 175512 RVA: 0x005D9A25 File Offset: 0x005D7C25
		public static THitLogicTypeUnion FromIHitLogicChangeByPartHit(IHitLogicChangeByPartHitT _ihitlogicchangebyparthit)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeByPartHit,
				Value = _ihitlogicchangebyparthit
			};
		}

		// Token: 0x0602AD99 RID: 175513 RVA: 0x005D9A3A File Offset: 0x005D7C3A
		public IHitLogicChangeCountDownStateT AsIHitLogicChangeCountDownState()
		{
			return this.As<IHitLogicChangeCountDownStateT>();
		}

		// Token: 0x0602AD9A RID: 175514 RVA: 0x005D9A42 File Offset: 0x005D7C42
		public static THitLogicTypeUnion FromIHitLogicChangeCountDownState(IHitLogicChangeCountDownStateT _ihitlogicchangecountdownstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeCountDownState,
				Value = _ihitlogicchangecountdownstate
			};
		}

		// Token: 0x0602AD9B RID: 175515 RVA: 0x005D9A57 File Offset: 0x005D7C57
		public IHitLogicChangeLockStateT AsIHitLogicChangeLockState()
		{
			return this.As<IHitLogicChangeLockStateT>();
		}

		// Token: 0x0602AD9C RID: 175516 RVA: 0x005D9A5F File Offset: 0x005D7C5F
		public static THitLogicTypeUnion FromIHitLogicChangeLockState(IHitLogicChangeLockStateT _ihitlogicchangelockstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeLockState,
				Value = _ihitlogicchangelockstate
			};
		}

		// Token: 0x0602AD9D RID: 175517 RVA: 0x005D9A74 File Offset: 0x005D7C74
		public IHitLogicChangeNextAndLockTargetStateT AsIHitLogicChangeNextAndLockTargetState()
		{
			return this.As<IHitLogicChangeNextAndLockTargetStateT>();
		}

		// Token: 0x0602AD9E RID: 175518 RVA: 0x005D9A7C File Offset: 0x005D7C7C
		public static THitLogicTypeUnion FromIHitLogicChangeNextAndLockTargetState(IHitLogicChangeNextAndLockTargetStateT _ihitlogicchangenextandlocktargetstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeNextAndLockTargetState,
				Value = _ihitlogicchangenextandlocktargetstate
			};
		}

		// Token: 0x0602AD9F RID: 175519 RVA: 0x005D9A91 File Offset: 0x005D7C91
		public IHitLogicChangeNextStateT AsIHitLogicChangeNextState()
		{
			return this.As<IHitLogicChangeNextStateT>();
		}

		// Token: 0x0602ADA0 RID: 175520 RVA: 0x005D9A99 File Offset: 0x005D7C99
		public static THitLogicTypeUnion FromIHitLogicChangeNextState(IHitLogicChangeNextStateT _ihitlogicchangenextstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeNextState,
				Value = _ihitlogicchangenextstate
			};
		}

		// Token: 0x0602ADA1 RID: 175521 RVA: 0x005D9AAE File Offset: 0x005D7CAE
		public IHitLogicChangeTargetStateT AsIHitLogicChangeTargetState()
		{
			return this.As<IHitLogicChangeTargetStateT>();
		}

		// Token: 0x0602ADA2 RID: 175522 RVA: 0x005D9AB6 File Offset: 0x005D7CB6
		public static THitLogicTypeUnion FromIHitLogicChangeTargetState(IHitLogicChangeTargetStateT _ihitlogicchangetargetstate)
		{
			return new THitLogicTypeUnion
			{
				Type = THitLogicType.IHitLogicChangeTargetState,
				Value = _ihitlogicchangetargetstate
			};
		}

		// Token: 0x0602ADA3 RID: 175523 RVA: 0x005D9ACC File Offset: 0x005D7CCC
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
