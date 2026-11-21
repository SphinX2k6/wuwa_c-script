using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C87 RID: 23687
	public class LevelEventDestroyDynamicEntities : LevelEventBase
	{
		// Token: 0x0603A1D8 RID: 238040 RVA: 0x010621E9 File Offset: 0x010603E9
		public LevelEventDestroyDynamicEntities(int id) : base(id)
		{
		}

		// Token: 0x0603A1D9 RID: 238041 RVA: 0x010621F4 File Offset: 0x010603F4
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

		// Token: 0x0603A1DA RID: 238042 RVA: 0x010622C0 File Offset: 0x010604C0
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

		// Token: 0x0401EB78 RID: 125816
		private int CurVisionEntityCount;

		// Token: 0x0401EB79 RID: 125817
		private bool IsCheckingVisionDestroy;
	}
}
