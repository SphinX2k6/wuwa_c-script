using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058F0 RID: 22768
	public class KurotatoExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D17 RID: 236823 RVA: 0x00DBBB48 File Offset: 0x00DB9D48
		public override bool Checker()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 51;
		}

		// Token: 0x06039D18 RID: 236824 RVA: 0x00DBBB99 File Offset: 0x00DB9D99
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoPauseView, null, null);
		}
	}
}
