using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MovieMode;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006105 RID: 24837
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowEnterMovieMode : LevelFlowActionBase
	{
		// Token: 0x0603B892 RID: 243858 RVA: 0x010E14DE File Offset: 0x010DF6DE
		public LevelFlowEnterMovieMode Init(EnterMovieMode params_)
		{
			this.Params = params_;
			return this;
		}

		// Token: 0x0603B893 RID: 243859 RVA: 0x010E14E8 File Offset: 0x010DF6E8
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

		// Token: 0x0603B894 RID: 243860 RVA: 0x010E15EC File Offset: 0x010DF7EC
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

		// Token: 0x0401F66B RID: 128619
		[Nullable(2)]
		private EnterMovieMode Params;
	}
}
