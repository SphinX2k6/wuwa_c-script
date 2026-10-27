using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050A3 RID: 20643
	public class FlowActionAddPlayBubble : FlowActionBase
	{
		// Token: 0x06034E85 RID: 216709 RVA: 0x00C87EC0 File Offset: 0x00C860C0
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

		// Token: 0x06034E86 RID: 216710 RVA: 0x00C87F0C File Offset: 0x00C8610C
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}

		// Token: 0x06034E87 RID: 216711 RVA: 0x00C87F14 File Offset: 0x00C86114
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
