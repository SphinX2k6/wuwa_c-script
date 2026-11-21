using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200478C RID: 18316
	public class TTrackTypeUnion
	{
		// Token: 0x17007FB3 RID: 32691
		// (get) Token: 0x0601AF79 RID: 110457 RVA: 0x003D2986 File Offset: 0x003D0B86
		// (set) Token: 0x0601AF7A RID: 110458 RVA: 0x003D298E File Offset: 0x003D0B8E
		public TTrackType Type { get; set; }

		// Token: 0x17007FB4 RID: 32692
		// (get) Token: 0x0601AF7B RID: 110459 RVA: 0x003D2997 File Offset: 0x003D0B97
		// (set) Token: 0x0601AF7C RID: 110460 RVA: 0x003D299F File Offset: 0x003D0B9F
		public object Value { get; set; }

		// Token: 0x0601AF7D RID: 110461 RVA: 0x003D29A8 File Offset: 0x003D0BA8
		public TTrackTypeUnion()
		{
			this.Type = TTrackType.NONE;
			this.Value = null;
		}

		// Token: 0x0601AF7E RID: 110462 RVA: 0x003D29BE File Offset: 0x003D0BBE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AF7F RID: 110463 RVA: 0x003D29D0 File Offset: 0x003D0BD0
		public ITrackCaptureVisionsT AsITrackCaptureVisions()
		{
			return this.As<ITrackCaptureVisionsT>();
		}

		// Token: 0x0601AF80 RID: 110464 RVA: 0x003D29D8 File Offset: 0x003D0BD8
		public static TTrackTypeUnion FromITrackCaptureVisions(ITrackCaptureVisionsT _itrackcapturevisions)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackCaptureVisions,
				Value = _itrackcapturevisions
			};
		}

		// Token: 0x0601AF81 RID: 110465 RVA: 0x003D29ED File Offset: 0x003D0BED
		public ITrackEntitiesT AsITrackEntities()
		{
			return this.As<ITrackEntitiesT>();
		}

		// Token: 0x0601AF82 RID: 110466 RVA: 0x003D29F5 File Offset: 0x003D0BF5
		public static TTrackTypeUnion FromITrackEntities(ITrackEntitiesT _itrackentities)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackEntities,
				Value = _itrackentities
			};
		}

		// Token: 0x0601AF83 RID: 110467 RVA: 0x003D2A0A File Offset: 0x003D0C0A
		public ITrackEntityGroupT AsITrackEntityGroup()
		{
			return this.As<ITrackEntityGroupT>();
		}

		// Token: 0x0601AF84 RID: 110468 RVA: 0x003D2A12 File Offset: 0x003D0C12
		public static TTrackTypeUnion FromITrackEntityGroup(ITrackEntityGroupT _itrackentitygroup)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackEntityGroup,
				Value = _itrackentitygroup
			};
		}

		// Token: 0x0601AF85 RID: 110469 RVA: 0x003D2A27 File Offset: 0x003D0C27
		public ITrackLevelPlayT AsITrackLevelPlay()
		{
			return this.As<ITrackLevelPlayT>();
		}

		// Token: 0x0601AF86 RID: 110470 RVA: 0x003D2A2F File Offset: 0x003D0C2F
		public static TTrackTypeUnion FromITrackLevelPlay(ITrackLevelPlayT _itracklevelplay)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackLevelPlay,
				Value = _itracklevelplay
			};
		}

		// Token: 0x0601AF87 RID: 110471 RVA: 0x003D2A44 File Offset: 0x003D0C44
		public ITrackLocationsT AsITrackLocations()
		{
			return this.As<ITrackLocationsT>();
		}

		// Token: 0x0601AF88 RID: 110472 RVA: 0x003D2A4C File Offset: 0x003D0C4C
		public static TTrackTypeUnion FromITrackLocations(ITrackLocationsT _itracklocations)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackLocations,
				Value = _itracklocations
			};
		}

		// Token: 0x0601AF89 RID: 110473 RVA: 0x003D2A64 File Offset: 0x003D0C64
		public static int Pack(FlatBufferBuilder builder, TTrackTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TTrackType.ITrackCaptureVisions:
				return ITrackCaptureVisions.Pack(builder, _o.AsITrackCaptureVisions()).Value;
			case TTrackType.ITrackEntities:
				return ITrackEntities.Pack(builder, _o.AsITrackEntities()).Value;
			case TTrackType.ITrackEntityGroup:
				return ITrackEntityGroup.Pack(builder, _o.AsITrackEntityGroup()).Value;
			case TTrackType.ITrackLevelPlay:
				return ITrackLevelPlay.Pack(builder, _o.AsITrackLevelPlay()).Value;
			case TTrackType.ITrackLocations:
				return ITrackLocations.Pack(builder, _o.AsITrackLocations()).Value;
			default:
				return 0;
			}
		}
	}
}
