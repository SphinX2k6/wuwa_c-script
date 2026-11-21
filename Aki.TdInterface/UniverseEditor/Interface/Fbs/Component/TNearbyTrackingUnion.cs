using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006292 RID: 25234
	public class TNearbyTrackingUnion
	{
		// Token: 0x1700BB78 RID: 47992
		// (get) Token: 0x0602AEBD RID: 175805 RVA: 0x005DB666 File Offset: 0x005D9866
		// (set) Token: 0x0602AEBE RID: 175806 RVA: 0x005DB66E File Offset: 0x005D986E
		public TNearbyTracking Type { get; set; }

		// Token: 0x1700BB79 RID: 47993
		// (get) Token: 0x0602AEBF RID: 175807 RVA: 0x005DB677 File Offset: 0x005D9877
		// (set) Token: 0x0602AEC0 RID: 175808 RVA: 0x005DB67F File Offset: 0x005D987F
		public object Value { get; set; }

		// Token: 0x0602AEC1 RID: 175809 RVA: 0x005DB688 File Offset: 0x005D9888
		public TNearbyTrackingUnion()
		{
			this.Type = TNearbyTracking.NONE;
			this.Value = null;
		}

		// Token: 0x0602AEC2 RID: 175810 RVA: 0x005DB69E File Offset: 0x005D989E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AEC3 RID: 175811 RVA: 0x005DB6B0 File Offset: 0x005D98B0
		public IAudioPointNearbyTrackingT AsIAudioPointNearbyTracking()
		{
			return this.As<IAudioPointNearbyTrackingT>();
		}

		// Token: 0x0602AEC4 RID: 175812 RVA: 0x005DB6B8 File Offset: 0x005D98B8
		public static TNearbyTrackingUnion FromIAudioPointNearbyTracking(IAudioPointNearbyTrackingT _iaudiopointnearbytracking)
		{
			return new TNearbyTrackingUnion
			{
				Type = TNearbyTracking.IAudioPointNearbyTracking,
				Value = _iaudiopointnearbytracking
			};
		}

		// Token: 0x0602AEC5 RID: 175813 RVA: 0x005DB6CD File Offset: 0x005D98CD
		public ICompassTrackingT AsICompassTracking()
		{
			return this.As<ICompassTrackingT>();
		}

		// Token: 0x0602AEC6 RID: 175814 RVA: 0x005DB6D5 File Offset: 0x005D98D5
		public static TNearbyTrackingUnion FromICompassTracking(ICompassTrackingT _icompasstracking)
		{
			return new TNearbyTrackingUnion
			{
				Type = TNearbyTracking.ICompassTracking,
				Value = _icompasstracking
			};
		}

		// Token: 0x0602AEC7 RID: 175815 RVA: 0x005DB6EA File Offset: 0x005D98EA
		public IDarkTideNearbyTrackingT AsIDarkTideNearbyTracking()
		{
			return this.As<IDarkTideNearbyTrackingT>();
		}

		// Token: 0x0602AEC8 RID: 175816 RVA: 0x005DB6F2 File Offset: 0x005D98F2
		public static TNearbyTrackingUnion FromIDarkTideNearbyTracking(IDarkTideNearbyTrackingT _idarktidenearbytracking)
		{
			return new TNearbyTrackingUnion
			{
				Type = TNearbyTracking.IDarkTideNearbyTracking,
				Value = _idarktidenearbytracking
			};
		}

		// Token: 0x0602AEC9 RID: 175817 RVA: 0x005DB707 File Offset: 0x005D9907
		public IIconNearbyTrackingT AsIIconNearbyTracking()
		{
			return this.As<IIconNearbyTrackingT>();
		}

		// Token: 0x0602AECA RID: 175818 RVA: 0x005DB70F File Offset: 0x005D990F
		public static TNearbyTrackingUnion FromIIconNearbyTracking(IIconNearbyTrackingT _iiconnearbytracking)
		{
			return new TNearbyTrackingUnion
			{
				Type = TNearbyTracking.IIconNearbyTracking,
				Value = _iiconnearbytracking
			};
		}

		// Token: 0x0602AECB RID: 175819 RVA: 0x005DB724 File Offset: 0x005D9924
		public IStealthNearbyTrackingT AsIStealthNearbyTracking()
		{
			return this.As<IStealthNearbyTrackingT>();
		}

		// Token: 0x0602AECC RID: 175820 RVA: 0x005DB72C File Offset: 0x005D992C
		public static TNearbyTrackingUnion FromIStealthNearbyTracking(IStealthNearbyTrackingT _istealthnearbytracking)
		{
			return new TNearbyTrackingUnion
			{
				Type = TNearbyTracking.IStealthNearbyTracking,
				Value = _istealthnearbytracking
			};
		}

		// Token: 0x0602AECD RID: 175821 RVA: 0x005DB744 File Offset: 0x005D9944
		public static int Pack(FlatBufferBuilder builder, TNearbyTrackingUnion _o)
		{
			switch (_o.Type)
			{
			case TNearbyTracking.IAudioPointNearbyTracking:
				return IAudioPointNearbyTracking.Pack(builder, _o.AsIAudioPointNearbyTracking()).Value;
			case TNearbyTracking.ICompassTracking:
				return ICompassTracking.Pack(builder, _o.AsICompassTracking()).Value;
			case TNearbyTracking.IDarkTideNearbyTracking:
				return IDarkTideNearbyTracking.Pack(builder, _o.AsIDarkTideNearbyTracking()).Value;
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
