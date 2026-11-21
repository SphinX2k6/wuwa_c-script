using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x020013B4 RID: 5044
public class HonamiStorySmallLoadingView : UiViewBase
{
	// Token: 0x0600C7F2 RID: 51186 RVA: 0x003B8435 File Offset: 0x003B6635
	[NullableContext(1)]
	public HonamiStorySmallLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C7F3 RID: 51187 RVA: 0x003B8440 File Offset: 0x003B6640
	protected override void OnStart()
	{
		bool needOpenMainView = this.OpenParam != null;
		int? viewId = null;
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			Action<int?> <>9__2;
			TTimerAction <>9__3;
			uiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				if (needOpenMainView)
				{
					UniTask<int?> task = UiManager.Instance.OpenViewAsync(EUiViewName.HonamiStoryMainView, this.OpenParam, null);
					Action<int?> continuationFunction;
					if ((continuationFunction = <>9__2) == null)
					{
						continuationFunction = (<>9__2 = delegate(int? id)
						{
							if (id != null)
							{
								viewId = id;
							}
							this.CloseMe(null);
						});
					}
					task.ContinueWith(continuationFunction);
					return;
				}
				TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
				TTimerAction action;
				if ((action = <>9__3) == null)
				{
					action = (<>9__3 = delegate(float _)
					{
						this.CloseMe(null);
					});
				}
				gameplayTimeInstance.Next(action, null, null);
			}, false);
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 == null)
		{
			return;
		}
		uiViewSequence2.AddSequenceFinishEvent("Close", delegate(string _)
		{
			if (viewId != null)
			{
				UiViewBase view = UiManager.Instance.GetView(viewId.Value);
				if (view != null)
				{
					((HonamiStoryMainView)view).RefreshSpecialButtonsStates();
				}
			}
		}, false);
	}
}
