using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BA8 RID: 19368
	public class SkipTaskCyberPunkAdamSmasher : SkipTask
	{
		// Token: 0x060322CF RID: 205519 RVA: 0x00BA8814 File Offset: 0x00BA6A14
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

		// Token: 0x0401AB83 RID: 109443
		private const int BOSS_ENTRANCE_ID = 5;
	}
}
