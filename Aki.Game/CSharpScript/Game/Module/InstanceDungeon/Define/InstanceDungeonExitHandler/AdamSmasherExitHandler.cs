using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048BD RID: 18621
	public class AdamSmasherExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC1D RID: 191517 RVA: 0x00D0A56B File Offset: 0x00D0876B
		public override bool Checker()
		{
			return AdamSmasherController.Instance.IsInAdamSmasherDungeon();
		}

		// Token: 0x0602EC1E RID: 191518 RVA: 0x00D0A578 File Offset: 0x00D08778
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CyberPunkExitChallengeViewConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
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
