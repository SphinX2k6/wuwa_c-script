using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E0E RID: 28174
	[NullableContext(2)]
	[Nullable(0)]
	public class GuaranteeActionBlackScreenFadeOut : GuaranteeActionBase
	{
		// Token: 0x06044B60 RID: 281440 RVA: 0x010F57F0 File Offset: 0x010F39F0
		protected override void OnExecute(ActionParams @params = null)
		{
			if (BlackScreenFadeController.Instance.NeedGuarantee)
			{
				IGuaranteeFadeInParams guaranteeFadeInParams = @params as IGuaranteeFadeInParams;
				if (guaranteeFadeInParams != null && guaranteeFadeInParams.KeepFadeAfterTreeRollBack.GetValueOrDefault())
				{
					GuaranteeContext context = this.Context;
					if (context != null && context.GuaranteeReason == EGuaranteeReason.TreeRollback)
					{
						return;
					}
				}
				global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.JYS, "保底黑幕结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				FadeBackgroundController.Instance.CloseFadeBackground();
				PlotModel.Instance.IsFadeIn = false;
				Global.CharacterCameraManager.FadeAmount = 0f;
				LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "GuaranteeActionBlackScreenFadeOut", delegate
				{
					LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectNone);
				}, new float?(1f));
				return;
			}
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.JYS, "执行到了保底黑幕结束,但因为不需要保底被return", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06044B61 RID: 281441 RVA: 0x010F58D4 File Offset: 0x010F3AD4
		protected override void OnClear(ActionParams @params = null, GeneralContext instigatorContext = null)
		{
			if (instigatorContext is GeneralLogicTreeContext)
			{
				GeneralLogicTreeContext generalLogicTreeContext = instigatorContext as GeneralLogicTreeContext;
				if (generalLogicTreeContext != null && generalLogicTreeContext.TreeIncId != 0L && GeneralLogicTreeModel.Instance != null)
				{
					BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(generalLogicTreeContext.TreeIncId), false);
					if (behaviorTree != null && behaviorTree.GetRollbackPoint() == 0)
					{
						return;
					}
				}
			}
			IGuaranteeFadeInParams guaranteeFadeInParams = @params as IGuaranteeFadeInParams;
			if (guaranteeFadeInParams != null && guaranteeFadeInParams.KeepFadeAfterTreeRollBack.GetValueOrDefault() && GeneralLogicTreeModel.Instance != null)
			{
				GeneralLogicTreeModel.Instance.AddGuaranteeActionsWhenLogicTreeRemove(EGuaranteeAction.ActionBlackScreenFadeOut, @params, instigatorContext);
			}
		}
	}
}
