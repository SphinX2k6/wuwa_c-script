using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B0 RID: 21168
	public class IFollowTrackEndType_UnionUnion
	{
		// Token: 0x17009B39 RID: 39737
		// (get) Token: 0x06022827 RID: 141351 RVA: 0x004C8A09 File Offset: 0x004C6C09
		// (set) Token: 0x06022828 RID: 141352 RVA: 0x004C8A11 File Offset: 0x004C6C11
		public IFollowTrackEndType_Union Type { get; set; }

		// Token: 0x17009B3A RID: 39738
		// (get) Token: 0x06022829 RID: 141353 RVA: 0x004C8A1A File Offset: 0x004C6C1A
		// (set) Token: 0x0602282A RID: 141354 RVA: 0x004C8A22 File Offset: 0x004C6C22
		public object Value { get; set; }

		// Token: 0x0602282B RID: 141355 RVA: 0x004C8A2B File Offset: 0x004C6C2B
		public IFollowTrackEndType_UnionUnion()
		{
			this.Type = IFollowTrackEndType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602282C RID: 141356 RVA: 0x004C8A41 File Offset: 0x004C6C41
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602282D RID: 141357 RVA: 0x004C8A53 File Offset: 0x004C6C53
		public IFollowTrackEndTypeT AsIFollowTrackEndType()
		{
			return this.As<IFollowTrackEndTypeT>();
		}

		// Token: 0x0602282E RID: 141358 RVA: 0x004C8A5B File Offset: 0x004C6C5B
		public static IFollowTrackEndType_UnionUnion FromIFollowTrackEndType(IFollowTrackEndTypeT _ifollowtrackendtype)
		{
			return new IFollowTrackEndType_UnionUnion
			{
				Type = IFollowTrackEndType_Union.IFollowTrackEndType,
				Value = _ifollowtrackendtype
			};
		}

		// Token: 0x0602282F RID: 141359 RVA: 0x004C8A70 File Offset: 0x004C6C70
		public IFollowTrackToStartT AsIFollowTrackToStart()
		{
			return this.As<IFollowTrackToStartT>();
		}

		// Token: 0x06022830 RID: 141360 RVA: 0x004C8A78 File Offset: 0x004C6C78
		public static IFollowTrackEndType_UnionUnion FromIFollowTrackToStart(IFollowTrackToStartT _ifollowtracktostart)
		{
			return new IFollowTrackEndType_UnionUnion
			{
				Type = IFollowTrackEndType_Union.IFollowTrackToStart,
				Value = _ifollowtracktostart
			};
		}

		// Token: 0x06022831 RID: 141361 RVA: 0x004C8A8D File Offset: 0x004C6C8D
		public IFollowTrackToFoundationT AsIFollowTrackToFoundation()
		{
			return this.As<IFollowTrackToFoundationT>();
		}

		// Token: 0x06022832 RID: 141362 RVA: 0x004C8A95 File Offset: 0x004C6C95
		public static IFollowTrackEndType_UnionUnion FromIFollowTrackToFoundation(IFollowTrackToFoundationT _ifollowtracktofoundation)
		{
			return new IFollowTrackEndType_UnionUnion
			{
				Type = IFollowTrackEndType_Union.IFollowTrackToFoundation,
				Value = _ifollowtracktofoundation
			};
		}

		// Token: 0x06022833 RID: 141363 RVA: 0x004C8AAA File Offset: 0x004C6CAA
		public IFollowTrackToSplineDestinationT AsIFollowTrackToSplineDestination()
		{
			return this.As<IFollowTrackToSplineDestinationT>();
		}

		// Token: 0x06022834 RID: 141364 RVA: 0x004C8AB2 File Offset: 0x004C6CB2
		public static IFollowTrackEndType_UnionUnion FromIFollowTrackToSplineDestination(IFollowTrackToSplineDestinationT _ifollowtracktosplinedestination)
		{
			return new IFollowTrackEndType_UnionUnion
			{
				Type = IFollowTrackEndType_Union.IFollowTrackToSplineDestination,
				Value = _ifollowtracktosplinedestination
			};
		}

		// Token: 0x06022835 RID: 141365 RVA: 0x004C8AC8 File Offset: 0x004C6CC8
		public static int Pack(FlatBufferBuilder builder, IFollowTrackEndType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFollowTrackEndType_Union.IFollowTrackEndType:
				return IFollowTrackEndType.Pack(builder, _o.AsIFollowTrackEndType()).Value;
			case IFollowTrackEndType_Union.IFollowTrackToStart:
				return IFollowTrackToStart.Pack(builder, _o.AsIFollowTrackToStart()).Value;
			case IFollowTrackEndType_Union.IFollowTrackToFoundation:
				return IFollowTrackToFoundation.Pack(builder, _o.AsIFollowTrackToFoundation()).Value;
			case IFollowTrackEndType_Union.IFollowTrackToSplineDestination:
				return IFollowTrackToSplineDestination.Pack(builder, _o.AsIFollowTrackToSplineDestination()).Value;
			default:
				return 0;
			}
		}
	}
}
