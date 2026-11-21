using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048C8 RID: 18632
	public class KurotatoExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC3A RID: 191546 RVA: 0x00D0AAAC File Offset: 0x00D08CAC
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

		// Token: 0x0602EC3B RID: 191547 RVA: 0x00D0AAFD File Offset: 0x00D08CFD
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoPauseView, null, null);
		}
	}
}
