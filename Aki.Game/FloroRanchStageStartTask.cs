using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001B4F RID: 6991
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchStageStartTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600CF69 RID: 53097 RVA: 0x002F4087 File Offset: 0x002F2287
	public FloroRanchStageStartTask(FloroRanchStageStart data)
	{
		this.StageStartData = data;
	}

	// Token: 0x0600CF6A RID: 53098 RVA: 0x002F4098 File Offset: 0x002F2298
	protected override void OnExecute()
	{
		FloroRanchGamePlayModel.Instance.OnStageStart(this.StageStartData);
		EventSystem.Instance.Emit<bool>(EEventName.OnFloroRanchStageStartTaskBeforeFinish, false);
		UiManager.Instance.OpenView(EUiViewName.FloroRanchPhaseTargetView, new FloroRanchPhaseTargetViewParam
		{
			StageStartData = this.StageStartData,
			CloseCallback = delegate()
			{
				FloroRanchStageStartTask.<<OnExecute>b__2_0>d <<OnExecute>b__2_0>d;
				<<OnExecute>b__2_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnExecute>b__2_0>d.<>4__this = this;
				<<OnExecute>b__2_0>d.<>1__state = -1;
				<<OnExecute>b__2_0>d.<>t__builder.Start<FloroRanchStageStartTask.<<OnExecute>b__2_0>d>(ref <<OnExecute>b__2_0>d);
				return <<OnExecute>b__2_0>d.<>t__builder.Task;
			}
		}, null);
	}

	// Token: 0x04005F6A RID: 24426
	private readonly FloroRanchStageStart StageStartData;
}
