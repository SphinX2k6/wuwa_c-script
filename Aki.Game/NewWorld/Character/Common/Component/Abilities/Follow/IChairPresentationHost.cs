using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x020044BD RID: 17597
	[NullableContext(1)]
	public interface IChairPresentationHost
	{
		// Token: 0x17007388 RID: 29576
		// (get) Token: 0x0602D5BD RID: 185789
		int OwnerPlayerId { get; }

		// Token: 0x17007389 RID: 29577
		// (get) Token: 0x0602D5BE RID: 185790
		// (set) Token: 0x0602D5BF RID: 185791
		long ChairCreatureDataId { get; set; }

		// Token: 0x1700738A RID: 29578
		// (get) Token: 0x0602D5C0 RID: 185792
		// (set) Token: 0x0602D5C1 RID: 185793
		bool IsChairShown { get; set; }

		// Token: 0x1700738B RID: 29579
		// (get) Token: 0x0602D5C2 RID: 185794
		// (set) Token: 0x0602D5C3 RID: 185795
		Func<bool> IsLocalOwner { get; set; }

		// Token: 0x1700738C RID: 29580
		// (get) Token: 0x0602D5C4 RID: 185796
		// (set) Token: 0x0602D5C5 RID: 185797
		Action<Entity, EChairPerformanceState> ChangeChairPerformanceState { get; set; }

		// Token: 0x1700738D RID: 29581
		// (get) Token: 0x0602D5C6 RID: 185798
		// (set) Token: 0x0602D5C7 RID: 185799
		Action<Entity, bool> SetChairPerformanceControlledExternally { get; set; }

		// Token: 0x1700738E RID: 29582
		// (get) Token: 0x0602D5C8 RID: 185800
		// (set) Token: 0x0602D5C9 RID: 185801
		Action CleanupCurrentChair { get; set; }
	}
}
