using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006268 RID: 25192
	public class TInitStateUnion
	{
		// Token: 0x1700BB5C RID: 47964
		// (get) Token: 0x0602ADFB RID: 175611 RVA: 0x005DA4FA File Offset: 0x005D86FA
		// (set) Token: 0x0602ADFC RID: 175612 RVA: 0x005DA502 File Offset: 0x005D8702
		public TInitState Type { get; set; }

		// Token: 0x1700BB5D RID: 47965
		// (get) Token: 0x0602ADFD RID: 175613 RVA: 0x005DA50B File Offset: 0x005D870B
		// (set) Token: 0x0602ADFE RID: 175614 RVA: 0x005DA513 File Offset: 0x005D8713
		public object Value { get; set; }

		// Token: 0x0602ADFF RID: 175615 RVA: 0x005DA51C File Offset: 0x005D871C
		public TInitStateUnion()
		{
			this.Type = TInitState.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE00 RID: 175616 RVA: 0x005DA532 File Offset: 0x005D8732
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE01 RID: 175617 RVA: 0x005DA544 File Offset: 0x005D8744
		public IInitStateBarrierLockT AsIInitStateBarrierLock()
		{
			return this.As<IInitStateBarrierLockT>();
		}

		// Token: 0x0602AE02 RID: 175618 RVA: 0x005DA54C File Offset: 0x005D874C
		public static TInitStateUnion FromIInitStateBarrierLock(IInitStateBarrierLockT _iinitstatebarrierlock)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateBarrierLock,
				Value = _iinitstatebarrierlock
			};
		}

		// Token: 0x0602AE03 RID: 175619 RVA: 0x005DA561 File Offset: 0x005D8761
		public IInitStateBirthT AsIInitStateBirth()
		{
			return this.As<IInitStateBirthT>();
		}

		// Token: 0x0602AE04 RID: 175620 RVA: 0x005DA569 File Offset: 0x005D8769
		public static TInitStateUnion FromIInitStateBirth(IInitStateBirthT _iinitstatebirth)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateBirth,
				Value = _iinitstatebirth
			};
		}

		// Token: 0x0602AE05 RID: 175621 RVA: 0x005DA57E File Offset: 0x005D877E
		public IInitStateDigitalT AsIInitStateDigital()
		{
			return this.As<IInitStateDigitalT>();
		}

		// Token: 0x0602AE06 RID: 175622 RVA: 0x005DA586 File Offset: 0x005D8786
		public static TInitStateUnion FromIInitStateDigital(IInitStateDigitalT _iinitstatedigital)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateDigital,
				Value = _iinitstatedigital
			};
		}

		// Token: 0x0602AE07 RID: 175623 RVA: 0x005DA59B File Offset: 0x005D879B
		public IInitStateMagneticStormT AsIInitStateMagneticStorm()
		{
			return this.As<IInitStateMagneticStormT>();
		}

		// Token: 0x0602AE08 RID: 175624 RVA: 0x005DA5A3 File Offset: 0x005D87A3
		public static TInitStateUnion FromIInitStateMagneticStorm(IInitStateMagneticStormT _iinitstatemagneticstorm)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateMagneticStorm,
				Value = _iinitstatemagneticstorm
			};
		}

		// Token: 0x0602AE09 RID: 175625 RVA: 0x005DA5B8 File Offset: 0x005D87B8
		public IInitStateStandbyT AsIInitStateStandby()
		{
			return this.As<IInitStateStandbyT>();
		}

		// Token: 0x0602AE0A RID: 175626 RVA: 0x005DA5C0 File Offset: 0x005D87C0
		public static TInitStateUnion FromIInitStateStandby(IInitStateStandbyT _iinitstatestandby)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateStandby,
				Value = _iinitstatestandby
			};
		}

		// Token: 0x0602AE0B RID: 175627 RVA: 0x005DA5D5 File Offset: 0x005D87D5
		public IInitStateWuYinQuT AsIInitStateWuYinQu()
		{
			return this.As<IInitStateWuYinQuT>();
		}

		// Token: 0x0602AE0C RID: 175628 RVA: 0x005DA5DD File Offset: 0x005D87DD
		public static TInitStateUnion FromIInitStateWuYinQu(IInitStateWuYinQuT _iinitstatewuyinqu)
		{
			return new TInitStateUnion
			{
				Type = TInitState.IInitStateWuYinQu,
				Value = _iinitstatewuyinqu
			};
		}

		// Token: 0x0602AE0D RID: 175629 RVA: 0x005DA5F4 File Offset: 0x005D87F4
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
