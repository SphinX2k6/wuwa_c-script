using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B94 RID: 27540
	public class LevelEventSpawnEffectV2 : LevelEventBase
	{
		// Token: 0x060442C6 RID: 279238 RVA: 0x010CC7EC File Offset: 0x010CA9EC
		public LevelEventSpawnEffectV2(int id) : base(id)
		{
		}

		// Token: 0x060442C7 RID: 279239 RVA: 0x010CC7F8 File Offset: 0x010CA9F8
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
