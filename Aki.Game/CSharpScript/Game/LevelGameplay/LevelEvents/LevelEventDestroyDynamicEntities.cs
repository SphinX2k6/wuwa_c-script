using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B0F RID: 27407
	public class LevelEventDestroyDynamicEntities : LevelEventBase
	{
		// Token: 0x06044086 RID: 278662 RVA: 0x010B895D File Offset: 0x010B6B5D
		public LevelEventDestroyDynamicEntities(int id) : base(id)
		{
		}

		// Token: 0x06044087 RID: 278663 RVA: 0x010B8968 File Offset: 0x010B6B68
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if ((inParams as DestroyDynamicEntities).DestroyEntitiesConfig.Type == EDynamicEntityType.VisionDisplay)
			{
				this.CurVisionEntityCount = 0;
				this.IsCheckingVisionDestroy = true;
				foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(true))
				{
					Entity entity = entityHandle.Entity;
					if (!(!entity) && !(!((entity != null) ? entity.GetComponent<CharacterVisionComponent>() : null)))
					{
						this.CurVisionEntityCount++;
						EventSystem.Instance.EmitWithTarget<Action>(entity, EEventName.VisionSummonEndByAction, delegate()
						{
							this.CurVisionEntityCount--;
							this.CheckVisionDestroyFinish();
						});
					}
				}
				this.IsCheckingVisionDestroy = false;
				this.CheckVisionDestroyFinish();
			}
		}

		// Token: 0x06044088 RID: 278664 RVA: 0x010B8A34 File Offset: 0x010B6C34
		private void CheckVisionDestroyFinish()
		{
			if (this.IsCheckingVisionDestroy)
			{
				return;
			}
			if (this.CurVisionEntityCount <= 0)
			{
				this.CurVisionEntityCount = 0;
				base.FinishExecute(true, false, true);
			}
		}

		// Token: 0x040238D6 RID: 145622
		private int CurVisionEntityCount;

		// Token: 0x040238D7 RID: 145623
		private bool IsCheckingVisionDestroy;
	}
}
