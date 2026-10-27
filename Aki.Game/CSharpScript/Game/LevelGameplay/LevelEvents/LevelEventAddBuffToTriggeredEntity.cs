using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AEF RID: 27375
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventAddBuffToTriggeredEntity : LevelEventAddBuffClientPrePerformance
	{
		// Token: 0x06043FD7 RID: 278487 RVA: 0x010AE21C File Offset: 0x010AC41C
		public LevelEventAddBuffToTriggeredEntity(int id) : base(id)
		{
		}

		// Token: 0x06043FD8 RID: 278488 RVA: 0x010AE225 File Offset: 0x010AC425
		[return: Nullable(2)]
		protected override EntityHandle GetTargetEntity(TriggerContext context)
		{
			return base.GetOtherEntity(context);
		}

		// Token: 0x06043FD9 RID: 278489 RVA: 0x010AE22E File Offset: 0x010AC42E
		protected override List<long> GetBuffIds(ActionParams inParams)
		{
			return (inParams as AddBuffToTriggeredEntity).BuffIds;
		}
	}
}
