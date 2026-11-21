using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200467D RID: 18045
	public class ITrackType_UnionUnion
	{
		// Token: 0x17007E76 RID: 32374
		// (get) Token: 0x0601A7D6 RID: 108502 RVA: 0x003C5694 File Offset: 0x003C3894
		// (set) Token: 0x0601A7D7 RID: 108503 RVA: 0x003C569C File Offset: 0x003C389C
		public ITrackType_Union Type { get; set; }

		// Token: 0x17007E77 RID: 32375
		// (get) Token: 0x0601A7D8 RID: 108504 RVA: 0x003C56A5 File Offset: 0x003C38A5
		// (set) Token: 0x0601A7D9 RID: 108505 RVA: 0x003C56AD File Offset: 0x003C38AD
		public object Value { get; set; }

		// Token: 0x0601A7DA RID: 108506 RVA: 0x003C56B6 File Offset: 0x003C38B6
		public ITrackType_UnionUnion()
		{
			this.Type = ITrackType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A7DB RID: 108507 RVA: 0x003C56CC File Offset: 0x003C38CC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A7DC RID: 108508 RVA: 0x003C56DE File Offset: 0x003C38DE
		public ITrackTypeT AsITrackType()
		{
			return this.As<ITrackTypeT>();
		}

		// Token: 0x0601A7DD RID: 108509 RVA: 0x003C56E6 File Offset: 0x003C38E6
		public static ITrackType_UnionUnion FromITrackType(ITrackTypeT _itracktype)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackType,
				Value = _itracktype
			};
		}

		// Token: 0x0601A7DE RID: 108510 RVA: 0x003C56FB File Offset: 0x003C38FB
		public ITrackLocationsT AsITrackLocations()
		{
			return this.As<ITrackLocationsT>();
		}

		// Token: 0x0601A7DF RID: 108511 RVA: 0x003C5703 File Offset: 0x003C3903
		public static ITrackType_UnionUnion FromITrackLocations(ITrackLocationsT _itracklocations)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackLocations,
				Value = _itracklocations
			};
		}

		// Token: 0x0601A7E0 RID: 108512 RVA: 0x003C5718 File Offset: 0x003C3918
		public ITrackEntitiesT AsITrackEntities()
		{
			return this.As<ITrackEntitiesT>();
		}

		// Token: 0x0601A7E1 RID: 108513 RVA: 0x003C5720 File Offset: 0x003C3920
		public static ITrackType_UnionUnion FromITrackEntities(ITrackEntitiesT _itrackentities)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackEntities,
				Value = _itrackentities
			};
		}

		// Token: 0x0601A7E2 RID: 108514 RVA: 0x003C5735 File Offset: 0x003C3935
		public ITrackCaptureVisionsT AsITrackCaptureVisions()
		{
			return this.As<ITrackCaptureVisionsT>();
		}

		// Token: 0x0601A7E3 RID: 108515 RVA: 0x003C573D File Offset: 0x003C393D
		public static ITrackType_UnionUnion FromITrackCaptureVisions(ITrackCaptureVisionsT _itrackcapturevisions)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackCaptureVisions,
				Value = _itrackcapturevisions
			};
		}

		// Token: 0x0601A7E4 RID: 108516 RVA: 0x003C5752 File Offset: 0x003C3952
		public ITrackEntityGroupT AsITrackEntityGroup()
		{
			return this.As<ITrackEntityGroupT>();
		}

		// Token: 0x0601A7E5 RID: 108517 RVA: 0x003C575A File Offset: 0x003C395A
		public static ITrackType_UnionUnion FromITrackEntityGroup(ITrackEntityGroupT _itrackentitygroup)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackEntityGroup,
				Value = _itrackentitygroup
			};
		}

		// Token: 0x0601A7E6 RID: 108518 RVA: 0x003C576F File Offset: 0x003C396F
		public ITrackLevelPlayT AsITrackLevelPlay()
		{
			return this.As<ITrackLevelPlayT>();
		}

		// Token: 0x0601A7E7 RID: 108519 RVA: 0x003C5777 File Offset: 0x003C3977
		public static ITrackType_UnionUnion FromITrackLevelPlay(ITrackLevelPlayT _itracklevelplay)
		{
			return new ITrackType_UnionUnion
			{
				Type = ITrackType_Union.ITrackLevelPlay,
				Value = _itracklevelplay
			};
		}

		// Token: 0x0601A7E8 RID: 108520 RVA: 0x003C578C File Offset: 0x003C398C
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
