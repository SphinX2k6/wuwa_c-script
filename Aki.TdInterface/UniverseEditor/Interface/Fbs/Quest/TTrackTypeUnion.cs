using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432A RID: 17194
	public class TTrackTypeUnion
	{
		// Token: 0x1700797E RID: 31102
		// (get) Token: 0x060197EB RID: 104427 RVA: 0x003A6F5E File Offset: 0x003A515E
		// (set) Token: 0x060197EC RID: 104428 RVA: 0x003A6F66 File Offset: 0x003A5166
		public TTrackType Type { get; set; }

		// Token: 0x1700797F RID: 31103
		// (get) Token: 0x060197ED RID: 104429 RVA: 0x003A6F6F File Offset: 0x003A516F
		// (set) Token: 0x060197EE RID: 104430 RVA: 0x003A6F77 File Offset: 0x003A5177
		public object Value { get; set; }

		// Token: 0x060197EF RID: 104431 RVA: 0x003A6F80 File Offset: 0x003A5180
		public TTrackTypeUnion()
		{
			this.Type = TTrackType.NONE;
			this.Value = null;
		}

		// Token: 0x060197F0 RID: 104432 RVA: 0x003A6F96 File Offset: 0x003A5196
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060197F1 RID: 104433 RVA: 0x003A6FA8 File Offset: 0x003A51A8
		public ITrackCaptureVisionsT AsITrackCaptureVisions()
		{
			return this.As<ITrackCaptureVisionsT>();
		}

		// Token: 0x060197F2 RID: 104434 RVA: 0x003A6FB0 File Offset: 0x003A51B0
		public static TTrackTypeUnion FromITrackCaptureVisions(ITrackCaptureVisionsT _itrackcapturevisions)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackCaptureVisions,
				Value = _itrackcapturevisions
			};
		}

		// Token: 0x060197F3 RID: 104435 RVA: 0x003A6FC5 File Offset: 0x003A51C5
		public ITrackEntitiesT AsITrackEntities()
		{
			return this.As<ITrackEntitiesT>();
		}

		// Token: 0x060197F4 RID: 104436 RVA: 0x003A6FCD File Offset: 0x003A51CD
		public static TTrackTypeUnion FromITrackEntities(ITrackEntitiesT _itrackentities)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackEntities,
				Value = _itrackentities
			};
		}

		// Token: 0x060197F5 RID: 104437 RVA: 0x003A6FE2 File Offset: 0x003A51E2
		public ITrackEntityGroupT AsITrackEntityGroup()
		{
			return this.As<ITrackEntityGroupT>();
		}

		// Token: 0x060197F6 RID: 104438 RVA: 0x003A6FEA File Offset: 0x003A51EA
		public static TTrackTypeUnion FromITrackEntityGroup(ITrackEntityGroupT _itrackentitygroup)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackEntityGroup,
				Value = _itrackentitygroup
			};
		}

		// Token: 0x060197F7 RID: 104439 RVA: 0x003A6FFF File Offset: 0x003A51FF
		public ITrackLevelPlayT AsITrackLevelPlay()
		{
			return this.As<ITrackLevelPlayT>();
		}

		// Token: 0x060197F8 RID: 104440 RVA: 0x003A7007 File Offset: 0x003A5207
		public static TTrackTypeUnion FromITrackLevelPlay(ITrackLevelPlayT _itracklevelplay)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackLevelPlay,
				Value = _itracklevelplay
			};
		}

		// Token: 0x060197F9 RID: 104441 RVA: 0x003A701C File Offset: 0x003A521C
		public ITrackLocationsT AsITrackLocations()
		{
			return this.As<ITrackLocationsT>();
		}

		// Token: 0x060197FA RID: 104442 RVA: 0x003A7024 File Offset: 0x003A5224
		public static TTrackTypeUnion FromITrackLocations(ITrackLocationsT _itracklocations)
		{
			return new TTrackTypeUnion
			{
				Type = TTrackType.ITrackLocations,
				Value = _itracklocations
			};
		}

		// Token: 0x060197FB RID: 104443 RVA: 0x003A703C File Offset: 0x003A523C
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
