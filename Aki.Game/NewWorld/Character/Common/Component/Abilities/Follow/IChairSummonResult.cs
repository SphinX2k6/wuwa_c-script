using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x020044BF RID: 17599
	[NullableContext(1)]
	public interface IChairSummonResult
	{
		// Token: 0x1700738F RID: 29583
		// (get) Token: 0x0602D5E0 RID: 185824
		// (set) Token: 0x0602D5E1 RID: 185825
		bool Success { get; set; }

		// Token: 0x17007390 RID: 29584
		// (get) Token: 0x0602D5E2 RID: 185826
		// (set) Token: 0x0602D5E3 RID: 185827
		string FailReason { get; set; }

		// Token: 0x17007391 RID: 29585
		// (get) Token: 0x0602D5E4 RID: 185828
		// (set) Token: 0x0602D5E5 RID: 185829
		Vector FinalLocation { get; set; }

		// Token: 0x17007392 RID: 29586
		// (get) Token: 0x0602D5E6 RID: 185830
		// (set) Token: 0x0602D5E7 RID: 185831
		float Yaw { get; set; }

		// Token: 0x17007393 RID: 29587
		// (get) Token: 0x0602D5E8 RID: 185832
		// (set) Token: 0x0602D5E9 RID: 185833
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		List<ValueTuple<Vector, Vector>> DownRayLines { [return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] set; }
	}
}
