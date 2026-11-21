using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001012 RID: 4114
public class FloroRanchGameExitState : FloroRanchStateBase
{
	// Token: 0x0600A3A1 RID: 41889 RVA: 0x002FF7FA File Offset: 0x002FD9FA
	[NullableContext(1)]
	public FloroRanchGameExitState(FloroRanchStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x0600A3A2 RID: 41890 RVA: 0x002FF804 File Offset: 0x002FDA04
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

	// Token: 0x0600A3A3 RID: 41891 RVA: 0x002FF858 File Offset: 0x002FDA58
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
