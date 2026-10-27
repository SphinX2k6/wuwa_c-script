using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058EC RID: 22764
	public class HonamiStoryExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D0F RID: 236815 RVA: 0x00DBB982 File Offset: 0x00DB9B82
		public override bool Checker()
		{
			return HonamiStoryUtil.CheckInHonamiStoryDungeon();
		}

		// Token: 0x06039D10 RID: 236816 RVA: 0x00DBB989 File Offset: 0x00DB9B89
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			HonamiStoryController.Instance.TryHonamiStoryInstLeave(false);
		}
	}
}
