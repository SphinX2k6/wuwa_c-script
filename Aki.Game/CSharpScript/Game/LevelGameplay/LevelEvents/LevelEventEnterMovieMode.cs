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
	// Token: 0x02005C95 RID: 23701
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventEnterMovieMode : LevelEventBase
	{
		// Token: 0x0603A209 RID: 238089 RVA: 0x01063960 File Offset: 0x01061B60
		public LevelEventEnterMovieMode(int id) : base(id)
		{
		}

		// Token: 0x0603A20A RID: 238090 RVA: 0x0106396C File Offset: 0x01061B6C
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			EnterMovieMode enterMovieMode = inParams as EnterMovieMode;
			float blendTime = enterMovieMode.BorderAnimDuration ?? ((float)ConfigCommonParamById.GetIntConfig("EnterMovieModeTimeThreshold").GetValueOrDefault(1));
			EnterMovieModeParams enterMovieModeParams = new EnterMovieModeParams();
			enterMovieModeParams.BlendTime = blendTime;
			enterMovieModeParams.MovieCameraConfig = enterMovieMode.MovieCameraConfig;
			IEnableFuncConfig enableFuncConfig = enterMovieMode.EnableFuncConfig;
			enterMovieModeParams.DelayDuration = ((enableFuncConfig != null) ? enableFuncConfig.DelayDuration : null);
			IEnableFuncConfig enableFuncConfig2 = enterMovieMode.EnableFuncConfig;
			enterMovieModeParams.IsEnableEsc = ((enableFuncConfig2 != null) ? enableFuncConfig2.IsEnableEsc : null);
			IEnableFuncConfig enableFuncConfig3 = enterMovieMode.EnableFuncConfig;
			enterMovieModeParams.IsEnablePhoto = ((enableFuncConfig3 != null) ? enableFuncConfig3.IsEnablePhoto : null);
			enterMovieModeParams.IsAutoExitInFlowSequence = enterMovieMode.AutoExitInFlow;
			bool value = (GameSettingsManager.Instance.GetCurrentValue(EFunction.FlowAdaptation, true, true) ?? 0) == 0;
			enterMovieModeParams.IsBanAdaptation = new bool?(value);
			EnterMovieModeParams @params = enterMovieModeParams;
			this.ExecuteEnterMovieMode(@params, enterMovieMode.DurationType);
		}

		// Token: 0x0603A20B RID: 238091 RVA: 0x01063A80 File Offset: 0x01061C80
		private UniTask ExecuteEnterMovieMode(EnterMovieModeParams @params, [Nullable(2)] IEnterMovieModeDurationType durationType)
		{
			LevelEventEnterMovieMode.<ExecuteEnterMovieMode>d__2 <ExecuteEnterMovieMode>d__;
			<ExecuteEnterMovieMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteEnterMovieMode>d__.<>4__this = this;
			<ExecuteEnterMovieMode>d__.@params = @params;
			<ExecuteEnterMovieMode>d__.durationType = durationType;
			<ExecuteEnterMovieMode>d__.<>1__state = -1;
			<ExecuteEnterMovieMode>d__.<>t__builder.Start<LevelEventEnterMovieMode.<ExecuteEnterMovieMode>d__2>(ref <ExecuteEnterMovieMode>d__);
			return <ExecuteEnterMovieMode>d__.<>t__builder.Task;
		}

		// Token: 0x0603A20C RID: 238092 RVA: 0x01063AD3 File Offset: 0x01061CD3
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A20D RID: 238093 RVA: 0x01063AE0 File Offset: 0x01061CE0
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.ActionExitMovieMode
			};
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, this.Type, this.BaseContext, p, null);
		}
	}
}
