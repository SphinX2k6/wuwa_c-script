using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CEC RID: 23788
	public class LevelEventSetExploreState : LevelEventBase
	{
		// Token: 0x0603A390 RID: 238480 RVA: 0x01072C8B File Offset: 0x01070E8B
		public LevelEventSetExploreState(int Id) : base(Id)
		{
		}

		// Token: 0x0603A391 RID: 238481 RVA: 0x01072C94 File Offset: 0x01070E94
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
