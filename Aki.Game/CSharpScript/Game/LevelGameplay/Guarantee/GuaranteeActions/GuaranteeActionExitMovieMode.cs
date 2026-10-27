using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MovieMode;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E12 RID: 28178
	[NullableContext(2)]
	[Nullable(0)]
	public class GuaranteeActionExitMovieMode : GuaranteeActionBase
	{
		// Token: 0x06044B69 RID: 281449 RVA: 0x010F5A88 File Offset: 0x010F3C88
		protected override void OnExecute(ActionParams @params = null)
		{
			ExitMovieModeParams param = new ExitMovieModeParams
			{
				BlendTime = 1f
			};
			MovieModeController.Instance.ExitMovieMode(param, null);
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CB, "保底退出电影模式", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06044B6A RID: 281450 RVA: 0x010F5ACF File Offset: 0x010F3CCF
		protected override void OnClear(ActionParams @params = null, GeneralContext instigatorContext = null)
		{
			GeneralLogicTreeModel.Instance.AddGuaranteeActionsWhenLogicTreeRemove(EGuaranteeAction.ActionExitMovieMode, @params, instigatorContext);
		}
	}
}
