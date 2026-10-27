using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C43 RID: 23619
	public class TInitStateUnion
	{
		// Token: 0x1700B20A RID: 45578
		// (get) Token: 0x060287ED RID: 165869 RVA: 0x005922E2 File Offset: 0x005904E2
		// (set) Token: 0x060287EE RID: 165870 RVA: 0x005922EA File Offset: 0x005904EA
		public TInitState Type { get; set; }

		// Token: 0x1700B20B RID: 45579
		// (get) Token: 0x060287EF RID: 165871 RVA: 0x005922F3 File Offset: 0x005904F3
		// (set) Token: 0x060287F0 RID: 165872 RVA: 0x005922FB File Offset: 0x005904FB
		public object Value { get; set; }

		// Token: 0x060287F1 RID: 165873 RVA: 0x00592304 File Offset: 0x00590504
		public TInitStateUnion()
		{
			this.Type = TInitState.NONE;
			this.Value = null;
		}

		// Token: 0x060287F2 RID: 165874 RVA: 0x0059231A File Offset: 0x0059051A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060287F3 RID: 165875 RVA: 0x0059232C File Offset: 0x0059052C
		public IInitStateBarrierLockT AsIInitStateBarrierLock()
		{
			return this.As<IInitStateBarrierLockT>();
		}

		// Token: 0x060287F4 RID: 165876 RVA: 0x00592334 File Offset: 0x00590534
		public static TInitStateUnion FromIInitStateBarrierLock(IInitStateBarrierLockT _iinitstatebarrierlock)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateBarrierLock,
				Value = _iinitstatebarrierlock
			};
		}

		// Token: 0x060287F5 RID: 165877 RVA: 0x00592349 File Offset: 0x00590549
		public IInitStateBirthT AsIInitStateBirth()
		{
			return this.As<IInitStateBirthT>();
		}

		// Token: 0x060287F6 RID: 165878 RVA: 0x00592351 File Offset: 0x00590551
		public static TInitStateUnion FromIInitStateBirth(IInitStateBirthT _iinitstatebirth)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateBirth,
				Value = _iinitstatebirth
			};
		}

		// Token: 0x060287F7 RID: 165879 RVA: 0x00592366 File Offset: 0x00590566
		public IInitStateDigitalT AsIInitStateDigital()
		{
			return this.As<IInitStateDigitalT>();
		}

		// Token: 0x060287F8 RID: 165880 RVA: 0x0059236E File Offset: 0x0059056E
		public static TInitStateUnion FromIInitStateDigital(IInitStateDigitalT _iinitstatedigital)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateDigital,
				Value = _iinitstatedigital
			};
		}

		// Token: 0x060287F9 RID: 165881 RVA: 0x00592383 File Offset: 0x00590583
		public IInitStateMagneticStormT AsIInitStateMagneticStorm()
		{
			return this.As<IInitStateMagneticStormT>();
		}

		// Token: 0x060287FA RID: 165882 RVA: 0x0059238B File Offset: 0x0059058B
		public static TInitStateUnion FromIInitStateMagneticStorm(IInitStateMagneticStormT _iinitstatemagneticstorm)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateMagneticStorm,
				Value = _iinitstatemagneticstorm
			};
		}

		// Token: 0x060287FB RID: 165883 RVA: 0x005923A0 File Offset: 0x005905A0
		public IInitStateStandbyT AsIInitStateStandby()
		{
			return this.As<IInitStateStandbyT>();
		}

		// Token: 0x060287FC RID: 165884 RVA: 0x005923A8 File Offset: 0x005905A8
		public static TInitStateUnion FromIInitStateStandby(IInitStateStandbyT _iinitstatestandby)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateStandby,
				Value = _iinitstatestandby
			};
		}

		// Token: 0x060287FD RID: 165885 RVA: 0x005923BD File Offset: 0x005905BD
		public IInitStateWuYinQuT AsIInitStateWuYinQu()
		{
			return this.As<IInitStateWuYinQuT>();
		}

		// Token: 0x060287FE RID: 165886 RVA: 0x005923C5 File Offset: 0x005905C5
		public static TInitStateUnion FromIInitStateWuYinQu(IInitStateWuYinQuT _iinitstatewuyinqu)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateWuYinQu,
				Value = _iinitstatewuyinqu
			};
		}

		// Token: 0x060287FF RID: 165887 RVA: 0x005923DC File Offset: 0x005905DC
		public static int Pack(FlatBufferBuilder builder, TInitStateUnion _o)
		{
			switch (_o.Type)
			{
			case TInitState.IInitStateBarrierLock:
				return IInitStateBarrierLock.Pack(builder, _o.AsIInitStateBarrierLock()).Value;
			case TInitState.IInitStateBirth:
				return IInitStateBirth.Pack(builder, _o.AsIInitStateBirth()).Value;
			case TInitState.IInitStateDigital:
				return IInitStateDigital.Pack(builder, _o.AsIInitStateDigital()).Value;
			case TInitState.IInitStateMagneticStorm:
				return IInitStateMagneticStorm.Pack(builder, _o.AsIInitStateMagneticStorm()).Value;
			case TInitState.IInitStateStandby:
				return IInitStateStandby.Pack(builder, _o.AsIInitStateStandby()).Value;
			case TInitState.IInitStateWuYinQu:
				return IInitStateWuYinQu.Pack(builder, _o.AsIInitStateWuYinQu()).Value;
			default:
				return 0;
			}
		}
	}
}
