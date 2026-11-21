using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592B RID: 22827
	public class IHitLogicType_UnionUnion
	{
		// Token: 0x1700A588 RID: 42376
		// (get) Token: 0x060251D0 RID: 152016 RVA: 0x00517D85 File Offset: 0x00515F85
		// (set) Token: 0x060251D1 RID: 152017 RVA: 0x00517D8D File Offset: 0x00515F8D
		public IHitLogicType_Union Type { get; set; }

		// Token: 0x1700A589 RID: 42377
		// (get) Token: 0x060251D2 RID: 152018 RVA: 0x00517D96 File Offset: 0x00515F96
		// (set) Token: 0x060251D3 RID: 152019 RVA: 0x00517D9E File Offset: 0x00515F9E
		public object Value { get; set; }

		// Token: 0x060251D4 RID: 152020 RVA: 0x00517DA7 File Offset: 0x00515FA7
		public IHitLogicType_UnionUnion()
		{
			this.Type = IHitLogicType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060251D5 RID: 152021 RVA: 0x00517DBD File Offset: 0x00515FBD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060251D6 RID: 152022 RVA: 0x00517DCF File Offset: 0x00515FCF
		public IHitLogicTypeT AsIHitLogicType()
		{
			return this.As<IHitLogicTypeT>();
		}

		// Token: 0x060251D7 RID: 152023 RVA: 0x00517DD7 File Offset: 0x00515FD7
		public static IHitLogicType_UnionUnion FromIHitLogicType(IHitLogicTypeT _ihitlogictype)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicType,
				Value = _ihitlogictype
			};
		}

		// Token: 0x060251D8 RID: 152024 RVA: 0x00517DEC File Offset: 0x00515FEC
		public IHitLogicChangeNextStateT AsIHitLogicChangeNextState()
		{
			return this.As<IHitLogicChangeNextStateT>();
		}

		// Token: 0x060251D9 RID: 152025 RVA: 0x00517DF4 File Offset: 0x00515FF4
		public static IHitLogicType_UnionUnion FromIHitLogicChangeNextState(IHitLogicChangeNextStateT _ihitlogicchangenextstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeNextState,
				Value = _ihitlogicchangenextstate
			};
		}

		// Token: 0x060251DA RID: 152026 RVA: 0x00517E09 File Offset: 0x00516009
		public IHitLogicChangeLockStateT AsIHitLogicChangeLockState()
		{
			return this.As<IHitLogicChangeLockStateT>();
		}

		// Token: 0x060251DB RID: 152027 RVA: 0x00517E11 File Offset: 0x00516011
		public static IHitLogicType_UnionUnion FromIHitLogicChangeLockState(IHitLogicChangeLockStateT _ihitlogicchangelockstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeLockState,
				Value = _ihitlogicchangelockstate
			};
		}

		// Token: 0x060251DC RID: 152028 RVA: 0x00517E26 File Offset: 0x00516026
		public IHitLogicChangeCountDownStateT AsIHitLogicChangeCountDownState()
		{
			return this.As<IHitLogicChangeCountDownStateT>();
		}

		// Token: 0x060251DD RID: 152029 RVA: 0x00517E2E File Offset: 0x0051602E
		public static IHitLogicType_UnionUnion FromIHitLogicChangeCountDownState(IHitLogicChangeCountDownStateT _ihitlogicchangecountdownstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeCountDownState,
				Value = _ihitlogicchangecountdownstate
			};
		}

		// Token: 0x060251DE RID: 152030 RVA: 0x00517E43 File Offset: 0x00516043
		public IHitLogicChangeNextAndLockTargetStateT AsIHitLogicChangeNextAndLockTargetState()
		{
			return this.As<IHitLogicChangeNextAndLockTargetStateT>();
		}

		// Token: 0x060251DF RID: 152031 RVA: 0x00517E4B File Offset: 0x0051604B
		public static IHitLogicType_UnionUnion FromIHitLogicChangeNextAndLockTargetState(IHitLogicChangeNextAndLockTargetStateT _ihitlogicchangenextandlocktargetstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeNextAndLockTargetState,
				Value = _ihitlogicchangenextandlocktargetstate
			};
		}

		// Token: 0x060251E0 RID: 152032 RVA: 0x00517E60 File Offset: 0x00516060
		public IHitLogicChangeTargetStateT AsIHitLogicChangeTargetState()
		{
			return this.As<IHitLogicChangeTargetStateT>();
		}

		// Token: 0x060251E1 RID: 152033 RVA: 0x00517E68 File Offset: 0x00516068
		public static IHitLogicType_UnionUnion FromIHitLogicChangeTargetState(IHitLogicChangeTargetStateT _ihitlogicchangetargetstate)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeTargetState,
				Value = _ihitlogicchangetargetstate
			};
		}

		// Token: 0x060251E2 RID: 152034 RVA: 0x00517E7D File Offset: 0x0051607D
		public IHitLogicChangeByPartHitT AsIHitLogicChangeByPartHit()
		{
			return this.As<IHitLogicChangeByPartHitT>();
		}

		// Token: 0x060251E3 RID: 152035 RVA: 0x00517E85 File Offset: 0x00516085
		public static IHitLogicType_UnionUnion FromIHitLogicChangeByPartHit(IHitLogicChangeByPartHitT _ihitlogicchangebyparthit)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicChangeByPartHit,
				Value = _ihitlogicchangebyparthit
			};
		}

		// Token: 0x060251E4 RID: 152036 RVA: 0x00517E9A File Offset: 0x0051609A
		public IHitLogicActionByHitTypeT AsIHitLogicActionByHitType()
		{
			return this.As<IHitLogicActionByHitTypeT>();
		}

		// Token: 0x060251E5 RID: 152037 RVA: 0x00517EA2 File Offset: 0x005160A2
		public static IHitLogicType_UnionUnion FromIHitLogicActionByHitType(IHitLogicActionByHitTypeT _ihitlogicactionbyhittype)
		{
			return new IHitLogicType_UnionUnion
			{
				Type = IHitLogicType_Union.IHitLogicActionByHitType,
				Value = _ihitlogicactionbyhittype
			};
		}

		// Token: 0x060251E6 RID: 152038 RVA: 0x00517EB8 File Offset: 0x005160B8
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
