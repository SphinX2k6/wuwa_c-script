using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004073 RID: 16499
	public class FlowActionAddPlayBubble : FlowActionBase
	{
		// Token: 0x06029D7E RID: 171390 RVA: 0x00BD5140 File Offset: 0x00BD3340
		protected override void OnExecute()
		{
			AddPlayBubble addPlayBubble = this.ActionInfo.Params as AddPlayBubble;
			if (addPlayBubble == null)
			{
				return;
			}
			if (addPlayBubble.EntityIds.Count == 0)
			{
				return;
			}
			CharacterDynamicFlowData data = this.CreateCharacterFlowData(addPlayBubble);
			DynamicFlowController.Instance.AddDynamicFlow(data);
			base.FinishExecute(true, true);
		}

		// Token: 0x06029D7F RID: 171391 RVA: 0x00BD518C File Offset: 0x00BD338C
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}

		// Token: 0x06029D80 RID: 171392 RVA: 0x00BD5194 File Offset: 0x00BD3394
		[NullableContext(1)]
		private CharacterDynamicFlowData CreateCharacterFlowData(AddPlayBubble flowData)
		{
			return new CharacterDynamicFlowData
			{
				MasterInfo = new DynamicFlowActorInfo
				{
					PbDataId = flowData.EntityIds[0]
				},
				BubbleData = flowData,
				Type = new EDynamicFlowType?(EDynamicFlowType.FlowAction)
			};
		}
	}
}
