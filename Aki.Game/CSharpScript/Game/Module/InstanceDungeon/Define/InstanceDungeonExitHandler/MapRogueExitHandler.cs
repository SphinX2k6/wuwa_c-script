using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MapRogue;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048CC RID: 18636
	public class MapRogueExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC49 RID: 191561 RVA: 0x00D0AF58 File Offset: 0x00D09158
		public override bool Checker()
		{
			return MapRogueController.Instance.CheckInMapRogueInstance();
		}

		// Token: 0x0602EC4A RID: 191562 RVA: 0x00D0AF64 File Offset: 0x00D09164
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			MapRogueController.Instance.OpenExploreEnd(true);
		}
	}
}
