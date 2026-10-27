using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E16 RID: 28182
	[NullableContext(2)]
	[Nullable(0)]
	public class GuaranteeActionStopEffect : GuaranteeActionBase
	{
		// Token: 0x06044B72 RID: 281458 RVA: 0x010F5C70 File Offset: 0x010F3E70
		protected override void OnExecute(ActionParams @params = null)
		{
			IGuaranteeStopEffectParams guaranteeStopEffectParams = @params as IGuaranteeStopEffectParams;
			if (guaranteeStopEffectParams == null)
			{
				return;
			}
			if (guaranteeStopEffectParams.ScreenEffectHandle != null)
			{
				ScreenEffectModel.Instance.EndScreenEffect(guaranteeStopEffectParams.ScreenEffectHandle.Value);
			}
			if (guaranteeStopEffectParams.EffectId != null)
			{
				EffectSystem.Instance.StopEffectById(guaranteeStopEffectParams.EffectId.Value, "[GuaranteeActionStopEffect] 行为树保底销毁特效", true, null);
			}
			if (guaranteeStopEffectParams.Mp4Name != null)
			{
				VideoBpController.Instance.RemoveBp();
			}
		}

		// Token: 0x06044B73 RID: 281459 RVA: 0x010F5CFC File Offset: 0x010F3EFC
		protected override void OnClear(ActionParams @params, GeneralContext instigatorContext = null)
		{
			if (instigatorContext != null && instigatorContext.Type.GetValueOrDefault() == EGeneralContextType.GeneralLogicTree)
			{
				long treeIncId = (instigatorContext as GeneralLogicTreeContext).TreeIncId;
				if (!GeneralLogicTreeModel.Instance.GuaranteeActionsWhenLogicTreeRemove.ContainsKey(treeIncId))
				{
					GeneralLogicTreeModel.Instance.GuaranteeActionsWhenLogicTreeRemove[treeIncId] = new List<GuaranteeActionInfo>();
				}
				GeneralLogicTreeModel.Instance.GuaranteeActionsWhenLogicTreeRemove[treeIncId].Add(new GuaranteeActionInfo
				{
					Name = EGuaranteeAction.StopEffect,
					Params = @params
				});
			}
		}
	}
}
