using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.Plot.Sequence.NpcPerformState;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050D3 RID: 20691
	public class FlowActionSetNpcGroupPerform : FlowActionBase
	{
		// Token: 0x06034F36 RID: 216886 RVA: 0x00C8AD60 File Offset: 0x00C88F60
		protected unsafe override void OnExecute()
		{
			FlowDefineNpcGroupPerform flowDefineNpcGroupPerform = this.ActionInfo.Params as FlowDefineNpcGroupPerform;
			if (flowDefineNpcGroupPerform == null || ((flowDefineNpcGroupPerform != null) ? flowDefineNpcGroupPerform.PerformType : null) == null)
			{
				global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.JYS, "FlowActionSetNpcGroupPerform", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			IFlowDefineNpcGroupPerformType flowDefineNpcGroupPerformType = (flowDefineNpcGroupPerform != null) ? flowDefineNpcGroupPerform.PerformType : null;
			IFlowDefineNpcHandInHandPerform flowDefineNpcHandInHandPerform = flowDefineNpcGroupPerformType as IFlowDefineNpcHandInHandPerform;
			string text;
			if (flowDefineNpcHandInHandPerform == null)
			{
				IFlowDefineNpcMotorcycleSharingPerform flowDefineNpcMotorcycleSharingPerform = flowDefineNpcGroupPerformType as IFlowDefineNpcMotorcycleSharingPerform;
				if (flowDefineNpcMotorcycleSharingPerform == null)
				{
					IFlowDefineNpcCancelMotorcycleSharingPerform flowDefineNpcCancelMotorcycleSharingPerform = flowDefineNpcGroupPerformType as IFlowDefineNpcCancelMotorcycleSharingPerform;
					if (flowDefineNpcCancelMotorcycleSharingPerform == null)
					{
						IFlowDefineNpcSupportedWalkingPerform flowDefineNpcSupportedWalkingPerform = flowDefineNpcGroupPerformType as IFlowDefineNpcSupportedWalkingPerform;
						if (flowDefineNpcSupportedWalkingPerform == null)
						{
							IFlowDefineNpcCancelSupportedWalkingPerform flowDefineNpcCancelSupportedWalkingPerform = flowDefineNpcGroupPerformType as IFlowDefineNpcCancelSupportedWalkingPerform;
							if (flowDefineNpcCancelSupportedWalkingPerform == null)
							{
								text = "";
							}
							else
							{
								text = flowDefineNpcCancelSupportedWalkingPerform.Key;
							}
						}
						else
						{
							text = flowDefineNpcSupportedWalkingPerform.Key;
						}
					}
					else
					{
						text = flowDefineNpcCancelMotorcycleSharingPerform.Key;
					}
				}
				else
				{
					text = flowDefineNpcMotorcycleSharingPerform.Key;
				}
			}
			else
			{
				text = flowDefineNpcHandInHandPerform.Key;
			}
			string text2 = text;
			FName fname = new FName(text2);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "FlowActionSetNpcGroupPerform";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("keyName", fname);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			NpcRelation npcRelation = SeqNpcPerformStateManager.Instance.Capture(flowDefineNpcGroupPerform.PerformType.Type, text2);
			if (npcRelation == null)
			{
				base.FinishExecute(true, true);
				return;
			}
			SequenceModel.Instance.NpcGroupPerform.Add(fname);
			SequenceModel.Instance.NpcRelationMap[fname] = npcRelation;
			base.FinishExecute(true, true);
		}

		// Token: 0x06034F37 RID: 216887 RVA: 0x00C8AEEA File Offset: 0x00C890EA
		protected override void OnInterruptExecute()
		{
			this.OnExecute();
		}

		// Token: 0x06034F38 RID: 216888 RVA: 0x00C8AEF2 File Offset: 0x00C890F2
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
