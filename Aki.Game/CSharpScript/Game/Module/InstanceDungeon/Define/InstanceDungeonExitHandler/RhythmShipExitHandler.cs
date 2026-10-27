using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058F7 RID: 22775
	public class RhythmShipExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D2F RID: 236847 RVA: 0x00DBC170 File Offset: 0x00DBA370
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

		// Token: 0x06039D30 RID: 236848 RVA: 0x00DBC1C1 File Offset: 0x00DBA3C1
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipPauseView, null, null);
		}
	}
}
