using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200567A RID: 22138
	public class PlayFlowCommand : IDropCatchCommand
	{
		// Token: 0x060369FE RID: 223742 RVA: 0x00F3E42C File Offset: 0x00F3C62C
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IPlayFlowCommandParams playFlowCommandParams = (IPlayFlowCommandParams)@params;
			context.GetLogicContext().GetProxy().PlayFlow(playFlowCommandParams.FlowId.Split(',', StringSplitOptions.None));
		}
	}
}
