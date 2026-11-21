using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C67 RID: 23655
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventAddBuffToTriggeredEntity : LevelEventAddBuffClientPrePerformance
	{
		// Token: 0x0603A129 RID: 237865 RVA: 0x01057A98 File Offset: 0x01055C98
		public LevelEventAddBuffToTriggeredEntity(int id) : base(id)
		{
		}

		// Token: 0x0603A12A RID: 237866 RVA: 0x01057AA1 File Offset: 0x01055CA1
		[return: Nullable(2)]
		protected override EntityHandle GetTargetEntity(TriggerContext context)
		{
			return base.GetOtherEntity(context);
		}

		// Token: 0x0603A12B RID: 237867 RVA: 0x01057AAA File Offset: 0x01055CAA
		protected override List<long> GetBuffIds(ActionParams inParams)
		{
			return (inParams as AddBuffToTriggeredEntity).BuffIds;
		}
	}
}
