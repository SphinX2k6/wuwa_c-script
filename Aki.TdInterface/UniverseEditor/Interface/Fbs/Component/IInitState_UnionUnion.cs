using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B5 RID: 22965
	public class IInitState_UnionUnion
	{
		// Token: 0x1700A6BC RID: 42684
		// (get) Token: 0x06025721 RID: 153377 RVA: 0x00522E35 File Offset: 0x00521035
		// (set) Token: 0x06025722 RID: 153378 RVA: 0x00522E3D File Offset: 0x0052103D
		public IInitState_Union Type { get; set; }

		// Token: 0x1700A6BD RID: 42685
		// (get) Token: 0x06025723 RID: 153379 RVA: 0x00522E46 File Offset: 0x00521046
		// (set) Token: 0x06025724 RID: 153380 RVA: 0x00522E4E File Offset: 0x0052104E
		public object Value { get; set; }

		// Token: 0x06025725 RID: 153381 RVA: 0x00522E57 File Offset: 0x00521057
		public IInitState_UnionUnion()
		{
			this.Type = IInitState_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025726 RID: 153382 RVA: 0x00522E6D File Offset: 0x0052106D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025727 RID: 153383 RVA: 0x00522E7F File Offset: 0x0052107F
		public IInitStateT AsIInitState()
		{
			return this.As<IInitStateT>();
		}

		// Token: 0x06025728 RID: 153384 RVA: 0x00522E87 File Offset: 0x00521087
		public static IInitState_UnionUnion FromIInitState(IInitStateT _iinitstate)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitState,
				Value = _iinitstate
			};
		}

		// Token: 0x06025729 RID: 153385 RVA: 0x00522E9C File Offset: 0x0052109C
		public IInitStateBirthT AsIInitStateBirth()
		{
			return this.As<IInitStateBirthT>();
		}

		// Token: 0x0602572A RID: 153386 RVA: 0x00522EA4 File Offset: 0x005210A4
		public static IInitState_UnionUnion FromIInitStateBirth(IInitStateBirthT _iinitstatebirth)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateBirth,
				Value = _iinitstatebirth
			};
		}

		// Token: 0x0602572B RID: 153387 RVA: 0x00522EB9 File Offset: 0x005210B9
		public IInitStateStandbyT AsIInitStateStandby()
		{
			return this.As<IInitStateStandbyT>();
		}

		// Token: 0x0602572C RID: 153388 RVA: 0x00522EC1 File Offset: 0x005210C1
		public static IInitState_UnionUnion FromIInitStateStandby(IInitStateStandbyT _iinitstatestandby)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateStandby,
				Value = _iinitstatestandby
			};
		}

		// Token: 0x0602572D RID: 153389 RVA: 0x00522ED6 File Offset: 0x005210D6
		public IInitStateMagneticStormT AsIInitStateMagneticStorm()
		{
			return this.As<IInitStateMagneticStormT>();
		}

		// Token: 0x0602572E RID: 153390 RVA: 0x00522EDE File Offset: 0x005210DE
		public static IInitState_UnionUnion FromIInitStateMagneticStorm(IInitStateMagneticStormT _iinitstatemagneticstorm)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateMagneticStorm,
				Value = _iinitstatemagneticstorm
			};
		}

		// Token: 0x0602572F RID: 153391 RVA: 0x00522EF3 File Offset: 0x005210F3
		public IInitStateWuYinQuT AsIInitStateWuYinQu()
		{
			return this.As<IInitStateWuYinQuT>();
		}

		// Token: 0x06025730 RID: 153392 RVA: 0x00522EFB File Offset: 0x005210FB
		public static IInitState_UnionUnion FromIInitStateWuYinQu(IInitStateWuYinQuT _iinitstatewuyinqu)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateWuYinQu,
				Value = _iinitstatewuyinqu
			};
		}

		// Token: 0x06025731 RID: 153393 RVA: 0x00522F10 File Offset: 0x00521110
		public IInitStateBarrierLockT AsIInitStateBarrierLock()
		{
			return this.As<IInitStateBarrierLockT>();
		}

		// Token: 0x06025732 RID: 153394 RVA: 0x00522F18 File Offset: 0x00521118
		public static IInitState_UnionUnion FromIInitStateBarrierLock(IInitStateBarrierLockT _iinitstatebarrierlock)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateBarrierLock,
				Value = _iinitstatebarrierlock
			};
		}

		// Token: 0x06025733 RID: 153395 RVA: 0x00522F2D File Offset: 0x0052112D
		public IInitStateDigitalT AsIInitStateDigital()
		{
			return this.As<IInitStateDigitalT>();
		}

		// Token: 0x06025734 RID: 153396 RVA: 0x00522F35 File Offset: 0x00521135
		public static IInitState_UnionUnion FromIInitStateDigital(IInitStateDigitalT _iinitstatedigital)
		{
			return new IInitState_UnionUnion
			{
				Type = IInitState_Union.IInitStateDigital,
				Value = _iinitstatedigital
			};
		}

		// Token: 0x06025735 RID: 153397 RVA: 0x00522F4C File Offset: 0x0052114C
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
