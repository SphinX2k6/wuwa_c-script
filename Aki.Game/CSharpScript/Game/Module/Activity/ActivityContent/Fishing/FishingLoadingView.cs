using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200660D RID: 26125
	public class FishingLoadingView : UiViewBase
	{
		// Token: 0x0604178F RID: 268175 RVA: 0x00FDB3E5 File Offset: 0x00FD95E5
		[NullableContext(1)]
		public FishingLoadingView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06041790 RID: 268176 RVA: 0x00FDB3F0 File Offset: 0x00FD95F0
		protected override void OnStart()
		{
			bool needOpenDock = (bool)this.OpenParam;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			TOpenViewCallBack <>9__1;
			TTimerAction <>9__2;
			uiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				if (needOpenDock)
				{
					UiManager instance = UiManager.Instance;
					EUiViewName fishingDockView = EUiViewName.FishingDockView;
					object param = null;
					TOpenViewCallBack finishCallback;
					if ((finishCallback = <>9__1) == null)
					{
						finishCallback = (<>9__1 = delegate(bool _, int _)
						{
							this.CloseMe(null);
						});
					}
					instance.OpenView(fishingDockView, param, finishCallback);
					return;
				}
				TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
				TTimerAction action;
				if ((action = <>9__2) == null)
				{
					action = (<>9__2 = delegate(float _)
					{
						this.CloseMe(null);
					});
				}
				gameplayTimeInstance.Next(action, null, null);
			}, false);
		}
	}
}
