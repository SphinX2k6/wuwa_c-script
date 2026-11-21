using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005670 RID: 22128
	public class ConvertDropItemCommand : IDropCatchCommand
	{
		// Token: 0x060369EA RID: 223722 RVA: 0x00F3DF48 File Offset: 0x00F3C148
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IConvertDropItemCommandParams convertDropItemCommandParams = (IConvertDropItemCommandParams)@params;
			context.GetLogicContext().GetGameplayDropItemMgr().ConvertDropItem(convertDropItemCommandParams.SourceItemId, convertDropItemCommandParams.TargetItemId, convertDropItemCommandParams.Duration);
		}
	}
}
