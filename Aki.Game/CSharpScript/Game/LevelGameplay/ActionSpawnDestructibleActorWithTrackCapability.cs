using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005ADA RID: 23258
	[NullableContext(1)]
	[Nullable(0)]
	public class ActionSpawnDestructibleActorWithTrackCapability : ActionParams
	{
		// Token: 0x060393B9 RID: 234425 RVA: 0x010068E8 File Offset: 0x01004AE8
		public ActionSpawnDestructibleActorWithTrackCapability(SpawnDestructibleActorWithTrackCapability spawnDestructibleParam)
		{
			this.SpawnDestructibleParam = spawnDestructibleParam;
		}

		// Token: 0x17006D18 RID: 27928
		// (get) Token: 0x060393BA RID: 234426 RVA: 0x010068F7 File Offset: 0x01004AF7
		public SpawnDestructibleActorWithTrackCapability SpawnDestructibleParam { get; }
	}
}
