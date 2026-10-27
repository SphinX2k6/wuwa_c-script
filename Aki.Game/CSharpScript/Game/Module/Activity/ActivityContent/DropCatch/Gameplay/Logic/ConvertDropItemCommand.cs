using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006720 RID: 26400
	public class ConvertDropItemCommand : IDropCatchCommand
	{
		// Token: 0x06041E9E RID: 269982 RVA: 0x00FFCB7C File Offset: 0x00FFAD7C
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IConvertDropItemCommandParams convertDropItemCommandParams = (IConvertDropItemCommandParams)@params;
			context.GetLogicContext().GetGameplayDropItemMgr().ConvertDropItem(convertDropItemCommandParams.SourceItemId, convertDropItemCommandParams.TargetItemId, convertDropItemCommandParams.Duration);
		}
	}
}
