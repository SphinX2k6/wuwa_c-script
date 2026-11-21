using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B95 RID: 23445
	public class INearbyTracking_UnionUnion
	{
		// Token: 0x1700AB5F RID: 43871
		// (get) Token: 0x06026A3D RID: 158269 RVA: 0x0054A714 File Offset: 0x00548914
		// (set) Token: 0x06026A3E RID: 158270 RVA: 0x0054A71C File Offset: 0x0054891C
		public INearbyTracking_Union Type { get; set; }

		// Token: 0x1700AB60 RID: 43872
		// (get) Token: 0x06026A3F RID: 158271 RVA: 0x0054A725 File Offset: 0x00548925
		// (set) Token: 0x06026A40 RID: 158272 RVA: 0x0054A72D File Offset: 0x0054892D
		public object Value { get; set; }

		// Token: 0x06026A41 RID: 158273 RVA: 0x0054A736 File Offset: 0x00548936
		public INearbyTracking_UnionUnion()
		{
			this.Type = INearbyTracking_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026A42 RID: 158274 RVA: 0x0054A74C File Offset: 0x0054894C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026A43 RID: 158275 RVA: 0x0054A75E File Offset: 0x0054895E
		public INearbyTrackingT AsINearbyTracking()
		{
			return this.As<INearbyTrackingT>();
		}

		// Token: 0x06026A44 RID: 158276 RVA: 0x0054A766 File Offset: 0x00548966
		public static INearbyTracking_UnionUnion FromINearbyTracking(INearbyTrackingT _inearbytracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.INearbyTracking,
				Value = _inearbytracking
			};
		}

		// Token: 0x06026A45 RID: 158277 RVA: 0x0054A77B File Offset: 0x0054897B
		public IIconNearbyTrackingT AsIIconNearbyTracking()
		{
			return this.As<IIconNearbyTrackingT>();
		}

		// Token: 0x06026A46 RID: 158278 RVA: 0x0054A783 File Offset: 0x00548983
		public static INearbyTracking_UnionUnion FromIIconNearbyTracking(IIconNearbyTrackingT _iiconnearbytracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.IIconNearbyTracking,
				Value = _iiconnearbytracking
			};
		}

		// Token: 0x06026A47 RID: 158279 RVA: 0x0054A798 File Offset: 0x00548998
		public IAudioPointNearbyTrackingT AsIAudioPointNearbyTracking()
		{
			return this.As<IAudioPointNearbyTrackingT>();
		}

		// Token: 0x06026A48 RID: 158280 RVA: 0x0054A7A0 File Offset: 0x005489A0
		public static INearbyTracking_UnionUnion FromIAudioPointNearbyTracking(IAudioPointNearbyTrackingT _iaudiopointnearbytracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.IAudioPointNearbyTracking,
				Value = _iaudiopointnearbytracking
			};
		}

		// Token: 0x06026A49 RID: 158281 RVA: 0x0054A7B5 File Offset: 0x005489B5
		public ICompassTrackingT AsICompassTracking()
		{
			return this.As<ICompassTrackingT>();
		}

		// Token: 0x06026A4A RID: 158282 RVA: 0x0054A7BD File Offset: 0x005489BD
		public static INearbyTracking_UnionUnion FromICompassTracking(ICompassTrackingT _icompasstracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.ICompassTracking,
				Value = _icompasstracking
			};
		}

		// Token: 0x06026A4B RID: 158283 RVA: 0x0054A7D2 File Offset: 0x005489D2
		public IDarkTideNearbyTrackingT AsIDarkTideNearbyTracking()
		{
			return this.As<IDarkTideNearbyTrackingT>();
		}

		// Token: 0x06026A4C RID: 158284 RVA: 0x0054A7DA File Offset: 0x005489DA
		public static INearbyTracking_UnionUnion FromIDarkTideNearbyTracking(IDarkTideNearbyTrackingT _idarktidenearbytracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.IDarkTideNearbyTracking,
				Value = _idarktidenearbytracking
			};
		}

		// Token: 0x06026A4D RID: 158285 RVA: 0x0054A7EF File Offset: 0x005489EF
		public IStealthNearbyTrackingT AsIStealthNearbyTracking()
		{
			return this.As<IStealthNearbyTrackingT>();
		}

		// Token: 0x06026A4E RID: 158286 RVA: 0x0054A7F7 File Offset: 0x005489F7
		public static INearbyTracking_UnionUnion FromIStealthNearbyTracking(IStealthNearbyTrackingT _istealthnearbytracking)
		{
			return new INearbyTracking_UnionUnion
			{
				Type = INearbyTracking_Union.IStealthNearbyTracking,
				Value = _istealthnearbytracking
			};
		}

		// Token: 0x06026A4F RID: 158287 RVA: 0x0054A80C File Offset: 0x00548A0C
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
			case INearbyTracking_Union.IDarkTideNearbyTracking:
				return IDarkTideNearbyTracking.Pack(builder, _o.AsIDarkTideNearbyTracking()).Value;
			case INearbyTracking_Union.IStealthNearbyTracking:
				return IStealthNearbyTracking.Pack(builder, _o.AsIStealthNearbyTracking()).Value;
			default:
				return 0;
			}
		}
	}
}
