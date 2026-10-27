using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MapRogue;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058F4 RID: 22772
	public class MapRogueExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D26 RID: 236838 RVA: 0x00DBBFF4 File Offset: 0x00DBA1F4
		public override bool Checker()
		{
			return MapRogueController.Instance.CheckInMapRogueInstance();
		}

		// Token: 0x06039D27 RID: 236839 RVA: 0x00DBC000 File Offset: 0x00DBA200
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			MapRogueController.Instance.OpenExploreEnd(true);
		}
	}
}
