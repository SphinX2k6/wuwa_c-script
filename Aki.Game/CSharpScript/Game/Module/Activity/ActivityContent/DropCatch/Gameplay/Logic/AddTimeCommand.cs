using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200566E RID: 22126
	public class AddTimeCommand : IDropCatchCommand
	{
		// Token: 0x060369E6 RID: 223718 RVA: 0x00F3DED8 File Offset: 0x00F3C0D8
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IAddTimeCommandParams addTimeCommandParams = (IAddTimeCommandParams)@params;
			context.GetLogicContext().GetGameplayTimeMgr().AddTime(addTimeCommandParams.Time);
		}
	}
}
