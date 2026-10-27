using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200671E RID: 26398
	public class AddTimeCommand : IDropCatchCommand
	{
		// Token: 0x06041E9A RID: 269978 RVA: 0x00FFCB0C File Offset: 0x00FFAD0C
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IAddTimeCommandParams addTimeCommandParams = (IAddTimeCommandParams)@params;
			context.GetLogicContext().GetGameplayTimeMgr().AddTime(addTimeCommandParams.Time);
		}
	}
}
