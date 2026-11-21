using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D0C RID: 23820
	public class LevelEventSpawnEffectV2 : LevelEventBase
	{
		// Token: 0x0603A419 RID: 238617 RVA: 0x01076577 File Offset: 0x01074777
		public LevelEventSpawnEffectV2(int id) : base(id)
		{
		}

		// Token: 0x0603A41A RID: 238618 RVA: 0x01076580 File Offset: 0x01074780
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			PlayEffect2 playEffect = inParams as PlayEffect2;
			if (playEffect == null)
			{
				return;
			}
			SpawnEffectImplementation.Instance.SpawnEffect(playEffect, context);
		}
	}
}
