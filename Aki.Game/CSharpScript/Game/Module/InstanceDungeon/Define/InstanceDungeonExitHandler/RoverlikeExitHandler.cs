using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058FA RID: 22778
	public class RoverlikeExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D3C RID: 236860 RVA: 0x00DBC498 File Offset: 0x00DBA698
		public override bool Checker()
		{
			return RoverlikeController.Instance.CheckInRoverlike();
		}

		// Token: 0x06039D3D RID: 236861 RVA: 0x00DBC4A4 File Offset: 0x00DBA6A4
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikePauseView, null, null);
		}
	}
}
