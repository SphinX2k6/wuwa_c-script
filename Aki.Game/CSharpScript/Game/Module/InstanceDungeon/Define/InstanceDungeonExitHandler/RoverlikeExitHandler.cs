using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048D3 RID: 18643
	public class RoverlikeExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC62 RID: 191586 RVA: 0x00D0B464 File Offset: 0x00D09664
		public override bool Checker()
		{
			return RoverlikeController.Instance.CheckInRoverlike();
		}

		// Token: 0x0602EC63 RID: 191587 RVA: 0x00D0B470 File Offset: 0x00D09670
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikePauseView, null, null);
		}
	}
}
