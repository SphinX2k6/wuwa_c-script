using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02002F8F RID: 12175
	[NullableContext(1)]
	public interface IChairPresentationHost
	{
		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x0601CDE3 RID: 118243
		int OwnerPlayerId { get; }

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x0601CDE4 RID: 118244
		// (set) Token: 0x0601CDE5 RID: 118245
		long ChairCreatureDataId { get; set; }

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x0601CDE6 RID: 118246
		// (set) Token: 0x0601CDE7 RID: 118247
		bool IsChairShown { get; set; }

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x0601CDE8 RID: 118248
		// (set) Token: 0x0601CDE9 RID: 118249
		Func<bool> IsLocalOwner { get; set; }

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x0601CDEA RID: 118250
		// (set) Token: 0x0601CDEB RID: 118251
		Action<Entity, EChairPerformanceState> ChangeChairPerformanceState { get; set; }

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x0601CDEC RID: 118252
		// (set) Token: 0x0601CDED RID: 118253
		Action<Entity, bool> SetChairPerformanceControlledExternally { get; set; }

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x0601CDEE RID: 118254
		// (set) Token: 0x0601CDEF RID: 118255
		Action CleanupCurrentChair { get; set; }
	}
}
