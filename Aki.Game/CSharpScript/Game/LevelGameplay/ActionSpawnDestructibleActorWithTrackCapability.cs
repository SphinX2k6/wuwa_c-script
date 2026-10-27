using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200697E RID: 27006
	[NullableContext(1)]
	[Nullable(0)]
	public class ActionSpawnDestructibleActorWithTrackCapability : ActionParams
	{
		// Token: 0x06043381 RID: 275329 RVA: 0x01062680 File Offset: 0x01060880
		public ActionSpawnDestructibleActorWithTrackCapability(SpawnDestructibleActorWithTrackCapability spawnDestructibleParam)
		{
			this.SpawnDestructibleParam = spawnDestructibleParam;
		}

		// Token: 0x17009838 RID: 38968
		// (get) Token: 0x06043382 RID: 275330 RVA: 0x0106268F File Offset: 0x0106088F
		public SpawnDestructibleActorWithTrackCapability SpawnDestructibleParam { get; }
	}
}
