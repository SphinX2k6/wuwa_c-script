using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CDE RID: 23774
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventRogueReceiveReward : LevelEventBase
	{
		// Token: 0x0603A350 RID: 238416 RVA: 0x0106EE13 File Offset: 0x0106D013
		public LevelEventRogueReceiveReward(int id) : base(id)
		{
		}

		// Token: 0x0603A351 RID: 238417 RVA: 0x0106EE1C File Offset: 0x0106D01C
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A352 RID: 238418 RVA: 0x0106EE27 File Offset: 0x0106D027
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
		}
	}
}
