using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200697A RID: 27002
	[NullableContext(1)]
	[Nullable(0)]
	public class ActionSpawnBlueprintActor : ActionParams
	{
		// Token: 0x06043362 RID: 275298 RVA: 0x01062574 File Offset: 0x01060774
		public ActionSpawnBlueprintActor(ISpawnDestructibleStoneTrackTargetWhileRotate spawnBlueprintParam)
		{
			this.SpawnBlueprintParam = spawnBlueprintParam;
		}

		// Token: 0x1700982A RID: 38954
		// (get) Token: 0x06043363 RID: 275299 RVA: 0x01062583 File Offset: 0x01060783
		public ISpawnDestructibleStoneTrackTargetWhileRotate SpawnBlueprintParam { get; }
	}
}
