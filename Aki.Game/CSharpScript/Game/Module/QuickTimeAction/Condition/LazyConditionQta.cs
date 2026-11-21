using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using AkiClient.Game.Aki.Data.QuickTimeAction;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02003F22 RID: 16162
	[NullableContext(1)]
	[Nullable(0)]
	public class LazyConditionQta : LazyConditionBase
	{
		// Token: 0x06028F77 RID: 167799 RVA: 0x00B7F80F File Offset: 0x00B7DA0F
		public LazyConditionQta(TLazyConditionResultCallback callback) : base(callback)
		{
		}

		// Token: 0x06028F78 RID: 167800 RVA: 0x00B7F818 File Offset: 0x00B7DA18
		public void SetQtaCondition(SQtaCondition ueCondition, SQta qtaConfig, int payloadId, bool immediatelyCheck = true)
		{
			CfgLazyConditionGroup cfgLazyConditionGroup = new CfgLazyConditionGroup();
			cfgLazyConditionGroup.ConditionFormula = ueCondition.Formula;
			cfgLazyConditionGroup.PayloadId = payloadId;
			for (int i = 0; i < ueCondition.Contents.Num(); i++)
			{
				SQtaCondition_Content sqtaCondition_Content = ueCondition.Contents.Get(i);
				if (sqtaCondition_Content != null)
				{
					if (sqtaCondition_Content.ConditionType == EQtaConditionType.检查输入)
					{
						for (int j = 0; j < qtaConfig.BaseConfig.InputConfig.Num(); j++)
						{
							SCommonQteButton scommonQteButton = qtaConfig.BaseConfig.InputConfig.Get(j);
							CfgLazyConditionForInput cfgLazyConditionForInput = new CfgLazyConditionForInput();
							cfgLazyConditionForInput.InitForQta(QtaActionNames.Get((int)scommonQteButton.Action), sqtaCondition_Content);
							cfgLazyConditionGroup.ConditionGroup.Add(cfgLazyConditionForInput);
						}
					}
					else if (sqtaCondition_Content.ConditionType == EQtaConditionType.检查Tag)
					{
						CfgLazyConditionForTag cfgLazyConditionForTag = new CfgLazyConditionForTag();
						cfgLazyConditionForTag.InitForQta(sqtaCondition_Content);
						cfgLazyConditionGroup.ConditionGroup.Add(cfgLazyConditionForTag);
					}
					else if (sqtaCondition_Content.ConditionType == EQtaConditionType.事件变化)
					{
						CfgLazyConditionForEntityEvent cfgLazyConditionForEntityEvent = new CfgLazyConditionForEntityEvent();
						cfgLazyConditionForEntityEvent.InitForQta(sqtaCondition_Content);
						cfgLazyConditionGroup.ConditionGroup.Add(cfgLazyConditionForEntityEvent);
					}
				}
			}
			base.SetCondition(cfgLazyConditionGroup, immediatelyCheck);
		}
	}
}
