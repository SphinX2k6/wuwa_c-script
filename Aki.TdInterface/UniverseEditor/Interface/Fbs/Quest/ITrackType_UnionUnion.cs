using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004221 RID: 16929
	public class ITrackType_UnionUnion
	{
		// Token: 0x17007845 RID: 30789
		// (get) Token: 0x0601906A RID: 102506 RVA: 0x00399FBC File Offset: 0x003981BC
		// (set) Token: 0x0601906B RID: 102507 RVA: 0x00399FC4 File Offset: 0x003981C4
		public ITrackType_Union Type { get; set; }

		// Token: 0x17007846 RID: 30790
		// (get) Token: 0x0601906C RID: 102508 RVA: 0x00399FCD File Offset: 0x003981CD
		// (set) Token: 0x0601906D RID: 102509 RVA: 0x00399FD5 File Offset: 0x003981D5
		public object Value { get; set; }

		// Token: 0x0601906E RID: 102510 RVA: 0x00399FDE File Offset: 0x003981DE
		public ITrackType_UnionUnion()
		{
			this.Type = ITrackType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601906F RID: 102511 RVA: 0x00399FF4 File Offset: 0x003981F4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019070 RID: 102512 RVA: 0x0039A006 File Offset: 0x00398206
		public ITrackTypeT AsITrackType()
		{
			return this.As<ITrackTypeT>();
		}

		// Token: 0x06019071 RID: 102513 RVA: 0x0039A00E File Offset: 0x0039820E
		public static ITrackType_UnionUnion FromITrackType(ITrackTypeT _itracktype)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackType,
				Value = _itracktype
			};
		}

		// Token: 0x06019072 RID: 102514 RVA: 0x0039A023 File Offset: 0x00398223
		public ITrackLocationsT AsITrackLocations()
		{
			return this.As<ITrackLocationsT>();
		}

		// Token: 0x06019073 RID: 102515 RVA: 0x0039A02B File Offset: 0x0039822B
		public static ITrackType_UnionUnion FromITrackLocations(ITrackLocationsT _itracklocations)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackLocations,
				Value = _itracklocations
			};
		}

		// Token: 0x06019074 RID: 102516 RVA: 0x0039A040 File Offset: 0x00398240
		public ITrackEntitiesT AsITrackEntities()
		{
			return this.As<ITrackEntitiesT>();
		}

		// Token: 0x06019075 RID: 102517 RVA: 0x0039A048 File Offset: 0x00398248
		public static ITrackType_UnionUnion FromITrackEntities(ITrackEntitiesT _itrackentities)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackEntities,
				Value = _itrackentities
			};
		}

		// Token: 0x06019076 RID: 102518 RVA: 0x0039A05D File Offset: 0x0039825D
		public ITrackCaptureVisionsT AsITrackCaptureVisions()
		{
			return this.As<ITrackCaptureVisionsT>();
		}

		// Token: 0x06019077 RID: 102519 RVA: 0x0039A065 File Offset: 0x00398265
		public static ITrackType_UnionUnion FromITrackCaptureVisions(ITrackCaptureVisionsT _itrackcapturevisions)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackCaptureVisions,
				Value = _itrackcapturevisions
			};
		}

		// Token: 0x06019078 RID: 102520 RVA: 0x0039A07A File Offset: 0x0039827A
		public ITrackEntityGroupT AsITrackEntityGroup()
		{
			return this.As<ITrackEntityGroupT>();
		}

		// Token: 0x06019079 RID: 102521 RVA: 0x0039A082 File Offset: 0x00398282
		public static ITrackType_UnionUnion FromITrackEntityGroup(ITrackEntityGroupT _itrackentitygroup)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackEntityGroup,
				Value = _itrackentitygroup
			};
		}

		// Token: 0x0601907A RID: 102522 RVA: 0x0039A097 File Offset: 0x00398297
		public ITrackLevelPlayT AsITrackLevelPlay()
		{
			return this.As<ITrackLevelPlayT>();
		}

		// Token: 0x0601907B RID: 102523 RVA: 0x0039A09F File Offset: 0x0039829F
		public static ITrackType_UnionUnion FromITrackLevelPlay(ITrackLevelPlayT _itracklevelplay)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackLevelPlay,
				Value = _itracklevelplay
			};
		}

		// Token: 0x0601907C RID: 102524 RVA: 0x0039A0B4 File Offset: 0x003982B4
		public static int Pack(FlatBufferBuilder builder, ITrackType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITrackType_Union.ITrackType:
				return ITrackType.Pack(builder, _o.AsITrackType()).Value;
			case ITrackType_Union.ITrackLocations:
				return ITrackLocations.Pack(builder, _o.AsITrackLocations()).Value;
			case ITrackType_Union.ITrackEntities:
				return ITrackEntities.Pack(builder, _o.AsITrackEntities()).Value;
			case ITrackType_Union.ITrackCaptureVisions:
				return ITrackCaptureVisions.Pack(builder, _o.AsITrackCaptureVisions()).Value;
			case ITrackType_Union.ITrackEntityGroup:
				return ITrackEntityGroup.Pack(builder, _o.AsITrackEntityGroup()).Value;
			case ITrackType_Union.ITrackLevelPlay:
				return ITrackLevelPlay.Pack(builder, _o.AsITrackLevelPlay()).Value;
			default:
				return 0;
			}
		}
	}
}
