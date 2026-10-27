using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MovieMode;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F84 RID: 28548
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowEnterMovieMode : LevelFlowActionBase
	{
		// Token: 0x060456E4 RID: 284388 RVA: 0x011376DA File Offset: 0x011358DA
		public LevelFlowEnterMovieMode Init(EnterMovieMode params_)
		{
			this.Params = params_;
			return this;
		}

		// Token: 0x060456E5 RID: 284389 RVA: 0x011376E4 File Offset: 0x011358E4
		protected override void OnExecute()
		{
			if (this.Params == null)
			{
				base.FinishExecute(false);
				return;
			}
			float blendTime = this.Params.BorderAnimDuration ?? ((float)ConfigCommonParamById.GetIntConfig("EnterMovieModeTimeThreshold").GetValueOrDefault(1));
			EnterMovieModeParams enterMovieModeParams = new EnterMovieModeParams();
			enterMovieModeParams.BlendTime = blendTime;
			enterMovieModeParams.MovieCameraConfig = this.Params.MovieCameraConfig;
			IEnableFuncConfig enableFuncConfig = this.Params.EnableFuncConfig;
			enterMovieModeParams.DelayDuration = ((enableFuncConfig != null) ? enableFuncConfig.DelayDuration : null);
			IEnableFuncConfig enableFuncConfig2 = this.Params.EnableFuncConfig;
			enterMovieModeParams.IsEnableEsc = ((enableFuncConfig2 != null) ? enableFuncConfig2.IsEnableEsc : null);
			IEnableFuncConfig enableFuncConfig3 = this.Params.EnableFuncConfig;
			enterMovieModeParams.IsEnablePhoto = ((enableFuncConfig3 != null) ? enableFuncConfig3.IsEnablePhoto : null);
			enterMovieModeParams.IsAutoExitInFlowSequence = this.Params.AutoExitInFlow;
			EnterMovieModeParams params_ = enterMovieModeParams;
			this.ExecuteEnterMovieMode(params_, this.Params.DurationType);
		}

		// Token: 0x060456E6 RID: 284390 RVA: 0x011377E8 File Offset: 0x011359E8
		private UniTask ExecuteEnterMovieMode(IEnterMovieModeParams params_, [Nullable(2)] IEnterMovieModeDurationType durationType)
		{
			LevelFlowEnterMovieMode.<ExecuteEnterMovieMode>d__3 <ExecuteEnterMovieMode>d__;
			<ExecuteEnterMovieMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteEnterMovieMode>d__.<>4__this = this;
			<ExecuteEnterMovieMode>d__.params_ = params_;
			<ExecuteEnterMovieMode>d__.durationType = durationType;
			<ExecuteEnterMovieMode>d__.<>1__state = -1;
			<ExecuteEnterMovieMode>d__.<>t__builder.Start<LevelFlowEnterMovieMode.<ExecuteEnterMovieMode>d__3>(ref <ExecuteEnterMovieMode>d__);
			return <ExecuteEnterMovieMode>d__.<>t__builder.Task;
		}

		// Token: 0x040243B6 RID: 148406
		[Nullable(2)]
		private EnterMovieMode Params;
	}
}
