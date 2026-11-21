using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B52 RID: 15186
	public class SkipTaskCyberPunkAdamSmasher : SkipTask
	{
		// Token: 0x06027060 RID: 159840 RVA: 0x00AECA88 File Offset: 0x00AEAC88
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				base.Finish();
				return;
			}
			if (CyberPunkConfig.Instance.GetEdgeRunnerUnlockConfigById(5) == null)
			{
				base.Finish();
				return;
			}
			if (currentActivityData.IsFunctionUnlocked(5))
			{
				InstanceDungeonEntranceController.Instance.EnterEntrance(6090, 0, null).Forget<bool>();
			}
			else
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("AdamChallengeBlockTip", Array.Empty<object>());
			}
			base.Finish();
		}

		// Token: 0x040154D8 RID: 87256
		private const int BOSS_ENTRANCE_ID = 5;
	}
}
