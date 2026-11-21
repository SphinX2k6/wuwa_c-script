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
	// Token: 0x02005CA0 RID: 23712
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventExitMovieMode : LevelEventBase
	{
		// Token: 0x0603A251 RID: 238161 RVA: 0x01065A72 File Offset: 0x01063C72
		public LevelEventExitMovieMode(int id) : base(id)
		{
		}

		// Token: 0x0603A252 RID: 238162 RVA: 0x01065A7C File Offset: 0x01063C7C
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

		// Token: 0x0603A253 RID: 238163 RVA: 0x01065AF8 File Offset: 0x01063CF8
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

		// Token: 0x0603A254 RID: 238164 RVA: 0x01065B4B File Offset: 0x01063D4B
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A255 RID: 238165 RVA: 0x01065B58 File Offset: 0x01063D58
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
