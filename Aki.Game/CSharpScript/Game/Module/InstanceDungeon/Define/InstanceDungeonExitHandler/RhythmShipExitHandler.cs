using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048CF RID: 18639
	public class RhythmShipExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC52 RID: 191570 RVA: 0x00D0B0D4 File Offset: 0x00D092D4
		public override bool Checker()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 53;
		}

		// Token: 0x0602EC53 RID: 191571 RVA: 0x00D0B125 File Offset: 0x00D09325
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipPauseView, null, null);
		}
	}
}
