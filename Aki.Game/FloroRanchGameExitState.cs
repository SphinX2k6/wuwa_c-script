using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001B53 RID: 6995
public class FloroRanchGameExitState : FloroRanchStateBase
{
	// Token: 0x0600CF90 RID: 53136 RVA: 0x002F4722 File Offset: 0x002F2922
	[NullableContext(1)]
	public FloroRanchGameExitState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600CF91 RID: 53137 RVA: 0x002F472C File Offset: 0x002F292C
	protected override void OnEnter()
	{
		if (FloroRanchGamePlayModel.Instance.NeedReStart)
		{
			BlackScreenController.Instance.AddBlackScreenAsync("Start", "FloroRanch Restart", "Black", "Default").ContinueWith(delegate()
			{
				this.CloseView();
			}).Forget();
			return;
		}
		this.CloseView();
	}

	// Token: 0x0600CF92 RID: 53138 RVA: 0x002F4780 File Offset: 0x002F2980
	private void CloseView()
	{
		int activityId = FloroRanchGamePlayModel.Instance.ActivityId;
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		List<int> races = new List<int>(FloroRanchGamePlayModel.Instance.Races);
		int skillId = FloroRanchGamePlayModel.Instance.SkillId;
		bool needReStart = FloroRanchGamePlayModel.Instance.NeedReStart;
		bool needSettle = FloroRanchGamePlayModel.Instance.NeedSettle;
		UiManager.Instance.CloseView(EUiViewName.FloroRanchGamePlayView, delegate(bool _)
		{
			FloroRanchEntityActionSystem.Exit();
			if (needReStart)
			{
				FloroRanchGamePlayModel.Instance.GameEnd();
				FloroRanchController.Instance.SendFloroRanchReStartRequest(activityId, subInstanceId, races.ToArray(), skillId).ContinueWith(delegate()
				{
					BlackScreenController.Instance.RemoveBlackScreen("Close", "FloroRanch Restart", "Default");
				}).Forget();
				return;
			}
			if (needSettle)
			{
				FloroRanchController.Instance.SendFloroRanchSettleRequest(activityId, subInstanceId, true, delegate(FloroRanchSettleResponse _)
				{
				});
				return;
			}
			FloroRanchGamePlayModel.Instance.GameEnd();
		});
	}
}
