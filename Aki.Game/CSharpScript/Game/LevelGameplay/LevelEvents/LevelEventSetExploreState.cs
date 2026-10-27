using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B74 RID: 27508
	public class LevelEventSetExploreState : LevelEventBase
	{
		// Token: 0x0604423E RID: 279102 RVA: 0x010C9017 File Offset: 0x010C7217
		public LevelEventSetExploreState(int Id) : base(Id)
		{
		}

		// Token: 0x0604423F RID: 279103 RVA: 0x010C9020 File Offset: 0x010C7220
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				return;
			}
			ITeleControlConfig config = (inParams as SetExploreState).Config;
			if (config != null)
			{
				ETeleControlType teleControlType = config.TeleControlType;
				if (teleControlType == ETeleControlType.BigWorld)
				{
					ManipulaterModel.Instance.SetManipulateMode(ManipulaterModel.EManipulaterMode.BigWorld);
					return;
				}
				if (teleControlType == ETeleControlType.Boss)
				{
					ManipulaterModel.Instance.SetManipulateMode(ManipulaterModel.EManipulaterMode.Boss);
				}
			}
		}
	}
}
