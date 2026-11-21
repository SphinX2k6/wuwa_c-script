using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048CD RID: 18637
	public class MotorFightExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC4C RID: 191564 RVA: 0x00D0AF7C File Offset: 0x00D0917C
		public override bool Checker()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 44;
		}

		// Token: 0x0602EC4D RID: 191565 RVA: 0x00D0AFCD File Offset: 0x00D091CD
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightPauseView, null, null);
		}
	}
}
