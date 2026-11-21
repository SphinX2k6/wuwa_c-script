using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058F7 RID: 22775
	public class SolarSchoolGameStartState : ActivityGameplayTurnStateBase<ESolarSchoolStageStateType>
	{
		// Token: 0x0603825E RID: 229982 RVA: 0x00FB240C File Offset: 0x00FB060C
		public override void Enter(ESolarSchoolStageStateType? prev)
		{
			Log.Instance.Info(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] GameStart 进入，开始第一天", default(ReadOnlySpan<ValueTuple<string, object>>));
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			instance.InitGameplayAudioState();
			instance.AddGameplayAudioEvents();
			instance.PushGameplayAudioFilter();
			instance.PlayGameplayBgm();
			this.OpenRootViewThenStartDay().Forget();
		}

		// Token: 0x0603825F RID: 229983 RVA: 0x00FB2460 File Offset: 0x00FB0660
		private UniTask OpenRootViewThenStartDay()
		{
			SolarSchoolGameStartState.<OpenRootViewThenStartDay>d__1 <OpenRootViewThenStartDay>d__;
			<OpenRootViewThenStartDay>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenRootViewThenStartDay>d__.<>4__this = this;
			<OpenRootViewThenStartDay>d__.<>1__state = -1;
			<OpenRootViewThenStartDay>d__.<>t__builder.Start<SolarSchoolGameStartState.<OpenRootViewThenStartDay>d__1>(ref <OpenRootViewThenStartDay>d__);
			return <OpenRootViewThenStartDay>d__.<>t__builder.Task;
		}

		// Token: 0x06038260 RID: 229984 RVA: 0x00FB24A4 File Offset: 0x00FB06A4
		[NullableContext(1)]
		private bool IsExitedWithoutNewGame(SolarSchoolGamePlayModel model)
		{
			ESolarSchoolStageStateType currentStateType = model.GetCurrentStateType();
			return currentStateType == ESolarSchoolStageStateType.None || currentStateType == ESolarSchoolStageStateType.GameExit;
		}
	}
}
