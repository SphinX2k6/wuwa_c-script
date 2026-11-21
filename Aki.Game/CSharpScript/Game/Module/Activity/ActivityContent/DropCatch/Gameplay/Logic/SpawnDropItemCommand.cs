using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005669 RID: 22121
	public class SpawnDropItemCommand : IDropCatchCommand
	{
		// Token: 0x060369DC RID: 223708 RVA: 0x00F3DDD4 File Offset: 0x00F3BFD4
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			ISpawnDropItemCommandParams spawnDropItemCommandParams = (ISpawnDropItemCommandParams)@params;
			context.GetLogicContext().GetGameplayDropItemMgr().SpawnDropItem(spawnDropItemCommandParams.ItemId, (double)spawnDropItemCommandParams.PosX, null);
		}
	}
}
