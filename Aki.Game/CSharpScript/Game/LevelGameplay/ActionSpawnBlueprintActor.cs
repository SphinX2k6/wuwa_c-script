using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AD6 RID: 23254
	[NullableContext(1)]
	[Nullable(0)]
	public class ActionSpawnBlueprintActor : ActionParams
	{
		// Token: 0x0603939A RID: 234394 RVA: 0x010067DC File Offset: 0x010049DC
		public ActionSpawnBlueprintActor(ISpawnDestructibleStoneTrackTargetWhileRotate spawnBlueprintParam)
		{
			this.SpawnBlueprintParam = spawnBlueprintParam;
		}

		// Token: 0x17006D0A RID: 27914
		// (get) Token: 0x0603939B RID: 234395 RVA: 0x010067EB File Offset: 0x010049EB
		public ISpawnDestructibleStoneTrackTargetWhileRotate SpawnBlueprintParam { get; }
	}
}
