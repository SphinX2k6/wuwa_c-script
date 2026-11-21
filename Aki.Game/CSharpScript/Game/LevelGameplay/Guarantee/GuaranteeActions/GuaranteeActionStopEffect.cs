using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02005F96 RID: 24470
	[NullableContext(2)]
	[Nullable(0)]
	public class GuaranteeActionStopEffect : GuaranteeActionBase, IGuaranteeActionComparer
	{
		// Token: 0x0603ACDA RID: 240858 RVA: 0x010A0114 File Offset: 0x0109E314
		public bool IsSameAction(ActionParams left, ActionParams right)
		{
			IGuaranteeStopEffectParams guaranteeStopEffectParams = left as IGuaranteeStopEffectParams;
			if (guaranteeStopEffectParams != null)
			{
				IGuaranteeStopEffectParams guaranteeStopEffectParams2 = right as IGuaranteeStopEffectParams;
				if (guaranteeStopEffectParams2 != null)
				{
					int? num = guaranteeStopEffectParams.EffectId;
					int? num2 = guaranteeStopEffectParams2.EffectId;
					if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
					{
						num2 = guaranteeStopEffectParams.ScreenEffectHandle;
						num = guaranteeStopEffectParams2.ScreenEffectHandle;
						if (num2.GetValueOrDefault() == num.GetValueOrDefault() & num2 != null == (num != null))
						{
							return guaranteeStopEffectParams.Mp4Name == guaranteeStopEffectParams2.Mp4Name;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0603ACDB RID: 240859 RVA: 0x010A01AC File Offset: 0x0109E3AC
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

		// Token: 0x0603ACDC RID: 240860 RVA: 0x010A0238 File Offset: 0x0109E438
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
