using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02002F91 RID: 12177
	[NullableContext(1)]
	public interface IChairSummonResult
	{
		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x0601CE06 RID: 118278
		// (set) Token: 0x0601CE07 RID: 118279
		bool Success { get; set; }

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0601CE08 RID: 118280
		// (set) Token: 0x0601CE09 RID: 118281
		string FailReason { get; set; }

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x0601CE0A RID: 118282
		// (set) Token: 0x0601CE0B RID: 118283
		Vector FinalLocation { get; set; }

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0601CE0C RID: 118284
		// (set) Token: 0x0601CE0D RID: 118285
		float Yaw { get; set; }

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x0601CE0E RID: 118286
		// (set) Token: 0x0601CE0F RID: 118287
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
