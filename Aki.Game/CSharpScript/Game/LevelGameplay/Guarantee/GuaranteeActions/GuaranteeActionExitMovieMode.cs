using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MovieMode;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02005F92 RID: 24466
	[NullableContext(2)]
	[Nullable(0)]
	public class GuaranteeActionExitMovieMode : GuaranteeActionBase
	{
		// Token: 0x0603ACD0 RID: 240848 RVA: 0x0109FEBC File Offset: 0x0109E0BC
		protected override void OnExecute(ActionParams @params = null)
		{
			ExitMovieModeParams param = new ExitMovieModeParams
			{
				BlendTime = 1f
			};
			MovieModeController.Instance.ExitMovieMode(param, null);
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CB, "保底退出电影模式", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603ACD1 RID: 240849 RVA: 0x0109FF03 File Offset: 0x0109E103
		protected override void OnClear(ActionParams @params = null, GeneralContext instigatorContext = null)
		{
			GeneralLogicTreeModel.Instance.AddGuaranteeActionsWhenLogicTreeRemove(EGuaranteeAction.ActionExitMovieMode, @params, instigatorContext);
		}
	}
}
