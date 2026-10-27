using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001EF2 RID: 7922
public class HonamiStorySmallLoadingView : UiViewBase
{
	// Token: 0x0600F3D3 RID: 62419 RVA: 0x003AC939 File Offset: 0x003AAB39
	[NullableContext(1)]
	public HonamiStorySmallLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F3D4 RID: 62420 RVA: 0x003AC944 File Offset: 0x003AAB44
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
