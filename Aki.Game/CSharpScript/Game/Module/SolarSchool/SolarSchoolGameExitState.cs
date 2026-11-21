using System;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058F6 RID: 22774
	public class SolarSchoolGameExitState : ActivityGameplayTurnStateBase<ESolarSchoolStageStateType>
	{
		// Token: 0x0603825B RID: 229979 RVA: 0x00FB235C File Offset: 0x00FB055C
		public override void Enter(ESolarSchoolStageStateType? prev)
		{
			Log.Instance.Info(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] GameExit", default(ReadOnlySpan<ValueTuple<string, object>>));
			SolarSchoolVisualNovelEntry.StopCurrent();
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (!instance.IsForceExiting && prev != null)
			{
				SolarSchoolModel.Instance.OpenExitLoadingView();
			}
			instance.RemoveGameplayAudioEvents();
			instance.ClearGameplayAudioState();
			instance.RemoveGameplayAudioFilter();
			instance.StopGameplayBgm();
		}

		// Token: 0x0603825C RID: 229980 RVA: 0x00FB23C8 File Offset: 0x00FB05C8
		public override UniTask EnterAsync(ESolarSchoolStageStateType? prev)
		{
			SolarSchoolGameExitState.<EnterAsync>d__1 <EnterAsync>d__;
			<EnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterAsync>d__.<>1__state = -1;
			<EnterAsync>d__.<>t__builder.Start<SolarSchoolGameExitState.<EnterAsync>d__1>(ref <EnterAsync>d__);
			return <EnterAsync>d__.<>t__builder.Task;
		}
	}
}
