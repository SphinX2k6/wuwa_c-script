using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.MovieMode;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B28 RID: 27432
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventExitMovieMode : LevelEventBase
	{
		// Token: 0x060440FF RID: 278783 RVA: 0x010BC1E6 File Offset: 0x010BA3E6
		public LevelEventExitMovieMode(int id) : base(id)
		{
		}

		// Token: 0x06044100 RID: 278784 RVA: 0x010BC1F0 File Offset: 0x010BA3F0
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ExitMovieMode exitMovieMode = inParams as ExitMovieMode;
			ExitMovieModeParams exitMovieModeParams = new ExitMovieModeParams();
			exitMovieModeParams.BlendTime = (exitMovieMode.BorderAnimDuration ?? ((float)ConfigCommonParamById.GetIntConfig("ExitMovieModeTimeThreshold").GetValueOrDefault(1)));
			IMovieModeFadeOutMaskConfig fadeOutMaskConfig = exitMovieMode.FadeOutMaskConfig;
			exitMovieModeParams.BlackFadeInTime = ((fadeOutMaskConfig != null) ? fadeOutMaskConfig.TransitionTime : null);
			ExitMovieModeParams @params = exitMovieModeParams;
			this.ExecuteExitMovieMode(@params, exitMovieMode.DurationType);
		}

		// Token: 0x06044101 RID: 278785 RVA: 0x010BC26C File Offset: 0x010BA46C
		private UniTask ExecuteExitMovieMode(ExitMovieModeParams @params, [Nullable(2)] IEnterMovieModeDurationType durationType)
		{
			LevelEventExitMovieMode.<ExecuteExitMovieMode>d__2 <ExecuteExitMovieMode>d__;
			<ExecuteExitMovieMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteExitMovieMode>d__.<>4__this = this;
			<ExecuteExitMovieMode>d__.@params = @params;
			<ExecuteExitMovieMode>d__.durationType = durationType;
			<ExecuteExitMovieMode>d__.<>1__state = -1;
			<ExecuteExitMovieMode>d__.<>t__builder.Start<LevelEventExitMovieMode.<ExecuteExitMovieMode>d__2>(ref <ExecuteExitMovieMode>d__);
			return <ExecuteExitMovieMode>d__.<>t__builder.Task;
		}

		// Token: 0x06044102 RID: 278786 RVA: 0x010BC2BF File Offset: 0x010BA4BF
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044103 RID: 278787 RVA: 0x010BC2CC File Offset: 0x010BA4CC
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.ActionExitMovieMode
			};
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, this.Type, this.BaseContext, p, null);
		}
	}
}
