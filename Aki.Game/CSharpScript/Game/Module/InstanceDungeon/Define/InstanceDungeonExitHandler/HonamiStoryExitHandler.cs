using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048C4 RID: 18628
	public class HonamiStoryExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC32 RID: 191538 RVA: 0x00D0A8DA File Offset: 0x00D08ADA
		public override bool Checker()
		{
			return HonamiStoryUtil.CheckInHonamiStoryDungeon();
		}

		// Token: 0x0602EC33 RID: 191539 RVA: 0x00D0A8E1 File Offset: 0x00D08AE1
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			HonamiStoryController.Instance.TryHonamiStoryInstLeave(false);
		}
	}
}
