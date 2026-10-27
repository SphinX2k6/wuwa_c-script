using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F7 RID: 22007
	public class INearbyTracking_UnionUnion
	{
		// Token: 0x1700A2D7 RID: 41687
		// (get) Token: 0x0602482F RID: 149551 RVA: 0x0050A140 File Offset: 0x00508340
		// (set) Token: 0x06024830 RID: 149552 RVA: 0x0050A148 File Offset: 0x00508348
		public INearbyTracking_Union Type { get; set; }

		// Token: 0x1700A2D8 RID: 41688
		// (get) Token: 0x06024831 RID: 149553 RVA: 0x0050A151 File Offset: 0x00508351
		// (set) Token: 0x06024832 RID: 149554 RVA: 0x0050A159 File Offset: 0x00508359
		public object Value { get; set; }

		// Token: 0x06024833 RID: 149555 RVA: 0x0050A162 File Offset: 0x00508362
		public INearbyTracking_UnionUnion()
		{
			this.Type = INearbyTracking_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024834 RID: 149556 RVA: 0x0050A178 File Offset: 0x00508378
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024835 RID: 149557 RVA: 0x0050A18A File Offset: 0x0050838A
		public INearbyTrackingT AsINearbyTracking()
		{
			return this.As<INearbyTrackingT>();
		}

		// Token: 0x06024836 RID: 149558 RVA: 0x0050A192 File Offset: 0x00508392
		public static INearbyTracking_UnionUnion FromINearbyTracking(INearbyTrackingT _inearbytracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.INearbyTracking,
				Value = _inearbytracking
			};
		}

		// Token: 0x06024837 RID: 149559 RVA: 0x0050A1A7 File Offset: 0x005083A7
		public IIconNearbyTrackingT AsIIconNearbyTracking()
		{
			return this.As<IIconNearbyTrackingT>();
		}

		// Token: 0x06024838 RID: 149560 RVA: 0x0050A1AF File Offset: 0x005083AF
		public static INearbyTracking_UnionUnion FromIIconNearbyTracking(IIconNearbyTrackingT _iiconnearbytracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.IIconNearbyTracking,
				Value = _iiconnearbytracking
			};
		}

		// Token: 0x06024839 RID: 149561 RVA: 0x0050A1C4 File Offset: 0x005083C4
		public IAudioPointNearbyTrackingT AsIAudioPointNearbyTracking()
		{
			return this.As<IAudioPointNearbyTrackingT>();
		}

		// Token: 0x0602483A RID: 149562 RVA: 0x0050A1CC File Offset: 0x005083CC
		public static INearbyTracking_UnionUnion FromIAudioPointNearbyTracking(IAudioPointNearbyTrackingT _iaudiopointnearbytracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.IAudioPointNearbyTracking,
				Value = _iaudiopointnearbytracking
			};
		}

		// Token: 0x0602483B RID: 149563 RVA: 0x0050A1E1 File Offset: 0x005083E1
		public ICompassTrackingT AsICompassTracking()
		{
			return this.As<ICompassTrackingT>();
		}

		// Token: 0x0602483C RID: 149564 RVA: 0x0050A1E9 File Offset: 0x005083E9
		public static INearbyTracking_UnionUnion FromICompassTracking(ICompassTrackingT _icompasstracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.ICompassTracking,
				Value = _icompasstracking
			};
		}

		// Token: 0x0602483D RID: 149565 RVA: 0x0050A1FE File Offset: 0x005083FE
		public IStealthNearbyTrackingT AsIStealthNearbyTracking()
		{
			return this.As<IStealthNearbyTrackingT>();
		}

		// Token: 0x0602483E RID: 149566 RVA: 0x0050A206 File Offset: 0x00508406
		public static INearbyTracking_UnionUnion FromIStealthNearbyTracking(IStealthNearbyTrackingT _istealthnearbytracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.IStealthNearbyTracking,
				Value = _istealthnearbytracking
			};
		}

		// Token: 0x0602483F RID: 149567 RVA: 0x0050A21C File Offset: 0x0050841C
		public static int Pack(FlatBufferBuilder builder, INearbyTracking_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INearbyTracking_Union.INearbyTracking:
				return INearbyTracking.Pack(builder, _o.AsINearbyTracking()).Value;
			case INearbyTracking_Union.IIconNearbyTracking:
				return IIconNearbyTracking.Pack(builder, _o.AsIIconNearbyTracking()).Value;
			case INearbyTracking_Union.IAudioPointNearbyTracking:
				return IAudioPointNearbyTracking.Pack(builder, _o.AsIAudioPointNearbyTracking()).Value;
			case INearbyTracking_Union.ICompassTracking:
				return ICompassTracking.Pack(builder, _o.AsICompassTracking()).Value;
			case INearbyTracking_Union.IStealthNearbyTracking:
				return IStealthNearbyTracking.Pack(builder, _o.AsIStealthNearbyTracking()).Value;
			default:
				return 0;
			}
		}
	}
}
