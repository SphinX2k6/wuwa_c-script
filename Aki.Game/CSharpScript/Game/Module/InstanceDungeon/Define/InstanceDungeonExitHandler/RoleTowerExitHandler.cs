using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048D1 RID: 18641
	public class RoleTowerExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC5B RID: 191579 RVA: 0x00D0B27C File Offset: 0x00D0947C
		public override bool Checker()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 67;
		}

		// Token: 0x0602EC5C RID: 191580 RVA: 0x00D0B2CD File Offset: 0x00D094CD
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			RoleTowerModel.Instance.OpenPauseView();
		}
	}
}
