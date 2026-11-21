using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006244 RID: 25156
	public class TFollowTrackEndOptionUnion
	{
		// Token: 0x1700BB44 RID: 47940
		// (get) Token: 0x0602AD2B RID: 175403 RVA: 0x005D9096 File Offset: 0x005D7296
		// (set) Token: 0x0602AD2C RID: 175404 RVA: 0x005D909E File Offset: 0x005D729E
		public TFollowTrackEndOption Type { get; set; }

		// Token: 0x1700BB45 RID: 47941
		// (get) Token: 0x0602AD2D RID: 175405 RVA: 0x005D90A7 File Offset: 0x005D72A7
		// (set) Token: 0x0602AD2E RID: 175406 RVA: 0x005D90AF File Offset: 0x005D72AF
		public object Value { get; set; }

		// Token: 0x0602AD2F RID: 175407 RVA: 0x005D90B8 File Offset: 0x005D72B8
		public TFollowTrackEndOptionUnion()
		{
			this.Type = TFollowTrackEndOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD30 RID: 175408 RVA: 0x005D90CE File Offset: 0x005D72CE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD31 RID: 175409 RVA: 0x005D90E0 File Offset: 0x005D72E0
		public IFollowTrackToFoundationT AsIFollowTrackToFoundation()
		{
			return this.As<IFollowTrackToFoundationT>();
		}

		// Token: 0x0602AD32 RID: 175410 RVA: 0x005D90E8 File Offset: 0x005D72E8
		public static TFollowTrackEndOptionUnion FromIFollowTrackToFoundation(IFollowTrackToFoundationT _ifollowtracktofoundation)
		{
			return new TFollowTrackEndOptionUnion
			{
				Type = TFollowTrackEndOption.IFollowTrackToFoundation,
				Value = _ifollowtracktofoundation
			};
		}

		// Token: 0x0602AD33 RID: 175411 RVA: 0x005D90FD File Offset: 0x005D72FD
		public IFollowTrackToSplineDestinationT AsIFollowTrackToSplineDestination()
		{
			return this.As<IFollowTrackToSplineDestinationT>();
		}

		// Token: 0x0602AD34 RID: 175412 RVA: 0x005D9105 File Offset: 0x005D7305
		public static TFollowTrackEndOptionUnion FromIFollowTrackToSplineDestination(IFollowTrackToSplineDestinationT _ifollowtracktosplinedestination)
		{
			return new TFollowTrackEndOptionUnion
			{
				Type = TFollowTrackEndOption.IFollowTrackToSplineDestination,
				Value = _ifollowtracktosplinedestination
			};
		}

		// Token: 0x0602AD35 RID: 175413 RVA: 0x005D911A File Offset: 0x005D731A
		public IFollowTrackToStartT AsIFollowTrackToStart()
		{
			return this.As<IFollowTrackToStartT>();
		}

		// Token: 0x0602AD36 RID: 175414 RVA: 0x005D9122 File Offset: 0x005D7322
		public static TFollowTrackEndOptionUnion FromIFollowTrackToStart(IFollowTrackToStartT _ifollowtracktostart)
		{
			return new TFollowTrackEndOptionUnion
			{
				Type = TFollowTrackEndOption.IFollowTrackToStart,
				Value = _ifollowtracktostart
			};
		}

		// Token: 0x0602AD37 RID: 175415 RVA: 0x005D9138 File Offset: 0x005D7338
		public static int Pack(FlatBufferBuilder builder, TFollowTrackEndOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TFollowTrackEndOption.IFollowTrackToFoundation:
				return IFollowTrackToFoundation.Pack(builder, _o.AsIFollowTrackToFoundation()).Value;
			case TFollowTrackEndOption.IFollowTrackToSplineDestination:
				return IFollowTrackToSplineDestination.Pack(builder, _o.AsIFollowTrackToSplineDestination()).Value;
			case TFollowTrackEndOption.IFollowTrackToStart:
				return IFollowTrackToStart.Pack(builder, _o.AsIFollowTrackToStart()).Value;
			default:
				return 0;
			}
		}
	}
}
