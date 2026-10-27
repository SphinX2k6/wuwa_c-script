using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200672A RID: 26410
	public class PlayFlowCommand : IDropCatchCommand
	{
		// Token: 0x06041EB2 RID: 270002 RVA: 0x00FFD060 File Offset: 0x00FFB260
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IPlayFlowCommandParams playFlowCommandParams = (IPlayFlowCommandParams)@params;
			context.GetLogicContext().GetProxy().PlayFlow(playFlowCommandParams.FlowId.Split(',', StringSplitOptions.None));
		}
	}
}
