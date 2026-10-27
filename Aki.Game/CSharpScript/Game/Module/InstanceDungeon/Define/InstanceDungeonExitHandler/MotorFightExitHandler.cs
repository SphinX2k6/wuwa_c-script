using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058F5 RID: 22773
	public class MotorFightExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D29 RID: 236841 RVA: 0x00DBC018 File Offset: 0x00DBA218
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

		// Token: 0x06039D2A RID: 236842 RVA: 0x00DBC069 File Offset: 0x00DBA269
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightPauseView, null, null);
		}
	}
}
