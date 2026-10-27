using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006719 RID: 26393
	public class SpawnDropItemCommand : IDropCatchCommand
	{
		// Token: 0x06041E90 RID: 269968 RVA: 0x00FFCA08 File Offset: 0x00FFAC08
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			ISpawnDropItemCommandParams spawnDropItemCommandParams = (ISpawnDropItemCommandParams)@params;
			context.GetLogicContext().GetGameplayDropItemMgr().SpawnDropItem(spawnDropItemCommandParams.ItemId, (double)spawnDropItemCommandParams.PosX, null);
		}
	}
}
