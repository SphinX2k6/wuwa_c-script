using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C6A RID: 23658
	public class TNearbyTrackingUnion
	{
		// Token: 0x1700B224 RID: 45604
		// (get) Token: 0x060288A1 RID: 166049 RVA: 0x00593302 File Offset: 0x00591502
		// (set) Token: 0x060288A2 RID: 166050 RVA: 0x0059330A File Offset: 0x0059150A
		public TNearbyTracking Type { get; set; }

		// Token: 0x1700B225 RID: 45605
		// (get) Token: 0x060288A3 RID: 166051 RVA: 0x00593313 File Offset: 0x00591513
		// (set) Token: 0x060288A4 RID: 166052 RVA: 0x0059331B File Offset: 0x0059151B
		public object Value { get; set; }

		// Token: 0x060288A5 RID: 166053 RVA: 0x00593324 File Offset: 0x00591524
		public TNearbyTrackingUnion()
		{
			this.Type = TNearbyTracking.NONE;
			this.Value = null;
		}

		// Token: 0x060288A6 RID: 166054 RVA: 0x0059333A File Offset: 0x0059153A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060288A7 RID: 166055 RVA: 0x0059334C File Offset: 0x0059154C
		public IAudioPointNearbyTrackingT AsIAudioPointNearbyTracking()
		{
			return this.As<IAudioPointNearbyTrackingT>();
		}

		// Token: 0x060288A8 RID: 166056 RVA: 0x00593354 File Offset: 0x00591554
		public static TNearbyTrackingUnion FromIAudioPointNearbyTracking(IAudioPointNearbyTrackingT _iaudiopointnearbytracking)
		{
			return new TNearbyTrackingUnion
			{
				Type = TNearbyTracking.IAudioPointNearbyTracking,
				Value = _iaudiopointnearbytracking
			};
		}

		// Token: 0x060288A9 RID: 166057 RVA: 0x00593369 File Offset: 0x00591569
		public ICompassTrackingT AsICompassTracking()
		{
			return this.As<ICompassTrackingT>();
		}

		// Token: 0x060288AA RID: 166058 RVA: 0x00593371 File Offset: 0x00591571
		public static TNearbyTrackingUnion FromICompassTracking(ICompassTrackingT _icompasstracking)
		{
			return new TNearbyTrackingUnion
			{
				Type = TNearbyTracking.ICompassTracking,
				Value = _icompasstracking
			};
		}

		// Token: 0x060288AB RID: 166059 RVA: 0x00593386 File Offset: 0x00591586
		public IIconNearbyTrackingT AsIIconNearbyTracking()
		{
			return this.As<IIconNearbyTrackingT>();
		}

		// Token: 0x060288AC RID: 166060 RVA: 0x0059338E File Offset: 0x0059158E
		public static TNearbyTrackingUnion FromIIconNearbyTracking(IIconNearbyTrackingT _iiconnearbytracking)
		{
			return new TNearbyTrackingUnion
			{
				Type = TNearbyTracking.IIconNearbyTracking,
				Value = _iiconnearbytracking
			};
		}

		// Token: 0x060288AD RID: 166061 RVA: 0x005933A3 File Offset: 0x005915A3
		public IStealthNearbyTrackingT AsIStealthNearbyTracking()
		{
			return this.As<IStealthNearbyTrackingT>();
		}

		// Token: 0x060288AE RID: 166062 RVA: 0x005933AB File Offset: 0x005915AB
		public static TNearbyTrackingUnion FromIStealthNearbyTracking(IStealthNearbyTrackingT _istealthnearbytracking)
		{
			return new TNearbyTrackingUnion
			{
				Type = TNearbyTracking.IStealthNearbyTracking,
				Value = _istealthnearbytracking
			};
		}

		// Token: 0x060288AF RID: 166063 RVA: 0x005933C0 File Offset: 0x005915C0
		public static int Pack(FlatBufferBuilder builder, TNearbyTrackingUnion _o)
		{
			switch (_o.Type)
			{
			case TNearbyTracking.IAudioPointNearbyTracking:
				return IAudioPointNearbyTracking.Pack(builder, _o.AsIAudioPointNearbyTracking()).Value;
			case TNearbyTracking.ICompassTracking:
				return ICompassTracking.Pack(builder, _o.AsICompassTracking()).Value;
			case TNearbyTracking.IIconNearbyTracking:
				return IIconNearbyTracking.Pack(builder, _o.AsIIconNearbyTracking()).Value;
			case TNearbyTracking.IStealthNearbyTracking:
				return IStealthNearbyTracking.Pack(builder, _o.AsIStealthNearbyTracking()).Value;
			default:
				return 0;
			}
		}
	}
}
