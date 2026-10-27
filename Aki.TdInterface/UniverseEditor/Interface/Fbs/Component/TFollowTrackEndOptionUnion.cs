using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C25 RID: 23589
	public class TFollowTrackEndOptionUnion
	{
		// Token: 0x1700B1F6 RID: 45558
		// (get) Token: 0x06028739 RID: 165689 RVA: 0x00591106 File Offset: 0x0058F306
		// (set) Token: 0x0602873A RID: 165690 RVA: 0x0059110E File Offset: 0x0058F30E
		public TFollowTrackEndOption Type { get; set; }

		// Token: 0x1700B1F7 RID: 45559
		// (get) Token: 0x0602873B RID: 165691 RVA: 0x00591117 File Offset: 0x0058F317
		// (set) Token: 0x0602873C RID: 165692 RVA: 0x0059111F File Offset: 0x0058F31F
		public object Value { get; set; }

		// Token: 0x0602873D RID: 165693 RVA: 0x00591128 File Offset: 0x0058F328
		public TFollowTrackEndOptionUnion()
		{
			this.Type = TFollowTrackEndOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602873E RID: 165694 RVA: 0x0059113E File Offset: 0x0058F33E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602873F RID: 165695 RVA: 0x00591150 File Offset: 0x0058F350
		public IFollowTrackToFoundationT AsIFollowTrackToFoundation()
		{
			return this.As<IFollowTrackToFoundationT>();
		}

		// Token: 0x06028740 RID: 165696 RVA: 0x00591158 File Offset: 0x0058F358
		public static TFollowTrackEndOptionUnion FromIFollowTrackToFoundation(IFollowTrackToFoundationT _ifollowtracktofoundation)
		{
			return new TFollowTrackEndOptionUnion
			{
				Type = TFollowTrackEndOption.IFollowTrackToFoundation,
				Value = _ifollowtracktofoundation
			};
		}

		// Token: 0x06028741 RID: 165697 RVA: 0x0059116D File Offset: 0x0058F36D
		public IFollowTrackToSplineDestinationT AsIFollowTrackToSplineDestination()
		{
			return this.As<IFollowTrackToSplineDestinationT>();
		}

		// Token: 0x06028742 RID: 165698 RVA: 0x00591175 File Offset: 0x0058F375
		public static TFollowTrackEndOptionUnion FromIFollowTrackToSplineDestination(IFollowTrackToSplineDestinationT _ifollowtracktosplinedestination)
		{
			return new TFollowTrackEndOptionUnion
			{
				Type = TFollowTrackEndOption.IFollowTrackToSplineDestination,
				Value = _ifollowtracktosplinedestination
			};
		}

		// Token: 0x06028743 RID: 165699 RVA: 0x0059118A File Offset: 0x0058F38A
		public IFollowTrackToStartT AsIFollowTrackToStart()
		{
			return this.As<IFollowTrackToStartT>();
		}

		// Token: 0x06028744 RID: 165700 RVA: 0x00591192 File Offset: 0x0058F392
		public static TFollowTrackEndOptionUnion FromIFollowTrackToStart(IFollowTrackToStartT _ifollowtracktostart)
		{
			return new TFollowTrackEndOptionUnion
			{
				Type = TFollowTrackEndOption.IFollowTrackToStart,
				Value = _ifollowtracktostart
			};
		}

		// Token: 0x06028745 RID: 165701 RVA: 0x005911A8 File Offset: 0x0058F3A8
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
