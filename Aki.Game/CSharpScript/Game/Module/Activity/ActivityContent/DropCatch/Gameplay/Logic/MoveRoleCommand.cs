using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006721 RID: 26401
	public class MoveRoleCommand : IDropCatchCommand
	{
		// Token: 0x06041EA0 RID: 269984 RVA: 0x00FFCBBC File Offset: 0x00FFADBC
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IMoveRoleCommandParams moveRoleCommandParams = (IMoveRoleCommandParams)@params;
			context.GetLogicContext().GetGameplayInputMgr().SetMoveDirectionCommand(moveRoleCommandParams.Direction, moveRoleCommandParams.Duration);
		}
	}
}
