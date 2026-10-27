using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058E5 RID: 22757
	public class AdamSmasherExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039CFA RID: 236794 RVA: 0x00DBB613 File Offset: 0x00DB9813
		public override bool Checker()
		{
			return AdamSmasherController.Instance.IsInAdamSmasherDungeon();
		}

		// Token: 0x06039CFB RID: 236795 RVA: 0x00DBB620 File Offset: 0x00DB9820
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CyberPunkExitChallengeViewConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Forget<bool>();
			};
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				InstanceDungeonEntranceController.Instance.EnterEntrance(6090, 0, null).Forget<bool>();
			};
			confirmBoxDataNew.FunctionMap[0] = delegate()
			{
				InstanceDungeonExitHandlerData data2 = data;
				if (data2 == null)
				{
					return;
				}
				Action cancelBack = data2.CancelBack;
				if (cancelBack == null)
				{
					return;
				}
				cancelBack();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}
}
