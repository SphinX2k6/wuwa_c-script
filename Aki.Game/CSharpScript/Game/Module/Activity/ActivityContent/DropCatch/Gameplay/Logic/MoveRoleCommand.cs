using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005671 RID: 22129
	public class MoveRoleCommand : IDropCatchCommand
	{
		// Token: 0x060369EC RID: 223724 RVA: 0x00F3DF88 File Offset: 0x00F3C188
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IMoveRoleCommandParams moveRoleCommandParams = (IMoveRoleCommandParams)@params;
			context.GetLogicContext().GetGameplayInputMgr().SetMoveDirectionCommand(moveRoleCommandParams.Direction, moveRoleCommandParams.Duration);
		}
	}
}
