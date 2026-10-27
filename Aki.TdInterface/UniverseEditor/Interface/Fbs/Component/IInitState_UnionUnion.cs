using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542F RID: 21551
	public class IInitState_UnionUnion
	{
		// Token: 0x17009E82 RID: 40578
		// (get) Token: 0x06023669 RID: 145001 RVA: 0x004E5E09 File Offset: 0x004E4009
		// (set) Token: 0x0602366A RID: 145002 RVA: 0x004E5E11 File Offset: 0x004E4011
		public IInitState_Union Type { get; set; }

		// Token: 0x17009E83 RID: 40579
		// (get) Token: 0x0602366B RID: 145003 RVA: 0x004E5E1A File Offset: 0x004E401A
		// (set) Token: 0x0602366C RID: 145004 RVA: 0x004E5E22 File Offset: 0x004E4022
		public object Value { get; set; }

		// Token: 0x0602366D RID: 145005 RVA: 0x004E5E2B File Offset: 0x004E402B
		public IInitState_UnionUnion()
		{
			this.Type = IInitState_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602366E RID: 145006 RVA: 0x004E5E41 File Offset: 0x004E4041
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602366F RID: 145007 RVA: 0x004E5E53 File Offset: 0x004E4053
		public IInitStateT AsIInitState()
		{
			return this.As<IInitStateT>();
		}

		// Token: 0x06023670 RID: 145008 RVA: 0x004E5E5B File Offset: 0x004E405B
		public static IInitState_UnionUnion FromIInitState(IInitStateT _iinitstate)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitState,
				Value = _iinitstate
			};
		}

		// Token: 0x06023671 RID: 145009 RVA: 0x004E5E70 File Offset: 0x004E4070
		public IInitStateBirthT AsIInitStateBirth()
		{
			return this.As<IInitStateBirthT>();
		}

		// Token: 0x06023672 RID: 145010 RVA: 0x004E5E78 File Offset: 0x004E4078
		public static IInitState_UnionUnion FromIInitStateBirth(IInitStateBirthT _iinitstatebirth)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateBirth,
				Value = _iinitstatebirth
			};
		}

		// Token: 0x06023673 RID: 145011 RVA: 0x004E5E8D File Offset: 0x004E408D
		public IInitStateStandbyT AsIInitStateStandby()
		{
			return this.As<IInitStateStandbyT>();
		}

		// Token: 0x06023674 RID: 145012 RVA: 0x004E5E95 File Offset: 0x004E4095
		public static IInitState_UnionUnion FromIInitStateStandby(IInitStateStandbyT _iinitstatestandby)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateStandby,
				Value = _iinitstatestandby
			};
		}

		// Token: 0x06023675 RID: 145013 RVA: 0x004E5EAA File Offset: 0x004E40AA
		public IInitStateMagneticStormT AsIInitStateMagneticStorm()
		{
			return this.As<IInitStateMagneticStormT>();
		}

		// Token: 0x06023676 RID: 145014 RVA: 0x004E5EB2 File Offset: 0x004E40B2
		public static IInitState_UnionUnion FromIInitStateMagneticStorm(IInitStateMagneticStormT _iinitstatemagneticstorm)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateMagneticStorm,
				Value = _iinitstatemagneticstorm
			};
		}

		// Token: 0x06023677 RID: 145015 RVA: 0x004E5EC7 File Offset: 0x004E40C7
		public IInitStateWuYinQuT AsIInitStateWuYinQu()
		{
			return this.As<IInitStateWuYinQuT>();
		}

		// Token: 0x06023678 RID: 145016 RVA: 0x004E5ECF File Offset: 0x004E40CF
		public static IInitState_UnionUnion FromIInitStateWuYinQu(IInitStateWuYinQuT _iinitstatewuyinqu)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateWuYinQu,
				Value = _iinitstatewuyinqu
			};
		}

		// Token: 0x06023679 RID: 145017 RVA: 0x004E5EE4 File Offset: 0x004E40E4
		public IInitStateBarrierLockT AsIInitStateBarrierLock()
		{
			return this.As<IInitStateBarrierLockT>();
		}

		// Token: 0x0602367A RID: 145018 RVA: 0x004E5EEC File Offset: 0x004E40EC
		public static IInitState_UnionUnion FromIInitStateBarrierLock(IInitStateBarrierLockT _iinitstatebarrierlock)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateBarrierLock,
				Value = _iinitstatebarrierlock
			};
		}

		// Token: 0x0602367B RID: 145019 RVA: 0x004E5F01 File Offset: 0x004E4101
		public IInitStateDigitalT AsIInitStateDigital()
		{
			return this.As<IInitStateDigitalT>();
		}

		// Token: 0x0602367C RID: 145020 RVA: 0x004E5F09 File Offset: 0x004E4109
		public static IInitState_UnionUnion FromIInitStateDigital(IInitStateDigitalT _iinitstatedigital)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateDigital,
				Value = _iinitstatedigital
			};
		}

		// Token: 0x0602367D RID: 145021 RVA: 0x004E5F20 File Offset: 0x004E4120
		public static int Pack(FlatBufferBuilder builder, IInitState_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInitState_Union.IInitState:
				return IInitState.Pack(builder, _o.AsIInitState()).Value;
			case IInitState_Union.IInitStateBirth:
				return IInitStateBirth.Pack(builder, _o.AsIInitStateBirth()).Value;
			case IInitState_Union.IInitStateStandby:
				return IInitStateStandby.Pack(builder, _o.AsIInitStateStandby()).Value;
			case IInitState_Union.IInitStateMagneticStorm:
				return IInitStateMagneticStorm.Pack(builder, _o.AsIInitStateMagneticStorm()).Value;
			case IInitState_Union.IInitStateWuYinQu:
				return IInitStateWuYinQu.Pack(builder, _o.AsIInitStateWuYinQu()).Value;
			case IInitState_Union.IInitStateBarrierLock:
				return IInitStateBarrierLock.Pack(builder, _o.AsIInitStateBarrierLock()).Value;
			case IInitState_Union.IInitStateDigital:
				return IInitStateDigital.Pack(builder, _o.AsIInitStateDigital()).Value;
			default:
				return 0;
			}
		}
	}
}
