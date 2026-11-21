using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200636F RID: 25455
	public interface IPlayerFollowerItemInfo
	{
		// Token: 0x1700750D RID: 29965
		// (get) Token: 0x0603DACB RID: 252619
		// (set) Token: 0x0603DACC RID: 252620
		int Type { get; set; }

		// Token: 0x1700750E RID: 29966
		// (get) Token: 0x0603DACD RID: 252621
		// (set) Token: 0x0603DACE RID: 252622
		long EntityId { get; set; }
	}
}
