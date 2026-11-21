using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581B RID: 22555
	public class IFollowTrackEndType_UnionUnion
	{
		// Token: 0x1700A342 RID: 41794
		// (get) Token: 0x060247EB RID: 149483 RVA: 0x00503B05 File Offset: 0x00501D05
		// (set) Token: 0x060247EC RID: 149484 RVA: 0x00503B0D File Offset: 0x00501D0D
		public IFollowTrackEndType_Union Type { get; set; }

		// Token: 0x1700A343 RID: 41795
		// (get) Token: 0x060247ED RID: 149485 RVA: 0x00503B16 File Offset: 0x00501D16
		// (set) Token: 0x060247EE RID: 149486 RVA: 0x00503B1E File Offset: 0x00501D1E
		public object Value { get; set; }

		// Token: 0x060247EF RID: 149487 RVA: 0x00503B27 File Offset: 0x00501D27
		public IFollowTrackEndType_UnionUnion()
		{
			this.Type = IFollowTrackEndType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060247F0 RID: 149488 RVA: 0x00503B3D File Offset: 0x00501D3D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060247F1 RID: 149489 RVA: 0x00503B4F File Offset: 0x00501D4F
		public IFollowTrackEndTypeT AsIFollowTrackEndType()
		{
			return this.As<IFollowTrackEndTypeT>();
		}

		// Token: 0x060247F2 RID: 149490 RVA: 0x00503B57 File Offset: 0x00501D57
		public static IFollowTrackEndType_UnionUnion FromIFollowTrackEndType(IFollowTrackEndTypeT _ifollowtrackendtype)
		{
			return new IFollowTrackEndType_UnionUnion
			{
				Type = IFollowTrackEndType_Union.IFollowTrackEndType,
				Value = _ifollowtrackendtype
			};
		}

		// Token: 0x060247F3 RID: 149491 RVA: 0x00503B6C File Offset: 0x00501D6C
		public IFollowTrackToStartT AsIFollowTrackToStart()
		{
			return this.As<IFollowTrackToStartT>();
		}

		// Token: 0x060247F4 RID: 149492 RVA: 0x00503B74 File Offset: 0x00501D74
		public static IFollowTrackEndType_UnionUnion FromIFollowTrackToStart(IFollowTrackToStartT _ifollowtracktostart)
		{
			return new IFollowTrackEndType_UnionUnion
			{
				Type = IFollowTrackEndType_Union.IFollowTrackToStart,
				Value = _ifollowtracktostart
			};
		}

		// Token: 0x060247F5 RID: 149493 RVA: 0x00503B89 File Offset: 0x00501D89
		public IFollowTrackToFoundationT AsIFollowTrackToFoundation()
		{
			return this.As<IFollowTrackToFoundationT>();
		}

		// Token: 0x060247F6 RID: 149494 RVA: 0x00503B91 File Offset: 0x00501D91
		public static IFollowTrackEndType_UnionUnion FromIFollowTrackToFoundation(IFollowTrackToFoundationT _ifollowtracktofoundation)
		{
			return new IFollowTrackEndType_UnionUnion
			{
				Type = IFollowTrackEndType_Union.IFollowTrackToFoundation,
				Value = _ifollowtracktofoundation
			};
		}

		// Token: 0x060247F7 RID: 149495 RVA: 0x00503BA6 File Offset: 0x00501DA6
		public IFollowTrackToSplineDestinationT AsIFollowTrackToSplineDestination()
		{
			return this.As<IFollowTrackToSplineDestinationT>();
		}

		// Token: 0x060247F8 RID: 149496 RVA: 0x00503BAE File Offset: 0x00501DAE
		public static IFollowTrackEndType_UnionUnion FromIFollowTrackToSplineDestination(IFollowTrackToSplineDestinationT _ifollowtracktosplinedestination)
		{
			return new IFollowTrackEndType_UnionUnion
			{
				Type = IFollowTrackEndType_Union.IFollowTrackToSplineDestination,
				Value = _ifollowtracktosplinedestination
			};
		}

		// Token: 0x060247F9 RID: 149497 RVA: 0x00503BC4 File Offset: 0x00501DC4
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
